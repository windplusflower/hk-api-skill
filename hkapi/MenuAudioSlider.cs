using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// Token: 0x02000481 RID: 1153
public class MenuAudioSlider : MonoBehaviour
{
	// Token: 0x060019FC RID: 6652 RVA: 0x0007D4C3 File Offset: 0x0007B6C3
	private void Start()
	{
		this.gs = GameManager.instance.gameSettings;
		this.UpdateValue();
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x0007D4DC File Offset: 0x0007B6DC
	public void UpdateValue()
	{
		this.textUI.text = this.slider.value.ToString();
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x0007D508 File Offset: 0x0007B708
	public void RefreshValueFromSettings()
	{
		if (this.gs == null)
		{
			this.gs = GameManager.instance.gameSettings;
		}
		if (this.audioSetting == MenuAudioSlider.AudioSettingType.MasterVolume)
		{
			this.slider.value = this.gs.masterVolume;
			this.UpdateValue();
			return;
		}
		if (this.audioSetting == MenuAudioSlider.AudioSettingType.MusicVolume)
		{
			this.slider.value = this.gs.musicVolume;
			this.UpdateValue();
			return;
		}
		if (this.audioSetting == MenuAudioSlider.AudioSettingType.SoundVolume)
		{
			this.slider.value = this.gs.soundVolume;
			this.UpdateValue();
		}
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0007D59D File Offset: 0x0007B79D
	public void UpdateTextValue(float value)
	{
		this.textUI.text = value.ToString();
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x0007D5B4 File Offset: 0x0007B7B4
	public void SetMasterLevel(float masterLevel)
	{
		float num;
		if (masterLevel > 9f)
		{
			num = 0f;
		}
		else
		{
			num = this.GetVolumeLevel(masterLevel);
		}
		this.masterMixer.SetFloat("MasterVolume", num);
		this.gs.masterVolume = masterLevel;
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x0007D5F8 File Offset: 0x0007B7F8
	public void SetMusicLevel(float musicLevel)
	{
		float num;
		if (musicLevel > 9f)
		{
			num = 0f;
		}
		else
		{
			num = this.GetVolumeLevel(musicLevel);
		}
		this.masterMixer.SetFloat("MusicVolume", num);
		this.gs.musicVolume = musicLevel;
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x0007D63C File Offset: 0x0007B83C
	public void SetSoundLevel(float soundLevel)
	{
		float num;
		if (soundLevel > 9f)
		{
			num = 0f;
		}
		else
		{
			num = this.GetVolumeLevel(soundLevel);
		}
		this.masterMixer.SetFloat("SFXVolume", num);
		this.gs.soundVolume = soundLevel;
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x0007D67F File Offset: 0x0007B87F
	private float GetVolumeLevel(float x)
	{
		return -1.02f * (x * x) + 17.5f * x - 76.6f;
	}

	// Token: 0x04001F61 RID: 8033
	public Slider slider;

	// Token: 0x04001F62 RID: 8034
	public Text textUI;

	// Token: 0x04001F63 RID: 8035
	public AudioMixer masterMixer;

	// Token: 0x04001F64 RID: 8036
	public MenuAudioSlider.AudioSettingType audioSetting;

	// Token: 0x04001F65 RID: 8037
	private GameSettings gs;

	// Token: 0x04001F66 RID: 8038
	[SerializeField]
	private float value;

	// Token: 0x02000482 RID: 1154
	public enum AudioSettingType
	{
		// Token: 0x04001F68 RID: 8040
		MasterVolume,
		// Token: 0x04001F69 RID: 8041
		MusicVolume,
		// Token: 0x04001F6A RID: 8042
		SoundVolume
	}
}
