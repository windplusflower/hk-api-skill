using System;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x02000734 RID: 1844
	public static class Utility
	{
		// Token: 0x06002E1A RID: 11802 RVA: 0x000F5240 File Offset: 0x000F3440
		public static void DrawCircleGizmo(Vector2 center, float radius)
		{
			Vector2 v = Utility.circleVertexList[0] * radius + center;
			int num = Utility.circleVertexList.Length;
			for (int i = 1; i < num; i++)
			{
				Gizmos.DrawLine(v, v = Utility.circleVertexList[i] * radius + center);
			}
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000F52A2 File Offset: 0x000F34A2
		public static void DrawCircleGizmo(Vector2 center, float radius, Color color)
		{
			Gizmos.color = color;
			Utility.DrawCircleGizmo(center, radius);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000F52B4 File Offset: 0x000F34B4
		public static void DrawOvalGizmo(Vector2 center, Vector2 size)
		{
			Vector2 b = size / 2f;
			Vector2 v = Vector2.Scale(Utility.circleVertexList[0], b) + center;
			int num = Utility.circleVertexList.Length;
			for (int i = 1; i < num; i++)
			{
				Gizmos.DrawLine(v, v = Vector2.Scale(Utility.circleVertexList[i], b) + center);
			}
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000F5322 File Offset: 0x000F3522
		public static void DrawOvalGizmo(Vector2 center, Vector2 size, Color color)
		{
			Gizmos.color = color;
			Utility.DrawOvalGizmo(center, size);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000F5334 File Offset: 0x000F3534
		public static void DrawRectGizmo(Rect rect)
		{
			Vector3 vector = new Vector3(rect.xMin, rect.yMin);
			Vector3 vector2 = new Vector3(rect.xMax, rect.yMin);
			Vector3 vector3 = new Vector3(rect.xMax, rect.yMax);
			Vector3 vector4 = new Vector3(rect.xMin, rect.yMax);
			Gizmos.DrawLine(vector, vector2);
			Gizmos.DrawLine(vector2, vector3);
			Gizmos.DrawLine(vector3, vector4);
			Gizmos.DrawLine(vector4, vector);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000F53B1 File Offset: 0x000F35B1
		public static void DrawRectGizmo(Rect rect, Color color)
		{
			Gizmos.color = color;
			Utility.DrawRectGizmo(rect);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000F53C0 File Offset: 0x000F35C0
		public static void DrawRectGizmo(Vector2 center, Vector2 size)
		{
			float num = size.x / 2f;
			float num2 = size.y / 2f;
			Vector3 vector = new Vector3(center.x - num, center.y - num2);
			Vector3 vector2 = new Vector3(center.x + num, center.y - num2);
			Vector3 vector3 = new Vector3(center.x + num, center.y + num2);
			Vector3 vector4 = new Vector3(center.x - num, center.y + num2);
			Gizmos.DrawLine(vector, vector2);
			Gizmos.DrawLine(vector2, vector3);
			Gizmos.DrawLine(vector3, vector4);
			Gizmos.DrawLine(vector4, vector);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000F5463 File Offset: 0x000F3663
		public static void DrawRectGizmo(Vector2 center, Vector2 size, Color color)
		{
			Gizmos.color = color;
			Utility.DrawRectGizmo(center, size);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000F5472 File Offset: 0x000F3672
		public static bool GameObjectIsCulledOnCurrentCamera(GameObject gameObject)
		{
			return (Camera.current.cullingMask & 1 << gameObject.layer) == 0;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000F5490 File Offset: 0x000F3690
		public static Color MoveColorTowards(Color color0, Color color1, float maxDelta)
		{
			float r = Mathf.MoveTowards(color0.r, color1.r, maxDelta);
			float g = Mathf.MoveTowards(color0.g, color1.g, maxDelta);
			float b = Mathf.MoveTowards(color0.b, color1.b, maxDelta);
			float a = Mathf.MoveTowards(color0.a, color1.a, maxDelta);
			return new Color(r, g, b, a);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000F54F0 File Offset: 0x000F36F0
		public static float ApplyDeadZone(float value, float lowerDeadZone, float upperDeadZone)
		{
			float num = upperDeadZone - lowerDeadZone;
			if (value < 0f)
			{
				if (value > -lowerDeadZone)
				{
					return 0f;
				}
				if (value < -upperDeadZone)
				{
					return -1f;
				}
				return (value + lowerDeadZone) / num;
			}
			else
			{
				if (value < lowerDeadZone)
				{
					return 0f;
				}
				if (value > upperDeadZone)
				{
					return 1f;
				}
				return (value - lowerDeadZone) / num;
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x000F5540 File Offset: 0x000F3740
		public static float ApplySmoothing(float thisValue, float lastValue, float deltaTime, float sensitivity)
		{
			if (Utility.Approximately(sensitivity, 1f))
			{
				return thisValue;
			}
			float maxDelta = deltaTime * sensitivity * 100f;
			if (Utility.IsNotZero(thisValue) && Utility.Sign(lastValue) != Utility.Sign(thisValue))
			{
				lastValue = 0f;
			}
			return Mathf.MoveTowards(lastValue, thisValue, maxDelta);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000F558D File Offset: 0x000F378D
		public static float ApplySnapping(float value, float threshold)
		{
			if (value < -threshold)
			{
				return -1f;
			}
			if (value > threshold)
			{
				return 1f;
			}
			return 0f;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x000F55A9 File Offset: 0x000F37A9
		internal static bool TargetIsButton(InputControlType target)
		{
			return (target >= InputControlType.Action1 && target <= InputControlType.Action12) || (target >= InputControlType.Button0 && target <= InputControlType.Button19);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000F55CC File Offset: 0x000F37CC
		internal static bool TargetIsStandard(InputControlType target)
		{
			return (target >= InputControlType.LeftStickUp && target <= InputControlType.Action12) || (target >= InputControlType.Command && target <= InputControlType.DPadY);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000F55EE File Offset: 0x000F37EE
		internal static bool TargetIsAlias(InputControlType target)
		{
			return target >= InputControlType.Command && target <= InputControlType.RightCommand;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000F5608 File Offset: 0x000F3808
		public static string ReadFromFile(string path)
		{
			StreamReader streamReader = new StreamReader(path);
			string result = streamReader.ReadToEnd();
			streamReader.Close();
			return result;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000F5628 File Offset: 0x000F3828
		public static void WriteToFile(string path, string data)
		{
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.Write(data);
			streamWriter.Flush();
			streamWriter.Close();
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000F5642 File Offset: 0x000F3842
		public static float Abs(float value)
		{
			if (value >= 0f)
			{
				return value;
			}
			return -value;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000F5650 File Offset: 0x000F3850
		public static bool Approximately(float v1, float v2)
		{
			float num = v1 - v2;
			return num >= -1E-07f && num <= 1E-07f;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x000F5676 File Offset: 0x000F3876
		public static bool Approximately(Vector2 v1, Vector2 v2)
		{
			return Utility.Approximately(v1.x, v2.x) && Utility.Approximately(v1.y, v2.y);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000F569E File Offset: 0x000F389E
		public static bool IsNotZero(float value)
		{
			return value < -1E-07f || value > 1E-07f;
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000F56B2 File Offset: 0x000F38B2
		public static bool IsZero(float value)
		{
			return value >= -1E-07f && value <= 1E-07f;
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000F56C9 File Offset: 0x000F38C9
		public static int Sign(float f)
		{
			if ((double)f >= 0.0)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000F56DB File Offset: 0x000F38DB
		public static bool AbsoluteIsOverThreshold(float value, float threshold)
		{
			return value < -threshold || value > threshold;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000F56E8 File Offset: 0x000F38E8
		public static float NormalizeAngle(float angle)
		{
			while (angle < 0f)
			{
				angle += 360f;
			}
			while (angle > 360f)
			{
				angle -= 360f;
			}
			return angle;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000F5715 File Offset: 0x000F3915
		public static float VectorToAngle(Vector2 vector)
		{
			if (Utility.IsZero(vector.x) && Utility.IsZero(vector.y))
			{
				return 0f;
			}
			return Utility.NormalizeAngle(Mathf.Atan2(vector.x, vector.y) * 57.29578f);
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x000F5753 File Offset: 0x000F3953
		public static float Min(float v0, float v1)
		{
			if (v0 < v1)
			{
				return v0;
			}
			return v1;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x000F575C File Offset: 0x000F395C
		public static float Max(float v0, float v1)
		{
			if (v0 > v1)
			{
				return v0;
			}
			return v1;
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000F5768 File Offset: 0x000F3968
		public static float Min(float v0, float v1, float v2, float v3)
		{
			float num = (v0 >= v1) ? v1 : v0;
			float num2 = (v2 >= v3) ? v3 : v2;
			if (num < num2)
			{
				return num;
			}
			return num2;
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000F5790 File Offset: 0x000F3990
		public static float Max(float v0, float v1, float v2, float v3)
		{
			float num = (v0 <= v1) ? v1 : v0;
			float num2 = (v2 <= v3) ? v3 : v2;
			if (num > num2)
			{
				return num;
			}
			return num2;
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x000F57B8 File Offset: 0x000F39B8
		internal static float ValueFromSides(float negativeSide, float positiveSide)
		{
			float num = Utility.Abs(negativeSide);
			float num2 = Utility.Abs(positiveSide);
			if (Utility.Approximately(num, num2))
			{
				return 0f;
			}
			if (num <= num2)
			{
				return num2;
			}
			return -num;
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000F57EA File Offset: 0x000F39EA
		internal static float ValueFromSides(float negativeSide, float positiveSide, bool invertSides)
		{
			if (invertSides)
			{
				return Utility.ValueFromSides(positiveSide, negativeSide);
			}
			return Utility.ValueFromSides(negativeSide, positiveSide);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000F57FE File Offset: 0x000F39FE
		public static void ArrayResize<T>(ref T[] array, int capacity)
		{
			if (array == null || capacity > array.Length)
			{
				Array.Resize<T>(ref array, Utility.NextPowerOfTwo(capacity));
			}
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x000F5817 File Offset: 0x000F3A17
		public static void ArrayExpand<T>(ref T[] array, int capacity)
		{
			if (array == null || capacity > array.Length)
			{
				array = new T[Utility.NextPowerOfTwo(capacity)];
			}
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000F5831 File Offset: 0x000F3A31
		public static void ArrayAppend<T>(ref T[] array, T item)
		{
			if (array == null)
			{
				array = new T[1];
				array[0] = item;
				return;
			}
			Array.Resize<T>(ref array, array.Length + 1);
			array[array.Length - 1] = item;
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000F5863 File Offset: 0x000F3A63
		public static void ArrayAppend<T>(ref T[] array, T[] items)
		{
			if (array == null)
			{
				array = new T[items.Length];
				Array.Copy(items, array, items.Length);
				return;
			}
			Array.Resize<T>(ref array, array.Length + items.Length);
			Array.ConstrainedCopy(items, 0, array, array.Length - items.Length, items.Length);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000F58A4 File Offset: 0x000F3AA4
		public static int NextPowerOfTwo(int value)
		{
			if (value > 0)
			{
				value--;
				value |= value >> 1;
				value |= value >> 2;
				value |= value >> 4;
				value |= value >> 8;
				value |= value >> 16;
				value++;
				return value;
			}
			return 0;
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000F58F4 File Offset: 0x000F3AF4
		internal static bool Is32Bit
		{
			get
			{
				return IntPtr.Size == 4;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x000F58FE File Offset: 0x000F3AFE
		internal static bool Is64Bit
		{
			get
			{
				return IntPtr.Size == 8;
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000F5908 File Offset: 0x000F3B08
		public static string GetPlatformName(bool uppercase = true)
		{
			string windowsVersion = Utility.GetWindowsVersion();
			if (!uppercase)
			{
				return windowsVersion;
			}
			return windowsVersion.ToUpper();
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x000F5928 File Offset: 0x000F3B28
		private static string GetHumanUnderstandableWindowsVersion()
		{
			Version version = Environment.OSVersion.Version;
			if (version.Major == 6)
			{
				switch (version.Minor)
				{
				case 1:
					return "7";
				case 2:
					return "8";
				case 3:
					return "8.1";
				default:
					return "Vista";
				}
			}
			else
			{
				if (version.Major != 5)
				{
					return version.Major.ToString();
				}
				int minor = version.Minor;
				if (minor - 1 <= 1)
				{
					return "XP";
				}
				return "2000";
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x000F59B0 File Offset: 0x000F3BB0
		public static string GetWindowsVersion()
		{
			string humanUnderstandableWindowsVersion = Utility.GetHumanUnderstandableWindowsVersion();
			string text = Utility.Is32Bit ? "32Bit" : "64Bit";
			return string.Concat(new string[]
			{
				"Windows ",
				humanUnderstandableWindowsVersion,
				" ",
				text,
				" Build ",
				Utility.GetSystemBuildNumber().ToString()
			});
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x000F5A12 File Offset: 0x000F3C12
		public static int GetSystemBuildNumber()
		{
			return Environment.OSVersion.Version.Build;
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x000F5A23 File Offset: 0x000F3C23
		public static void LoadScene(string sceneName)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x000F5A2B File Offset: 0x000F3C2B
		internal static string PluginFileExtension()
		{
			return ".dll";
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000F5A34 File Offset: 0x000F3C34
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Utility.circleVertexList = new Vector2[]
			{
				new Vector2(0f, 1f),
				new Vector2(0.2588f, 0.9659f),
				new Vector2(0.5f, 0.866f),
				new Vector2(0.7071f, 0.7071f),
				new Vector2(0.866f, 0.5f),
				new Vector2(0.9659f, 0.2588f),
				new Vector2(1f, 0f),
				new Vector2(0.9659f, -0.2588f),
				new Vector2(0.866f, -0.5f),
				new Vector2(0.7071f, -0.7071f),
				new Vector2(0.5f, -0.866f),
				new Vector2(0.2588f, -0.9659f),
				new Vector2(0f, -1f),
				new Vector2(-0.2588f, -0.9659f),
				new Vector2(-0.5f, -0.866f),
				new Vector2(-0.7071f, -0.7071f),
				new Vector2(-0.866f, -0.5f),
				new Vector2(-0.9659f, -0.2588f),
				new Vector2(-1f, --0f),
				new Vector2(-0.9659f, 0.2588f),
				new Vector2(-0.866f, 0.5f),
				new Vector2(-0.7071f, 0.7071f),
				new Vector2(-0.5f, 0.866f),
				new Vector2(-0.2588f, 0.9659f),
				new Vector2(0f, 1f)
			};
		}

		// Token: 0x040032DE RID: 13022
		public const float Epsilon = 1E-07f;

		// Token: 0x040032DF RID: 13023
		private static readonly Vector2[] circleVertexList;
	}
}
