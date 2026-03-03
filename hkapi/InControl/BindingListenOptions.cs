using System;

namespace InControl
{
	// Token: 0x020006BC RID: 1724
	public class BindingListenOptions
	{
		// Token: 0x060028C5 RID: 10437 RVA: 0x000E4DDA File Offset: 0x000E2FDA
		public bool CallOnBindingFound(PlayerAction playerAction, BindingSource bindingSource)
		{
			return this.OnBindingFound == null || this.OnBindingFound(playerAction, bindingSource);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000E4DF3 File Offset: 0x000E2FF3
		public void CallOnBindingAdded(PlayerAction playerAction, BindingSource bindingSource)
		{
			if (this.OnBindingAdded != null)
			{
				this.OnBindingAdded(playerAction, bindingSource);
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000E4E0A File Offset: 0x000E300A
		public void CallOnBindingRejected(PlayerAction playerAction, BindingSource bindingSource, BindingSourceRejectionType bindingSourceRejectionType)
		{
			if (this.OnBindingRejected != null)
			{
				this.OnBindingRejected(playerAction, bindingSource, bindingSourceRejectionType);
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000E4E22 File Offset: 0x000E3022
		public void CallOnBindingEnded(PlayerAction playerAction)
		{
			if (this.OnBindingEnded != null)
			{
				this.OnBindingEnded(playerAction);
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000E4E38 File Offset: 0x000E3038
		public BindingListenOptions()
		{
			this.IncludeControllers = true;
			this.IncludeNonStandardControls = true;
			this.IncludeKeys = true;
			base..ctor();
		}

		// Token: 0x04002EB6 RID: 11958
		public bool IncludeControllers;

		// Token: 0x04002EB7 RID: 11959
		public bool IncludeUnknownControllers;

		// Token: 0x04002EB8 RID: 11960
		public bool IncludeNonStandardControls;

		// Token: 0x04002EB9 RID: 11961
		public bool IncludeMouseButtons;

		// Token: 0x04002EBA RID: 11962
		public bool IncludeMouseScrollWheel;

		// Token: 0x04002EBB RID: 11963
		public bool IncludeKeys;

		// Token: 0x04002EBC RID: 11964
		public bool IncludeModifiersAsFirstClassKeys;

		// Token: 0x04002EBD RID: 11965
		public uint MaxAllowedBindings;

		// Token: 0x04002EBE RID: 11966
		public uint MaxAllowedBindingsPerType;

		// Token: 0x04002EBF RID: 11967
		public bool AllowDuplicateBindingsPerSet;

		// Token: 0x04002EC0 RID: 11968
		public bool UnsetDuplicateBindingsOnSet;

		// Token: 0x04002EC1 RID: 11969
		public bool RejectRedundantBindings;

		// Token: 0x04002EC2 RID: 11970
		public BindingSource ReplaceBinding;

		// Token: 0x04002EC3 RID: 11971
		public Func<PlayerAction, BindingSource, bool> OnBindingFound;

		// Token: 0x04002EC4 RID: 11972
		public Action<PlayerAction, BindingSource> OnBindingAdded;

		// Token: 0x04002EC5 RID: 11973
		public Action<PlayerAction, BindingSource, BindingSourceRejectionType> OnBindingRejected;

		// Token: 0x04002EC6 RID: 11974
		public Action<PlayerAction> OnBindingEnded;
	}
}
