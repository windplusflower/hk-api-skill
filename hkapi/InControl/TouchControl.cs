using System;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000711 RID: 1809
	public abstract class TouchControl : MonoBehaviour
	{
		// Token: 0x06002CC5 RID: 11461
		public abstract void CreateControl();

		// Token: 0x06002CC6 RID: 11462
		public abstract void DestroyControl();

		// Token: 0x06002CC7 RID: 11463
		public abstract void ConfigureControl();

		// Token: 0x06002CC8 RID: 11464
		public abstract void SubmitControlState(ulong updateTick, float deltaTime);

		// Token: 0x06002CC9 RID: 11465
		public abstract void CommitControlState(ulong updateTick, float deltaTime);

		// Token: 0x06002CCA RID: 11466
		public abstract void TouchBegan(Touch touch);

		// Token: 0x06002CCB RID: 11467
		public abstract void TouchMoved(Touch touch);

		// Token: 0x06002CCC RID: 11468
		public abstract void TouchEnded(Touch touch);

		// Token: 0x06002CCD RID: 11469
		public abstract void DrawGizmos();

		// Token: 0x06002CCE RID: 11470 RVA: 0x000F169D File Offset: 0x000EF89D
		private void OnEnable()
		{
			TouchManager.OnSetup += this.Setup;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000F16B0 File Offset: 0x000EF8B0
		private void OnDisable()
		{
			this.DestroyControl();
			Resources.UnloadUnusedAssets();
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000F16BE File Offset: 0x000EF8BE
		private void Setup()
		{
			if (!base.enabled)
			{
				return;
			}
			this.CreateControl();
			this.ConfigureControl();
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000F16D8 File Offset: 0x000EF8D8
		protected Vector3 OffsetToWorldPosition(TouchControlAnchor anchor, Vector2 offset, TouchUnitType offsetUnitType, bool lockAspectRatio)
		{
			Vector3 b;
			if (offsetUnitType == TouchUnitType.Pixels)
			{
				b = TouchUtility.RoundVector(offset) * TouchManager.PixelToWorld;
			}
			else if (lockAspectRatio)
			{
				b = offset * TouchManager.PercentToWorld;
			}
			else
			{
				b = Vector3.Scale(offset, TouchManager.ViewSize);
			}
			return TouchManager.ViewToWorldPoint(TouchUtility.AnchorToViewPoint(anchor)) + b;
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000F173C File Offset: 0x000EF93C
		protected void SubmitButtonState(TouchControl.ButtonTarget target, bool state, ulong updateTick, float deltaTime)
		{
			if (TouchManager.Device == null || target == TouchControl.ButtonTarget.None)
			{
				return;
			}
			InputControl control = TouchManager.Device.GetControl((InputControlType)target);
			if (control != null && control != InputControl.Null)
			{
				control.UpdateWithState(state, updateTick, deltaTime);
			}
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000F1778 File Offset: 0x000EF978
		protected void SubmitButtonValue(TouchControl.ButtonTarget target, float value, ulong updateTick, float deltaTime)
		{
			if (TouchManager.Device == null || target == TouchControl.ButtonTarget.None)
			{
				return;
			}
			InputControl control = TouchManager.Device.GetControl((InputControlType)target);
			if (control != null && control != InputControl.Null)
			{
				control.UpdateWithValue(value, updateTick, deltaTime);
			}
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000F17B4 File Offset: 0x000EF9B4
		protected void CommitButton(TouchControl.ButtonTarget target)
		{
			if (TouchManager.Device == null || target == TouchControl.ButtonTarget.None)
			{
				return;
			}
			InputControl control = TouchManager.Device.GetControl((InputControlType)target);
			if (control != null && control != InputControl.Null)
			{
				control.Commit();
			}
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000F17EC File Offset: 0x000EF9EC
		protected void SubmitAnalogValue(TouchControl.AnalogTarget target, Vector2 value, float lowerDeadZone, float upperDeadZone, ulong updateTick, float deltaTime)
		{
			if (TouchManager.Device == null || target == TouchControl.AnalogTarget.None)
			{
				return;
			}
			Vector2 value2 = DeadZone.Circular(value.x, value.y, lowerDeadZone, upperDeadZone);
			if (target == TouchControl.AnalogTarget.LeftStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.UpdateLeftStickWithValue(value2, updateTick, deltaTime);
			}
			if (target == TouchControl.AnalogTarget.RightStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.UpdateRightStickWithValue(value2, updateTick, deltaTime);
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000F1847 File Offset: 0x000EFA47
		protected void CommitAnalog(TouchControl.AnalogTarget target)
		{
			if (TouchManager.Device == null || target == TouchControl.AnalogTarget.None)
			{
				return;
			}
			if (target == TouchControl.AnalogTarget.LeftStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.CommitLeftStick();
			}
			if (target == TouchControl.AnalogTarget.RightStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.CommitRightStick();
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000F1878 File Offset: 0x000EFA78
		protected void SubmitRawAnalogValue(TouchControl.AnalogTarget target, Vector2 rawValue, ulong updateTick, float deltaTime)
		{
			if (TouchManager.Device == null || target == TouchControl.AnalogTarget.None)
			{
				return;
			}
			if (target == TouchControl.AnalogTarget.LeftStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.UpdateLeftStickWithRawValue(rawValue, updateTick, deltaTime);
			}
			if (target == TouchControl.AnalogTarget.RightStick || target == TouchControl.AnalogTarget.Both)
			{
				TouchManager.Device.UpdateRightStickWithRawValue(rawValue, updateTick, deltaTime);
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000F18B4 File Offset: 0x000EFAB4
		protected static Vector3 SnapTo(Vector2 vector, TouchControl.SnapAngles snapAngles)
		{
			if (snapAngles == TouchControl.SnapAngles.None)
			{
				return vector;
			}
			float snapAngle = 360f / (float)snapAngles;
			return TouchControl.SnapTo(vector, snapAngle);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000F18DC File Offset: 0x000EFADC
		protected static Vector3 SnapTo(Vector2 vector, float snapAngle)
		{
			float num = Vector2.Angle(vector, Vector2.up);
			if (num < snapAngle / 2f)
			{
				return Vector2.up * vector.magnitude;
			}
			if (num > 180f - snapAngle / 2f)
			{
				return -Vector2.up * vector.magnitude;
			}
			float angle = Mathf.Round(num / snapAngle) * snapAngle - num;
			Vector3 axis = Vector3.Cross(Vector2.up, vector);
			return Quaternion.AngleAxis(angle, axis) * vector;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000F1975 File Offset: 0x000EFB75
		private void OnDrawGizmosSelected()
		{
			if (!base.enabled)
			{
				return;
			}
			if (TouchManager.ControlsShowGizmos != TouchManager.GizmoShowOption.WhenSelected)
			{
				return;
			}
			if (Utility.GameObjectIsCulledOnCurrentCamera(base.gameObject))
			{
				return;
			}
			if (!Application.isPlaying)
			{
				this.ConfigureControl();
			}
			this.DrawGizmos();
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000F19AC File Offset: 0x000EFBAC
		private void OnDrawGizmos()
		{
			if (!base.enabled)
			{
				return;
			}
			if (TouchManager.ControlsShowGizmos == TouchManager.GizmoShowOption.UnlessPlaying)
			{
				if (Application.isPlaying)
				{
					return;
				}
			}
			else if (TouchManager.ControlsShowGizmos != TouchManager.GizmoShowOption.Always)
			{
				return;
			}
			if (Utility.GameObjectIsCulledOnCurrentCamera(base.gameObject))
			{
				return;
			}
			if (!Application.isPlaying)
			{
				this.ConfigureControl();
			}
			this.DrawGizmos();
		}

		// Token: 0x02000712 RID: 1810
		public enum ButtonTarget
		{
			// Token: 0x04003238 RID: 12856
			None,
			// Token: 0x04003239 RID: 12857
			DPadDown = 12,
			// Token: 0x0400323A RID: 12858
			DPadLeft,
			// Token: 0x0400323B RID: 12859
			DPadRight,
			// Token: 0x0400323C RID: 12860
			DPadUp = 11,
			// Token: 0x0400323D RID: 12861
			LeftTrigger = 15,
			// Token: 0x0400323E RID: 12862
			RightTrigger,
			// Token: 0x0400323F RID: 12863
			LeftBumper,
			// Token: 0x04003240 RID: 12864
			RightBumper,
			// Token: 0x04003241 RID: 12865
			Action1,
			// Token: 0x04003242 RID: 12866
			Action2,
			// Token: 0x04003243 RID: 12867
			Action3,
			// Token: 0x04003244 RID: 12868
			Action4,
			// Token: 0x04003245 RID: 12869
			Action5,
			// Token: 0x04003246 RID: 12870
			Action6,
			// Token: 0x04003247 RID: 12871
			Action7,
			// Token: 0x04003248 RID: 12872
			Action8,
			// Token: 0x04003249 RID: 12873
			Action9,
			// Token: 0x0400324A RID: 12874
			Action10,
			// Token: 0x0400324B RID: 12875
			Action11,
			// Token: 0x0400324C RID: 12876
			Action12,
			// Token: 0x0400324D RID: 12877
			Menu = 106,
			// Token: 0x0400324E RID: 12878
			Button0 = 500,
			// Token: 0x0400324F RID: 12879
			Button1,
			// Token: 0x04003250 RID: 12880
			Button2,
			// Token: 0x04003251 RID: 12881
			Button3,
			// Token: 0x04003252 RID: 12882
			Button4,
			// Token: 0x04003253 RID: 12883
			Button5,
			// Token: 0x04003254 RID: 12884
			Button6,
			// Token: 0x04003255 RID: 12885
			Button7,
			// Token: 0x04003256 RID: 12886
			Button8,
			// Token: 0x04003257 RID: 12887
			Button9,
			// Token: 0x04003258 RID: 12888
			Button10,
			// Token: 0x04003259 RID: 12889
			Button11,
			// Token: 0x0400325A RID: 12890
			Button12,
			// Token: 0x0400325B RID: 12891
			Button13,
			// Token: 0x0400325C RID: 12892
			Button14,
			// Token: 0x0400325D RID: 12893
			Button15,
			// Token: 0x0400325E RID: 12894
			Button16,
			// Token: 0x0400325F RID: 12895
			Button17,
			// Token: 0x04003260 RID: 12896
			Button18,
			// Token: 0x04003261 RID: 12897
			Button19
		}

		// Token: 0x02000713 RID: 1811
		public enum AnalogTarget
		{
			// Token: 0x04003263 RID: 12899
			None,
			// Token: 0x04003264 RID: 12900
			LeftStick,
			// Token: 0x04003265 RID: 12901
			RightStick,
			// Token: 0x04003266 RID: 12902
			Both
		}

		// Token: 0x02000714 RID: 1812
		public enum SnapAngles
		{
			// Token: 0x04003268 RID: 12904
			None,
			// Token: 0x04003269 RID: 12905
			Four = 4,
			// Token: 0x0400326A RID: 12906
			Eight = 8,
			// Token: 0x0400326B RID: 12907
			Sixteen = 16
		}
	}
}
