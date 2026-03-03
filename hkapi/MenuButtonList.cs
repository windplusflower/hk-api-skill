using System;
using System.Collections;
using System.Collections.Generic;
using GlobalEnums;
using Modding;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Token: 0x0200048A RID: 1162
public class MenuButtonList : MonoBehaviour
{
	// Token: 0x06001A14 RID: 6676 RVA: 0x0007D798 File Offset: 0x0007B998
	private void Awake()
	{
		MenuScreen component = base.GetComponent<MenuScreen>();
		if (component)
		{
			component.defaultHighlight = null;
		}
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x0007D7BC File Offset: 0x0007B9BC
	protected void Start()
	{
		MenuButtonList.menuButtonLists.Add(this);
		this.activeSelectables = new List<Selectable>();
		for (int i = 0; i < this.entries.Length; i++)
		{
			MenuButtonList.Entry entry = this.entries[i];
			Selectable selectable = entry.Selectable;
			MenuButtonListCondition condition = entry.Condition;
			if (condition == null || condition.IsFulfilled())
			{
				if (!this.skipDisabled)
				{
					selectable.gameObject.SetActive(true);
					if (entry.AlsoAffectParent)
					{
						selectable.transform.parent.gameObject.SetActive(true);
						selectable.interactable = true;
					}
				}
				if (!this.skipDisabled || (selectable.gameObject.activeInHierarchy && selectable.interactable))
				{
					this.activeSelectables.Add(selectable);
				}
			}
			else
			{
				selectable.gameObject.SetActive(false);
				if (entry.AlsoAffectParent)
				{
					selectable.transform.parent.gameObject.SetActive(false);
					selectable.interactable = false;
				}
			}
		}
		for (int j = 0; j < this.activeSelectables.Count; j++)
		{
			Selectable selectable2 = this.activeSelectables[j];
			Selectable selectOnUp = this.activeSelectables[(j + this.activeSelectables.Count - 1) % this.activeSelectables.Count];
			Selectable selectOnDown = this.activeSelectables[(j + 1) % this.activeSelectables.Count];
			Navigation navigation = selectable2.navigation;
			if (navigation.mode == Navigation.Mode.Explicit)
			{
				navigation.selectOnUp = selectOnUp;
				navigation.selectOnDown = selectOnDown;
				selectable2.navigation = navigation;
			}
			if (this.isTopLevelMenu)
			{
				CancelAction cancelAction = (!Platform.Current.WillDisplayQuitButton) ? CancelAction.DoNothing : CancelAction.GoToExitPrompt;
				MenuButton menuButton = selectable2 as MenuButton;
				if (menuButton != null)
				{
					menuButton.cancelAction = cancelAction;
				}
			}
		}
		using (List<Selectable>.Enumerator enumerator = this.activeSelectables.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				MenuSelectable menuSelectable = (MenuSelectable)enumerator.Current;
				menuSelectable.OnSelected += delegate(MenuSelectable self)
				{
					if (this.isTopLevelMenu || menuSelectable != (MenuSelectable)this.activeSelectables[this.activeSelectables.Count - 1])
					{
						this.lastSelected = self;
					}
				};
			}
		}
		this.DoSelect();
		this.started = true;
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x0007DA10 File Offset: 0x0007BC10
	private void OnEnable()
	{
		if (this.started)
		{
			this.DoSelect();
		}
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x0007DA20 File Offset: 0x0007BC20
	private void DoSelect()
	{
		if (this.lastSelected)
		{
			base.StartCoroutine(this.SelectDelayed(this.lastSelected));
			return;
		}
		if (this.activeSelectables != null && this.activeSelectables.Count > 0)
		{
			base.StartCoroutine(this.SelectDelayed(this.activeSelectables[0].GetFirstInteractable()));
		}
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x0007DA82 File Offset: 0x0007BC82
	private void OnDestroy()
	{
		MenuButtonList.menuButtonLists.Remove(this);
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x0007DA90 File Offset: 0x0007BC90
	private IEnumerator SelectDelayed(Selectable selectable)
	{
		while (!selectable.gameObject.activeInHierarchy)
		{
			yield return null;
		}
		if (selectable is MenuSelectable)
		{
			((MenuSelectable)selectable).DontPlaySelectSound = true;
		}
		selectable.Select();
		if (selectable is MenuSelectable)
		{
			((MenuSelectable)selectable).DontPlaySelectSound = false;
		}
		foreach (Animator animator in selectable.GetComponentsInChildren<Animator>())
		{
			if (animator.HasParameter("hide", null))
			{
				animator.ResetTrigger("hide");
			}
			if (animator.HasParameter("show", null))
			{
				animator.SetTrigger("show");
			}
		}
		yield break;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x0007DA9F File Offset: 0x0007BC9F
	public void ClearLastSelected()
	{
		this.lastSelected = null;
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
	public static void ClearAllLastSelected()
	{
		foreach (MenuButtonList menuButtonList in MenuButtonList.menuButtonLists)
		{
			menuButtonList.ClearLastSelected();
		}
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x0007DAF8 File Offset: 0x0007BCF8
	// Note: this type is marked as 'beforefieldinit'.
	static MenuButtonList()
	{
		MenuButtonList.menuButtonLists = new List<MenuButtonList>();
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x0007DB04 File Offset: 0x0007BD04
	public void AddSelectable(Selectable sel)
	{
		if (this.entries != null)
		{
			this.AddSelectable(sel, this.entries.Length);
		}
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0007DB1D File Offset: 0x0007BD1D
	public void AddSelectableEnd(Selectable sel, int controlButtons)
	{
		this.AddSelectable(sel, this.entries.Length - controlButtons);
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0007DB30 File Offset: 0x0007BD30
	public void AddSelectable(Selectable sel, int index)
	{
		if (sel == null || this.entries == null || index < 0 || index > this.entries.Length)
		{
			return;
		}
		MenuButtonList.Entry[] array = new MenuButtonList.Entry[this.entries.Length + 1];
		for (int i = 0; i < index; i++)
		{
			array[i] = this.entries[i];
		}
		MenuButtonList.Entry entry = new MenuButtonList.Entry();
		ReflectionHelper.SetField<MenuButtonList.Entry, Selectable>(entry, "selectable", sel);
		array[index] = entry;
		for (int j = index + 1; j < array.Length; j++)
		{
			array[j] = this.entries[j - 1];
		}
		this.entries = array;
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0007DBBF File Offset: 0x0007BDBF
	public void ClearSelectables()
	{
		this.entries = new MenuButtonList.Entry[0];
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x0007DBCD File Offset: 0x0007BDCD
	public void RecalculateNavigation()
	{
		MenuButtonList.menuButtonLists.Remove(this);
		this.Start();
	}

	// Token: 0x04001F6F RID: 8047
	[SerializeField]
	private MenuButtonList.Entry[] entries;

	// Token: 0x04001F70 RID: 8048
	[SerializeField]
	private bool isTopLevelMenu;

	// Token: 0x04001F71 RID: 8049
	[SerializeField]
	private bool skipDisabled;

	// Token: 0x04001F72 RID: 8050
	private MenuSelectable lastSelected;

	// Token: 0x04001F73 RID: 8051
	private List<Selectable> activeSelectables;

	// Token: 0x04001F74 RID: 8052
	private static List<MenuButtonList> menuButtonLists;

	// Token: 0x04001F75 RID: 8053
	private bool started;

	// Token: 0x0200048B RID: 1163
	[Serializable]
	private class Entry
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0007DBE1 File Offset: 0x0007BDE1
		public Selectable Selectable
		{
			get
			{
				return this.selectable;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0007DBE9 File Offset: 0x0007BDE9
		public MenuButtonListCondition Condition
		{
			get
			{
				return this.condition;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0007DBF1 File Offset: 0x0007BDF1
		public bool AlsoAffectParent
		{
			get
			{
				return this.alsoAffectParent;
			}
		}

		// Token: 0x04001F76 RID: 8054
		[SerializeField]
		[FormerlySerializedAs("button")]
		private Selectable selectable;

		// Token: 0x04001F77 RID: 8055
		[SerializeField]
		private MenuButtonListCondition condition;

		// Token: 0x04001F78 RID: 8056
		[SerializeField]
		private bool alsoAffectParent;
	}
}
