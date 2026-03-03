using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C8B RID: 3211
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Sends a Message to a Game Object. See Unity docs for SendMessage.")]
	public class SendMessage : FsmStateAction
	{
		// Token: 0x06004315 RID: 17173 RVA: 0x0017200E File Offset: 0x0017020E
		public override void Reset()
		{
			this.gameObject = null;
			this.delivery = SendMessage.MessageType.SendMessage;
			this.options = SendMessageOptions.DontRequireReceiver;
			this.functionCall = null;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x0017202C File Offset: 0x0017022C
		public override void OnEnter()
		{
			this.DoSendMessage();
			base.Finish();
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x0017203C File Offset: 0x0017023C
		private void DoSendMessage()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			object obj = null;
			string parameterType = this.functionCall.ParameterType;
			if (parameterType != null)
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(parameterType);
				if (num <= 2571916692U)
				{
					if (num <= 1796249895U)
					{
						if (num <= 398550328U)
						{
							if (num != 382270662U)
							{
								if (num == 398550328U)
								{
									if (parameterType == "string")
									{
										obj = this.functionCall.StringParameter.Value;
									}
								}
							}
							else if (parameterType == "Array")
							{
								obj = this.functionCall.ArrayParameter.Values;
							}
						}
						else if (num != 810547195U)
						{
							if (num == 1796249895U)
							{
								if (parameterType == "Rect")
								{
									obj = this.functionCall.RectParamater.Value;
								}
							}
						}
						else if (!(parameterType == "None"))
						{
						}
					}
					else if (num <= 2214621635U)
					{
						if (num != 2197844016U)
						{
							if (num == 2214621635U)
							{
								if (parameterType == "Vector3")
								{
									obj = this.functionCall.Vector3Parameter.Value;
								}
							}
						}
						else if (parameterType == "Vector2")
						{
							obj = this.functionCall.Vector2Parameter.Value;
						}
					}
					else if (num != 2515107422U)
					{
						if (num == 2571916692U)
						{
							if (parameterType == "Texture")
							{
								obj = this.functionCall.TextureParameter.Value;
							}
						}
					}
					else if (parameterType == "int")
					{
						obj = this.functionCall.IntParameter.Value;
					}
				}
				else if (num <= 3419754368U)
				{
					if (num <= 3289806692U)
					{
						if (num != 2797886853U)
						{
							if (num == 3289806692U)
							{
								if (parameterType == "GameObject")
								{
									obj = this.functionCall.GameObjectParameter.Value;
								}
							}
						}
						else if (parameterType == "float")
						{
							obj = this.functionCall.FloatParameter.Value;
						}
					}
					else if (num != 3365180733U)
					{
						if (num == 3419754368U)
						{
							if (parameterType == "Material")
							{
								obj = this.functionCall.MaterialParameter.Value;
							}
						}
					}
					else if (parameterType == "bool")
					{
						obj = this.functionCall.BoolParameter.Value;
					}
				}
				else if (num <= 3851314394U)
				{
					if (num != 3731074221U)
					{
						if (num == 3851314394U)
						{
							if (parameterType == "Object")
							{
								obj = this.functionCall.ObjectParameter.Value;
							}
						}
					}
					else if (parameterType == "Quaternion")
					{
						obj = this.functionCall.QuaternionParameter.Value;
					}
				}
				else if (num != 3853794552U)
				{
					if (num == 3897416224U)
					{
						if (parameterType == "Enum")
						{
							obj = this.functionCall.EnumParameter.Value;
						}
					}
				}
				else if (parameterType == "Color")
				{
					obj = this.functionCall.ColorParameter.Value;
				}
			}
			switch (this.delivery)
			{
			case SendMessage.MessageType.SendMessage:
				ownerDefaultTarget.SendMessage(this.functionCall.FunctionName, obj, this.options);
				return;
			case SendMessage.MessageType.SendMessageUpwards:
				ownerDefaultTarget.SendMessageUpwards(this.functionCall.FunctionName, obj, this.options);
				return;
			case SendMessage.MessageType.BroadcastMessage:
				ownerDefaultTarget.BroadcastMessage(this.functionCall.FunctionName, obj, this.options);
				return;
			default:
				return;
			}
		}

		// Token: 0x04004769 RID: 18281
		[RequiredField]
		[Tooltip("GameObject that sends the message.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400476A RID: 18282
		[Tooltip("Where to send the message.\nSee Unity docs.")]
		public SendMessage.MessageType delivery;

		// Token: 0x0400476B RID: 18283
		[Tooltip("Send options.\nSee Unity docs.")]
		public SendMessageOptions options;

		// Token: 0x0400476C RID: 18284
		[RequiredField]
		public FunctionCall functionCall;

		// Token: 0x02000C8C RID: 3212
		public enum MessageType
		{
			// Token: 0x0400476E RID: 18286
			SendMessage,
			// Token: 0x0400476F RID: 18287
			SendMessageUpwards,
			// Token: 0x04004770 RID: 18288
			BroadcastMessage
		}
	}
}
