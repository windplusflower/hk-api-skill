using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C90 RID: 3216
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the Ambient Light Color for the scene.")]
	public class SetAmbientLight : FsmStateAction
	{
		// Token: 0x06004325 RID: 17189 RVA: 0x00172654 File Offset: 0x00170854
		public override void Reset()
		{
			this.ambientColor = Color.gray;
			this.everyFrame = false;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x0017266D File Offset: 0x0017086D
		public override void OnEnter()
		{
			this.DoSetAmbientColor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x00172683 File Offset: 0x00170883
		public override void OnUpdate()
		{
			this.DoSetAmbientColor();
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0017268B File Offset: 0x0017088B
		private void DoSetAmbientColor()
		{
			RenderSettings.ambientLight = this.ambientColor.Value;
		}

		// Token: 0x0400477A RID: 18298
		[RequiredField]
		public FsmColor ambientColor;

		// Token: 0x0400477B RID: 18299
		public bool everyFrame;
	}
}
