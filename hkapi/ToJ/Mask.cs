using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ToJ
{
	// Token: 0x020008BD RID: 2237
	[ExecuteInEditMode]
	[AddComponentMenu("Alpha Mask")]
	public class Mask : MonoBehaviour
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0012EBEC File Offset: 0x0012CDEC
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0012EBF4 File Offset: 0x0012CDF4
		public Mask.MappingAxis maskMappingWorldAxis
		{
			get
			{
				return this._maskMappingWorldAxis;
			}
			set
			{
				this.ChangeMappingAxis(value, this._maskMappingWorldAxis, this._invertAxis);
				this._maskMappingWorldAxis = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0012EC10 File Offset: 0x0012CE10
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0012EC18 File Offset: 0x0012CE18
		public bool invertAxis
		{
			get
			{
				return this._invertAxis;
			}
			set
			{
				this.ChangeMappingAxis(this._maskMappingWorldAxis, this._maskMappingWorldAxis, value);
				this._invertAxis = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0012EC34 File Offset: 0x0012CE34
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0012EC3C File Offset: 0x0012CE3C
		public bool clampAlphaHorizontally
		{
			get
			{
				return this._clampAlphaHorizontally;
			}
			set
			{
				this.SetMaskBoolValueInMaterials("_ClampHoriz", value);
				this._clampAlphaHorizontally = value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0012EC51 File Offset: 0x0012CE51
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0012EC59 File Offset: 0x0012CE59
		public bool clampAlphaVertically
		{
			get
			{
				return this._clampAlphaVertically;
			}
			set
			{
				this.SetMaskBoolValueInMaterials("_ClampVert", value);
				this._clampAlphaVertically = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0012EC6E File Offset: 0x0012CE6E
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x0012EC76 File Offset: 0x0012CE76
		public float clampingBorder
		{
			get
			{
				return this._clampingBorder;
			}
			set
			{
				this.SetMaskFloatValueInMaterials("_ClampBorder", value);
				this._clampingBorder = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x0012EC8B File Offset: 0x0012CE8B
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x0012EC93 File Offset: 0x0012CE93
		public bool useMaskAlphaChannel
		{
			get
			{
				return this._useMaskAlphaChannel;
			}
			set
			{
				this.SetMaskBoolValueInMaterials("_UseAlphaChannel", value);
				this._useMaskAlphaChannel = value;
			}
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0012ECA8 File Offset: 0x0012CEA8
		private void Start()
		{
			this._maskedSpriteWorldCoordsShader = Shader.Find("Alpha Masked/Sprites Alpha Masked - World Coords");
			this._maskedUnlitWorldCoordsShader = Shader.Find("Alpha Masked/Unlit Alpha Masked - World Coords");
			MeshRenderer component = base.GetComponent<MeshRenderer>();
			base.GetComponent<MeshFilter>();
			if (Application.isPlaying && component != null)
			{
				component.enabled = false;
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0012ECFC File Offset: 0x0012CEFC
		private void Update()
		{
			if (this._maskedSpriteWorldCoordsShader == null)
			{
				this._maskedSpriteWorldCoordsShader = Shader.Find("Alpha Masked/Sprites Alpha Masked - World Coords");
			}
			if (this._maskedUnlitWorldCoordsShader == null)
			{
				this._maskedUnlitWorldCoordsShader = Shader.Find("Alpha Masked/Unlit Alpha Masked - World Coords");
			}
			if (this._maskedSpriteWorldCoordsShader == null || this._maskedUnlitWorldCoordsShader == null)
			{
				if (!this.shaderErrorLogged)
				{
					Debug.LogError("Shaders necessary for masking don't seem to be present in the project.");
				}
				return;
			}
			if (base.transform.hasChanged)
			{
				base.transform.hasChanged = false;
				if (this.maskMappingWorldAxis == Mask.MappingAxis.X && (Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.x, 0f)) > 0.01f || Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.y, (float)(this.invertAxis ? -90 : 90))) > 0.01f))
				{
					Debug.Log("You cannot edit X and Y values of the Mask transform rotation!");
					base.transform.eulerAngles = new Vector3(0f, (float)(this.invertAxis ? 270 : 90), base.transform.eulerAngles.z);
				}
				else if (this.maskMappingWorldAxis == Mask.MappingAxis.Y && (Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.x, (float)(this.invertAxis ? -90 : 90))) > 0.01f || Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.z, 0f)) > 0.01f))
				{
					Debug.Log("You cannot edit X and Z values of the Mask transform rotation!");
					base.transform.eulerAngles = new Vector3((float)(this.invertAxis ? -90 : 90), base.transform.eulerAngles.y, 0f);
				}
				else if (this.maskMappingWorldAxis == Mask.MappingAxis.Z && (Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.x, 0f)) > 0.01f || Mathf.Abs(Mathf.DeltaAngle(base.transform.eulerAngles.y, (float)(this.invertAxis ? -180 : 0))) > 0.01f))
				{
					Debug.Log("You cannot edit X and Y values of the Mask transform rotation!");
					base.transform.eulerAngles = new Vector3(0f, (float)(this.invertAxis ? -180 : 0), base.transform.eulerAngles.z);
				}
				if (base.transform.parent != null)
				{
					Renderer[] componentsInChildren = base.transform.parent.gameObject.GetComponentsInChildren<Renderer>();
					Graphic[] componentsInChildren2 = base.transform.parent.gameObject.GetComponentsInChildren<Graphic>();
					List<Material> list = new List<Material>();
					Dictionary<Material, Graphic> dictionary = new Dictionary<Material, Graphic>();
					foreach (Renderer renderer in componentsInChildren)
					{
						if (renderer.gameObject != base.gameObject)
						{
							foreach (Material item in renderer.sharedMaterials)
							{
								if (!list.Contains(item))
								{
									list.Add(item);
								}
							}
						}
					}
					foreach (Graphic graphic in componentsInChildren2)
					{
						if (graphic.gameObject != base.gameObject && !list.Contains(graphic.material))
						{
							list.Add(graphic.material);
							Canvas canvas = graphic.canvas;
							if (canvas.renderMode == RenderMode.ScreenSpaceOverlay || (canvas.renderMode == RenderMode.ScreenSpaceCamera && canvas.worldCamera == null))
							{
								dictionary.Add(list[list.Count - 1], graphic);
							}
						}
					}
					foreach (Material material in list)
					{
						if (material.shader.ToString() == this._maskedSpriteWorldCoordsShader.ToString() && material.shader.GetInstanceID() != this._maskedSpriteWorldCoordsShader.GetInstanceID())
						{
							Debug.Log("There seems to be more than one masked shader in the project with the same display name, and it's preventing the mask from being properly applied.");
							this._maskedSpriteWorldCoordsShader = null;
						}
						if (material.shader.ToString() == this._maskedUnlitWorldCoordsShader.ToString() && material.shader.GetInstanceID() != this._maskedUnlitWorldCoordsShader.GetInstanceID())
						{
							Debug.Log("There seems to be more than one masked shader in the project with the same display name, and it's preventing the mask from being properly applied.");
							this._maskedUnlitWorldCoordsShader = null;
						}
						if (material.shader == this._maskedSpriteWorldCoordsShader || material.shader == this._maskedUnlitWorldCoordsShader)
						{
							material.DisableKeyword("_SCREEN_SPACE_UI");
							Vector2 vector = new Vector2(1f / base.transform.lossyScale.x, 1f / base.transform.lossyScale.y);
							Vector2 vector2 = Vector2.zero;
							float num = 0f;
							int num2 = 1;
							if (this.maskMappingWorldAxis == Mask.MappingAxis.X)
							{
								num2 = (this.invertAxis ? 1 : -1);
								vector2 = new Vector2(-base.transform.position.z, -base.transform.position.y);
								num = (float)num2 * base.transform.eulerAngles.z;
							}
							else if (this.maskMappingWorldAxis == Mask.MappingAxis.Y)
							{
								vector2 = new Vector2(-base.transform.position.x, -base.transform.position.z);
								num = -base.transform.eulerAngles.y;
							}
							else if (this.maskMappingWorldAxis == Mask.MappingAxis.Z)
							{
								num2 = (this.invertAxis ? -1 : 1);
								vector2 = new Vector2(-base.transform.position.x, -base.transform.position.y);
								num = (float)num2 * base.transform.eulerAngles.z;
							}
							RectTransform component = base.GetComponent<RectTransform>();
							if (component != null)
							{
								Rect rect = component.rect;
								vector2 += base.transform.right * (component.pivot.x - 0.5f) * rect.width * base.transform.lossyScale.x + base.transform.up * (component.pivot.y - 0.5f) * rect.height * base.transform.lossyScale.y;
								vector.x /= rect.width;
								vector.y /= rect.height;
							}
							if (dictionary.ContainsKey(material))
							{
								vector2 = dictionary[material].transform.InverseTransformVector(vector2);
								switch (this.maskMappingWorldAxis)
								{
								case Mask.MappingAxis.X:
									vector2.x *= dictionary[material].transform.lossyScale.z;
									vector2.y *= dictionary[material].transform.lossyScale.y;
									break;
								case Mask.MappingAxis.Y:
									vector2.x *= dictionary[material].transform.lossyScale.x;
									vector2.y *= dictionary[material].transform.lossyScale.z;
									break;
								case Mask.MappingAxis.Z:
									vector2.x *= dictionary[material].transform.lossyScale.x;
									vector2.y *= dictionary[material].transform.lossyScale.y;
									break;
								}
								Canvas canvas2 = dictionary[material].canvas;
								vector2 /= canvas2.scaleFactor;
								vector2 = this.RotateVector(vector2, dictionary[material].transform.eulerAngles);
								vector2 += canvas2.GetComponent<RectTransform>().sizeDelta * 0.5f;
								vector *= canvas2.scaleFactor;
								material.EnableKeyword("_SCREEN_SPACE_UI");
							}
							Vector2 mainTextureScale = base.gameObject.GetComponent<Renderer>().sharedMaterial.mainTextureScale;
							vector.x *= mainTextureScale.x;
							vector.y *= mainTextureScale.y;
							vector.x *= (float)num2;
							Vector2 vector3 = vector2;
							float num3 = Mathf.Sin(-num * 0.017453292f);
							float num4 = Mathf.Cos(-num * 0.017453292f);
							vector2.x = (num4 * vector3.x - num3 * vector3.y) * vector.x + 0.5f * mainTextureScale.x;
							vector2.y = (num3 * vector3.x + num4 * vector3.y) * vector.y + 0.5f * mainTextureScale.y;
							vector2 += base.gameObject.GetComponent<Renderer>().sharedMaterial.mainTextureOffset;
							material.SetTextureOffset("_AlphaTex", vector2);
							material.SetTextureScale("_AlphaTex", vector);
							material.SetFloat("_MaskRotation", num * 0.017453292f);
						}
					}
				}
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x0012F6B0 File Offset: 0x0012D8B0
		private Vector3 RotateVector(Vector3 point, Vector3 angles)
		{
			return Quaternion.Euler(angles) * point;
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0012F6C0 File Offset: 0x0012D8C0
		private void SetMaskMappingAxisInMaterials(Mask.MappingAxis mappingAxis)
		{
			if (base.transform.parent == null)
			{
				return;
			}
			Renderer[] componentsInChildren = base.transform.parent.gameObject.GetComponentsInChildren<Renderer>();
			Graphic[] componentsInChildren2 = base.transform.parent.gameObject.GetComponentsInChildren<Graphic>();
			List<Material> list = new List<Material>();
			foreach (Renderer renderer in componentsInChildren)
			{
				if (renderer.gameObject != base.gameObject)
				{
					foreach (Material material in renderer.sharedMaterials)
					{
						if (!list.Contains(material))
						{
							list.Add(material);
							this.SetMaskMappingAxisInMaterial(mappingAxis, material);
						}
					}
				}
			}
			foreach (Graphic graphic in componentsInChildren2)
			{
				if (graphic.gameObject != base.gameObject && !list.Contains(graphic.material))
				{
					list.Add(graphic.material);
					this.SetMaskMappingAxisInMaterial(mappingAxis, graphic.material);
				}
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0012F7D0 File Offset: 0x0012D9D0
		public void SetMaskMappingAxisInMaterial(Mask.MappingAxis mappingAxis, Material material)
		{
			if (material.shader == this._maskedSpriteWorldCoordsShader || material.shader == this._maskedUnlitWorldCoordsShader)
			{
				switch (mappingAxis)
				{
				case Mask.MappingAxis.X:
					material.SetFloat("_Axis", 0f);
					material.EnableKeyword("_AXIS_X");
					material.DisableKeyword("_AXIS_Y");
					material.DisableKeyword("_AXIS_Z");
					return;
				case Mask.MappingAxis.Y:
					material.SetFloat("_Axis", 1f);
					material.DisableKeyword("_AXIS_X");
					material.EnableKeyword("_AXIS_Y");
					material.DisableKeyword("_AXIS_Z");
					return;
				case Mask.MappingAxis.Z:
					material.SetFloat("_Axis", 2f);
					material.DisableKeyword("_AXIS_X");
					material.DisableKeyword("_AXIS_Y");
					material.EnableKeyword("_AXIS_Z");
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0012F8B0 File Offset: 0x0012DAB0
		private void SetMaskFloatValueInMaterials(string variable, float value)
		{
			if (base.transform.parent == null)
			{
				return;
			}
			Renderer[] componentsInChildren = base.transform.parent.gameObject.GetComponentsInChildren<Renderer>();
			Graphic[] componentsInChildren2 = base.transform.parent.gameObject.GetComponentsInChildren<Graphic>();
			List<Material> list = new List<Material>();
			foreach (Renderer renderer in componentsInChildren)
			{
				if (renderer.gameObject != base.gameObject)
				{
					foreach (Material material in renderer.sharedMaterials)
					{
						if (!list.Contains(material))
						{
							list.Add(material);
							material.SetFloat(variable, value);
						}
					}
				}
			}
			foreach (Graphic graphic in componentsInChildren2)
			{
				if (graphic.gameObject != base.gameObject && !list.Contains(graphic.material))
				{
					list.Add(graphic.material);
					graphic.material.SetFloat(variable, value);
				}
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0012F9C0 File Offset: 0x0012DBC0
		private void SetMaskBoolValueInMaterials(string variable, bool value)
		{
			if (base.transform.parent == null)
			{
				return;
			}
			Renderer[] componentsInChildren = base.transform.parent.gameObject.GetComponentsInChildren<Renderer>();
			Graphic[] componentsInChildren2 = base.transform.parent.gameObject.GetComponentsInChildren<Graphic>();
			List<Material> list = new List<Material>();
			foreach (Renderer renderer in componentsInChildren)
			{
				if (renderer.gameObject != base.gameObject)
				{
					foreach (Material material in renderer.sharedMaterials)
					{
						if (!list.Contains(material))
						{
							list.Add(material);
							this.SetMaskBoolValueInMaterial(variable, value, material);
						}
					}
				}
			}
			foreach (Graphic graphic in componentsInChildren2)
			{
				if (graphic.gameObject != base.gameObject && !list.Contains(graphic.material))
				{
					list.Add(graphic.material);
					this.SetMaskBoolValueInMaterial(variable, value, graphic.material);
				}
			}
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0012FAD0 File Offset: 0x0012DCD0
		public void SetMaskBoolValueInMaterial(string variable, bool value, Material material)
		{
			if (material.shader == this._maskedSpriteWorldCoordsShader || material.shader == this._maskedUnlitWorldCoordsShader)
			{
				material.SetFloat(variable, (float)(value ? 1 : 0));
				if (value)
				{
					material.EnableKeyword(variable.ToUpper() + "_ON");
					return;
				}
				material.DisableKeyword(variable.ToUpper() + "_ON");
			}
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0012FB44 File Offset: 0x0012DD44
		private void CreateAndAssignQuad(Mesh mesh, float minX = -0.5f, float maxX = 0.5f, float minY = -0.5f, float maxY = 0.5f)
		{
			mesh.vertices = new Vector3[]
			{
				new Vector3(minX, minY, 0f),
				new Vector3(maxX, minY, 0f),
				new Vector3(minX, maxY, 0f),
				new Vector3(maxX, maxY, 0f)
			};
			mesh.triangles = new int[]
			{
				0,
				2,
				1,
				2,
				3,
				1
			};
			mesh.normals = new Vector3[]
			{
				-Vector3.forward,
				-Vector3.forward,
				-Vector3.forward,
				-Vector3.forward
			};
			mesh.uv = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(1f, 0f),
				new Vector2(0f, 1f),
				new Vector2(1f, 1f)
			};
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0012FC8D File Offset: 0x0012DE8D
		public void SetMaskRendererActive(bool value)
		{
			if (base.GetComponent<Renderer>() != null)
			{
				if (value)
				{
					base.GetComponent<Renderer>().enabled = true;
					return;
				}
				base.GetComponent<Renderer>().enabled = false;
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x0012FCBC File Offset: 0x0012DEBC
		private void ChangeMappingAxis(Mask.MappingAxis currMaskMappingWorldAxis, Mask.MappingAxis prevMaskMappingWorldAxis, bool currInvertAxis)
		{
			if (currMaskMappingWorldAxis == Mask.MappingAxis.X)
			{
				if (prevMaskMappingWorldAxis == Mask.MappingAxis.Y)
				{
					base.transform.eulerAngles = new Vector3(0f, (float)(currInvertAxis ? -90 : 90), base.transform.eulerAngles.y);
				}
				else
				{
					base.transform.eulerAngles = new Vector3(0f, (float)(currInvertAxis ? -90 : 90), base.transform.eulerAngles.z);
				}
			}
			else if (currMaskMappingWorldAxis == Mask.MappingAxis.Y)
			{
				if (prevMaskMappingWorldAxis == Mask.MappingAxis.Y)
				{
					base.transform.eulerAngles = new Vector3((float)(currInvertAxis ? -90 : 90), base.transform.eulerAngles.y, 0f);
				}
				else
				{
					base.transform.eulerAngles = new Vector3((float)(currInvertAxis ? -90 : 90), base.transform.eulerAngles.z, 0f);
				}
			}
			else if (currMaskMappingWorldAxis == Mask.MappingAxis.Z)
			{
				if (prevMaskMappingWorldAxis == Mask.MappingAxis.Y)
				{
					base.transform.eulerAngles = new Vector3(0f, (float)(currInvertAxis ? -180 : 0), base.transform.eulerAngles.y);
				}
				else
				{
					base.transform.eulerAngles = new Vector3(0f, (float)(currInvertAxis ? -180 : 0), base.transform.eulerAngles.z);
				}
			}
			this.SetMaskMappingAxisInMaterials(currMaskMappingWorldAxis);
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0012FE1B File Offset: 0x0012E01B
		public Mask()
		{
			this._maskMappingWorldAxis = Mask.MappingAxis.Z;
			this._clampingBorder = 0.01f;
			base..ctor();
		}

		// Token: 0x04003342 RID: 13122
		private bool shaderErrorLogged;

		// Token: 0x04003343 RID: 13123
		[SerializeField]
		private Mask.MappingAxis _maskMappingWorldAxis;

		// Token: 0x04003344 RID: 13124
		[SerializeField]
		private bool _invertAxis;

		// Token: 0x04003345 RID: 13125
		[SerializeField]
		private bool _clampAlphaHorizontally;

		// Token: 0x04003346 RID: 13126
		[SerializeField]
		private bool _clampAlphaVertically;

		// Token: 0x04003347 RID: 13127
		[SerializeField]
		private float _clampingBorder;

		// Token: 0x04003348 RID: 13128
		[SerializeField]
		private bool _useMaskAlphaChannel;

		// Token: 0x04003349 RID: 13129
		private Shader _maskedSpriteWorldCoordsShader;

		// Token: 0x0400334A RID: 13130
		private Shader _maskedUnlitWorldCoordsShader;

		// Token: 0x020008BE RID: 2238
		public enum MappingAxis
		{
			// Token: 0x0400334C RID: 13132
			X,
			// Token: 0x0400334D RID: 13133
			Y,
			// Token: 0x0400334E RID: 13134
			Z
		}
	}
}
