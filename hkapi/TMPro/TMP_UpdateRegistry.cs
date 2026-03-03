using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000625 RID: 1573
	public class TMP_UpdateRegistry
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000C7B4E File Offset: 0x000C5D4E
		public static TMP_UpdateRegistry instance
		{
			get
			{
				if (TMP_UpdateRegistry.s_Instance == null)
				{
					TMP_UpdateRegistry.s_Instance = new TMP_UpdateRegistry();
				}
				return TMP_UpdateRegistry.s_Instance;
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000C7B68 File Offset: 0x000C5D68
		protected TMP_UpdateRegistry()
		{
			this.m_LayoutRebuildQueue = new List<ICanvasElement>();
			this.m_LayoutQueueLookup = new Dictionary<int, int>();
			this.m_GraphicRebuildQueue = new List<ICanvasElement>();
			this.m_GraphicQueueLookup = new Dictionary<int, int>();
			base..ctor();
			Canvas.willRenderCanvases += this.PerformUpdateForCanvasRendererObjects;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000C7BB8 File Offset: 0x000C5DB8
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			TMP_UpdateRegistry.instance.InternalRegisterCanvasElementForLayoutRebuild(element);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000C7BC8 File Offset: 0x000C5DC8
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			int instanceID = (element as UnityEngine.Object).GetInstanceID();
			if (this.m_LayoutQueueLookup.ContainsKey(instanceID))
			{
				return false;
			}
			this.m_LayoutQueueLookup[instanceID] = instanceID;
			this.m_LayoutRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000C7C0B File Offset: 0x000C5E0B
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			TMP_UpdateRegistry.instance.InternalRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000C7C1C File Offset: 0x000C5E1C
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			int instanceID = (element as UnityEngine.Object).GetInstanceID();
			if (this.m_GraphicQueueLookup.ContainsKey(instanceID))
			{
				return false;
			}
			this.m_GraphicQueueLookup[instanceID] = instanceID;
			this.m_GraphicRebuildQueue.Add(element);
			return true;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000C7C60 File Offset: 0x000C5E60
		private void PerformUpdateForCanvasRendererObjects()
		{
			for (int i = 0; i < this.m_LayoutRebuildQueue.Count; i++)
			{
				TMP_UpdateRegistry.instance.m_LayoutRebuildQueue[i].Rebuild(CanvasUpdate.Prelayout);
			}
			if (this.m_LayoutRebuildQueue.Count > 0)
			{
				this.m_LayoutRebuildQueue.Clear();
				this.m_LayoutQueueLookup.Clear();
			}
			for (int j = 0; j < this.m_GraphicRebuildQueue.Count; j++)
			{
				TMP_UpdateRegistry.instance.m_GraphicRebuildQueue[j].Rebuild(CanvasUpdate.PreRender);
			}
			if (this.m_GraphicRebuildQueue.Count > 0)
			{
				this.m_GraphicRebuildQueue.Clear();
				this.m_GraphicQueueLookup.Clear();
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000C7D0D File Offset: 0x000C5F0D
		private void PerformUpdateForMeshRendererObjects()
		{
			Debug.Log("Perform update of MeshRenderer objects.");
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000C7D19 File Offset: 0x000C5F19
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			TMP_UpdateRegistry.instance.InternalUnRegisterCanvasElementForLayoutRebuild(element);
			TMP_UpdateRegistry.instance.InternalUnRegisterCanvasElementForGraphicRebuild(element);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x000C7D34 File Offset: 0x000C5F34
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			int instanceID = (element as UnityEngine.Object).GetInstanceID();
			TMP_UpdateRegistry.instance.m_LayoutRebuildQueue.Remove(element);
			this.m_GraphicQueueLookup.Remove(instanceID);
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000C7D6C File Offset: 0x000C5F6C
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			int instanceID = (element as UnityEngine.Object).GetInstanceID();
			TMP_UpdateRegistry.instance.m_GraphicRebuildQueue.Remove(element);
			this.m_LayoutQueueLookup.Remove(instanceID);
		}

		// Token: 0x040029F1 RID: 10737
		private static TMP_UpdateRegistry s_Instance;

		// Token: 0x040029F2 RID: 10738
		private readonly List<ICanvasElement> m_LayoutRebuildQueue;

		// Token: 0x040029F3 RID: 10739
		private Dictionary<int, int> m_LayoutQueueLookup;

		// Token: 0x040029F4 RID: 10740
		private readonly List<ICanvasElement> m_GraphicRebuildQueue;

		// Token: 0x040029F5 RID: 10741
		private Dictionary<int, int> m_GraphicQueueLookup;
	}
}
