using System;
using UnityEngine;

// Token: 0x0200008E RID: 142
public abstract class SkippableSequence : MonoBehaviour
{
	// Token: 0x060002F5 RID: 757
	public abstract void Begin();

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060002F6 RID: 758
	public abstract bool IsPlaying { get; }

	// Token: 0x060002F7 RID: 759
	public abstract void Skip();

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060002F8 RID: 760
	public abstract bool IsSkipped { get; }

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060002F9 RID: 761
	// (set) Token: 0x060002FA RID: 762
	public abstract float FadeByController { get; set; }
}
