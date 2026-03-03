using System;
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A56 RID: 2646
	[ActionCategory("TextMeshPro")]
	[Tooltip("Set TextMeshPro color.")]
	public class SetTextMeshProColor : FsmStateAction
	{
		// Token: 0x06003932 RID: 14642 RVA: 0x0014D721 File Offset: 0x0014B921
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
			this.everyFrame = false;
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x0014D738 File Offset: 0x0014B938
		public override void OnEnter()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.gameObject != null)
			{
				this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.textMesh = this.go.GetComponent<TextMeshPro>();
				if (this.textMesh != null)
				{
					this.textMesh.color = this.color.Value;
				}
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0014D7C0 File Offset: 0x0014B9C0
		public override void OnUpdate()
		{
			if (this.gameObject != null)
			{
				this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.textMesh = this.go.GetComponent<TextMeshPro>();
				if (this.textMesh != null)
				{
					this.textMesh.color = this.color.Value;
				}
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x04003BD1 RID: 15313
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BD2 RID: 15314
		[RequiredField]
		public FsmColor color;

		// Token: 0x04003BD3 RID: 15315
		public bool everyFrame;

		// Token: 0x04003BD4 RID: 15316
		private GameObject go;

		// Token: 0x04003BD5 RID: 15317
		private TextMeshPro textMesh;
	}
}
