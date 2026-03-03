using System;
using UnityEngine;

// Token: 0x020001C5 RID: 453
public class Recoil : MonoBehaviour
{
	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0003733C File Offset: 0x0003553C
	// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00037344 File Offset: 0x00035544
	public bool SkipFreezingByController
	{
		get
		{
			return this.skipFreezingByController;
		}
		set
		{
			this.skipFreezingByController = value;
		}
	}

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000A02 RID: 2562 RVA: 0x00037350 File Offset: 0x00035550
	// (remove) Token: 0x06000A03 RID: 2563 RVA: 0x00037388 File Offset: 0x00035588
	public event Recoil.FreezeEvent OnHandleFreeze;

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x06000A04 RID: 2564 RVA: 0x000373C0 File Offset: 0x000355C0
	// (remove) Token: 0x06000A05 RID: 2565 RVA: 0x000373F8 File Offset: 0x000355F8
	public event Recoil.CancelRecoilEvent OnCancelRecoil;

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0003742D File Offset: 0x0003562D
	public bool IsRecoiling
	{
		get
		{
			return this.state == Recoil.States.Recoiling || this.state == Recoil.States.Frozen;
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00037443 File Offset: 0x00035643
	protected void Reset()
	{
		this.freezeInPlace = false;
		this.stopVelocityXWhenRecoilingUp = true;
		this.recoilDuration = 0.5f;
		this.recoilSpeedBase = 15f;
		this.preventRecoilUp = false;
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00037470 File Offset: 0x00035670
	protected void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.bodyCollider = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x0003748A File Offset: 0x0003568A
	private void OnEnable()
	{
		this.CancelRecoil();
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00037494 File Offset: 0x00035694
	public void RecoilByHealthManagerFSMParameters()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "health_manager_enemy");
		int cardinalDirection = DirectionUtils.GetCardinalDirection(playMakerFSM.FsmVariables.GetFsmFloat("Attack Direction").Value);
		int value = playMakerFSM.FsmVariables.GetFsmInt("Attack Type").Value;
		float value2 = playMakerFSM.FsmVariables.GetFsmFloat("Attack Magnitude").Value;
		this.RecoilByDirection(cardinalDirection, value2);
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00037500 File Offset: 0x00035700
	public void RecoilByDamage(HitInstance damageInstance)
	{
		int cardinalDirection = DirectionUtils.GetCardinalDirection(damageInstance.Direction);
		this.RecoilByDirection(cardinalDirection, damageInstance.MagnitudeMultiplier);
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x00037528 File Offset: 0x00035728
	public void RecoilByDirection(int attackDirection, float attackMagnitude)
	{
		if (this.state != Recoil.States.Ready)
		{
			return;
		}
		if (this.freezeInPlace)
		{
			this.Freeze();
			return;
		}
		if (attackDirection == 1 && this.preventRecoilUp)
		{
			return;
		}
		if (this.bodyCollider == null)
		{
			this.bodyCollider = base.GetComponent<Collider2D>();
		}
		this.state = Recoil.States.Recoiling;
		this.recoilSpeed = this.recoilSpeedBase * attackMagnitude;
		this.recoilSweep = new Sweep(this.bodyCollider, attackDirection, 3, 0.1f);
		this.isRecoilSweeping = true;
		this.recoilTimeRemaining = this.recoilDuration;
		switch (attackDirection)
		{
		case 0:
			FSMUtility.SendEventToGameObject(base.gameObject, "RECOIL HORIZONTAL", false);
			FSMUtility.SendEventToGameObject(base.gameObject, "HIT RIGHT", false);
			break;
		case 1:
			FSMUtility.SendEventToGameObject(base.gameObject, "HIT UP", false);
			break;
		case 2:
			FSMUtility.SendEventToGameObject(base.gameObject, "RECOIL HORIZONTAL", false);
			FSMUtility.SendEventToGameObject(base.gameObject, "HIT LEFT", false);
			break;
		case 3:
			FSMUtility.SendEventToGameObject(base.gameObject, "HIT DOWN", false);
			break;
		}
		this.UpdatePhysics(0f);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00037643 File Offset: 0x00035843
	public void CancelRecoil()
	{
		if (this.state != Recoil.States.Ready)
		{
			this.state = Recoil.States.Ready;
			if (this.OnCancelRecoil != null)
			{
				this.OnCancelRecoil();
			}
		}
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00037668 File Offset: 0x00035868
	private void Freeze()
	{
		if (this.skipFreezingByController)
		{
			if (this.OnHandleFreeze != null)
			{
				this.OnHandleFreeze();
			}
			this.state = Recoil.States.Ready;
			return;
		}
		this.state = Recoil.States.Frozen;
		if (this.body != null)
		{
			this.body.velocity = Vector2.zero;
		}
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "Climber Control");
		if (playMakerFSM != null)
		{
			playMakerFSM.SendEvent("FREEZE IN PLACE");
		}
		this.recoilTimeRemaining = this.recoilDuration;
		this.UpdatePhysics(0f);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x000376F9 File Offset: 0x000358F9
	protected void FixedUpdate()
	{
		this.UpdatePhysics(Time.fixedDeltaTime);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x00037708 File Offset: 0x00035908
	private void UpdatePhysics(float deltaTime)
	{
		if (this.state == Recoil.States.Frozen)
		{
			if (this.body != null)
			{
				this.body.velocity = Vector2.zero;
			}
			this.recoilTimeRemaining -= deltaTime;
			if (this.recoilTimeRemaining <= 0f)
			{
				this.CancelRecoil();
				return;
			}
		}
		else if (this.state == Recoil.States.Recoiling)
		{
			if (this.isRecoilSweeping)
			{
				float num;
				if (this.recoilSweep.Check(base.transform.position, this.recoilSpeed * deltaTime, 256, out num))
				{
					this.isRecoilSweeping = false;
				}
				if (num > Mathf.Epsilon)
				{
					base.transform.Translate(this.recoilSweep.Direction * num, Space.World);
				}
			}
			this.recoilTimeRemaining -= deltaTime;
			if (this.recoilTimeRemaining <= 0f)
			{
				this.CancelRecoil();
			}
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x000377F3 File Offset: 0x000359F3
	public void SetRecoilSpeed(float newSpeed)
	{
		this.recoilSpeedBase = newSpeed;
	}

	// Token: 0x04000B1F RID: 2847
	private Rigidbody2D body;

	// Token: 0x04000B20 RID: 2848
	private Collider2D bodyCollider;

	// Token: 0x04000B21 RID: 2849
	[SerializeField]
	public bool freezeInPlace;

	// Token: 0x04000B22 RID: 2850
	[SerializeField]
	private bool stopVelocityXWhenRecoilingUp;

	// Token: 0x04000B23 RID: 2851
	[SerializeField]
	private bool preventRecoilUp;

	// Token: 0x04000B24 RID: 2852
	[SerializeField]
	private float recoilSpeedBase;

	// Token: 0x04000B25 RID: 2853
	[SerializeField]
	private float recoilDuration;

	// Token: 0x04000B26 RID: 2854
	private bool skipFreezingByController;

	// Token: 0x04000B29 RID: 2857
	private Recoil.States state;

	// Token: 0x04000B2A RID: 2858
	private float recoilTimeRemaining;

	// Token: 0x04000B2B RID: 2859
	private float recoilSpeed;

	// Token: 0x04000B2C RID: 2860
	private Sweep recoilSweep;

	// Token: 0x04000B2D RID: 2861
	private bool isRecoilSweeping;

	// Token: 0x04000B2E RID: 2862
	private const int SweepLayerMask = 256;

	// Token: 0x020001C6 RID: 454
	// (Invoke) Token: 0x06000A14 RID: 2580
	public delegate void FreezeEvent();

	// Token: 0x020001C7 RID: 455
	// (Invoke) Token: 0x06000A18 RID: 2584
	public delegate void CancelRecoilEvent();

	// Token: 0x020001C8 RID: 456
	private enum States
	{
		// Token: 0x04000B30 RID: 2864
		Ready,
		// Token: 0x04000B31 RID: 2865
		Frozen,
		// Token: 0x04000B32 RID: 2866
		Recoiling
	}
}
