using System;
using System.Collections.Generic;
using GlobalEnums;
using UnityEngine;

namespace TeamCherry
{
	// Token: 0x0200065F RID: 1631
	[Serializable]
	public class SceneDefaultSettings : ScriptableObject
	{
		// Token: 0x06002779 RID: 10105 RVA: 0x000DF08A File Offset: 0x000DD28A
		public void OnEnable()
		{
			if (this.settingsList == null)
			{
				this.settingsList = new List<SceneManagerSettings>();
			}
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000DF0A0 File Offset: 0x000DD2A0
		public SceneManagerSettings GetMapZoneSettings(MapZone mapZone)
		{
			foreach (SceneManagerSettings sceneManagerSettings in this.settingsList)
			{
				if (sceneManagerSettings.mapZone == mapZone)
				{
					return sceneManagerSettings;
				}
			}
			return null;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000DF0FC File Offset: 0x000DD2FC
		public SceneManagerSettings GetCurrentMapZoneSettings()
		{
			return this.GetMapZoneSettings((MapZone)this.selection);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000DF10C File Offset: 0x000DD30C
		public void SaveSettings(SceneManagerSettings sms)
		{
			SceneManagerSettings mapZoneSettings = this.GetMapZoneSettings(sms.mapZone);
			if (mapZoneSettings != null)
			{
				mapZoneSettings.defaultColor = new Color(sms.defaultColor.r, sms.defaultColor.g, sms.defaultColor.b, sms.defaultColor.a);
				mapZoneSettings.defaultIntensity = sms.defaultIntensity;
				mapZoneSettings.saturation = sms.saturation;
				mapZoneSettings.redChannel = new AnimationCurve(sms.redChannel.keys.Clone() as Keyframe[]);
				mapZoneSettings.greenChannel = new AnimationCurve(sms.greenChannel.keys.Clone() as Keyframe[]);
				mapZoneSettings.blueChannel = new AnimationCurve(sms.blueChannel.keys.Clone() as Keyframe[]);
				mapZoneSettings.heroLightColor = new Color(sms.heroLightColor.r, sms.heroLightColor.g, sms.heroLightColor.b, sms.heroLightColor.a);
				return;
			}
			this.settingsList.Add(new SceneManagerSettings(sms.mapZone, new Color(sms.defaultColor.r, sms.defaultColor.g, sms.defaultColor.b), sms.defaultIntensity, sms.saturation, new AnimationCurve(sms.redChannel.keys.Clone() as Keyframe[]), new AnimationCurve(sms.greenChannel.keys.Clone() as Keyframe[]), new AnimationCurve(sms.blueChannel.keys.Clone() as Keyframe[]), new Color(sms.heroLightColor.r, sms.heroLightColor.g, sms.heroLightColor.b, sms.heroLightColor.a)));
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000DF2DA File Offset: 0x000DD4DA
		public MapZone GetCurrentSelection()
		{
			return (MapZone)this.selection;
		}

		// Token: 0x04002B84 RID: 11140
		[SerializeField]
		public int selection;

		// Token: 0x04002B85 RID: 11141
		[SerializeField]
		public List<SceneManagerSettings> settingsList;
	}
}
