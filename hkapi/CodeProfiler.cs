using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000412 RID: 1042
public class CodeProfiler : MonoBehaviour
{
	// Token: 0x0600178E RID: 6030 RVA: 0x0006F400 File Offset: 0x0006D600
	private void Awake()
	{
		this.startTime = Time.time;
		this.displayText = "\n\nTaking initial readings...";
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x0006F418 File Offset: 0x0006D618
	private void OnGUI()
	{
		GUI.Box(this.displayRect, "Code Profiler");
		GUI.Label(this.displayRect, this.displayText);
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0006F43B File Offset: 0x0006D63B
	public static void Begin(string id)
	{
		if (!CodeProfiler.recordings.ContainsKey(id))
		{
			CodeProfiler.recordings[id] = new ProfilerRecording(id);
		}
		CodeProfiler.recordings[id].Start();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0006F46B File Offset: 0x0006D66B
	public static void End(string id)
	{
		CodeProfiler.recordings[id].Stop();
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x0006F480 File Offset: 0x0006D680
	private void Update()
	{
		this.numFrames++;
		if (Time.time > this.nextOutputTime)
		{
			int totalWidth = 10;
			this.displayText = "\n\n";
			float num = (Time.time - this.startTime) * 1000f;
			float num2 = num / (float)this.numFrames;
			float num3 = 1000f / (num / (float)this.numFrames);
			this.displayText += "Avg frame time: ";
			this.displayText = this.displayText + num2.ToString("0.#") + "ms, ";
			this.displayText = this.displayText + num3.ToString("0.#") + " fps \n";
			this.displayText += "Total".PadRight(totalWidth);
			this.displayText += "MS/frame".PadRight(totalWidth);
			this.displayText += "Calls/fra".PadRight(totalWidth);
			this.displayText += "MS/call".PadRight(totalWidth);
			this.displayText += "Label";
			this.displayText += "\n";
			foreach (KeyValuePair<string, ProfilerRecording> keyValuePair in CodeProfiler.recordings)
			{
				ProfilerRecording value = keyValuePair.Value;
				float num4 = value.Seconds * 1000f;
				float num5 = num4 * 100f / num;
				float num6 = num4 / (float)this.numFrames;
				float num7 = num4 / (float)value.Count;
				float num8 = (float)value.Count / (float)this.numFrames;
				this.displayText += (num5.ToString("0.000") + "%").PadRight(totalWidth);
				this.displayText += (num6.ToString("0.000") + "ms").PadRight(totalWidth);
				this.displayText += num8.ToString("0.000").PadRight(totalWidth);
				this.displayText += (num7.ToString("0.0000") + "ms").PadRight(totalWidth);
				this.displayText += value.id;
				this.displayText += "\n";
				value.Reset();
			}
			Debug.Log(this.displayText);
			this.numFrames = 0;
			this.startTime = Time.time;
			this.nextOutputTime = Time.time + 5f;
		}
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x0006F784 File Offset: 0x0006D984
	public CodeProfiler()
	{
		this.nextOutputTime = 5f;
		this.displayRect = new Rect(10f, 10f, 460f, 300f);
		base..ctor();
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x0006F7B6 File Offset: 0x0006D9B6
	// Note: this type is marked as 'beforefieldinit'.
	static CodeProfiler()
	{
		CodeProfiler.recordings = new Dictionary<string, ProfilerRecording>();
	}

	// Token: 0x04001C50 RID: 7248
	private float startTime;

	// Token: 0x04001C51 RID: 7249
	private float nextOutputTime;

	// Token: 0x04001C52 RID: 7250
	private int numFrames;

	// Token: 0x04001C53 RID: 7251
	private static Dictionary<string, ProfilerRecording> recordings;

	// Token: 0x04001C54 RID: 7252
	private string displayText;

	// Token: 0x04001C55 RID: 7253
	private Rect displayRect;
}
