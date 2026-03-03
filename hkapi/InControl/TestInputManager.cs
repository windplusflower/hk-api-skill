using System;
using System.Collections.Generic;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000738 RID: 1848
	public class TestInputManager : MonoBehaviour
	{
		// Token: 0x06002E6B RID: 11883 RVA: 0x000F67FC File Offset: 0x000F49FC
		private void OnEnable()
		{
			Application.targetFrameRate = -1;
			QualitySettings.vSyncCount = 0;
			this.isPaused = false;
			Time.timeScale = 1f;
			Logger.OnLogMessage += delegate(LogMessage logMessage)
			{
				this.logMessages.Add(logMessage);
			};
			InputManager.OnDeviceAttached += delegate(InputDevice inputDevice)
			{
				Debug.Log("Attached: " + inputDevice.Name);
			};
			InputManager.OnDeviceDetached += delegate(InputDevice inputDevice)
			{
				Debug.Log("Detached: " + inputDevice.Name);
			};
			InputManager.OnActiveDeviceChanged += delegate(InputDevice inputDevice)
			{
				Debug.Log("Active device changed to: " + inputDevice.Name);
			};
			InputManager.OnUpdate += this.HandleInputUpdate;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000F68B4 File Offset: 0x000F4AB4
		private void HandleInputUpdate(ulong updateTick, float deltaTime)
		{
			this.CheckForPauseButton();
			int count = InputManager.Devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputDevice inputDevice = InputManager.Devices[i];
				inputDevice.Vibrate(inputDevice.LeftTrigger, inputDevice.RightTrigger);
				Color color = Color.HSVToRGB(Mathf.Repeat(Time.realtimeSinceStartup, 1f), 1f, 1f);
				inputDevice.SetLightColor(color.r, color.g, color.b);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00003603 File Offset: 0x00001803
		private void Start()
		{
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000F693D File Offset: 0x000F4B3D
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.R))
			{
				Utility.LoadScene("TestInputManager");
			}
			if (Input.GetKeyDown(KeyCode.E))
			{
				InputManager.Enabled = !InputManager.Enabled;
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000F6968 File Offset: 0x000F4B68
		private void CheckForPauseButton()
		{
			if (Input.GetKeyDown(KeyCode.P) || InputManager.CommandWasPressed)
			{
				Time.timeScale = (this.isPaused ? 1f : 0f);
				this.isPaused = !this.isPaused;
			}
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000F69A2 File Offset: 0x000F4BA2
		private void SetColor(Color color)
		{
			this.style.normal.textColor = color;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000F69B8 File Offset: 0x000F4BB8
		private void OnGUI()
		{
			int num = Mathf.FloorToInt((float)(Screen.width / Mathf.Max(1, InputManager.Devices.Count)));
			int num2 = 10;
			int num3 = 10;
			GUI.skin.font = this.font;
			this.SetColor(Color.white);
			string text = "Devices:";
			text = text + " (Platform: " + InputManager.Platform + ")";
			text = text + " " + InputManager.ActiveDevice.Direction.Vector.ToString();
			if (this.isPaused)
			{
				this.SetColor(Color.red);
				text = "+++ PAUSED +++";
			}
			GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text, this.style);
			this.SetColor(Color.white);
			foreach (InputDevice inputDevice in InputManager.Devices)
			{
				Color color = inputDevice.IsActive ? new Color(0.9f, 0.7f, 0.2f) : Color.white;
				bool flag = InputManager.ActiveDevice == inputDevice;
				if (flag)
				{
					color = new Color(1f, 0.9f, 0f);
				}
				num3 = 35;
				if (inputDevice.IsUnknown)
				{
					this.SetColor(Color.red);
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "Unknown Device", this.style);
				}
				else
				{
					this.SetColor(color);
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), inputDevice.Name, this.style);
				}
				num3 += 15;
				this.SetColor(color);
				if (inputDevice.IsUnknown)
				{
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), inputDevice.Meta, this.style);
					num3 += 15;
				}
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "Style: " + inputDevice.DeviceStyle.ToString(), this.style);
				num3 += 15;
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "GUID: " + inputDevice.GUID.ToString(), this.style);
				num3 += 15;
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "SortOrder: " + inputDevice.SortOrder.ToString(), this.style);
				num3 += 15;
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "LastInputTick: " + inputDevice.LastInputTick.ToString(), this.style);
				num3 += 15;
				NativeInputDevice nativeInputDevice = inputDevice as NativeInputDevice;
				if (nativeInputDevice != null)
				{
					string text2 = string.Format("VID = 0x{0:x}, PID = 0x{1:x}, VER = 0x{2:x}", nativeInputDevice.Info.vendorID, nativeInputDevice.Info.productID, nativeInputDevice.Info.versionNumber);
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text2, this.style);
					num3 += 15;
				}
				num3 += 15;
				foreach (InputControl inputControl in inputDevice.Controls)
				{
					if (inputControl != null && !Utility.TargetIsAlias(inputControl.Target))
					{
						string arg = (inputDevice.IsKnown && nativeInputDevice != null) ? nativeInputDevice.GetAppleGlyphNameForControl(inputControl.Target) : "";
						string arg2 = inputDevice.IsKnown ? string.Format("{0} ({1}) {2}", inputControl.Target, inputControl.Handle, arg) : inputControl.Handle;
						this.SetColor(inputControl.State ? Color.green : color);
						string text3 = string.Format("{0} {1}", arg2, inputControl.State ? ("= " + inputControl.Value.ToString()) : "");
						GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text3, this.style);
						num3 += 15;
					}
				}
				num3 += 15;
				color = (flag ? new Color(0.85f, 0.65f, 0.12f) : Color.white);
				if (inputDevice.IsKnown)
				{
					InputControl inputControl2 = inputDevice.Command;
					this.SetColor(inputControl2.State ? Color.green : color);
					string text4 = string.Format("{0} {1}", "Command", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.LeftCommand;
					this.SetColor(inputControl2.State ? Color.green : color);
					string arg3 = inputDevice.IsKnown ? string.Format("{0} ({1})", inputControl2.Target, inputControl2.Handle) : inputControl2.Handle;
					text4 = string.Format("{0} {1}", arg3, inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.RightCommand;
					this.SetColor(inputControl2.State ? Color.green : color);
					arg3 = (inputDevice.IsKnown ? string.Format("{0} ({1})", inputControl2.Target, inputControl2.Handle) : inputControl2.Handle);
					text4 = string.Format("{0} {1}", arg3, inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.LeftStickX;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Left Stick X", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.LeftStickY;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Left Stick Y", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					this.SetColor(inputDevice.LeftStick.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Left Stick A", inputDevice.LeftStick.State ? ("= " + inputDevice.LeftStick.Angle.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.RightStickX;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Right Stick X", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.RightStickY;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Right Stick Y", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					this.SetColor(inputDevice.RightStick.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "Right Stick A", inputDevice.RightStick.State ? ("= " + inputDevice.RightStick.Angle.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.DPadX;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "DPad X", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
					inputControl2 = inputDevice.DPadY;
					this.SetColor(inputControl2.State ? Color.green : color);
					text4 = string.Format("{0} {1}", "DPad Y", inputControl2.State ? ("= " + inputControl2.Value.ToString()) : "");
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text4, this.style);
					num3 += 15;
				}
				this.SetColor(Color.cyan);
				InputControl anyButton = inputDevice.AnyButton;
				if (anyButton)
				{
					GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), "AnyButton = " + anyButton.Handle, this.style);
				}
				num2 += num;
			}
			Color[] array = new Color[]
			{
				Color.gray,
				Color.yellow,
				Color.white
			};
			this.SetColor(Color.white);
			num2 = 10;
			num3 = Screen.height - 25;
			for (int i = this.logMessages.Count - 1; i >= 0; i--)
			{
				LogMessage logMessage = this.logMessages[i];
				if (logMessage.type != LogMessageType.Info)
				{
					this.SetColor(array[(int)logMessage.type]);
					foreach (string text5 in logMessage.text.Split(new char[]
					{
						'\n'
					}))
					{
						GUI.Label(new Rect((float)num2, (float)num3, (float)Screen.width, (float)(num3 + 10)), text5, this.style);
						num3 -= 15;
					}
				}
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000F75C4 File Offset: 0x000F57C4
		private void DrawUnityInputDebugger()
		{
			int num = 300;
			int num2 = Screen.width / 2;
			int num3 = 10;
			int num4 = 20;
			this.SetColor(Color.white);
			string[] joystickNames = Input.GetJoystickNames();
			int num5 = joystickNames.Length;
			for (int i = 0; i < num5; i++)
			{
				string text = joystickNames[i];
				int num6 = i + 1;
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), string.Concat(new string[]
				{
					"Joystick ",
					num6.ToString(),
					": \"",
					text,
					"\""
				}), this.style);
				num3 += num4;
				string text2 = "Buttons: ";
				for (int j = 0; j < 20; j++)
				{
					if (Input.GetKey("joystick " + num6.ToString() + " button " + j.ToString()))
					{
						text2 = text2 + "B" + j.ToString() + "  ";
					}
				}
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text2, this.style);
				num3 += num4;
				string text3 = "Analogs: ";
				for (int k = 0; k < 20; k++)
				{
					float axisRaw = Input.GetAxisRaw("joystick " + num6.ToString() + " analog " + k.ToString());
					if (Utility.AbsoluteIsOverThreshold(axisRaw, 0.2f))
					{
						text3 = string.Concat(new string[]
						{
							text3,
							"A",
							k.ToString(),
							": ",
							axisRaw.ToString("0.00"),
							"  "
						});
					}
				}
				GUI.Label(new Rect((float)num2, (float)num3, (float)(num2 + num), (float)(num3 + 10)), text3, this.style);
				num3 += num4;
				num3 += 25;
			}
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000F77A8 File Offset: 0x000F59A8
		private void OnDrawGizmos()
		{
			InputDevice activeDevice = InputManager.ActiveDevice;
			Vector2 vector = activeDevice.Direction.Vector;
			Gizmos.color = Color.blue;
			Vector2 vector2 = new Vector2(-3f, -1f);
			Vector2 v = vector2 + vector * 2f;
			Gizmos.DrawSphere(vector2, 0.1f);
			Gizmos.DrawLine(vector2, v);
			Gizmos.DrawSphere(v, 1f);
			Gizmos.color = Color.red;
			Vector2 vector3 = new Vector2(3f, -1f);
			Vector2 v2 = vector3 + activeDevice.RightStick.Vector * 2f;
			Gizmos.DrawSphere(vector3, 0.1f);
			Gizmos.DrawLine(vector3, v2);
			Gizmos.DrawSphere(v2, 1f);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000F7887 File Offset: 0x000F5A87
		public TestInputManager()
		{
			this.style = new GUIStyle();
			this.logMessages = new List<LogMessage>();
			base..ctor();
		}

		// Token: 0x040032EF RID: 13039
		public Font font;

		// Token: 0x040032F0 RID: 13040
		private readonly GUIStyle style;

		// Token: 0x040032F1 RID: 13041
		private readonly List<LogMessage> logMessages;

		// Token: 0x040032F2 RID: 13042
		private bool isPaused;
	}
}
