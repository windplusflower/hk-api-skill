using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000943 RID: 2371
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Check if a GameObject ( by name and/or tag) is within an arrayList.")]
	public class ArrayListContainsGameObject : ArrayListActions
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x0013841E File Offset: 0x0013661E
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.gameObjectName = null;
			this.result = null;
			this.resultIndex = null;
			this.isContained = null;
			this.isContainedEvent = null;
			this.isNotContainedEvent = null;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00138458 File Offset: 0x00136658
		public override void OnEnter()
		{
			if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				base.Finish();
			}
			int num = this.DoContainsGo();
			if (num >= 0)
			{
				this.isContained.Value = true;
				this.result.Value = (GameObject)this.proxy.arrayList[num];
				this.resultIndex.Value = num;
				base.Fsm.Event(this.isContainedEvent);
			}
			else
			{
				this.isContained.Value = false;
				base.Fsm.Event(this.isNotContainedEvent);
			}
			base.Finish();
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x0013850C File Offset: 0x0013670C
		private int DoContainsGo()
		{
			if (!base.isProxyValid())
			{
				return -1;
			}
			int num = 0;
			string value = this.gameObjectName.Value;
			string value2 = this.withTag.Value;
			foreach (object obj in this.proxy.arrayList)
			{
				GameObject gameObject = (GameObject)obj;
				if (gameObject != null)
				{
					if (value2 == "Untagged" || this.withTag.IsNone)
					{
						if (gameObject.name.Equals(value))
						{
							return num;
						}
					}
					else if (string.IsNullOrEmpty(value))
					{
						if (gameObject.tag.Equals(value2))
						{
							return num;
						}
					}
					else if (gameObject.name.Equals(value) && gameObject.tag.Equals(value2))
					{
						return num;
					}
				}
				num++;
			}
			return -1;
		}

		// Token: 0x040035CE RID: 13774
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035CF RID: 13775
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035D0 RID: 13776
		[Tooltip("The name of the GameObject to find in the arrayList. You can leave this empty if you specify a Tag.")]
		public FsmString gameObjectName;

		// Token: 0x040035D1 RID: 13777
		[UIHint(UIHint.Tag)]
		[Tooltip("Find a GameObject in this arrayList with this tag. If GameObject Name is specified then both name and Tag must match.")]
		public FsmString withTag;

		// Token: 0x040035D2 RID: 13778
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a GameObject variable.")]
		public FsmGameObject result;

		// Token: 0x040035D3 RID: 13779
		[UIHint(UIHint.Variable)]
		public FsmInt resultIndex;

		// Token: 0x040035D4 RID: 13780
		[Tooltip("Store in a bool wether it contains or not that GameObject")]
		[UIHint(UIHint.Variable)]
		public FsmBool isContained;

		// Token: 0x040035D5 RID: 13781
		[Tooltip("Event sent if this arraList contains that GameObject")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isContainedEvent;

		// Token: 0x040035D6 RID: 13782
		[Tooltip("Event sent if this arraList does not contains that GameObject")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isNotContainedEvent;
	}
}
