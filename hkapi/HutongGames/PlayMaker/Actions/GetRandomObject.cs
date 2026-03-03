using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0A RID: 3082
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets a Random Game Object from the scene.\nOptionally filter by Tag.")]
	public class GetRandomObject : FsmStateAction
	{
		// Token: 0x060040B3 RID: 16563 RVA: 0x0016AB8B File Offset: 0x00168D8B
		public override void Reset()
		{
			this.withTag = "Untagged";
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x0016ABAB File Offset: 0x00168DAB
		public override void OnEnter()
		{
			this.DoGetRandomObject();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0016ABC1 File Offset: 0x00168DC1
		public override void OnUpdate()
		{
			this.DoGetRandomObject();
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0016ABCC File Offset: 0x00168DCC
		private void DoGetRandomObject()
		{
			GameObject[] array;
			if (this.withTag.Value != "Untagged")
			{
				array = GameObject.FindGameObjectsWithTag(this.withTag.Value);
			}
			else
			{
				array = (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject));
			}
			if (array.Length != 0)
			{
				this.storeResult.Value = array[UnityEngine.Random.Range(0, array.Length)];
				return;
			}
			this.storeResult.Value = null;
		}

		// Token: 0x040044FE RID: 17662
		[UIHint(UIHint.Tag)]
		public FsmString withTag;

		// Token: 0x040044FF RID: 17663
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeResult;

		// Token: 0x04004500 RID: 17664
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
