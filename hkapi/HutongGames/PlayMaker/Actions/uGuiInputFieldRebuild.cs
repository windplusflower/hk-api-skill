using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA7 RID: 2727
	[ActionCategory("uGui")]
	[Tooltip("Rebuild a UGui Graphics component.")]
	public class uGuiInputFieldRebuild : FsmStateAction
	{
		// Token: 0x06003AB3 RID: 15027 RVA: 0x001549C7 File Offset: 0x00152BC7
		public override void Reset()
		{
			this.gameObject = null;
			this.canvasUpdate = CanvasUpdate.LatePreRender;
			this.rebuildOnExit = false;
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x001549E0 File Offset: 0x00152BE0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._graphic = ownerDefaultTarget.GetComponent<Graphic>();
			}
			if (!this.rebuildOnExit)
			{
				this.DoAction();
			}
			base.Finish();
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x00154A28 File Offset: 0x00152C28
		private void DoAction()
		{
			if (this._graphic != null)
			{
				this._graphic.Rebuild(this.canvasUpdate);
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00154A49 File Offset: 0x00152C49
		public override void OnExit()
		{
			if (this.rebuildOnExit)
			{
				this.DoAction();
			}
		}

		// Token: 0x04003E05 RID: 15877
		[RequiredField]
		[CheckForComponent(typeof(Graphic))]
		[Tooltip("The GameObject with the ui canvas Element component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E06 RID: 15878
		public CanvasUpdate canvasUpdate;

		// Token: 0x04003E07 RID: 15879
		[Tooltip("Only Rebuild when state exits.")]
		public bool rebuildOnExit;

		// Token: 0x04003E08 RID: 15880
		private Graphic _graphic;
	}
}
