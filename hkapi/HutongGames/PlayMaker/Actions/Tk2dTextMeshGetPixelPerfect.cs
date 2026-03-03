using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000979 RID: 2425
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Get the pixelPerfect flag of a TextMesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshGetPixelPerfect : FsmStateAction
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x0013B896 File Offset: 0x00139A96
		public override void Reset()
		{
			this.gameObject = null;
			this.pixelPerfect = null;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}

		// Token: 0x040036CD RID: 14029
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036CE RID: 14030
		[RequiredField]
		[Tooltip("(Deprecated in 2D Toolkit 2.0) Is the text pixelPerfect")]
		[UIHint(UIHint.Variable)]
		public FsmBool pixelPerfect;
	}
}
