using System;
using UnityEngine;

// Token: 0x020005A9 RID: 1449
[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/UI/tk2dUITextInput")]
public class tk2dUITextInput : MonoBehaviour
{
	// Token: 0x17000439 RID: 1081
	// (get) Token: 0x06002092 RID: 8338 RVA: 0x000A40DE File Offset: 0x000A22DE
	// (set) Token: 0x06002093 RID: 8339 RVA: 0x000A40E8 File Offset: 0x000A22E8
	public tk2dUILayout LayoutItem
	{
		get
		{
			return this.layoutItem;
		}
		set
		{
			if (this.layoutItem != value)
			{
				if (this.layoutItem != null)
				{
					this.layoutItem.OnReshape -= this.LayoutReshaped;
				}
				this.layoutItem = value;
				if (this.layoutItem != null)
				{
					this.layoutItem.OnReshape += this.LayoutReshaped;
				}
			}
		}
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06002094 RID: 8340 RVA: 0x000A4154 File Offset: 0x000A2354
	// (set) Token: 0x06002095 RID: 8341 RVA: 0x000A4171 File Offset: 0x000A2371
	public GameObject SendMessageTarget
	{
		get
		{
			if (this.selectionBtn != null)
			{
				return this.selectionBtn.sendMessageTarget;
			}
			return null;
		}
		set
		{
			if (this.selectionBtn != null && this.selectionBtn.sendMessageTarget != value)
			{
				this.selectionBtn.sendMessageTarget = value;
			}
		}
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06002096 RID: 8342 RVA: 0x000A41A0 File Offset: 0x000A23A0
	public bool IsFocus
	{
		get
		{
			return this.isSelected;
		}
	}

	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06002097 RID: 8343 RVA: 0x000A41A8 File Offset: 0x000A23A8
	// (set) Token: 0x06002098 RID: 8344 RVA: 0x000A41B0 File Offset: 0x000A23B0
	public string Text
	{
		get
		{
			return this.text;
		}
		set
		{
			if (this.text != value)
			{
				this.text = value;
				if (this.text.Length > this.maxCharacterLength)
				{
					this.text = this.text.Substring(0, this.maxCharacterLength);
				}
				this.FormatTextForDisplay(this.text);
				if (this.isSelected)
				{
					this.SetCursorPosition();
				}
			}
		}
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000A4217 File Offset: 0x000A2417
	private void Awake()
	{
		this.SetState();
		this.ShowDisplayText();
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000A4225 File Offset: 0x000A2425
	private void Start()
	{
		this.wasStartedCalled = true;
		if (tk2dUIManager.Instance__NoCreate != null)
		{
			tk2dUIManager.Instance.OnAnyPress += this.AnyPress;
		}
		this.wasOnAnyPressEventAttached = true;
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000A4258 File Offset: 0x000A2458
	private void OnEnable()
	{
		if (this.wasStartedCalled && !this.wasOnAnyPressEventAttached && tk2dUIManager.Instance__NoCreate != null)
		{
			tk2dUIManager.Instance.OnAnyPress += this.AnyPress;
		}
		if (this.layoutItem != null)
		{
			this.layoutItem.OnReshape += this.LayoutReshaped;
		}
		this.selectionBtn.OnClick += this.InputSelected;
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x000A42D4 File Offset: 0x000A24D4
	private void OnDisable()
	{
		if (tk2dUIManager.Instance__NoCreate != null)
		{
			tk2dUIManager.Instance.OnAnyPress -= this.AnyPress;
			if (this.listenForKeyboardText)
			{
				tk2dUIManager.Instance.OnInputUpdate -= this.ListenForKeyboardTextUpdate;
			}
		}
		this.wasOnAnyPressEventAttached = false;
		this.selectionBtn.OnClick -= this.InputSelected;
		this.listenForKeyboardText = false;
		if (this.layoutItem != null)
		{
			this.layoutItem.OnReshape -= this.LayoutReshaped;
		}
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x000A436C File Offset: 0x000A256C
	public void SetFocus()
	{
		this.SetFocus(true);
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x000A4375 File Offset: 0x000A2575
	public void SetFocus(bool focus)
	{
		if (!this.IsFocus && focus)
		{
			this.InputSelected();
			return;
		}
		if (this.IsFocus && !focus)
		{
			this.InputDeselected();
		}
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000A439C File Offset: 0x000A259C
	private void FormatTextForDisplay(string modifiedText)
	{
		if (this.isPasswordField)
		{
			int length = modifiedText.Length;
			char paddingChar = (this.passwordChar.Length > 0) ? this.passwordChar[0] : '*';
			modifiedText = "";
			modifiedText = modifiedText.PadRight(length, paddingChar);
		}
		this.inputLabel.text = modifiedText;
		this.inputLabel.Commit();
		for (float num = this.inputLabel.GetComponent<Renderer>().bounds.size.x / this.inputLabel.transform.lossyScale.x; num > this.fieldLength; num = this.inputLabel.GetComponent<Renderer>().bounds.size.x / this.inputLabel.transform.lossyScale.x)
		{
			modifiedText = modifiedText.Substring(1, modifiedText.Length - 1);
			this.inputLabel.text = modifiedText;
			this.inputLabel.Commit();
		}
		if (modifiedText.Length == 0 && !this.listenForKeyboardText)
		{
			this.ShowDisplayText();
			return;
		}
		this.HideDisplayText();
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000A44C0 File Offset: 0x000A26C0
	private void ListenForKeyboardTextUpdate()
	{
		bool flag = false;
		string str = this.text;
		foreach (char c in Input.inputString)
		{
			if (c == "\b"[0])
			{
				if (this.text.Length != 0)
				{
					str = this.text.Substring(0, this.text.Length - 1);
					flag = true;
				}
			}
			else if (c != "\n"[0] && c != "\r"[0] && c != '\t' && c != '\u001b')
			{
				str += c.ToString();
				flag = true;
			}
		}
		if (flag)
		{
			this.Text = str;
			if (this.OnTextChange != null)
			{
				this.OnTextChange(this);
			}
			if (this.SendMessageTarget != null && this.SendMessageOnTextChangeMethodName.Length > 0)
			{
				this.SendMessageTarget.SendMessage(this.SendMessageOnTextChangeMethodName, this, SendMessageOptions.RequireReceiver);
			}
		}
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000A45BC File Offset: 0x000A27BC
	private void InputSelected()
	{
		if (this.text.Length == 0)
		{
			this.HideDisplayText();
		}
		this.isSelected = true;
		if (!this.listenForKeyboardText)
		{
			tk2dUIManager.Instance.OnInputUpdate += this.ListenForKeyboardTextUpdate;
		}
		this.listenForKeyboardText = true;
		this.SetState();
		this.SetCursorPosition();
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000A4614 File Offset: 0x000A2814
	private void InputDeselected()
	{
		if (this.text.Length == 0)
		{
			this.ShowDisplayText();
		}
		this.isSelected = false;
		if (this.listenForKeyboardText)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.ListenForKeyboardTextUpdate;
		}
		this.listenForKeyboardText = false;
		this.SetState();
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000A4666 File Offset: 0x000A2866
	private void AnyPress()
	{
		if (this.isSelected && tk2dUIManager.Instance.PressedUIItem != this.selectionBtn)
		{
			this.InputDeselected();
		}
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000A468D File Offset: 0x000A288D
	private void SetState()
	{
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.unSelectedStateGO, !this.isSelected);
		tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.selectedStateGO, this.isSelected);
		tk2dUIBaseItemControl.ChangeGameObjectActiveState(this.cursor, this.isSelected);
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000A46C8 File Offset: 0x000A28C8
	private void SetCursorPosition()
	{
		float num = 1f;
		float num2 = 0.002f;
		if (this.inputLabel.anchor == TextAnchor.MiddleLeft || this.inputLabel.anchor == TextAnchor.LowerLeft || this.inputLabel.anchor == TextAnchor.UpperLeft)
		{
			num = 2f;
		}
		else if (this.inputLabel.anchor == TextAnchor.MiddleRight || this.inputLabel.anchor == TextAnchor.LowerRight || this.inputLabel.anchor == TextAnchor.UpperRight)
		{
			num = -2f;
			num2 = 0.012f;
		}
		if (this.text.EndsWith(" "))
		{
			tk2dFontChar tk2dFontChar;
			if (this.inputLabel.font.inst.useDictionary)
			{
				tk2dFontChar = this.inputLabel.font.inst.charDict[32];
			}
			else
			{
				tk2dFontChar = this.inputLabel.font.inst.chars[32];
			}
			num2 += tk2dFontChar.advance * this.inputLabel.scale.x / 2f;
		}
		float num3 = this.inputLabel.GetComponent<Renderer>().bounds.extents.x / base.gameObject.transform.lossyScale.x;
		this.cursor.transform.localPosition = new Vector3(this.inputLabel.transform.localPosition.x + (num3 + num2) * num, this.cursor.transform.localPosition.y, this.cursor.transform.localPosition.z);
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000A4858 File Offset: 0x000A2A58
	private void ShowDisplayText()
	{
		if (!this.isDisplayTextShown)
		{
			this.isDisplayTextShown = true;
			if (this.emptyDisplayLabel != null)
			{
				this.emptyDisplayLabel.text = this.emptyDisplayText;
				this.emptyDisplayLabel.Commit();
				tk2dUIBaseItemControl.ChangeGameObjectActiveState(this.emptyDisplayLabel.gameObject, true);
			}
			tk2dUIBaseItemControl.ChangeGameObjectActiveState(this.inputLabel.gameObject, false);
		}
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000A48C0 File Offset: 0x000A2AC0
	private void HideDisplayText()
	{
		if (this.isDisplayTextShown)
		{
			this.isDisplayTextShown = false;
			tk2dUIBaseItemControl.ChangeGameObjectActiveStateWithNullCheck(this.emptyDisplayLabel.gameObject, false);
			tk2dUIBaseItemControl.ChangeGameObjectActiveState(this.inputLabel.gameObject, true);
		}
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x000A48F4 File Offset: 0x000A2AF4
	private void LayoutReshaped(Vector3 dMin, Vector3 dMax)
	{
		this.fieldLength += dMax.x - dMin.x;
		string text = this.text;
		this.text = "";
		this.Text = text;
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x000A4934 File Offset: 0x000A2B34
	public tk2dUITextInput()
	{
		this.fieldLength = 1f;
		this.maxCharacterLength = 30;
		this.passwordChar = "*";
		this.SendMessageOnTextChangeMethodName = "";
		this.text = "";
		base..ctor();
	}

	// Token: 0x0400263D RID: 9789
	public tk2dUIItem selectionBtn;

	// Token: 0x0400263E RID: 9790
	public tk2dTextMesh inputLabel;

	// Token: 0x0400263F RID: 9791
	public tk2dTextMesh emptyDisplayLabel;

	// Token: 0x04002640 RID: 9792
	public GameObject unSelectedStateGO;

	// Token: 0x04002641 RID: 9793
	public GameObject selectedStateGO;

	// Token: 0x04002642 RID: 9794
	public GameObject cursor;

	// Token: 0x04002643 RID: 9795
	public float fieldLength;

	// Token: 0x04002644 RID: 9796
	public int maxCharacterLength;

	// Token: 0x04002645 RID: 9797
	public string emptyDisplayText;

	// Token: 0x04002646 RID: 9798
	public bool isPasswordField;

	// Token: 0x04002647 RID: 9799
	public string passwordChar;

	// Token: 0x04002648 RID: 9800
	[SerializeField]
	[HideInInspector]
	private tk2dUILayout layoutItem;

	// Token: 0x04002649 RID: 9801
	private bool isSelected;

	// Token: 0x0400264A RID: 9802
	private bool wasStartedCalled;

	// Token: 0x0400264B RID: 9803
	private bool wasOnAnyPressEventAttached;

	// Token: 0x0400264C RID: 9804
	private bool listenForKeyboardText;

	// Token: 0x0400264D RID: 9805
	private bool isDisplayTextShown;

	// Token: 0x0400264E RID: 9806
	public Action<tk2dUITextInput> OnTextChange;

	// Token: 0x0400264F RID: 9807
	public string SendMessageOnTextChangeMethodName;

	// Token: 0x04002650 RID: 9808
	private string text;
}
