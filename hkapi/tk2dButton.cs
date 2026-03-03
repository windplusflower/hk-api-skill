using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200054D RID: 1357
[AddComponentMenu("2D Toolkit/Deprecated/GUI/tk2dButton")]
public class tk2dButton : MonoBehaviour
{
	// Token: 0x14000042 RID: 66
	// (add) Token: 0x06001DC3 RID: 7619 RVA: 0x0009485C File Offset: 0x00092A5C
	// (remove) Token: 0x06001DC4 RID: 7620 RVA: 0x00094894 File Offset: 0x00092A94
	public event tk2dButton.ButtonHandlerDelegate ButtonPressedEvent;

	// Token: 0x14000043 RID: 67
	// (add) Token: 0x06001DC5 RID: 7621 RVA: 0x000948CC File Offset: 0x00092ACC
	// (remove) Token: 0x06001DC6 RID: 7622 RVA: 0x00094904 File Offset: 0x00092B04
	public event tk2dButton.ButtonHandlerDelegate ButtonAutoFireEvent;

	// Token: 0x14000044 RID: 68
	// (add) Token: 0x06001DC7 RID: 7623 RVA: 0x0009493C File Offset: 0x00092B3C
	// (remove) Token: 0x06001DC8 RID: 7624 RVA: 0x00094974 File Offset: 0x00092B74
	public event tk2dButton.ButtonHandlerDelegate ButtonDownEvent;

	// Token: 0x14000045 RID: 69
	// (add) Token: 0x06001DC9 RID: 7625 RVA: 0x000949AC File Offset: 0x00092BAC
	// (remove) Token: 0x06001DCA RID: 7626 RVA: 0x000949E4 File Offset: 0x00092BE4
	public event tk2dButton.ButtonHandlerDelegate ButtonUpEvent;

