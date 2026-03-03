using System;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000041 RID: 65
public class PlayMakerUGuiComponentProxy : MonoBehaviour
{
	// Token: 0x06000173 RID: 371 RVA: 0x00009D3E File Offset: 0x00007F3E
	private void Start()
	{
		if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
		{
			this.SetupVariableTarget();
		}
		else
		{
			this.SetupEventTarget();
		}
		this.SetupUiListeners();
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00009D60 File Offset: 0x00007F60
	private void Update()
	{
		if (this.WatchInputField && this.inputField != null && !this.inputField.text.Equals(this.lastInputFieldValue))
		{
			this.lastInputFieldValue = this.inputField.text;
			this.SetFsmVariable(this.lastInputFieldValue);
		}
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00009DB8 File Offset: 0x00007FB8
	private void SetupEventTarget()
	{
		if (this.fsmEventTarget == null)
		{
			this.fsmEventTarget = new FsmEventTarget();
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.BroadCastAll)
		{
			this.fsmEventTarget.target = FsmEventTarget.EventTarget.BroadcastAll;
			this.fsmEventTarget.excludeSelf = false;
			return;
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.FsmComponent)
		{
			this.fsmEventTarget.target = FsmEventTarget.EventTarget.FSMComponent;
			this.fsmEventTarget.fsmComponent = this.fsmEventSetup.fsmComponent;
			return;
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.GameObject)
		{
			this.fsmEventTarget.target = FsmEventTarget.EventTarget.GameObject;
			this.fsmEventTarget.gameObject = new FsmOwnerDefault();
			this.fsmEventTarget.gameObject.OwnerOption = OwnerDefaultOption.SpecifyGameObject;
			this.fsmEventTarget.gameObject.GameObject.Value = this.fsmEventSetup.gameObject;
			return;
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.Owner)
		{
			this.fsmEventTarget.ResetParameters();
			this.fsmEventTarget.target = FsmEventTarget.EventTarget.GameObject;
			this.fsmEventTarget.gameObject = new FsmOwnerDefault();
			this.fsmEventTarget.gameObject.OwnerOption = OwnerDefaultOption.SpecifyGameObject;
			this.fsmEventTarget.gameObject.GameObject.Value = base.gameObject;
		}
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00009EF4 File Offset: 0x000080F4
	private void SetupVariableTarget()
	{
		if (this.fsmVariableSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyVariableTarget.GlobalVariable)
		{
			if (this.fsmVariableSetup.variableType == VariableType.Bool)
			{
				this.fsmBoolTarget = FsmVariables.GlobalVariables.FindFsmBool(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.Float)
			{
				this.fsmFloatTarget = FsmVariables.GlobalVariables.FindFsmFloat(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.Vector2)
			{
				this.fsmVector2Target = FsmVariables.GlobalVariables.FindFsmVector2(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.String)
			{
				this.fsmStringTarget = FsmVariables.GlobalVariables.FindFsmString(this.fsmVariableSetup.variableName);
				return;
			}
		}
		else if (this.fsmVariableSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyVariableTarget.FsmComponent)
		{
			if (!(this.fsmVariableSetup.fsmComponent != null))
			{
				Debug.LogError("set to target a FsmComponent but fsmEventTarget.target is null");
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.Bool)
			{
				this.fsmBoolTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmBool(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.Float)
			{
				this.fsmFloatTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmFloat(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.Vector2)
			{
				this.fsmVector2Target = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmVector2(this.fsmVariableSetup.variableName);
				return;
			}
			if (this.fsmVariableSetup.variableType == VariableType.String)
			{
				this.fsmStringTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmString(this.fsmVariableSetup.variableName);
				return;
			}
		}
		else if (this.fsmVariableSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyVariableTarget.Owner)
		{
			if (!(this.fsmVariableSetup.gameObject != null))
			{
				Debug.LogError("set to target Owbner but fsmEventTarget.target is null");
				return;
			}
			if (this.fsmVariableSetup.fsmComponent != null)
			{
				if (this.fsmVariableSetup.variableType == VariableType.Bool)
				{
					this.fsmBoolTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmBool(this.fsmVariableSetup.variableName);
					return;
				}
				if (this.fsmVariableSetup.variableType == VariableType.Float)
				{
					this.fsmFloatTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmFloat(this.fsmVariableSetup.variableName);
					return;
				}
				if (this.fsmVariableSetup.variableType == VariableType.Vector2)
				{
					this.fsmVector2Target = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmVector2(this.fsmVariableSetup.variableName);
					return;
				}
				if (this.fsmVariableSetup.variableType == VariableType.String)
				{
					this.fsmStringTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmString(this.fsmVariableSetup.variableName);
					return;
				}
			}
		}
		else if (this.fsmVariableSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyVariableTarget.GameObject)
		{
			if (this.fsmVariableSetup.gameObject != null)
			{
				if (this.fsmVariableSetup.fsmComponent != null)
				{
					if (this.fsmVariableSetup.variableType == VariableType.Bool)
					{
						this.fsmBoolTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmBool(this.fsmVariableSetup.variableName);
						return;
					}
					if (this.fsmVariableSetup.variableType == VariableType.Float)
					{
						this.fsmFloatTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmFloat(this.fsmVariableSetup.variableName);
						return;
					}
					if (this.fsmVariableSetup.variableType == VariableType.Vector2)
					{
						this.fsmVector2Target = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmVector2(this.fsmVariableSetup.variableName);
						return;
					}
					if (this.fsmVariableSetup.variableType == VariableType.String)
					{
						this.fsmStringTarget = this.fsmVariableSetup.fsmComponent.FsmVariables.FindFsmString(this.fsmVariableSetup.variableName);
						return;
					}
				}
			}
			else
			{
				Debug.LogError("set to target a Gameobject but fsmEventTarget.target is null");
			}
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000A2FC File Offset: 0x000084FC
	private void SetupUiListeners()
	{
		if (this.UiTarget.GetComponent<Button>() != null)
		{
			this.UiTarget.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnClick));
		}
		if (this.UiTarget.GetComponent<Toggle>() != null)
		{
			this.UiTarget.GetComponent<Toggle>().onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
			if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
			{
				this.SetFsmVariable(this.UiTarget.GetComponent<Toggle>().isOn);
			}
		}
		if (this.UiTarget.GetComponent<Slider>() != null)
		{
			this.UiTarget.GetComponent<Slider>().onValueChanged.AddListener(new UnityAction<float>(this.OnValueChanged));
			if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
			{
				this.SetFsmVariable(this.UiTarget.GetComponent<Slider>().value);
			}
		}
		if (this.UiTarget.GetComponent<Scrollbar>() != null)
		{
			this.UiTarget.GetComponent<Scrollbar>().onValueChanged.AddListener(new UnityAction<float>(this.OnValueChanged));
			if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
			{
				this.SetFsmVariable(this.UiTarget.GetComponent<Scrollbar>().value);
			}
		}
		if (this.UiTarget.GetComponent<ScrollRect>() != null)
		{
			this.UiTarget.GetComponent<ScrollRect>().onValueChanged.AddListener(new UnityAction<Vector2>(this.OnValueChanged));
			if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
			{
				this.SetFsmVariable(this.UiTarget.GetComponent<ScrollRect>().normalizedPosition);
			}
		}
		if (this.UiTarget.GetComponent<InputField>() != null)
		{
			this.UiTarget.GetComponent<InputField>().onEndEdit.AddListener(new UnityAction<string>(this.onEndEdit));
			if (this.action == PlayMakerUGuiComponentProxy.ActionType.SetFsmVariable)
			{
				this.WatchInputField = true;
				this.inputField = this.UiTarget.GetComponent<InputField>();
				this.lastInputFieldValue = "";
			}
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000A4EC File Offset: 0x000086EC
	protected void OnClick()
	{
		if (this.debug)
		{
			Debug.Log("OnClick");
		}
		FsmEventData eventData = new FsmEventData();
		this.FirePlayMakerEvent(eventData);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000A518 File Offset: 0x00008718
	protected void OnValueChanged(bool value)
	{
		if (this.debug)
		{
			Debug.Log("OnValueChanged(bool): " + value.ToString());
		}
		if (this.action == PlayMakerUGuiComponentProxy.ActionType.SendFsmEvent)
		{
			this.FirePlayMakerEvent(new FsmEventData
			{
				BoolData = value
			});
			return;
		}
		this.SetFsmVariable(value);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000A568 File Offset: 0x00008768
	protected void OnValueChanged(float value)
	{
		if (this.debug)
		{
			Debug.Log("OnValueChanged(float): " + value.ToString());
		}
		if (this.action == PlayMakerUGuiComponentProxy.ActionType.SendFsmEvent)
		{
			this.FirePlayMakerEvent(new FsmEventData
			{
				FloatData = value
			});
			return;
		}
		this.SetFsmVariable(value);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000A5B8 File Offset: 0x000087B8
	protected void OnValueChanged(Vector2 value)
	{
		if (this.debug)
		{
			string str = "OnValueChanged(vector2): ";
			Vector2 vector = value;
			Debug.Log(str + vector.ToString());
		}
		if (this.action == PlayMakerUGuiComponentProxy.ActionType.SendFsmEvent)
		{
			this.FirePlayMakerEvent(new FsmEventData
			{
				Vector2Data = value
			});
			return;
		}
		this.SetFsmVariable(value);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000A610 File Offset: 0x00008810
	protected void onEndEdit(string value)
	{
		if (this.debug)
		{
			Debug.Log("onEndEdit(string): " + value);
		}
		if (this.action == PlayMakerUGuiComponentProxy.ActionType.SendFsmEvent)
		{
			this.FirePlayMakerEvent(new FsmEventData
			{
				StringData = value
			});
			return;
		}
		this.SetFsmVariable(value);
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000A65C File Offset: 0x0000885C
	private void SetFsmVariable(Vector2 value)
	{
		if (this.fsmVector2Target != null)
		{
			if (this.debug)
			{
				string str = "PlayMakerUGuiComponentProxy on ";
				string name = base.name;
				string str2 = ": Fsm Vector2 set to ";
				Vector2 vector = value;
				Debug.Log(str + name + str2 + vector.ToString());
			}
			this.fsmVector2Target.Value = value;
			return;
		}
		Debug.LogError("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm Vector2 MISSING !!", base.gameObject);
	}

	// Token: 0x0600017E RID: 382 RVA: 0x0000A6D0 File Offset: 0x000088D0
	private void SetFsmVariable(bool value)
	{
		if (this.fsmBoolTarget != null)
		{
			if (this.debug)
			{
				Debug.Log("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm Bool set to " + value.ToString());
			}
			this.fsmBoolTarget.Value = value;
			return;
		}
		Debug.LogError("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm Bool MISSING !!", base.gameObject);
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000A73C File Offset: 0x0000893C
	private void SetFsmVariable(float value)
	{
		if (this.fsmFloatTarget != null)
		{
			if (this.debug)
			{
				Debug.Log("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm Float set to " + value.ToString());
			}
			this.fsmFloatTarget.Value = value;
			return;
		}
		Debug.LogError("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm Float MISSING !!", base.gameObject);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000A7A8 File Offset: 0x000089A8
	private void SetFsmVariable(string value)
	{
		if (this.fsmStringTarget != null)
		{
			if (this.debug)
			{
				Debug.Log("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm String set to " + value);
			}
			this.fsmStringTarget.Value = value;
			return;
		}
		Debug.LogError("PlayMakerUGuiComponentProxy on " + base.name + ": Fsm String MISSING !!", base.gameObject);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x0000A810 File Offset: 0x00008A10
	private void FirePlayMakerEvent(FsmEventData eventData)
	{
		if (eventData != null)
		{
			Fsm.EventData = eventData;
		}
		this.fsmEventTarget.excludeSelf = false;
		if (PlayMakerUGuiSceneProxy.fsm == null)
		{
			Debug.LogError("Missing 'PlayMaker UGui' prefab in scene");
			return;
		}
		Fsm fsm = PlayMakerUGuiSceneProxy.fsm.Fsm;
		if (this.debug)
		{
			Debug.Log("Fire event: " + this.GetEventString());
		}
		fsm.Event(this.fsmEventTarget, this.GetEventString());
	}

	// Token: 0x06000182 RID: 386 RVA: 0x0000A888 File Offset: 0x00008A88
	public bool DoesTargetImplementsEvent()
	{
		string eventString = this.GetEventString();
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.BroadCastAll)
		{
			return FsmEvent.IsEventGlobal(eventString);
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.FsmComponent)
		{
			return PlayMakerUtils.DoesFsmImplementsEvent(this.fsmEventSetup.fsmComponent, eventString);
		}
		if (this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.GameObject)
		{
			return PlayMakerUtils.DoesGameObjectImplementsEvent(this.fsmEventSetup.gameObject, eventString);
		}
		return this.fsmEventSetup.target == PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget.Owner && PlayMakerUtils.DoesGameObjectImplementsEvent(base.gameObject, eventString);
	}

	// Token: 0x06000183 RID: 387 RVA: 0x0000A90C File Offset: 0x00008B0C
	private string GetEventString()
	{
		if (!string.IsNullOrEmpty(this.fsmEventSetup.customEventName))
		{
			return this.fsmEventSetup.customEventName;
		}
		return this.fsmEventSetup.builtInEventName;
	}

	// Token: 0x04000100 RID: 256
	public bool debug;

	// Token: 0x04000101 RID: 257
	private string error;

	// Token: 0x04000102 RID: 258
	public OwnerDefaultOption UiTargetOption;

	// Token: 0x04000103 RID: 259
	public GameObject UiTarget;

	// Token: 0x04000104 RID: 260
	public PlayMakerUGuiComponentProxy.ActionType action;

	// Token: 0x04000105 RID: 261
	public PlayMakerUGuiComponentProxy.FsmVariableSetup fsmVariableSetup;

	// Token: 0x04000106 RID: 262
	private FsmFloat fsmFloatTarget;

	// Token: 0x04000107 RID: 263
	private FsmBool fsmBoolTarget;

	// Token: 0x04000108 RID: 264
	private FsmVector2 fsmVector2Target;

	// Token: 0x04000109 RID: 265
	private FsmString fsmStringTarget;

	// Token: 0x0400010A RID: 266
	public PlayMakerUGuiComponentProxy.FsmEventSetup fsmEventSetup;

	// Token: 0x0400010B RID: 267
	private FsmEventTarget fsmEventTarget;

	// Token: 0x0400010C RID: 268
	private bool WatchInputField;

	// Token: 0x0400010D RID: 269
	private InputField inputField;

	// Token: 0x0400010E RID: 270
	private string lastInputFieldValue;

	// Token: 0x02000042 RID: 66
	public enum ActionType
	{
		// Token: 0x04000110 RID: 272
		SendFsmEvent,
		// Token: 0x04000111 RID: 273
		SetFsmVariable
	}

	// Token: 0x02000043 RID: 67
	public enum PlayMakerProxyEventTarget
	{
		// Token: 0x04000113 RID: 275
		Owner,
		// Token: 0x04000114 RID: 276
		GameObject,
		// Token: 0x04000115 RID: 277
		BroadCastAll,
		// Token: 0x04000116 RID: 278
		FsmComponent
	}

	// Token: 0x02000044 RID: 68
	public enum PlayMakerProxyVariableTarget
	{
		// Token: 0x04000118 RID: 280
		Owner,
		// Token: 0x04000119 RID: 281
		GameObject,
		// Token: 0x0400011A RID: 282
		GlobalVariable,
		// Token: 0x0400011B RID: 283
		FsmComponent
	}

	// Token: 0x02000045 RID: 69
	[Serializable]
	public struct FsmVariableSetup
	{
		// Token: 0x0400011C RID: 284
		public PlayMakerUGuiComponentProxy.PlayMakerProxyVariableTarget target;

		// Token: 0x0400011D RID: 285
		public GameObject gameObject;

		// Token: 0x0400011E RID: 286
		public PlayMakerFSM fsmComponent;

		// Token: 0x0400011F RID: 287
		public int fsmIndex;

		// Token: 0x04000120 RID: 288
		public int variableIndex;

		// Token: 0x04000121 RID: 289
		public VariableType variableType;

		// Token: 0x04000122 RID: 290
		public string variableName;
	}

	// Token: 0x02000046 RID: 70
	[Serializable]
	public struct FsmEventSetup
	{
		// Token: 0x04000123 RID: 291
		public PlayMakerUGuiComponentProxy.PlayMakerProxyEventTarget target;

		// Token: 0x04000124 RID: 292
		public GameObject gameObject;

		// Token: 0x04000125 RID: 293
		public PlayMakerFSM fsmComponent;

		// Token: 0x04000126 RID: 294
		public string customEventName;

		// Token: 0x04000127 RID: 295
		public string builtInEventName;
	}
}
