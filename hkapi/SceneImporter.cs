using System;
using UnityEngine;

// Token: 0x0200041B RID: 1051
public class SceneImporter : MonoBehaviour
{
	// Token: 0x060017BB RID: 6075 RVA: 0x00070074 File Offset: 0x0006E274
	public SceneImporter()
	{
		this.xml_folder = "./Assets/_Porting/Scene XML/";
		this.prefabs_folder = "Prefabs/";
		this.importMode = 1;
		this.lookForPrefabsFirst = true;
		base..ctor();
	}

	// Token: 0x04001C7D RID: 7293
	public string xml_folder;

	// Token: 0x04001C7E RID: 7294
	public string prefabs_folder;

	// Token: 0x04001C7F RID: 7295
	public string xml_doc_filename;

	// Token: 0x04001C80 RID: 7296
	public string level_name;

	// Token: 0x04001C81 RID: 7297
	public int tile_size;

	// Token: 0x04001C82 RID: 7298
	public int scene_width;

	// Token: 0x04001C83 RID: 7299
	public int scene_height;

	// Token: 0x04001C84 RID: 7300
	public int layer_count;

	// Token: 0x04001C85 RID: 7301
	public GameObject placeholder_prefab;

	// Token: 0x04001C86 RID: 7302
	public int importMode;

	// Token: 0x04001C87 RID: 7303
	public bool lookForPrefabsFirst;

	// Token: 0x04001C88 RID: 7304
	public bool debug_output;
}
