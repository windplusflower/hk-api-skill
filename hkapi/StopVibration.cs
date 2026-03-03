using System;
using HutongGames.PlayMaker;

// Token: 0x0200050A RID: 1290
[ActionCategory("Hollow Knight")]
public class StopVibration : FsmStateAction
{
	// Token: 0x06001C6B RID: 7275 RVA: 0x00085ADA File Offset: 0x00083CDA
	public override void Reset()
	{
		base.Reset();
		this.fsmTag = new FsmString
		{
			UseVariable = true
		};
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x00085AF4 File Offset: 0x00083CF4
	public override void OnEnter()
	{
		base.OnEnter();
		if (this.fsmTag == null || this.fsmTag.IsNone || string.IsNullOrEmpty(this.fsmTag.Value))
		{
			VibrationManager.StopAllVibration();
		}
		else
		{
			VibrationMixer mixer = VibrationManager.GetMixer();
			if (mixer != null)
			{
				mixer.StopAllEmissionsWithTag(this.fsmTag.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04002212 RID: 8722
	private FsmString fsmTag;
}
