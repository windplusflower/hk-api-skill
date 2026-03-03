using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006D8 RID: 1752
	[Serializable]
	public class InputControlMapping
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000E8048 File Offset: 0x000E6248
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x000E807D File Offset: 0x000E627D
		public string Name
		{
			get
			{
				if (!string.IsNullOrEmpty(this.name))
				{
					return this.name;
				}
				return this.Target.ToString();
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000E8086 File Offset: 0x000E6286
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x000E808E File Offset: 0x000E628E
		public bool Invert
		{
			get
			{
				return this.invert;
			}
			set
			{
				this.invert = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000E8097 File Offset: 0x000E6297
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x000E809F File Offset: 0x000E629F
		public float Scale
		{
			get
			{
				return this.scale;
			}
			set
			{
				this.scale = value;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000E80A8 File Offset: 0x000E62A8
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x000E80B0 File Offset: 0x000E62B0
		public bool Raw
		{
			get
			{
				return this.raw;
			}
			set
			{
				this.raw = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000E80B9 File Offset: 0x000E62B9
		// (set) Token: 0x06002A05 RID: 10757 RVA: 0x000E80C1 File Offset: 0x000E62C1
		public bool Passive
		{
			get
			{
				return this.passive;
			}
			set
			{
				this.passive = value;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000E80CA File Offset: 0x000E62CA
		// (set) Token: 0x06002A07 RID: 10759 RVA: 0x000E80D2 File Offset: 0x000E62D2
		public bool IgnoreInitialZeroValue
		{
			get
			{
				return this.ignoreInitialZeroValue;
			}
			set
			{
				this.ignoreInitialZeroValue = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000E80DB File Offset: 0x000E62DB
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x000E80E3 File Offset: 0x000E62E3
		public float Sensitivity
		{
			get
			{
				return this.sensitivity;
			}
			set
			{
				this.sensitivity = Mathf.Clamp01(value);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000E80F1 File Offset: 0x000E62F1
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x000E80F9 File Offset: 0x000E62F9
		public float LowerDeadZone
		{
			get
			{
				return this.lowerDeadZone;
			}
			set
			{
				this.lowerDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x000E8107 File Offset: 0x000E6307
		// (set) Token: 0x06002A0D RID: 10765 RVA: 0x000E810F File Offset: 0x000E630F
		public float UpperDeadZone
		{
			get
			{
				return this.upperDeadZone;
			}
			set
			{
				this.upperDeadZone = Mathf.Clamp01(value);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x000E811D File Offset: 0x000E631D
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x000E8125 File Offset: 0x000E6325
		public InputControlSource Source
		{
			get
			{
				return this.source;
			}
			set
			{
				this.source = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002A10 RID: 10768 RVA: 0x000E812E File Offset: 0x000E632E
		// (set) Token: 0x06002A11 RID: 10769 RVA: 0x000E8136 File Offset: 0x000E6336
		public InputControlType Target
		{
			get
			{
				return this.target;
			}
			set
			{
				this.target = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000E813F File Offset: 0x000E633F
		// (set) Token: 0x06002A13 RID: 10771 RVA: 0x000E8147 File Offset: 0x000E6347
		public InputRangeType SourceRange
		{
			get
			{
				return this.sourceRange;
			}
			set
			{
				this.sourceRange = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x000E8150 File Offset: 0x000E6350
		// (set) Token: 0x06002A15 RID: 10773 RVA: 0x000E8158 File Offset: 0x000E6358
		public InputRangeType TargetRange
		{
			get
			{
				return this.targetRange;
			}
			set
			{
				this.targetRange = value;
			}
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000E8164 File Offset: 0x000E6364
		public float ApplyToValue(float value)
		{
			if (this.Raw)
			{
				value *= this.Scale;
				value = (InputRange.Excludes(this.sourceRange, value) ? 0f : value);
			}
			else
			{
				value = Mathf.Clamp(value * this.Scale, -1f, 1f);
				value = InputRange.Remap(value, this.sourceRange, this.targetRange);
			}
			if (this.Invert)
			{
				value = -value;
			}
			return value;
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000E81E4 File Offset: 0x000E63E4
		public InputControlMapping()
		{
			this.name = "";
			this.scale = 1f;
			this.sensitivity = 1f;
			this.upperDeadZone = 1f;
			this.sourceRange = InputRangeType.MinusOneToOne;
			this.targetRange = InputRangeType.MinusOneToOne;
			base..ctor();
		}

		// Token: 0x04002FDD RID: 12253
		[SerializeField]
		private string name;

		// Token: 0x04002FDE RID: 12254
		[SerializeField]
		private bool invert;

		// Token: 0x04002FDF RID: 12255
		[SerializeField]
		private float scale;

		// Token: 0x04002FE0 RID: 12256
		[SerializeField]
		private bool raw;

		// Token: 0x04002FE1 RID: 12257
		[SerializeField]
		private bool passive;

		// Token: 0x04002FE2 RID: 12258
		[SerializeField]
		private bool ignoreInitialZeroValue;

		// Token: 0x04002FE3 RID: 12259
		[SerializeField]
		private float sensitivity;

		// Token: 0x04002FE4 RID: 12260
		[SerializeField]
		private float lowerDeadZone;

		// Token: 0x04002FE5 RID: 12261
		[SerializeField]
		private float upperDeadZone;

		// Token: 0x04002FE6 RID: 12262
		[SerializeField]
		private InputControlSource source;

		// Token: 0x04002FE7 RID: 12263
		[SerializeField]
		private InputControlType target;

		// Token: 0x04002FE8 RID: 12264
		[SerializeField]
		private InputRangeType sourceRange;

		// Token: 0x04002FE9 RID: 12265
		[SerializeField]
		private InputRangeType targetRange;
	}
}
