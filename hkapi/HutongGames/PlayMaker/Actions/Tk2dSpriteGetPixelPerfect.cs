using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000969 RID: 2409
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Get the pixel perfect flag of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dClippedSprite)")]
	public class Tk2dSpriteGetPixelPerfect : FsmStateAction
	{
		// Token: 0x060034E6 RID: 13542 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0013ACF1 File Offset: 0x00138EF1
		public override void Reset()
		{
			this.gameObject = null;
			this.pixelPerfect = null;
		}

		// Token: 0x04003691 RID: 13969
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dClippedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003692 RID: 13970
		[Tooltip("(Deprecated in 2D Toolkit 2.0) Is the sprite pixelPerfect")]
		[UIHint(UIHint.Variable)]
		public FsmBool pixelPerfect;
	}
}
