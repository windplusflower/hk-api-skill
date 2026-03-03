using System;
using System.IO;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CFC RID: 3324
	[ActionCategory(ActionCategory.Application)]
	[Tooltip("Saves a Screenshot. NOTE: Does nothing in Web Player. On Android, the resulting screenshot is available some time later.")]
	public class TakeScreenshot : FsmStateAction
	{
		// Token: 0x0600450A RID: 17674 RVA: 0x00177F32 File Offset: 0x00176132
		public override void Reset()
		{
			this.destination = TakeScreenshot.Destination.MyPictures;
			this.filename = "";
			this.autoNumber = null;
			this.superSize = null;
			this.debugLog = null;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00177F60 File Offset: 0x00176160
		public override void OnEnter()
		{
			if (string.IsNullOrEmpty(this.filename.Value))
			{
				return;
			}
			string text;
			switch (this.destination)
			{
			case TakeScreenshot.Destination.MyPictures:
				text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				break;
			case TakeScreenshot.Destination.PersistentDataPath:
				text = Application.persistentDataPath;
				break;
			case TakeScreenshot.Destination.CustomPath:
				text = this.customPath.Value;
				break;
			default:
				text = "";
				break;
			}
			text = text.Replace("\\", "/") + "/";
			string text2 = text + this.filename.Value + ".png";
			if (this.autoNumber.Value)
			{
				while (File.Exists(text2))
				{
					this.screenshotCount++;
					text2 = text + this.filename.Value + this.screenshotCount.ToString() + ".png";
				}
			}
			if (this.debugLog.Value)
			{
				Debug.Log("TakeScreenshot: " + text2);
			}
			ScreenCapture.CaptureScreenshot(text2, this.superSize.Value);
			base.Finish();
		}

		// Token: 0x0400495F RID: 18783
		[Tooltip("Where to save the screenshot.")]
		public TakeScreenshot.Destination destination;

		// Token: 0x04004960 RID: 18784
		[Tooltip("Path used with Custom Path Destination option.")]
		public FsmString customPath;

		// Token: 0x04004961 RID: 18785
		[RequiredField]
		public FsmString filename;

		// Token: 0x04004962 RID: 18786
		[Tooltip("Add an auto-incremented number to the filename.")]
		public FsmBool autoNumber;

		// Token: 0x04004963 RID: 18787
		[Tooltip("Factor by which to increase resolution.")]
		public FsmInt superSize;

		// Token: 0x04004964 RID: 18788
		[Tooltip("Log saved file info in Unity console.")]
		public FsmBool debugLog;

		// Token: 0x04004965 RID: 18789
		private int screenshotCount;

		// Token: 0x02000CFD RID: 3325
		public enum Destination
		{
			// Token: 0x04004967 RID: 18791
			MyPictures,
			// Token: 0x04004968 RID: 18792
			PersistentDataPath,
			// Token: 0x04004969 RID: 18793
			CustomPath
		}
	}
}
