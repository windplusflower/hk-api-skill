using System;
using System.Collections;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x0200044E RID: 1102
public class DialogueBox : MonoBehaviour
{
	// Token: 0x060018B7 RID: 6327 RVA: 0x00073CA4 File Offset: 0x00071EA4
	private void Start()
	{
		this.textMesh = base.gameObject.GetComponent<TextMeshPro>();
		this.normalRevealSpeed = this.revealSpeed;
		this.HideText();
		this.proxyFSM = FSMUtility.LocateFSM(base.gameObject, "Dialogue Page Control");
		if (this.proxyFSM == null)
		{
			Debug.LogWarning("DialogueBox: Couldn't find an FSM on this GameObject to use as a proxy, events will not be fired from this dialogue box.");
		}
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00073D02 File Offset: 0x00071F02
	public void SetConversation(string convName, string sheetName)
	{
		this.currentConversation = convName;
		this.currentPage = 1;
		this.textMesh.text = Language.Get(convName, sheetName);
		this.textMesh.ForceMeshUpdate();
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00073D30 File Offset: 0x00071F30
	public void ShowPage(int pageNum)
	{
		if (pageNum < 1 || pageNum > this.textMesh.textInfo.pageCount)
		{
			this.SendConvEndEvent();
			return;
		}
		if (this.hidden)
		{
			this.hidden = false;
		}
		if (this.useTypeWriter)
		{
			if (this.typing)
			{
				this.StopTypewriter();
			}
			this.textMesh.pageToDisplay = pageNum;
			this.currentPage = pageNum;
			this.textMesh.maxVisibleCharacters = this.GetFirstCharIndexOnPage() - 1;
			string text = this.textMesh.text;
			text = text.Replace("<br>", "\n");
			this.textMesh.text = text;
			base.StartCoroutine("TypewriteCurrentPage");
			return;
		}
		this.textMesh.pageToDisplay = pageNum;
		this.currentPage = pageNum;
		this.textMesh.maxVisibleCharacters = this.GetLastCharIndexOnPage();
		this.SendEndEvent();
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00073E06 File Offset: 0x00072006
	public void ShowNextPage()
	{
		if (this.textMesh.pageToDisplay < this.textMesh.textInfo.pageCount)
		{
			this.ShowPage(this.currentPage + 1);
		}
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00073E33 File Offset: 0x00072033
	public void ShowPrevPage()
	{
		if (this.textMesh.pageToDisplay > 1)
		{
			this.ShowPage(this.currentPage - 1);
		}
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x00073E51 File Offset: 0x00072051
	public void HideText()
	{
		if (this.typing)
		{
			this.StopTypewriter();
		}
		this.textMesh.maxVisibleCharacters = 0;
		this.hidden = true;
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x00073E74 File Offset: 0x00072074
	public void StartConversation(string convName, string sheetName)
	{
		this.SetConversation(convName, sheetName);
		this.ShowPage(1);
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00073E85 File Offset: 0x00072085
	private IEnumerator TypewriteCurrentPage()
	{
		if (!this.typing)
		{
			this.InvokeRepeating("ShowNextChar", 0f, 1f / this.revealSpeed);
			this.typing = true;
		}
		while (this.typing)
		{
			if (this.textMesh.maxVisibleCharacters >= this.GetLastCharIndexOnPage())
			{
				this.StopTypewriter();
				this.SendEndEvent();
			}
			else
			{
				yield return null;
			}
		}
		yield break;
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00073E94 File Offset: 0x00072094
	private void ShowNextChar()
	{
		TextMeshPro textMeshPro = this.textMesh;
		int maxVisibleCharacters = textMeshPro.maxVisibleCharacters;
		textMeshPro.maxVisibleCharacters = maxVisibleCharacters + 1;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00073EB6 File Offset: 0x000720B6
	private void StopTypewriter()
	{
		base.CancelInvoke("ShowNextChar");
		this.typing = false;
		this.fastTyping = false;
		this.revealSpeed = this.normalRevealSpeed;
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00073EE0 File Offset: 0x000720E0
	public void SpeedupTypewriter()
	{
		if (this.typing && !this.fastTyping)
		{
			this.StopTypewriter();
			this.normalRevealSpeed = this.revealSpeed;
			this.revealSpeed = 200f;
			this.fastTyping = true;
			base.StartCoroutine(this.TypewriteCurrentPage());
		}
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00073F2E File Offset: 0x0007212E
	private void RestoreTypewriter()
	{
		this.revealSpeed = this.normalRevealSpeed;
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00073F3C File Offset: 0x0007213C
	private void SendEndEvent()
	{
		if (this.currentPage == this.textMesh.textInfo.pageCount)
		{
			this.SendConvEndEvent();
			return;
		}
		this.SendPageEndEvent();
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00073F63 File Offset: 0x00072163
	private void SendPageEndEvent()
	{
		if (this.proxyFSM != null)
		{
			this.proxyFSM.SendEvent("PAGE_END");
		}
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00073F83 File Offset: 0x00072183
	private void SendConvEndEvent()
	{
		if (this.proxyFSM != null)
		{
			this.proxyFSM.SendEvent("CONVERSATION_END");
		}
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00073FA3 File Offset: 0x000721A3
	private int GetFirstCharIndexOnPage()
	{
		return this.textMesh.textInfo.pageInfo[this.currentPage - 1].firstCharacterIndex + 1;
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00073FC9 File Offset: 0x000721C9
	private int GetLastCharIndexOnPage()
	{
		return this.textMesh.textInfo.pageInfo[this.currentPage - 1].lastCharacterIndex + 1;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00073FEF File Offset: 0x000721EF
	public void PrintPageInfo()
	{
		Debug.LogFormat("PageInfo: Current Page: {0} Start: {1} End {2}", new object[]
		{
			this.currentPage,
			this.GetFirstCharIndexOnPage(),
			this.GetLastCharIndexOnPage()
		});
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x0007402C File Offset: 0x0007222C
	public void PrintPageInfoAll()
	{
		Debug.LogFormat("PageInfo: Current conversation {0} contains {1} pages.\n", new object[]
		{
			this.currentConversation,
			this.textMesh.textInfo.pageCount
		});
		for (int i = 0; i < this.textMesh.textInfo.pageCount; i++)
		{
			Debug.LogFormat("[Page {0}] Start/End: {1}/{2}\n", new object[]
			{
				i + 1,
				this.textMesh.textInfo.pageInfo[i].firstCharacterIndex,
				this.textMesh.textInfo.pageInfo[i].lastCharacterIndex
			});
		}
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x000740E6 File Offset: 0x000722E6
	public void PrintCurrentConversation()
	{
		Debug.LogFormat("Current conversation set to {0}\nClick this message to see the dialogue for this conversation.\n{1}", new object[]
		{
			this.currentConversation,
			this.textMesh.text
		});
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x0007410F File Offset: 0x0007230F
	public DialogueBox()
	{
		this.revealSpeed = 20f;
		base..ctor();
	}

	// Token: 0x04001DB3 RID: 7603
	[Header("Conversation Info")]
	public string currentConversation;

	// Token: 0x04001DB4 RID: 7604
	public int currentPage;

	// Token: 0x04001DB5 RID: 7605
	[Header("Typewriter")]
	[Tooltip("Enables the typewriter effect.")]
	public bool useTypeWriter;

	// Token: 0x04001DB6 RID: 7606
	[Range(1f, 100f)]
	public float revealSpeed;

	// Token: 0x04001DB7 RID: 7607
	private float normalRevealSpeed;

	// Token: 0x04001DB8 RID: 7608
	private TextMeshPro textMesh;

	// Token: 0x04001DB9 RID: 7609
	private PlayMakerFSM proxyFSM;

	// Token: 0x04001DBA RID: 7610
	private bool typing;

	// Token: 0x04001DBB RID: 7611
	private bool fastTyping;

	// Token: 0x04001DBC RID: 7612
	private bool hidden;

	// Token: 0x04001DBD RID: 7613
	private TMP_PageInfo[] pageInfo;
}
