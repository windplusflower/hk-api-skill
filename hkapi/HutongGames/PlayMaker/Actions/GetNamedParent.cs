using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D8 RID: 2520
	[ActionCategory("Hollow Knight")]
	public class GetNamedParent : FsmStateAction
	{
		// Token: 0x06003711 RID: 14097 RVA: 0x00144656 File Offset: 0x00142856
		public override void Reset()
		{
			this.gameObject = null;
			this.parentName = "";
			this.withTag = null;
			this.storeResult = null;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00144680 File Offset: 0x00142880
		public override void OnEnter()
		{
			this.storeResult.Value = GetNamedParent.DoGetParentByName(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.parentName.Value, this.withTag.IsNone ? null : this.withTag.Value);
			base.Finish();
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x001446DC File Offset: 0x001428DC
		private static GameObject DoGetParentByName(GameObject root, string name, string tag)
		{
			if (root == null)
			{
				return null;
			}
			Transform parent = root.transform.parent;
			if (parent == null)
			{
				return null;
			}
			if (parent.name == name && (string.IsNullOrEmpty(tag) || parent.CompareTag(tag)))
			{
				return parent.gameObject;
			}
			return GetNamedParent.DoGetParentByName(parent.gameObject, name, tag);
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x0014473E File Offset: 0x0014293E
		public override string ErrorCheck()
		{
			if (string.IsNullOrEmpty(this.parentName.Value) && string.IsNullOrEmpty(this.withTag.Value))
			{
				return "Specify Parent Name, Tag, or both.";
			}
			return null;
		}

		// Token: 0x0400392B RID: 14635
		[RequiredField]
		[Tooltip("The GameObject to search.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400392C RID: 14636
		[Tooltip("The name of the parent to search for.")]
		public FsmString parentName;

		// Token: 0x0400392D RID: 14637
		[UIHint(UIHint.Tag)]
		[Tooltip("The Tag to search for. If Parent Name is set, both name and Tag need to match.")]
		public FsmString withTag;

		// Token: 0x0400392E RID: 14638
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a GameObject variable.")]
		public FsmGameObject storeResult;
	}
}
