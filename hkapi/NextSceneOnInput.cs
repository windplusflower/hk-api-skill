using System;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200007C RID: 124
public class NextSceneOnInput : MonoBehaviour
{
	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000F017 File Offset: 0x0000D217
	public bool AcceptingInput
	{
		get
		{
			return this.acceptingInput || Time.time >= this.inputAcceptTime;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060002AA RID: 682 RVA: 0x0000F033 File Offset: 0x0000D233
	private bool ButtonPressed
	{
		get
		{
			return (InputHandler.Instance && InputHandler.Instance.inputActions.ActiveDevice.AnyButtonIsPressed) || Input.anyKeyDown;
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000F05E File Offset: 0x0000D25E
	private void Start()
	{
		this.inputAcceptTime = Time.time + this.maxInputBlockDelay;
		this.onBeforeSave.Invoke();
		if (this.doSaveOnStart)
		{
			GameManager.instance.SaveGame();
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000F08F File Offset: 0x0000D28F
	public void UnlockSkip()
	{
		this.acceptingInput = true;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000F098 File Offset: 0x0000D298
	private void Update()
	{
		if (!this.hasSkipped && this.AcceptingInput && this.ButtonPressed)
		{
			this.Skip();
			this.hasSkipped = true;
		}
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
	private void Skip()
	{
		if (this.nextSceneType == NextSceneOnInput.NextSceneType.GGReturn)
		{
			GameManager.instance.BeginSceneTransition(new GameManager.SceneLoadInfo
			{
				SceneName = "GG_Atrium",
				EntryGateName = GameManager.instance.playerData.GetString("bossReturnEntryGate"),
				EntryDelay = 0f,
				Visualization = GameManager.SceneLoadVisualizations.GodsAndGlory,
				PreventCameraFadeOut = false,
				WaitForSceneTransitionCameraFade = true
			});
			return;
		}
		Debug.LogError("Next Scene Type \"{0}\" not implemented!");
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000F134 File Offset: 0x0000D334
	public NextSceneOnInput()
	{
		this.doSaveOnStart = true;
		this.maxInputBlockDelay = 10f;
		base..ctor();
	}

	// Token: 0x04000234 RID: 564
	[SerializeField]
	private UnityEvent onBeforeSave;

	// Token: 0x04000235 RID: 565
	[SerializeField]
	private bool doSaveOnStart;

	// Token: 0x04000236 RID: 566
	[Space]
	[SerializeField]
	private bool acceptingInput;

	// Token: 0x04000237 RID: 567
	[SerializeField]
	private float maxInputBlockDelay;

	// Token: 0x04000238 RID: 568
	private float inputAcceptTime;

	// Token: 0x04000239 RID: 569
	private bool hasSkipped;

	// Token: 0x0400023A RID: 570
	[Space]
	[SerializeField]
	private NextSceneOnInput.NextSceneType nextSceneType;

	// Token: 0x0200007D RID: 125
	private enum NextSceneType
	{
		// Token: 0x0400023C RID: 572
		GGReturn
	}
}
