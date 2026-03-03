using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using UnityEngine;

// Token: 0x0200041A RID: 1050
public class SaveSlotOverrides : MonoBehaviour
{
	// Token: 0x060017B8 RID: 6072 RVA: 0x0006FF3C File Offset: 0x0006E13C
	private void OnValidate()
	{
		if (this.overrideFiles.Length != 4)
		{
			TextAsset[] array = new TextAsset[4];
			for (int i = 0; i < Mathf.Min(array.Length, this.overrideFiles.Length); i++)
			{
				array[i] = this.overrideFiles[i];
			}
			this.overrideFiles = array;
		}
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x0006FF88 File Offset: 0x0006E188
	private void Awake()
	{
		try
		{
			for (int i = 0; i < this.overrideFiles.Length; i++)
			{
				if (this.overrideFiles[i] != null)
				{
					int slotIndex = i + 1;
					string text = this.overrideFiles[i].text;
					if (!Platform.Current.IsFileSystemProtected)
					{
						string graph = Encryption.Encrypt(text);
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						MemoryStream memoryStream = new MemoryStream();
						binaryFormatter.Serialize(memoryStream, graph);
						Platform.Current.WriteSaveSlot(slotIndex, memoryStream.ToArray(), null);
						memoryStream.Close();
					}
					else
					{
						Platform.Current.WriteSaveSlot(slotIndex, Encoding.UTF8.GetBytes(text), null);
					}
				}
			}
		}
		catch (Exception ex)
		{
			string str = "GM Save - There was an error overriding save files!";
			Exception ex2 = ex;
			Debug.LogError(str + ((ex2 != null) ? ex2.ToString() : null));
		}
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00070060 File Offset: 0x0006E260
	public SaveSlotOverrides()
	{
		this.overrideFiles = new TextAsset[4];
		base..ctor();
	}

	// Token: 0x04001C7C RID: 7292
	[Tooltip("Insert an UNENCRYPTED save file into the slots that should be overridden.")]
	public TextAsset[] overrideFiles;
}
