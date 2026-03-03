using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B83 RID: 2947
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds a Game Object by Name and/or Tag.")]
	public class FindGameObject : FsmStateAction
	{
		// Token: 0x06003E9F RID: 16031 RVA: 0x00164D39 File Offset: 0x00162F39
		public override void Reset()
		{
			this.objectName = "";
			this.withTag = "Untagged";
			this.store = null;
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x00164D62 File Offset: 0x00162F62
		public override void OnEnter()
		{
			this.Find();
			base.Finish();
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x00164D70 File Offset: 0x00162F70
		private void Find()
		{
			if (!(this.withTag.Value != "Untagged"))
			{
				this.store.Value = GameObject.Find(this.objectName.Value);
				return;
			}
			if (!string.IsNullOrEmpty(this.objectName.Value))
			{
				foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag(this.withTag.Value))
				{
					if (gameObject.name == this.objectName.Value)
					{
						this.store.Value = gameObject;
						return;
					}
				}
				this.store.Value = null;
				return;
			}
			this.store.Value = GameObject.FindGameObjectWithTag(this.withTag.Value);
		}

		// Token: 0x06003EA2 RID: 16034 RVA: 0x00164E35 File Offset: 0x00163035
		public override string ErrorCheck()
		{
			if (string.IsNullOrEmpty(this.objectName.Value) && string.IsNullOrEmpty(this.withTag.Value))
			{
				return "Specify Name, Tag, or both.";
			}
			return null;
		}

		// Token: 0x040042B1 RID: 17073
		[Tooltip("The name of the GameObject to find. You can leave this empty if you specify a Tag.")]
		public FsmString objectName;

		// Token: 0x040042B2 RID: 17074
		[UIHint(UIHint.Tag)]
		[Tooltip("Find a GameObject with this tag. If Object Name is specified then both name and Tag must match.")]
		public FsmString withTag;

		// Token: 0x040042B3 RID: 17075
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a GameObject variable.")]
		public FsmGameObject store;
	}
}
