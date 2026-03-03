using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C58 RID: 3160
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Projects the location found with Get Location Info to a 2d map using common projections.")]
	public class ProjectLocationToMap : FsmStateAction
	{
		// Token: 0x0600420F RID: 16911 RVA: 0x0016F02C File Offset: 0x0016D22C
		public override void Reset()
		{
			this.GPSLocation = new FsmVector3
			{
				UseVariable = true
			};
			this.mapProjection = ProjectLocationToMap.MapProjection.EquidistantCylindrical;
			this.minLongitude = -180f;
			this.maxLongitude = 180f;
			this.minLatitude = -90f;
			this.maxLatitude = 90f;
			this.minX = 0f;
			this.minY = 0f;
			this.width = 1f;
			this.height = 1f;
			this.normalized = true;
			this.projectedX = null;
			this.projectedY = null;
			this.everyFrame = false;
		}

		// Token: 0x06004210 RID: 16912 RVA: 0x0016F0F3 File Offset: 0x0016D2F3
		public override void OnEnter()
		{
			if (this.GPSLocation.IsNone)
			{
				base.Finish();
				return;
			}
			this.DoProjectGPSLocation();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x0016F11D File Offset: 0x0016D31D
		public override void OnUpdate()
		{
			this.DoProjectGPSLocation();
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x0016F128 File Offset: 0x0016D328
		private void DoProjectGPSLocation()
		{
			this.x = Mathf.Clamp(this.GPSLocation.Value.x, this.minLongitude.Value, this.maxLongitude.Value);
			this.y = Mathf.Clamp(this.GPSLocation.Value.y, this.minLatitude.Value, this.maxLatitude.Value);
			ProjectLocationToMap.MapProjection mapProjection = this.mapProjection;
			if (mapProjection != ProjectLocationToMap.MapProjection.EquidistantCylindrical)
			{
				if (mapProjection == ProjectLocationToMap.MapProjection.Mercator)
				{
					this.DoMercatorProjection();
				}
			}
			else
			{
				this.DoEquidistantCylindrical();
			}
			this.x *= this.width.Value;
			this.y *= this.height.Value;
			this.projectedX.Value = (this.normalized.Value ? (this.minX.Value + this.x) : (this.minX.Value + this.x * (float)Screen.width));
			this.projectedY.Value = (this.normalized.Value ? (this.minY.Value + this.y) : (this.minY.Value + this.y * (float)Screen.height));
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x0016F270 File Offset: 0x0016D470
		private void DoEquidistantCylindrical()
		{
			this.x = (this.x - this.minLongitude.Value) / (this.maxLongitude.Value - this.minLongitude.Value);
			this.y = (this.y - this.minLatitude.Value) / (this.maxLatitude.Value - this.minLatitude.Value);
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x0016F2E0 File Offset: 0x0016D4E0
		private void DoMercatorProjection()
		{
			this.x = (this.x - this.minLongitude.Value) / (this.maxLongitude.Value - this.minLongitude.Value);
			float num = ProjectLocationToMap.LatitudeToMercator(this.minLatitude.Value);
			float num2 = ProjectLocationToMap.LatitudeToMercator(this.maxLatitude.Value);
			this.y = (ProjectLocationToMap.LatitudeToMercator(this.GPSLocation.Value.y) - num) / (num2 - num);
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x0016F360 File Offset: 0x0016D560
		private static float LatitudeToMercator(float latitudeInDegrees)
		{
			float num = Mathf.Clamp(latitudeInDegrees, -85f, 85f);
			num = 0.017453292f * num;
			return Mathf.Log(Mathf.Tan(num / 2f + 0.7853982f));
		}

		// Token: 0x04004678 RID: 18040
		[Tooltip("Location vector in degrees longitude and latitude. Typically returned by the Get Location Info action.")]
		public FsmVector3 GPSLocation;

		// Token: 0x04004679 RID: 18041
		[Tooltip("The projection used by the map.")]
		public ProjectLocationToMap.MapProjection mapProjection;

		// Token: 0x0400467A RID: 18042
		[ActionSection("Map Region")]
		[HasFloatSlider(-180f, 180f)]
		public FsmFloat minLongitude;

		// Token: 0x0400467B RID: 18043
		[HasFloatSlider(-180f, 180f)]
		public FsmFloat maxLongitude;

		// Token: 0x0400467C RID: 18044
		[HasFloatSlider(-90f, 90f)]
		public FsmFloat minLatitude;

		// Token: 0x0400467D RID: 18045
		[HasFloatSlider(-90f, 90f)]
		public FsmFloat maxLatitude;

		// Token: 0x0400467E RID: 18046
		[ActionSection("Screen Region")]
		public FsmFloat minX;

		// Token: 0x0400467F RID: 18047
		public FsmFloat minY;

		// Token: 0x04004680 RID: 18048
		public FsmFloat width;

		// Token: 0x04004681 RID: 18049
		public FsmFloat height;

		// Token: 0x04004682 RID: 18050
		[ActionSection("Projection")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the projected X coordinate in a Float Variable. Use this to display a marker on the map.")]
		public FsmFloat projectedX;

		// Token: 0x04004683 RID: 18051
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the projected Y coordinate in a Float Variable. Use this to display a marker on the map.")]
		public FsmFloat projectedY;

		// Token: 0x04004684 RID: 18052
		[Tooltip("If true all coordinates in this action are normalized (0-1); otherwise coordinates are in pixels.")]
		public FsmBool normalized;

		// Token: 0x04004685 RID: 18053
		public bool everyFrame;

		// Token: 0x04004686 RID: 18054
		private float x;

		// Token: 0x04004687 RID: 18055
		private float y;

		// Token: 0x02000C59 RID: 3161
		public enum MapProjection
		{
			// Token: 0x04004689 RID: 18057
			EquidistantCylindrical,
			// Token: 0x0400468A RID: 18058
			Mercator
		}
	}
}
