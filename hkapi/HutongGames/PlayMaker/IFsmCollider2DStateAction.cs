using System;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	// Token: 0x020008BF RID: 2239
	public interface IFsmCollider2DStateAction
	{
		// Token: 0x060031E4 RID: 12772
		void DoCollisionEnter2D(Collision2D collisionInfo);

		// Token: 0x060031E5 RID: 12773
		void DoCollisionExit2D(Collision2D collisionInfo);

		// Token: 0x060031E6 RID: 12774
		void DoCollisionStay2D(Collision2D collisionInfo);
	}
}
