using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class INIParser
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
	public string FileName
	{
		get
		{
			return this.m_FileName;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002060 File Offset: 0x00000260
	public string iniString
	{
		get
		{
			return this.m_iniString;
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
	public void Open(string path)
	{
		this.m_FileName = path;
		if (File.Exists(this.m_FileName))
		{
			this.m_iniString = File.ReadAllText(this.m_FileName);
		}
		else
		{
			File.Create(this.m_FileName).Close();
			this.m_iniString = "";
		}
		this.Initialize(this.m_iniString, false);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020C4 File Offset: 0x000002C4
	public void Open(TextAsset name)
	{
		if (name == null)
		{
			this.error = 1;
			this.m_iniString = "";
			this.m_FileName = null;
			this.Initialize(this.m_iniString, false);
			return;
		}
		this.m_FileName = Application.persistentDataPath + name.name;
		if (File.Exists(this.m_FileName))
		{
			this.m_iniString = File.ReadAllText(this.m_FileName);
		}
		else
		{
			this.m_iniString = name.text;
		}
		this.Initialize(this.m_iniString, false);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002150 File Offset: 0x00000350
	public void OpenFromString(string str)
	{
		this.m_FileName = null;
		this.Initialize(str, false);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002060 File Offset: 0x00000260
	public override string ToString()
	{
		return this.m_iniString;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002161 File Offset: 0x00000361
	private void Initialize(string iniString, bool AutoFlush)
	{
		this.m_iniString = iniString;
		this.m_AutoFlush = AutoFlush;
		this.Refresh();
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002178 File Offset: 0x00000378
	public void Close()
	{
		object @lock = this.m_Lock;
		lock (@lock)
		{
			this.PerformFlush();
			this.m_FileName = null;
			this.m_iniString = null;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000021C8 File Offset: 0x000003C8
	private string ParseSectionName(string Line)
	{
		if (!Line.StartsWith("["))
		{
			return null;
		}
		if (!Line.EndsWith("]"))
		{
			return null;
		}
		if (Line.Length < 3)
		{
			return null;
		}
		return Line.Substring(1, Line.Length - 2);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002204 File Offset: 0x00000404
	private bool ParseKeyValuePair(string Line, ref string Key, ref string Value)
	{
		int num;
		if ((num = Line.IndexOf('=')) <= 0)
		{
			return false;
		}
		int num2 = Line.Length - num - 1;
		Key = Line.Substring(0, num).Trim();
		if (Key.Length <= 0)
		{
			return false;
		}
		Value = ((num2 > 0) ? Line.Substring(num + 1, num2).Trim() : "");
		return true;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002264 File Offset: 0x00000464
	private bool isComment(string Line)
	{
		string text = null;
		string text2 = null;
		return this.ParseSectionName(Line) == null && !this.ParseKeyValuePair(Line, ref text, ref text2);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002290 File Offset: 0x00000490
	private void Refresh()
	{
		object @lock = this.m_Lock;
		lock (@lock)
		{
			StringReader stringReader = null;
			try
			{
				this.m_Sections.Clear();
				this.m_Modified.Clear();
				stringReader = new StringReader(this.m_iniString);
				Dictionary<string, string> dictionary = null;
				string key = null;
				string value = null;
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					text = text.Trim();
					string text2 = this.ParseSectionName(text);
					if (text2 != null)
					{
						if (this.m_Sections.ContainsKey(text2))
						{
							dictionary = null;
						}
						else
						{
							dictionary = new Dictionary<string, string>();
							this.m_Sections.Add(text2, dictionary);
						}
					}
					else if (dictionary != null && this.ParseKeyValuePair(text, ref key, ref value) && !dictionary.ContainsKey(key))
					{
						dictionary.Add(key, value);
					}
				}
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002384 File Offset: 0x00000584
	private void PerformFlush()
	{
		if (!this.m_CacheModified)
		{
			return;
		}
		this.m_CacheModified = false;
		StringWriter stringWriter = new StringWriter();
		try
		{
			Dictionary<string, string> dictionary = null;
			Dictionary<string, string> dictionary2 = null;
			StringReader stringReader = null;
			try
			{
				stringReader = new StringReader(this.m_iniString);
				string text = null;
				string value = null;
				bool flag = true;
				bool flag2 = false;
				string key = null;
				string text2 = null;
				while (flag)
				{
					string text3 = stringReader.ReadLine();
					flag = (text3 != null);
					bool flag3;
					string text4;
					if (flag)
					{
						flag3 = true;
						text3 = text3.Trim();
						text4 = this.ParseSectionName(text3);
					}
					else
					{
						flag3 = false;
						text4 = null;
					}
					if (text4 != null || !flag)
					{
						if (dictionary != null && dictionary.Count > 0)
						{
							StringBuilder stringBuilder = stringWriter.GetStringBuilder();
							while (stringBuilder[stringBuilder.Length - 1] == '\n' || stringBuilder[stringBuilder.Length - 1] == '\r')
							{
								stringBuilder.Length--;
							}
							stringWriter.WriteLine();
							foreach (string text5 in dictionary.Keys)
							{
								if (dictionary.TryGetValue(text5, out value))
								{
									stringWriter.Write(text5);
									stringWriter.Write('=');
									stringWriter.WriteLine(value);
								}
							}
							stringWriter.WriteLine();
							dictionary.Clear();
						}
						if (flag && !this.m_Modified.TryGetValue(text4, out dictionary))
						{
							dictionary = null;
						}
					}
					else if (dictionary != null && this.ParseKeyValuePair(text3, ref text, ref value) && dictionary.TryGetValue(text, out value))
					{
						flag3 = false;
						dictionary.Remove(text);
						stringWriter.Write(text);
						stringWriter.Write('=');
						stringWriter.WriteLine(value);
					}
					if (flag3)
					{
						if (text4 != null)
						{
							if (!this.m_Sections.ContainsKey(text4))
							{
								flag2 = true;
								dictionary2 = null;
							}
							else
							{
								flag2 = false;
								this.m_Sections.TryGetValue(text4, out dictionary2);
							}
						}
						else if (dictionary2 != null && this.ParseKeyValuePair(text3, ref key, ref text2))
						{
							flag2 = !dictionary2.ContainsKey(key);
						}
					}
					if (flag3 && !this.isComment(text3) && !flag2)
					{
						stringWriter.WriteLine(text3);
					}
				}
				stringReader.Close();
				stringReader = null;
			}
			finally
			{
				if (stringReader != null)
				{
					stringReader.Close();
				}
				stringReader = null;
			}
			foreach (KeyValuePair<string, Dictionary<string, string>> keyValuePair in this.m_Modified)
			{
				dictionary = keyValuePair.Value;
				if (dictionary.Count > 0)
				{
					stringWriter.WriteLine();
					stringWriter.Write('[');
					stringWriter.Write(keyValuePair.Key);
					stringWriter.WriteLine(']');
					foreach (KeyValuePair<string, string> keyValuePair2 in dictionary)
					{
						stringWriter.Write(keyValuePair2.Key);
						stringWriter.Write('=');
						stringWriter.WriteLine(keyValuePair2.Value);
					}
					dictionary.Clear();
				}
			}
			this.m_Modified.Clear();
			this.m_iniString = stringWriter.ToString();
			stringWriter.Close();
			stringWriter = null;
			if (this.m_FileName != null)
			{
				File.WriteAllText(this.m_FileName, this.m_iniString);
			}
		}
		finally
		{
			if (stringWriter != null)
			{
				stringWriter.Close();
			}
			stringWriter = null;
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002734 File Offset: 0x00000934
	public bool IsSectionExists(string SectionName)
	{
		return this.m_Sections.ContainsKey(SectionName);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002744 File Offset: 0x00000944
	public bool IsKeyExists(string SectionName, string Key)
	{
		if (this.m_Sections.ContainsKey(SectionName))
		{
			Dictionary<string, string> dictionary;
			this.m_Sections.TryGetValue(SectionName, out dictionary);
			return dictionary.ContainsKey(Key);
		}
		return false;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002778 File Offset: 0x00000978
	public void SectionDelete(string SectionName)
	{
		if (this.IsSectionExists(SectionName))
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_CacheModified = true;
				this.m_Sections.Remove(SectionName);
				this.m_Modified.Remove(SectionName);
				if (this.m_AutoFlush)
				{
					this.PerformFlush();
				}
			}
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000027EC File Offset: 0x000009EC
	public void KeyDelete(string SectionName, string Key)
	{
		if (this.IsKeyExists(SectionName, Key))
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_CacheModified = true;
				Dictionary<string, string> dictionary;
				this.m_Sections.TryGetValue(SectionName, out dictionary);
				dictionary.Remove(Key);
				if (this.m_Modified.TryGetValue(SectionName, out dictionary))
				{
					dictionary.Remove(SectionName);
				}
				if (this.m_AutoFlush)
				{
					this.PerformFlush();
				}
			}
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002874 File Offset: 0x00000A74
	public string ReadValue(string SectionName, string Key, string DefaultValue)
	{
		object @lock = this.m_Lock;
		string result;
		lock (@lock)
		{
			Dictionary<string, string> dictionary;
			string text;
			if (!this.m_Sections.TryGetValue(SectionName, out dictionary))
			{
				result = DefaultValue;
			}
			else if (!dictionary.TryGetValue(Key, out text))
			{
				result = DefaultValue;
			}
			else
			{
				result = text;
			}
		}
		return result;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000028D8 File Offset: 0x00000AD8
	public void WriteValue(string SectionName, string Key, string Value)
	{
		object @lock = this.m_Lock;
		lock (@lock)
		{
			this.m_CacheModified = true;
			Dictionary<string, string> dictionary;
			if (!this.m_Sections.TryGetValue(SectionName, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.m_Sections.Add(SectionName, dictionary);
			}
			if (dictionary.ContainsKey(Key))
			{
				dictionary.Remove(Key);
			}
			dictionary.Add(Key, Value);
			if (!this.m_Modified.TryGetValue(SectionName, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				this.m_Modified.Add(SectionName, dictionary);
			}
			if (dictionary.ContainsKey(Key))
			{
				dictionary.Remove(Key);
			}
			dictionary.Add(Key, Value);
			if (this.m_AutoFlush)
			{
				this.PerformFlush();
			}
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000029A0 File Offset: 0x00000BA0
	private string EncodeByteArray(byte[] Value)
	{
		if (Value == null)
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < Value.Length; i++)
		{
			string text = Convert.ToString(Value[i], 16);
			int length = text.Length;
			if (length > 2)
			{
				stringBuilder.Append(text.Substring(length - 2, 2));
			}
			else
			{
				if (length < 2)
				{
					stringBuilder.Append("0");
				}
				stringBuilder.Append(text);
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002A14 File Offset: 0x00000C14
	private byte[] DecodeByteArray(string Value)
	{
		if (Value == null)
		{
			return null;
		}
		int num = Value.Length;
		if (num < 2)
		{
			return new byte[0];
		}
		num /= 2;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Convert.ToByte(Value.Substring(i * 2, 2), 16);
		}
		return array;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002A64 File Offset: 0x00000C64
	public bool ReadValue(string SectionName, string Key, bool DefaultValue)
	{
		int num;
		if (int.TryParse(this.ReadValue(SectionName, Key, DefaultValue.ToString(CultureInfo.InvariantCulture)), out num))
		{
			return num != 0;
		}
		return DefaultValue;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002A94 File Offset: 0x00000C94
	public int ReadValue(string SectionName, string Key, int DefaultValue)
	{
		int result;
		if (int.TryParse(this.ReadValue(SectionName, Key, DefaultValue.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return DefaultValue;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002ACC File Offset: 0x00000CCC
	public long ReadValue(string SectionName, string Key, long DefaultValue)
	{
		long result;
		if (long.TryParse(this.ReadValue(SectionName, Key, DefaultValue.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return DefaultValue;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002B04 File Offset: 0x00000D04
	public double ReadValue(string SectionName, string Key, double DefaultValue)
	{
		double result;
		if (double.TryParse(this.ReadValue(SectionName, Key, DefaultValue.ToString(CultureInfo.InvariantCulture)), NumberStyles.Any, CultureInfo.InvariantCulture, out result))
		{
			return result;
		}
		return DefaultValue;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002B3C File Offset: 0x00000D3C
	public byte[] ReadValue(string SectionName, string Key, byte[] DefaultValue)
	{
		string value = this.ReadValue(SectionName, Key, this.EncodeByteArray(DefaultValue));
		byte[] result;
		try
		{
			result = this.DecodeByteArray(value);
		}
		catch (FormatException)
		{
			result = DefaultValue;
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002B7C File Offset: 0x00000D7C
	public DateTime ReadValue(string SectionName, string Key, DateTime DefaultValue)
	{
		DateTime result;
		if (DateTime.TryParse(this.ReadValue(SectionName, Key, DefaultValue.ToString(CultureInfo.InvariantCulture)), CultureInfo.InvariantCulture, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AssumeLocal, out result))
		{
			return result;
		}
		return DefaultValue;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002BB0 File Offset: 0x00000DB0
	public void WriteValue(string SectionName, string Key, bool Value)
	{
		this.WriteValue(SectionName, Key, Value ? "1" : "0");
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002BC9 File Offset: 0x00000DC9
	public void WriteValue(string SectionName, string Key, int Value)
	{
		this.WriteValue(SectionName, Key, Value.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002BDF File Offset: 0x00000DDF
	public void WriteValue(string SectionName, string Key, long Value)
	{
		this.WriteValue(SectionName, Key, Value.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002BF5 File Offset: 0x00000DF5
	public void WriteValue(string SectionName, string Key, double Value)
	{
		this.WriteValue(SectionName, Key, Value.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002C0B File Offset: 0x00000E0B
	public void WriteValue(string SectionName, string Key, byte[] Value)
	{
		this.WriteValue(SectionName, Key, this.EncodeByteArray(Value));
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002C1C File Offset: 0x00000E1C
	public void WriteValue(string SectionName, string Key, DateTime Value)
	{
		this.WriteValue(SectionName, Key, Value.ToString(CultureInfo.InvariantCulture));
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002C32 File Offset: 0x00000E32
	public INIParser()
	{
		this.m_Lock = new object();
		this.m_Sections = new Dictionary<string, Dictionary<string, string>>();
		this.m_Modified = new Dictionary<string, Dictionary<string, string>>();
		base..ctor();
	}

	// Token: 0x04000001 RID: 1
	public int error;

	// Token: 0x04000002 RID: 2
	private object m_Lock;

	// Token: 0x04000003 RID: 3
	private string m_FileName;

	// Token: 0x04000004 RID: 4
	private string m_iniString;

	// Token: 0x04000005 RID: 5
	private bool m_AutoFlush;

	// Token: 0x04000006 RID: 6
	private Dictionary<string, Dictionary<string, string>> m_Sections;

	// Token: 0x04000007 RID: 7
	private Dictionary<string, Dictionary<string, string>> m_Modified;

	// Token: 0x04000008 RID: 8
	private bool m_CacheModified;
}
