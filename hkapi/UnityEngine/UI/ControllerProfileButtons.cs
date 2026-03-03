using System;

namespace UnityEngine.UI
{
	// Token: 0x02000687 RID: 1671
	public class ControllerProfileButtons : MonoBehaviour
	{
		// Token: 0x0600279D RID: 10141 RVA: 0x000DF54C File Offset: 0x000DD74C
		public void SelectItem(int num)
		{
			switch (num)
			{
			case 1:
				this.profileHighlight1.gameObject.SetActive(true);
				this.profileHighlight2.gameObject.SetActive(false);
				this.profileHighlight3.gameObject.SetActive(false);
				this.profileHighlight4.gameObject.SetActive(false);
				return;
			case 2:
				this.profileHighlight1.gameObject.SetActive(false);
				this.profileHighlight2.gameObject.SetActive(true);
				this.profileHighlight3.gameObject.SetActive(false);
				this.profileHighlight4.gameObject.SetActive(false);
				return;
			case 3:
				this.profileHighlight1.gameObject.SetActive(false);
				this.profileHighlight2.gameObject.SetActive(false);
				this.profileHighlight3.gameObject.SetActive(true);
				this.profileHighlight4.gameObject.SetActive(false);
				return;
			case 4:
				this.profileHighlight1.gameObject.SetActive(false);
				this.profileHighlight2.gameObject.SetActive(false);
				this.profileHighlight3.gameObject.SetActive(false);
				this.profileHighlight4.gameObject.SetActive(true);
				return;
			default:
				Debug.LogError("Invalid profile button ID");
				return;
			}
		}

		// Token: 0x04002CCD RID: 11469
		public Image profileHighlight1;

		// Token: 0x04002CCE RID: 11470
		public Image profileHighlight2;

		// Token: 0x04002CCF RID: 11471
		public Image profileHighlight3;

		// Token: 0x04002CD0 RID: 11472
		public Image profileHighlight4;
	}
}
