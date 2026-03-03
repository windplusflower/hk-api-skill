using System;
using UnityEngine;

// Token: 0x02000428 RID: 1064
public class TriggerEnterSendMessage : MonoBehaviour
{
	// Token: 0x06001800 RID: 6144 RVA: 0x00070EBC File Offset: 0x0006F0BC
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Acid trigger entered");
		collision.gameObject.SendMessage(this.message, this.options);
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00070EDF File Offset: 0x0006F0DF
	public TriggerEnterSendMessage()
	{
		this.message = "Acid";
		this.options = SendMessageOptions.DontRequireReceiver;
		base..ctor();
	}

	// Token: 0x04001CC5 RID: 7365
	public string message;

	// Token: 0x04001CC6 RID: 7366
	public SendMessageOptions options;
}
