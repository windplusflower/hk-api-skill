using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020004D8 RID: 1240
public static class Encryption
{
	// Token: 0x06001B68 RID: 7016 RVA: 0x00083608 File Offset: 0x00081808
	public static byte[] Encrypt(byte[] decryptedBytes)
	{
		byte[] result;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Key = Encryption.KeyArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			result = rijndaelManaged.CreateEncryptor().TransformFinalBlock(decryptedBytes, 0, decryptedBytes.Length);
		}
		return result;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00083664 File Offset: 0x00081864
	public static byte[] Decrypt(byte[] encryptedBytes)
	{
		byte[] result;
		using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
		{
			rijndaelManaged.Key = Encryption.KeyArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			result = rijndaelManaged.CreateDecryptor().TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
		}
		return result;
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000836C0 File Offset: 0x000818C0
	public static string Encrypt(string unencryptedString)
	{
		byte[] array = Encryption.Encrypt(Encoding.UTF8.GetBytes(unencryptedString));
		return Convert.ToBase64String(array, 0, array.Length);
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x000836E8 File Offset: 0x000818E8
	public static string Decrypt(string encryptedString)
	{
		byte[] bytes = Encryption.Decrypt(Convert.FromBase64String(encryptedString));
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x0008370C File Offset: 0x0008190C
	// Note: this type is marked as 'beforefieldinit'.
	static Encryption()
	{
		Encryption.KeyArray = Encoding.UTF8.GetBytes("UKu52ePUBwetZ9wNX88o54dnfKRu0T1l");
	}

	// Token: 0x04002193 RID: 8595
	private static readonly byte[] KeyArray;
}
