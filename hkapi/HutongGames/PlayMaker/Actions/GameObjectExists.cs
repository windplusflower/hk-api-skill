using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CC RID: 2508
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Checks to see if a Game Object exists in the scene by Name and/or Tag.")]
	public class GameObjectExists : FsmStateAction
	{
		// Token: 0x060036DF RID: 14047 RVA: 0x00143BBB File Offset: 0x00141DBB
		public override void Reset()
		{
			this.objectName = "";
			this.withTag = "Untagged";
			this.result = null;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00143BE4 File Offset: 0x00141DE4
		public override void OnEnter()
		{
			base.Finish();
			if (!(this.withTag.Value != "Untagged"))
			{
				if (GameObject.Find(this.objectName.Value) == null)
				{
					this.result.Value = true;
				}
				return;
			}
			if (!string.IsNullOrEmpty(this.objectName.Value))
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag(this.withTag.Value);
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].name == this.objectName.Value)
					{
						this.result.Value = true;
						return;
					}
				}
				this.result.Value = false;
				return;
			}
			if (GameObject.FindGameObjectWithTag(this.withTag.Value) != null)
			{
				this.result.Value = true;
				return;
			}
			this.result.Value = false;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00143CCC File Offset: 0x00141ECC
		public override string ErrorCheck()
		{
			if (string.IsNullOrEmpty(this.objectName.Value) && string.IsNullOrEmpty(this.withTag.Value))
			{
				return "Please specify Name, Tag, or both for the object you are looking for.";
			}
			return null;
		}

		// Token: 0x040038F9 RID: 14585
		[Tooltip("The name of the GameObject to find. You can leave this empty if you specify a Tag.")]
		public FsmString objectName;

		// Token: 0x040038FA RID: 14586
		[UIHint(UIHint.Tag)]
		[Tooltip("Find a GameObject with this tag. If Object Name is specified then both name and Tag must match.")]
		public FsmString withTag;

		// Token: 0x040038FB RID: 14587
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a boolean variable.")]
		public FsmBool result;
	}
}
