using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200095B RID: 2395
	[Tooltip("Collections base action - don't use!")]
	public abstract class CollectionsActions : FsmStateAction
	{
		// Token: 0x0600349E RID: 13470 RVA: 0x0013A084 File Offset: 0x00138284
		protected PlayMakerHashTableProxy GetHashTableProxyPointer(GameObject aProxy, string nameReference, bool silent)
		{
			if (aProxy == null)
			{
				if (!silent)
				{
					Debug.LogError("Null Proxy");
				}
				return null;
			}
			PlayMakerHashTableProxy[] components = aProxy.GetComponents<PlayMakerHashTableProxy>();
			if (components.Length > 1)
			{
				if (nameReference == "" && !silent)
				{
					Debug.LogWarning("Several HashTable Proxies coexists on the same GameObject and no reference is given to find the expected HashTable");
				}
				foreach (PlayMakerHashTableProxy playMakerHashTableProxy in components)
				{
					if (playMakerHashTableProxy.referenceName == nameReference)
					{
						return playMakerHashTableProxy;
					}
				}
				if (nameReference != "")
				{
					if (!silent)
					{
						Debug.LogError("HashTable Proxy not found for reference <" + nameReference + ">");
					}
					return null;
				}
			}
			else if (components.Length != 0)
			{
				if (nameReference != "" && nameReference != components[0].referenceName)
				{
					if (!silent)
					{
						Debug.LogError("HashTable Proxy reference do not match");
					}
					return null;
				}
				return components[0];
			}
			if (!silent)
			{
				Debug.LogError("HashTable not found");
			}
			return null;
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x0013A160 File Offset: 0x00138360
		protected PlayMakerArrayListProxy GetArrayListProxyPointer(GameObject aProxy, string nameReference, bool silent)
		{
			if (aProxy == null)
			{
				if (!silent)
				{
					Debug.LogError("Null Proxy");
				}
				return null;
			}
			PlayMakerArrayListProxy[] components = aProxy.GetComponents<PlayMakerArrayListProxy>();
			if (components.Length > 1)
			{
				if (nameReference == "" && !silent)
				{
					Debug.LogError("Several ArrayList Proxies coexists on the same GameObject and no reference is given to find the expected ArrayList");
				}
				foreach (PlayMakerArrayListProxy playMakerArrayListProxy in components)
				{
					if (playMakerArrayListProxy.referenceName == nameReference)
					{
						return playMakerArrayListProxy;
					}
				}
				if (nameReference != "")
				{
					if (!silent)
					{
						base.LogError("ArrayList Proxy not found for reference <" + nameReference + ">");
					}
					return null;
				}
			}
			else if (components.Length != 0)
			{
				if (nameReference != "" && nameReference != components[0].referenceName)
				{
					if (!silent)
					{
						Debug.LogError("ArrayList Proxy reference do not match");
					}
					return null;
				}
				return components[0];
			}
			if (!silent)
			{
				base.LogError("ArrayList proxy not found");
			}
			return null;
		}

		// Token: 0x0200095C RID: 2396
		public enum FsmVariableEnum
		{
			// Token: 0x04003656 RID: 13910
			FsmGameObject,
			// Token: 0x04003657 RID: 13911
			FsmInt,
			// Token: 0x04003658 RID: 13912
			FsmFloat,
			// Token: 0x04003659 RID: 13913
			FsmString,
			// Token: 0x0400365A RID: 13914
			FsmBool,
			// Token: 0x0400365B RID: 13915
			FsmVector2,
			// Token: 0x0400365C RID: 13916
			FsmVector3,
			// Token: 0x0400365D RID: 13917
			FsmRect,
			// Token: 0x0400365E RID: 13918
			FsmQuaternion,
			// Token: 0x0400365F RID: 13919
			FsmColor,
			// Token: 0x04003660 RID: 13920
			FsmMaterial,
			// Token: 0x04003661 RID: 13921
			FsmTexture,
			// Token: 0x04003662 RID: 13922
			FsmObject
		}
	}
}
