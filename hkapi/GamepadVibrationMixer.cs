using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000372 RID: 882
public class GamepadVibrationMixer : VibrationMixer
{
	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06001410 RID: 5136 RVA: 0x00059A59 File Offset: 0x00057C59
	// (set) Token: 0x06001411 RID: 5137 RVA: 0x00059A61 File Offset: 0x00057C61
	public override bool IsPaused
	{
		get
		{
			return this.isPaused;
		}
		set
		{
			this.isPaused = value;
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06001412 RID: 5138 RVA: 0x00059A6A File Offset: 0x00057C6A
	public override int PlayingEmissionCount
	{
		get
		{
			return this.playingEmissions.Count;
		}
	}

	// Token: 0x06001413 RID: 5139 RVA: 0x00059A77 File Offset: 0x00057C77
	public override VibrationEmission GetPlayingEmission(int playingEmissionIndex)
	{
		return this.playingEmissions[playingEmissionIndex];
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00059A85 File Offset: 0x00057C85
	public GamepadVibrationMixer(GamepadVibrationMixer.PlatformAdjustments platformAdjustment = GamepadVibrationMixer.PlatformAdjustments.None)
	{
		this.platformAdjustment = platformAdjustment;
		this.playingEmissions = new List<GamepadVibrationMixer.GamepadVibrationEmission>();
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00059AA0 File Offset: 0x00057CA0
	public override VibrationEmission PlayEmission(VibrationData vibrationData, VibrationTarget vibrationTarget, bool isLooping, string tag)
	{
		if (vibrationData.GamepadVibration == null)
		{
			return new UnsupportedVibrationEmission(vibrationTarget, isLooping, tag);
		}
		GamepadVibrationMixer.GamepadVibrationEmission gamepadVibrationEmission = new GamepadVibrationMixer.GamepadVibrationEmission(this, vibrationData.GamepadVibration, isLooping, tag, vibrationTarget);
		this.playingEmissions.Add(gamepadVibrationEmission);
		return gamepadVibrationEmission;
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x00059AE8 File Offset: 0x00057CE8
	public override void StopAllEmissions()
	{
		for (int i = 0; i < this.playingEmissions.Count; i++)
		{
			this.playingEmissions[i].Stop();
		}
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00059B1C File Offset: 0x00057D1C
	public override void StopAllEmissionsWithTag(string tag)
	{
		for (int i = 0; i < this.playingEmissions.Count; i++)
		{
			GamepadVibrationMixer.GamepadVibrationEmission gamepadVibrationEmission = this.playingEmissions[i];
			if (gamepadVibrationEmission.Tag == tag)
			{
				gamepadVibrationEmission.Stop();
			}
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06001418 RID: 5144 RVA: 0x00059B60 File Offset: 0x00057D60
	public GamepadVibrationMixer.GamepadVibrationEmission.Values CurrentValues
	{
		get
		{
			return this.currentValues;
		}
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x00059B68 File Offset: 0x00057D68
	public void Update(float deltaTime)
	{
		GamepadVibrationMixer.GamepadVibrationEmission.Values values = new GamepadVibrationMixer.GamepadVibrationEmission.Values
		{
			Small = 0f,
			Large = 0f
		};
		bool flag = deltaTime < 1E-05f;
		if (!this.isPaused && !flag)
		{
			for (int i = 0; i < this.playingEmissions.Count; i++)
			{
				if (!this.playingEmissions[i].IsPlaying)
				{
					this.playingEmissions.RemoveAt(i--);
				}
			}
			for (int j = 0; j < this.playingEmissions.Count; j++)
			{
				GamepadVibrationMixer.GamepadVibrationEmission gamepadVibrationEmission = this.playingEmissions[j];
				GamepadVibrationMixer.GamepadVibrationEmission.Values values2 = gamepadVibrationEmission.GetCurrentValues();
				values.Small = this.AdjustForPlatform(Mathf.Max(values.Small, values2.Small));
				values.Large = this.AdjustForPlatform(Mathf.Max(values.Large, values2.Large));
				gamepadVibrationEmission.Advance(deltaTime);
			}
		}
		this.currentValues = values;
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00059C64 File Offset: 0x00057E64
	private float AdjustForPlatform(float val)
	{
		if (this.platformAdjustment == GamepadVibrationMixer.PlatformAdjustments.DualShock)
		{
			float b = Mathf.Clamp01(Mathf.Sin(val * 3.1415927f * 0.5f));
			val = Mathf.Lerp(val, b, 1f);
		}
		return val * ConfigManager.ControllerRumbleMultiplier;
	}

	// Token: 0x040012DD RID: 4829
	private bool isPaused;

	// Token: 0x040012DE RID: 4830
	private List<GamepadVibrationMixer.GamepadVibrationEmission> playingEmissions;

	// Token: 0x040012DF RID: 4831
	private GamepadVibrationMixer.PlatformAdjustments platformAdjustment;

	// Token: 0x040012E0 RID: 4832
	private GamepadVibrationMixer.GamepadVibrationEmission.Values currentValues;

	// Token: 0x02000373 RID: 883
	public class GamepadVibrationEmission : VibrationEmission
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00059CA9 File Offset: 0x00057EA9
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00059CB1 File Offset: 0x00057EB1
		public override bool IsLooping
		{
			get
			{
				return this.isLooping;
			}
			set
			{
				this.isLooping = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00059CBA File Offset: 0x00057EBA
		public override bool IsPlaying
		{
			get
			{
				return this.isPlaying;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00059CC2 File Offset: 0x00057EC2
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x00059CCA File Offset: 0x00057ECA
		public override string Tag
		{
			get
			{
				return this.tag;
			}
			set
			{
				this.tag = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x00059CD3 File Offset: 0x00057ED3
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x00059CDB File Offset: 0x00057EDB
		public override VibrationTarget Target
		{
			get
			{
				return this.target;
			}
			set
			{
				this.target = value;
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00059CE4 File Offset: 0x00057EE4
		public GamepadVibrationEmission(GamepadVibrationMixer mixer, GamepadVibration gamepadVibration, bool isLooping, string tag, VibrationTarget target)
		{
			this.mixer = mixer;
			this.gamepadVibration = gamepadVibration;
			this.duration = gamepadVibration.GetDuration();
			this.isLooping = isLooping;
			this.isPlaying = true;
			this.tag = tag;
			this.target = target;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00059D24 File Offset: 0x00057F24
		public override void Stop()
		{
			this.isPlaying = false;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00059D30 File Offset: 0x00057F30
		public GamepadVibrationMixer.GamepadVibrationEmission.Values GetCurrentValues()
		{
			return new GamepadVibrationMixer.GamepadVibrationEmission.Values
			{
				Small = ((this.target.Motors != VibrationMotors.None) ? this.gamepadVibration.SmallMotor.Evaluate(this.timer) : 0f),
				Large = ((this.target.Motors != VibrationMotors.None) ? this.gamepadVibration.LargeMotor.Evaluate(this.timer) : 0f)
			};
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x00059DA8 File Offset: 0x00057FA8
		public void Advance(float deltaTime)
		{
			this.timer += deltaTime * this.gamepadVibration.PlaybackRate;
			if (this.timer >= this.duration)
			{
				if (this.isLooping)
				{
					this.timer = Mathf.Repeat(this.timer, this.duration);
					return;
				}
				this.isPlaying = false;
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x00059E04 File Offset: 0x00058004
		public override string ToString()
		{
			if (!(this.gamepadVibration != null))
			{
				return "null";
			}
			return this.gamepadVibration.name;
		}

		// Token: 0x040012E1 RID: 4833
		private GamepadVibrationMixer mixer;

		// Token: 0x040012E2 RID: 4834
		private GamepadVibration gamepadVibration;

		// Token: 0x040012E3 RID: 4835
		private float duration;

		// Token: 0x040012E4 RID: 4836
		private bool isLooping;

		// Token: 0x040012E5 RID: 4837
		private bool isPlaying;

		// Token: 0x040012E6 RID: 4838
		private string tag;

		// Token: 0x040012E7 RID: 4839
		private VibrationTarget target;

		// Token: 0x040012E8 RID: 4840
		private float timer;

		// Token: 0x02000374 RID: 884
		public struct Values
		{
			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06001427 RID: 5159 RVA: 0x00059E25 File Offset: 0x00058025
			public bool IsNearlyZero
			{
				get
				{
					return this.Small < Mathf.Epsilon && this.Large < Mathf.Epsilon;
				}
			}

			// Token: 0x040012E9 RID: 4841
			public float Small;

			// Token: 0x040012EA RID: 4842
			public float Large;
		}
	}

	// Token: 0x02000375 RID: 885
	public enum PlatformAdjustments
	{
		// Token: 0x040012EC RID: 4844
		None,
		// Token: 0x040012ED RID: 4845
		DualShock
	}
}
