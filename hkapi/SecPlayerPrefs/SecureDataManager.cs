using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SecPlayerPrefs
{
	// Token: 0x0200065A RID: 1626
	public class SecureDataManager<T> where T : new()
	{
		// Token: 0x0600275C RID: 10076 RVA: 0x000DED44 File Offset: 0x000DCF44
		public SecureDataManager(string filename)
		{
			this.key = filename;
			this.stats = this.Load();
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000DED5F File Offset: 0x000DCF5F
		public T Get()
		{
			return this.stats;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000DED68 File Offset: 0x000DCF68
		private T Load()
		{
			if (!SecurePlayerPrefs.HasKey(this.key))
			{
				return Activator.CreateInstance<T>();
			}
			string @string = SecurePlayerPrefs.GetString(this.key);
			return this.DeserializeObject(@string);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000DED9C File Offset: 0x000DCF9C
		public void Save(T stats)
		{
			string value = this.SerializeObject(stats);
			SecurePlayerPrefs.SetString(this.key, value);
			SecurePlayerPrefs.Save();
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000DEDC4 File Offset: 0x000DCFC4
		private string SerializeObject(T pObject)
		{
			Stream w = new MemoryStream();
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			XmlTextWriter xmlTextWriter = new XmlTextWriter(w, Encoding.UTF8);
			xmlSerializer.Serialize(xmlTextWriter, pObject);
			return SecureDataManager<T>.UTF8ByteArrayToString(((MemoryStream)xmlTextWriter.BaseStream).ToArray());
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000DEE14 File Offset: 0x000DD014
		private T DeserializeObject(string pXmlizedString)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			MemoryStream memoryStream = new MemoryStream(SecureDataManager<T>.StringToUTF8ByteArray(pXmlizedString));
			new XmlTextWriter(memoryStream, Encoding.UTF8);
			return (T)((object)xmlSerializer.Deserialize(memoryStream));
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000DEE53 File Offset: 0x000DD053
		private static string UTF8ByteArrayToString(byte[] characters)
		{
			return new UTF8Encoding().GetString(characters);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000DEE60 File Offset: 0x000DD060
		private static byte[] StringToUTF8ByteArray(string pXmlString)
		{
			return new UTF8Encoding().GetBytes(pXmlString);
		}

		// Token: 0x04002B75 RID: 11125
		private T stats;

		// Token: 0x04002B76 RID: 11126
		private string key;
	}
}
