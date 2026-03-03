using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A34 RID: 2612
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Sends a Message to a Game Object. See Unity docs for SendMessage.")]
	public class SendMessageV2 : FsmStateAction
	{
		// Token: 0x060038AF RID: 14511 RVA: 0x0014B81F File Offset: 0x00149A1F
		public override void Reset()
		{
			this.gameObject = null;
			this.delivery = SendMessageV2.MessageType.SendMessage;
			this.options = SendMessageOptions.DontRequireReceiver;
			this.functionCall = null;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x0014B83D File Offset: 0x00149A3D
		public override void OnUpdate()
		{
			this.DoSendMessage();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x0014B854 File Offset: 0x00149A54
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
						if (num != 398550328U)
						{
							if (num != 810547195U)
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
						else if (parameterType == "string")
						{
							obj = this.functionCall.StringParameter.Value;
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
				else if (num <= 3365180733U)
				{
					if (num != 2797886853U)
					{
						if (num != 3289806692U)
						{
							if (num == 3365180733U)
							{
								if (parameterType == "bool")
								{
									obj = this.functionCall.BoolParameter.Value;
								}
							}
						}
						else if (parameterType == "GameObject")
						{
							obj = this.functionCall.GameObjectParameter.Value;
						}
					}
					else if (parameterType == "float")
					{
						obj = this.functionCall.FloatParameter.Value;
					}
				}
				else if (num <= 3731074221U)
				{
					if (num != 3419754368U)
					{
						if (num == 3731074221U)
						{
							if (parameterType == "Quaternion")
							{
								obj = this.functionCall.QuaternionParameter.Value;
							}
						}
					}
					else if (parameterType == "Material")
					{
						obj = this.functionCall.MaterialParameter.Value;
					}
				}
				else if (num != 3851314394U)
				{
					if (num == 3853794552U)
					{
						if (parameterType == "Color")
						{
							obj = this.functionCall.ColorParameter.Value;
						}
					}
				}
				else if (parameterType == "Object")
				{
					obj = this.functionCall.ObjectParameter.Value;
				}
			}
			switch (this.delivery)
			{
			case SendMessageV2.MessageType.SendMessage:
				ownerDefaultTarget.SendMessage(this.functionCall.FunctionName, obj, this.options);
				return;
			case SendMessageV2.MessageType.SendMessageUpwards:
				ownerDefaultTarget.SendMessageUpwards(this.functionCall.FunctionName, obj, this.options);
				return;
			case SendMessageV2.MessageType.BroadcastMessage:
				ownerDefaultTarget.BroadcastMessage(this.functionCall.FunctionName, obj, this.options);
				return;
			default:
				return;
			}
		}

		// Token: 0x04003B55 RID: 15189
		[RequiredField]
		[Tooltip("GameObject that sends the message.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B56 RID: 15190
		[Tooltip("Where to send the message.\nSee Unity docs.")]
		public SendMessageV2.MessageType delivery;

		// Token: 0x04003B57 RID: 15191
		[Tooltip("Send options.\nSee Unity docs.")]
		public SendMessageOptions options;

		// Token: 0x04003B58 RID: 15192
		[RequiredField]
		public FunctionCall functionCall;

		// Token: 0x04003B59 RID: 15193
		public bool everyFrame;

		// Token: 0x02000A35 RID: 2613
		public enum MessageType
		{
			// Token: 0x04003B5B RID: 15195
			SendMessage,
			// Token: 0x04003B5C RID: 15196
			SendMessageUpwards,
			// Token: 0x04003B5D RID: 15197
			BroadcastMessage
		}
	}
}
