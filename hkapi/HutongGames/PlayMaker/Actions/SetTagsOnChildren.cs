using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE5 RID: 3301
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Set the Tag on all children of a GameObject. Optionally filter by component.")]
	public class SetTagsOnChildren : FsmStateAction
	{
		// Token: 0x0600449F RID: 17567 RVA: 0x0017645B File Offset: 0x0017465B
		public override void Reset()
		{
			this.gameObject = null;
			this.tag = null;
			this.filterByComponent = null;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00176472 File Offset: 0x00174672
		public override void OnEnter()
		{
			this.SetTag(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x00176494 File Offset: 0x00174694
		private void SetTag(GameObject parent)
		{
			if (parent == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(this.filterByComponent.Value))
			{
				using (IEnumerator enumerator = parent.transform.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						((Transform)obj).gameObject.tag = this.tag.Value;
					}
					goto IL_AC;
				}
			}
			this.UpdateComponentFilter();
			if (this.componentFilter != null)
			{
				Component[] componentsInChildren = parent.GetComponentsInChildren(this.componentFilter);
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].gameObject.tag = this.tag.Value;
				}
			}
			IL_AC:
			base.Finish();
		}

		// Token: 0x060044A2 RID: 17570 RVA: 0x00176564 File Offset: 0x00174764
		private void UpdateComponentFilter()
		{
			this.componentFilter = ReflectionUtils.GetGlobalType(this.filterByComponent.Value);
			if (this.componentFilter == null)
			{
				this.componentFilter = ReflectionUtils.GetGlobalType("UnityEngine." + this.filterByComponent.Value);
			}
			if (this.componentFilter == null)
			{
				Debug.LogWarning("Couldn't get type: " + this.filterByComponent.Value);
			}
		}

		// Token: 0x040048E1 RID: 18657
		[RequiredField]
		[Tooltip("GameObject Parent")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048E2 RID: 18658
		[RequiredField]
		[UIHint(UIHint.Tag)]
		[Tooltip("Set Tag To...")]
		public FsmString tag;

		// Token: 0x040048E3 RID: 18659
		[UIHint(UIHint.ScriptComponent)]
		[Tooltip("Only set the Tag on children with this component.")]
		public FsmString filterByComponent;

		// Token: 0x040048E4 RID: 18660
		private Type componentFilter;
	}
}
