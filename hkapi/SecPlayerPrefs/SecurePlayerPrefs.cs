using System;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace SecPlayerPrefs
{
	// Token: 0x0200065B RID: 1627
	public class SecurePlayerPrefs : ScriptableObject
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x000DEE70 File Offset: 0x000DD070
		private static string Encrypt(string toEncrypt)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
			byte[] array = new RijndaelManaged
			{
				Key = SecurePlayerPrefs.keyArray,
				Mode = CipherMode.ECB,
				Padding = PaddingMode.PKCS7
			}.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000DEEC4 File Offset: 0x000DD0C4
		private static string Decrypt(string toDecrypt)
		{
			byte[] array = Convert.FromBase64String(toDecrypt);
			byte[] bytes = new RijndaelManaged
			{
				Key = SecurePlayerPrefs.keyArray,
				Mode = CipherMode.ECB,
				Padding = PaddingMode.PKCS7
			}.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000DEE53 File Offset: 0x000DD053
		private static string UTF8ByteArrayToString(byte[] characters)
		{
			return new UTF8Encoding().GetString(characters);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000DEE60 File Offset: 0x000DD060
		private static byte[] StringToUTF8ByteArray(string pXmlString)
		{
			return new UTF8Encoding().GetBytes(pXmlString);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x000DEF11 File Offset: 0x000DD111
		public static void SetInt(string Key, int Value)
		{
			PlayerPrefs.SetString(SecurePlayerPrefs.Encrypt(Key), SecurePlayerPrefs.Encrypt(Value.ToString()));
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000DEF2A File Offset: 0x000DD12A
		public static void SetString(string Key, string Value)
		{
			PlayerPrefs.SetString(SecurePlayerPrefs.Encrypt(Key), SecurePlayerPrefs.Encrypt(Value));
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000DEF3D File Offset: 0x000DD13D
		public static void SetFloat(string Key, float Value)
		{
			PlayerPrefs.SetString(SecurePlayerPrefs.Encrypt(Key), SecurePlayerPrefs.Encrypt(Value.ToString()));
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000DEF56 File Offset: 0x000DD156
		public static void SetBool(string Key, bool Value)
		{
			PlayerPrefs.SetString(SecurePlayerPrefs.Encrypt(Key), SecurePlayerPrefs.Encrypt(Value.ToString()));
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000DEF70 File Offset: 0x000DD170
		public static string GetString(string Key)
		{
			string @string = PlayerPrefs.GetString(SecurePlayerPrefs.Encrypt(Key));
			if (@string == "")
			{
				return "";
			}
			return SecurePlayerPrefs.Decrypt(@string);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000DEFA4 File Offset: 0x000DD1A4
		public static int GetInt(string Key)
		{
			string @string = PlayerPrefs.GetString(SecurePlayerPrefs.Encrypt(Key));
			if (@string == "")
			{
				return 0;
			}
			return int.Parse(SecurePlayerPrefs.Decrypt(@string));
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x000DEFD8 File Offset: 0x000DD1D8
		public static float GetFloat(string Key)
		{
			string @string = PlayerPrefs.GetString(SecurePlayerPrefs.Encrypt(Key));
			if (@string == "")
			{
				return 0f;
			}
			return float.Parse(SecurePlayerPrefs.Decrypt(@string));
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000DF010 File Offset: 0x000DD210
		public static bool GetBool(string Key)
		{
			string @string = PlayerPrefs.GetString(SecurePlayerPrefs.Encrypt(Key));
			return !(@string == "") && bool.Parse(SecurePlayerPrefs.Decrypt(@string));
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000DF043 File Offset: 0x000DD243
		public static void DeleteKey(string Key)
		{
			PlayerPrefs.DeleteKey(SecurePlayerPrefs.Encrypt(Key));
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0005A484 File Offset: 0x00058684
		public static void DeleteAll()
		{
			PlayerPrefs.DeleteAll();
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0005A5A5 File Offset: 0x000587A5
		public static void Save()
		{
			PlayerPrefs.Save();
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000DF050 File Offset: 0x000DD250
		public static bool HasKey(string Key)
		{
			return PlayerPrefs.HasKey(SecurePlayerPrefs.Encrypt(Key));
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000DF05D File Offset: 0x000DD25D
		// Note: this type is marked as 'beforefieldinit'.
		static SecurePlayerPrefs()
		{
			SecurePlayerPrefs.Salt = new byte[]
			{
				10,
				20,
				30,
				40,
				50,
				60,
				70,
				80,
				90,
				12,
				13,
				14,
				15,
				16,
				17,
				18,
				19
			};
			SecurePlayerPrefs.keyArray = Encoding.UTF8.GetBytes("UKu52ePUBwetZ9wNX88o54dnfKRu0T1l");
		}

		// Token: 0x04002B77 RID: 11127
		private static readonly byte[] Salt;

		// Token: 0x04002B78 RID: 11128
		private static byte[] keyArray;
	}
}
