using System;
using HutongGames.PlayMaker;
using Language;

// Token: 0x020002CC RID: 716
[ActionCategory("Game Text")]
public class GetLanguageStringProcessed : FsmStateAction
{
	// Token: 0x06000F08 RID: 3848 RVA: 0x0004A044 File Offset: 0x00048244
	public override void Reset()
	{
		this.sheetName = null;
		this.convName = null;
		this.storeValue = null;
		this.fontSource = null;
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x0004A064 File Offset: 0x00048264
	public override void OnEnter()
	{
		this.storeValue.Value = Language.Get(this.convName.Value, this.sheetName.Value);
		this.storeValue.Value = this.storeValue.Value.Replace("<br>", "\n");
		this.storeValue.Value = this.storeValue.Value.GetProcessed((LocalisationHelper.FontSource)this.fontSource.Value);
		base.Finish();
	}

	// Token: 0x04000FCB RID: 4043
	[RequiredField]
	public FsmString sheetName;

	// Token: 0x04000FCC RID: 4044
	[RequiredField]
	public FsmString convName;

	// Token: 0x04000FCD RID: 4045
	[RequiredField]
	[UIHint(UIHint.Variable)]
	public FsmString storeValue;

	// Token: 0x04000FCE RID: 4046
	[ObjectType(typeof(LocalisationHelper.FontSource))]
	public FsmEnum fontSource;
}
