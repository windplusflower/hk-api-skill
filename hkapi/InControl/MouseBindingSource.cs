using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006C8 RID: 1736
	public class MouseBindingSource : BindingSource
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000E5904 File Offset: 0x000E3B04
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x000E590C File Offset: 0x000E3B0C
		public Mouse Control { get; protected set; }

		// Token: 0x06002926 RID: 10534 RVA: 0x000E5205 File Offset: 0x000E3405
		internal MouseBindingSource()
		{
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000E5915 File Offset: 0x000E3B15
		public MouseBindingSource(Mouse mouseControl)
		{
			this.Control = mouseControl;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000E5924 File Offset: 0x000E3B24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool ButtonIsPressed(Mouse control)
		{
			return InputManager.MouseProvider.GetButtonIsPressed(control);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000E5931 File Offset: 0x000E3B31
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool NegativeScrollWheelIsActive(float threshold)
		{
			return Mathf.Min(InputManager.MouseProvider.GetDeltaScroll() * MouseBindingSource.ScaleZ, 0f) < -threshold;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000E5951 File Offset: 0x000E3B51
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool PositiveScrollWheelIsActive(float threshold)
		{
			return Mathf.Max(0f, InputManager.MouseProvider.GetDeltaScroll() * MouseBindingSource.ScaleZ) > threshold;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000E5970 File Offset: 0x000E3B70
		internal static float GetValue(Mouse mouseControl)
		{
			switch (mouseControl)
			{
			case Mouse.None:
				return 0f;
			case Mouse.NegativeX:
				return -Mathf.Min(InputManager.MouseProvider.GetDeltaX() * MouseBindingSource.ScaleX, 0f);
			case Mouse.PositiveX:
				return Mathf.Max(0f, InputManager.MouseProvider.GetDeltaX() * MouseBindingSource.ScaleX);
			case Mouse.NegativeY:
				return -Mathf.Min(InputManager.MouseProvider.GetDeltaY() * MouseBindingSource.ScaleY, 0f);
			case Mouse.PositiveY:
				return Mathf.Max(0f, InputManager.MouseProvider.GetDeltaY() * MouseBindingSource.ScaleY);
			case Mouse.PositiveScrollWheel:
				return Mathf.Max(0f, InputManager.MouseProvider.GetDeltaScroll() * MouseBindingSource.ScaleZ);
			case Mouse.NegativeScrollWheel:
				return -Mathf.Min(InputManager.MouseProvider.GetDeltaScroll() * MouseBindingSource.ScaleZ, 0f);
			}
			if (!InputManager.MouseProvider.GetButtonIsPressed(mouseControl))
			{
				return 0f;
			}
			return 1f;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000E5A73 File Offset: 0x000E3C73
		public override float GetValue(InputDevice inputDevice)
		{
			return MouseBindingSource.GetValue(this.Control);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000E5A80 File Offset: 0x000E3C80
		public override bool GetState(InputDevice inputDevice)
		{
			return Utility.IsNotZero(this.GetValue(inputDevice));
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000E5A90 File Offset: 0x000E3C90
		public override string Name
		{
			get
			{
				return this.Control.ToString();
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x000E5AB1 File Offset: 0x000E3CB1
		public override string DeviceName
		{
			get
			{
				return "Mouse";
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00058FB1 File Offset: 0x000571B1
		public override InputDeviceClass DeviceClass
		{
			get
			{
				return InputDeviceClass.Mouse;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x0000D742 File Offset: 0x0000B942
		public override InputDeviceStyle DeviceStyle
		{
			get
			{
				return InputDeviceStyle.Unknown;
			}
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000E5AB8 File Offset: 0x000E3CB8
		public override bool Equals(BindingSource other)
		{
			if (other == null)
			{
				return false;
			}
			MouseBindingSource mouseBindingSource = other as MouseBindingSource;
			return mouseBindingSource != null && this.Control == mouseBindingSource.Control;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000E5AF0 File Offset: 0x000E3CF0
		public override bool Equals(object other)
		{
			if (other == null)
			{
				return false;
			}
			MouseBindingSource mouseBindingSource = other as MouseBindingSource;
			return mouseBindingSource != null && this.Control == mouseBindingSource.Control;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000E5B24 File Offset: 0x000E3D24
		public override int GetHashCode()
		{
			return this.Control.GetHashCode();
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x00059F92 File Offset: 0x00058192
		public override BindingSourceType BindingSourceType
		{
			get
			{
				return BindingSourceType.MouseBindingSource;
			}
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000E5B45 File Offset: 0x000E3D45
		public override void Save(BinaryWriter writer)
		{
			writer.Write((int)this.Control);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000E5B53 File Offset: 0x000E3D53
		public override void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.Control = (Mouse)reader.ReadInt32();
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000E5B61 File Offset: 0x000E3D61
		// Note: this type is marked as 'beforefieldinit'.
		static MouseBindingSource()
		{
			MouseBindingSource.ScaleX = 0.05f;
			MouseBindingSource.ScaleY = 0.05f;
			MouseBindingSource.ScaleZ = 0.05f;
			MouseBindingSource.JitterThreshold = 0.05f;
		}

		// Token: 0x04002F75 RID: 12149
		public static float ScaleX;

		// Token: 0x04002F76 RID: 12150
		public static float ScaleY;

		// Token: 0x04002F77 RID: 12151
		public static float ScaleZ;

		// Token: 0x04002F78 RID: 12152
		public static float JitterThreshold;
	}
}
