using System;
using UnityEngine;

// Token: 0x020003D6 RID: 982
public class LiftPlatform : MonoBehaviour
{
	// Token: 0x06001680 RID: 5760 RVA: 0x0006A7B3 File Offset: 0x000689B3
	private void Start()
	{
		this.part1_start_y = this.part1.transform.position.y;
		this.part2_start_y = this.part2.transform.position.y;
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0006A7EC File Offset: 0x000689EC
	private void Update()
	{
		if (this.state == 1)
		{
			if (this.timer < 0.12f)
			{
				this.part1.transform.position = new Vector3(this.part1.transform.position.x, this.part1_start_y - this.timer * 0.75f, this.part1.transform.position.z);
				this.part2.transform.position = new Vector3(this.part2.transform.position.x, this.part2_start_y - this.timer * 0.75f, this.part2.transform.position.z);
				this.timer += Time.deltaTime;
			}
			else
			{
				this.part1.transform.position = new Vector3(this.part1.transform.position.x, this.part1_start_y - 0.09f, this.part1.transform.position.z);
				this.part2.transform.position = new Vector3(this.part2.transform.position.x, this.part2_start_y - 0.09f, this.part2.transform.position.z);
				this.state = 2;
				this.timer = 0.12f;
			}
		}
		if (this.state == 2)
		{
			if (this.timer > 0f)
			{
				this.part1.transform.position = new Vector3(this.part1.transform.position.x, this.part1_start_y - this.timer * 0.75f, this.part1.transform.position.z);
				this.part2.transform.position = new Vector3(this.part2.transform.position.x, this.part2_start_y - this.timer * 0.75f, this.part2.transform.position.z);
				this.timer -= Time.deltaTime;
				return;
			}
			this.part1.transform.position = new Vector3(this.part1.transform.position.x, this.part1_start_y, this.part1.transform.position.z);
			this.part2.transform.position = new Vector3(this.part2.transform.position.x, this.part2_start_y, this.part2.transform.position.z);
			this.state = 0;
		}
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0006AADC File Offset: 0x00068CDC
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.state == 0 && collision.collider.gameObject.layer != 16 && collision.collider.gameObject.layer != 18 && collision.GetSafeContact().Normal.y < 0.1f)
		{
			this.audioSource.pitch = UnityEngine.Random.Range(0.85f, 1.15f);
			this.audioSource.Play();
			this.dustParticle.Play();
			this.state = 1;
			this.timer = 0f;
		}
	}

	// Token: 0x04001B12 RID: 6930
	public GameObject part1;

	// Token: 0x04001B13 RID: 6931
	public GameObject part2;

	// Token: 0x04001B14 RID: 6932
	public ParticleSystem dustParticle;

	// Token: 0x04001B15 RID: 6933
	public AudioSource audioSource;

	// Token: 0x04001B16 RID: 6934
	private float part1_start_y;

	// Token: 0x04001B17 RID: 6935
	private float part2_start_y;

	// Token: 0x04001B18 RID: 6936
	private int state;

	// Token: 0x04001B19 RID: 6937
	private float timer;
}