	// Token: 0x06001DCB RID: 7627 RVA: 0x00094A19 File Offset: 0x00092C19
	private void OnEnable()
	{
		this.buttonDown = false;
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x00094A24 File Offset: 0x00092C24
	private void Start()
	{
		if (this.viewCamera == null)
		{
			Transform transform = base.transform;
			while (transform && transform.GetComponent<Camera>() == null)
			{
				transform = transform.parent;
			}
			if (transform && transform.GetComponent<Camera>() != null)
			{
				this.viewCamera = transform.GetComponent<Camera>();
			}
			if (this.viewCamera == null && tk2dCamera.Instance)
			{
				this.viewCamera = tk2dCamera.Instance.GetComponent<Camera>();
			}
			if (this.viewCamera == null)
			{
				this.viewCamera = Camera.main;
			}
		}
		this.sprite = base.GetComponent<tk2dBaseSprite>();
		if (this.sprite)
		{
			this.UpdateSpriteIds();
		}
		if (base.GetComponent<Collider>() == null)
		{
			BoxCollider boxCollider = base.gameObject.AddComponent<BoxCollider>();
			Vector3 size = boxCollider.size;
			size.z = 0.2f;
			boxCollider.size = size;
		}
		if ((this.buttonDownSound != null || this.buttonPressedSound != null || this.buttonUpSound != null) && base.GetComponent<AudioSource>() == null)
		{
			base.gameObject.AddComponent<AudioSource>().playOnAwake = false;
		}
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x00094B68 File Offset: 0x00092D68
	public void UpdateSpriteIds()
	{
		this.buttonDownSpriteId = ((this.buttonDownSprite.Length > 0) ? this.sprite.GetSpriteIdByName(this.buttonDownSprite) : -1);
		this.buttonUpSpriteId = ((this.buttonUpSprite.Length > 0) ? this.sprite.GetSpriteIdByName(this.buttonUpSprite) : -1);
		this.buttonPressedSpriteId = ((this.buttonPressedSprite.Length > 0) ? this.sprite.GetSpriteIdByName(this.buttonPressedSprite) : -1);
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x00094BED File Offset: 0x00092DED
	private void PlaySound(AudioClip source)
	{
		if (base.GetComponent<AudioSource>() && source)
		{
			base.GetComponent<AudioSource>().PlayOneShot(source);
		}
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x00094C10 File Offset: 0x00092E10
	private IEnumerator coScale(Vector3 defaultScale, float startScale, float endScale)
	{
		float t0 = Time.realtimeSinceStartup;
		for (float num = 0f; num < this.scaleTime; num = Time.realtimeSinceStartup - t0)
		{
			float t = Mathf.Clamp01(num / this.scaleTime);
			float d = Mathf.Lerp(startScale, endScale, t);
			Vector3 localScale = defaultScale * d;
			this.transform.localScale = localScale;
			yield return 0;
		}
		this.transform.localScale = defaultScale * endScale;
		yield break;
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x00094C34 File Offset: 0x00092E34
	private IEnumerator LocalWaitForSeconds(float seconds)
	{
		float t0 = Time.realtimeSinceStartup;
		for (float num = 0f; num < seconds; num = Time.realtimeSinceStartup - t0)
		{
			yield return 0;
		}
		yield break;
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x00094C43 File Offset: 0x00092E43
	private IEnumerator coHandleButtonPress(int fingerId)
	{
		this.buttonDown = true;
		bool buttonPressed = true;
		Vector3 defaultScale = this.transform.localScale;
		if (this.targetScale != 1f)
		{
			yield return this.StartCoroutine(this.coScale(defaultScale, 1f, this.targetScale));
		}
		this.PlaySound(this.buttonDownSound);
		if (this.buttonDownSpriteId != -1)
		{
			this.sprite.spriteId = this.buttonDownSpriteId;
		}
		if (this.ButtonDownEvent != null)
		{
			this.ButtonDownEvent(this);
		}
		for (;;)
		{
			Vector3 pos = Vector3.zero;
			bool flag = true;
			if (fingerId != -1)
			{
				bool flag2 = false;
				for (int i = 0; i < Input.touchCount; i++)
				{
					Touch touch = Input.GetTouch(i);
					if (touch.fingerId == fingerId)
					{
						if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
						{
							break;
						}
						pos = touch.position;
						flag2 = true;
					}
				}
				if (!flag2)
				{
					flag = false;
				}
			}
			else
			{
				if (!Input.GetMouseButton(0))
				{
					flag = false;
				}
				pos = Input.mousePosition;
			}
			if (!flag)
			{
				break;
			}
			Ray ray = this.viewCamera.ScreenPointToRay(pos);
			RaycastHit raycastHit;
			bool flag3 = this.GetComponent<Collider>().Raycast(ray, out raycastHit, float.PositiveInfinity);
			if (buttonPressed && !flag3)
			{
				if (this.targetScale != 1f)
				{
					yield return this.StartCoroutine(this.coScale(defaultScale, this.targetScale, 1f));
				}
				this.PlaySound(this.buttonUpSound);
				if (this.buttonUpSpriteId != -1)
				{
					this.sprite.spriteId = this.buttonUpSpriteId;
				}
				if (this.ButtonUpEvent != null)
				{
					this.ButtonUpEvent(this);
				}
				buttonPressed = false;
			}
			else if (!buttonPressed && flag3)
			{
				if (this.targetScale != 1f)
				{
					yield return this.StartCoroutine(this.coScale(defaultScale, 1f, this.targetScale));
				}
				this.PlaySound(this.buttonDownSound);
				if (this.buttonDownSpriteId != -1)
				{
					this.sprite.spriteId = this.buttonDownSpriteId;
				}
				if (this.ButtonDownEvent != null)
				{
					this.ButtonDownEvent(this);
				}
				buttonPressed = true;
			}
			if (buttonPressed && this.ButtonAutoFireEvent != null)
			{
				this.ButtonAutoFireEvent(this);
			}
			yield return 0;
		}
		if (buttonPressed)
		{
			if (this.targetScale != 1f)
			{
				yield return this.StartCoroutine(this.coScale(defaultScale, this.targetScale, 1f));
			}
			this.PlaySound(this.buttonPressedSound);
			if (this.buttonPressedSpriteId != -1)
			{
				this.sprite.spriteId = this.buttonPressedSpriteId;
			}
			if (this.targetObject)
			{
				this.targetObject.SendMessage(this.messageName);
			}
			if (this.ButtonUpEvent != null)
			{
				this.ButtonUpEvent(this);
			}
			if (this.ButtonPressedEvent != null)
			{
				this.ButtonPressedEvent(this);
			}
			if (this.gameObject.activeInHierarchy)
			{
				yield return this.StartCoroutine(this.LocalWaitForSeconds(this.pressedWaitTime));
			}
			if (this.buttonUpSpriteId != -1)
			{
				this.sprite.spriteId = this.buttonUpSpriteId;
			}
		}
		this.buttonDown = false;
		yield break;
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x00094C5C File Offset: 0x00092E5C
	private void Update()
	{
		if (this.buttonDown)
		{
			return;
		}
		bool flag = false;
		if (Input.multiTouchEnabled)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began)
				{
					Ray ray = this.viewCamera.ScreenPointToRay(touch.position);
					RaycastHit raycastHit;
					if (base.GetComponent<Collider>().Raycast(ray, out raycastHit, 100000000f) && !Physics.Raycast(ray, raycastHit.distance - 0.01f))
					{
						base.StartCoroutine(this.coHandleButtonPress(touch.fingerId));
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag && Input.GetMouseButtonDown(0))
		{
			Ray ray2 = this.viewCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit2;
			if (base.GetComponent<Collider>().Raycast(ray2, out raycastHit2, 100000000f) && !Physics.Raycast(ray2, raycastHit2.distance - 0.01f))
			{
				base.StartCoroutine(this.coHandleButtonPress(-1));
			}
		}
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x00094D54 File Offset: 0x00092F54
	public tk2dButton()
	{
		this.buttonDownSprite = "button_down";
		this.buttonUpSprite = "button_up";
		this.buttonPressedSprite = "button_up";
		this.buttonDownSpriteId = -1;
		this.buttonUpSpriteId = -1;
		this.buttonPressedSpriteId = -1;
		this.messageName = "";
		this.targetScale = 1.1f;
		this.scaleTime = 0.05f;
		this.pressedWaitTime = 0.3f;
		base..ctor();
	}

	// Token: 0x04002373 RID: 9075
	public Camera viewCamera;

	// Token: 0x04002374 RID: 9076
	public string buttonDownSprite;

	// Token: 0x04002375 RID: 9077
	public string buttonUpSprite;

	// Token: 0x04002376 RID: 9078
	public string buttonPressedSprite;

	// Token: 0x04002377 RID: 9079
	private int buttonDownSpriteId;

	// Token: 0x04002378 RID: 9080
	private int buttonUpSpriteId;

	// Token: 0x04002379 RID: 9081
	private int buttonPressedSpriteId;

	// Token: 0x0400237A RID: 9082
	public AudioClip buttonDownSound;

	// Token: 0x0400237B RID: 9083
	public AudioClip buttonUpSound;

	// Token: 0x0400237C RID: 9084
	public AudioClip buttonPressedSound;

	// Token: 0x0400237D RID: 9085
	public GameObject targetObject;

	// Token: 0x0400237E RID: 9086
	public string messageName;

	// Token: 0x04002383 RID: 9091
	private tk2dBaseSprite sprite;

	// Token: 0x04002384 RID: 9092
	private bool buttonDown;

	// Token: 0x04002385 RID: 9093
	public float targetScale;

	// Token: 0x04002386 RID: 9094
	public float scaleTime;

	// Token: 0x04002387 RID: 9095
	public float pressedWaitTime;

	// Token: 0x0200054E RID: 1358
	// (Invoke) Token: 0x06001DD5 RID: 7637
	public delegate void ButtonHandlerDelegate(tk2dButton source);
}
