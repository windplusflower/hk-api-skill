using System;
using System.Linq;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000731 RID: 1841
	public abstract class SingletonMonoBehavior<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
	{
		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x000F4D64 File Offset: 0x000F2F64
		public static TComponent Instance
		{
			get
			{
				object obj = SingletonMonoBehavior<TComponent>.lockObject;
				TComponent result;
				lock (obj)
				{
					if (SingletonMonoBehavior<TComponent>.hasInstance)
					{
						result = SingletonMonoBehavior<TComponent>.instance;
					}
					else
					{
						SingletonMonoBehavior<TComponent>.instance = SingletonMonoBehavior<TComponent>.FindFirstInstance();
						if (SingletonMonoBehavior<TComponent>.instance == null)
						{
							string str = "The instance of singleton component ";
							Type typeFromHandle = typeof(TComponent);
							throw new Exception(str + ((typeFromHandle != null) ? typeFromHandle.ToString() : null) + " was requested, but it doesn't appear to exist in the scene.");
						}
						SingletonMonoBehavior<TComponent>.hasInstance = true;
						SingletonMonoBehavior<TComponent>.instanceId = SingletonMonoBehavior<TComponent>.instance.GetInstanceID();
						result = SingletonMonoBehavior<TComponent>.instance;
					}
				}
				return result;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x000F4E18 File Offset: 0x000F3018
		protected bool EnforceSingleton
		{
			get
			{
				if (base.GetInstanceID() == SingletonMonoBehavior<TComponent>.Instance.GetInstanceID())
				{
					return false;
				}
				if (Application.isPlaying)
				{
					base.enabled = false;
				}
				return true;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000F4E44 File Offset: 0x000F3044
		protected bool IsTheSingleton
		{
			get
			{
				object obj = SingletonMonoBehavior<TComponent>.lockObject;
				bool result;
				lock (obj)
				{
					result = (base.GetInstanceID() == SingletonMonoBehavior<TComponent>.instanceId);
				}
				return result;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x000F4E8C File Offset: 0x000F308C
		protected bool IsNotTheSingleton
		{
			get
			{
				object obj = SingletonMonoBehavior<TComponent>.lockObject;
				bool result;
				lock (obj)
				{
					result = (base.GetInstanceID() != SingletonMonoBehavior<TComponent>.instanceId);
				}
				return result;
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000F4ED8 File Offset: 0x000F30D8
		private static TComponent[] FindInstances()
		{
			TComponent[] array = UnityEngine.Object.FindObjectsOfType<TComponent>();
			Array.Sort<TComponent>(array, (TComponent a, TComponent b) => a.transform.GetSiblingIndex().CompareTo(b.transform.GetSiblingIndex()));
			return array;
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000F4F04 File Offset: 0x000F3104
		private static TComponent FindFirstInstance()
		{
			TComponent[] array = SingletonMonoBehavior<TComponent>.FindInstances();
			if (array.Length == 0)
			{
				return default(TComponent);
			}
			return array[0];
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x000F4F2C File Offset: 0x000F312C
		protected virtual void Awake()
		{
			if (Application.isPlaying && SingletonMonoBehavior<TComponent>.Instance)
			{
				if (base.GetInstanceID() != SingletonMonoBehavior<TComponent>.instanceId)
				{
					base.enabled = false;
				}
				foreach (TComponent tcomponent in from o in SingletonMonoBehavior<TComponent>.FindInstances()
				where o.GetInstanceID() != SingletonMonoBehavior<TComponent>.instanceId
				select o)
				{
					tcomponent.enabled = false;
				}
			}
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x000F4FD0 File Offset: 0x000F31D0
		protected virtual void OnDestroy()
		{
			object obj = SingletonMonoBehavior<TComponent>.lockObject;
			lock (obj)
			{
				if (base.GetInstanceID() == SingletonMonoBehavior<TComponent>.instanceId)
				{
					SingletonMonoBehavior<TComponent>.hasInstance = false;
				}
			}
		}

		// Token: 0x040032D5 RID: 13013
		private static TComponent instance;

		// Token: 0x040032D6 RID: 13014
		private static bool hasInstance;

		// Token: 0x040032D7 RID: 13015
		private static int instanceId;

		// Token: 0x040032D8 RID: 13016
		private static readonly object lockObject = new object();
	}
}
