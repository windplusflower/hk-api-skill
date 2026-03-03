using System;
using System.Reflection;
using UnityEngine;

// Token: 0x02000218 RID: 536
public class BossDoorCompletionStates : MonoBehaviour
{
	// Token: 0x06000B8B RID: 2955 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
	private void Start()
	{
		this.completedIndex = 0;
		foreach (FieldInfo fieldInfo in typeof(PlayerData).GetFields())
		{
			if (fieldInfo.FieldType == typeof(BossSequenceDoor.Completion) && ((BossSequenceDoor.Completion)fieldInfo.GetValue(GameManager.instance.playerData)).completed)
			{
				this.completedIndex++;
			}
		}
		if (!string.IsNullOrEmpty(this.stateSeenPlayerData))
		{
			int num = GameManager.instance.GetPlayerDataInt(this.stateSeenPlayerData) + 1;
			if (this.completedIndex > num)
			{
				this.completedIndex = num;
			}
		}
		if (this.completedIndex >= this.completionStates.Length)
		{
			this.completedIndex = this.completionStates.Length - 1;
		}
		for (int j = 0; j < this.completionStates.Length; j++)
		{
			if (this.completionStates[j].stateObject)
			{
				this.completionStates[j].stateObject.SetActive(false);
			}
		}
		BossDoorCompletionStates.CompletionState completionState = this.completionStates[this.completedIndex];
		if (completionState.stateObject)
		{
			completionState.stateObject.SetActive(true);
			if (!string.IsNullOrEmpty(completionState.sendEvent))
			{
				FSMUtility.SendEventToGameObject(completionState.stateObject, completionState.sendEvent, false);
			}
		}
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0003CE34 File Offset: 0x0003B034
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!string.IsNullOrEmpty(this.stateSeenPlayerData))
		{
			GameManager.instance.SetPlayerDataInt(this.stateSeenPlayerData, this.completedIndex);
		}
	}

	// Token: 0x04000C7B RID: 3195
	public BossDoorCompletionStates.CompletionState[] completionStates;

	// Token: 0x04000C7C RID: 3196
	[Space]
	[Tooltip("OPTIONAL - using an int, will ensure each state is seen at least once. (Requires a 2D trigger on this GameObject)")]
	public string stateSeenPlayerData;

	// Token: 0x04000C7D RID: 3197
	private int completedIndex;

	// Token: 0x02000219 RID: 537
	[Serializable]
	public class CompletionState
	{
		// Token: 0x04000C7E RID: 3198
		public GameObject stateObject;

		// Token: 0x04000C7F RID: 3199
		public string sendEvent;
	}
}
