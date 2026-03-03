using System;

namespace HutongGames.PlayMaker.Ecosystem.Utils
{
	// Token: 0x020008C2 RID: 2242
	[AttributeUsage(AttributeTargets.All)]
	public class EventTargetVariable : Attribute
	{
		// Token: 0x06003219 RID: 12825 RVA: 0x001309E9 File Offset: 0x0012EBE9
		public EventTargetVariable(string variable)
		{
			this.variable = variable;
		}

		// Token: 0x04003353 RID: 13139
		public string variable;
	}
}
