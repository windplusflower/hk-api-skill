using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006DA RID: 1754
	[Serializable]
	public struct InputControlSource
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000E8231 File Offset: 0x000E6431
		// (set) Token: 0x06002A19 RID: 10777 RVA: 0x000E8239 File Offset: 0x000E6439
		public InputControlSourceType SourceType
		{
			get
			{
				return this.sourceType;
			}
			set
			{
				this.sourceType = value;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002A1A RID: 10778 RVA: 0x000E8242 File Offset: 0x000E6442
		// (set) Token: 0x06002A1B RID: 10779 RVA: 0x000E824A File Offset: 0x000E644A
		public int Index
		{
			get
			{
				return this.index;
			}
			set
			{
				this.index = value;
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000E8253 File Offset: 0x000E6453
		public InputControlSource(InputControlSourceType sourceType, int index)
		{
			this.sourceType = sourceType;
			this.index = index;
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000E8263 File Offset: 0x000E6463
		public InputControlSource(KeyCode keyCode)
		{
			this = new InputControlSource(InputControlSourceType.KeyCode, (int)keyCode);
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000E8270 File Offset: 0x000E6470
		public float GetValue(InputDevice inputDevice)
		{
			switch (this.SourceType)
			{
			case InputControlSourceType.None:
				return 0f;
			case InputControlSourceType.Button:
				if (!this.GetState(inputDevice))
				{
					return 0f;
				}
				return 1f;
			case InputControlSourceType.Analog:
				return inputDevice.ReadRawAnalogValue(this.Index);
			case InputControlSourceType.KeyCode:
				if (!this.GetState(inputDevice))
				{
					return 0f;
				}
				return 1f;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000E82E0 File Offset: 0x000E64E0
		public bool GetState(InputDevice inputDevice)
		{
			switch (this.SourceType)
			{
			case InputControlSourceType.None:
				return false;
			case InputControlSourceType.Button:
				return inputDevice.ReadRawButtonState(this.Index);
			case InputControlSourceType.Analog:
				return Utility.IsNotZero(this.GetValue(inputDevice));
			case InputControlSourceType.KeyCode:
				return Input.GetKey((KeyCode)this.Index);
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x000E833C File Offset: 0x000E653C
		public string ToCode()
		{
			return string.Concat(new string[]
			{
				"new InputControlSource( InputControlSourceType.",
				this.SourceType.ToString(),
				", ",
				this.Index.ToString(),
				" )"
			});
		}

		// Token: 0x04002FEF RID: 12271
		[SerializeField]
		private InputControlSourceType sourceType;

		// Token: 0x04002FF0 RID: 12272
		[SerializeField]
		private int index;
	}
}
