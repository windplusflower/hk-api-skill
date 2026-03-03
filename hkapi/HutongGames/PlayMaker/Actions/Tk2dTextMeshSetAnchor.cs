using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200097F RID: 2431
	[ActionCategory("2D Toolkit/TextMesh")]
	[Tooltip("Set the anchor of a TextMesh. \nChanges will not be updated if commit is OFF. This is so you can change multiple parameters without reconstructing the mesh repeatedly.\n Use tk2dtextMeshCommit or set commit to true on your last change for that mesh. \nNOTE: The Game Object must have a tk2dTextMesh attached.")]
	public class Tk2dTextMeshSetAnchor : FsmStateAction
	{
		// Token: 0x0600355C RID: 13660 RVA: 0x0013BD94 File Offset: 0x00139F94
		private void _getTextMesh()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._textMesh = ownerDefaultTarget.GetComponent<tk2dTextMesh>();
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0013BDC9 File Offset: 0x00139FC9
		public override void Reset()
		{
			this.gameObject = null;
			this.textAnchor = TextAnchor.LowerLeft;
			this.OrTextAnchorString = "";
			this.commit = true;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0013BDF5 File Offset: 0x00139FF5
		public override void OnEnter()
		{
			this._getTextMesh();
			this.DoSetAnchor();
			base.Finish();
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0013BE0C File Offset: 0x0013A00C
		private void DoSetAnchor()
		{
			if (this._textMesh == null)
			{
				base.LogWarning("Missing tk2dTextMesh component: " + this._textMesh.gameObject.name);
				return;
			}
			bool flag = false;
			TextAnchor textAnchor = this.textAnchor;
			if (this.OrTextAnchorString.Value != "")
			{
				bool flag2 = false;
				TextAnchor textAnchorFromString = this.getTextAnchorFromString(this.OrTextAnchorString.Value, out flag2);
				if (flag2)
				{
					textAnchor = textAnchorFromString;
				}
			}
			if (this._textMesh.anchor != textAnchor)
			{
				this._textMesh.anchor = textAnchor;
				flag = true;
			}
			if (this.commit.Value && flag)
			{
				this._textMesh.Commit();
			}
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0013BEBC File Offset: 0x0013A0BC
		public override string ErrorCheck()
		{
			if (this.OrTextAnchorString.Value != "")
			{
				bool flag = false;
				this.getTextAnchorFromString(this.OrTextAnchorString.Value, out flag);
				if (!flag)
				{
					return "Text Anchor string '" + this.OrTextAnchorString.Value + "' is not valid. Use (case insensitive): LowerLeft,LowerCenter,LowerRight,MiddleLeft,MiddleCenter,MiddleRight,UpperLeft,UpperCenter or UpperRight";
				}
			}
			return null;
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0013BF18 File Offset: 0x0013A118
		private TextAnchor getTextAnchorFromString(string textAnchorString, out bool isValid)
		{
			isValid = true;
			string text = textAnchorString.ToLower();
			if (text != null)
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 1908354376U)
				{
					if (num <= 1105326723U)
					{
						if (num != 715965102U)
						{
							if (num == 1105326723U)
							{
								if (text == "upperright")
								{
									return TextAnchor.UpperRight;
								}
							}
						}
						else if (text == "upperleft")
						{
							return TextAnchor.UpperLeft;
						}
					}
					else if (num != 1288498647U)
					{
						if (num == 1908354376U)
						{
							if (text == "lowerright")
							{
								return TextAnchor.LowerRight;
							}
						}
					}
					else if (text == "lowerleft")
					{
						return TextAnchor.LowerLeft;
					}
				}
				else if (num <= 2713264041U)
				{
					if (num != 2471591370U)
					{
						if (num == 2713264041U)
						{
							if (text == "middleleft")
							{
								return TextAnchor.MiddleLeft;
							}
						}
					}
					else if (text == "middleright")
					{
						return TextAnchor.MiddleRight;
					}
				}
				else if (num != 2975192015U)
				{
					if (num != 3984702913U)
					{
						if (num == 4156319434U)
						{
							if (text == "uppercenter")
							{
								return TextAnchor.UpperCenter;
							}
						}
					}
					else if (text == "middlecenter")
					{
						return TextAnchor.MiddleCenter;
					}
				}
				else if (text == "lowercenter")
				{
					return TextAnchor.LowerCenter;
				}
			}
			isValid = false;
			return TextAnchor.LowerLeft;
		}

		// Token: 0x040036EB RID: 14059
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dTextMesh component attached.")]
		[CheckForComponent(typeof(tk2dTextMesh))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036EC RID: 14060
		[Tooltip("The anchor")]
		public TextAnchor textAnchor;

		// Token: 0x040036ED RID: 14061
		[Tooltip("The anchor as a string (text Anchor setting will be ignore if set). \npossible values ( case insensitive): LowerLeft,LowerCenter,LowerRight,MiddleLeft,MiddleCenter,MiddleRight,UpperLeft,UpperCenter or UpperRight ")]
		[UIHint(UIHint.FsmString)]
		public FsmString OrTextAnchorString;

		// Token: 0x040036EE RID: 14062
		[Tooltip("Commit changes")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool commit;

		// Token: 0x040036EF RID: 14063
		private tk2dTextMesh _textMesh;
	}
}
