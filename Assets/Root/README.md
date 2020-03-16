# Readme

## Requirements
[![Unity 2018.3+](https://img.shields.io/badge/unity-2018.3+-brightgreen.svg?style=flat&logo=unity&cacheSeconds=2592000)](https://unity3d.com/get-unity/download/archive)
[![.Net 2.0 Scripting Runtime](https://img.shields.io/badge/.NET-2.0-blueviolet.svg?style=flat&cacheSeconds=2592000)](https://docs.unity3d.com/2019.1/Documentation/Manual/ScriptingRuntimeUpgrade.html)

## Installation

## Usage

### AES (CBC mode)

```csharp
		 AESEncryptor temp = new AESEncryptor("1234", EBits.Bits128);
        string data = "raw data contains in here 2019";
        Stopwatch watch = new Stopwatch();

        byte[] byteData = Encoding.UTF8.GetBytes(data);
        var encrypted = temp.Encrypt(byteData);

```

### MD5

```csharp
	string result = MD5.GetHashString(data);
	string result = MD5.GetHashString(data, Encoding.UTF8);
	byte[] result = MD5.GetHash(data);
	byte[] result = MD5.GetHash(data, Encoding.UTF8);


	var source = "Md5 hash data";      
    MD5.GetHashString(source);

```

### Base64Extensions

```csharp
	string Base64Encrypt(string input);
	string Base64Encrypt(string input, Encoding encoding);
	string Base64Decrypt(string input);
	string Base64Decrypt(string input, Encoding encoding);
```


### HMACSHA

```csharp
	string HMACSHA1(string source, string key);
	string HMACSHA256(string source, string key);
	string HMACSHA384(string source, string key);
	string HMACSHA512(string source, string key);
```

### MachineKey

```csharp
	MKEncrypt.ValidationKey(128);
	MKEncrypt.DecryptionKey(48);
```
