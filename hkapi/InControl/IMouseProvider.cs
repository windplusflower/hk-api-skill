using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006F9 RID: 1785
	public interface IMouseProvider
	{
		// Token: 0x06002C00 RID: 11264
		void Setup();

		// Token: 0x06002C01 RID: 11265
		void Reset();

		// Token: 0x06002C02 RID: 11266
		void Update();

		// Token: 0x06002C03 RID: 11267
		Vector2 GetPosition();

		// Token: 0x06002C04 RID: 11268
		float GetDeltaX();

		// Token: 0x06002C05 RID: 11269
		float GetDeltaY();

		// Token: 0x06002C06 RID: 11270
		float GetDeltaScroll();

		// Token: 0x06002C07 RID: 11271
		bool GetButtonIsPressed(Mouse control);

		// Token: 0x06002C08 RID: 11272
		bool GetButtonWasPressed(Mouse control);

		// Token: 0x06002C09 RID: 11273
		bool GetButtonWasReleased(Mouse control);

		// Token: 0x06002C0A RID: 11274
		bool HasMousePresent();
	}
}
