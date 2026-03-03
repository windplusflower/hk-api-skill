using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x020005E4 RID: 1508
	[AddComponentMenu("UI/TMP Dropdown", 35)]
	[RequireComponent(typeof(RectTransform))]
	public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000B5385 File Offset: 0x000B3585
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x000B538D File Offset: 0x000B358D
		public RectTransform template
		{
			get
			{
				return this.m_Template;
			}
			set
			{
				this.m_Template = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000B539C File Offset: 0x000B359C
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x000B53A4 File Offset: 0x000B35A4
		public TMP_Text captionText
		{
			get
			{
				return this.m_CaptionText;
			}
			set
			{
				this.m_CaptionText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000B53B3 File Offset: 0x000B35B3
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x000B53BB File Offset: 0x000B35BB
		public Image captionImage
		{
			get
			{
				return this.m_CaptionImage;
			}
			set
			{
				this.m_CaptionImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000B53CA File Offset: 0x000B35CA
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x000B53D2 File Offset: 0x000B35D2
		public TMP_Text itemText
		{
			get
			{
				return this.m_ItemText;
			}
			set
			{
				this.m_ItemText = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000B53E1 File Offset: 0x000B35E1
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x000B53E9 File Offset: 0x000B35E9
		public Image itemImage
		{
			get
			{
				return this.m_ItemImage;
			}
			set
			{
				this.m_ItemImage = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x000B53F8 File Offset: 0x000B35F8
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x000B5405 File Offset: 0x000B3605
		public List<TMP_Dropdown.OptionData> options
		{
			get
			{
				return this.m_Options.options;
			}
			set
			{
				this.m_Options.options = value;
				this.RefreshShownValue();
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x000B5419 File Offset: 0x000B3619
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x000B5421 File Offset: 0x000B3621
		public TMP_Dropdown.DropdownEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				this.m_OnValueChanged = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000B542A File Offset: 0x000B362A
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x000B5434 File Offset: 0x000B3634
		public int value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				if (Application.isPlaying && (value == this.m_Value || this.options.Count == 0))
				{
					return;
				}
				this.m_Value = Mathf.Clamp(value, 0, this.options.Count - 1);
				this.RefreshShownValue();
				this.m_OnValueChanged.Invoke(this.m_Value);
			}
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x000B5490 File Offset: 0x000B3690
		protected TMP_Dropdown()
		{
			this.m_Options = new TMP_Dropdown.OptionDataList();
			this.m_OnValueChanged = new TMP_Dropdown.DropdownEvent();
			this.m_Items = new List<TMP_Dropdown.DropdownItem>();
			base..ctor();
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x000B54BC File Offset: 0x000B36BC
		protected override void Awake()
		{
			this.m_AlphaTweenRunner = new TweenRunner<FloatTween>();
			this.m_AlphaTweenRunner.Init(this);
			if (this.m_CaptionImage)
			{
				this.m_CaptionImage.enabled = (this.m_CaptionImage.sprite != null);
			}
			if (this.m_Template)
			{
				this.m_Template.gameObject.SetActive(false);
			}
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x000B5528 File Offset: 0x000B3728
		public void RefreshShownValue()
		{
			TMP_Dropdown.OptionData optionData = TMP_Dropdown.s_NoOptionData;
			if (this.options.Count > 0)
			{
				optionData = this.options[Mathf.Clamp(this.m_Value, 0, this.options.Count - 1)];
			}
			if (this.m_CaptionText)
			{
				if (optionData != null && optionData.text != null)
				{
					this.m_CaptionText.text = optionData.text;
				}
				else
				{
					this.m_CaptionText.text = "";
				}
			}
			if (this.m_CaptionImage)
			{
				if (optionData != null)
				{
					this.m_CaptionImage.sprite = optionData.image;
				}
				else
				{
					this.m_CaptionImage.sprite = null;
				}
				this.m_CaptionImage.enabled = (this.m_CaptionImage.sprite != null);
			}
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x000B55F4 File Offset: 0x000B37F4
		public void AddOptions(List<TMP_Dropdown.OptionData> options)
		{
			this.options.AddRange(options);
			this.RefreshShownValue();
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000B5608 File Offset: 0x000B3808
		public void AddOptions(List<string> options)
		{
			for (int i = 0; i < options.Count; i++)
			{
				this.options.Add(new TMP_Dropdown.OptionData(options[i]));
			}
			this.RefreshShownValue();
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x000B5644 File Offset: 0x000B3844
		public void AddOptions(List<Sprite> options)
		{
			for (int i = 0; i < options.Count; i++)
			{
				this.options.Add(new TMP_Dropdown.OptionData(options[i]));
			}
			this.RefreshShownValue();
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000B567F File Offset: 0x000B387F
		public void ClearOptions()
		{
			this.options.Clear();
			this.RefreshShownValue();
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000B5694 File Offset: 0x000B3894
		private void SetupTemplate()
		{
			this.validTemplate = false;
			if (!this.m_Template)
			{
				Debug.LogError("The dropdown template is not assigned. The template needs to be assigned and must have a child GameObject with a Toggle component serving as the item.", this);
				return;
			}
			GameObject gameObject = this.m_Template.gameObject;
			gameObject.SetActive(true);
			Toggle componentInChildren = this.m_Template.GetComponentInChildren<Toggle>();
			this.validTemplate = true;
			if (!componentInChildren || componentInChildren.transform == this.template)
			{
				this.validTemplate = false;
				Debug.LogError("The dropdown template is not valid. The template must have a child GameObject with a Toggle component serving as the item.", this.template);
			}
			else if (!(componentInChildren.transform.parent is RectTransform))
			{
				this.validTemplate = false;
				Debug.LogError("The dropdown template is not valid. The child GameObject with a Toggle component (the item) must have a RectTransform on its parent.", this.template);
			}
			else if (this.itemText != null && !this.itemText.transform.IsChildOf(componentInChildren.transform))
			{
				this.validTemplate = false;
				Debug.LogError("The dropdown template is not valid. The Item Text must be on the item GameObject or children of it.", this.template);
			}
			else if (this.itemImage != null && !this.itemImage.transform.IsChildOf(componentInChildren.transform))
			{
				this.validTemplate = false;
				Debug.LogError("The dropdown template is not valid. The Item Image must be on the item GameObject or children of it.", this.template);
			}
			if (!this.validTemplate)
			{
				gameObject.SetActive(false);
				return;
			}
			TMP_Dropdown.DropdownItem dropdownItem = componentInChildren.gameObject.AddComponent<TMP_Dropdown.DropdownItem>();
			dropdownItem.text = this.m_ItemText;
			dropdownItem.image = this.m_ItemImage;
			dropdownItem.toggle = componentInChildren;
			dropdownItem.rectTransform = (RectTransform)componentInChildren.transform;
			Canvas orAddComponent = TMP_Dropdown.GetOrAddComponent<Canvas>(gameObject);
			orAddComponent.overrideSorting = true;
			orAddComponent.sortingOrder = 30000;
			TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>(gameObject);
			TMP_Dropdown.GetOrAddComponent<CanvasGroup>(gameObject);
			gameObject.SetActive(false);
			this.validTemplate = true;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x000B5848 File Offset: 0x000B3A48
		private static T GetOrAddComponent<T>(GameObject go) where T : Component
		{
			T t = go.GetComponent<T>();
			if (!t)
			{
				t = go.AddComponent<T>();
			}
			return t;
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000B5871 File Offset: 0x000B3A71
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			this.Show();
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000B5871 File Offset: 0x000B3A71
		public virtual void OnSubmit(BaseEventData eventData)
		{
			this.Show();
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x000B5879 File Offset: 0x000B3A79
		public virtual void OnCancel(BaseEventData eventData)
		{
			this.Hide();
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x000B5884 File Offset: 0x000B3A84
		public void Show()
		{
			if (!this.IsActive() || !this.IsInteractable() || this.m_Dropdown != null)
			{
				return;
			}
			if (!this.validTemplate)
			{
				this.SetupTemplate();
				if (!this.validTemplate)
				{
					return;
				}
			}
			List<Canvas> list = TMP_ListPool<Canvas>.Get();
			base.gameObject.GetComponentsInParent<Canvas>(false, list);
			if (list.Count == 0)
			{
				return;
			}
			Canvas canvas = list[0];
			TMP_ListPool<Canvas>.Release(list);
			this.m_Template.gameObject.SetActive(true);
			this.m_Dropdown = this.CreateDropdownList(this.m_Template.gameObject);
			this.m_Dropdown.name = "Dropdown List";
			this.m_Dropdown.SetActive(true);
			RectTransform rectTransform = this.m_Dropdown.transform as RectTransform;
			rectTransform.SetParent(this.m_Template.transform.parent, false);
			TMP_Dropdown.DropdownItem componentInChildren = this.m_Dropdown.GetComponentInChildren<TMP_Dropdown.DropdownItem>();
			RectTransform rectTransform2 = componentInChildren.rectTransform.parent.gameObject.transform as RectTransform;
			componentInChildren.rectTransform.gameObject.SetActive(true);
			Rect rect = rectTransform2.rect;
			Rect rect2 = componentInChildren.rectTransform.rect;
			Vector2 vector = rect2.min - rect.min + componentInChildren.rectTransform.localPosition;
			Vector2 vector2 = rect2.max - rect.max + componentInChildren.rectTransform.localPosition;
			Vector2 size = rect2.size;
			this.m_Items.Clear();
			Toggle toggle = null;
			for (int i = 0; i < this.options.Count; i++)
			{
				TMP_Dropdown.OptionData data = this.options[i];
				TMP_Dropdown.DropdownItem item = this.AddItem(data, this.value == i, componentInChildren, this.m_Items);
				if (!(item == null))
				{
					item.toggle.isOn = (this.value == i);
					item.toggle.onValueChanged.AddListener(delegate(bool x)
					{
						this.OnSelectItem(item.toggle);
					});
					if (item.toggle.isOn)
					{
						item.toggle.Select();
					}
					if (toggle != null)
					{
						Navigation navigation = toggle.navigation;
						Navigation navigation2 = item.toggle.navigation;
						navigation.mode = Navigation.Mode.Explicit;
						navigation2.mode = Navigation.Mode.Explicit;
						navigation.selectOnDown = item.toggle;
						navigation.selectOnRight = item.toggle;
						navigation2.selectOnLeft = toggle;
						navigation2.selectOnUp = toggle;
						toggle.navigation = navigation;
						item.toggle.navigation = navigation2;
					}
					toggle = item.toggle;
				}
			}
			Vector2 sizeDelta = rectTransform2.sizeDelta;
			sizeDelta.y = size.y * (float)this.m_Items.Count + vector.y - vector2.y;
			rectTransform2.sizeDelta = sizeDelta;
			float num = rectTransform.rect.height - rectTransform2.rect.height;
			if (num > 0f)
			{
				rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y - num);
			}
			Vector3[] array = new Vector3[4];
			rectTransform.GetWorldCorners(array);
			RectTransform rectTransform3 = canvas.transform as RectTransform;
			Rect rect3 = rectTransform3.rect;
			for (int j = 0; j < 2; j++)
			{
				bool flag = false;
				for (int k = 0; k < 4; k++)
				{
					Vector3 vector3 = rectTransform3.InverseTransformPoint(array[k]);
					if (vector3[j] < rect3.min[j] || vector3[j] > rect3.max[j])
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					RectTransformUtility.FlipLayoutOnAxis(rectTransform, j, false, false);
				}
			}
			for (int l = 0; l < this.m_Items.Count; l++)
			{
				RectTransform rectTransform4 = this.m_Items[l].rectTransform;
				rectTransform4.anchorMin = new Vector2(rectTransform4.anchorMin.x, 0f);
				rectTransform4.anchorMax = new Vector2(rectTransform4.anchorMax.x, 0f);
				rectTransform4.anchoredPosition = new Vector2(rectTransform4.anchoredPosition.x, vector.y + size.y * (float)(this.m_Items.Count - 1 - l) + size.y * rectTransform4.pivot.y);
				rectTransform4.sizeDelta = new Vector2(rectTransform4.sizeDelta.x, size.y);
			}
			this.AlphaFadeList(0.15f, 0f, 1f);
			this.m_Template.gameObject.SetActive(false);
			componentInChildren.gameObject.SetActive(false);
			this.m_Blocker = this.CreateBlocker(canvas);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x000B5DD8 File Offset: 0x000B3FD8
		protected virtual GameObject CreateBlocker(Canvas rootCanvas)
		{
			GameObject gameObject = new GameObject("Blocker");
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			rectTransform.SetParent(rootCanvas.transform, false);
			rectTransform.anchorMin = Vector3.zero;
			rectTransform.anchorMax = Vector3.one;
			rectTransform.sizeDelta = Vector2.zero;
			Canvas canvas = gameObject.AddComponent<Canvas>();
			canvas.overrideSorting = true;
			Canvas component = this.m_Dropdown.GetComponent<Canvas>();
			canvas.sortingLayerID = component.sortingLayerID;
			canvas.sortingOrder = component.sortingOrder - 1;
			gameObject.AddComponent<GraphicRaycaster>();
			gameObject.AddComponent<Image>().color = Color.clear;
			gameObject.AddComponent<Button>().onClick.AddListener(new UnityAction(this.Hide));
			return gameObject;
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000B5E91 File Offset: 0x000B4091
		protected virtual void DestroyBlocker(GameObject blocker)
		{
			UnityEngine.Object.Destroy(blocker);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x000B5E99 File Offset: 0x000B4099
		protected virtual GameObject CreateDropdownList(GameObject template)
		{
			return UnityEngine.Object.Instantiate<GameObject>(template);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x000B5E91 File Offset: 0x000B4091
		protected virtual void DestroyDropdownList(GameObject dropdownList)
		{
			UnityEngine.Object.Destroy(dropdownList);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x000B5EA1 File Offset: 0x000B40A1
		protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate)
		{
			return UnityEngine.Object.Instantiate<TMP_Dropdown.DropdownItem>(itemTemplate);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00003603 File Offset: 0x00001803
		protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item)
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x000B5EAC File Offset: 0x000B40AC
		private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items)
		{
			TMP_Dropdown.DropdownItem dropdownItem = this.CreateItem(itemTemplate);
			dropdownItem.rectTransform.SetParent(itemTemplate.rectTransform.parent, false);
			dropdownItem.gameObject.SetActive(true);
			dropdownItem.gameObject.name = "Item " + items.Count.ToString() + ((data.text != null) ? (": " + data.text) : "");
			if (dropdownItem.toggle != null)
			{
				dropdownItem.toggle.isOn = false;
			}
			if (dropdownItem.text)
			{
				dropdownItem.text.text = data.text;
			}
			if (dropdownItem.image)
			{
				dropdownItem.image.sprite = data.image;
				dropdownItem.image.enabled = (dropdownItem.image.sprite != null);
			}
			items.Add(dropdownItem);
			return dropdownItem;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x000B5FA4 File Offset: 0x000B41A4
		private void AlphaFadeList(float duration, float alpha)
		{
			CanvasGroup component = this.m_Dropdown.GetComponent<CanvasGroup>();
			this.AlphaFadeList(duration, component.alpha, alpha);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000B5FCC File Offset: 0x000B41CC
		private void AlphaFadeList(float duration, float start, float end)
		{
			if (end.Equals(start))
			{
				return;
			}
			FloatTween info = new FloatTween
			{
				duration = duration,
				startValue = start,
				targetValue = end
			};
			info.AddOnChangedCallback(new UnityAction<float>(this.SetAlpha));
			info.ignoreTimeScale = true;
			this.m_AlphaTweenRunner.StartTween(info);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000B602D File Offset: 0x000B422D
		private void SetAlpha(float alpha)
		{
			if (!this.m_Dropdown)
			{
				return;
			}
			this.m_Dropdown.GetComponent<CanvasGroup>().alpha = alpha;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000B6050 File Offset: 0x000B4250
		public void Hide()
		{
			if (this.m_Dropdown != null)
			{
				this.AlphaFadeList(0.15f, 0f);
				if (this.IsActive())
				{
					base.StartCoroutine(this.DelayedDestroyDropdownList(0.15f));
				}
			}
			if (this.m_Blocker != null)
			{
				this.DestroyBlocker(this.m_Blocker);
			}
			this.m_Blocker = null;
			this.Select();
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000B60BC File Offset: 0x000B42BC
		private IEnumerator DelayedDestroyDropdownList(float delay)
		{
			yield return new WaitForSeconds(delay);
			for (int i = 0; i < this.m_Items.Count; i++)
			{
				if (this.m_Items[i] != null)
				{
					this.DestroyItem(this.m_Items[i]);
				}
				this.m_Items.Clear();
			}
			if (this.m_Dropdown != null)
			{
				this.DestroyDropdownList(this.m_Dropdown);
			}
			this.m_Dropdown = null;
			yield break;
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000B60D4 File Offset: 0x000B42D4
		private void OnSelectItem(Toggle toggle)
		{
			if (!toggle.isOn)
			{
				toggle.isOn = true;
			}
			int num = -1;
			Transform transform = toggle.transform;
			Transform parent = transform.parent;
			for (int i = 0; i < parent.childCount; i++)
			{
				if (parent.GetChild(i) == transform)
				{
					num = i - 1;
					break;
				}
			}
			if (num < 0)
			{
				return;
			}
			this.value = num;
			this.Hide();
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000B6138 File Offset: 0x000B4338
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Dropdown()
		{
			TMP_Dropdown.s_NoOptionData = new TMP_Dropdown.OptionData();
		}

		// Token: 0x040027B2 RID: 10162
		[SerializeField]
		private RectTransform m_Template;

		// Token: 0x040027B3 RID: 10163
		[SerializeField]
		private TMP_Text m_CaptionText;

		// Token: 0x040027B4 RID: 10164
		[SerializeField]
		private Image m_CaptionImage;

		// Token: 0x040027B5 RID: 10165
		[Space]
		[SerializeField]
		private TMP_Text m_ItemText;

		// Token: 0x040027B6 RID: 10166
		[SerializeField]
		private Image m_ItemImage;

		// Token: 0x040027B7 RID: 10167
		[Space]
		[SerializeField]
		private int m_Value;

		// Token: 0x040027B8 RID: 10168
		[Space]
		[SerializeField]
		private TMP_Dropdown.OptionDataList m_Options;

		// Token: 0x040027B9 RID: 10169
		[Space]
		[SerializeField]
		private TMP_Dropdown.DropdownEvent m_OnValueChanged;

		// Token: 0x040027BA RID: 10170
		private GameObject m_Dropdown;

		// Token: 0x040027BB RID: 10171
		private GameObject m_Blocker;

		// Token: 0x040027BC RID: 10172
		private List<TMP_Dropdown.DropdownItem> m_Items;

		// Token: 0x040027BD RID: 10173
		private TweenRunner<FloatTween> m_AlphaTweenRunner;

		// Token: 0x040027BE RID: 10174
		private bool validTemplate;

		// Token: 0x040027BF RID: 10175
		private static TMP_Dropdown.OptionData s_NoOptionData;

		// Token: 0x020005E5 RID: 1509
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
		{
			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x06002352 RID: 9042 RVA: 0x000B6144 File Offset: 0x000B4344
			// (set) Token: 0x06002353 RID: 9043 RVA: 0x000B614C File Offset: 0x000B434C
			public TMP_Text text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x06002354 RID: 9044 RVA: 0x000B6155 File Offset: 0x000B4355
			// (set) Token: 0x06002355 RID: 9045 RVA: 0x000B615D File Offset: 0x000B435D
			public Image image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x06002356 RID: 9046 RVA: 0x000B6166 File Offset: 0x000B4366
			// (set) Token: 0x06002357 RID: 9047 RVA: 0x000B616E File Offset: 0x000B436E
			public RectTransform rectTransform
			{
				get
				{
					return this.m_RectTransform;
				}
				set
				{
					this.m_RectTransform = value;
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x06002358 RID: 9048 RVA: 0x000B6177 File Offset: 0x000B4377
			// (set) Token: 0x06002359 RID: 9049 RVA: 0x000B617F File Offset: 0x000B437F
			public Toggle toggle
			{
				get
				{
					return this.m_Toggle;
				}
				set
				{
					this.m_Toggle = value;
				}
			}

			// Token: 0x0600235A RID: 9050 RVA: 0x000B6188 File Offset: 0x000B4388
			public virtual void OnPointerEnter(PointerEventData eventData)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}

			// Token: 0x0600235B RID: 9051 RVA: 0x000B619C File Offset: 0x000B439C
			public virtual void OnCancel(BaseEventData eventData)
			{
				TMP_Dropdown componentInParent = base.GetComponentInParent<TMP_Dropdown>();
				if (componentInParent)
				{
					componentInParent.Hide();
				}
			}

			// Token: 0x040027C0 RID: 10176
			[SerializeField]
			private TMP_Text m_Text;

			// Token: 0x040027C1 RID: 10177
			[SerializeField]
			private Image m_Image;

			// Token: 0x040027C2 RID: 10178
			[SerializeField]
			private RectTransform m_RectTransform;

			// Token: 0x040027C3 RID: 10179
			[SerializeField]
			private Toggle m_Toggle;
		}

		// Token: 0x020005E6 RID: 1510
		[Serializable]
		public class OptionData
		{
			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x0600235D RID: 9053 RVA: 0x000B61BE File Offset: 0x000B43BE
			// (set) Token: 0x0600235E RID: 9054 RVA: 0x000B61C6 File Offset: 0x000B43C6
			public string text
			{
				get
				{
					return this.m_Text;
				}
				set
				{
					this.m_Text = value;
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x0600235F RID: 9055 RVA: 0x000B61CF File Offset: 0x000B43CF
			// (set) Token: 0x06002360 RID: 9056 RVA: 0x000B61D7 File Offset: 0x000B43D7
			public Sprite image
			{
				get
				{
					return this.m_Image;
				}
				set
				{
					this.m_Image = value;
				}
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x0000310E File Offset: 0x0000130E
			public OptionData()
			{
			}

			// Token: 0x06002362 RID: 9058 RVA: 0x000B61E0 File Offset: 0x000B43E0
			public OptionData(string text)
			{
				this.text = text;
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x000B61EF File Offset: 0x000B43EF
			public OptionData(Sprite image)
			{
				this.image = image;
			}

			// Token: 0x06002364 RID: 9060 RVA: 0x000B61FE File Offset: 0x000B43FE
			public OptionData(string text, Sprite image)
			{
				this.text = text;
				this.image = image;
			}

			// Token: 0x040027C4 RID: 10180
			[SerializeField]
			private string m_Text;

			// Token: 0x040027C5 RID: 10181
			[SerializeField]
			private Sprite m_Image;
		}

		// Token: 0x020005E7 RID: 1511
		[Serializable]
		public class OptionDataList
		{
			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06002365 RID: 9061 RVA: 0x000B6214 File Offset: 0x000B4414
			// (set) Token: 0x06002366 RID: 9062 RVA: 0x000B621C File Offset: 0x000B441C
			public List<TMP_Dropdown.OptionData> options
			{
				get
				{
					return this.m_Options;
				}
				set
				{
					this.m_Options = value;
				}
			}

			// Token: 0x06002367 RID: 9063 RVA: 0x000B6225 File Offset: 0x000B4425
			public OptionDataList()
			{
				this.options = new List<TMP_Dropdown.OptionData>();
			}

			// Token: 0x040027C6 RID: 10182
			[SerializeField]
			private List<TMP_Dropdown.OptionData> m_Options;
		}

		// Token: 0x020005E8 RID: 1512
		[Serializable]
		public class DropdownEvent : UnityEvent<int>
		{
		}
	}
}
