using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000628 RID: 1576
	public static class TMPro_EventManager
	{
		// Token: 0x060025FF RID: 9727 RVA: 0x000C7EB6 File Offset: 0x000C60B6
		public static void ON_PRE_RENDER_OBJECT_CHANGED()
		{
			TMPro_EventManager.OnPreRenderObject_Event.Call();
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000C7EC2 File Offset: 0x000C60C2
		public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
		{
			TMPro_EventManager.MATERIAL_PROPERTY_EVENT.Call(isChanged, mat);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000C7ED0 File Offset: 0x000C60D0
		public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, TMP_FontAsset font)
		{
			TMPro_EventManager.FONT_PROPERTY_EVENT.Call(isChanged, font);
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000C7EDE File Offset: 0x000C60DE
		public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, UnityEngine.Object obj)
		{
			TMPro_EventManager.SPRITE_ASSET_PROPERTY_EVENT.Call(isChanged, obj);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000C7EEC File Offset: 0x000C60EC
		public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, TextMeshPro obj)
		{
			TMPro_EventManager.TEXTMESHPRO_PROPERTY_EVENT.Call(isChanged, obj);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x000C7EFA File Offset: 0x000C60FA
		public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
		{
			TMPro_EventManager.DRAG_AND_DROP_MATERIAL_EVENT.Call(sender, currentMaterial, newMaterial);
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000C7F09 File Offset: 0x000C6109
		public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
		{
			TMPro_EventManager.TEXT_STYLE_PROPERTY_EVENT.Call(isChanged);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000C7F16 File Offset: 0x000C6116
		public static void ON_COLOR_GRAIDENT_PROPERTY_CHANGED(TMP_ColorGradient gradient)
		{
			TMPro_EventManager.COLOR_GRADIENT_PROPERTY_EVENT.Call(gradient);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000C7F23 File Offset: 0x000C6123
		public static void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
			TMPro_EventManager.TEXT_CHANGED_EVENT.Call(obj);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x000C7F30 File Offset: 0x000C6130
		public static void ON_TMP_SETTINGS_CHANGED()
		{
			TMPro_EventManager.TMP_SETTINGS_PROPERTY_EVENT.Call();
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000C7F3C File Offset: 0x000C613C
		public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, TextMeshProUGUI obj)
		{
			TMPro_EventManager.TEXTMESHPRO_UGUI_PROPERTY_EVENT.Call(isChanged, obj);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000C7F4A File Offset: 0x000C614A
		public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e)
		{
			TMPro_EventManager.COMPUTE_DT_EVENT.Call(Sender, e);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000C7F58 File Offset: 0x000C6158
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_EventManager()
		{
			TMPro_EventManager.COMPUTE_DT_EVENT = new FastAction<object, Compute_DT_EventArgs>();
			TMPro_EventManager.MATERIAL_PROPERTY_EVENT = new FastAction<bool, Material>();
			TMPro_EventManager.FONT_PROPERTY_EVENT = new FastAction<bool, TMP_FontAsset>();
			TMPro_EventManager.SPRITE_ASSET_PROPERTY_EVENT = new FastAction<bool, UnityEngine.Object>();
			TMPro_EventManager.TEXTMESHPRO_PROPERTY_EVENT = new FastAction<bool, TextMeshPro>();
			TMPro_EventManager.DRAG_AND_DROP_MATERIAL_EVENT = new FastAction<GameObject, Material, Material>();
			TMPro_EventManager.TEXT_STYLE_PROPERTY_EVENT = new FastAction<bool>();
			TMPro_EventManager.COLOR_GRADIENT_PROPERTY_EVENT = new FastAction<TMP_ColorGradient>();
			TMPro_EventManager.TMP_SETTINGS_PROPERTY_EVENT = new FastAction();
			TMPro_EventManager.TEXTMESHPRO_UGUI_PROPERTY_EVENT = new FastAction<bool, TextMeshProUGUI>();
			TMPro_EventManager.OnPreRenderObject_Event = new FastAction();
			TMPro_EventManager.TEXT_CHANGED_EVENT = new FastAction<UnityEngine.Object>();
		}

		// Token: 0x040029FB RID: 10747
		public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT;

		// Token: 0x040029FC RID: 10748
		public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT;

		// Token: 0x040029FD RID: 10749
		public static readonly FastAction<bool, TMP_FontAsset> FONT_PROPERTY_EVENT;

		// Token: 0x040029FE RID: 10750
		public static readonly FastAction<bool, UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT;

		// Token: 0x040029FF RID: 10751
		public static readonly FastAction<bool, TextMeshPro> TEXTMESHPRO_PROPERTY_EVENT;

		// Token: 0x04002A00 RID: 10752
		public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT;

		// Token: 0x04002A01 RID: 10753
		public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT;

		// Token: 0x04002A02 RID: 10754
		public static readonly FastAction<TMP_ColorGradient> COLOR_GRADIENT_PROPERTY_EVENT;

		// Token: 0x04002A03 RID: 10755
		public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT;

		// Token: 0x04002A04 RID: 10756
		public static readonly FastAction<bool, TextMeshProUGUI> TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		// Token: 0x04002A05 RID: 10757
		public static readonly FastAction OnPreRenderObject_Event;

		// Token: 0x04002A06 RID: 10758
		public static readonly FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT;
	}
}
