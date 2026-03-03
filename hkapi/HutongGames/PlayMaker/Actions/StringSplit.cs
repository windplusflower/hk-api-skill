using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF5 RID: 3317
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Splits a string into substrings using separator characters.")]
	public class StringSplit : FsmStateAction
	{
		// Token: 0x060044EA RID: 17642 RVA: 0x001778CF File Offset: 0x00175ACF
		public override void Reset()
		{
			this.stringToSplit = null;
			this.separators = null;
			this.trimStrings = false;
			this.trimChars = null;
			this.stringArray = null;
		}

		// Token: 0x060044EB RID: 17643 RVA: 0x001778FC File Offset: 0x00175AFC
		public override void OnEnter()
		{
			char[] array = this.trimChars.Value.ToCharArray();
			if (!this.stringToSplit.IsNone && !this.stringArray.IsNone)
			{
				FsmArray fsmArray = this.stringArray;
				object[] values = this.stringToSplit.Value.Split(this.separators.Value.ToCharArray());
				fsmArray.Values = values;
				if (this.trimStrings.Value)
				{
					for (int i = 0; i < this.stringArray.Values.Length; i++)
					{
						string text = this.stringArray.Values[i] as string;
						if (text != null)
						{
							if (!this.trimChars.IsNone && array.Length != 0)
							{
								this.stringArray.Set(i, text.Trim(array));
							}
							else
							{
								this.stringArray.Set(i, text.Trim());
							}
						}
					}
				}
				this.stringArray.SaveChanges();
			}
			base.Finish();
		}

		// Token: 0x04004938 RID: 18744
		[UIHint(UIHint.Variable)]
		[Tooltip("String to split.")]
		public FsmString stringToSplit;

		// Token: 0x04004939 RID: 18745
		[Tooltip("Characters used to split the string.\nUse '\\n' for newline\nUse '\\t' for tab")]
		public FsmString separators;

		// Token: 0x0400493A RID: 18746
		[Tooltip("Remove all leading and trailing white-space characters from each seperated string.")]
		public FsmBool trimStrings;

		// Token: 0x0400493B RID: 18747
		[Tooltip("Optional characters used to trim each seperated string.")]
		public FsmString trimChars;

		// Token: 0x0400493C RID: 18748
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.String, "", 0, 0, 65536)]
		[Tooltip("Store the split strings in a String Array.")]
		public FsmArray stringArray;
	}
}
