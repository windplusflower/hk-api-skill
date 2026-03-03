using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x020005EF RID: 1519
	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x000B6CBC File Offset: 0x000B4EBC
		protected TMP_InputField()
		{
			this.m_AsteriskChar = '*';
			this.m_OnEndEdit = new TMP_InputField.SubmitEvent();
			this.m_OnSubmit = new TMP_InputField.SubmitEvent();
			this.m_OnFocusLost = new TMP_InputField.SubmitEvent();
			this.m_OnValueChanged = new TMP_InputField.OnChangeEvent();
			this.m_CaretColor = new Color(0.19607843f, 0.19607843f, 0.19607843f, 1f);
			this.m_SelectionColor = new Color(0.65882355f, 0.80784315f, 1f, 0.7529412f);
			this.m_Text = string.Empty;
			this.m_CaretBlinkRate = 0.85f;
			this.m_CaretWidth = 1;
			this.m_RichText = true;
			this.m_OriginalText = "";
			this.m_ProcessingEvent = new Event();
			base..ctor();
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000B6D7B File Offset: 0x000B4F7B
		protected Mesh mesh
		{
			get
			{
				if (this.m_Mesh == null)
				{
					this.m_Mesh = new Mesh();
				}
				return this.m_Mesh;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x000B6DAC File Offset: 0x000B4FAC
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x000B6D9C File Offset: 0x000B4F9C
		public bool shouldHideMobileInput
		{
			get
			{
				RuntimePlatform platform = Application.platform;
				return (platform != RuntimePlatform.IPhonePlayer && platform != RuntimePlatform.Android && platform - RuntimePlatform.BlackBerryPlayer > 1) || this.m_HideMobileInput;
			}
			set
			{
				SetPropertyUtility.SetStruct<bool>(ref this.m_HideMobileInput, value);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000B6DD7 File Offset: 0x000B4FD7
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x000B6DE0 File Offset: 0x000B4FE0
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				if (this.text == value)
				{
					return;
				}
				this.m_Text = value;
				if (this.m_Keyboard != null)
				{
					this.m_Keyboard.text = this.m_Text;
				}
				if (this.m_StringPosition > this.m_Text.Length)
				{
					this.m_StringPosition = (this.m_StringSelectPosition = this.m_Text.Length);
				}
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000B6E4F File Offset: 0x000B504F
		public bool isFocused
		{
			get
			{
				return this.m_AllowInput;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000B6E57 File Offset: 0x000B5057
		// (set) Token: 0x0600238E RID: 9102 RVA: 0x000B6E5F File Offset: 0x000B505F
		public float caretBlinkRate
		{
			get
			{
				return this.m_CaretBlinkRate;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<float>(ref this.m_CaretBlinkRate, value) && this.m_AllowInput)
				{
					this.SetCaretActive();
				}
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x000B6E7D File Offset: 0x000B507D
		// (set) Token: 0x06002390 RID: 9104 RVA: 0x000B6E85 File Offset: 0x000B5085
		public int caretWidth
		{
			get
			{
				return this.m_CaretWidth;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_CaretWidth, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x000B6E9B File Offset: 0x000B509B
		// (set) Token: 0x06002392 RID: 9106 RVA: 0x000B6EA3 File Offset: 0x000B50A3
		public RectTransform textViewport
		{
			get
			{
				return this.m_TextViewport;
			}
			set
			{
				SetPropertyUtility.SetClass<RectTransform>(ref this.m_TextViewport, value);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x000B6EB2 File Offset: 0x000B50B2
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x000B6EBA File Offset: 0x000B50BA
		public TMP_Text textComponent
		{
			get
			{
				return this.m_TextComponent;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_Text>(ref this.m_TextComponent, value);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x000B6EC9 File Offset: 0x000B50C9
		// (set) Token: 0x06002396 RID: 9110 RVA: 0x000B6ED1 File Offset: 0x000B50D1
		public Graphic placeholder
		{
			get
			{
				return this.m_Placeholder;
			}
			set
			{
				SetPropertyUtility.SetClass<Graphic>(ref this.m_Placeholder, value);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x000B6EE0 File Offset: 0x000B50E0
		// (set) Token: 0x06002398 RID: 9112 RVA: 0x000B6EFC File Offset: 0x000B50FC
		public Color caretColor
		{
			get
			{
				if (!this.customCaretColor)
				{
					return this.textComponent.color;
				}
				return this.m_CaretColor;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_CaretColor, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x000B6F12 File Offset: 0x000B5112
		// (set) Token: 0x0600239A RID: 9114 RVA: 0x000B6F1A File Offset: 0x000B511A
		public bool customCaretColor
		{
			get
			{
				return this.m_CustomCaretColor;
			}
			set
			{
				if (this.m_CustomCaretColor != value)
				{
					this.m_CustomCaretColor = value;
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600239B RID: 9115 RVA: 0x000B6F32 File Offset: 0x000B5132
		// (set) Token: 0x0600239C RID: 9116 RVA: 0x000B6F3A File Offset: 0x000B513A
		public Color selectionColor
		{
			get
			{
				return this.m_SelectionColor;
			}
			set
			{
				if (SetPropertyUtility.SetColor(ref this.m_SelectionColor, value))
				{
					this.MarkGeometryAsDirty();
				}
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x000B6F50 File Offset: 0x000B5150
		// (set) Token: 0x0600239E RID: 9118 RVA: 0x000B6F58 File Offset: 0x000B5158
		public TMP_InputField.SubmitEvent onEndEdit
		{
			get
			{
				return this.m_OnEndEdit;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_InputField.SubmitEvent>(ref this.m_OnEndEdit, value);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600239F RID: 9119 RVA: 0x000B6F67 File Offset: 0x000B5167
		// (set) Token: 0x060023A0 RID: 9120 RVA: 0x000B6F6F File Offset: 0x000B516F
		public TMP_InputField.SubmitEvent onSubmit
		{
			get
			{
				return this.m_OnSubmit;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_InputField.SubmitEvent>(ref this.m_OnSubmit, value);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060023A1 RID: 9121 RVA: 0x000B6F7E File Offset: 0x000B517E
		// (set) Token: 0x060023A2 RID: 9122 RVA: 0x000B6F86 File Offset: 0x000B5186
		public TMP_InputField.SubmitEvent onFocusLost
		{
			get
			{
				return this.m_OnFocusLost;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_InputField.SubmitEvent>(ref this.m_OnFocusLost, value);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x000B6F95 File Offset: 0x000B5195
		// (set) Token: 0x060023A4 RID: 9124 RVA: 0x000B6F9D File Offset: 0x000B519D
		public TMP_InputField.OnChangeEvent onValueChanged
		{
			get
			{
				return this.m_OnValueChanged;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_InputField.OnChangeEvent>(ref this.m_OnValueChanged, value);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x000B6FAC File Offset: 0x000B51AC
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x000B6FB4 File Offset: 0x000B51B4
		public TMP_InputField.OnValidateInput onValidateInput
		{
			get
			{
				return this.m_OnValidateInput;
			}
			set
			{
				SetPropertyUtility.SetClass<TMP_InputField.OnValidateInput>(ref this.m_OnValidateInput, value);
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060023A7 RID: 9127 RVA: 0x000B6FC3 File Offset: 0x000B51C3
		// (set) Token: 0x060023A8 RID: 9128 RVA: 0x000B6FCB File Offset: 0x000B51CB
		public int characterLimit
		{
			get
			{
				return this.m_CharacterLimit;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<int>(ref this.m_CharacterLimit, Math.Max(0, value)))
				{
					this.UpdateLabel();
				}
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x000B6FE7 File Offset: 0x000B51E7
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x000B6FEF File Offset: 0x000B51EF
		public TMP_InputField.ContentType contentType
		{
			get
			{
				return this.m_ContentType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TMP_InputField.ContentType>(ref this.m_ContentType, value))
				{
					this.EnforceContentType();
				}
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x000B7005 File Offset: 0x000B5205
		// (set) Token: 0x060023AC RID: 9132 RVA: 0x000B700D File Offset: 0x000B520D
		public TMP_InputField.LineType lineType
		{
			get
			{
				return this.m_LineType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TMP_InputField.LineType>(ref this.m_LineType, value))
				{
					this.SetTextComponentWrapMode();
				}
				this.SetToCustomIfContentTypeIsNot(new TMP_InputField.ContentType[]
				{
					TMP_InputField.ContentType.Standard,
					TMP_InputField.ContentType.Autocorrected
				});
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x000B7033 File Offset: 0x000B5233
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x000B703B File Offset: 0x000B523B
		public TMP_InputField.InputType inputType
		{
			get
			{
				return this.m_InputType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TMP_InputField.InputType>(ref this.m_InputType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x000B7051 File Offset: 0x000B5251
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x000B7059 File Offset: 0x000B5259
		public TouchScreenKeyboardType keyboardType
		{
			get
			{
				return this.m_KeyboardType;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TouchScreenKeyboardType>(ref this.m_KeyboardType, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000B706F File Offset: 0x000B526F
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x000B7077 File Offset: 0x000B5277
		public TMP_InputField.CharacterValidation characterValidation
		{
			get
			{
				return this.m_CharacterValidation;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<TMP_InputField.CharacterValidation>(ref this.m_CharacterValidation, value))
				{
					this.SetToCustom();
				}
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060023B3 RID: 9139 RVA: 0x000B708D File Offset: 0x000B528D
		// (set) Token: 0x060023B4 RID: 9140 RVA: 0x000B7095 File Offset: 0x000B5295
		public bool readOnly
		{
			get
			{
				return this.m_ReadOnly;
			}
			set
			{
				this.m_ReadOnly = value;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000B709E File Offset: 0x000B529E
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x000B70A6 File Offset: 0x000B52A6
		public bool richText
		{
			get
			{
				return this.m_RichText;
			}
			set
			{
				this.m_RichText = value;
				this.SetTextComponentRichTextMode();
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060023B7 RID: 9143 RVA: 0x000B70B5 File Offset: 0x000B52B5
		public bool multiLine
		{
			get
			{
				return this.m_LineType == TMP_InputField.LineType.MultiLineNewline || this.lineType == TMP_InputField.LineType.MultiLineSubmit;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000B70CB File Offset: 0x000B52CB
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x000B70D3 File Offset: 0x000B52D3
		public char asteriskChar
		{
			get
			{
				return this.m_AsteriskChar;
			}
			set
			{
				if (SetPropertyUtility.SetStruct<char>(ref this.m_AsteriskChar, value))
				{
					this.UpdateLabel();
				}
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000B70E9 File Offset: 0x000B52E9
		public bool wasCanceled
		{
			get
			{
				return this.m_WasCanceled;
			}
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x000B70F1 File Offset: 0x000B52F1
		protected void ClampPos(ref int pos)
		{
			if (pos < 0)
			{
				pos = 0;
				return;
			}
			if (pos > this.text.Length)
			{
				pos = this.text.Length;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000B7118 File Offset: 0x000B5318
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x000B712B File Offset: 0x000B532B
		protected int caretPositionInternal
		{
			get
			{
				return this.m_CaretPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_CaretPosition = value;
				this.ClampPos(ref this.m_CaretPosition);
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000B7140 File Offset: 0x000B5340
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x000B7153 File Offset: 0x000B5353
		protected int stringPositionInternal
		{
			get
			{
				return this.m_StringPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_StringPosition = value;
				this.ClampPos(ref this.m_StringPosition);
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000B7168 File Offset: 0x000B5368
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x000B717B File Offset: 0x000B537B
		protected int caretSelectPositionInternal
		{
			get
			{
				return this.m_CaretSelectPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_CaretSelectPosition = value;
				this.ClampPos(ref this.m_CaretSelectPosition);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000B7190 File Offset: 0x000B5390
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x000B71A3 File Offset: 0x000B53A3
		protected int stringSelectPositionInternal
		{
			get
			{
				return this.m_StringSelectPosition + Input.compositionString.Length;
			}
			set
			{
				this.m_StringSelectPosition = value;
				this.ClampPos(ref this.m_StringSelectPosition);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x000B71B8 File Offset: 0x000B53B8
		private bool hasSelection
		{
			get
			{
				return this.stringPositionInternal != this.stringSelectPositionInternal;
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000B7190 File Offset: 0x000B5390
		// (set) Token: 0x060023C6 RID: 9158 RVA: 0x000B71CB File Offset: 0x000B53CB
		public int caretPosition
		{
			get
			{
				return this.m_StringSelectPosition + Input.compositionString.Length;
			}
			set
			{
				this.selectionAnchorPosition = value;
				this.selectionFocusPosition = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000B71DB File Offset: 0x000B53DB
		// (set) Token: 0x060023C8 RID: 9160 RVA: 0x000B7200 File Offset: 0x000B5400
		public int selectionAnchorPosition
		{
			get
			{
				this.m_StringPosition = this.GetStringIndexFromCaretPosition(this.m_CaretPosition);
				return this.m_StringPosition + Input.compositionString.Length;
			}
			set
			{
				if (Input.compositionString.Length != 0)
				{
					return;
				}
				this.m_CaretPosition = value;
				this.ClampPos(ref this.m_CaretPosition);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000B7222 File Offset: 0x000B5422
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x000B7247 File Offset: 0x000B5447
		public int selectionFocusPosition
		{
			get
			{
				this.m_StringSelectPosition = this.GetStringIndexFromCaretPosition(this.m_CaretSelectPosition);
				return this.m_StringSelectPosition + Input.compositionString.Length;
			}
			set
			{
				if (Input.compositionString.Length != 0)
				{
					return;
				}
				this.m_CaretSelectPosition = value;
				this.ClampPos(ref this.m_CaretSelectPosition);
			}
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000B726C File Offset: 0x000B546C
		protected override void OnEnable()
		{
			base.OnEnable();
			if (this.m_Text == null)
			{
				this.m_Text = string.Empty;
			}
			this.m_DrawStart = 0;
			this.m_DrawEnd = this.m_Text.Length;
			if (this.m_CachedInputRenderer != null)
			{
				this.m_CachedInputRenderer.SetMaterial(Graphic.defaultGraphicMaterial, Texture2D.whiteTexture);
			}
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.RegisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
				this.UpdateLabel();
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000B7310 File Offset: 0x000B5510
		protected override void OnDisable()
		{
			this.m_BlinkCoroutine = null;
			this.DeactivateInputField();
			if (this.m_TextComponent != null)
			{
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.MarkGeometryAsDirty));
				this.m_TextComponent.UnregisterDirtyVerticesCallback(new UnityAction(this.UpdateLabel));
			}
			CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(this);
			if (this.m_CachedInputRenderer != null)
			{
				this.m_CachedInputRenderer.Clear();
			}
			if (this.m_Mesh != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Mesh);
			}
			this.m_Mesh = null;
			base.OnDisable();
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000B73AB File Offset: 0x000B55AB
		private IEnumerator CaretBlink()
		{
			this.m_CaretVisible = true;
			yield return null;
			while (this.isFocused && this.m_CaretBlinkRate > 0f)
			{
				float num = 1f / this.m_CaretBlinkRate;
				bool flag = (Time.unscaledTime - this.m_BlinkStartTime) % num < num / 2f;
				if (this.m_CaretVisible != flag)
				{
					this.m_CaretVisible = flag;
					if (!this.hasSelection)
					{
						this.MarkGeometryAsDirty();
					}
				}
				yield return null;
			}
			this.m_BlinkCoroutine = null;
			yield break;
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x000B73BA File Offset: 0x000B55BA
		private void SetCaretVisible()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			this.m_CaretVisible = true;
			this.m_BlinkStartTime = Time.unscaledTime;
			this.SetCaretActive();
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x000B73DD File Offset: 0x000B55DD
		private void SetCaretActive()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			if (this.m_CaretBlinkRate > 0f)
			{
				if (this.m_BlinkCoroutine == null)
				{
					this.m_BlinkCoroutine = base.StartCoroutine(this.CaretBlink());
					return;
				}
			}
			else
			{
				this.m_CaretVisible = true;
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x000B7417 File Offset: 0x000B5617
		protected void OnFocus()
		{
			this.SelectAll();
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x000B741F File Offset: 0x000B561F
		protected void SelectAll()
		{
			this.stringPositionInternal = this.text.Length;
			this.stringSelectPositionInternal = 0;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x000B743C File Offset: 0x000B563C
		public void MoveTextEnd(bool shift)
		{
			int length = this.text.Length;
			if (shift)
			{
				this.stringSelectPositionInternal = length;
			}
			else
			{
				this.stringPositionInternal = length;
				this.stringSelectPositionInternal = this.stringPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x000B747C File Offset: 0x000B567C
		public void MoveTextStart(bool shift)
		{
			int num = 0;
			if (shift)
			{
				this.stringSelectPositionInternal = num;
			}
			else
			{
				this.stringPositionInternal = num;
				this.stringSelectPositionInternal = this.stringPositionInternal;
			}
			this.UpdateLabel();
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x000B74B0 File Offset: 0x000B56B0
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x000B74B7 File Offset: 0x000B56B7
		private static string clipboard
		{
			get
			{
				return GUIUtility.systemCopyBuffer;
			}
			set
			{
				GUIUtility.systemCopyBuffer = value;
			}
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x000B74BF File Offset: 0x000B56BF
		private bool InPlaceEditing()
		{
			return !TouchScreenKeyboard.isSupported;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x000B74CC File Offset: 0x000B56CC
		protected virtual void LateUpdate()
		{
			if (this.m_ShouldActivateNextUpdate)
			{
				if (!this.isFocused)
				{
					this.ActivateInputFieldInternal();
					this.m_ShouldActivateNextUpdate = false;
					return;
				}
				this.m_ShouldActivateNextUpdate = false;
			}
			if (this.InPlaceEditing() || !this.isFocused)
			{
				return;
			}
			this.AssignPositioningIfNeeded();
			if (this.m_Keyboard == null || !this.m_Keyboard.active)
			{
				if (this.m_Keyboard != null)
				{
					if (!this.m_ReadOnly)
					{
						this.text = this.m_Keyboard.text;
					}
					if (this.m_Keyboard.wasCanceled)
					{
						this.m_WasCanceled = true;
					}
				}
				this.OnDeselect(null);
				return;
			}
			string text = this.m_Keyboard.text;
			if (this.m_Text != text)
			{
				if (this.m_ReadOnly)
				{
					this.m_Keyboard.text = this.m_Text;
				}
				else
				{
					this.m_Text = "";
					foreach (char c in text)
					{
						if (c == '\r' || c == '\u0003')
						{
							c = '\n';
						}
						if (this.onValidateInput != null)
						{
							c = this.onValidateInput(this.m_Text, this.m_Text.Length, c);
						}
						else if (this.characterValidation != TMP_InputField.CharacterValidation.None)
						{
							c = this.Validate(this.m_Text, this.m_Text.Length, c);
						}
						if (this.lineType == TMP_InputField.LineType.MultiLineSubmit && c == '\n')
						{
							this.m_Keyboard.text = this.m_Text;
							this.OnDeselect(null);
							return;
						}
						if (c != '\0')
						{
							this.m_Text += c.ToString();
						}
					}
					if (this.characterLimit > 0 && this.m_Text.Length > this.characterLimit)
					{
						this.m_Text = this.m_Text.Substring(0, this.characterLimit);
					}
					this.stringPositionInternal = (this.stringSelectPositionInternal = this.m_Text.Length);
					if (this.m_Text != text)
					{
						this.m_Keyboard.text = this.m_Text;
					}
					this.SendOnValueChangedAndUpdateLabel();
				}
			}
			if (this.m_Keyboard.done)
			{
				if (this.m_Keyboard.wasCanceled)
				{
					this.m_WasCanceled = true;
				}
				this.OnDeselect(null);
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0000D742 File Offset: 0x0000B942
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			return 0;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x000B76FE File Offset: 0x000B58FE
		private bool MayDrag(PointerEventData eventData)
		{
			return this.IsActive() && this.IsInteractable() && eventData.button == PointerEventData.InputButton.Left && this.m_TextComponent != null && this.m_Keyboard == null;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x000B7731 File Offset: 0x000B5931
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			this.m_UpdateDrag = true;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x000B7744 File Offset: 0x000B5944
		public virtual void OnDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			CaretPosition caretPosition;
			int cursorIndexFromPosition = TMP_TextUtilities.GetCursorIndexFromPosition(this.m_TextComponent, eventData.position, eventData.pressEventCamera, out caretPosition);
			if (caretPosition == CaretPosition.Left)
			{
				this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(cursorIndexFromPosition);
			}
			else if (caretPosition == CaretPosition.Right)
			{
				this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(cursorIndexFromPosition) + 1;
			}
			this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal);
			this.MarkGeometryAsDirty();
			this.m_DragPositionOutOfBounds = !RectTransformUtility.RectangleContainsScreenPoint(this.textViewport, eventData.position, eventData.pressEventCamera);
			if (this.m_DragPositionOutOfBounds && this.m_DragCoroutine == null)
			{
				this.m_DragCoroutine = base.StartCoroutine(this.MouseDragOutsideRect(eventData));
			}
			eventData.Use();
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x000B7801 File Offset: 0x000B5A01
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			while (this.m_UpdateDrag && this.m_DragPositionOutOfBounds)
			{
				Vector2 vector;
				RectTransformUtility.ScreenPointToLocalPointInRectangle(this.textViewport, eventData.position, eventData.pressEventCamera, out vector);
				Rect rect = this.textViewport.rect;
				if (this.multiLine)
				{
					if (vector.y > rect.yMax)
					{
						this.MoveUp(true, true);
					}
					else if (vector.y < rect.yMin)
					{
						this.MoveDown(true, true);
					}
				}
				else if (vector.x < rect.xMin)
				{
					this.MoveLeft(true, false);
				}
				else if (vector.x > rect.xMax)
				{
					this.MoveRight(true, false);
				}
				this.UpdateLabel();
				float seconds = this.multiLine ? 0.1f : 0.05f;
				yield return new WaitForSeconds(seconds);
			}
			this.m_DragCoroutine = null;
			yield break;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x000B7817 File Offset: 0x000B5A17
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			this.m_UpdateDrag = false;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x000B782C File Offset: 0x000B5A2C
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (!this.MayDrag(eventData))
			{
				return;
			}
			EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
			bool allowInput = this.m_AllowInput;
			base.OnPointerDown(eventData);
			if (!this.InPlaceEditing() && (this.m_Keyboard == null || !this.m_Keyboard.active))
			{
				this.OnSelect(eventData);
				return;
			}
			if (allowInput)
			{
				CaretPosition caretPosition;
				int cursorIndexFromPosition = TMP_TextUtilities.GetCursorIndexFromPosition(this.m_TextComponent, eventData.position, eventData.pressEventCamera, out caretPosition);
				if (caretPosition == CaretPosition.Left)
				{
					this.stringPositionInternal = (this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(cursorIndexFromPosition));
				}
				else if (caretPosition == CaretPosition.Right)
				{
					this.stringPositionInternal = (this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(cursorIndexFromPosition) + 1);
				}
				this.caretPositionInternal = (this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringPositionInternal));
			}
			this.UpdateLabel();
			eventData.Use();
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000B7908 File Offset: 0x000B5B08
		protected TMP_InputField.EditState KeyPressed(Event evt)
		{
			EventModifiers modifiers = evt.modifiers;
			RuntimePlatform platform = Application.platform;
			bool flag = (platform == RuntimePlatform.OSXEditor || platform == RuntimePlatform.OSXPlayer) ? ((modifiers & EventModifiers.Command) > EventModifiers.None) : ((modifiers & EventModifiers.Control) > EventModifiers.None);
			bool flag2 = (modifiers & EventModifiers.Shift) > EventModifiers.None;
			bool flag3 = (modifiers & EventModifiers.Alt) > EventModifiers.None;
			bool flag4 = flag && !flag3 && !flag2;
			KeyCode keyCode = evt.keyCode;
			if (keyCode <= KeyCode.A)
			{
				if (keyCode <= KeyCode.Return)
				{
					if (keyCode == KeyCode.Backspace)
					{
						this.Backspace();
						return TMP_InputField.EditState.Continue;
					}
					if (keyCode != KeyCode.Return)
					{
						goto IL_1C4;
					}
				}
				else
				{
					if (keyCode == KeyCode.Escape)
					{
						this.m_WasCanceled = true;
						return TMP_InputField.EditState.Finish;
					}
					if (keyCode != KeyCode.A)
					{
						goto IL_1C4;
					}
					if (flag4)
					{
						this.SelectAll();
						return TMP_InputField.EditState.Continue;
					}
					goto IL_1C4;
				}
			}
			else if (keyCode <= KeyCode.V)
			{
				if (keyCode != KeyCode.C)
				{
					if (keyCode != KeyCode.V)
					{
						goto IL_1C4;
					}
					if (flag4)
					{
						this.Append(TMP_InputField.clipboard);
						return TMP_InputField.EditState.Continue;
					}
					goto IL_1C4;
				}
				else
				{
					if (flag4)
					{
						if (this.inputType != TMP_InputField.InputType.Password)
						{
							TMP_InputField.clipboard = this.GetSelectedString();
						}
						else
						{
							TMP_InputField.clipboard = "";
						}
						return TMP_InputField.EditState.Continue;
					}
					goto IL_1C4;
				}
			}
			else if (keyCode != KeyCode.X)
			{
				if (keyCode == KeyCode.Delete)
				{
					this.ForwardSpace();
					return TMP_InputField.EditState.Continue;
				}
				switch (keyCode)
				{
				case KeyCode.KeypadEnter:
					break;
				case KeyCode.KeypadEquals:
				case KeyCode.Insert:
					goto IL_1C4;
				case KeyCode.UpArrow:
					this.MoveUp(flag2);
					return TMP_InputField.EditState.Continue;
				case KeyCode.DownArrow:
					this.MoveDown(flag2);
					return TMP_InputField.EditState.Continue;
				case KeyCode.RightArrow:
					this.MoveRight(flag2, flag);
					return TMP_InputField.EditState.Continue;
				case KeyCode.LeftArrow:
					this.MoveLeft(flag2, flag);
					return TMP_InputField.EditState.Continue;
				case KeyCode.Home:
					this.MoveTextStart(flag2);
					return TMP_InputField.EditState.Continue;
				case KeyCode.End:
					this.MoveTextEnd(flag2);
					return TMP_InputField.EditState.Continue;
				default:
					goto IL_1C4;
				}
			}
			else
			{
				if (flag4)
				{
					if (this.inputType != TMP_InputField.InputType.Password)
					{
						TMP_InputField.clipboard = this.GetSelectedString();
					}
					else
					{
						TMP_InputField.clipboard = "";
					}
					this.Delete();
					this.SendOnValueChangedAndUpdateLabel();
					return TMP_InputField.EditState.Continue;
				}
				goto IL_1C4;
			}
			if (this.lineType != TMP_InputField.LineType.MultiLineNewline)
			{
				return TMP_InputField.EditState.Finish;
			}
			IL_1C4:
			char c = evt.character;
			if (!this.multiLine && (c == '\t' || c == '\r' || c == '\n'))
			{
				return TMP_InputField.EditState.Continue;
			}
			if (c == '\r' || c == '\u0003')
			{
				c = '\n';
			}
			if (this.IsValidChar(c))
			{
				this.Append(c);
			}
			if (c == '\0' && Input.compositionString.Length > 0)
			{
				this.UpdateLabel();
			}
			return TMP_InputField.EditState.Continue;
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000B7B36 File Offset: 0x000B5D36
		private bool IsValidChar(char c)
		{
			return c != '\u007f' && (c == '\t' || c == '\n' || this.m_TextComponent.font.HasCharacter(c, true));
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000B7B5D File Offset: 0x000B5D5D
		public void ProcessEvent(Event e)
		{
			this.KeyPressed(e);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x000B7B68 File Offset: 0x000B5D68
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
			if (!this.isFocused)
			{
				return;
			}
			bool flag = false;
			while (Event.PopEvent(this.m_ProcessingEvent))
			{
				if (this.m_ProcessingEvent.rawType == EventType.KeyDown)
				{
					flag = true;
					if (this.KeyPressed(this.m_ProcessingEvent) == TMP_InputField.EditState.Finish)
					{
						this.DeactivateInputField();
						break;
					}
				}
				EventType type = this.m_ProcessingEvent.type;
				if (type - EventType.ValidateCommand <= 1)
				{
					string commandName = this.m_ProcessingEvent.commandName;
					if (commandName != null && commandName == "SelectAll")
					{
						this.SelectAll();
						flag = true;
					}
				}
			}
			if (flag)
			{
				this.UpdateLabel();
			}
			eventData.Use();
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x000B7BFC File Offset: 0x000B5DFC
		private string GetSelectedString()
		{
			if (!this.hasSelection)
			{
				return "";
			}
			int num = this.stringPositionInternal;
			int num2 = this.stringSelectPositionInternal;
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			return this.text.Substring(num, num2 - num);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x000B7C3C File Offset: 0x000B5E3C
		private int FindtNextWordBegin()
		{
			if (this.stringSelectPositionInternal + 1 >= this.text.Length)
			{
				return this.text.Length;
			}
			int num = this.text.IndexOfAny(TMP_InputField.kSeparators, this.stringSelectPositionInternal + 1);
			if (num == -1)
			{
				num = this.text.Length;
			}
			else
			{
				num++;
			}
			return num;
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x000B7C9C File Offset: 0x000B5E9C
		private void MoveRight(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				this.stringPositionInternal = (this.stringSelectPositionInternal = Mathf.Max(this.stringPositionInternal, this.stringSelectPositionInternal));
				this.caretPositionInternal = (this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal));
				return;
			}
			int caretSelectPositionInternal = this.caretSelectPositionInternal;
			int num;
			if (ctrl)
			{
				num = this.FindtNextWordBegin();
			}
			else
			{
				num = this.stringSelectPositionInternal + 1;
			}
			if (shift)
			{
				this.stringSelectPositionInternal = num;
				this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal);
			}
			else
			{
				this.stringSelectPositionInternal = (this.stringPositionInternal = num);
				this.caretSelectPositionInternal = (this.caretPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal));
			}
			this.isCaretInsideTag = (caretSelectPositionInternal == this.caretSelectPositionInternal);
			Debug.Log("Caret is " + (this.isCaretInsideTag ? " [Inside Tag]" : " [Not Inside Tag]"));
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x000B7D88 File Offset: 0x000B5F88
		private int FindtPrevWordBegin()
		{
			if (this.stringSelectPositionInternal - 2 < 0)
			{
				return 0;
			}
			int num = this.text.LastIndexOfAny(TMP_InputField.kSeparators, this.stringSelectPositionInternal - 2);
			if (num == -1)
			{
				num = 0;
			}
			else
			{
				num++;
			}
			return num;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000B7DC8 File Offset: 0x000B5FC8
		private void MoveLeft(bool shift, bool ctrl)
		{
			if (this.hasSelection && !shift)
			{
				this.stringPositionInternal = (this.stringSelectPositionInternal = Mathf.Min(this.stringPositionInternal, this.stringSelectPositionInternal));
				this.caretPositionInternal = (this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal));
				return;
			}
			int caretSelectPositionInternal = this.caretSelectPositionInternal;
			int num;
			if (ctrl)
			{
				num = this.FindtPrevWordBegin();
			}
			else
			{
				num = this.stringSelectPositionInternal - 1;
			}
			if (shift)
			{
				this.stringSelectPositionInternal = num;
				this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal);
			}
			else
			{
				this.stringSelectPositionInternal = (this.stringPositionInternal = num);
				this.caretSelectPositionInternal = (this.caretPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal));
			}
			this.isCaretInsideTag = (caretSelectPositionInternal == this.caretSelectPositionInternal);
			Debug.Log("Caret is " + (this.isCaretInsideTag ? " [Inside Tag]" : " [Not Inside Tag]"));
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x000B7EB4 File Offset: 0x000B60B4
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			if (originalPos >= this.m_TextComponent.textInfo.characterCount)
			{
				originalPos--;
			}
			TMP_CharacterInfo tmp_CharacterInfo = this.m_TextComponent.textInfo.characterInfo[originalPos];
			int lineNumber = (int)tmp_CharacterInfo.lineNumber;
			if (lineNumber - 1 >= 0)
			{
				int num = this.m_TextComponent.textInfo.lineInfo[lineNumber].firstCharacterIndex - 1;
				int i = this.m_TextComponent.textInfo.lineInfo[lineNumber - 1].firstCharacterIndex;
				while (i < num)
				{
					TMP_CharacterInfo tmp_CharacterInfo2 = this.m_TextComponent.textInfo.characterInfo[i];
					float num2 = (tmp_CharacterInfo.origin - tmp_CharacterInfo2.origin) / (tmp_CharacterInfo2.xAdvance - tmp_CharacterInfo2.origin);
					if (num2 >= 0f && num2 <= 1f)
					{
						if (num2 < 0.5f)
						{
							return i;
						}
						return i + 1;
					}
					else
					{
						i++;
					}
				}
				return num;
			}
			if (!goToFirstChar)
			{
				return originalPos;
			}
			return 0;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x000B7FA8 File Offset: 0x000B61A8
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			if (originalPos >= this.m_TextComponent.textInfo.characterCount)
			{
				return this.text.Length;
			}
			TMP_CharacterInfo tmp_CharacterInfo = this.m_TextComponent.textInfo.characterInfo[originalPos];
			int lineNumber = (int)tmp_CharacterInfo.lineNumber;
			if (lineNumber + 1 < this.m_TextComponent.textInfo.lineCount)
			{
				int lastCharacterIndex = this.m_TextComponent.textInfo.lineInfo[lineNumber + 1].lastCharacterIndex;
				int i = this.m_TextComponent.textInfo.lineInfo[lineNumber + 1].firstCharacterIndex;
				while (i < lastCharacterIndex)
				{
					TMP_CharacterInfo tmp_CharacterInfo2 = this.m_TextComponent.textInfo.characterInfo[i];
					float num = (tmp_CharacterInfo.origin - tmp_CharacterInfo2.origin) / (tmp_CharacterInfo2.xAdvance - tmp_CharacterInfo2.origin);
					if (num >= 0f && num <= 1f)
					{
						if (num < 0.5f)
						{
							return i;
						}
						return i + 1;
					}
					else
					{
						i++;
					}
				}
				return lastCharacterIndex;
			}
			if (!goToLastChar)
			{
				return originalPos;
			}
			return this.m_TextComponent.textInfo.characterCount - 1;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000B80BF File Offset: 0x000B62BF
		private void MoveDown(bool shift)
		{
			this.MoveDown(shift, true);
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000B80CC File Offset: 0x000B62CC
		private void MoveDown(bool shift, bool goToLastChar)
		{
			if (this.hasSelection && !shift)
			{
				this.caretPositionInternal = (this.caretSelectPositionInternal = Mathf.Max(this.caretPositionInternal, this.caretSelectPositionInternal));
			}
			int num = this.multiLine ? this.LineDownCharacterPosition(this.caretSelectPositionInternal, goToLastChar) : this.text.Length;
			if (shift)
			{
				this.caretSelectPositionInternal = num;
				this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(this.caretSelectPositionInternal);
				return;
			}
			this.caretSelectPositionInternal = (this.caretPositionInternal = num);
			this.stringSelectPositionInternal = (this.stringPositionInternal = this.GetStringIndexFromCaretPosition(this.caretSelectPositionInternal));
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x000B816F File Offset: 0x000B636F
		private void MoveUp(bool shift)
		{
			this.MoveUp(shift, true);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x000B817C File Offset: 0x000B637C
		private void MoveUp(bool shift, bool goToFirstChar)
		{
			if (this.hasSelection && !shift)
			{
				this.caretPositionInternal = (this.caretSelectPositionInternal = Mathf.Min(this.caretPositionInternal, this.caretSelectPositionInternal));
			}
			int num = this.multiLine ? this.LineUpCharacterPosition(this.caretSelectPositionInternal, goToFirstChar) : 0;
			if (shift)
			{
				this.caretSelectPositionInternal = num;
				this.stringSelectPositionInternal = this.GetStringIndexFromCaretPosition(this.caretSelectPositionInternal);
				return;
			}
			this.caretSelectPositionInternal = (this.caretPositionInternal = num);
			this.stringSelectPositionInternal = (this.stringPositionInternal = this.GetStringIndexFromCaretPosition(this.caretSelectPositionInternal));
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000B8218 File Offset: 0x000B6418
		private void Delete()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			if (this.stringPositionInternal == this.stringSelectPositionInternal)
			{
				return;
			}
			if (this.stringPositionInternal < this.stringSelectPositionInternal)
			{
				this.m_Text = this.text.Substring(0, this.stringPositionInternal) + this.text.Substring(this.stringSelectPositionInternal, this.text.Length - this.stringSelectPositionInternal);
				this.stringSelectPositionInternal = this.stringPositionInternal;
				return;
			}
			this.m_Text = this.text.Substring(0, this.stringSelectPositionInternal) + this.text.Substring(this.stringPositionInternal, this.text.Length - this.stringPositionInternal);
			this.stringPositionInternal = this.stringSelectPositionInternal;
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000B82E4 File Offset: 0x000B64E4
		private void ForwardSpace()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			if (this.hasSelection)
			{
				this.Delete();
				this.SendOnValueChangedAndUpdateLabel();
				return;
			}
			if (this.stringPositionInternal < this.text.Length)
			{
				this.m_Text = this.text.Remove(this.stringPositionInternal, 1);
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x000B8340 File Offset: 0x000B6540
		private void Backspace()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			if (this.hasSelection)
			{
				this.Delete();
				this.SendOnValueChangedAndUpdateLabel();
				return;
			}
			if (this.stringPositionInternal > 0)
			{
				this.m_Text = this.text.Remove(this.stringPositionInternal - 1, 1);
				this.stringSelectPositionInternal = --this.stringPositionInternal;
				this.m_isLastKeyBackspace = true;
				this.SendOnValueChangedAndUpdateLabel();
			}
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000B83B4 File Offset: 0x000B65B4
		private void Insert(char c)
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			string text = c.ToString();
			this.Delete();
			if (this.characterLimit > 0 && this.text.Length >= this.characterLimit)
			{
				return;
			}
			this.m_Text = this.text.Insert(this.m_StringPosition, text);
			this.stringSelectPositionInternal = (this.stringPositionInternal += text.Length);
			this.SendOnValueChanged();
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000B842F File Offset: 0x000B662F
		private void SendOnValueChangedAndUpdateLabel()
		{
			this.SendOnValueChanged();
			this.UpdateLabel();
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000B843D File Offset: 0x000B663D
		private void SendOnValueChanged()
		{
			if (this.onValueChanged != null)
			{
				this.onValueChanged.Invoke(this.text);
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x000B8458 File Offset: 0x000B6658
		protected void SendOnSubmit()
		{
			if (this.onEndEdit != null)
			{
				this.onEndEdit.Invoke(this.m_Text);
			}
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x000B8473 File Offset: 0x000B6673
		protected void SendOnFocusLost()
		{
			if (this.onFocusLost != null)
			{
				this.onFocusLost.Invoke(this.m_Text);
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x000B8490 File Offset: 0x000B6690
		protected virtual void Append(string input)
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			if (!this.InPlaceEditing())
			{
				return;
			}
			int i = 0;
			int length = input.Length;
			while (i < length)
			{
				char c = input[i];
				if (c >= ' ' || c == '\t' || c == '\r' || c == '\n' || c == '\n')
				{
					this.Append(c);
				}
				i++;
			}
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x000B84EC File Offset: 0x000B66EC
		protected virtual void Append(char input)
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			if (!this.InPlaceEditing())
			{
				return;
			}
			if (this.onValidateInput != null)
			{
				input = this.onValidateInput(this.text, this.stringPositionInternal, input);
			}
			else if (this.characterValidation != TMP_InputField.CharacterValidation.None)
			{
				input = this.Validate(this.text, this.stringPositionInternal, input);
			}
			if (input == '\0')
			{
				return;
			}
			this.Insert(input);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x000B855C File Offset: 0x000B675C
		protected void UpdateLabel()
		{
			if (this.m_TextComponent != null && this.m_TextComponent.font != null)
			{
				string text;
				if (Input.compositionString.Length > 0)
				{
					text = this.text.Substring(0, this.m_StringPosition) + Input.compositionString + this.text.Substring(this.m_StringPosition);
				}
				else
				{
					text = this.text;
				}
				string str;
				if (this.inputType == TMP_InputField.InputType.Password)
				{
					str = new string(this.asteriskChar, text.Length);
				}
				else
				{
					str = text;
				}
				bool flag = string.IsNullOrEmpty(text);
				if (this.m_Placeholder != null)
				{
					this.m_Placeholder.enabled = flag;
				}
				if (!this.m_AllowInput)
				{
					this.m_DrawStart = 0;
					this.m_DrawEnd = this.m_Text.Length;
				}
				if (!flag)
				{
					this.SetCaretVisible();
				}
				this.m_TextComponent.text = str + "​";
				this.MarkGeometryAsDirty();
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x000B865C File Offset: 0x000B685C
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			int characterCount = this.m_TextComponent.textInfo.characterCount;
			for (int i = 0; i < characterCount; i++)
			{
				if ((int)this.m_TextComponent.textInfo.characterInfo[i].index >= stringIndex)
				{
					return i;
				}
			}
			return characterCount;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x000B86A7 File Offset: 0x000B68A7
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return (int)this.m_TextComponent.textInfo.characterInfo[caretPosition].index;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000B86C4 File Offset: 0x000B68C4
		public void ForceLabelUpdate()
		{
			this.UpdateLabel();
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000B86CC File Offset: 0x000B68CC
		private void MarkGeometryAsDirty()
		{
			CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000B86D4 File Offset: 0x000B68D4
		public virtual void Rebuild(CanvasUpdate update)
		{
			if (update == CanvasUpdate.LatePreRender)
			{
				this.UpdateGeometry();
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000B86E0 File Offset: 0x000B68E0
		private void UpdateGeometry()
		{
			if (!this.shouldHideMobileInput)
			{
				return;
			}
			if (this.m_CachedInputRenderer == null && this.m_TextComponent != null)
			{
				GameObject gameObject = new GameObject(base.transform.name + " Input Caret");
				gameObject.hideFlags = HideFlags.DontSave;
				gameObject.transform.SetParent(this.m_TextComponent.transform.parent);
				gameObject.transform.SetAsFirstSibling();
				gameObject.layer = base.gameObject.layer;
				this.caretRectTrans = gameObject.AddComponent<RectTransform>();
				this.m_CachedInputRenderer = gameObject.AddComponent<CanvasRenderer>();
				this.m_CachedInputRenderer.SetMaterial(Graphic.defaultGraphicMaterial, Texture2D.whiteTexture);
				gameObject.AddComponent<LayoutElement>().ignoreLayout = true;
				this.AssignPositioningIfNeeded();
			}
			if (this.m_CachedInputRenderer == null)
			{
				return;
			}
			this.OnFillVBO(this.mesh);
			this.m_CachedInputRenderer.SetMesh(this.mesh);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000B87E0 File Offset: 0x000B69E0
		private void AssignPositioningIfNeeded()
		{
			if (this.m_TextComponent != null && this.caretRectTrans != null && (this.caretRectTrans.localPosition != this.m_TextComponent.rectTransform.localPosition || this.caretRectTrans.localRotation != this.m_TextComponent.rectTransform.localRotation || this.caretRectTrans.localScale != this.m_TextComponent.rectTransform.localScale || this.caretRectTrans.anchorMin != this.m_TextComponent.rectTransform.anchorMin || this.caretRectTrans.anchorMax != this.m_TextComponent.rectTransform.anchorMax || this.caretRectTrans.anchoredPosition != this.m_TextComponent.rectTransform.anchoredPosition || this.caretRectTrans.sizeDelta != this.m_TextComponent.rectTransform.sizeDelta || this.caretRectTrans.pivot != this.m_TextComponent.rectTransform.pivot))
			{
				this.caretRectTrans.localPosition = this.m_TextComponent.rectTransform.localPosition;
				this.caretRectTrans.localRotation = this.m_TextComponent.rectTransform.localRotation;
				this.caretRectTrans.localScale = this.m_TextComponent.rectTransform.localScale;
				this.caretRectTrans.anchorMin = this.m_TextComponent.rectTransform.anchorMin;
				this.caretRectTrans.anchorMax = this.m_TextComponent.rectTransform.anchorMax;
				this.caretRectTrans.anchoredPosition = this.m_TextComponent.rectTransform.anchoredPosition;
				this.caretRectTrans.sizeDelta = this.m_TextComponent.rectTransform.sizeDelta;
				this.caretRectTrans.pivot = this.m_TextComponent.rectTransform.pivot;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000B8A08 File Offset: 0x000B6C08
		private void OnFillVBO(Mesh vbo)
		{
			using (VertexHelper vertexHelper = new VertexHelper())
			{
				if (!this.isFocused)
				{
					vertexHelper.FillMesh(vbo);
				}
				else
				{
					if (!this.hasSelection)
					{
						this.GenerateCaret(vertexHelper, Vector2.zero);
					}
					else
					{
						this.GenerateHightlight(vertexHelper, Vector2.zero);
					}
					vertexHelper.FillMesh(vbo);
				}
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000B8A74 File Offset: 0x000B6C74
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
			if (!this.m_CaretVisible)
			{
				return;
			}
			if (this.m_CursorVerts == null)
			{
				this.CreateCursorVerts();
			}
			float num = (float)this.m_CaretWidth;
			int characterCount = this.m_TextComponent.textInfo.characterCount;
			Vector2 zero = Vector2.zero;
			this.caretPositionInternal = this.GetCaretPositionFromStringIndex(this.stringPositionInternal);
			TMP_CharacterInfo tmp_CharacterInfo;
			float num2;
			if (this.caretPositionInternal == 0)
			{
				tmp_CharacterInfo = this.m_TextComponent.textInfo.characterInfo[0];
				zero = new Vector2(tmp_CharacterInfo.origin, tmp_CharacterInfo.descender);
				num2 = tmp_CharacterInfo.ascender - tmp_CharacterInfo.descender;
			}
			else if (this.caretPositionInternal < characterCount)
			{
				tmp_CharacterInfo = this.m_TextComponent.textInfo.characterInfo[this.caretPositionInternal];
				zero = new Vector2(tmp_CharacterInfo.origin, tmp_CharacterInfo.descender);
				num2 = tmp_CharacterInfo.ascender - tmp_CharacterInfo.descender;
			}
			else
			{
				tmp_CharacterInfo = this.m_TextComponent.textInfo.characterInfo[characterCount - 1];
				zero = new Vector2(tmp_CharacterInfo.xAdvance, tmp_CharacterInfo.descender);
				num2 = tmp_CharacterInfo.ascender - tmp_CharacterInfo.descender;
			}
			this.AdjustRectTransformRelativeToViewport(zero, num2, tmp_CharacterInfo.isVisible);
			float num3 = zero.y + num2;
			float y = num3 - Mathf.Min(num2, this.m_TextComponent.rectTransform.rect.height);
			this.m_CursorVerts[0].position = new Vector3(zero.x, y, 0f);
			this.m_CursorVerts[1].position = new Vector3(zero.x, num3, 0f);
			this.m_CursorVerts[2].position = new Vector3(zero.x + num, num3, 0f);
			this.m_CursorVerts[3].position = new Vector3(zero.x + num, y, 0f);
			this.m_CursorVerts[0].color = this.caretColor;
			this.m_CursorVerts[1].color = this.caretColor;
			this.m_CursorVerts[2].color = this.caretColor;
			this.m_CursorVerts[3].color = this.caretColor;
			vbo.AddUIVertexQuad(this.m_CursorVerts);
			int height = Screen.height;
			zero.y = (float)height - zero.y;
			Input.compositionCursorPos = zero;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000B8D0C File Offset: 0x000B6F0C
		private void CreateCursorVerts()
		{
			this.m_CursorVerts = new UIVertex[4];
			for (int i = 0; i < this.m_CursorVerts.Length; i++)
			{
				this.m_CursorVerts[i] = UIVertex.simpleVert;
				this.m_CursorVerts[i].uv0 = Vector2.zero;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000B8D64 File Offset: 0x000B6F64
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
			TMP_TextInfo textInfo = this.m_TextComponent.textInfo;
			this.caretPositionInternal = this.GetCaretPositionFromStringIndex(this.stringPositionInternal);
			this.caretSelectPositionInternal = this.GetCaretPositionFromStringIndex(this.stringSelectPositionInternal);
			Debug.Log("StringPosition:" + this.stringPositionInternal.ToString() + "  StringSelectPosition:" + this.stringSelectPositionInternal.ToString());
			Vector2 startPosition;
			float height;
			if (this.caretSelectPositionInternal < textInfo.characterCount)
			{
				startPosition = new Vector2(textInfo.characterInfo[this.caretSelectPositionInternal].origin, textInfo.characterInfo[this.caretSelectPositionInternal].descender);
				height = textInfo.characterInfo[this.caretSelectPositionInternal].ascender - textInfo.characterInfo[this.caretSelectPositionInternal].descender;
			}
			else
			{
				startPosition = new Vector2(textInfo.characterInfo[this.caretSelectPositionInternal - 1].xAdvance, textInfo.characterInfo[this.caretSelectPositionInternal - 1].descender);
				height = textInfo.characterInfo[this.caretSelectPositionInternal - 1].ascender - textInfo.characterInfo[this.caretSelectPositionInternal - 1].descender;
			}
			this.AdjustRectTransformRelativeToViewport(startPosition, height, true);
			int num = Mathf.Max(0, this.caretPositionInternal);
			int num2 = Mathf.Max(0, this.caretSelectPositionInternal);
			if (num > num2)
			{
				int num3 = num;
				num = num2;
				num2 = num3;
			}
			num2--;
			int num4 = (int)textInfo.characterInfo[num].lineNumber;
			int lastCharacterIndex = textInfo.lineInfo[num4].lastCharacterIndex;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.uv0 = Vector2.zero;
			simpleVert.color = this.selectionColor;
			int num5 = num;
			while (num5 <= num2 && num5 < textInfo.characterCount)
			{
				if (num5 == lastCharacterIndex || num5 == num2)
				{
					TMP_CharacterInfo tmp_CharacterInfo = textInfo.characterInfo[num];
					TMP_CharacterInfo tmp_CharacterInfo2 = textInfo.characterInfo[num5];
					Vector2 vector = new Vector2(tmp_CharacterInfo.origin, tmp_CharacterInfo.ascender);
					Vector2 vector2 = new Vector2(tmp_CharacterInfo2.xAdvance, tmp_CharacterInfo2.descender);
					Vector2 min = this.m_TextViewport.rect.min;
					Vector2 max = this.m_TextViewport.rect.max;
					float num6 = this.m_TextComponent.rectTransform.anchoredPosition.x + vector.x - min.x;
					if (num6 < 0f)
					{
						vector.x -= num6;
					}
					float num7 = this.m_TextComponent.rectTransform.anchoredPosition.y + vector2.y - min.y;
					if (num7 < 0f)
					{
						vector2.y -= num7;
					}
					float num8 = max.x - (this.m_TextComponent.rectTransform.anchoredPosition.x + vector2.x);
					if (num8 < 0f)
					{
						vector2.x += num8;
					}
					float num9 = max.y - (this.m_TextComponent.rectTransform.anchoredPosition.y + vector.y);
					if (num9 < 0f)
					{
						vector.y += num9;
					}
					if (this.m_TextComponent.rectTransform.anchoredPosition.y + vector.y >= min.y && this.m_TextComponent.rectTransform.anchoredPosition.y + vector2.y <= max.y)
					{
						int currentVertCount = vbo.currentVertCount;
						simpleVert.position = new Vector3(vector.x, vector2.y, 0f);
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector2.x, vector2.y, 0f);
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector2.x, vector.y, 0f);
						vbo.AddVert(simpleVert);
						simpleVert.position = new Vector3(vector.x, vector.y, 0f);
						vbo.AddVert(simpleVert);
						vbo.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
						vbo.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
					}
					num = num5 + 1;
					num4++;
					if (num4 < textInfo.lineCount)
					{
						lastCharacterIndex = textInfo.lineInfo[num4].lastCharacterIndex;
					}
				}
				num5++;
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000B9210 File Offset: 0x000B7410
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
			float xMin = this.m_TextViewport.rect.xMin;
			float xMax = this.m_TextViewport.rect.xMax;
			float num = xMax - (this.m_TextComponent.rectTransform.anchoredPosition.x + startPosition.x + this.m_TextComponent.margin.z);
			if (num < 0f && (!this.multiLine || (this.multiLine && isCharVisible)))
			{
				this.m_TextComponent.rectTransform.anchoredPosition += new Vector2(num, 0f);
				this.AssignPositioningIfNeeded();
			}
			float num2 = this.m_TextComponent.rectTransform.anchoredPosition.x + startPosition.x - this.m_TextComponent.margin.x - xMin;
			if (num2 < 0f)
			{
				this.m_TextComponent.rectTransform.anchoredPosition += new Vector2(-num2, 0f);
				this.AssignPositioningIfNeeded();
			}
			if (this.m_LineType != TMP_InputField.LineType.SingleLine)
			{
				float num3 = this.m_TextViewport.rect.yMax - (this.m_TextComponent.rectTransform.anchoredPosition.y + startPosition.y + height);
				if (num3 < -0.0001f)
				{
					this.m_TextComponent.rectTransform.anchoredPosition += new Vector2(0f, num3);
					this.AssignPositioningIfNeeded();
				}
				float num4 = this.m_TextComponent.rectTransform.anchoredPosition.y + startPosition.y - this.m_TextViewport.rect.yMin;
				if (num4 < 0f)
				{
					this.m_TextComponent.rectTransform.anchoredPosition -= new Vector2(0f, num4);
					this.AssignPositioningIfNeeded();
				}
			}
			if (this.m_isLastKeyBackspace)
			{
				float num5 = this.m_TextComponent.rectTransform.anchoredPosition.x + this.m_TextComponent.textInfo.characterInfo[0].origin - this.m_TextComponent.margin.x;
				float num6 = this.m_TextComponent.rectTransform.anchoredPosition.x + this.m_TextComponent.textInfo.characterInfo[this.m_TextComponent.textInfo.characterCount - 1].origin + this.m_TextComponent.margin.z;
				if (this.m_TextComponent.rectTransform.anchoredPosition.x + startPosition.x <= xMin + 0.0001f)
				{
					if (num5 < xMin)
					{
						float x = Mathf.Min((xMax - xMin) / 2f, xMin - num5);
						this.m_TextComponent.rectTransform.anchoredPosition += new Vector2(x, 0f);
						this.AssignPositioningIfNeeded();
					}
				}
				else if (num6 < xMax && num5 < xMin)
				{
					float x2 = Mathf.Min(xMax - num6, xMin - num5);
					this.m_TextComponent.rectTransform.anchoredPosition += new Vector2(x2, 0f);
					this.AssignPositioningIfNeeded();
				}
				this.m_isLastKeyBackspace = false;
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x000B9564 File Offset: 0x000B7764
		protected char Validate(string text, int pos, char ch)
		{
			if (this.characterValidation == TMP_InputField.CharacterValidation.None || !base.enabled)
			{
				return ch;
			}
			if (this.characterValidation == TMP_InputField.CharacterValidation.Integer || this.characterValidation == TMP_InputField.CharacterValidation.Decimal)
			{
				bool flag = pos == 0 && text.Length > 0 && text[0] == '-';
				bool flag2 = this.stringPositionInternal == 0 || this.stringSelectPositionInternal == 0;
				if (!flag)
				{
					if (ch >= '0' && ch <= '9')
					{
						return ch;
					}
					if (ch == '-' && (pos == 0 || flag2))
					{
						return ch;
					}
					if (ch == '.' && this.characterValidation == TMP_InputField.CharacterValidation.Decimal && !text.Contains("."))
					{
						return ch;
					}
				}
			}
			else if (this.characterValidation == TMP_InputField.CharacterValidation.Alphanumeric)
			{
				if (ch >= 'A' && ch <= 'Z')
				{
					return ch;
				}
				if (ch >= 'a' && ch <= 'z')
				{
					return ch;
				}
				if (ch >= '0' && ch <= '9')
				{
					return ch;
				}
			}
			else if (this.characterValidation == TMP_InputField.CharacterValidation.Name)
			{
				char c = (text.Length > 0) ? text[Mathf.Clamp(pos, 0, text.Length - 1)] : ' ';
				char c2 = (text.Length > 0) ? text[Mathf.Clamp(pos + 1, 0, text.Length - 1)] : '\n';
				if (char.IsLetter(ch))
				{
					if (char.IsLower(ch) && c == ' ')
					{
						return char.ToUpper(ch);
					}
					if (char.IsUpper(ch) && c != ' ' && c != '\'')
					{
						return char.ToLower(ch);
					}
					return ch;
				}
				else if (ch == '\'')
				{
					if (c != ' ' && c != '\'' && c2 != '\'' && !text.Contains("'"))
					{
						return ch;
					}
				}
				else if (ch == ' ' && c != ' ' && c != '\'' && c2 != ' ' && c2 != '\'')
				{
					return ch;
				}
			}
			else if (this.characterValidation == TMP_InputField.CharacterValidation.EmailAddress)
			{
				if (ch >= 'A' && ch <= 'Z')
				{
					return ch;
				}
				if (ch >= 'a' && ch <= 'z')
				{
					return ch;
				}
				if (ch >= '0' && ch <= '9')
				{
					return ch;
				}
				if (ch == '@' && text.IndexOf('@') == -1)
				{
					return ch;
				}
				if ("!#$%&'*+-/=?^_`{|}~".IndexOf(ch) != -1)
				{
					return ch;
				}
				if (ch == '.')
				{
					int num = (int)((text.Length > 0) ? text[Mathf.Clamp(pos, 0, text.Length - 1)] : ' ');
					char c3 = (text.Length > 0) ? text[Mathf.Clamp(pos + 1, 0, text.Length - 1)] : '\n';
					if (num != 46 && c3 != '.')
					{
						return ch;
					}
				}
			}
			return '\0';
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x000B97D0 File Offset: 0x000B79D0
		public void ActivateInputField()
		{
			if (this.m_TextComponent == null || this.m_TextComponent.font == null || !this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (this.isFocused && this.m_Keyboard != null && !this.m_Keyboard.active)
			{
				this.m_Keyboard.active = true;
				this.m_Keyboard.text = this.m_Text;
			}
			this.m_HasLostFocus = false;
			this.m_ShouldActivateNextUpdate = true;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x000B9858 File Offset: 0x000B7A58
		private void ActivateInputFieldInternal()
		{
			if (EventSystem.current == null)
			{
				return;
			}
			if (EventSystem.current.currentSelectedGameObject != base.gameObject)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject);
			}
			if (TouchScreenKeyboard.isSupported)
			{
				if (Input.touchSupported)
				{
					TouchScreenKeyboard.hideInput = this.shouldHideMobileInput;
				}
				this.m_Keyboard = ((this.inputType == TMP_InputField.InputType.Password) ? TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, false, this.multiLine, true) : TouchScreenKeyboard.Open(this.m_Text, this.keyboardType, this.inputType == TMP_InputField.InputType.AutoCorrect, this.multiLine));
				this.MoveTextEnd(false);
			}
			else
			{
				Input.imeCompositionMode = IMECompositionMode.On;
				this.OnFocus();
			}
			this.m_AllowInput = true;
			this.m_OriginalText = this.text;
			this.m_WasCanceled = false;
			this.SetCaretVisible();
			this.UpdateLabel();
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000B9938 File Offset: 0x000B7B38
		public override void OnSelect(BaseEventData eventData)
		{
			Debug.Log("OnSelect()");
			base.OnSelect(eventData);
			this.ActivateInputField();
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x000B9951 File Offset: 0x000B7B51
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.ActivateInputField();
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x000B9964 File Offset: 0x000B7B64
		public void DeactivateInputField()
		{
			if (!this.m_AllowInput)
			{
				return;
			}
			this.m_HasDoneFocusTransition = false;
			this.m_AllowInput = false;
			if (this.m_Placeholder != null)
			{
				this.m_Placeholder.enabled = string.IsNullOrEmpty(this.m_Text);
			}
			if (this.m_TextComponent != null && this.IsInteractable())
			{
				if (this.m_WasCanceled)
				{
					this.text = this.m_OriginalText;
				}
				if (this.m_Keyboard != null)
				{
					this.m_Keyboard.active = false;
					this.m_Keyboard = null;
				}
				this.m_StringPosition = (this.m_StringSelectPosition = 0);
				this.m_TextComponent.rectTransform.localPosition = Vector3.zero;
				if (this.caretRectTrans != null)
				{
					this.caretRectTrans.localPosition = Vector3.zero;
				}
				this.SendOnSubmit();
				if (this.m_HasLostFocus)
				{
					this.SendOnFocusLost();
				}
				Input.imeCompositionMode = IMECompositionMode.Auto;
			}
			this.MarkGeometryAsDirty();
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000B9A5A File Offset: 0x000B7C5A
		public override void OnDeselect(BaseEventData eventData)
		{
			Debug.Log("OnDeselect()");
			this.m_HasLostFocus = true;
			this.DeactivateInputField();
			base.OnDeselect(eventData);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000B9A7A File Offset: 0x000B7C7A
		public virtual void OnSubmit(BaseEventData eventData)
		{
			Debug.Log("OnSubmit()");
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			if (!this.isFocused)
			{
				this.m_ShouldActivateNextUpdate = true;
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000B9AA8 File Offset: 0x000B7CA8
		private void EnforceContentType()
		{
			switch (this.contentType)
			{
			case TMP_InputField.ContentType.Standard:
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.None;
				return;
			case TMP_InputField.ContentType.Autocorrected:
				this.m_InputType = TMP_InputField.InputType.AutoCorrect;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.None;
				return;
			case TMP_InputField.ContentType.IntegerNumber:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.Integer;
				return;
			case TMP_InputField.ContentType.DecimalNumber:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.NumbersAndPunctuation;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.Decimal;
				return;
			case TMP_InputField.ContentType.Alphanumeric:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.ASCIICapable;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.Alphanumeric;
				return;
			case TMP_InputField.ContentType.Name:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.Name;
				return;
			case TMP_InputField.ContentType.EmailAddress:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Standard;
				this.m_KeyboardType = TouchScreenKeyboardType.EmailAddress;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.EmailAddress;
				return;
			case TMP_InputField.ContentType.Password:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.Default;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.None;
				return;
			case TMP_InputField.ContentType.Pin:
				this.m_LineType = TMP_InputField.LineType.SingleLine;
				this.m_TextComponent.enableWordWrapping = false;
				this.m_InputType = TMP_InputField.InputType.Password;
				this.m_KeyboardType = TouchScreenKeyboardType.NumberPad;
				this.m_CharacterValidation = TMP_InputField.CharacterValidation.Integer;
				return;
			default:
				return;
			}
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x000B9C31 File Offset: 0x000B7E31
		private void SetTextComponentWrapMode()
		{
			if (this.m_TextComponent == null)
			{
				return;
			}
			if (this.m_LineType == TMP_InputField.LineType.SingleLine)
			{
				this.m_TextComponent.enableWordWrapping = false;
				return;
			}
			this.m_TextComponent.enableWordWrapping = true;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x000B9C63 File Offset: 0x000B7E63
		private void SetTextComponentRichTextMode()
		{
			if (this.m_TextComponent == null)
			{
				return;
			}
			this.m_TextComponent.richText = this.m_RichText;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x000B9C88 File Offset: 0x000B7E88
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
			if (this.contentType == TMP_InputField.ContentType.Custom)
			{
				return;
			}
			for (int i = 0; i < allowedContentTypes.Length; i++)
			{
				if (this.contentType == allowedContentTypes[i])
				{
					return;
				}
			}
			this.contentType = TMP_InputField.ContentType.Custom;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000B9CC2 File Offset: 0x000B7EC2
		private void SetToCustom()
		{
			if (this.contentType == TMP_InputField.ContentType.Custom)
			{
				return;
			}
			this.contentType = TMP_InputField.ContentType.Custom;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000B9CD7 File Offset: 0x000B7ED7
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			if (this.m_HasDoneFocusTransition)
			{
				state = Selectable.SelectionState.Highlighted;
			}
			else if (state == Selectable.SelectionState.Pressed)
			{
				this.m_HasDoneFocusTransition = true;
			}
			base.DoStateTransition(state, instant);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x000B9CFB File Offset: 0x000B7EFB
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_InputField()
		{
			TMP_InputField.kSeparators = new char[]
			{
				' ',
				'.',
				',',
				'\t',
				'\r',
				'\n'
			};
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x000B9D13 File Offset: 0x000B7F13
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x040027E9 RID: 10217
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x040027EA RID: 10218
		private static readonly char[] kSeparators;

		// Token: 0x040027EB RID: 10219
		[SerializeField]
		protected RectTransform m_TextViewport;

		// Token: 0x040027EC RID: 10220
		[SerializeField]
		protected TMP_Text m_TextComponent;

		// Token: 0x040027ED RID: 10221
		protected RectTransform m_TextComponentRectTransform;

		// Token: 0x040027EE RID: 10222
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x040027EF RID: 10223
		[SerializeField]
		private TMP_InputField.ContentType m_ContentType;

		// Token: 0x040027F0 RID: 10224
		[SerializeField]
		private TMP_InputField.InputType m_InputType;

		// Token: 0x040027F1 RID: 10225
		[SerializeField]
		private char m_AsteriskChar;

		// Token: 0x040027F2 RID: 10226
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x040027F3 RID: 10227
		[SerializeField]
		private TMP_InputField.LineType m_LineType;

		// Token: 0x040027F4 RID: 10228
		[SerializeField]
		private bool m_HideMobileInput;

		// Token: 0x040027F5 RID: 10229
		[SerializeField]
		private TMP_InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x040027F6 RID: 10230
		[SerializeField]
		private int m_CharacterLimit;

		// Token: 0x040027F7 RID: 10231
		[SerializeField]
		private TMP_InputField.SubmitEvent m_OnEndEdit;

		// Token: 0x040027F8 RID: 10232
		[SerializeField]
		private TMP_InputField.SubmitEvent m_OnSubmit;

		// Token: 0x040027F9 RID: 10233
		[SerializeField]
		private TMP_InputField.SubmitEvent m_OnFocusLost;

		// Token: 0x040027FA RID: 10234
		[SerializeField]
		private TMP_InputField.OnChangeEvent m_OnValueChanged;

		// Token: 0x040027FB RID: 10235
		[SerializeField]
		private TMP_InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x040027FC RID: 10236
		[SerializeField]
		private Color m_CaretColor;

		// Token: 0x040027FD RID: 10237
		[SerializeField]
		private bool m_CustomCaretColor;

		// Token: 0x040027FE RID: 10238
		[SerializeField]
		private Color m_SelectionColor;

		// Token: 0x040027FF RID: 10239
		[SerializeField]
		protected string m_Text;

		// Token: 0x04002800 RID: 10240
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		// Token: 0x04002801 RID: 10241
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		// Token: 0x04002802 RID: 10242
		[SerializeField]
		private bool m_ReadOnly;

		// Token: 0x04002803 RID: 10243
		[SerializeField]
		private bool m_RichText;

		// Token: 0x04002804 RID: 10244
		protected int m_StringPosition;

		// Token: 0x04002805 RID: 10245
		protected int m_StringSelectPosition;

		// Token: 0x04002806 RID: 10246
		protected int m_CaretPosition;

		// Token: 0x04002807 RID: 10247
		protected int m_CaretSelectPosition;

		// Token: 0x04002808 RID: 10248
		private RectTransform caretRectTrans;

		// Token: 0x04002809 RID: 10249
		protected UIVertex[] m_CursorVerts;

		// Token: 0x0400280A RID: 10250
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x0400280B RID: 10251
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x0400280C RID: 10252
		private bool m_AllowInput;

		// Token: 0x0400280D RID: 10253
		private bool m_HasLostFocus;

		// Token: 0x0400280E RID: 10254
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x0400280F RID: 10255
		private bool m_UpdateDrag;

		// Token: 0x04002810 RID: 10256
		private bool m_DragPositionOutOfBounds;

		// Token: 0x04002811 RID: 10257
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x04002812 RID: 10258
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x04002813 RID: 10259
		protected bool m_CaretVisible;

		// Token: 0x04002814 RID: 10260
		private Coroutine m_BlinkCoroutine;

		// Token: 0x04002815 RID: 10261
		private float m_BlinkStartTime;

		// Token: 0x04002816 RID: 10262
		protected int m_DrawStart;

		// Token: 0x04002817 RID: 10263
		protected int m_DrawEnd;

		// Token: 0x04002818 RID: 10264
		private Coroutine m_DragCoroutine;

		// Token: 0x04002819 RID: 10265
		private string m_OriginalText;

		// Token: 0x0400281A RID: 10266
		private bool m_WasCanceled;

		// Token: 0x0400281B RID: 10267
		private bool m_HasDoneFocusTransition;

		// Token: 0x0400281C RID: 10268
		private bool m_isLastKeyBackspace;

		// Token: 0x0400281D RID: 10269
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x0400281E RID: 10270
		private bool isCaretInsideTag;

		// Token: 0x0400281F RID: 10271
		private Event m_ProcessingEvent;

		// Token: 0x020005F0 RID: 1520
		public enum ContentType
		{
			// Token: 0x04002821 RID: 10273
			Standard,
			// Token: 0x04002822 RID: 10274
			Autocorrected,
			// Token: 0x04002823 RID: 10275
			IntegerNumber,
			// Token: 0x04002824 RID: 10276
			DecimalNumber,
			// Token: 0x04002825 RID: 10277
			Alphanumeric,
			// Token: 0x04002826 RID: 10278
			Name,
			// Token: 0x04002827 RID: 10279
			EmailAddress,
			// Token: 0x04002828 RID: 10280
			Password,
			// Token: 0x04002829 RID: 10281
			Pin,
			// Token: 0x0400282A RID: 10282
			Custom
		}

		// Token: 0x020005F1 RID: 1521
		public enum InputType
		{
			// Token: 0x0400282C RID: 10284
			Standard,
			// Token: 0x0400282D RID: 10285
			AutoCorrect,
			// Token: 0x0400282E RID: 10286
			Password
		}

		// Token: 0x020005F2 RID: 1522
		public enum CharacterValidation
		{
			// Token: 0x04002830 RID: 10288
			None,
			// Token: 0x04002831 RID: 10289
			Integer,
			// Token: 0x04002832 RID: 10290
			Decimal,
			// Token: 0x04002833 RID: 10291
			Alphanumeric,
			// Token: 0x04002834 RID: 10292
			Name,
			// Token: 0x04002835 RID: 10293
			EmailAddress
		}

		// Token: 0x020005F3 RID: 1523
		public enum LineType
		{
			// Token: 0x04002837 RID: 10295
			SingleLine,
			// Token: 0x04002838 RID: 10296
			MultiLineSubmit,
			// Token: 0x04002839 RID: 10297
			MultiLineNewline
		}

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x06002418 RID: 9240
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		// Token: 0x020005F5 RID: 1525
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
		}

		// Token: 0x020005F6 RID: 1526
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
		}

		// Token: 0x020005F7 RID: 1527
		protected enum EditState
		{
			// Token: 0x0400283B RID: 10299
			Continue,
			// Token: 0x0400283C RID: 10300
			Finish
		}
	}
}
