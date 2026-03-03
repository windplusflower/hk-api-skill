using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000624 RID: 1572
	public class TMP_UpdateManager
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000C7914 File Offset: 0x000C5B14
		public static TMP_UpdateManager instance
		{
			get
			{
				if (TMP_UpdateManager.s_Instance == null)
				{
					TMP_UpdateManager.s_Instance = new TMP_UpdateManager();
				}
				return TMP_UpdateManager.s_Instance;
			}
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000C792C File Offset: 0x000C5B2C
		protected TMP_UpdateManager()
		{
			this.m_LayoutRebuildQueue = new List<TMP_Text>();
			this.m_LayoutQueueLookup = new Dictionary<int, int>();
			this.m_GraphicRebuildQueue = new List<TMP_Text>();
			this.m_GraphicQueueLookup = new Dictionary<int, int>();
			base..ctor();
			Camera.onPreRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPreRender, new Camera.CameraCallback(this.OnCameraPreRender));
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000C798B File Offset: 0x000C5B8B
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			TMP_UpdateManager.instance.InternalRegisterTextElementForLayoutRebuild(element);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000C799C File Offset: 0x000C5B9C
		private bool InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			int instanceID = element.GetInstanceID();
			if (this.m_LayoutQueueLookup.ContainsKey(instanceID))
			{
				return false;
			}
			this.m_LayoutQueueLookup[instanceID] = instanceID;
			this.m_LayoutRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x000C79DA File Offset: 0x000C5BDA
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			TMP_UpdateManager.instance.InternalRegisterTextElementForGraphicRebuild(element);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000C79E8 File Offset: 0x000C5BE8
		private bool InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			int instanceID = element.GetInstanceID();
			if (this.m_GraphicQueueLookup.ContainsKey(instanceID))
			{
				return false;
			}
			this.m_GraphicQueueLookup[instanceID] = instanceID;
			this.m_GraphicRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000C7A28 File Offset: 0x000C5C28
		private void OnCameraPreRender(Camera cam)
		{
			for (int i = 0; i < this.m_LayoutRebuildQueue.Count; i++)
			{
				this.m_LayoutRebuildQueue[i].Rebuild(CanvasUpdate.Prelayout);
			}
			if (this.m_LayoutRebuildQueue.Count > 0)
			{
				this.m_LayoutRebuildQueue.Clear();
				this.m_LayoutQueueLookup.Clear();
			}
			for (int j = 0; j < this.m_GraphicRebuildQueue.Count; j++)
			{
				this.m_GraphicRebuildQueue[j].Rebuild(CanvasUpdate.PreRender);
			}
			if (this.m_GraphicRebuildQueue.Count > 0)
			{
				this.m_GraphicRebuildQueue.Clear();
				this.m_GraphicQueueLookup.Clear();
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000C7ACD File Offset: 0x000C5CCD
		public static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
			TMP_UpdateManager.instance.InternalUnRegisterTextElementForGraphicRebuild(element);
			TMP_UpdateManager.instance.InternalUnRegisterTextElementForLayoutRebuild(element);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000C7AE8 File Offset: 0x000C5CE8
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			int instanceID = element.GetInstanceID();
			TMP_UpdateManager.instance.m_GraphicRebuildQueue.Remove(element);
			this.m_GraphicQueueLookup.Remove(instanceID);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000C7B1C File Offset: 0x000C5D1C
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			int instanceID = element.GetInstanceID();
			TMP_UpdateManager.instance.m_LayoutRebuildQueue.Remove(element);
			this.m_LayoutQueueLookup.Remove(instanceID);
		}

		// Token: 0x040029EC RID: 10732
		private static TMP_UpdateManager s_Instance;

		// Token: 0x040029ED RID: 10733
		private readonly List<TMP_Text> m_LayoutRebuildQueue;

		// Token: 0x040029EE RID: 10734
		private Dictionary<int, int> m_LayoutQueueLookup;

		// Token: 0x040029EF RID: 10735
		private readonly List<TMP_Text> m_GraphicRebuildQueue;

		// Token: 0x040029F0 RID: 10736
		private Dictionary<int, int> m_GraphicQueueLookup;
	}
}
