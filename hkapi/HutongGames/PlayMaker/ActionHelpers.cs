using System;
using HutongGames.PlayMaker.AnimationEnums;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	// Token: 0x020008C0 RID: 2240
	public static class ActionHelpers
	{
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060031E7 RID: 12775 RVA: 0x0012FE35 File Offset: 0x0012E035
		public static Texture2D WhiteTexture
		{
			get
			{
				return Texture2D.whiteTexture;
			}
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x0012FE3C File Offset: 0x0012E03C
		public static Color BlendColor(ColorBlendMode blendMode, Color c1, Color c2)
		{
			switch (blendMode)
			{
			case ColorBlendMode.Normal:
				return Color.Lerp(c1, c2, c2.a);
			case ColorBlendMode.Multiply:
				return Color.Lerp(c1, c1 * c2, c2.a);
			case ColorBlendMode.Screen:
			{
				Color b = Color.white - (Color.white - c1) * (Color.white - c2);
				return Color.Lerp(c1, b, c2.a);
			}
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0012FEB8 File Offset: 0x0012E0B8
		public static bool IsVisible(GameObject go)
		{
			if (go == null)
			{
				return false;
			}
			Renderer component = go.GetComponent<Renderer>();
			return component != null && component.isVisible;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0012FEE8 File Offset: 0x0012E0E8
		public static GameObject GetOwnerDefault(FsmStateAction action, FsmOwnerDefault ownerDefault)
		{
			return action.Fsm.GetOwnerDefaultTarget(ownerDefault);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0012FEF8 File Offset: 0x0012E0F8
		public static PlayMakerFSM GetGameObjectFsm(GameObject go, string fsmName)
		{
			if (!string.IsNullOrEmpty(fsmName))
			{
				foreach (PlayMakerFSM playMakerFSM in go.GetComponents<PlayMakerFSM>())
				{
					if (playMakerFSM.FsmName == fsmName)
					{
						return playMakerFSM;
					}
				}
				Debug.LogWarning("Could not find FSM: " + fsmName);
			}
			return go.GetComponent<PlayMakerFSM>();
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x0012FF4C File Offset: 0x0012E14C
		public static int GetRandomWeightedIndex(FsmFloat[] weights)
		{
			float num = 0f;
			foreach (FsmFloat fsmFloat in weights)
			{
				num += fsmFloat.Value;
			}
			float num2 = UnityEngine.Random.Range(0f, num);
			for (int j = 0; j < weights.Length; j++)
			{
				if (num2 < weights[j].Value)
				{
					return j;
				}
				num2 -= weights[j].Value;
			}
			return -1;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0012FFB8 File Offset: 0x0012E1B8
		public static void AddAnimationClip(GameObject go, AnimationClip animClip)
		{
			if (animClip == null)
			{
				return;
			}
			Animation component = go.GetComponent<Animation>();
			if (component != null)
			{
				component.AddClip(animClip, animClip.name);
			}
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0012FFEC File Offset: 0x0012E1EC
		public static bool HasAnimationFinished(AnimationState anim, float prevTime, float currentTime)
		{
			return anim.wrapMode != WrapMode.Loop && anim.wrapMode != WrapMode.PingPong && (((anim.wrapMode == WrapMode.Default || anim.wrapMode == WrapMode.Once) && prevTime > 0f && currentTime.Equals(0f)) || (prevTime < anim.length && currentTime >= anim.length));
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00130050 File Offset: 0x0012E250
		public static Vector3 GetPosition(FsmGameObject fsmGameObject, FsmVector3 fsmVector3)
		{
			Vector3 result;
			if (fsmGameObject.Value != null)
			{
				result = ((!fsmVector3.IsNone) ? fsmGameObject.Value.transform.TransformPoint(fsmVector3.Value) : fsmGameObject.Value.transform.position);
			}
			else
			{
				result = fsmVector3.Value;
			}
			return result;
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x001300A8 File Offset: 0x0012E2A8
		public static Quaternion GetTargetRotation(RotationOptions option, Transform owner, Transform target, Vector3 rotation)
		{
			if (owner == null)
			{
				return Quaternion.identity;
			}
			switch (option)
			{
			case RotationOptions.CurrentRotation:
				return owner.rotation;
			case RotationOptions.WorldRotation:
				return Quaternion.Euler(rotation);
			case RotationOptions.LocalRotation:
				if (owner.parent == null)
				{
					return Quaternion.Euler(rotation);
				}
				return owner.parent.rotation * Quaternion.Euler(rotation);
			case RotationOptions.WorldOffsetRotation:
				return Quaternion.Euler(rotation) * owner.rotation;
			case RotationOptions.LocalOffsetRotation:
				return owner.rotation * Quaternion.Euler(rotation);
			case RotationOptions.MatchGameObjectRotation:
				if (target == null)
				{
					return owner.rotation;
				}
				return target.rotation * Quaternion.Euler(rotation);
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0013016C File Offset: 0x0012E36C
		public static bool GetTargetRotation(RotationOptions option, Transform owner, FsmVector3 rotation, FsmGameObject target, out Quaternion targetRotation)
		{
			targetRotation = Quaternion.identity;
			if (owner == null || !ActionHelpers.CanEditTargetRotation(option, rotation, target))
			{
				return false;
			}
			targetRotation = ActionHelpers.GetTargetRotation(option, owner, (target.Value != null) ? target.Value.transform : null, rotation.Value);
			return true;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x001301CB File Offset: 0x0012E3CB
		private static bool CanEditTargetRotation(RotationOptions option, NamedVariable rotation, FsmGameObject target)
		{
			switch (option)
			{
			case RotationOptions.CurrentRotation:
				return false;
			case RotationOptions.WorldRotation:
			case RotationOptions.LocalRotation:
			case RotationOptions.WorldOffsetRotation:
			case RotationOptions.LocalOffsetRotation:
				return !rotation.IsNone;
			case RotationOptions.MatchGameObjectRotation:
				return target.Value != null;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x0013020C File Offset: 0x0012E40C
		public static Vector3 GetTargetScale(ScaleOptions option, Transform owner, Transform target, Vector3 scale)
		{
			if (owner == null)
			{
				return Vector3.one;
			}
			switch (option)
			{
			case ScaleOptions.CurrentScale:
				return owner.localScale;
			case ScaleOptions.LocalScale:
				return scale;
			case ScaleOptions.MultiplyScale:
				return new Vector3(owner.localScale.x * scale.x, owner.localScale.y * scale.y, owner.localScale.z * scale.z);
			case ScaleOptions.AddToScale:
				return new Vector3(owner.localScale.x + scale.x, owner.localScale.y + scale.y, owner.localScale.z + scale.z);
			case ScaleOptions.MatchGameObject:
				if (target == null)
				{
					return owner.localScale;
				}
				return target.localScale;
			default:
				return owner.localScale;
			}
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x001302E8 File Offset: 0x0012E4E8
		public static bool GetTargetPosition(PositionOptions option, Transform owner, FsmVector3 position, FsmGameObject target, out Vector3 targetPosition)
		{
			targetPosition = Vector3.zero;
			if (owner == null || !ActionHelpers.IsValidTargetPosition(option, position, target))
			{
				return false;
			}
			targetPosition = ActionHelpers.GetTargetPosition(option, owner, (target != null && target.Value != null) ? target.Value.transform : null, position.Value);
			return true;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x0013034A File Offset: 0x0012E54A
		private static bool IsValidTargetPosition(PositionOptions option, NamedVariable position, FsmGameObject target)
		{
			switch (option)
			{
			case PositionOptions.CurrentPosition:
				return true;
			case PositionOptions.WorldPosition:
			case PositionOptions.LocalPosition:
			case PositionOptions.WorldOffset:
			case PositionOptions.LocalOffset:
				return !position.IsNone;
			case PositionOptions.TargetGameObject:
				return target.Value != null;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x001301CB File Offset: 0x0012E3CB
		public static bool CanEditTargetPosition(PositionOptions option, NamedVariable position, FsmGameObject target)
		{
			switch (option)
			{
			case PositionOptions.CurrentPosition:
				return false;
			case PositionOptions.WorldPosition:
			case PositionOptions.LocalPosition:
			case PositionOptions.WorldOffset:
			case PositionOptions.LocalOffset:
				return !position.IsNone;
			case PositionOptions.TargetGameObject:
				return target.Value != null;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0013038C File Offset: 0x0012E58C
		public static Vector3 GetTargetPosition(PositionOptions option, Transform owner, Transform target, Vector3 position)
		{
			if (owner == null)
			{
				return Vector3.zero;
			}
			switch (option)
			{
			case PositionOptions.CurrentPosition:
				return owner.position;
			case PositionOptions.WorldPosition:
				return position;
			case PositionOptions.LocalPosition:
				if (owner.parent == null)
				{
					return position;
				}
				return owner.parent.TransformPoint(position);
			case PositionOptions.WorldOffset:
				return owner.position + position;
			case PositionOptions.LocalOffset:
				return owner.TransformPoint(position);
			case PositionOptions.TargetGameObject:
				if (target == null)
				{
					return owner.position;
				}
				if (position != Vector3.zero)
				{
					return target.TransformPoint(position);
				}
				return target.position;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00130434 File Offset: 0x0012E634
		public static bool IsMouseOver(GameObject gameObject, float distance, int layerMask)
		{
			return !(gameObject == null) && gameObject == ActionHelpers.MouseOver(distance, layerMask);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x0013044E File Offset: 0x0012E64E
		public static RaycastHit MousePick(float distance, int layerMask)
		{
			if (!ActionHelpers.mousePickRaycastTime.Equals((float)Time.frameCount) || ActionHelpers.mousePickDistanceUsed < distance || ActionHelpers.mousePickLayerMaskUsed != layerMask)
			{
				ActionHelpers.DoMousePick(distance, layerMask);
			}
			return ActionHelpers.mousePickInfo;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00130480 File Offset: 0x0012E680
		public static GameObject MouseOver(float distance, int layerMask)
		{
			if (!ActionHelpers.mousePickRaycastTime.Equals((float)Time.frameCount) || ActionHelpers.mousePickDistanceUsed < distance || ActionHelpers.mousePickLayerMaskUsed != layerMask)
			{
				ActionHelpers.DoMousePick(distance, layerMask);
			}
			if (ActionHelpers.mousePickInfo.collider != null && ActionHelpers.mousePickInfo.distance < distance)
			{
				return ActionHelpers.mousePickInfo.collider.gameObject;
			}
			return null;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x001304E8 File Offset: 0x0012E6E8
		private static void DoMousePick(float distance, int layerMask)
		{
			if (Camera.main == null)
			{
				return;
			}
			Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ActionHelpers.mousePickInfo, distance, layerMask);
			ActionHelpers.mousePickLayerMaskUsed = layerMask;
			ActionHelpers.mousePickDistanceUsed = distance;
			ActionHelpers.mousePickRaycastTime = (float)Time.frameCount;
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00130538 File Offset: 0x0012E738
		public static int LayerArrayToLayerMask(FsmInt[] layers, bool invert)
		{
			int num = 0;
			foreach (FsmInt fsmInt in layers)
			{
				num |= 1 << fsmInt.Value;
			}
			if (invert)
			{
				num = ~num;
			}
			if (num != 0)
			{
				return num;
			}
			return -5;
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00130576 File Offset: 0x0012E776
		public static bool IsLoopingWrapMode(WrapMode wrapMode)
		{
			return wrapMode == WrapMode.Loop || wrapMode == WrapMode.PingPong;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00130582 File Offset: 0x0012E782
		public static string CheckRayDistance(float rayDistance)
		{
			if (rayDistance > 0f)
			{
				return "";
			}
			return "Ray Distance should be greater than zero!\n";
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00130598 File Offset: 0x0012E798
		public static string CheckForValidEvent(FsmState state, string eventName)
		{
			if (state == null)
			{
				return "Invalid State!";
			}
			if (string.IsNullOrEmpty(eventName))
			{
				return "";
			}
			FsmTransition[] array = state.Fsm.GlobalTransitions;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].EventName == eventName)
				{
					return "";
				}
			}
			array = state.Transitions;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].EventName == eventName)
				{
					return "";
				}
			}
			return "Fsm will not respond to Event: " + eventName;
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00130622 File Offset: 0x0012E822
		public static string CheckPhysicsSetup(FsmOwnerDefault ownerDefault)
		{
			if (ownerDefault == null)
			{
				return "";
			}
			return ActionHelpers.CheckPhysicsSetup(ownerDefault.GameObject.Value);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0013063D File Offset: 0x0012E83D
		public static string CheckOwnerPhysicsSetup(GameObject gameObject)
		{
			return ActionHelpers.CheckPhysicsSetup(gameObject);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00130648 File Offset: 0x0012E848
		public static string CheckPhysicsSetup(GameObject gameObject)
		{
			string text = string.Empty;
			if (gameObject != null && gameObject.GetComponent<Collider>() == null && gameObject.GetComponent<Rigidbody>() == null)
			{
				text += "GameObject requires RigidBody/Collider!\n";
			}
			return text;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0013068D File Offset: 0x0012E88D
		public static string CheckPhysics2dSetup(FsmOwnerDefault ownerDefault)
		{
			if (ownerDefault == null)
			{
				return "";
			}
			return ActionHelpers.CheckPhysics2dSetup(ownerDefault.GameObject.Value);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x001306A8 File Offset: 0x0012E8A8
		public static string CheckOwnerPhysics2dSetup(GameObject gameObject)
		{
			return ActionHelpers.CheckPhysics2dSetup(gameObject);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x001306B0 File Offset: 0x0012E8B0
		public static string CheckPhysics2dSetup(GameObject gameObject)
		{
			string text = string.Empty;
			if (gameObject != null && gameObject.GetComponent<Collider2D>() == null && gameObject.GetComponent<Rigidbody2D>() == null)
			{
				text += "GameObject requires a RigidBody2D or Collider2D component!\n";
			}
			return text;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x001306F8 File Offset: 0x0012E8F8
		public static void DebugLog(Fsm fsm, LogLevel logLevel, string text, bool sendToUnityLog = false)
		{
			if (!Application.isEditor && sendToUnityLog)
			{
				string message = ActionHelpers.FormatUnityLogString(text);
				if (logLevel != LogLevel.Warning)
				{
					if (logLevel != LogLevel.Error)
					{
						Debug.Log(message);
					}
					else
					{
						Debug.LogError(message);
					}
				}
				else
				{
					Debug.LogWarning(message);
				}
			}
			if (!FsmLog.LoggingEnabled || fsm == null)
			{
				return;
			}
			switch (logLevel)
			{
			case LogLevel.Info:
				fsm.MyLog.LogAction(FsmLogType.Info, text, sendToUnityLog);
				return;
			case LogLevel.Warning:
				fsm.MyLog.LogAction(FsmLogType.Warning, text, sendToUnityLog);
				return;
			case LogLevel.Error:
				fsm.MyLog.LogAction(FsmLogType.Error, text, sendToUnityLog);
				return;
			default:
				return;
			}
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00130782 File Offset: 0x0012E982
		public static void LogError(string text)
		{
			ActionHelpers.DebugLog(FsmExecutionStack.ExecutingFsm, LogLevel.Error, text, true);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00130791 File Offset: 0x0012E991
		public static void LogWarning(string text)
		{
			ActionHelpers.DebugLog(FsmExecutionStack.ExecutingFsm, LogLevel.Warning, text, true);
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x001307A0 File Offset: 0x0012E9A0
		public static string FormatUnityLogString(string text)
		{
			if (FsmExecutionStack.ExecutingFsm == null)
			{
				return text;
			}
			string str = Fsm.GetFullFsmLabel(FsmExecutionStack.ExecutingFsm);
			if (FsmExecutionStack.ExecutingState != null)
			{
				str = str + " : " + FsmExecutionStack.ExecutingStateName;
			}
			if (FsmExecutionStack.ExecutingAction != null)
			{
				str += FsmExecutionStack.ExecutingAction.Name;
			}
			return str + " : " + text;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00008204 File Offset: 0x00006404
		public static string GetValueLabel(INamedVariable variable)
		{
			return "";
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x001307FF File Offset: 0x0012E9FF
		public static string GetValueLabel(Fsm fsm, FsmOwnerDefault ownerDefault)
		{
			if (ownerDefault == null)
			{
				return "[null]";
			}
			if (ownerDefault.OwnerOption == OwnerDefaultOption.UseOwner)
			{
				return "Owner";
			}
			return ActionHelpers.GetValueLabel(ownerDefault.GameObject);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00130823 File Offset: 0x0012EA23
		public static string AutoName(FsmStateAction action, params INamedVariable[] exposedFields)
		{
			if (action != null)
			{
				return ActionHelpers.AutoName(action.GetType().Name, exposedFields);
			}
			return null;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0013083C File Offset: 0x0012EA3C
		public static string AutoName(string actionName, params INamedVariable[] exposedFields)
		{
			string text = actionName + " :";
			foreach (INamedVariable variable in exposedFields)
			{
				text = text + " " + ActionHelpers.GetValueLabel(variable);
			}
			return text;
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0013087C File Offset: 0x0012EA7C
		public static string AutoNameRange(FsmStateAction action, NamedVariable min, NamedVariable max)
		{
			if (action != null)
			{
				return ActionHelpers.AutoNameRange(action.GetType().Name, min, max);
			}
			return null;
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00130895 File Offset: 0x0012EA95
		public static string AutoNameRange(string actionName, NamedVariable min, NamedVariable max)
		{
			return string.Concat(new string[]
			{
				actionName,
				" : ",
				ActionHelpers.GetValueLabel(min),
				" - ",
				ActionHelpers.GetValueLabel(max)
			});
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x001308C8 File Offset: 0x0012EAC8
		public static string AutoNameSetVar(FsmStateAction action, NamedVariable var, NamedVariable value)
		{
			if (action != null)
			{
				return ActionHelpers.AutoNameSetVar(action.GetType().Name, var, value);
			}
			return null;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x001308E1 File Offset: 0x0012EAE1
		public static string AutoNameSetVar(string actionName, NamedVariable var, NamedVariable value)
		{
			return string.Concat(new string[]
			{
				actionName,
				" : ",
				ActionHelpers.GetValueLabel(var),
				" = ",
				ActionHelpers.GetValueLabel(value)
			});
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x00130914 File Offset: 0x0012EB14
		public static string AutoNameConvert(FsmStateAction action, NamedVariable fromVariable, NamedVariable toVariable)
		{
			if (action != null)
			{
				return ActionHelpers.AutoNameConvert(action.GetType().Name, fromVariable, toVariable);
			}
			return null;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00130930 File Offset: 0x0012EB30
		public static string AutoNameConvert(string actionName, NamedVariable fromVariable, NamedVariable toVariable)
		{
			return string.Concat(new string[]
			{
				actionName.Replace("Convert", ""),
				" : ",
				ActionHelpers.GetValueLabel(fromVariable),
				" to ",
				ActionHelpers.GetValueLabel(toVariable)
			});
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x0013097D File Offset: 0x0012EB7D
		public static string AutoNameGetProperty(FsmStateAction action, NamedVariable property, NamedVariable store)
		{
			if (action != null)
			{
				return ActionHelpers.AutoNameGetProperty(action.GetType().Name, property, store);
			}
			return null;
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00130996 File Offset: 0x0012EB96
		public static string AutoNameGetProperty(string actionName, NamedVariable property, NamedVariable store)
		{
			return string.Concat(new string[]
			{
				actionName,
				" : ",
				ActionHelpers.GetValueLabel(property),
				" -> ",
				ActionHelpers.GetValueLabel(store)
			});
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x001309C9 File Offset: 0x0012EBC9
		[Obsolete("Use LogError instead.")]
		public static void RuntimeError(FsmStateAction action, string error)
		{
			action.LogError(((action != null) ? action.ToString() : null) + " : " + error);
		}

		// Token: 0x0400334F RID: 13135
		public static RaycastHit mousePickInfo;

		// Token: 0x04003350 RID: 13136
		private static float mousePickRaycastTime;

		// Token: 0x04003351 RID: 13137
		private static float mousePickDistanceUsed;

		// Token: 0x04003352 RID: 13138
		private static int mousePickLayerMaskUsed;
	}
}
