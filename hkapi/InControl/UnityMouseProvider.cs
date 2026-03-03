using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006FA RID: 1786
	public class UnityMouseProvider : IMouseProvider
	{
		// Token: 0x06002C0B RID: 11275 RVA: 0x000EDEE8 File Offset: 0x000EC0E8
		public void Setup()
		{
			this.ClearState();
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000EDEE8 File Offset: 0x000EC0E8
		public void Reset()
		{
			this.ClearState();
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000EDEF0 File Offset: 0x000EC0F0
		public void Update()
		{
			if (Input.mousePresent)
			{
				Array.Copy(this.buttonPressed, this.lastButtonPressed, this.buttonPressed.Length);
				this.buttonPressed[1] = UnityMouseProvider.SafeGetMouseButton(0);
				this.buttonPressed[2] = UnityMouseProvider.SafeGetMouseButton(1);
				this.buttonPressed[3] = UnityMouseProvider.SafeGetMouseButton(2);
				this.buttonPressed[10] = UnityMouseProvider.SafeGetMouseButton(3);
				this.buttonPressed[11] = UnityMouseProvider.SafeGetMouseButton(4);
				this.buttonPressed[12] = UnityMouseProvider.SafeGetMouseButton(5);
				this.buttonPressed[13] = UnityMouseProvider.SafeGetMouseButton(6);
				this.buttonPressed[14] = UnityMouseProvider.SafeGetMouseButton(7);
				this.buttonPressed[15] = UnityMouseProvider.SafeGetMouseButton(8);
				this.lastPosition = this.position;
				this.position = Input.mousePosition;
				this.delta = new Vector2(Input.GetAxisRaw("mouse x"), Input.GetAxisRaw("mouse y"));
				this.scroll = Input.mouseScrollDelta.y;
				return;
			}
			this.ClearState();
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000EDFF8 File Offset: 0x000EC1F8
		private static bool SafeGetMouseButton(int button)
		{
			try
			{
				return Input.GetMouseButton(button);
			}
			catch (ArgumentException)
			{
			}
			return false;
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000EE024 File Offset: 0x000EC224
		private void ClearState()
		{
			Array.Clear(this.lastButtonPressed, 0, this.lastButtonPressed.Length);
			Array.Clear(this.buttonPressed, 0, this.buttonPressed.Length);
			this.lastPosition = Vector2.zero;
			this.position = Vector2.zero;
			this.delta = Vector2.zero;
			this.scroll = 0f;
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000EE085 File Offset: 0x000EC285
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector2 GetPosition()
		{
			return this.position;
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000EE08D File Offset: 0x000EC28D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float GetDeltaX()
		{
			return this.delta.x;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000EE09A File Offset: 0x000EC29A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float GetDeltaY()
		{
			return this.delta.y;
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000EE0A7 File Offset: 0x000EC2A7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float GetDeltaScroll()
		{
			return this.scroll;
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000EE0AF File Offset: 0x000EC2AF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool GetButtonIsPressed(Mouse control)
		{
			return this.buttonPressed[(int)control];
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000EE0B9 File Offset: 0x000EC2B9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool GetButtonWasPressed(Mouse control)
		{
			return this.buttonPressed[(int)control] && !this.lastButtonPressed[(int)control];
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000EE0D2 File Offset: 0x000EC2D2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool GetButtonWasReleased(Mouse control)
		{
			return !this.buttonPressed[(int)control] && this.lastButtonPressed[(int)control];
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000EE0E8 File Offset: 0x000EC2E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool HasMousePresent()
		{
			return Input.mousePresent;
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000EE0EF File Offset: 0x000EC2EF
		public UnityMouseProvider()
		{
			this.lastButtonPressed = new bool[16];
			this.buttonPressed = new bool[16];
			base..ctor();
		}

		// Token: 0x04003196 RID: 12694
		private const string mouseXAxis = "mouse x";

		// Token: 0x04003197 RID: 12695
		private const string mouseYAxis = "mouse y";

		// Token: 0x04003198 RID: 12696
		private readonly bool[] lastButtonPressed;

		// Token: 0x04003199 RID: 12697
		private readonly bool[] buttonPressed;

		// Token: 0x0400319A RID: 12698
		private Vector2 lastPosition;

		// Token: 0x0400319B RID: 12699
		private Vector2 position;

		// Token: 0x0400319C RID: 12700
		private Vector2 delta;

		// Token: 0x0400319D RID: 12701
		private float scroll;
	}
}
