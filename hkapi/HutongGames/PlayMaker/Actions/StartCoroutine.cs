using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF0 RID: 3312
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Start a Coroutine in a Behaviour on a Game Object. See Unity StartCoroutine docs.")]
	public class StartCoroutine : FsmStateAction
	{
		// Token: 0x060044D8 RID: 17624 RVA: 0x0017732F File Offset: 0x0017552F
		public override void Reset()
		{
			this.gameObject = null;
			this.behaviour = null;
			this.functionCall = null;
			this.stopOnExit = false;
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0017734D File Offset: 0x0017554D
		public override void OnEnter()
		{
			this.DoStartCoroutine();
			base.Finish();
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x0017735C File Offset: 0x0017555C
		private void DoStartCoroutine()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.component = (ownerDefaultTarget.GetComponent(ReflectionUtils.GetGlobalType(this.behaviour.Value)) as MonoBehaviour);
			if (this.component == null)
			{
				base.LogWarning("StartCoroutine: " + ownerDefaultTarget.name + " missing behaviour: " + this.behaviour.Value);
				return;
			}
			string parameterType = this.functionCall.ParameterType;
			if (parameterType == null)
			{
				return;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(parameterType);
			if (num <= 2515107422U)
			{
				if (num <= 1796249895U)
				{
					if (num != 398550328U)
					{
						if (num != 810547195U)
						{
							if (num != 1796249895U)
							{
								return;
							}
							if (!(parameterType == "Rect"))
							{
								return;
							}
							this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.RectParamater.Value);
							return;
						}
						else
						{
							if (!(parameterType == "None"))
							{
								return;
							}
							this.component.StartCoroutine(this.functionCall.FunctionName);
							return;
						}
					}
					else
					{
						if (!(parameterType == "string"))
						{
							return;
						}
						this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.StringParameter.Value);
						return;
					}
				}
				else if (num != 2197844016U)
				{
					if (num != 2214621635U)
					{
						if (num != 2515107422U)
						{
							return;
						}
						if (!(parameterType == "int"))
						{
							return;
						}
						this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.IntParameter.Value);
						return;
					}
					else
					{
						if (!(parameterType == "Vector3"))
						{
							return;
						}
						this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.Vector3Parameter.Value);
						return;
					}
				}
				else
				{
					if (!(parameterType == "Vector2"))
					{
						return;
					}
					this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.Vector2Parameter.Value);
					return;
				}
			}
			else if (num <= 3289806692U)
			{
				if (num != 2571916692U)
				{
					if (num != 2797886853U)
					{
						if (num != 3289806692U)
						{
							return;
						}
						if (!(parameterType == "GameObject"))
						{
							return;
						}
						this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.GameObjectParameter.Value);
						return;
					}
					else
					{
						if (!(parameterType == "float"))
						{
							return;
						}
						this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.FloatParameter.Value);
						return;
					}
				}
				else
				{
					if (!(parameterType == "Texture"))
					{
						return;
					}
					this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.TextureParameter.Value);
					return;
				}
			}
			else if (num <= 3419754368U)
			{
				if (num != 3365180733U)
				{
					if (num != 3419754368U)
					{
						return;
					}
					if (!(parameterType == "Material"))
					{
						return;
					}
					this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.MaterialParameter.Value);
					return;
				}
				else
				{
					if (!(parameterType == "bool"))
					{
						return;
					}
					this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.BoolParameter.Value);
					return;
				}
			}
			else if (num != 3731074221U)
			{
				if (num != 3851314394U)
				{
					return;
				}
				if (!(parameterType == "Object"))
				{
					return;
				}
				this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.ObjectParameter.Value);
				return;
			}
			else
			{
				if (!(parameterType == "Quaternion"))
				{
					return;
				}
				this.component.StartCoroutine(this.functionCall.FunctionName, this.functionCall.QuaternionParameter.Value);
				return;
			}
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00177797 File Offset: 0x00175997
		public override void OnExit()
		{
			if (this.component == null)
			{
				return;
			}
			if (this.stopOnExit)
			{
				this.component.StopCoroutine(this.functionCall.FunctionName);
			}
		}

		// Token: 0x04004929 RID: 18729
		[RequiredField]
		[Tooltip("The game object that owns the Behaviour.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400492A RID: 18730
		[RequiredField]
		[UIHint(UIHint.Behaviour)]
		[Tooltip("The Behaviour that contains the method to start as a coroutine.")]
		public FsmString behaviour;

		// Token: 0x0400492B RID: 18731
		[RequiredField]
		[UIHint(UIHint.Coroutine)]
		[Tooltip("The name of the coroutine method.")]
		public FunctionCall functionCall;

		// Token: 0x0400492C RID: 18732
		[Tooltip("Stop the coroutine when the state is exited.")]
		public bool stopOnExit;

		// Token: 0x0400492D RID: 18733
		private MonoBehaviour component;
	}
}
