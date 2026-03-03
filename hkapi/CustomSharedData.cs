using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200035C RID: 860
public abstract class CustomSharedData : Platform.ISharedData
{
	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06001378 RID: 4984 RVA: 0x00058440 File Offset: 0x00056640
	public Dictionary<string, string> SharedData
	{
		get
		{
			return this.sharedData;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06001379 RID: 4985 RVA: 0x00058448 File Offset: 0x00056648
	// (set) Token: 0x0600137A RID: 4986 RVA: 0x00058450 File Offset: 0x00056650
	public CustomSharedData.IResponder Responder
	{
		get
		{
			return this.responder;
		}
		set
		{
			this.responder = value;
		}
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00058459 File Offset: 0x00056659
	protected CustomSharedData()
	{
		this.sharedData = new Dictionary<string, string>();
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x0005846C File Offset: 0x0005666C
	public void LoadFromJSON(string str)
	{
		JsonUtility.FromJson<CustomSharedData.SharedDataSerializableBlob>(str).ToSharedData(this.sharedData);
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x0005847F File Offset: 0x0005667F
	public string SaveToJSON()
	{
		return JsonUtility.ToJson(CustomSharedData.SharedDataSerializableBlob.FromSharedData(this.sharedData));
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00058491 File Offset: 0x00056691
	public bool HasKey(string key)
	{
		return this.sharedData.ContainsKey(key);
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x0005849F File Offset: 0x0005669F
	public void DeleteKey(string key)
	{
		if (this.sharedData.Remove(key))
		{
			this.OnModified();
		}
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x000584B5 File Offset: 0x000566B5
	public void DeleteAll()
	{
		if (this.sharedData.Count > 0)
		{
			this.sharedData.Clear();
			this.OnModified();
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x000584D6 File Offset: 0x000566D6
	public bool GetBool(string key, bool def)
	{
		return this.GetInt(key, def ? 1 : 0) > 0;
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x000584E9 File Offset: 0x000566E9
	public void SetBool(string key, bool val)
	{
		this.SetInt(key, val ? 1 : 0);
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x000584FC File Offset: 0x000566FC
	public int GetInt(string key, int def)
	{
		string s;
		if (!this.sharedData.TryGetValue(key, out s))
		{
			return def;
		}
		int result;
		if (!int.TryParse(s, out result))
		{
			return def;
		}
		return result;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00058528 File Offset: 0x00056728
	public void SetInt(string key, int val)
	{
		string text = val.ToString();
		if (!this.sharedData.ContainsKey(key) || this.sharedData[key] != text)
		{
			this.sharedData[key] = text;
			this.OnModified();
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00058574 File Offset: 0x00056774
	public float GetFloat(string key, float def)
	{
		string s;
		if (!this.sharedData.TryGetValue(key, out s))
		{
			return def;
		}
		float result;
		if (!float.TryParse(s, out result))
		{
			return def;
		}
		return result;
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x000585A0 File Offset: 0x000567A0
	public void SetFloat(string key, float val)
	{
		string text = val.ToString();
		if (!this.sharedData.ContainsKey(key) || this.sharedData[key] != text)
		{
			this.sharedData[key] = text;
			this.OnModified();
		}
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x000585EC File Offset: 0x000567EC
	public string GetString(string key, string def)
	{
		string result;
		if (!this.sharedData.TryGetValue(key, out result))
		{
			return def;
		}
		return result;
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x0005860C File Offset: 0x0005680C
	public void SetString(string key, string val)
	{
		if (!this.sharedData.ContainsKey(key) || this.sharedData[key] != val)
		{
			this.sharedData[key] = val;
			this.OnModified();
		}
	}

	// Token: 0x06001389 RID: 5001
	public abstract void Save();

	// Token: 0x0600138A RID: 5002 RVA: 0x00058643 File Offset: 0x00056843
	protected virtual void OnModified()
	{
		if (this.responder != null)
		{
			this.responder.OnModified(this);
		}
	}

	// Token: 0x040012AA RID: 4778
	private Dictionary<string, string> sharedData;

	// Token: 0x040012AB RID: 4779
	private CustomSharedData.IResponder responder;

	// Token: 0x0200035D RID: 861
	[Serializable]
	private class SharedDataSerializableBlob
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x0005865C File Offset: 0x0005685C
		public static CustomSharedData.SharedDataSerializableBlob FromSharedData(Dictionary<string, string> sharedData)
		{
			List<CustomSharedData.SharedDataSerializablePair> list = new List<CustomSharedData.SharedDataSerializablePair>();
			foreach (KeyValuePair<string, string> keyValuePair in sharedData)
			{
				if (keyValuePair.Key == null)
				{
					Debug.LogErrorFormat("Null key found in shared data", Array.Empty<object>());
				}
				else if (keyValuePair.Value == null)
				{
					Debug.LogErrorFormat("Null value for key '{0}' found in shared data", Array.Empty<object>());
				}
				else
				{
					list.Add(new CustomSharedData.SharedDataSerializablePair
					{
						Key = keyValuePair.Key,
						Value = keyValuePair.Value
					});
				}
			}
			return new CustomSharedData.SharedDataSerializableBlob
			{
				pairs = list.ToArray()
			};
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0005871C File Offset: 0x0005691C
		public void ToSharedData(Dictionary<string, string> sharedData)
		{
			sharedData.Clear();
			int num = 0;
			while (this.pairs != null && num < this.pairs.Length)
			{
				CustomSharedData.SharedDataSerializablePair sharedDataSerializablePair = this.pairs[num];
				if (sharedDataSerializablePair.Key == null)
				{
					Debug.LogErrorFormat("Null key found in shared data", Array.Empty<object>());
				}
				else if (sharedDataSerializablePair.Value == null)
				{
					Debug.LogErrorFormat("Null value for key '{0}' found in shared data", new object[]
					{
						sharedDataSerializablePair.Key
					});
				}
				else if (sharedData.ContainsKey(sharedDataSerializablePair.Key))
				{
					Debug.LogErrorFormat("Duplicate key '{0}' found in shared data", new object[]
					{
						sharedDataSerializablePair.Key
					});
				}
				else
				{
					sharedData.Add(sharedDataSerializablePair.Key, sharedDataSerializablePair.Value);
				}
				num++;
			}
		}

		// Token: 0x040012AC RID: 4780
		[SerializeField]
		private CustomSharedData.SharedDataSerializablePair[] pairs;
	}

	// Token: 0x0200035E RID: 862
	[Serializable]
	private struct SharedDataSerializablePair
	{
		// Token: 0x040012AD RID: 4781
		public string Key;

		// Token: 0x040012AE RID: 4782
		public string Value;
	}

	// Token: 0x0200035F RID: 863
	public interface IResponder
	{
		// Token: 0x0600138E RID: 5006
		void OnModified(CustomSharedData sharedData);
	}
}
