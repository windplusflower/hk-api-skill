using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD1 RID: 3025
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds the Child of a GameObject by Name and/or Tag. Use this to find attach points etc. NOTE: This action will search recursively through all children and return the first match; To find a specific child use Find Child.")]
	public class GetChild : FsmStateAction
	{
		// Token: 0x06003FBC RID: 16316 RVA: 0x001682EE File Offset: 0x001664EE
		public override void Reset()
		{
			this.gameObject = null;
			this.childName = "";
			this.withTag = "Untagged";
			this.storeResult = null;
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x0016831E File Offset: 0x0016651E
		public override void OnEnter()
		{
			this.storeResult.Value = GetChild.DoGetChildByName(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.childName.Value, this.withTag.Value);
			base.Finish();
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00168360 File Offset: 0x00166560
		private static GameObject DoGetChildByName(GameObject root, string name, string tag)
		{
			if (root == null)
			{
				return null;
			}
			foreach (object obj in root.transform)
			{
				Transform transform = (Transform)obj;
				if (!string.IsNullOrEmpty(name))
				{
					if (transform.name == name)
					{
						if (string.IsNullOrEmpty(tag))
						{
							return transform.gameObject;
						}
						if (transform.tag.Equals(tag))
						{
							return transform.gameObject;
						}
					}
				}
				else if (!string.IsNullOrEmpty(tag) && transform.tag == tag)
				{
					return transform.gameObject;
				}
				GameObject gameObject = GetChild.DoGetChildByName(transform.gameObject, name, tag);
				if (gameObject != null)
				{
					return gameObject;
				}
			}
			return null;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00168444 File Offset: 0x00166644
		public override string ErrorCheck()
		{
			if (string.IsNullOrEmpty(this.childName.Value) && string.IsNullOrEmpty(this.withTag.Value))
			{
				return "Specify Child Name, Tag, or both.";
			}
			return null;
		}

		// Token: 0x040043ED RID: 17389
		[RequiredField]
		[Tooltip("The GameObject to search.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040043EE RID: 17390
		[Tooltip("The name of the child to search for.")]
		public FsmString childName;

		// Token: 0x040043EF RID: 17391
		[UIHint(UIHint.Tag)]
		[Tooltip("The Tag to search for. If Child Name is set, both name and Tag need to match.")]
		public FsmString withTag;

		// Token: 0x040043F0 RID: 17392
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a GameObject variable.")]
		public FsmGameObject storeResult;
	}
}
