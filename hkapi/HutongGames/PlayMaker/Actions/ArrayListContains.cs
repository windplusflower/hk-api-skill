using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000910 RID: 2320
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Check if an item is contains in a particula PlayMaker ArrayList Proxy component")]
	public class ArrayListContains : ArrayListActions
	{
		// Token: 0x0600336A RID: 13162 RVA: 0x00135444 File Offset: 0x00133644
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.variable = null;
			this.isContained = null;
			this.isContainedEvent = null;
			this.isNotContainedEvent = null;
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00135470 File Offset: 0x00133670
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doesArrayListContains();
			}
			base.Finish();
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x001354A4 File Offset: 0x001336A4
		public void doesArrayListContains()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			bool flag = false;
			PlayMakerUtils.RefreshValueFromFsmVar(base.Fsm, this.variable);
			switch (this.variable.Type)
			{
			case VariableType.Float:
				flag = this.proxy.arrayList.Contains(this.variable.floatValue);
				break;
			case VariableType.Int:
				flag = this.proxy.arrayList.Contains(this.variable.intValue);
				break;
			case VariableType.Bool:
				flag = this.proxy.arrayList.Contains(this.variable.boolValue);
				break;
			case VariableType.GameObject:
				flag = this.proxy.arrayList.Contains(this.variable.gameObjectValue);
				break;
			case VariableType.String:
				flag = this.proxy.arrayList.Contains(this.variable.stringValue);
				break;
			case VariableType.Vector2:
				flag = this.proxy.arrayList.Contains(this.variable.vector2Value);
				break;
			case VariableType.Vector3:
				flag = this.proxy.arrayList.Contains(this.variable.vector3Value);
				break;
			case VariableType.Color:
				flag = this.proxy.arrayList.Contains(this.variable.colorValue);
				break;
			case VariableType.Rect:
				flag = this.proxy.arrayList.Contains(this.variable.rectValue);
				break;
			case VariableType.Material:
				flag = this.proxy.arrayList.Contains(this.variable.materialValue);
				break;
			case VariableType.Texture:
				flag = this.proxy.arrayList.Contains(this.variable.textureValue);
				break;
			case VariableType.Quaternion:
				flag = this.proxy.arrayList.Contains(this.variable.quaternionValue);
				break;
			case VariableType.Object:
				flag = this.proxy.arrayList.Contains(this.variable.objectReference);
				break;
			}
			this.isContained.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isContainedEvent);
				return;
			}
			base.Fsm.Event(this.isNotContainedEvent);
		}

		// Token: 0x040034D0 RID: 13520
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034D1 RID: 13521
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component (necessary if several component coexists on the same GameObject)")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x040034D2 RID: 13522
		[ActionSection("Data")]
		[RequiredField]
		[Tooltip("The variable to check.")]
		public FsmVar variable;

		// Token: 0x040034D3 RID: 13523
		[ActionSection("Result")]
		[Tooltip("Store in a bool wether it contains or not that element (described below)")]
		[UIHint(UIHint.Variable)]
		public FsmBool isContained;

		// Token: 0x040034D4 RID: 13524
		[Tooltip("Event sent if this arraList contains that element ( described below)")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isContainedEvent;

		// Token: 0x040034D5 RID: 13525
		[Tooltip("Event sent if this arraList does not contains that element ( described below)")]
		[UIHint(UIHint.FsmEvent)]
		public FsmEvent isNotContainedEvent;
	}
}
