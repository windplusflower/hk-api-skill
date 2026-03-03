using System;
using UnityEngine;

namespace TeamCherry
{
	// Token: 0x0200065E RID: 1630
	[Serializable]
	public class References : ScriptableObject
	{
		// Token: 0x04002B7F RID: 11135
		public SceneDefaultSettings sceneDefaultSettings;

		// Token: 0x04002B80 RID: 11136
		public CleanScenePrefabs cleanScenePrefabs;

		// Token: 0x04002B81 RID: 11137
		public GameConfig gameConfig;

		// Token: 0x04002B82 RID: 11138
		public SaveConfig saveConfig;

		// Token: 0x04002B83 RID: 11139
		public GameVersionData gameVersionData;
	}
}
