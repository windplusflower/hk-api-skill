using System;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020004FE RID: 1278
public class StringEncrypt
{
	// Token: 0x06001C2D RID: 7213 RVA: 0x000854A8 File Offset: 0x000836A8
	public static string EncryptData(string toEncrypt)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
		byte[] array = new RijndaelManaged
		{
			Key = StringEncrypt.keyArray,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
		return Convert.ToBase64String(array, 0, array.Length);
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x000854FC File Offset: 0x000836FC
	public static string DecryptData(string toDecrypt)
	{
		byte[] array = Convert.FromBase64String(toDecrypt);
		byte[] bytes = new RijndaelManaged
		{
			Key = StringEncrypt.keyArray,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		}.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x00085549 File Offset: 0x00083749
	// Note: this type is marked as 'beforefieldinit'.
	static StringEncrypt()
	{
		StringEncrypt.keyArray = Encoding.UTF8.GetBytes("UKu52ePUBwetZ9wNX88o54dnfKRu0T1l");
	}

	// Token: 0x040021EB RID: 8683
	private static byte[] keyArray;
}
