using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called when an enemy dies and a journal kill is recorded. You may use the "playerDataName" string or one of the
	///     additional pre-formatted player data strings to look up values in playerData.
	/// </summary>
	// Token: 0x02000DE2 RID: 3554
	// (Invoke) Token: 0x06004973 RID: 18803
	public delegate void RecordKillForJournalHandler(EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey);
}
