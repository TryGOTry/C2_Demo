package encode

import (
	"crypto/aes"
	"encoding/hex"
)
//AEs加密


func AESEncrypt(src []byte, key []byte) (encrypted []byte) {
	cipher, _ := aes.NewCipher(generateKey(key))
	length := (len(src) + aes.BlockSize) / aes.BlockSize
	plain := make([]byte, length*aes.BlockSize)
	copy(plain, src)
	pad := byte(len(plain) - len(src))
	for i := len(src); i < len(plain); i++ {
		plain[i] = pad
	}
	encrypted = make([]byte, len(plain))
	// 分组分块加密
	for bs, be := 0, cipher.BlockSize(); bs <= len(src); bs, be = bs+cipher.BlockSize(), be+cipher.BlockSize() {
		cipher.Encrypt(encrypted[bs:be], plain[bs:be])
	}

	return encrypted
}

func AESDecrypt(encrypted []byte, key []byte) (decrypted []byte) {
	cipher, _ := aes.NewCipher(generateKey(key))
	decrypted = make([]byte, len(encrypted))
	//
	for bs, be := 0, cipher.BlockSize(); bs < len(encrypted); bs, be = bs+cipher.BlockSize(), be+cipher.BlockSize() {
		cipher.Decrypt(decrypted[bs:be], encrypted[bs:be])
	}

	trim := 0
	if len(decrypted) > 0 {
		trim = len(decrypted) - int(decrypted[len(decrypted)-1])
	}

	return decrypted[:trim]
}

func generateKey(key []byte) (genKey []byte) {
	genKey = make([]byte, 16)
	copy(genKey, key)
	for i := 16; i < len(key); {
		for j := 0; j < 16 && i < len(key); j, i = j+1, i+1 {
			genKey[j] ^= key[i]
		}
	}
	return genKey
}

func Encodestr(str string, uuid string) string {
	uuidnew := uuid[len(uuid)-16:]
	//fmt.Println(uuidnew)
	msgstr := []byte(str)
	key := []byte(uuidnew)
	//fmt.Println(uuidnew)
	a := AESEncrypt(msgstr, key)

	b := hex.EncodeToString(a)
	return b
}
func Decodestr(str string, uuid string) string {
	//fmt.Println("hex:", str)
	a, _ := hex.DecodeString(str)
	//fmt.Println(string(a))
	uuidnew := uuid[len(uuid)-16:]
	msgstr := []byte(a)
	key := []byte(uuidnew)
	a = AESDecrypt(msgstr, key)
	//fmt.Println("解密:",string(a))
	return string(a)
}