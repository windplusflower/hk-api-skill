using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200060D RID: 1549
	[Serializable]
	public class TMP_StyleSheet : ScriptableObject
	{
		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000BC0EC File Offset: 0x000BA2EC
		public static TMP_StyleSheet instance
		{
			get
			{
				if (TMP_StyleSheet.s_Instance == null)
				{
					TMP_StyleSheet.s_Instance = TMP_Settings.defaultStyleSheet;
					if (TMP_StyleSheet.s_Instance == null)
					{
						TMP_StyleSheet.s_Instance = (Resources.Load("Style Sheets/TMP Default Style Sheet") as TMP_StyleSheet);
					}
					if (TMP_StyleSheet.s_Instance == null)
					{
						return null;
					}
					TMP_StyleSheet.s_Instance.LoadStyleDictionaryInternal();
				}
				return TMP_StyleSheet.s_Instance;
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000BC14F File Offset: 0x000BA34F
		public static TMP_StyleSheet LoadDefaultStyleSheet()
		{
			return TMP_StyleSheet.instance;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000BC156 File Offset: 0x000BA356
		public static TMP_Style GetStyle(int hashCode)
		{
			return TMP_StyleSheet.instance.GetStyleInternal(hashCode);
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000BC164 File Offset: 0x000BA364
		private TMP_Style GetStyleInternal(int hashCode)
		{
			TMP_Style result;
			if (this.m_StyleDictionary.TryGetValue(hashCode, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x000BC184 File Offset: 0x000BA384
		public void UpdateStyleDictionaryKey(int old_key, int new_key)
		{
			if (this.m_StyleDictionary.ContainsKey(old_key))
			{
				TMP_Style value = this.m_StyleDictionary[old_key];
				this.m_StyleDictionary.Add(new_key, value);
				this.m_StyleDictionary.Remove(old_key);
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x000BC1C6 File Offset: 0x000BA3C6
		public static void RefreshStyles()
		{
			TMP_StyleSheet.s_Instance.LoadStyleDictionaryInternal();
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000BC1D4 File Offset: 0x000BA3D4
		private void LoadStyleDictionaryInternal()
		{
			this.m_StyleDictionary.Clear();
			for (int i = 0; i < this.m_StyleList.Count; i++)
			{
				this.m_StyleList[i].RefreshStyle();
				if (!this.m_StyleDictionary.ContainsKey(this.m_StyleList[i].hashCode))
				{
					this.m_StyleDictionary.Add(this.m_StyleList[i].hashCode, this.m_StyleList[i]);
				}
			}
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000BC259 File Offset: 0x000BA459
		public TMP_StyleSheet()
		{
			this.m_StyleList = new List<TMP_Style>(1);
			this.m_StyleDictionary = new Dictionary<int, TMP_Style>();
			base..ctor();
		}

		// Token: 0x040028A2 RID: 10402
		private static TMP_StyleSheet s_Instance;

		// Token: 0x040028A3 RID: 10403
		[SerializeField]
		private List<TMP_Style> m_StyleList;

		// Token: 0x040028A4 RID: 10404
		private Dictionary<int, TMP_Style> m_StyleDictionary;
	}
}
