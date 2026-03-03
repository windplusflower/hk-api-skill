using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Modding.Menu.Components
{
	/// <summary>
	/// A component to automatically select a menu item.
	/// </summary>
	// Token: 0x02000DD9 RID: 3545
	public class AutoSelector : MonoBehaviour
	{
		/// <summary>
		/// The menu item to select.
		/// </summary>
		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06004945 RID: 18757 RVA: 0x0018CF2A File Offset: 0x0018B12A
		// (set) Token: 0x06004946 RID: 18758 RVA: 0x0018CF32 File Offset: 0x0018B132
		public Selectable Start { get; set; }

		// Token: 0x06004947 RID: 18759 RVA: 0x0018CF3B File Offset: 0x0018B13B
		private void OnEnable()
		{
			if (this.Start != null)
			{
				base.StartCoroutine(this.SelectDelayed(this.Start));
			}
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0018CF5E File Offset: 0x0018B15E
		private IEnumerator SelectDelayed(Selectable selectable)
		{
			AutoSelector.<SelectDelayed>d__5 <SelectDelayed>d__ = new AutoSelector.<SelectDelayed>d__5(0);
			<SelectDelayed>d__.selectable = selectable;
			return <SelectDelayed>d__;
		}
	}
}
