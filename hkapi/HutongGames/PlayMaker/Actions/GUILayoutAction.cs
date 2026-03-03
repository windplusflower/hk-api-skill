using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BA1 RID: 2977
	[Tooltip("GUILayout base action - don't use!")]
	public abstract class GUILayoutAction : FsmStateAction
	{
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x0016611C File Offset: 0x0016431C
		public GUILayoutOption[] LayoutOptions
		{
			get
			{
				if (this.options == null)
				{
					this.options = new GUILayoutOption[this.layoutOptions.Length];
					for (int i = 0; i < this.layoutOptions.Length; i++)
					{
						this.options[i] = this.layoutOptions[i].GetGUILayoutOption();
					}
				}
				return this.options;
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x00166172 File Offset: 0x00164372
		public override void Reset()
		{
			this.layoutOptions = new LayoutOption[0];
		}

		// Token: 0x04004332 RID: 17202
		public LayoutOption[] layoutOptions;

		// Token: 0x04004333 RID: 17203
		private GUILayoutOption[] options;
	}
}
