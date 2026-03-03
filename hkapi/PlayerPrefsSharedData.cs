using System;
using System.Security.Cryptography;
using UnityEngine;

// Token: 0x02000385 RID: 901
public class PlayerPrefsSharedData : Platform.ISharedData
{
	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0005A3C8 File Offset: 0x000585C8
	public bool IsEncrypted
	{
		get
		{
			return this.cryptoSettings != null;
		}
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0005A3D4 File Offset: 0x000585D4
	public PlayerPrefsSharedData(byte[] encryptionKey)
	{
		if (encryptionKey == null)
		{
			this.cryptoSettings = null;
			return;
		}
		this.cryptoSettings = new RijndaelManaged();
		this.cryptoSettings.Key = encryptionKey;
		this.cryptoSettings.Mode = CipherMode.ECB;
		this.cryptoSettings.Padding = PaddingMode.PKCS7;
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x0005A424 File Offset: 0x00058624
	private string ReadEncrypted(string key)
	{
		string @string = PlayerPrefs.GetString(Encryption.Encrypt(key), "");
		if (string.IsNullOrEmpty(@string))
		{
			return null;
		}
		return Encryption.Decrypt(@string);
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x0005A454 File Offset: 0x00058654
	private void WriteEncrypted(string key, string val)
	{
		string key2 = Encryption.Encrypt(key);
		string value = Encryption.Encrypt(val);
		PlayerPrefs.SetString(key2, value);
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x0005A474 File Offset: 0x00058674
	public bool HasKey(string key)
	{
		return PlayerPrefs.HasKey(key);
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x0005A47C File Offset: 0x0005867C
	public void DeleteKey(string key)
	{
		PlayerPrefs.DeleteKey(key);
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0005A484 File Offset: 0x00058684
	public void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x0005A48B File Offset: 0x0005868B
	public bool GetBool(string key, bool def)
	{
		return this.GetInt(key, def ? 1 : 0) > 0;
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x0005A49E File Offset: 0x0005869E
	public void SetBool(string key, bool val)
	{
		this.SetInt(key, val ? 1 : 0);
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x0005A4B0 File Offset: 0x000586B0
	public int GetInt(string key, int def)
	{
		if (!this.IsEncrypted)
		{
			return PlayerPrefs.GetInt(key, def);
		}
		string text = this.ReadEncrypted(key);
		if (text == null)
		{
			return def;
		}
		int result;
		if (!int.TryParse(text, out result))
		{
			return def;
		}
		return result;
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x0005A4E7 File Offset: 0x000586E7
	public void SetInt(string key, int val)
	{
		if (this.IsEncrypted)
		{
			this.WriteEncrypted(key, val.ToString());
			return;
		}
		PlayerPrefs.SetInt(key, val);
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x0005A508 File Offset: 0x00058708
	public float GetFloat(string key, float def)
	{
		if (!this.IsEncrypted)
		{
			return PlayerPrefs.GetFloat(key, def);
		}
		string text = this.ReadEncrypted(key);
		if (text == null)
		{
			return def;
		}
		float result;
		if (!float.TryParse(text, out result))
		{
			return def;
		}
		return result;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x0005A53F File Offset: 0x0005873F
	public void SetFloat(string key, float val)
	{
		if (this.IsEncrypted)
		{
			this.WriteEncrypted(key, val.ToString());
			return;
		}
		PlayerPrefs.SetFloat(key, val);
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x0005A560 File Offset: 0x00058760
	public string GetString(string key, string def)
	{
		if (!this.IsEncrypted)
		{
			return PlayerPrefs.GetString(key, def);
		}
		string text = this.ReadEncrypted(key);
		if (text == null)
		{
			return def;
		}
		return text;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x0005A58B File Offset: 0x0005878B
	public void SetString(string key, string val)
	{
		if (this.IsEncrypted)
		{
			this.WriteEncrypted(key, val);
			return;
		}
		PlayerPrefs.SetString(key, val);
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x0005A5A5 File Offset: 0x000587A5
	public void Save()
	{
		PlayerPrefs.Save();
	}

	// Token: 0x04001316 RID: 4886
	private readonly RijndaelManaged cryptoSettings;
}
