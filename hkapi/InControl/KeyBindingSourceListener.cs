using System;

namespace InControl
{
	// Token: 0x020006C5 RID: 1733
	public class KeyBindingSourceListener : BindingSourceListener
	{
		// Token: 0x06002906 RID: 10502 RVA: 0x000E5368 File Offset: 0x000E3568
		public void Reset()
		{
			this.detectFound.Clear();
			this.detectPhase = 0;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x000E537C File Offset: 0x000E357C
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device)
		{
			if (!listenOptions.IncludeKeys)
			{
				return null;
			}
			if (this.detectFound.IncludeCount > 0 && !this.detectFound.IsPressed && this.detectPhase == 2)
			{
				BindingSource result = new KeyBindingSource(this.detectFound);
				this.Reset();
				return result;
			}
			KeyCombo keyCombo = KeyCombo.Detect(listenOptions.IncludeModifiersAsFirstClassKeys);
			if (keyCombo.IncludeCount > 0)
			{
				if (this.detectPhase == 1)
				{
					this.detectFound = keyCombo;
					this.detectPhase = 2;
				}
			}
			else if (this.detectPhase == 0)
			{
				this.detectPhase = 1;
			}
			return null;
		}

		// Token: 0x04002F5B RID: 12123
		private KeyCombo detectFound;

		// Token: 0x04002F5C RID: 12124
		private int detectPhase;
	}
}
