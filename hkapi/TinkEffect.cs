using System;
using UnityEngine;

// Token: 0x0200009B RID: 155
public class TinkEffect : MonoBehaviour
{
	// Token: 0x06000358 RID: 856 RVA: 0x00011D52 File Offset: 0x0000FF52
	private void Awake()
	{
		this.boxCollider = base.gameObject.GetComponent<BoxCollider2D>();
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00011D65 File Offset: 0x0000FF65
	private void Start()
	{
		this.gameCam = GameCameras.instance;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00011D74 File Offset: 0x0000FF74
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Nail Attack")
		{
			if (Time.time < this.nextTinkTime)
			{
				return;
			}
			this.nextTinkTime = Time.time + 0.25f;
			PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy");
			float degrees = (playMakerFSM != null) ? playMakerFSM.FsmVariables.FindFsmFloat("direction").Value : 0f;
			if (this.gameCam)
			{
				this.gameCam.cameraShakeFSM.SendEvent("EnemyKillShake");
			}
			Vector3 position = new Vector3(0f, 0f, 0f);
			Vector3 euler = new Vector3(0f, 0f, 0f);
			Vector3 position2 = HeroController.instance.transform.position;
			Vector3 position3 = collision.gameObject.transform.position;
			bool flag = this.boxCollider != null;
			if (this.useNailPosition)
			{
				flag = false;
			}
			Vector2 vector = Vector2.zero;
			float num = 0f;
			float num2 = 0f;
			if (flag)
			{
				vector = base.transform.TransformPoint(this.boxCollider.offset);
				num = this.boxCollider.bounds.size.x * 0.5f;
				num2 = this.boxCollider.bounds.size.y * 0.5f;
			}
			int cardinalDirection = DirectionUtils.GetCardinalDirection(degrees);
			if (cardinalDirection == 0)
			{
				HeroController.instance.RecoilLeft();
				if (this.sendDirectionalFSMEvents)
				{
					this.fsm.SendEvent("TINK RIGHT");
				}
				if (flag)
				{
					position = new Vector3(vector.x - num, position3.y, 0.002f);
				}
				else
				{
					position = new Vector3(position2.x + 2f, position2.y, 0.002f);
				}
			}
			else if (cardinalDirection == 1)
			{
				HeroController.instance.RecoilDown();
				if (this.sendDirectionalFSMEvents)
				{
					this.fsm.SendEvent("TINK UP");
				}
				if (flag)
				{
					position = new Vector3(position3.x, Mathf.Max(vector.y - num2, position3.y), 0.002f);
				}
				else
				{
					position = new Vector3(position2.x, position2.y + 2f, 0.002f);
				}
				euler = new Vector3(0f, 0f, 90f);
			}
			else if (cardinalDirection == 2)
			{
				HeroController.instance.RecoilRight();
				if (this.sendDirectionalFSMEvents)
				{
					this.fsm.SendEvent("TINK LEFT");
				}
				if (flag)
				{
					position = new Vector3(vector.x + num, position3.y, 0.002f);
				}
				else
				{
					position = new Vector3(position2.x - 2f, position2.y, 0.002f);
				}
				euler = new Vector3(0f, 0f, 180f);
			}
			else
			{
				if (this.sendDirectionalFSMEvents)
				{
					this.fsm.SendEvent("TINK DOWN");
				}
				if (flag)
				{
					position = new Vector3(position3.x, Mathf.Min(vector.y + num2, position3.y), 0.002f);
				}
				else
				{
					position = new Vector3(position2.x, position2.y - 2f, 0.002f);
				}
				euler = new Vector3(0f, 0f, 270f);
			}
			this.blockEffect.Spawn(position, Quaternion.Euler(euler)).GetComponent<AudioSource>().pitch = UnityEngine.Random.Range(0.85f, 1.15f);
			if (this.sendFSMEvent)
			{
				this.fsm.SendEvent(this.FSMEvent);
			}
		}
	}

	// Token: 0x040002B4 RID: 692
	public GameObject blockEffect;

	// Token: 0x040002B5 RID: 693
	public bool useNailPosition;

	// Token: 0x040002B6 RID: 694
	public bool sendFSMEvent;

	// Token: 0x040002B7 RID: 695
	public string FSMEvent;

	// Token: 0x040002B8 RID: 696
	public PlayMakerFSM fsm;

	// Token: 0x040002B9 RID: 697
	public bool sendDirectionalFSMEvents;

	// Token: 0x040002BA RID: 698
	private BoxCollider2D boxCollider;

	// Token: 0x040002BB RID: 699
	private bool hasBoxCollider;

	// Token: 0x040002BC RID: 700
	private HeroController heroController;

	// Token: 0x040002BD RID: 701
	private GameCameras gameCam;

	// Token: 0x040002BE RID: 702
	private Vector2 centre;

	// Token: 0x040002BF RID: 703
	private float halfWidth;

	// Token: 0x040002C0 RID: 704
	private float halfHeight;

	// Token: 0x040002C1 RID: 705
	private const float repeatDelay = 0.25f;

	// Token: 0x040002C2 RID: 706
	private float nextTinkTime;
}
