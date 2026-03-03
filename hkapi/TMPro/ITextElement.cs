using System;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000610 RID: 1552
	public interface ITextElement
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060024EA RID: 9450
		Material sharedMaterial { get; }

		// Token: 0x060024EB RID: 9451
		void Rebuild(CanvasUpdate update);

		// Token: 0x060024EC RID: 9452
		int GetInstanceID();
	}
}
