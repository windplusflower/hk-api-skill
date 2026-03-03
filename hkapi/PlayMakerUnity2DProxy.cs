using System;
using HutongGames.PlayMaker;
using Modding;
using UnityEngine;

// Token: 0x02000033 RID: 51
public class PlayMakerUnity2DProxy : MonoBehaviour
{
	// Token: 0x0600011A RID: 282 RVA: 0x000066A6 File Offset: 0x000048A6
	public void AddOnCollisionEnter2dDelegate(PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate del)
	{
		this.OnCollisionEnter2dDelegates = (PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate)Delegate.Combine(this.OnCollisionEnter2dDelegates, del);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000066BF File Offset: 0x000048BF
	public void RemoveOnCollisionEnter2dDelegate(PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate del)
	{
		this.OnCollisionEnter2dDelegates = (PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate)Delegate.Remove(this.OnCollisionEnter2dDelegates, del);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000066D8 File Offset: 0x000048D8
	public void AddOnCollisionStay2dDelegate(PlayMakerUnity2DProxy.OnCollisionStay2dDelegate del)
	{
		this.OnCollisionStay2dDelegates = (PlayMakerUnity2DProxy.OnCollisionStay2dDelegate)Delegate.Combine(this.OnCollisionStay2dDelegates, del);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000066F1 File Offset: 0x000048F1
	public void RemoveOnCollisionStay2dDelegate(PlayMakerUnity2DProxy.OnCollisionStay2dDelegate del)
	{
		this.OnCollisionStay2dDelegates = (PlayMakerUnity2DProxy.OnCollisionStay2dDelegate)Delegate.Remove(this.OnCollisionStay2dDelegates, del);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000670A File Offset: 0x0000490A
	public void AddOnCollisionExit2dDelegate(PlayMakerUnity2DProxy.OnCollisionExit2dDelegate del)
	{
		this.OnCollisionExit2dDelegates = (PlayMakerUnity2DProxy.OnCollisionExit2dDelegate)Delegate.Combine(this.OnCollisionExit2dDelegates, del);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00006723 File Offset: 0x00004923
	public void RemoveOnCollisionExit2dDelegate(PlayMakerUnity2DProxy.OnCollisionExit2dDelegate del)
	{
		this.OnCollisionExit2dDelegates = (PlayMakerUnity2DProxy.OnCollisionExit2dDelegate)Delegate.Remove(this.OnCollisionExit2dDelegates, del);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000673C File Offset: 0x0000493C
	public void AddOnTriggerEnter2dDelegate(PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate del)
	{
		this.OnTriggerEnter2dDelegates = (PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate)Delegate.Combine(this.OnTriggerEnter2dDelegates, del);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00006755 File Offset: 0x00004955
	public void RemoveOnTriggerEnter2dDelegate(PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate del)
	{
		this.OnTriggerEnter2dDelegates = (PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate)Delegate.Remove(this.OnTriggerEnter2dDelegates, del);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x0000676E File Offset: 0x0000496E
	public void AddOnTriggerStay2dDelegate(PlayMakerUnity2DProxy.OnTriggerStay2dDelegate del)
	{
		this.OnTriggerStay2dDelegates = (PlayMakerUnity2DProxy.OnTriggerStay2dDelegate)Delegate.Combine(this.OnTriggerStay2dDelegates, del);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00006787 File Offset: 0x00004987
	public void RemoveOnTriggerStay2dDelegate(PlayMakerUnity2DProxy.OnTriggerStay2dDelegate del)
	{
		this.OnTriggerStay2dDelegates = (PlayMakerUnity2DProxy.OnTriggerStay2dDelegate)Delegate.Remove(this.OnTriggerStay2dDelegates, del);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000067A0 File Offset: 0x000049A0
	public void AddOnTriggerExit2dDelegate(PlayMakerUnity2DProxy.OnTriggerExit2dDelegate del)
	{
		this.OnTriggerExit2dDelegates = (PlayMakerUnity2DProxy.OnTriggerExit2dDelegate)Delegate.Combine(this.OnTriggerExit2dDelegates, del);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x000067B9 File Offset: 0x000049B9
	public void RemoveOnTriggerExit2dDelegate(PlayMakerUnity2DProxy.OnTriggerExit2dDelegate del)
	{
		this.OnTriggerExit2dDelegates = (PlayMakerUnity2DProxy.OnTriggerExit2dDelegate)Delegate.Remove(this.OnTriggerExit2dDelegates, del);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x000067D2 File Offset: 0x000049D2
	[ContextMenu("Help")]
	public void help()
	{
		Application.OpenURL("https://hutonggames.fogbugz.com/default.asp?W1150");
	}

	// Token: 0x06000127 RID: 295 RVA: 0x000067DE File Offset: 0x000049DE
	public void Start()
	{
		if (!PlayMakerUnity2d.isAvailable())
		{
			Debug.LogError("PlayMakerUnity2DProxy requires the 'PlayMaker Unity 2D' Prefab in the Scene.\nUse the menu 'PlayMaker/Addons/Unity 2D/Components/Add PlayMakerUnity2D to Scene' to correct the situation", this);
			base.enabled = false;
			return;
		}
		ModHooks.OnColliderCreate(base.gameObject);
		this.RefreshImplementation();
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0000680B File Offset: 0x00004A0B
	public void RefreshImplementation()
	{
		this.CheckGameObjectEventsImplementation();
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00006813 File Offset: 0x00004A13
	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (this.HandleCollisionEnter2D)
		{
			this.lastCollision2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnCollisionEnter2DEvent);
		}
		if (this.OnCollisionEnter2dDelegates != null)
		{
			this.OnCollisionEnter2dDelegates(coll);
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00006848 File Offset: 0x00004A48
	private void OnCollisionStay2D(Collision2D coll)
	{
		if (this.debug)
		{
			Debug.Log("OnCollisionStay2D " + this.HandleCollisionStay2D.ToString(), base.gameObject);
		}
		if (this.HandleCollisionStay2D)
		{
			this.lastCollision2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnCollisionStay2DEvent);
		}
		if (this.OnCollisionStay2dDelegates != null)
		{
			this.OnCollisionStay2dDelegates(coll);
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x000068B0 File Offset: 0x00004AB0
	private void OnCollisionExit2D(Collision2D coll)
	{
		if (this.debug)
		{
			Debug.Log("OnCollisionExit2D " + this.HandleCollisionExit2D.ToString(), base.gameObject);
		}
		if (this.HandleCollisionExit2D)
		{
			this.lastCollision2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnCollisionExit2DEvent);
		}
		if (this.OnCollisionExit2dDelegates != null)
		{
			this.OnCollisionExit2dDelegates(coll);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00006918 File Offset: 0x00004B18
	private void OnTriggerEnter2D(Collider2D coll)
	{
		if (this.debug)
		{
			Debug.Log(base.gameObject.name + " OnTriggerEnter2D " + coll.gameObject.name, base.gameObject);
		}
		if (this.HandleTriggerEnter2D)
		{
			this.lastTrigger2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnTriggerEnter2DEvent);
		}
		if (this.OnTriggerEnter2dDelegates != null)
		{
			this.OnTriggerEnter2dDelegates(coll);
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0000698C File Offset: 0x00004B8C
	private void OnTriggerStay2D(Collider2D coll)
	{
		if (this.debug)
		{
			Debug.Log(base.gameObject.name + " OnTriggerStay2D " + coll.gameObject.name, base.gameObject);
		}
		if (this.HandleTriggerStay2D)
		{
			this.lastTrigger2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnTriggerStay2DEvent);
		}
		if (this.OnTriggerStay2dDelegates != null)
		{
			this.OnTriggerStay2dDelegates(coll);
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00006A00 File Offset: 0x00004C00
	private void OnTriggerExit2D(Collider2D coll)
	{
		if (this.debug)
		{
			Debug.Log(base.gameObject.name + " OnTriggerExit2D " + coll.gameObject.name, base.gameObject);
		}
		if (this.HandleTriggerExit2D)
		{
			this.lastTrigger2DInfo = coll;
			PlayMakerUnity2d.ForwardEventToGameObject(base.gameObject, PlayMakerUnity2d.OnTriggerExit2DEvent);
		}
		if (this.OnTriggerExit2dDelegates != null)
		{
			this.OnTriggerExit2dDelegates(coll);
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00006A74 File Offset: 0x00004C74
	private void CheckGameObjectEventsImplementation()
	{
		foreach (PlayMakerFSM fsm in base.GetComponents<PlayMakerFSM>())
		{
			this.CheckFsmEventsImplementation(fsm);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00006AA4 File Offset: 0x00004CA4
	private void CheckFsmEventsImplementation(PlayMakerFSM fsm)
	{
		foreach (FsmTransition fsmTransition in fsm.FsmGlobalTransitions)
		{
			this.CheckTransition(fsmTransition.EventName);
		}
		FsmState[] fsmStates = fsm.FsmStates;
		for (int i = 0; i < fsmStates.Length; i++)
		{
			foreach (FsmTransition fsmTransition2 in fsmStates[i].Transitions)
			{
				this.CheckTransition(fsmTransition2.EventName);
			}
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00006B1C File Offset: 0x00004D1C
	private void CheckTransition(string transitionName)
	{
		if (transitionName.Equals(PlayMakerUnity2d.OnCollisionEnter2DEvent))
		{
			this.HandleCollisionEnter2D = true;
		}
		if (transitionName.Equals(PlayMakerUnity2d.OnCollisionExit2DEvent))
		{
			this.HandleCollisionExit2D = true;
		}
		if (transitionName.Equals(PlayMakerUnity2d.OnCollisionStay2DEvent))
		{
			this.HandleCollisionStay2D = true;
		}
		if (transitionName.Equals(PlayMakerUnity2d.OnTriggerEnter2DEvent))
		{
			this.HandleTriggerEnter2D = true;
		}
		if (transitionName.Equals(PlayMakerUnity2d.OnTriggerExit2DEvent))
		{
			this.HandleTriggerExit2D = true;
		}
		if (transitionName.Equals(PlayMakerUnity2d.OnTriggerStay2DEvent))
		{
			this.HandleTriggerStay2D = true;
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00006BA1 File Offset: 0x00004DA1
	public void orig_Start()
	{
		if (!PlayMakerUnity2d.isAvailable())
		{
			Debug.LogError("PlayMakerUnity2DProxy requires the 'PlayMaker Unity 2D' Prefab in the Scene.\nUse the menu 'PlayMaker/Addons/Unity 2D/Components/Add PlayMakerUnity2D to Scene' to correct the situation", this);
			base.enabled = false;
			return;
		}
		this.RefreshImplementation();
	}

	// Token: 0x040000DE RID: 222
	public bool debug;

	// Token: 0x040000DF RID: 223
	[HideInInspector]
	public bool HandleCollisionEnter2D;

	// Token: 0x040000E0 RID: 224
	[HideInInspector]
	public bool HandleCollisionExit2D;

	// Token: 0x040000E1 RID: 225
	[HideInInspector]
	public bool HandleCollisionStay2D;

	// Token: 0x040000E2 RID: 226
	[HideInInspector]
	public bool HandleTriggerEnter2D;

	// Token: 0x040000E3 RID: 227
	[HideInInspector]
	public bool HandleTriggerExit2D;

	// Token: 0x040000E4 RID: 228
	[HideInInspector]
	public bool HandleTriggerStay2D;

	// Token: 0x040000E5 RID: 229
	[HideInInspector]
	public Collision2D lastCollision2DInfo;

	// Token: 0x040000E6 RID: 230
	[HideInInspector]
	public Collider2D lastTrigger2DInfo;

	// Token: 0x040000E7 RID: 231
	private PlayMakerUnity2DProxy.OnCollisionEnter2dDelegate OnCollisionEnter2dDelegates;

	// Token: 0x040000E8 RID: 232
	private PlayMakerUnity2DProxy.OnCollisionStay2dDelegate OnCollisionStay2dDelegates;

	// Token: 0x040000E9 RID: 233
	private PlayMakerUnity2DProxy.OnCollisionExit2dDelegate OnCollisionExit2dDelegates;

	// Token: 0x040000EA RID: 234
	private PlayMakerUnity2DProxy.OnTriggerEnter2dDelegate OnTriggerEnter2dDelegates;

	// Token: 0x040000EB RID: 235
	private PlayMakerUnity2DProxy.OnTriggerStay2dDelegate OnTriggerStay2dDelegates;

	// Token: 0x040000EC RID: 236
	private PlayMakerUnity2DProxy.OnTriggerExit2dDelegate OnTriggerExit2dDelegates;

	// Token: 0x02000034 RID: 52
	// (Invoke) Token: 0x06000135 RID: 309
	public delegate void OnCollisionEnter2dDelegate(Collision2D collisionInfo);

	// Token: 0x02000035 RID: 53
	// (Invoke) Token: 0x06000139 RID: 313
	public delegate void OnCollisionStay2dDelegate(Collision2D collisionInfo);

	// Token: 0x02000036 RID: 54
	// (Invoke) Token: 0x0600013D RID: 317
	public delegate void OnCollisionExit2dDelegate(Collision2D collisionInfo);

	// Token: 0x02000037 RID: 55
	// (Invoke) Token: 0x06000141 RID: 321
	public delegate void OnTriggerEnter2dDelegate(Collider2D collisionInfo);

	// Token: 0x02000038 RID: 56
	// (Invoke) Token: 0x06000145 RID: 325
	public delegate void OnTriggerStay2dDelegate(Collider2D collisionInfo);

	// Token: 0x02000039 RID: 57
	// (Invoke) Token: 0x06000149 RID: 329
	public delegate void OnTriggerExit2dDelegate(Collider2D collisionInfo);
}
