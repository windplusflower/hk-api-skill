using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000155 RID: 341
public class Climber : MonoBehaviour
{
	// Token: 0x060007EE RID: 2030 RVA: 0x0002C89E File Offset: 0x0002AA9E
	private void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.col = base.GetComponent<BoxCollider2D>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
	private void Start()
	{
		this.StickToGround();
		float num = Mathf.Sign(base.transform.localScale.x);
		if (!this.startRight)
		{
			num *= -1f;
		}
		this.clockwise = (num > 0f);
		float num2 = base.transform.eulerAngles.z % 360f;
		if (num2 >= 45f && num2 <= 135f)
		{
			this.currentDirection = (this.clockwise ? Climber.Direction.Up : Climber.Direction.Down);
		}
		else if (num2 >= 135f && num2 <= 225f)
		{
			this.currentDirection = (this.clockwise ? Climber.Direction.Left : Climber.Direction.Right);
		}
		else if (num2 >= 225f && num2 <= 315f)
		{
			this.currentDirection = (this.clockwise ? Climber.Direction.Down : Climber.Direction.Up);
		}
		else
		{
			this.currentDirection = (this.clockwise ? Climber.Direction.Right : Climber.Direction.Left);
		}
		Recoil component = base.GetComponent<Recoil>();
		if (component)
		{
			component.SkipFreezingByController = true;
			component.OnHandleFreeze += this.Stun;
		}
		this.previousPos = base.transform.position;
		base.StartCoroutine(this.Walk());
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x0002C9EB File Offset: 0x0002ABEB
	private IEnumerator Walk()
	{
		this.anim.Play("Walk");
		this.body.velocity = this.GetVelocity(this.currentDirection);
		for (;;)
		{
			Vector2 vector = this.transform.position;
			bool flag = false;
			if (Mathf.Abs(vector.x - this.previousPos.x) > this.constrain.x)
			{
				vector.x = this.previousPos.x;
				flag = true;
			}
			if (Mathf.Abs(vector.y - this.previousPos.y) > this.constrain.y)
			{
				vector.y = this.previousPos.y;
				flag = true;
			}
			if (flag)
			{
				this.transform.position = vector;
			}
			else
			{
				this.previousPos = this.transform.position;
			}
			if (Vector3.Distance(this.previousTurnPos, this.transform.position) >= this.minTurnDistance)
			{
				if (!this.CheckGround())
				{
					this.turnRoutine = this.StartCoroutine(this.Turn(this.clockwise, false));
					yield return this.turnRoutine;
				}
				else if (this.CheckWall())
				{
					this.turnRoutine = this.StartCoroutine(this.Turn(!this.clockwise, true));
					yield return this.turnRoutine;
				}
			}
			yield return null;
		}
		yield break;
	}

	// Token: 0x060007F1 RID: 2033 RVA: 0x0002C9FA File Offset: 0x0002ABFA
	private IEnumerator Turn(bool turnClockwise, bool tweenPos = false)
	{
		this.body.velocity = Vector2.zero;
		float currentRotation = this.transform.eulerAngles.z;
		float targetRotation = currentRotation + (float)(turnClockwise ? -90 : 90);
		Vector3 currentPos = this.transform.position;
		Vector3 targetPos = currentPos + this.GetTweenPos(this.currentDirection);
		for (float elapsed = 0f; elapsed < this.spinTime; elapsed += Time.deltaTime)
		{
			float t = elapsed / this.spinTime;
			this.transform.SetRotation2D(Mathf.Lerp(currentRotation, targetRotation, t));
			if (tweenPos)
			{
				this.transform.position = Vector3.Lerp(currentPos, targetPos, t);
			}
			yield return null;
		}
		this.transform.SetRotation2D(targetRotation);
		int num = (int)this.currentDirection;
		num += (turnClockwise ? 1 : -1);
		int num2 = Enum.GetNames(typeof(Climber.Direction)).Length;
		if (num < 0)
		{
			num = num2 - 1;
		}
		else if (num >= num2)
		{
			num = 0;
		}
		this.currentDirection = (Climber.Direction)num;
		this.body.velocity = this.GetVelocity(this.currentDirection);
		this.previousPos = this.transform.position;
		this.previousTurnPos = this.previousPos;
		this.turnRoutine = null;
		yield break;
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x0002CA18 File Offset: 0x0002AC18
	private Vector2 GetVelocity(Climber.Direction direction)
	{
		Vector2 zero = Vector2.zero;
		switch (direction)
		{
		case Climber.Direction.Right:
			zero = new Vector2(this.speed, 0f);
			break;
		case Climber.Direction.Down:
			zero = new Vector2(0f, -this.speed);
			break;
		case Climber.Direction.Left:
			zero = new Vector2(-this.speed, 0f);
			break;
		case Climber.Direction.Up:
			zero = new Vector2(0f, this.speed);
			break;
		}
		return zero;
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x0002CA94 File Offset: 0x0002AC94
	private bool CheckGround()
	{
		return this.FireRayLocal(Vector2.down, 1f).collider != null;
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
	private bool CheckWall()
	{
		return this.FireRayLocal(this.clockwise ? Vector2.right : Vector2.left, this.col.size.x / 2f + this.wallRayPadding).collider != null;
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x0002CB12 File Offset: 0x0002AD12
	public void Stun()
	{
		if (this.turnRoutine == null)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.DoStun());
		}
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x0002CB2F File Offset: 0x0002AD2F
	private IEnumerator DoStun()
	{
		this.body.velocity = Vector2.zero;
		yield return this.StartCoroutine(this.anim.PlayAnimWait("Stun"));
		this.StartCoroutine(this.Walk());
		yield break;
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x0002CB40 File Offset: 0x0002AD40
	private RaycastHit2D FireRayLocal(Vector2 direction, float length)
	{
		Vector2 vector = base.transform.TransformPoint(this.col.offset);
		Vector2 vector2 = base.transform.TransformDirection(direction);
		RaycastHit2D result = Physics2D.Raycast(vector, vector2, length, 256);
		Debug.DrawRay(vector, vector2);
		return result;
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x0002CBA4 File Offset: 0x0002ADA4
	private Vector2 GetTweenPos(Climber.Direction direction)
	{
		Vector2 result = Vector2.zero;
		switch (direction)
		{
		case Climber.Direction.Right:
			result = (this.clockwise ? new Vector2(this.col.size.x / 2f, this.col.size.y / 2f) : new Vector2(this.col.size.x / 2f, -(this.col.size.y / 2f)));
			result.x += this.wallRayPadding;
			break;
		case Climber.Direction.Down:
			result = (this.clockwise ? new Vector2(this.col.size.x / 2f, -(this.col.size.y / 2f)) : new Vector2(-(this.col.size.x / 2f), -(this.col.size.y / 2f)));
			result.y -= this.wallRayPadding;
			break;
		case Climber.Direction.Left:
			result = (this.clockwise ? new Vector2(-(this.col.size.x / 2f), -(this.col.size.y / 2f)) : new Vector2(-(this.col.size.x / 2f), this.col.size.y / 2f));
			result.x -= this.wallRayPadding;
			break;
		case Climber.Direction.Up:
			result = (this.clockwise ? new Vector2(-(this.col.size.x / 2f), this.col.size.y / 2f) : new Vector2(this.col.size.x / 2f, this.col.size.y / 2f));
			result.y += this.wallRayPadding;
			break;
		}
		return result;
	}

	// Token: 0x060007F9 RID: 2041 RVA: 0x0002CDE4 File Offset: 0x0002AFE4
	private void StickToGround()
	{
		RaycastHit2D raycastHit2D = this.FireRayLocal(Vector2.down, 2f);
		if (raycastHit2D.collider != null)
		{
			base.transform.position = raycastHit2D.point;
		}
	}

	// Token: 0x060007FA RID: 2042 RVA: 0x0002CE28 File Offset: 0x0002B028
	public Climber()
	{
		this.startRight = true;
		this.clockwise = true;
		this.speed = 2f;
		this.spinTime = 0.25f;
		this.wallRayPadding = 0.1f;
		this.constrain = new Vector2(0.1f, 0.1f);
		this.minTurnDistance = 0.25f;
		base..ctor();
	}

	// Token: 0x040008CD RID: 2253
	public bool startRight;

	// Token: 0x040008CE RID: 2254
	private bool clockwise;

	// Token: 0x040008CF RID: 2255
	public float speed;

	// Token: 0x040008D0 RID: 2256
	public float spinTime;

	// Token: 0x040008D1 RID: 2257
	[Space]
	public float wallRayPadding;

	// Token: 0x040008D2 RID: 2258
	[Space]
	public Vector2 constrain;

	// Token: 0x040008D3 RID: 2259
	private Vector2 previousPos;

	// Token: 0x040008D4 RID: 2260
	public float minTurnDistance;

	// Token: 0x040008D5 RID: 2261
	private Vector2 previousTurnPos;

	// Token: 0x040008D6 RID: 2262
	private Climber.Direction currentDirection;

	// Token: 0x040008D7 RID: 2263
	private Coroutine turnRoutine;

	// Token: 0x040008D8 RID: 2264
	private Rigidbody2D body;

	// Token: 0x040008D9 RID: 2265
	private BoxCollider2D col;

	// Token: 0x040008DA RID: 2266
	private tk2dSpriteAnimator anim;

	// Token: 0x02000156 RID: 342
	private enum Direction
	{
		// Token: 0x040008DC RID: 2268
		Right,
		// Token: 0x040008DD RID: 2269
		Down,
		// Token: 0x040008DE RID: 2270
		Left,
		// Token: 0x040008DF RID: 2271
		Up
	}
}
