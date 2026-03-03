using System;
using UnityEngine;

namespace Modding.Delegates
{
	/// <summary>
	///     Called whenever nail strikes something
	/// </summary>
	/// <param name="otherCollider">What the nail is colliding with</param>
	/// <param name="slash">The NailSlash gameObject</param>
	// Token: 0x02000DDE RID: 3550
	// (Invoke) Token: 0x06004963 RID: 18787
	public delegate void SlashHitHandler(Collider2D otherCollider, GameObject slash);
}
