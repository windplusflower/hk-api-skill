using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000957 RID: 2391
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Split a text asset or string into an arrayList")]
	public class SplitTextToArrayList : ArrayListActions
	{
		// Token: 0x06003496 RID: 13462 RVA: 0x00139D9E File Offset: 0x00137F9E
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.startIndex = null;
			this.parseRange = null;
			this.textAsset = null;
			this.split = SplitTextToArrayList.SplitSpecialChars.NewLine;
			this.parseAsType = SplitTextToArrayList.ArrayMakerParseStringAs.String;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00139DD1 File Offset: 0x00137FD1
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.splitText();
			}
			base.Finish();
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00139E04 File Offset: 0x00138004
		public void splitText()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			string text;
			if (this.OrThisString.Value.Length == 0)
			{
				if (this.textAsset == null)
				{
					return;
				}
				text = this.textAsset.text;
			}
			else
			{
				text = this.OrThisString.Value;
			}
			this.proxy.arrayList.Clear();
			string[] array;
			if (this.OrThisChar.Value.Length == 0)
			{
				char c = '\n';
				SplitTextToArrayList.SplitSpecialChars splitSpecialChars = this.split;
				if (splitSpecialChars != SplitTextToArrayList.SplitSpecialChars.Tab)
				{
					if (splitSpecialChars == SplitTextToArrayList.SplitSpecialChars.Space)
					{
						c = ' ';
					}
				}
				else
				{
					c = '\t';
				}
				array = text.Split(new char[]
				{
					c
				});
			}
			else
			{
				array = text.Split(this.OrThisChar.Value.ToCharArray());
			}
			int value = this.startIndex.Value;
			int num = array.Length;
			if (this.parseRange.Value > 0)
			{
				num = Mathf.Min(num - value, this.parseRange.Value);
			}
			string[] array2 = new string[num];
			int num2 = 0;
			for (int i = value; i < value + num; i++)
			{
				array2[num2] = array[i];
				num2++;
			}
			if (this.parseAsType == SplitTextToArrayList.ArrayMakerParseStringAs.String)
			{
				this.proxy.arrayList.InsertRange(0, array2);
				return;
			}
			if (this.parseAsType == SplitTextToArrayList.ArrayMakerParseStringAs.Int)
			{
				int[] array3 = new int[array2.Length];
				int num3 = 0;
				string[] array4 = array2;
				for (int j = 0; j < array4.Length; j++)
				{
					int.TryParse(array4[j], out array3[num3]);
					num3++;
				}
				this.proxy.arrayList.InsertRange(0, array3);
				return;
			}
			if (this.parseAsType == SplitTextToArrayList.ArrayMakerParseStringAs.Float)
			{
				float[] array5 = new float[array2.Length];
				int num4 = 0;
				string[] array4 = array2;
				for (int j = 0; j < array4.Length; j++)
				{
					float.TryParse(array4[j], out array5[num4]);
					num4++;
				}
				this.proxy.arrayList.InsertRange(0, array5);
			}
		}

		// Token: 0x04003643 RID: 13891
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003644 RID: 13892
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003645 RID: 13893
		[Tooltip("From where to start parsing, leave to 0 to start from the beginning")]
		public FsmInt startIndex;

		// Token: 0x04003646 RID: 13894
		[Tooltip("the range of parsing")]
		public FsmInt parseRange;

		// Token: 0x04003647 RID: 13895
		[ActionSection("Source")]
		[Tooltip("Text asset source")]
		public TextAsset textAsset;

		// Token: 0x04003648 RID: 13896
		[Tooltip("Text Asset is ignored if this is set.")]
		public FsmString OrThisString;

		// Token: 0x04003649 RID: 13897
		[ActionSection("Split")]
		[Tooltip("Split")]
		public SplitTextToArrayList.SplitSpecialChars split;

		// Token: 0x0400364A RID: 13898
		[Tooltip("Split is ignored if this value is not empty. Each chars taken in account for split")]
		public FsmString OrThisChar;

		// Token: 0x0400364B RID: 13899
		[ActionSection("Value")]
		[Tooltip("Parse the line as a specific type")]
		public SplitTextToArrayList.ArrayMakerParseStringAs parseAsType;

		// Token: 0x02000958 RID: 2392
		public enum ArrayMakerParseStringAs
		{
			// Token: 0x0400364D RID: 13901
			String,
			// Token: 0x0400364E RID: 13902
			Int,
			// Token: 0x0400364F RID: 13903
			Float
		}

		// Token: 0x02000959 RID: 2393
		public enum SplitSpecialChars
		{
			// Token: 0x04003651 RID: 13905
			NewLine,
			// Token: 0x04003652 RID: 13906
			Tab,
			// Token: 0x04003653 RID: 13907
			Space
		}
	}
}
