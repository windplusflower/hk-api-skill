using System;
using System.Collections;
using UnityEngine;

// Token: 0x020005C1 RID: 1473
public class iTween : MonoBehaviour
{
	// Token: 0x06002189 RID: 8585 RVA: 0x000A8D31 File Offset: 0x000A6F31
	public static void Init(GameObject target)
	{
		iTween.MoveBy(target, Vector3.zero, 0f);
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x000A8D44 File Offset: 0x000A6F44
	public static void CameraFadeFrom(float amount, float time)
	{
		if (iTween.cameraFade)
		{
			iTween.CameraFadeFrom(iTween.Hash(new object[]
			{
				"amount",
				amount,
				"time",
				time
			}));
			return;
		}
		Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000A8D9A File Offset: 0x000A6F9A
	public static void CameraFadeFrom(Hashtable args)
	{
		if (iTween.cameraFade)
		{
			iTween.ColorFrom(iTween.cameraFade, args);
			return;
		}
		Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000A8DC0 File Offset: 0x000A6FC0
	public static void CameraFadeTo(float amount, float time)
	{
		if (iTween.cameraFade)
		{
			iTween.CameraFadeTo(iTween.Hash(new object[]
			{
				"amount",
				amount,
				"time",
				time
			}));
			return;
		}
		Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x000A8E16 File Offset: 0x000A7016
	public static void CameraFadeTo(Hashtable args)
	{
		if (iTween.cameraFade)
		{
			iTween.ColorTo(iTween.cameraFade, args);
			return;
		}
		Debug.LogError("iTween Error: You must first add a camera fade object with CameraFadeAdd() before atttempting to use camera fading.");
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x000A8E3C File Offset: 0x000A703C
	public static void ValueTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (!args.Contains("onupdate") || !args.Contains("from") || !args.Contains("to"))
		{
			Debug.LogError("iTween Error: ValueTo() requires an 'onupdate' callback function and a 'from' and 'to' property.  The supplied 'onupdate' callback must accept a single argument that is the same type as the supplied 'from' and 'to' properties!");
			return;
		}
		args["type"] = "value";
		if (args["from"].GetType() == typeof(Vector2))
		{
			args["method"] = "vector2";
		}
		else if (args["from"].GetType() == typeof(Vector3))
		{
			args["method"] = "vector3";
		}
		else if (args["from"].GetType() == typeof(Rect))
		{
			args["method"] = "rect";
		}
		else if (args["from"].GetType() == typeof(float))
		{
			args["method"] = "float";
		}
		else
		{
			if (!(args["from"].GetType() == typeof(Color)))
			{
				Debug.LogError("iTween Error: ValueTo() only works with interpolating Vector3s, Vector2s, floats, ints, Rects and Colors!");
				return;
			}
			args["method"] = "color";
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", iTween.EaseType.linear);
		}
		iTween.Launch(target, args);
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000A8FCB File Offset: 0x000A71CB
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
		iTween.FadeFrom(target, iTween.Hash(new object[]
		{
			"alpha",
			alpha,
			"time",
			time
		}));
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x000A9000 File Offset: 0x000A7200
	public static void FadeFrom(GameObject target, Hashtable args)
	{
		iTween.ColorFrom(target, args);
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x000A9009 File Offset: 0x000A7209
	public static void FadeTo(GameObject target, float alpha, float time)
	{
		iTween.FadeTo(target, iTween.Hash(new object[]
		{
			"alpha",
			alpha,
			"time",
			time
		}));
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x000A903E File Offset: 0x000A723E
	public static void FadeTo(GameObject target, Hashtable args)
	{
		iTween.ColorTo(target, args);
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x000A9047 File Offset: 0x000A7247
	public static void ColorFrom(GameObject target, Color color, float time)
	{
		iTween.ColorFrom(target, iTween.Hash(new object[]
		{
			"color",
			color,
			"time",
			time
		}));
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000A907C File Offset: 0x000A727C
	public static void ColorFrom(GameObject target, Hashtable args)
	{
		Color color = default(Color);
		Color color2 = default(Color);
		args = iTween.CleanArgs(args);
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (object obj in target.transform)
			{
				Component component = (Transform)obj;
				Hashtable hashtable = (Hashtable)args.Clone();
				hashtable["ischild"] = true;
				iTween.ColorFrom(component.gameObject, hashtable);
			}
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", iTween.EaseType.linear);
		}
		if (target.GetComponent<Renderer>())
		{
			color = (color2 = target.GetComponent<Renderer>().material.color);
		}
		else if (target.GetComponent<Light>())
		{
			color = (color2 = target.GetComponent<Light>().color);
		}
		if (args.Contains("color"))
		{
			color = (Color)args["color"];
		}
		else
		{
			if (args.Contains("r"))
			{
				color.r = (float)args["r"];
			}
			if (args.Contains("g"))
			{
				color.g = (float)args["g"];
			}
			if (args.Contains("b"))
			{
				color.b = (float)args["b"];
			}
			if (args.Contains("a"))
			{
				color.a = (float)args["a"];
			}
		}
		if (args.Contains("amount"))
		{
			color.a = (float)args["amount"];
			args.Remove("amount");
		}
		else if (args.Contains("alpha"))
		{
			color.a = (float)args["alpha"];
			args.Remove("alpha");
		}
		if (target.GetComponent<Renderer>())
		{
			target.GetComponent<Renderer>().material.color = color;
		}
		else if (target.GetComponent<Light>())
		{
			target.GetComponent<Light>().color = color;
		}
		args["color"] = color2;
		args["type"] = "color";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000A9314 File Offset: 0x000A7514
	public static void ColorTo(GameObject target, Color color, float time)
	{
		iTween.ColorTo(target, iTween.Hash(new object[]
		{
			"color",
			color,
			"time",
			time
		}));
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000A934C File Offset: 0x000A754C
	public static void ColorTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (object obj in target.transform)
			{
				Component component = (Transform)obj;
				Hashtable hashtable = (Hashtable)args.Clone();
				hashtable["ischild"] = true;
				iTween.ColorTo(component.gameObject, hashtable);
			}
		}
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", iTween.EaseType.linear);
		}
		args["type"] = "color";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x000A9434 File Offset: 0x000A7634
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
		iTween.AudioFrom(target, iTween.Hash(new object[]
		{
			"volume",
			volume,
			"pitch",
			pitch,
			"time",
			time
		}));
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x000A9488 File Offset: 0x000A7688
	public static void AudioFrom(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		AudioSource audioSource;
		if (args.Contains("audiosource"))
		{
			audioSource = (AudioSource)args["audiosource"];
		}
		else
		{
			if (!target.GetComponent(typeof(AudioSource)))
			{
				Debug.LogError("iTween Error: AudioFrom requires an AudioSource.");
				return;
			}
			audioSource = target.GetComponent<AudioSource>();
		}
		Vector2 vector;
		Vector2 vector2;
		vector.x = (vector2.x = audioSource.volume);
		vector.y = (vector2.y = audioSource.pitch);
		if (args.Contains("volume"))
		{
			vector2.x = (float)args["volume"];
		}
		if (args.Contains("pitch"))
		{
			vector2.y = (float)args["pitch"];
		}
		audioSource.volume = vector2.x;
		audioSource.pitch = vector2.y;
		args["volume"] = vector.x;
		args["pitch"] = vector.y;
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", iTween.EaseType.linear);
		}
		args["type"] = "audio";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x000A95EC File Offset: 0x000A77EC
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
		iTween.AudioTo(target, iTween.Hash(new object[]
		{
			"volume",
			volume,
			"pitch",
			pitch,
			"time",
			time
		}));
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000A9640 File Offset: 0x000A7840
	public static void AudioTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (!args.Contains("easetype"))
		{
			args.Add("easetype", iTween.EaseType.linear);
		}
		args["type"] = "audio";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000A969D File Offset: 0x000A789D
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
		iTween.Stab(target, iTween.Hash(new object[]
		{
			"audioclip",
			audioclip,
			"delay",
			delay
		}));
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x000A96CD File Offset: 0x000A78CD
	public static void Stab(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "stab";
		iTween.Launch(target, args);
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x000A96F0 File Offset: 0x000A78F0
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
		iTween.LookFrom(target, iTween.Hash(new object[]
		{
			"looktarget",
			looktarget,
			"time",
			time
		}));
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x000A9728 File Offset: 0x000A7928
	public static void LookFrom(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		Vector3 eulerAngles = target.transform.eulerAngles;
		if (args["looktarget"].GetType() == typeof(Transform))
		{
			target.transform.LookAt((Transform)args["looktarget"], ((Vector3?)args["up"]) ?? iTween.Defaults.up);
		}
		else if (args["looktarget"].GetType() == typeof(Vector3))
		{
			target.transform.LookAt((Vector3)args["looktarget"], ((Vector3?)args["up"]) ?? iTween.Defaults.up);
		}
		if (args.Contains("axis"))
		{
			Vector3 eulerAngles2 = target.transform.eulerAngles;
			string text = (string)args["axis"];
			if (text != null)
			{
				if (!(text == "x"))
				{
					if (!(text == "y"))
					{
						if (text == "z")
						{
							eulerAngles2.x = eulerAngles.x;
							eulerAngles2.y = eulerAngles.y;
						}
					}
					else
					{
						eulerAngles2.x = eulerAngles.x;
						eulerAngles2.z = eulerAngles.z;
					}
				}
				else
				{
					eulerAngles2.y = eulerAngles.y;
					eulerAngles2.z = eulerAngles.z;
				}
			}
			target.transform.eulerAngles = eulerAngles2;
		}
		args["rotation"] = eulerAngles;
		args["type"] = "rotate";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000A9907 File Offset: 0x000A7B07
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
		iTween.LookTo(target, iTween.Hash(new object[]
		{
			"looktarget",
			looktarget,
			"time",
			time
		}));
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000A993C File Offset: 0x000A7B3C
	public static void LookTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (args.Contains("looktarget") && args["looktarget"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["looktarget"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
		}
		args["type"] = "look";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000A9A28 File Offset: 0x000A7C28
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
		iTween.MoveTo(target, iTween.Hash(new object[]
		{
			"position",
			position,
			"time",
			time
		}));
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000A9A60 File Offset: 0x000A7C60
	public static void MoveTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (args.Contains("position") && args["position"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["position"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "move";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x000A9B85 File Offset: 0x000A7D85
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
		iTween.MoveFrom(target, iTween.Hash(new object[]
		{
			"position",
			position,
			"time",
			time
		}));
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000A9BBC File Offset: 0x000A7DBC
	public static void MoveFrom(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		bool flag;
		if (args.Contains("islocal"))
		{
			flag = (bool)args["islocal"];
		}
		else
		{
			flag = iTween.Defaults.isLocal;
		}
		if (args.Contains("path"))
		{
			Vector3[] array2;
			if (args["path"].GetType() == typeof(Vector3[]))
			{
				Vector3[] array = (Vector3[])args["path"];
				array2 = new Vector3[array.Length];
				Array.Copy(array, array2, array.Length);
			}
			else
			{
				Transform[] array3 = (Transform[])args["path"];
				array2 = new Vector3[array3.Length];
				for (int i = 0; i < array3.Length; i++)
				{
					array2[i] = array3[i].position;
				}
			}
			if (array2[array2.Length - 1] != target.transform.position)
			{
				Vector3[] array4 = new Vector3[array2.Length + 1];
				Array.Copy(array2, array4, array2.Length);
				if (flag)
				{
					array4[array4.Length - 1] = target.transform.localPosition;
					target.transform.localPosition = array4[0];
				}
				else
				{
					array4[array4.Length - 1] = target.transform.position;
					target.transform.position = array4[0];
				}
				args["path"] = array4;
			}
			else
			{
				if (flag)
				{
					target.transform.localPosition = array2[0];
				}
				else
				{
					target.transform.position = array2[0];
				}
				args["path"] = array2;
			}
		}
		else
		{
			Vector3 vector2;
			Vector3 vector;
			if (flag)
			{
				vector = (vector2 = target.transform.localPosition);
			}
			else
			{
				vector = (vector2 = target.transform.position);
			}
			if (args.Contains("position"))
			{
				if (args["position"].GetType() == typeof(Transform))
				{
					vector = ((Transform)args["position"]).position;
				}
				else if (args["position"].GetType() == typeof(Vector3))
				{
					vector = (Vector3)args["position"];
				}
			}
			else
			{
				if (args.Contains("x"))
				{
					vector.x = (float)args["x"];
				}
				if (args.Contains("y"))
				{
					vector.y = (float)args["y"];
				}
				if (args.Contains("z"))
				{
					vector.z = (float)args["z"];
				}
			}
			if (flag)
			{
				target.transform.localPosition = vector;
			}
			else
			{
				target.transform.position = vector;
			}
			args["position"] = vector2;
		}
		args["type"] = "move";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000A9ED1 File Offset: 0x000A80D1
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
		iTween.MoveAdd(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000A9F06 File Offset: 0x000A8106
	public static void MoveAdd(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "move";
		args["method"] = "add";
		iTween.Launch(target, args);
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x000A9F39 File Offset: 0x000A8139
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
		iTween.MoveBy(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x000A9F6E File Offset: 0x000A816E
	public static void MoveBy(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "move";
		args["method"] = "by";
		iTween.Launch(target, args);
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000A9FA1 File Offset: 0x000A81A1
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
		iTween.ScaleTo(target, iTween.Hash(new object[]
		{
			"scale",
			scale,
			"time",
			time
		}));
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000A9FD8 File Offset: 0x000A81D8
	public static void ScaleTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (args.Contains("scale") && args["scale"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["scale"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "scale";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x000AA0FD File Offset: 0x000A82FD
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
		iTween.ScaleFrom(target, iTween.Hash(new object[]
		{
			"scale",
			scale,
			"time",
			time
		}));
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000AA134 File Offset: 0x000A8334
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		Vector3 localScale2;
		Vector3 localScale = localScale2 = target.transform.localScale;
		if (args.Contains("scale"))
		{
			if (args["scale"].GetType() == typeof(Transform))
			{
				localScale = ((Transform)args["scale"]).localScale;
			}
			else if (args["scale"].GetType() == typeof(Vector3))
			{
				localScale = (Vector3)args["scale"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				localScale.x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				localScale.y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				localScale.z = (float)args["z"];
			}
		}
		target.transform.localScale = localScale;
		args["scale"] = localScale2;
		args["type"] = "scale";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x000AA289 File Offset: 0x000A8489
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
		iTween.ScaleAdd(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x000AA2BE File Offset: 0x000A84BE
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "scale";
		args["method"] = "add";
		iTween.Launch(target, args);
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x000AA2F1 File Offset: 0x000A84F1
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
		iTween.ScaleBy(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000AA326 File Offset: 0x000A8526
	public static void ScaleBy(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "scale";
		args["method"] = "by";
		iTween.Launch(target, args);
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000AA359 File Offset: 0x000A8559
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
		iTween.RotateTo(target, iTween.Hash(new object[]
		{
			"rotation",
			rotation,
			"time",
			time
		}));
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000AA390 File Offset: 0x000A8590
	public static void RotateTo(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		if (args.Contains("rotation") && args["rotation"].GetType() == typeof(Transform))
		{
			Transform transform = (Transform)args["rotation"];
			args["position"] = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			args["rotation"] = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
			args["scale"] = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		}
		args["type"] = "rotate";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x000AA4B5 File Offset: 0x000A86B5
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
		iTween.RotateFrom(target, iTween.Hash(new object[]
		{
			"rotation",
			rotation,
			"time",
			time
		}));
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x000AA4EC File Offset: 0x000A86EC
	public static void RotateFrom(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		bool flag;
		if (args.Contains("islocal"))
		{
			flag = (bool)args["islocal"];
		}
		else
		{
			flag = iTween.Defaults.isLocal;
		}
		Vector3 vector2;
		Vector3 vector;
		if (flag)
		{
			vector = (vector2 = target.transform.localEulerAngles);
		}
		else
		{
			vector = (vector2 = target.transform.eulerAngles);
		}
		if (args.Contains("rotation"))
		{
			if (args["rotation"].GetType() == typeof(Transform))
			{
				vector = ((Transform)args["rotation"]).eulerAngles;
			}
			else if (args["rotation"].GetType() == typeof(Vector3))
			{
				vector = (Vector3)args["rotation"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				vector.x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				vector.y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				vector.z = (float)args["z"];
			}
		}
		if (flag)
		{
			target.transform.localEulerAngles = vector;
		}
		else
		{
			target.transform.eulerAngles = vector;
		}
		args["rotation"] = vector2;
		args["type"] = "rotate";
		args["method"] = "to";
		iTween.Launch(target, args);
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000AA68B File Offset: 0x000A888B
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
		iTween.RotateAdd(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000AA6C0 File Offset: 0x000A88C0
	public static void RotateAdd(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "rotate";
		args["method"] = "add";
		iTween.Launch(target, args);
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000AA6F3 File Offset: 0x000A88F3
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
		iTween.RotateBy(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000AA728 File Offset: 0x000A8928
	public static void RotateBy(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "rotate";
		args["method"] = "by";
		iTween.Launch(target, args);
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000AA75B File Offset: 0x000A895B
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
		iTween.ShakePosition(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000AA790 File Offset: 0x000A8990
	public static void ShakePosition(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "position";
		iTween.Launch(target, args);
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000AA7C3 File Offset: 0x000A89C3
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
		iTween.ShakeScale(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000AA7F8 File Offset: 0x000A89F8
	public static void ShakeScale(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "scale";
		iTween.Launch(target, args);
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x000AA82B File Offset: 0x000A8A2B
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
		iTween.ShakeRotation(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x000AA860 File Offset: 0x000A8A60
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "shake";
		args["method"] = "rotation";
		iTween.Launch(target, args);
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x000AA893 File Offset: 0x000A8A93
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
		iTween.PunchPosition(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000AA8C8 File Offset: 0x000A8AC8
	public static void PunchPosition(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "position";
		args["easetype"] = iTween.EaseType.punch;
		iTween.Launch(target, args);
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000AA918 File Offset: 0x000A8B18
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
		iTween.PunchRotation(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x000AA950 File Offset: 0x000A8B50
	public static void PunchRotation(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "rotation";
		args["easetype"] = iTween.EaseType.punch;
		iTween.Launch(target, args);
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x000AA9A0 File Offset: 0x000A8BA0
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
		iTween.PunchScale(target, iTween.Hash(new object[]
		{
			"amount",
			amount,
			"time",
			time
		}));
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x000AA9D8 File Offset: 0x000A8BD8
	public static void PunchScale(GameObject target, Hashtable args)
	{
		args = iTween.CleanArgs(args);
		args["type"] = "punch";
		args["method"] = "scale";
		args["easetype"] = iTween.EaseType.punch;
		iTween.Launch(target, args);
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x000AAA28 File Offset: 0x000A8C28
	private void GenerateTargets()
	{
		string text = this.type;
		if (text != null)
		{
			uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 2361356451U)
			{
				if (num <= 1031692888U)
				{
					if (num != 407568404U)
					{
						if (num != 1031692888U)
						{
							return;
						}
						if (!(text == "color"))
						{
							return;
						}
						string text2 = this.method;
						if (text2 != null && text2 == "to")
						{
							this.GenerateColorToTargets();
							this.apply = new iTween.ApplyTween(this.ApplyColorToTargets);
							return;
						}
					}
					else
					{
						if (!(text == "move"))
						{
							return;
						}
						string text2 = this.method;
						if (text2 != null)
						{
							if (!(text2 == "to"))
							{
								if (!(text2 == "by") && !(text2 == "add"))
								{
									return;
								}
								this.GenerateMoveByTargets();
								this.apply = new iTween.ApplyTween(this.ApplyMoveByTargets);
								return;
							}
							else
							{
								if (this.tweenArguments.Contains("path"))
								{
									this.GenerateMoveToPathTargets();
									this.apply = new iTween.ApplyTween(this.ApplyMoveToPathTargets);
									return;
								}
								this.GenerateMoveToTargets();
								this.apply = new iTween.ApplyTween(this.ApplyMoveToTargets);
								return;
							}
						}
					}
				}
				else if (num != 1113510858U)
				{
					if (num != 2190941297U)
					{
						if (num != 2361356451U)
						{
							return;
						}
						if (!(text == "punch"))
						{
							return;
						}
						string text2 = this.method;
						if (text2 != null)
						{
							if (text2 == "position")
							{
								this.GeneratePunchPositionTargets();
								this.apply = new iTween.ApplyTween(this.ApplyPunchPositionTargets);
								return;
							}
							if (text2 == "rotation")
							{
								this.GeneratePunchRotationTargets();
								this.apply = new iTween.ApplyTween(this.ApplyPunchRotationTargets);
								return;
							}
							if (!(text2 == "scale"))
							{
								return;
							}
							this.GeneratePunchScaleTargets();
							this.apply = new iTween.ApplyTween(this.ApplyPunchScaleTargets);
							return;
						}
					}
					else
					{
						if (!(text == "scale"))
						{
							return;
						}
						string text2 = this.method;
						if (text2 != null)
						{
							if (text2 == "to")
							{
								this.GenerateScaleToTargets();
								this.apply = new iTween.ApplyTween(this.ApplyScaleToTargets);
								return;
							}
							if (text2 == "by")
							{
								this.GenerateScaleByTargets();
								this.apply = new iTween.ApplyTween(this.ApplyScaleToTargets);
								return;
							}
							if (!(text2 == "add"))
							{
								return;
							}
							this.GenerateScaleAddTargets();
							this.apply = new iTween.ApplyTween(this.ApplyScaleToTargets);
							return;
						}
					}
				}
				else
				{
					if (!(text == "value"))
					{
						return;
					}
					string text2 = this.method;
					if (text2 != null)
					{
						if (text2 == "float")
						{
							this.GenerateFloatTargets();
							this.apply = new iTween.ApplyTween(this.ApplyFloatTargets);
							return;
						}
						if (text2 == "vector2")
						{
							this.GenerateVector2Targets();
							this.apply = new iTween.ApplyTween(this.ApplyVector2Targets);
							return;
						}
						if (text2 == "vector3")
						{
							this.GenerateVector3Targets();
							this.apply = new iTween.ApplyTween(this.ApplyVector3Targets);
							return;
						}
						if (text2 == "color")
						{
							this.GenerateColorTargets();
							this.apply = new iTween.ApplyTween(this.ApplyColorTargets);
							return;
						}
						if (!(text2 == "rect"))
						{
							return;
						}
						this.GenerateRectTargets();
						this.apply = new iTween.ApplyTween(this.ApplyRectTargets);
						return;
					}
				}
			}
			else if (num <= 3180049141U)
			{
				if (num != 2784296202U)
				{
					if (num != 3180049141U)
					{
						return;
					}
					if (!(text == "shake"))
					{
						return;
					}
					string text2 = this.method;
					if (text2 != null)
					{
						if (text2 == "position")
						{
							this.GenerateShakePositionTargets();
							this.apply = new iTween.ApplyTween(this.ApplyShakePositionTargets);
							return;
						}
						if (text2 == "scale")
						{
							this.GenerateShakeScaleTargets();
							this.apply = new iTween.ApplyTween(this.ApplyShakeScaleTargets);
							return;
						}
						if (!(text2 == "rotation"))
						{
							return;
						}
						this.GenerateShakeRotationTargets();
						this.apply = new iTween.ApplyTween(this.ApplyShakeRotationTargets);
						return;
					}
				}
				else
				{
					if (!(text == "rotate"))
					{
						return;
					}
					string text2 = this.method;
					if (text2 != null)
					{
						if (text2 == "to")
						{
							this.GenerateRotateToTargets();
							this.apply = new iTween.ApplyTween(this.ApplyRotateToTargets);
							return;
						}
						if (text2 == "add")
						{
							this.GenerateRotateAddTargets();
							this.apply = new iTween.ApplyTween(this.ApplyRotateAddTargets);
							return;
						}
						if (!(text2 == "by"))
						{
							return;
						}
						this.GenerateRotateByTargets();
						this.apply = new iTween.ApplyTween(this.ApplyRotateAddTargets);
						return;
					}
				}
			}
			else if (num != 3764468121U)
			{
				if (num != 3778758817U)
				{
					if (num != 3874444950U)
					{
						return;
					}
					if (!(text == "look"))
					{
						return;
					}
					string text2 = this.method;
					if (text2 != null && text2 == "to")
					{
						this.GenerateLookToTargets();
						this.apply = new iTween.ApplyTween(this.ApplyLookToTargets);
						return;
					}
				}
				else
				{
					if (!(text == "stab"))
					{
						return;
					}
					this.GenerateStabTargets();
					this.apply = new iTween.ApplyTween(this.ApplyStabTargets);
				}
			}
			else
			{
				if (!(text == "audio"))
				{
					return;
				}
				string text2 = this.method;
				if (text2 != null && text2 == "to")
				{
					this.GenerateAudioToTargets();
					this.apply = new iTween.ApplyTween(this.ApplyAudioToTargets);
					return;
				}
			}
		}
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x000AAF88 File Offset: 0x000A9188
	private void GenerateRectTargets()
	{
		this.rects = new Rect[3];
		this.rects[0] = (Rect)this.tweenArguments["from"];
		this.rects[1] = (Rect)this.tweenArguments["to"];
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x000AAFE4 File Offset: 0x000A91E4
	private void GenerateColorTargets()
	{
		this.colors = new Color[1, 3];
		this.colors[0, 0] = (Color)this.tweenArguments["from"];
		this.colors[0, 1] = (Color)this.tweenArguments["to"];
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000AB044 File Offset: 0x000A9244
	private void GenerateVector3Targets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = (Vector3)this.tweenArguments["from"];
		this.vector3s[1] = (Vector3)this.tweenArguments["to"];
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x000AB0F4 File Offset: 0x000A92F4
	private void GenerateVector2Targets()
	{
		this.vector2s = new Vector2[3];
		this.vector2s[0] = (Vector2)this.tweenArguments["from"];
		this.vector2s[1] = (Vector2)this.tweenArguments["to"];
		if (this.tweenArguments.Contains("speed"))
		{
			Vector3 a = new Vector3(this.vector2s[0].x, this.vector2s[0].y, 0f);
			Vector3 b = new Vector3(this.vector2s[1].x, this.vector2s[1].y, 0f);
			float num = Math.Abs(Vector3.Distance(a, b));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000AB1E8 File Offset: 0x000A93E8
	private void GenerateFloatTargets()
	{
		this.floats = new float[3];
		this.floats[0] = (float)this.tweenArguments["from"];
		this.floats[1] = (float)this.tweenArguments["to"];
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(this.floats[0] - this.floats[1]);
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000AB284 File Offset: 0x000A9484
	private void GenerateColorToTargets()
	{
		if (base.GetComponent<Renderer>())
		{
			this.colors = new Color[base.GetComponent<Renderer>().materials.Length, 3];
			for (int i = 0; i < base.GetComponent<Renderer>().materials.Length; i++)
			{
				this.colors[i, 0] = base.GetComponent<Renderer>().materials[i].GetColor(this.namedcolorvalue.ToString());
				this.colors[i, 1] = base.GetComponent<Renderer>().materials[i].GetColor(this.namedcolorvalue.ToString());
			}
		}
		else if (base.GetComponent<Light>())
		{
			this.colors = new Color[1, 3];
			this.colors[0, 0] = (this.colors[0, 1] = base.GetComponent<Light>().color);
		}
		else
		{
			this.colors = new Color[1, 3];
		}
		if (this.tweenArguments.Contains("color"))
		{
			for (int j = 0; j < this.colors.GetLength(0); j++)
			{
				this.colors[j, 1] = (Color)this.tweenArguments["color"];
			}
		}
		else
		{
			if (this.tweenArguments.Contains("r"))
			{
				for (int k = 0; k < this.colors.GetLength(0); k++)
				{
					this.colors[k, 1].r = (float)this.tweenArguments["r"];
				}
			}
			if (this.tweenArguments.Contains("g"))
			{
				for (int l = 0; l < this.colors.GetLength(0); l++)
				{
					this.colors[l, 1].g = (float)this.tweenArguments["g"];
				}
			}
			if (this.tweenArguments.Contains("b"))
			{
				for (int m = 0; m < this.colors.GetLength(0); m++)
				{
					this.colors[m, 1].b = (float)this.tweenArguments["b"];
				}
			}
			if (this.tweenArguments.Contains("a"))
			{
				for (int n = 0; n < this.colors.GetLength(0); n++)
				{
					this.colors[n, 1].a = (float)this.tweenArguments["a"];
				}
			}
		}
		if (this.tweenArguments.Contains("amount"))
		{
			for (int num = 0; num < this.colors.GetLength(0); num++)
			{
				this.colors[num, 1].a = (float)this.tweenArguments["amount"];
			}
			return;
		}
		if (this.tweenArguments.Contains("alpha"))
		{
			for (int num2 = 0; num2 < this.colors.GetLength(0); num2++)
			{
				this.colors[num2, 1].a = (float)this.tweenArguments["alpha"];
			}
		}
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000AB5D0 File Offset: 0x000A97D0
	private void GenerateAudioToTargets()
	{
		this.vector2s = new Vector2[3];
		if (this.tweenArguments.Contains("audiosource"))
		{
			this.audioSource = (AudioSource)this.tweenArguments["audiosource"];
		}
		else if (base.GetComponent(typeof(AudioSource)))
		{
			this.audioSource = base.GetComponent<AudioSource>();
		}
		else
		{
			Debug.LogError("iTween Error: AudioTo requires an AudioSource.");
			this.Dispose();
		}
		this.vector2s[0] = (this.vector2s[1] = new Vector2(this.audioSource.volume, this.audioSource.pitch));
		if (this.tweenArguments.Contains("volume"))
		{
			this.vector2s[1].x = (float)this.tweenArguments["volume"];
		}
		if (this.tweenArguments.Contains("pitch"))
		{
			this.vector2s[1].y = (float)this.tweenArguments["pitch"];
		}
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000AB6F4 File Offset: 0x000A98F4
	private void GenerateStabTargets()
	{
		if (this.tweenArguments.Contains("audiosource"))
		{
			this.audioSource = (AudioSource)this.tweenArguments["audiosource"];
		}
		else if (base.GetComponent(typeof(AudioSource)))
		{
			this.audioSource = base.GetComponent<AudioSource>();
		}
		else
		{
			base.gameObject.AddComponent(typeof(AudioSource));
			this.audioSource = base.GetComponent<AudioSource>();
			this.audioSource.playOnAwake = false;
		}
		this.audioSource.clip = (AudioClip)this.tweenArguments["audioclip"];
		if (this.tweenArguments.Contains("pitch"))
		{
			this.audioSource.pitch = (float)this.tweenArguments["pitch"];
		}
		if (this.tweenArguments.Contains("volume"))
		{
			this.audioSource.volume = (float)this.tweenArguments["volume"];
		}
		this.time = this.audioSource.clip.length / this.audioSource.pitch;
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000AB82C File Offset: 0x000A9A2C
	private void GenerateLookToTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = base.transform.eulerAngles;
		if (this.tweenArguments.Contains("looktarget"))
		{
			if (this.tweenArguments["looktarget"].GetType() == typeof(Transform))
			{
				base.transform.LookAt((Transform)this.tweenArguments["looktarget"], ((Vector3?)this.tweenArguments["up"]) ?? iTween.Defaults.up);
			}
			else if (this.tweenArguments["looktarget"].GetType() == typeof(Vector3))
			{
				base.transform.LookAt((Vector3)this.tweenArguments["looktarget"], ((Vector3?)this.tweenArguments["up"]) ?? iTween.Defaults.up);
			}
		}
		else
		{
			Debug.LogError("iTween Error: LookTo needs a 'looktarget' property!");
			this.Dispose();
		}
		this.vector3s[1] = base.transform.eulerAngles;
		base.transform.eulerAngles = this.vector3s[0];
		if (this.tweenArguments.Contains("axis"))
		{
			string text = (string)this.tweenArguments["axis"];
			if (text != null)
			{
				if (!(text == "x"))
				{
					if (!(text == "y"))
					{
						if (text == "z")
						{
							this.vector3s[1].x = this.vector3s[0].x;
							this.vector3s[1].y = this.vector3s[0].y;
						}
					}
					else
					{
						this.vector3s[1].x = this.vector3s[0].x;
						this.vector3s[1].z = this.vector3s[0].z;
					}
				}
				else
				{
					this.vector3s[1].y = this.vector3s[0].y;
					this.vector3s[1].z = this.vector3s[0].z;
				}
			}
		}
		this.vector3s[1] = new Vector3(this.clerp(this.vector3s[0].x, this.vector3s[1].x, 1f), this.clerp(this.vector3s[0].y, this.vector3s[1].y, 1f), this.clerp(this.vector3s[0].z, this.vector3s[1].z, 1f));
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000ABBBC File Offset: 0x000A9DBC
	private void GenerateMoveToPathTargets()
	{
		Vector3[] array2;
		if (this.tweenArguments["path"].GetType() == typeof(Vector3[]))
		{
			Vector3[] array = (Vector3[])this.tweenArguments["path"];
			if (array.Length == 1)
			{
				Debug.LogError("iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
				this.Dispose();
			}
			array2 = new Vector3[array.Length];
			Array.Copy(array, array2, array.Length);
		}
		else
		{
			Transform[] array3 = (Transform[])this.tweenArguments["path"];
			if (array3.Length == 1)
			{
				Debug.LogError("iTween Error: Attempting a path movement with MoveTo requires an array of more than 1 entry!");
				this.Dispose();
			}
			array2 = new Vector3[array3.Length];
			for (int i = 0; i < array3.Length; i++)
			{
				array2[i] = array3[i].position;
			}
		}
		bool flag;
		int num;
		if (base.transform.position != array2[0])
		{
			if (!this.tweenArguments.Contains("movetopath") || (bool)this.tweenArguments["movetopath"])
			{
				flag = true;
				num = 3;
			}
			else
			{
				flag = false;
				num = 2;
			}
		}
		else
		{
			flag = false;
			num = 2;
		}
		this.vector3s = new Vector3[array2.Length + num];
		if (flag)
		{
			this.vector3s[1] = base.transform.position;
			num = 2;
		}
		else
		{
			num = 1;
		}
		Array.Copy(array2, 0, this.vector3s, num, array2.Length);
		this.vector3s[0] = this.vector3s[1] + (this.vector3s[1] - this.vector3s[2]);
		this.vector3s[this.vector3s.Length - 1] = this.vector3s[this.vector3s.Length - 2] + (this.vector3s[this.vector3s.Length - 2] - this.vector3s[this.vector3s.Length - 3]);
		if (this.vector3s[1] == this.vector3s[this.vector3s.Length - 2])
		{
			Vector3[] array4 = new Vector3[this.vector3s.Length];
			Array.Copy(this.vector3s, array4, this.vector3s.Length);
			array4[0] = array4[array4.Length - 3];
			array4[array4.Length - 1] = array4[2];
			this.vector3s = new Vector3[array4.Length];
			Array.Copy(array4, this.vector3s, array4.Length);
		}
		this.path = new iTween.CRSpline(this.vector3s);
		if (this.tweenArguments.Contains("speed"))
		{
			float num2 = iTween.PathLength(this.vector3s);
			this.time = num2 / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000ABE9C File Offset: 0x000AA09C
	private void GenerateMoveToTargets()
	{
		this.vector3s = new Vector3[3];
		if (this.isLocal)
		{
			this.vector3s[0] = (this.vector3s[1] = base.transform.localPosition);
		}
		else
		{
			this.vector3s[0] = (this.vector3s[1] = base.transform.position);
		}
		if (this.tweenArguments.Contains("position"))
		{
			if (this.tweenArguments["position"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)this.tweenArguments["position"];
				this.vector3s[1] = transform.position;
			}
			else if (this.tweenArguments["position"].GetType() == typeof(Vector3))
			{
				this.vector3s[1] = (Vector3)this.tweenArguments["position"];
			}
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				this.vector3s[1].x = (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				this.vector3s[1].y = (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				this.vector3s[1].z = (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("orienttopath") && (bool)this.tweenArguments["orienttopath"])
		{
			this.tweenArguments["looktarget"] = this.vector3s[1];
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000AC108 File Offset: 0x000AA308
	private void GenerateMoveByTargets()
	{
		this.vector3s = new Vector3[6];
		this.vector3s[4] = base.transform.eulerAngles;
		this.vector3s[0] = (this.vector3s[1] = (this.vector3s[3] = base.transform.position));
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = this.vector3s[0] + (Vector3)this.tweenArguments["amount"];
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				this.vector3s[1].x = this.vector3s[0].x + (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				this.vector3s[1].y = this.vector3s[0].y + (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				this.vector3s[1].z = this.vector3s[0].z + (float)this.tweenArguments["z"];
			}
		}
		base.transform.Translate(this.vector3s[1], this.space);
		this.vector3s[5] = base.transform.position;
		base.transform.position = this.vector3s[0];
		if (this.tweenArguments.Contains("orienttopath") && (bool)this.tweenArguments["orienttopath"])
		{
			this.tweenArguments["looktarget"] = this.vector3s[1];
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000AC37C File Offset: 0x000AA57C
	private void GenerateScaleToTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = (this.vector3s[1] = base.transform.localScale);
		if (this.tweenArguments.Contains("scale"))
		{
			if (this.tweenArguments["scale"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)this.tweenArguments["scale"];
				this.vector3s[1] = transform.localScale;
			}
			else if (this.tweenArguments["scale"].GetType() == typeof(Vector3))
			{
				this.vector3s[1] = (Vector3)this.tweenArguments["scale"];
			}
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				this.vector3s[1].x = (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				this.vector3s[1].y = (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				this.vector3s[1].z = (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x000AC56C File Offset: 0x000AA76C
	private void GenerateScaleByTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = (this.vector3s[1] = base.transform.localScale);
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = Vector3.Scale(this.vector3s[1], (Vector3)this.tweenArguments["amount"]);
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				Vector3[] array = this.vector3s;
				int num = 1;
				array[num].x = array[num].x * (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				Vector3[] array2 = this.vector3s;
				int num2 = 1;
				array2[num2].y = array2[num2].y * (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				Vector3[] array3 = this.vector3s;
				int num3 = 1;
				array3[num3].z = array3[num3].z * (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num4 = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num4 / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000AC6FC File Offset: 0x000AA8FC
	private void GenerateScaleAddTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = (this.vector3s[1] = base.transform.localScale);
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] += (Vector3)this.tweenArguments["amount"];
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				Vector3[] array = this.vector3s;
				int num = 1;
				array[num].x = array[num].x + (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				Vector3[] array2 = this.vector3s;
				int num2 = 1;
				array2[num2].y = array2[num2].y + (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				Vector3[] array3 = this.vector3s;
				int num3 = 1;
				array3[num3].z = array3[num3].z + (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num4 = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num4 / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000AC88C File Offset: 0x000AAA8C
	private void GenerateRotateToTargets()
	{
		this.vector3s = new Vector3[3];
		if (this.isLocal)
		{
			this.vector3s[0] = (this.vector3s[1] = base.transform.localEulerAngles);
		}
		else
		{
			this.vector3s[0] = (this.vector3s[1] = base.transform.eulerAngles);
		}
		if (this.tweenArguments.Contains("rotation"))
		{
			if (this.tweenArguments["rotation"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)this.tweenArguments["rotation"];
				this.vector3s[1] = transform.eulerAngles;
			}
			else if (this.tweenArguments["rotation"].GetType() == typeof(Vector3))
			{
				this.vector3s[1] = (Vector3)this.tweenArguments["rotation"];
			}
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				this.vector3s[1].x = (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				this.vector3s[1].y = (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				this.vector3s[1].z = (float)this.tweenArguments["z"];
			}
		}
		this.vector3s[1] = new Vector3(this.clerp(this.vector3s[0].x, this.vector3s[1].x, 1f), this.clerp(this.vector3s[0].y, this.vector3s[1].y, 1f), this.clerp(this.vector3s[0].z, this.vector3s[1].z, 1f));
		if (this.tweenArguments.Contains("speed"))
		{
			float num = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000ACB44 File Offset: 0x000AAD44
	private void GenerateRotateAddTargets()
	{
		this.vector3s = new Vector3[5];
		this.vector3s[0] = (this.vector3s[1] = (this.vector3s[3] = base.transform.eulerAngles));
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] += (Vector3)this.tweenArguments["amount"];
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				Vector3[] array = this.vector3s;
				int num = 1;
				array[num].x = array[num].x + (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				Vector3[] array2 = this.vector3s;
				int num2 = 1;
				array2[num2].y = array2[num2].y + (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				Vector3[] array3 = this.vector3s;
				int num3 = 1;
				array3[num3].z = array3[num3].z + (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num4 = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num4 / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
	private void GenerateRotateByTargets()
	{
		this.vector3s = new Vector3[4];
		this.vector3s[0] = (this.vector3s[1] = (this.vector3s[3] = base.transform.eulerAngles));
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] += Vector3.Scale((Vector3)this.tweenArguments["amount"], new Vector3(360f, 360f, 360f));
		}
		else
		{
			if (this.tweenArguments.Contains("x"))
			{
				Vector3[] array = this.vector3s;
				int num = 1;
				array[num].x = array[num].x + 360f * (float)this.tweenArguments["x"];
			}
			if (this.tweenArguments.Contains("y"))
			{
				Vector3[] array2 = this.vector3s;
				int num2 = 1;
				array2[num2].y = array2[num2].y + 360f * (float)this.tweenArguments["y"];
			}
			if (this.tweenArguments.Contains("z"))
			{
				Vector3[] array3 = this.vector3s;
				int num3 = 1;
				array3[num3].z = array3[num3].z + 360f * (float)this.tweenArguments["z"];
			}
		}
		if (this.tweenArguments.Contains("speed"))
		{
			float num4 = Math.Abs(Vector3.Distance(this.vector3s[0], this.vector3s[1]));
			this.time = num4 / (float)this.tweenArguments["speed"];
		}
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x000ACEA8 File Offset: 0x000AB0A8
	private void GenerateShakePositionTargets()
	{
		this.vector3s = new Vector3[4];
		this.vector3s[3] = base.transform.eulerAngles;
		this.vector3s[0] = base.transform.position;
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000ACFCC File Offset: 0x000AB1CC
	private void GenerateShakeScaleTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = base.transform.localScale;
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021DA RID: 8666 RVA: 0x000AD0D8 File Offset: 0x000AB2D8
	private void GenerateShakeRotationTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = base.transform.eulerAngles;
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000AD1E4 File Offset: 0x000AB3E4
	private void GeneratePunchPositionTargets()
	{
		this.vector3s = new Vector3[5];
		this.vector3s[4] = base.transform.eulerAngles;
		this.vector3s[0] = base.transform.position;
		this.vector3s[1] = (this.vector3s[3] = Vector3.zero);
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000AD328 File Offset: 0x000AB528
	private void GeneratePunchRotationTargets()
	{
		this.vector3s = new Vector3[4];
		this.vector3s[0] = base.transform.eulerAngles;
		this.vector3s[1] = (this.vector3s[3] = Vector3.zero);
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000AD454 File Offset: 0x000AB654
	private void GeneratePunchScaleTargets()
	{
		this.vector3s = new Vector3[3];
		this.vector3s[0] = base.transform.localScale;
		this.vector3s[1] = Vector3.zero;
		if (this.tweenArguments.Contains("amount"))
		{
			this.vector3s[1] = (Vector3)this.tweenArguments["amount"];
			return;
		}
		if (this.tweenArguments.Contains("x"))
		{
			this.vector3s[1].x = (float)this.tweenArguments["x"];
		}
		if (this.tweenArguments.Contains("y"))
		{
			this.vector3s[1].y = (float)this.tweenArguments["y"];
		}
		if (this.tweenArguments.Contains("z"))
		{
			this.vector3s[1].z = (float)this.tweenArguments["z"];
		}
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000AD574 File Offset: 0x000AB774
	private void ApplyRectTargets()
	{
		this.rects[2].x = this.ease(this.rects[0].x, this.rects[1].x, this.percentage);
		this.rects[2].y = this.ease(this.rects[0].y, this.rects[1].y, this.percentage);
		this.rects[2].width = this.ease(this.rects[0].width, this.rects[1].width, this.percentage);
		this.rects[2].height = this.ease(this.rects[0].height, this.rects[1].height, this.percentage);
		this.tweenArguments["onupdateparams"] = this.rects[2];
		if (this.percentage == 1f)
		{
			this.tweenArguments["onupdateparams"] = this.rects[1];
		}
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000AD6E0 File Offset: 0x000AB8E0
	private void ApplyColorTargets()
	{
		this.colors[0, 2].r = this.ease(this.colors[0, 0].r, this.colors[0, 1].r, this.percentage);
		this.colors[0, 2].g = this.ease(this.colors[0, 0].g, this.colors[0, 1].g, this.percentage);
		this.colors[0, 2].b = this.ease(this.colors[0, 0].b, this.colors[0, 1].b, this.percentage);
		this.colors[0, 2].a = this.ease(this.colors[0, 0].a, this.colors[0, 1].a, this.percentage);
		this.tweenArguments["onupdateparams"] = this.colors[0, 2];
		if (this.percentage == 1f)
		{
			this.tweenArguments["onupdateparams"] = this.colors[0, 1];
		}
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000AD85C File Offset: 0x000ABA5C
	private void ApplyVector3Targets()
	{
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		this.tweenArguments["onupdateparams"] = this.vector3s[2];
		if (this.percentage == 1f)
		{
			this.tweenArguments["onupdateparams"] = this.vector3s[1];
		}
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000AD984 File Offset: 0x000ABB84
	private void ApplyVector2Targets()
	{
		this.vector2s[2].x = this.ease(this.vector2s[0].x, this.vector2s[1].x, this.percentage);
		this.vector2s[2].y = this.ease(this.vector2s[0].y, this.vector2s[1].y, this.percentage);
		this.tweenArguments["onupdateparams"] = this.vector2s[2];
		if (this.percentage == 1f)
		{
			this.tweenArguments["onupdateparams"] = this.vector2s[1];
		}
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x000ADA68 File Offset: 0x000ABC68
	private void ApplyFloatTargets()
	{
		this.floats[2] = this.ease(this.floats[0], this.floats[1], this.percentage);
		this.tweenArguments["onupdateparams"] = this.floats[2];
		if (this.percentage == 1f)
		{
			this.tweenArguments["onupdateparams"] = this.floats[1];
		}
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000ADAE8 File Offset: 0x000ABCE8
	private void ApplyColorToTargets()
	{
		for (int i = 0; i < this.colors.GetLength(0); i++)
		{
			this.colors[i, 2].r = this.ease(this.colors[i, 0].r, this.colors[i, 1].r, this.percentage);
			this.colors[i, 2].g = this.ease(this.colors[i, 0].g, this.colors[i, 1].g, this.percentage);
			this.colors[i, 2].b = this.ease(this.colors[i, 0].b, this.colors[i, 1].b, this.percentage);
			this.colors[i, 2].a = this.ease(this.colors[i, 0].a, this.colors[i, 1].a, this.percentage);
		}
		if (base.GetComponent<Renderer>())
		{
			for (int j = 0; j < this.colors.GetLength(0); j++)
			{
				base.GetComponent<Renderer>().materials[j].SetColor(this.namedcolorvalue.ToString(), this.colors[j, 2]);
			}
		}
		else if (base.GetComponent<Light>())
		{
			base.GetComponent<Light>().color = this.colors[0, 2];
		}
		if (this.percentage == 1f)
		{
			if (base.GetComponent<Renderer>())
			{
				for (int k = 0; k < this.colors.GetLength(0); k++)
				{
					base.GetComponent<Renderer>().materials[k].SetColor(this.namedcolorvalue.ToString(), this.colors[k, 1]);
				}
				return;
			}
			if (base.GetComponent<Light>())
			{
				base.GetComponent<Light>().color = this.colors[0, 1];
			}
		}
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000ADD34 File Offset: 0x000ABF34
	private void ApplyAudioToTargets()
	{
		this.vector2s[2].x = this.ease(this.vector2s[0].x, this.vector2s[1].x, this.percentage);
		this.vector2s[2].y = this.ease(this.vector2s[0].y, this.vector2s[1].y, this.percentage);
		this.audioSource.volume = this.vector2s[2].x;
		this.audioSource.pitch = this.vector2s[2].y;
		if (this.percentage == 1f)
		{
			this.audioSource.volume = this.vector2s[1].x;
			this.audioSource.pitch = this.vector2s[1].y;
		}
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x00003603 File Offset: 0x00001803
	private void ApplyStabTargets()
	{
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000ADE48 File Offset: 0x000AC048
	private void ApplyMoveToPathTargets()
	{
		this.preUpdate = base.transform.position;
		float value = this.ease(0f, 1f, this.percentage);
		if (this.isLocal)
		{
			base.transform.localPosition = this.path.Interp(Mathf.Clamp(value, 0f, 1f));
		}
		else
		{
			base.transform.position = this.path.Interp(Mathf.Clamp(value, 0f, 1f));
		}
		if (this.tweenArguments.Contains("orienttopath") && (bool)this.tweenArguments["orienttopath"])
		{
			float num;
			if (this.tweenArguments.Contains("lookahead"))
			{
				num = (float)this.tweenArguments["lookahead"];
			}
			else
			{
				num = iTween.Defaults.lookAhead;
			}
			float value2 = this.ease(0f, 1f, Mathf.Min(1f, this.percentage + num));
			this.tweenArguments["looktarget"] = this.path.Interp(Mathf.Clamp(value2, 0f, 1f));
		}
		this.postUpdate = base.transform.position;
		if (this.physics)
		{
			base.transform.position = this.preUpdate;
			base.GetComponent<Rigidbody>().MovePosition(this.postUpdate);
		}
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000ADFCC File Offset: 0x000AC1CC
	private void ApplyMoveToTargets()
	{
		this.preUpdate = base.transform.position;
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		if (this.isLocal)
		{
			base.transform.localPosition = this.vector3s[2];
		}
		else
		{
			base.transform.position = this.vector3s[2];
		}
		if (this.percentage == 1f)
		{
			if (this.isLocal)
			{
				base.transform.localPosition = this.vector3s[1];
			}
			else
			{
				base.transform.position = this.vector3s[1];
			}
		}
		this.postUpdate = base.transform.position;
		if (this.physics)
		{
			base.transform.position = this.preUpdate;
			base.GetComponent<Rigidbody>().MovePosition(this.postUpdate);
		}
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000AE170 File Offset: 0x000AC370
	private void ApplyMoveByTargets()
	{
		this.preUpdate = base.transform.position;
		Vector3 eulerAngles = default(Vector3);
		if (this.tweenArguments.Contains("looktarget"))
		{
			eulerAngles = base.transform.eulerAngles;
			base.transform.eulerAngles = this.vector3s[4];
		}
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		base.transform.Translate(this.vector3s[2] - this.vector3s[3], this.space);
		this.vector3s[3] = this.vector3s[2];
		if (this.tweenArguments.Contains("looktarget"))
		{
			base.transform.eulerAngles = eulerAngles;
		}
		this.postUpdate = base.transform.position;
		if (this.physics)
		{
			base.transform.position = this.preUpdate;
			base.GetComponent<Rigidbody>().MovePosition(this.postUpdate);
		}
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x000AE338 File Offset: 0x000AC538
	private void ApplyScaleToTargets()
	{
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		base.transform.localScale = this.vector3s[2];
		if (this.percentage == 1f)
		{
			base.transform.localScale = this.vector3s[1];
		}
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000AE44C File Offset: 0x000AC64C
	private void ApplyLookToTargets()
	{
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		if (this.isLocal)
		{
			base.transform.localRotation = Quaternion.Euler(this.vector3s[2]);
			return;
		}
		base.transform.rotation = Quaternion.Euler(this.vector3s[2]);
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000AE568 File Offset: 0x000AC768
	private void ApplyRotateToTargets()
	{
		this.preUpdate = base.transform.eulerAngles;
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		if (this.isLocal)
		{
			base.transform.localRotation = Quaternion.Euler(this.vector3s[2]);
		}
		else
		{
			base.transform.rotation = Quaternion.Euler(this.vector3s[2]);
		}
		if (this.percentage == 1f)
		{
			if (this.isLocal)
			{
				base.transform.localRotation = Quaternion.Euler(this.vector3s[1]);
			}
			else
			{
				base.transform.rotation = Quaternion.Euler(this.vector3s[1]);
			}
		}
		this.postUpdate = base.transform.eulerAngles;
		if (this.physics)
		{
			base.transform.eulerAngles = this.preUpdate;
			base.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(this.postUpdate));
		}
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000AE724 File Offset: 0x000AC924
	private void ApplyRotateAddTargets()
	{
		this.preUpdate = base.transform.eulerAngles;
		this.vector3s[2].x = this.ease(this.vector3s[0].x, this.vector3s[1].x, this.percentage);
		this.vector3s[2].y = this.ease(this.vector3s[0].y, this.vector3s[1].y, this.percentage);
		this.vector3s[2].z = this.ease(this.vector3s[0].z, this.vector3s[1].z, this.percentage);
		base.transform.Rotate(this.vector3s[2] - this.vector3s[3], this.space);
		this.vector3s[3] = this.vector3s[2];
		this.postUpdate = base.transform.eulerAngles;
		if (this.physics)
		{
			base.transform.eulerAngles = this.preUpdate;
			base.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(this.postUpdate));
		}
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000AE894 File Offset: 0x000ACA94
	private void ApplyShakePositionTargets()
	{
		this.preUpdate = base.transform.position;
		Vector3 eulerAngles = default(Vector3);
		if (this.tweenArguments.Contains("looktarget"))
		{
			eulerAngles = base.transform.eulerAngles;
			base.transform.eulerAngles = this.vector3s[3];
		}
		if (this.percentage == 0f)
		{
			base.transform.Translate(this.vector3s[1], this.space);
		}
		base.transform.position = this.vector3s[0];
		float num = 1f - this.percentage;
		this.vector3s[2].x = UnityEngine.Random.Range(-this.vector3s[1].x * num, this.vector3s[1].x * num);
		this.vector3s[2].y = UnityEngine.Random.Range(-this.vector3s[1].y * num, this.vector3s[1].y * num);
		this.vector3s[2].z = UnityEngine.Random.Range(-this.vector3s[1].z * num, this.vector3s[1].z * num);
		base.transform.Translate(this.vector3s[2], this.space);
		if (this.tweenArguments.Contains("looktarget"))
		{
			base.transform.eulerAngles = eulerAngles;
		}
		this.postUpdate = base.transform.position;
		if (this.physics)
		{
			base.transform.position = this.preUpdate;
			base.GetComponent<Rigidbody>().MovePosition(this.postUpdate);
		}
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000AEA6C File Offset: 0x000ACC6C
	private void ApplyShakeScaleTargets()
	{
		if (this.percentage == 0f)
		{
			base.transform.localScale = this.vector3s[1];
		}
		base.transform.localScale = this.vector3s[0];
		float num = 1f - this.percentage;
		this.vector3s[2].x = UnityEngine.Random.Range(-this.vector3s[1].x * num, this.vector3s[1].x * num);
		this.vector3s[2].y = UnityEngine.Random.Range(-this.vector3s[1].y * num, this.vector3s[1].y * num);
		this.vector3s[2].z = UnityEngine.Random.Range(-this.vector3s[1].z * num, this.vector3s[1].z * num);
		base.transform.localScale += this.vector3s[2];
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000AEB9C File Offset: 0x000ACD9C
	private void ApplyShakeRotationTargets()
	{
		this.preUpdate = base.transform.eulerAngles;
		if (this.percentage == 0f)
		{
			base.transform.Rotate(this.vector3s[1], this.space);
		}
		base.transform.eulerAngles = this.vector3s[0];
		float num = 1f - this.percentage;
		this.vector3s[2].x = UnityEngine.Random.Range(-this.vector3s[1].x * num, this.vector3s[1].x * num);
		this.vector3s[2].y = UnityEngine.Random.Range(-this.vector3s[1].y * num, this.vector3s[1].y * num);
		this.vector3s[2].z = UnityEngine.Random.Range(-this.vector3s[1].z * num, this.vector3s[1].z * num);
		base.transform.Rotate(this.vector3s[2], this.space);
		this.postUpdate = base.transform.eulerAngles;
		if (this.physics)
		{
			base.transform.eulerAngles = this.preUpdate;
			base.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(this.postUpdate));
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000AED1C File Offset: 0x000ACF1C
	private void ApplyPunchPositionTargets()
	{
		this.preUpdate = base.transform.position;
		Vector3 eulerAngles = default(Vector3);
		if (this.tweenArguments.Contains("looktarget"))
		{
			eulerAngles = base.transform.eulerAngles;
			base.transform.eulerAngles = this.vector3s[4];
		}
		if (this.vector3s[1].x > 0f)
		{
			this.vector3s[2].x = this.punch(this.vector3s[1].x, this.percentage);
		}
		else if (this.vector3s[1].x < 0f)
		{
			this.vector3s[2].x = -this.punch(Mathf.Abs(this.vector3s[1].x), this.percentage);
		}
		if (this.vector3s[1].y > 0f)
		{
			this.vector3s[2].y = this.punch(this.vector3s[1].y, this.percentage);
		}
		else if (this.vector3s[1].y < 0f)
		{
			this.vector3s[2].y = -this.punch(Mathf.Abs(this.vector3s[1].y), this.percentage);
		}
		if (this.vector3s[1].z > 0f)
		{
			this.vector3s[2].z = this.punch(this.vector3s[1].z, this.percentage);
		}
		else if (this.vector3s[1].z < 0f)
		{
			this.vector3s[2].z = -this.punch(Mathf.Abs(this.vector3s[1].z), this.percentage);
		}
		base.transform.Translate(this.vector3s[2] - this.vector3s[3], this.space);
		this.vector3s[3] = this.vector3s[2];
		if (this.tweenArguments.Contains("looktarget"))
		{
			base.transform.eulerAngles = eulerAngles;
		}
		this.postUpdate = base.transform.position;
		if (this.physics)
		{
			base.transform.position = this.preUpdate;
			base.GetComponent<Rigidbody>().MovePosition(this.postUpdate);
		}
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000AEFD4 File Offset: 0x000AD1D4
	private void ApplyPunchRotationTargets()
	{
		this.preUpdate = base.transform.eulerAngles;
		if (this.vector3s[1].x > 0f)
		{
			this.vector3s[2].x = this.punch(this.vector3s[1].x, this.percentage);
		}
		else if (this.vector3s[1].x < 0f)
		{
			this.vector3s[2].x = -this.punch(Mathf.Abs(this.vector3s[1].x), this.percentage);
		}
		if (this.vector3s[1].y > 0f)
		{
			this.vector3s[2].y = this.punch(this.vector3s[1].y, this.percentage);
		}
		else if (this.vector3s[1].y < 0f)
		{
			this.vector3s[2].y = -this.punch(Mathf.Abs(this.vector3s[1].y), this.percentage);
		}
		if (this.vector3s[1].z > 0f)
		{
			this.vector3s[2].z = this.punch(this.vector3s[1].z, this.percentage);
		}
		else if (this.vector3s[1].z < 0f)
		{
			this.vector3s[2].z = -this.punch(Mathf.Abs(this.vector3s[1].z), this.percentage);
		}
		base.transform.Rotate(this.vector3s[2] - this.vector3s[3], this.space);
		this.vector3s[3] = this.vector3s[2];
		this.postUpdate = base.transform.eulerAngles;
		if (this.physics)
		{
			base.transform.eulerAngles = this.preUpdate;
			base.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(this.postUpdate));
		}
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000AF234 File Offset: 0x000AD434
	private void ApplyPunchScaleTargets()
	{
		if (this.vector3s[1].x > 0f)
		{
			this.vector3s[2].x = this.punch(this.vector3s[1].x, this.percentage);
		}
		else if (this.vector3s[1].x < 0f)
		{
			this.vector3s[2].x = -this.punch(Mathf.Abs(this.vector3s[1].x), this.percentage);
		}
		if (this.vector3s[1].y > 0f)
		{
			this.vector3s[2].y = this.punch(this.vector3s[1].y, this.percentage);
		}
		else if (this.vector3s[1].y < 0f)
		{
			this.vector3s[2].y = -this.punch(Mathf.Abs(this.vector3s[1].y), this.percentage);
		}
		if (this.vector3s[1].z > 0f)
		{
			this.vector3s[2].z = this.punch(this.vector3s[1].z, this.percentage);
		}
		else if (this.vector3s[1].z < 0f)
		{
			this.vector3s[2].z = -this.punch(Mathf.Abs(this.vector3s[1].z), this.percentage);
		}
		base.transform.localScale = this.vector3s[0] + this.vector3s[2];
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000AF425 File Offset: 0x000AD625
	private IEnumerator TweenDelay()
	{
		this.delayStarted = Time.time;
		yield return new WaitForSeconds(this.delay);
		if (this.wasPaused)
		{
			this.wasPaused = false;
			this.TweenStart();
		}
		yield break;
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000AF434 File Offset: 0x000AD634
	private void TweenStart()
	{
		this.CallBack("onstart");
		if (!this.loop)
		{
			this.ConflictCheck();
			this.GenerateTargets();
		}
		if (this.type == "stab")
		{
			this.audioSource.PlayOneShot(this.audioSource.clip);
		}
		if (this.type == "move" || this.type == "scale" || this.type == "rotate" || this.type == "punch" || this.type == "shake" || this.type == "curve" || this.type == "look")
		{
			this.EnableKinematic();
		}
		this.isRunning = true;
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000AF513 File Offset: 0x000AD713
	private IEnumerator TweenRestart()
	{
		if (this.delay > 0f)
		{
			this.delayStarted = Time.time;
			yield return new WaitForSeconds(this.delay);
		}
		this.loop = true;
		this.TweenStart();
		yield break;
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000AF522 File Offset: 0x000AD722
	private void TweenUpdate()
	{
		this.apply();
		this.CallBack("onupdate");
		this.UpdatePercentage();
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000AF540 File Offset: 0x000AD740
	private void TweenComplete()
	{
		this.isRunning = false;
		if (this.percentage > 0.5f)
		{
			this.percentage = 1f;
		}
		else
		{
			this.percentage = 0f;
		}
		this.apply();
		if (this.type == "value")
		{
			this.CallBack("onupdate");
		}
		if (this.loopType == iTween.LoopType.none)
		{
			this.Dispose();
		}
		else
		{
			this.TweenLoop();
		}
		this.CallBack("oncomplete");
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
	private void TweenLoop()
	{
		this.DisableKinematic();
		iTween.LoopType loopType = this.loopType;
		if (loopType == iTween.LoopType.loop)
		{
			this.percentage = 0f;
			this.runningTime = 0f;
			this.apply();
			base.StartCoroutine("TweenRestart");
			return;
		}
		if (loopType != iTween.LoopType.pingPong)
		{
			return;
		}
		this.reverse = !this.reverse;
		this.runningTime = 0f;
		base.StartCoroutine("TweenRestart");
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000AF63C File Offset: 0x000AD83C
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return new Rect(iTween.FloatUpdate(currentValue.x, targetValue.x, speed), iTween.FloatUpdate(currentValue.y, targetValue.y, speed), iTween.FloatUpdate(currentValue.width, targetValue.width, speed), iTween.FloatUpdate(currentValue.height, targetValue.height, speed));
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000AF6A0 File Offset: 0x000AD8A0
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		Vector3 a = targetValue - currentValue;
		currentValue += a * speed * Time.deltaTime;
		return currentValue;
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x000AF6D4 File Offset: 0x000AD8D4
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		Vector2 a = targetValue - currentValue;
		currentValue += a * speed * Time.deltaTime;
		return currentValue;
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000AF708 File Offset: 0x000AD908
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		float num = targetValue - currentValue;
		currentValue += num * speed * Time.deltaTime;
		return currentValue;
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000AF729 File Offset: 0x000AD929
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
		args["a"] = args["alpha"];
		iTween.ColorUpdate(target, args);
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x000AF748 File Offset: 0x000AD948
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
		iTween.FadeUpdate(target, iTween.Hash(new object[]
		{
			"alpha",
			alpha,
			"time",
			time
		}));
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x000AF780 File Offset: 0x000AD980
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Color[] array = new Color[4];
		if (!args.Contains("includechildren") || (bool)args["includechildren"])
		{
			foreach (object obj in target.transform)
			{
				iTween.ColorUpdate(((Transform)obj).gameObject, args);
			}
		}
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		if (target.GetComponent<Renderer>())
		{
			array[0] = (array[1] = target.GetComponent<Renderer>().material.color);
		}
		else if (target.GetComponent<Light>())
		{
			array[0] = (array[1] = target.GetComponent<Light>().color);
		}
		if (args.Contains("color"))
		{
			array[1] = (Color)args["color"];
		}
		else
		{
			if (args.Contains("r"))
			{
				array[1].r = (float)args["r"];
			}
			if (args.Contains("g"))
			{
				array[1].g = (float)args["g"];
			}
			if (args.Contains("b"))
			{
				array[1].b = (float)args["b"];
			}
			if (args.Contains("a"))
			{
				array[1].a = (float)args["a"];
			}
		}
		array[3].r = Mathf.SmoothDamp(array[0].r, array[1].r, ref array[2].r, num);
		array[3].g = Mathf.SmoothDamp(array[0].g, array[1].g, ref array[2].g, num);
		array[3].b = Mathf.SmoothDamp(array[0].b, array[1].b, ref array[2].b, num);
		array[3].a = Mathf.SmoothDamp(array[0].a, array[1].a, ref array[2].a, num);
		if (target.GetComponent<Renderer>())
		{
			target.GetComponent<Renderer>().material.color = array[3];
			return;
		}
		if (target.GetComponent<Light>())
		{
			target.GetComponent<Light>().color = array[3];
		}
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000AFA80 File Offset: 0x000ADC80
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
		iTween.ColorUpdate(target, iTween.Hash(new object[]
		{
			"color",
			color,
			"time",
			time
		}));
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Vector2[] array = new Vector2[4];
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		AudioSource audioSource;
		if (args.Contains("audiosource"))
		{
			audioSource = (AudioSource)args["audiosource"];
		}
		else
		{
			if (!target.GetComponent(typeof(AudioSource)))
			{
				Debug.LogError("iTween Error: AudioUpdate requires an AudioSource.");
				return;
			}
			audioSource = target.GetComponent<AudioSource>();
		}
		array[0] = (array[1] = new Vector2(audioSource.volume, audioSource.pitch));
		if (args.Contains("volume"))
		{
			array[1].x = (float)args["volume"];
		}
		if (args.Contains("pitch"))
		{
			array[1].y = (float)args["pitch"];
		}
		array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
		audioSource.volume = array[3].x;
		audioSource.pitch = array[3].y;
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000AFC50 File Offset: 0x000ADE50
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
		iTween.AudioUpdate(target, iTween.Hash(new object[]
		{
			"volume",
			volume,
			"pitch",
			pitch,
			"time",
			time
		}));
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000AFCA4 File Offset: 0x000ADEA4
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Vector3[] array = new Vector3[4];
		Vector3 eulerAngles = target.transform.eulerAngles;
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		bool flag;
		if (args.Contains("islocal"))
		{
			flag = (bool)args["islocal"];
		}
		else
		{
			flag = iTween.Defaults.isLocal;
		}
		if (flag)
		{
			array[0] = target.transform.localEulerAngles;
		}
		else
		{
			array[0] = target.transform.eulerAngles;
		}
		if (args.Contains("rotation"))
		{
			if (args["rotation"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["rotation"];
				array[1] = transform.eulerAngles;
			}
			else if (args["rotation"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["rotation"];
			}
		}
		array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDampAngle(array[0].z, array[1].z, ref array[2].z, num);
		if (flag)
		{
			target.transform.localEulerAngles = array[3];
		}
		else
		{
			target.transform.eulerAngles = array[3];
		}
		if (target.GetComponent<Rigidbody>() != null)
		{
			Vector3 eulerAngles2 = target.transform.eulerAngles;
			target.transform.eulerAngles = eulerAngles;
			target.GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(eulerAngles2));
		}
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000AFED7 File Offset: 0x000AE0D7
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
		iTween.RotateUpdate(target, iTween.Hash(new object[]
		{
			"rotation",
			rotation,
			"time",
			time
		}));
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000AFF0C File Offset: 0x000AE10C
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Vector3[] array = new Vector3[4];
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		array[0] = (array[1] = target.transform.localScale);
		if (args.Contains("scale"))
		{
			if (args["scale"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["scale"];
				array[1] = transform.localScale;
			}
			else if (args["scale"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["scale"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				array[1].x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				array[1].y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				array[1].z = (float)args["z"];
			}
		}
		array[3].x = Mathf.SmoothDamp(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDamp(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDamp(array[0].z, array[1].z, ref array[2].z, num);
		target.transform.localScale = array[3];
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000B0134 File Offset: 0x000AE334
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
		iTween.ScaleUpdate(target, iTween.Hash(new object[]
		{
			"scale",
			scale,
			"time",
			time
		}));
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000B016C File Offset: 0x000AE36C
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Vector3[] array = new Vector3[4];
		Vector3 position = target.transform.position;
		float num;
		if (args.Contains("time"))
		{
			num = (float)args["time"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		bool flag;
		if (args.Contains("islocal"))
		{
			flag = (bool)args["islocal"];
		}
		else
		{
			flag = iTween.Defaults.isLocal;
		}
		if (flag)
		{
			array[0] = (array[1] = target.transform.localPosition);
		}
		else
		{
			array[0] = (array[1] = target.transform.position);
		}
		if (args.Contains("position"))
		{
			if (args["position"].GetType() == typeof(Transform))
			{
				Transform transform = (Transform)args["position"];
				array[1] = transform.position;
			}
			else if (args["position"].GetType() == typeof(Vector3))
			{
				array[1] = (Vector3)args["position"];
			}
		}
		else
		{
			if (args.Contains("x"))
			{
				array[1].x = (float)args["x"];
			}
			if (args.Contains("y"))
			{
				array[1].y = (float)args["y"];
			}
			if (args.Contains("z"))
			{
				array[1].z = (float)args["z"];
			}
		}
		array[3].x = Mathf.SmoothDamp(array[0].x, array[1].x, ref array[2].x, num);
		array[3].y = Mathf.SmoothDamp(array[0].y, array[1].y, ref array[2].y, num);
		array[3].z = Mathf.SmoothDamp(array[0].z, array[1].z, ref array[2].z, num);
		if (args.Contains("orienttopath") && (bool)args["orienttopath"])
		{
			args["looktarget"] = array[3];
		}
		if (args.Contains("looktarget"))
		{
			iTween.LookUpdate(target, args);
		}
		if (flag)
		{
			target.transform.localPosition = array[3];
		}
		else
		{
			target.transform.position = array[3];
		}
		if (target.GetComponent<Rigidbody>() != null)
		{
			Vector3 position2 = target.transform.position;
			target.transform.position = position;
			target.GetComponent<Rigidbody>().MovePosition(position2);
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000B0482 File Offset: 0x000AE682
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
		iTween.MoveUpdate(target, iTween.Hash(new object[]
		{
			"position",
			position,
			"time",
			time
		}));
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000B04B8 File Offset: 0x000AE6B8
	public static void LookUpdate(GameObject target, Hashtable args)
	{
		iTween.CleanArgs(args);
		Vector3[] array = new Vector3[5];
		float num;
		if (args.Contains("looktime"))
		{
			num = (float)args["looktime"];
			num *= iTween.Defaults.updateTimePercentage;
		}
		else if (args.Contains("time"))
		{
			num = (float)args["time"] * 0.15f;
			num *= iTween.Defaults.updateTimePercentage;
		}
		else
		{
			num = iTween.Defaults.updateTime;
		}
		array[0] = target.transform.eulerAngles;
		if (args.Contains("looktarget"))
		{
			if (args["looktarget"].GetType() == typeof(Transform))
			{
				target.transform.LookAt((Transform)args["looktarget"], ((Vector3?)args["up"]) ?? iTween.Defaults.up);
			}
			else if (args["looktarget"].GetType() == typeof(Vector3))
			{
				target.transform.LookAt((Vector3)args["looktarget"], ((Vector3?)args["up"]) ?? iTween.Defaults.up);
			}
			array[1] = target.transform.eulerAngles;
			target.transform.eulerAngles = array[0];
			array[3].x = Mathf.SmoothDampAngle(array[0].x, array[1].x, ref array[2].x, num);
			array[3].y = Mathf.SmoothDampAngle(array[0].y, array[1].y, ref array[2].y, num);
			array[3].z = Mathf.SmoothDampAngle(array[0].z, array[1].z, ref array[2].z, num);
			target.transform.eulerAngles = array[3];
			if (args.Contains("axis"))
			{
				array[4] = target.transform.eulerAngles;
				string text = (string)args["axis"];
				if (text != null)
				{
					if (!(text == "x"))
					{
						if (!(text == "y"))
						{
							if (text == "z")
							{
								array[4].x = array[0].x;
								array[4].y = array[0].y;
							}
						}
						else
						{
							array[4].x = array[0].x;
							array[4].z = array[0].z;
						}
					}
					else
					{
						array[4].y = array[0].y;
						array[4].z = array[0].z;
					}
				}
				target.transform.eulerAngles = array[4];
			}
			return;
		}
		Debug.LogError("iTween Error: LookUpdate needs a 'looktarget' property!");
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000B080B File Offset: 0x000AEA0B
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
		iTween.LookUpdate(target, iTween.Hash(new object[]
		{
			"looktarget",
			looktarget,
			"time",
			time
		}));
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000B0840 File Offset: 0x000AEA40
	public static float PathLength(Transform[] path)
	{
		Vector3[] array = new Vector3[path.Length];
		float num = 0f;
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		Vector3[] pts = iTween.PathControlPointGenerator(array);
		Vector3 a = iTween.Interp(pts, 0f);
		int num2 = path.Length * 20;
		for (int j = 1; j <= num2; j++)
		{
			float t = (float)j / (float)num2;
			Vector3 vector = iTween.Interp(pts, t);
			num += Vector3.Distance(a, vector);
			a = vector;
		}
		return num;
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000B08D0 File Offset: 0x000AEAD0
	public static float PathLength(Vector3[] path)
	{
		float num = 0f;
		Vector3[] pts = iTween.PathControlPointGenerator(path);
		Vector3 a = iTween.Interp(pts, 0f);
		int num2 = path.Length * 20;
		for (int i = 1; i <= num2; i++)
		{
			float t = (float)i / (float)num2;
			Vector3 vector = iTween.Interp(pts, t);
			num += Vector3.Distance(a, vector);
			a = vector;
		}
		return num;
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000B0930 File Offset: 0x000AEB30
	public static Texture2D CameraTexture(Color color)
	{
		Texture2D texture2D = new Texture2D(Screen.width, Screen.height, TextureFormat.ARGB32, false);
		Color[] array = new Color[Screen.width * Screen.height];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = color;
		}
		texture2D.SetPixels(array);
		texture2D.Apply();
		return texture2D;
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000B0984 File Offset: 0x000AEB84
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
		target.transform.position = iTween.Interp(iTween.PathControlPointGenerator(path), percent);
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000B099D File Offset: 0x000AEB9D
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
		target.position = iTween.Interp(iTween.PathControlPointGenerator(path), percent);
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000B09B4 File Offset: 0x000AEBB4
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		target.transform.position = iTween.Interp(iTween.PathControlPointGenerator(array), percent);
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x000B0A00 File Offset: 0x000AEC00
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		target.position = iTween.Interp(iTween.PathControlPointGenerator(array), percent);
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x000B0A48 File Offset: 0x000AEC48
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		Vector3[] array = new Vector3[path.Length];
		for (int i = 0; i < path.Length; i++)
		{
			array[i] = path[i].position;
		}
		return iTween.Interp(iTween.PathControlPointGenerator(array), percent);
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000B0A87 File Offset: 0x000AEC87
	public static void DrawLine(Vector3[] line)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000B0A9D File Offset: 0x000AEC9D
	public static void DrawLine(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, color, "gizmos");
		}
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000B0AB0 File Offset: 0x000AECB0
	public static void DrawLine(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000B0AF8 File Offset: 0x000AECF8
	public static void DrawLine(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, color, "gizmos");
		}
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000B0A87 File Offset: 0x000AEC87
	public static void DrawLineGizmos(Vector3[] line)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000B0A9D File Offset: 0x000AEC9D
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, color, "gizmos");
		}
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000B0B3C File Offset: 0x000AED3C
	public static void DrawLineGizmos(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000B0B84 File Offset: 0x000AED84
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, color, "gizmos");
		}
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000B0BC7 File Offset: 0x000AEDC7
	public static void DrawLineHandles(Vector3[] line)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, iTween.Defaults.color, "handles");
		}
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000B0BDD File Offset: 0x000AEDDD
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
		if (line.Length != 0)
		{
			iTween.DrawLineHelper(line, color, "handles");
		}
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000B0BF0 File Offset: 0x000AEDF0
	public static void DrawLineHandles(Transform[] line)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, iTween.Defaults.color, "handles");
		}
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x000B0C38 File Offset: 0x000AEE38
	public static void DrawLineHandles(Transform[] line, Color color)
	{
		if (line.Length != 0)
		{
			Vector3[] array = new Vector3[line.Length];
			for (int i = 0; i < line.Length; i++)
			{
				array[i] = line[i].position;
			}
			iTween.DrawLineHelper(array, color, "handles");
		}
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000B0C7B File Offset: 0x000AEE7B
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return iTween.Interp(iTween.PathControlPointGenerator(path), percent);
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x000B0C89 File Offset: 0x000AEE89
	public static void DrawPath(Vector3[] path)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000B0C9F File Offset: 0x000AEE9F
	public static void DrawPath(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, color, "gizmos");
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000B0CB4 File Offset: 0x000AEEB4
	public static void DrawPath(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000B0CFC File Offset: 0x000AEEFC
	public static void DrawPath(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, color, "gizmos");
		}
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x000B0C89 File Offset: 0x000AEE89
	public static void DrawPathGizmos(Vector3[] path)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000B0C9F File Offset: 0x000AEE9F
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, color, "gizmos");
		}
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000B0D40 File Offset: 0x000AEF40
	public static void DrawPathGizmos(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, iTween.Defaults.color, "gizmos");
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000B0D88 File Offset: 0x000AEF88
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, color, "gizmos");
		}
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000B0DCB File Offset: 0x000AEFCB
	public static void DrawPathHandles(Vector3[] path)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, iTween.Defaults.color, "handles");
		}
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000B0DE1 File Offset: 0x000AEFE1
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
		if (path.Length != 0)
		{
			iTween.DrawPathHelper(path, color, "handles");
		}
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x000B0DF4 File Offset: 0x000AEFF4
	public static void DrawPathHandles(Transform[] path)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, iTween.Defaults.color, "handles");
		}
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000B0E3C File Offset: 0x000AF03C
	public static void DrawPathHandles(Transform[] path, Color color)
	{
		if (path.Length != 0)
		{
			Vector3[] array = new Vector3[path.Length];
			for (int i = 0; i < path.Length; i++)
			{
				array[i] = path[i].position;
			}
			iTween.DrawPathHelper(array, color, "handles");
		}
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x000B0E80 File Offset: 0x000AF080
	public static void CameraFadeDepth(int depth)
	{
		if (iTween.cameraFade)
		{
			iTween.cameraFade.transform.position = new Vector3(iTween.cameraFade.transform.position.x, iTween.cameraFade.transform.position.y, (float)depth);
		}
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x000B0ED7 File Offset: 0x000AF0D7
	public static void CameraFadeDestroy()
	{
		if (iTween.cameraFade)
		{
			UnityEngine.Object.Destroy(iTween.cameraFade);
		}
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000B0EEF File Offset: 0x000AF0EF
	public static void CameraFadeSwap(Texture2D texture)
	{
		if (iTween.cameraFade)
		{
			Debug.LogError("REMOVED");
		}
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000B0F07 File Offset: 0x000AF107
	public static GameObject CameraFadeAdd(Texture2D texture, int depth)
	{
		Debug.LogError("REMOVED");
		return null;
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000B0F07 File Offset: 0x000AF107
	public static GameObject CameraFadeAdd(Texture2D texture)
	{
		Debug.LogError("REMOVED");
		return null;
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x000B0F07 File Offset: 0x000AF107
	public static GameObject CameraFadeAdd()
	{
		Debug.LogError("REMOVED");
		return null;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x000B0F14 File Offset: 0x000AF114
	public static void Resume(GameObject target)
	{
		Component[] components = target.GetComponents(typeof(iTween));
		for (int i = 0; i < components.Length; i++)
		{
			((iTween)components[i]).enabled = true;
		}
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x000B0F50 File Offset: 0x000AF150
	public static void Resume(GameObject target, bool includechildren)
	{
		iTween.Resume(target);
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Resume(((Transform)obj).gameObject, true);
			}
		}
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x000B0FB8 File Offset: 0x000AF1B8
	public static void Resume(GameObject target, string type)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween.enabled = true;
			}
		}
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x000B1024 File Offset: 0x000AF224
	public static void Resume(GameObject target, string type, bool includechildren)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween.enabled = true;
			}
		}
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Resume(((Transform)obj).gameObject, type, true);
			}
		}
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000B10E8 File Offset: 0x000AF2E8
	public static void Resume()
	{
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			iTween.Resume((GameObject)((Hashtable)iTween.tweens[i])["target"]);
		}
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000B1130 File Offset: 0x000AF330
	public static void Resume(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			GameObject value = (GameObject)((Hashtable)iTween.tweens[i])["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			iTween.Resume((GameObject)arrayList[j], type);
		}
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000B11A8 File Offset: 0x000AF3A8
	public static void Pause(GameObject target)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if (iTween.delay > 0f)
			{
				iTween.delay -= Time.time - iTween.delayStarted;
				iTween.StopCoroutine("TweenDelay");
			}
			iTween.isPaused = true;
			iTween.enabled = false;
		}
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000B121C File Offset: 0x000AF41C
	public static void Pause(GameObject target, bool includechildren)
	{
		iTween.Pause(target);
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Pause(((Transform)obj).gameObject, true);
			}
		}
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000B1284 File Offset: 0x000AF484
	public static void Pause(GameObject target, string type)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				if (iTween.delay > 0f)
				{
					iTween.delay -= Time.time - iTween.delayStarted;
					iTween.StopCoroutine("TweenDelay");
				}
				iTween.isPaused = true;
				iTween.enabled = false;
			}
		}
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000B1330 File Offset: 0x000AF530
	public static void Pause(GameObject target, string type, bool includechildren)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				if (iTween.delay > 0f)
				{
					iTween.delay -= Time.time - iTween.delayStarted;
					iTween.StopCoroutine("TweenDelay");
				}
				iTween.isPaused = true;
				iTween.enabled = false;
			}
		}
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Pause(((Transform)obj).gameObject, type, true);
			}
		}
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000B1430 File Offset: 0x000AF630
	public static void Pause()
	{
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			iTween.Pause((GameObject)((Hashtable)iTween.tweens[i])["target"]);
		}
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000B1478 File Offset: 0x000AF678
	public static void Pause(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			GameObject value = (GameObject)((Hashtable)iTween.tweens[i])["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			iTween.Pause((GameObject)arrayList[j], type);
		}
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000B14F0 File Offset: 0x000AF6F0
	public static int Count()
	{
		return iTween.tweens.Count;
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000B14FC File Offset: 0x000AF6FC
	public static int Count(string type)
	{
		int num = 0;
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			Hashtable hashtable = (Hashtable)iTween.tweens[i];
			if (((string)hashtable["type"] + (string)hashtable["method"]).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000B1579 File Offset: 0x000AF779
	public static int Count(GameObject target)
	{
		return target.GetComponents(typeof(iTween)).Length;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000B1590 File Offset: 0x000AF790
	public static int Count(GameObject target, string type)
	{
		int num = 0;
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000B15FC File Offset: 0x000AF7FC
	public static void Stop()
	{
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			iTween.Stop((GameObject)((Hashtable)iTween.tweens[i])["target"]);
		}
		iTween.tweens.Clear();
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000B164C File Offset: 0x000AF84C
	public static void Stop(string type)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			GameObject value = (GameObject)((Hashtable)iTween.tweens[i])["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			iTween.Stop((GameObject)arrayList[j], type);
		}
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000B16C4 File Offset: 0x000AF8C4
	public static void StopByName(string name)
	{
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			GameObject value = (GameObject)((Hashtable)iTween.tweens[i])["target"];
			arrayList.Insert(arrayList.Count, value);
		}
		for (int j = 0; j < arrayList.Count; j++)
		{
			iTween.StopByName((GameObject)arrayList[j], name);
		}
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000B173C File Offset: 0x000AF93C
	public static void Stop(GameObject target)
	{
		Component[] components = target.GetComponents(typeof(iTween));
		for (int i = 0; i < components.Length; i++)
		{
			((iTween)components[i]).Dispose();
		}
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000B1778 File Offset: 0x000AF978
	public static void Stop(GameObject target, bool includechildren)
	{
		iTween.Stop(target);
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Stop(((Transform)obj).gameObject, true);
			}
		}
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x000B17E0 File Offset: 0x000AF9E0
	public static void Stop(GameObject target, string type)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween.Dispose();
			}
		}
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x000B184C File Offset: 0x000AFA4C
	public static void StopByName(GameObject target, string name)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if (iTween._name == name)
			{
				iTween.Dispose();
			}
		}
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x000B1898 File Offset: 0x000AFA98
	public static void Stop(GameObject target, string type, bool includechildren)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if ((iTween.type + iTween.method).Substring(0, type.Length).ToLower() == type.ToLower())
			{
				iTween.Dispose();
			}
		}
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.Stop(((Transform)obj).gameObject, type, true);
			}
		}
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000B1958 File Offset: 0x000AFB58
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
		foreach (iTween iTween in target.GetComponents(typeof(iTween)))
		{
			if (iTween._name == name)
			{
				iTween.Dispose();
			}
		}
		if (includechildren)
		{
			foreach (object obj in target.transform)
			{
				iTween.StopByName(((Transform)obj).gameObject, name, true);
			}
		}
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000B19F8 File Offset: 0x000AFBF8
	public static Hashtable Hash(params object[] args)
	{
		Hashtable hashtable = new Hashtable(args.Length / 2);
		if (args.Length % 2 != 0)
		{
			Debug.LogError("Tween Error: Hash requires an even number of arguments!");
			return null;
		}
		for (int i = 0; i < args.Length - 1; i += 2)
		{
			hashtable.Add(args[i], args[i + 1]);
		}
		return hashtable;
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000B1A42 File Offset: 0x000AFC42
	private void Awake()
	{
		this.RetrieveArgs();
		this.lastRealTime = Time.realtimeSinceStartup;
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x000B1A55 File Offset: 0x000AFC55
	private IEnumerator Start()
	{
		if (this.delay > 0f)
		{
			yield return this.StartCoroutine("TweenDelay");
		}
		this.TweenStart();
		yield break;
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x000B1A64 File Offset: 0x000AFC64
	private void Update()
	{
		if (this.isRunning && !this.physics)
		{
			if (!this.reverse)
			{
				if (this.percentage < 1f)
				{
					this.TweenUpdate();
					return;
				}
				this.TweenComplete();
				return;
			}
			else
			{
				if (this.percentage > 0f)
				{
					this.TweenUpdate();
					return;
				}
				this.TweenComplete();
			}
		}
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x000B1AC0 File Offset: 0x000AFCC0
	private void FixedUpdate()
	{
		if (this.isRunning && this.physics)
		{
			if (!this.reverse)
			{
				if (this.percentage < 1f)
				{
					this.TweenUpdate();
					return;
				}
				this.TweenComplete();
				return;
			}
			else
			{
				if (this.percentage > 0f)
				{
					this.TweenUpdate();
					return;
				}
				this.TweenComplete();
			}
		}
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x000B1B1C File Offset: 0x000AFD1C
	private void LateUpdate()
	{
		if (this.tweenArguments.Contains("looktarget") && this.isRunning && (this.type == "move" || this.type == "shake" || this.type == "punch"))
		{
			iTween.LookUpdate(base.gameObject, this.tweenArguments);
		}
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x000B1B8A File Offset: 0x000AFD8A
	private void OnEnable()
	{
		if (this.isRunning)
		{
			this.EnableKinematic();
		}
		if (this.isPaused)
		{
			this.isPaused = false;
			if (this.delay > 0f)
			{
				this.wasPaused = true;
				this.ResumeDelay();
			}
		}
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x000B1BC3 File Offset: 0x000AFDC3
	private void OnDisable()
	{
		this.DisableKinematic();
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x000B1BCC File Offset: 0x000AFDCC
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
		Gizmos.color = color;
		for (int i = 0; i < line.Length - 1; i++)
		{
			if (method == "gizmos")
			{
				Gizmos.DrawLine(line[i], line[i + 1]);
			}
			else if (method == "handles")
			{
				Debug.LogError("iTween Error: Drawing a line with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
			}
		}
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x000B1C2C File Offset: 0x000AFE2C
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
		Vector3[] pts = iTween.PathControlPointGenerator(path);
		Vector3 to = iTween.Interp(pts, 0f);
		Gizmos.color = color;
		int num = path.Length * 20;
		for (int i = 1; i <= num; i++)
		{
			float t = (float)i / (float)num;
			Vector3 vector = iTween.Interp(pts, t);
			if (method == "gizmos")
			{
				Gizmos.DrawLine(vector, to);
			}
			else if (method == "handles")
			{
				Debug.LogError("iTween Error: Drawing a path with Handles is temporarily disabled because of compatability issues with Unity 2.6!");
			}
			to = vector;
		}
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x000B1CA8 File Offset: 0x000AFEA8
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		int num = 2;
		Vector3[] array = new Vector3[path.Length + num];
		Array.Copy(path, 0, array, 1, path.Length);
		array[0] = array[1] + (array[1] - array[2]);
		array[array.Length - 1] = array[array.Length - 2] + (array[array.Length - 2] - array[array.Length - 3]);
		if (array[1] == array[array.Length - 2])
		{
			Vector3[] array2 = new Vector3[array.Length];
			Array.Copy(array, array2, array.Length);
			array2[0] = array2[array2.Length - 3];
			array2[array2.Length - 1] = array2[2];
			array = new Vector3[array2.Length];
			Array.Copy(array2, array, array2.Length);
		}
		return array;
	}

	// Token: 0x06002256 RID: 8790 RVA: 0x000B1D90 File Offset: 0x000AFF90
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		int num = pts.Length - 3;
		int num2 = Mathf.Min(Mathf.FloorToInt(t * (float)num), num - 1);
		float num3 = t * (float)num - (float)num2;
		Vector3 a = pts[num2];
		Vector3 a2 = pts[num2 + 1];
		Vector3 vector = pts[num2 + 2];
		Vector3 b = pts[num2 + 3];
		return 0.5f * ((-a + 3f * a2 - 3f * vector + b) * (num3 * num3 * num3) + (2f * a - 5f * a2 + 4f * vector - b) * (num3 * num3) + (-a + vector) * num3 + 2f * a2);
	}

	// Token: 0x06002257 RID: 8791 RVA: 0x000B1E94 File Offset: 0x000B0094
	private static void Launch(GameObject target, Hashtable args)
	{
		if (!args.Contains("id"))
		{
			args["id"] = iTween.GenerateID();
		}
		if (!args.Contains("target"))
		{
			args["target"] = target;
		}
		iTween.tweens.Insert(0, args);
		target.AddComponent<iTween>();
	}

	// Token: 0x06002258 RID: 8792 RVA: 0x000B1EEC File Offset: 0x000B00EC
	private static Hashtable CleanArgs(Hashtable args)
	{
		Hashtable hashtable = new Hashtable(args.Count);
		Hashtable hashtable2 = new Hashtable(args.Count);
		foreach (object obj in args)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
			hashtable.Add(dictionaryEntry.Key, dictionaryEntry.Value);
		}
		foreach (object obj2 in hashtable)
		{
			DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
			if (dictionaryEntry2.Value.GetType() == typeof(int))
			{
				float num = (float)((int)dictionaryEntry2.Value);
				args[dictionaryEntry2.Key] = num;
			}
			if (dictionaryEntry2.Value.GetType() == typeof(double))
			{
				float num2 = (float)((double)dictionaryEntry2.Value);
				args[dictionaryEntry2.Key] = num2;
			}
		}
		foreach (object obj3 in args)
		{
			DictionaryEntry dictionaryEntry3 = (DictionaryEntry)obj3;
			hashtable2.Add(dictionaryEntry3.Key.ToString().ToLower(), dictionaryEntry3.Value);
		}
		args = hashtable2;
		return args;
	}

	// Token: 0x06002259 RID: 8793 RVA: 0x000B2094 File Offset: 0x000B0294
	private static string GenerateID()
	{
		int num = 15;
		char[] array = new char[]
		{
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8'
		};
		int maxExclusive = array.Length - 1;
		string text = "";
		for (int i = 0; i < num; i++)
		{
			text += array[(int)Mathf.Floor((float)UnityEngine.Random.Range(0, maxExclusive))].ToString();
		}
		return text;
	}

	// Token: 0x0600225A RID: 8794 RVA: 0x000B20F4 File Offset: 0x000B02F4
	private void RetrieveArgs()
	{
		foreach (object obj in iTween.tweens)
		{
			Hashtable hashtable = (Hashtable)obj;
			if ((GameObject)hashtable["target"] == base.gameObject)
			{
				this.tweenArguments = hashtable;
				break;
			}
		}
		this.id = (string)this.tweenArguments["id"];
		this.type = (string)this.tweenArguments["type"];
		this._name = (string)this.tweenArguments["name"];
		this.method = (string)this.tweenArguments["method"];
		if (this.tweenArguments.Contains("time"))
		{
			this.time = (float)this.tweenArguments["time"];
		}
		else
		{
			this.time = iTween.Defaults.time;
		}
		if (base.GetComponent<Rigidbody>() != null)
		{
			this.physics = true;
		}
		if (this.tweenArguments.Contains("delay"))
		{
			this.delay = (float)this.tweenArguments["delay"];
		}
		else
		{
			this.delay = iTween.Defaults.delay;
		}
		if (this.tweenArguments.Contains("namedcolorvalue"))
		{
			if (this.tweenArguments["namedcolorvalue"].GetType() == typeof(iTween.NamedValueColor))
			{
				this.namedcolorvalue = (iTween.NamedValueColor)this.tweenArguments["namedcolorvalue"];
				goto IL_1F9;
			}
			try
			{
				this.namedcolorvalue = (iTween.NamedValueColor)Enum.Parse(typeof(iTween.NamedValueColor), (string)this.tweenArguments["namedcolorvalue"], true);
				goto IL_1F9;
			}
			catch
			{
				Debug.LogWarning("iTween: Unsupported namedcolorvalue supplied! Default will be used.");
				this.namedcolorvalue = iTween.NamedValueColor._Color;
				goto IL_1F9;
			}
		}
		this.namedcolorvalue = iTween.Defaults.namedColorValue;
		IL_1F9:
		if (this.tweenArguments.Contains("looptype"))
		{
			if (this.tweenArguments["looptype"].GetType() == typeof(iTween.LoopType))
			{
				this.loopType = (iTween.LoopType)this.tweenArguments["looptype"];
				goto IL_29F;
			}
			try
			{
				this.loopType = (iTween.LoopType)Enum.Parse(typeof(iTween.LoopType), (string)this.tweenArguments["looptype"], true);
				goto IL_29F;
			}
			catch
			{
				Debug.LogWarning("iTween: Unsupported loopType supplied! Default will be used.");
				this.loopType = iTween.LoopType.none;
				goto IL_29F;
			}
		}
		this.loopType = iTween.LoopType.none;
		IL_29F:
		if (this.tweenArguments.Contains("easetype"))
		{
			if (this.tweenArguments["easetype"].GetType() == typeof(iTween.EaseType))
			{
				this.easeType = (iTween.EaseType)this.tweenArguments["easetype"];
				goto IL_34D;
			}
			try
			{
				this.easeType = (iTween.EaseType)Enum.Parse(typeof(iTween.EaseType), (string)this.tweenArguments["easetype"], true);
				goto IL_34D;
			}
			catch
			{
				Debug.LogWarning("iTween: Unsupported easeType supplied! Default will be used.");
				this.easeType = iTween.Defaults.easeType;
				goto IL_34D;
			}
		}
		this.easeType = iTween.Defaults.easeType;
		IL_34D:
		if (this.tweenArguments.Contains("space"))
		{
			if (this.tweenArguments["space"].GetType() == typeof(Space))
			{
				this.space = (Space)this.tweenArguments["space"];
				goto IL_3FB;
			}
			try
			{
				this.space = (Space)Enum.Parse(typeof(Space), (string)this.tweenArguments["space"], true);
				goto IL_3FB;
			}
			catch
			{
				Debug.LogWarning("iTween: Unsupported space supplied! Default will be used.");
				this.space = iTween.Defaults.space;
				goto IL_3FB;
			}
		}
		this.space = iTween.Defaults.space;
		IL_3FB:
		if (this.tweenArguments.Contains("islocal"))
		{
			this.isLocal = (bool)this.tweenArguments["islocal"];
		}
		else
		{
			this.isLocal = iTween.Defaults.isLocal;
		}
		if (this.tweenArguments.Contains("ignoretimescale"))
		{
			this.useRealTime = (bool)this.tweenArguments["ignoretimescale"];
		}
		else
		{
			this.useRealTime = iTween.Defaults.useRealTime;
		}
		this.GetEasingFunction();
	}

	// Token: 0x0600225B RID: 8795 RVA: 0x000B25B8 File Offset: 0x000B07B8
	private void GetEasingFunction()
	{
		switch (this.easeType)
		{
		case iTween.EaseType.easeInQuad:
			this.ease = new iTween.EasingFunction(this.easeInQuad);
			return;
		case iTween.EaseType.easeOutQuad:
			this.ease = new iTween.EasingFunction(this.easeOutQuad);
			return;
		case iTween.EaseType.easeInOutQuad:
			this.ease = new iTween.EasingFunction(this.easeInOutQuad);
			return;
		case iTween.EaseType.easeInCubic:
			this.ease = new iTween.EasingFunction(this.easeInCubic);
			return;
		case iTween.EaseType.easeOutCubic:
			this.ease = new iTween.EasingFunction(this.easeOutCubic);
			return;
		case iTween.EaseType.easeInOutCubic:
			this.ease = new iTween.EasingFunction(this.easeInOutCubic);
			return;
		case iTween.EaseType.easeInQuart:
			this.ease = new iTween.EasingFunction(this.easeInQuart);
			return;
		case iTween.EaseType.easeOutQuart:
			this.ease = new iTween.EasingFunction(this.easeOutQuart);
			return;
		case iTween.EaseType.easeInOutQuart:
			this.ease = new iTween.EasingFunction(this.easeInOutQuart);
			return;
		case iTween.EaseType.easeInQuint:
			this.ease = new iTween.EasingFunction(this.easeInQuint);
			return;
		case iTween.EaseType.easeOutQuint:
			this.ease = new iTween.EasingFunction(this.easeOutQuint);
			return;
		case iTween.EaseType.easeInOutQuint:
			this.ease = new iTween.EasingFunction(this.easeInOutQuint);
			return;
		case iTween.EaseType.easeInSine:
			this.ease = new iTween.EasingFunction(this.easeInSine);
			return;
		case iTween.EaseType.easeOutSine:
			this.ease = new iTween.EasingFunction(this.easeOutSine);
			return;
		case iTween.EaseType.easeInOutSine:
			this.ease = new iTween.EasingFunction(this.easeInOutSine);
			return;
		case iTween.EaseType.easeInExpo:
			this.ease = new iTween.EasingFunction(this.easeInExpo);
			return;
		case iTween.EaseType.easeOutExpo:
			this.ease = new iTween.EasingFunction(this.easeOutExpo);
			return;
		case iTween.EaseType.easeInOutExpo:
			this.ease = new iTween.EasingFunction(this.easeInOutExpo);
			return;
		case iTween.EaseType.easeInCirc:
			this.ease = new iTween.EasingFunction(this.easeInCirc);
			return;
		case iTween.EaseType.easeOutCirc:
			this.ease = new iTween.EasingFunction(this.easeOutCirc);
			return;
		case iTween.EaseType.easeInOutCirc:
			this.ease = new iTween.EasingFunction(this.easeInOutCirc);
			return;
		case iTween.EaseType.linear:
			this.ease = new iTween.EasingFunction(this.linear);
			return;
		case iTween.EaseType.spring:
			this.ease = new iTween.EasingFunction(this.spring);
			return;
		case iTween.EaseType.easeInBounce:
			this.ease = new iTween.EasingFunction(this.easeInBounce);
			return;
		case iTween.EaseType.easeOutBounce:
			this.ease = new iTween.EasingFunction(this.easeOutBounce);
			return;
		case iTween.EaseType.easeInOutBounce:
			this.ease = new iTween.EasingFunction(this.easeInOutBounce);
			return;
		case iTween.EaseType.easeInBack:
			this.ease = new iTween.EasingFunction(this.easeInBack);
			return;
		case iTween.EaseType.easeOutBack:
			this.ease = new iTween.EasingFunction(this.easeOutBack);
			return;
		case iTween.EaseType.easeInOutBack:
			this.ease = new iTween.EasingFunction(this.easeInOutBack);
			return;
		case iTween.EaseType.easeInElastic:
			this.ease = new iTween.EasingFunction(this.easeInElastic);
			return;
		case iTween.EaseType.easeOutElastic:
			this.ease = new iTween.EasingFunction(this.easeOutElastic);
			return;
		case iTween.EaseType.easeInOutElastic:
			this.ease = new iTween.EasingFunction(this.easeInOutElastic);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600225C RID: 8796 RVA: 0x000B28B4 File Offset: 0x000B0AB4
	private void UpdatePercentage()
	{
		if (this.useRealTime)
		{
			this.runningTime += Time.realtimeSinceStartup - this.lastRealTime;
		}
		else
		{
			this.runningTime += Time.deltaTime;
		}
		if (this.reverse)
		{
			this.percentage = 1f - this.runningTime / this.time;
		}
		else
		{
			this.percentage = this.runningTime / this.time;
		}
		this.lastRealTime = Time.realtimeSinceStartup;
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x000B2938 File Offset: 0x000B0B38
	private void CallBack(string callbackType)
	{
		if (this.tweenArguments.Contains(callbackType) && !this.tweenArguments.Contains("ischild"))
		{
			GameObject gameObject;
			if (this.tweenArguments.Contains(callbackType + "target"))
			{
				gameObject = (GameObject)this.tweenArguments[callbackType + "target"];
			}
			else
			{
				gameObject = base.gameObject;
			}
			if (this.tweenArguments[callbackType].GetType() == typeof(string))
			{
				gameObject.SendMessage((string)this.tweenArguments[callbackType], this.tweenArguments[callbackType + "params"], SendMessageOptions.DontRequireReceiver);
				return;
			}
			Debug.LogError("iTween Error: Callback method references must be passed as a String!");
			UnityEngine.Object.Destroy(this);
		}
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x000B2A0C File Offset: 0x000B0C0C
	private void Dispose()
	{
		for (int i = 0; i < iTween.tweens.Count; i++)
		{
			if ((string)((Hashtable)iTween.tweens[i])["id"] == this.id)
			{
				iTween.tweens.RemoveAt(i);
				break;
			}
		}
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x000B2A70 File Offset: 0x000B0C70
	private void ConflictCheck()
	{
		foreach (iTween iTween in base.GetComponents(typeof(iTween)))
		{
			if (iTween.type == "value")
			{
				return;
			}
			if (iTween.isRunning && iTween.type == this.type)
			{
				if (iTween.method != this.method)
				{
					return;
				}
				if (iTween.tweenArguments.Count != this.tweenArguments.Count)
				{
					iTween.Dispose();
					return;
				}
				foreach (object obj in this.tweenArguments)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					if (!iTween.tweenArguments.Contains(dictionaryEntry.Key))
					{
						iTween.Dispose();
						return;
					}
					if (!iTween.tweenArguments[dictionaryEntry.Key].Equals(this.tweenArguments[dictionaryEntry.Key]) && (string)dictionaryEntry.Key != "id")
					{
						iTween.Dispose();
						return;
					}
				}
				this.Dispose();
			}
		}
	}

	// Token: 0x06002260 RID: 8800 RVA: 0x00003603 File Offset: 0x00001803
	private void EnableKinematic()
	{
	}

	// Token: 0x06002261 RID: 8801 RVA: 0x00003603 File Offset: 0x00001803
	private void DisableKinematic()
	{
	}

	// Token: 0x06002262 RID: 8802 RVA: 0x000B2BD4 File Offset: 0x000B0DD4
	private void ResumeDelay()
	{
		base.StartCoroutine("TweenDelay");
	}

	// Token: 0x06002263 RID: 8803 RVA: 0x000B2BE2 File Offset: 0x000B0DE2
	private float linear(float start, float end, float value)
	{
		return Mathf.Lerp(start, end, value);
	}

	// Token: 0x06002264 RID: 8804 RVA: 0x000B2BEC File Offset: 0x000B0DEC
	private float clerp(float start, float end, float value)
	{
		float num = 0f;
		float num2 = 360f;
		float num3 = Mathf.Abs((num2 - num) / 2f);
		float result;
		if (end - start < -num3)
		{
			float num4 = (num2 - start + end) * value;
			result = start + num4;
		}
		else if (end - start > num3)
		{
			float num4 = -(num2 - end + start) * value;
			result = start + num4;
		}
		else
		{
			result = start + (end - start) * value;
		}
		return result;
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x000B2C58 File Offset: 0x000B0E58
	private float spring(float start, float end, float value)
	{
		value = Mathf.Clamp01(value);
		value = (Mathf.Sin(value * 3.1415927f * (0.2f + 2.5f * value * value * value)) * Mathf.Pow(1f - value, 2.2f) + value) * (1f + 1.2f * (1f - value));
		return start + (end - start) * value;
	}

	// Token: 0x06002266 RID: 8806 RVA: 0x000B2CC0 File Offset: 0x000B0EC0
	private float easeInQuad(float start, float end, float value)
	{
		end -= start;
		return end * value * value + start;
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x000B2CD0 File Offset: 0x000B0ED0
	private float easeOutQuad(float start, float end, float value)
	{
		end -= start;
		return -end * value * (value - 2f) + start;
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x000B2CE8 File Offset: 0x000B0EE8
	private float easeInOutQuad(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end / 2f * value * value + start;
		}
		value -= 1f;
		return -end / 2f * (value * (value - 2f) - 1f) + start;
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x000B2D42 File Offset: 0x000B0F42
	private float easeInCubic(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value + start;
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x000B2D54 File Offset: 0x000B0F54
	private float easeOutCubic(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value + 1f) + start;
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x000B2D78 File Offset: 0x000B0F78
	private float easeInOutCubic(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end / 2f * value * value * value + start;
		}
		value -= 2f;
		return end / 2f * (value * value * value + 2f) + start;
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x000B2DCF File Offset: 0x000B0FCF
	private float easeInQuart(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value + start;
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x000B2DE3 File Offset: 0x000B0FE3
	private float easeOutQuart(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return -end * (value * value * value * value - 1f) + start;
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x000B2E0C File Offset: 0x000B100C
	private float easeInOutQuart(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end / 2f * value * value * value * value + start;
		}
		value -= 2f;
		return -end / 2f * (value * value * value * value - 2f) + start;
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000B2E68 File Offset: 0x000B1068
	private float easeInQuint(float start, float end, float value)
	{
		end -= start;
		return end * value * value * value * value * value + start;
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000B2E7E File Offset: 0x000B107E
	private float easeOutQuint(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * (value * value * value * value * value + 1f) + start;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000B2EA8 File Offset: 0x000B10A8
	private float easeInOutQuint(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end / 2f * value * value * value * value * value + start;
		}
		value -= 2f;
		return end / 2f * (value * value * value * value * value + 2f) + start;
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000B2F07 File Offset: 0x000B1107
	private float easeInSine(float start, float end, float value)
	{
		end -= start;
		return -end * Mathf.Cos(value / 1f * 1.5707964f) + end + start;
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000B2F29 File Offset: 0x000B1129
	private float easeOutSine(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Sin(value / 1f * 1.5707964f) + start;
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000B2F48 File Offset: 0x000B1148
	private float easeInOutSine(float start, float end, float value)
	{
		end -= start;
		return -end / 2f * (Mathf.Cos(3.1415927f * value / 1f) - 1f) + start;
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000B2F74 File Offset: 0x000B1174
	private float easeInExpo(float start, float end, float value)
	{
		end -= start;
		return end * Mathf.Pow(2f, 10f * (value / 1f - 1f)) + start;
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000B2F9E File Offset: 0x000B119E
	private float easeOutExpo(float start, float end, float value)
	{
		end -= start;
		return end * (-Mathf.Pow(2f, -10f * value / 1f) + 1f) + start;
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000B2FCC File Offset: 0x000B11CC
	private float easeInOutExpo(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return end / 2f * Mathf.Pow(2f, 10f * (value - 1f)) + start;
		}
		value -= 1f;
		return end / 2f * (-Mathf.Pow(2f, -10f * value) + 2f) + start;
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000B3042 File Offset: 0x000B1242
	private float easeInCirc(float start, float end, float value)
	{
		end -= start;
		return -end * (Mathf.Sqrt(1f - value * value) - 1f) + start;
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000B3064 File Offset: 0x000B1264
	private float easeOutCirc(float start, float end, float value)
	{
		value -= 1f;
		end -= start;
		return end * Mathf.Sqrt(1f - value * value) + start;
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000B308C File Offset: 0x000B128C
	private float easeInOutCirc(float start, float end, float value)
	{
		value /= 0.5f;
		end -= start;
		if (value < 1f)
		{
			return -end / 2f * (Mathf.Sqrt(1f - value * value) - 1f) + start;
		}
		value -= 2f;
		return end / 2f * (Mathf.Sqrt(1f - value * value) + 1f) + start;
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000B30FC File Offset: 0x000B12FC
	private float easeInBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		return end - this.easeOutBounce(0f, end, num - value) + start;
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000B312C File Offset: 0x000B132C
	private float easeOutBounce(float start, float end, float value)
	{
		value /= 1f;
		end -= start;
		if (value < 0.36363637f)
		{
			return end * (7.5625f * value * value) + start;
		}
		if (value < 0.72727275f)
		{
			value -= 0.54545456f;
			return end * (7.5625f * value * value + 0.75f) + start;
		}
		if ((double)value < 0.9090909090909091)
		{
			value -= 0.8181818f;
			return end * (7.5625f * value * value + 0.9375f) + start;
		}
		value -= 0.95454544f;
		return end * (7.5625f * value * value + 0.984375f) + start;
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000B31D4 File Offset: 0x000B13D4
	private float easeInOutBounce(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		if (value < num / 2f)
		{
			return this.easeInBounce(0f, end, value * 2f) * 0.5f + start;
		}
		return this.easeOutBounce(0f, end, value * 2f - num) * 0.5f + end * 0.5f + start;
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000B323C File Offset: 0x000B143C
	private float easeInBack(float start, float end, float value)
	{
		end -= start;
		value /= 1f;
		float num = 1.70158f;
		return end * value * value * ((num + 1f) * value - num) + start;
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000B3274 File Offset: 0x000B1474
	private float easeOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value = value / 1f - 1f;
		return end * (value * value * ((num + 1f) * value + num) + 1f) + start;
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000B32B8 File Offset: 0x000B14B8
	private float easeInOutBack(float start, float end, float value)
	{
		float num = 1.70158f;
		end -= start;
		value /= 0.5f;
		if (value < 1f)
		{
			num *= 1.525f;
			return end / 2f * (value * value * ((num + 1f) * value - num)) + start;
		}
		value -= 2f;
		num *= 1.525f;
		return end / 2f * (value * value * ((num + 1f) * value + num) + 2f) + start;
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000B333C File Offset: 0x000B153C
	private float punch(float amplitude, float value)
	{
		if (value == 0f)
		{
			return 0f;
		}
		if (value == 1f)
		{
			return 0f;
		}
		float num = 0.3f;
		float num2 = num / 6.2831855f * Mathf.Asin(0f);
		return amplitude * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * 1f - num2) * 6.2831855f / num);
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000B33B0 File Offset: 0x000B15B0
	private float easeInElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		float num4;
		if (num3 == 0f || num3 < Mathf.Abs(end))
		{
			num3 = end;
			num4 = num2 / 4f;
		}
		else
		{
			num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
		}
		return -(num3 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2)) + start;
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000B3460 File Offset: 0x000B1660
	private float easeOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num) == 1f)
		{
			return start + end;
		}
		float num4;
		if (num3 == 0f || num3 < Mathf.Abs(end))
		{
			num3 = end;
			num4 = num2 / 4f;
		}
		else
		{
			num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
		}
		return num3 * Mathf.Pow(2f, -10f * value) * Mathf.Sin((value * num - num4) * 6.2831855f / num2) + end + start;
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000B3504 File Offset: 0x000B1704
	private float easeInOutElastic(float start, float end, float value)
	{
		end -= start;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		if (value == 0f)
		{
			return start;
		}
		if ((value /= num / 2f) == 2f)
		{
			return start + end;
		}
		float num4;
		if (num3 == 0f || num3 < Mathf.Abs(end))
		{
			num3 = end;
			num4 = num2 / 4f;
		}
		else
		{
			num4 = num2 / 6.2831855f * Mathf.Asin(end / num3);
		}
		if (value < 1f)
		{
			return -0.5f * (num3 * Mathf.Pow(2f, 10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2)) + start;
		}
		return num3 * Mathf.Pow(2f, -10f * (value -= 1f)) * Mathf.Sin((value * num - num4) * 6.2831855f / num2) * 0.5f + end + start;
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000B3600 File Offset: 0x000B1800
	// Note: this type is marked as 'beforefieldinit'.
	static iTween()
	{
		iTween.tweens = new ArrayList();
	}

	// Token: 0x040026F0 RID: 9968
	public static ArrayList tweens;

	// Token: 0x040026F1 RID: 9969
	private static GameObject cameraFade;

	// Token: 0x040026F2 RID: 9970
	public string id;

	// Token: 0x040026F3 RID: 9971
	public string type;

	// Token: 0x040026F4 RID: 9972
	public string method;

	// Token: 0x040026F5 RID: 9973
	public iTween.EaseType easeType;

	// Token: 0x040026F6 RID: 9974
	public float time;

	// Token: 0x040026F7 RID: 9975
	public float delay;

	// Token: 0x040026F8 RID: 9976
	public iTween.LoopType loopType;

	// Token: 0x040026F9 RID: 9977
	public bool isRunning;

	// Token: 0x040026FA RID: 9978
	public bool isPaused;

	// Token: 0x040026FB RID: 9979
	public string _name;

	// Token: 0x040026FC RID: 9980
	private float runningTime;

	// Token: 0x040026FD RID: 9981
	private float percentage;

	// Token: 0x040026FE RID: 9982
	private float delayStarted;

	// Token: 0x040026FF RID: 9983
	private bool kinematic;

	// Token: 0x04002700 RID: 9984
	private bool isLocal;

	// Token: 0x04002701 RID: 9985
	private bool loop;

	// Token: 0x04002702 RID: 9986
	private bool reverse;

	// Token: 0x04002703 RID: 9987
	private bool wasPaused;

	// Token: 0x04002704 RID: 9988
	private bool physics;

	// Token: 0x04002705 RID: 9989
	private Hashtable tweenArguments;

	// Token: 0x04002706 RID: 9990
	private Space space;

	// Token: 0x04002707 RID: 9991
	private iTween.EasingFunction ease;

	// Token: 0x04002708 RID: 9992
	private iTween.ApplyTween apply;

	// Token: 0x04002709 RID: 9993
	private AudioSource audioSource;

	// Token: 0x0400270A RID: 9994
	private Vector3[] vector3s;

	// Token: 0x0400270B RID: 9995
	private Vector2[] vector2s;

	// Token: 0x0400270C RID: 9996
	private Color[,] colors;

	// Token: 0x0400270D RID: 9997
	private float[] floats;

	// Token: 0x0400270E RID: 9998
	private Rect[] rects;

	// Token: 0x0400270F RID: 9999
	private iTween.CRSpline path;

	// Token: 0x04002710 RID: 10000
	private Vector3 preUpdate;

	// Token: 0x04002711 RID: 10001
	private Vector3 postUpdate;

	// Token: 0x04002712 RID: 10002
	private iTween.NamedValueColor namedcolorvalue;

	// Token: 0x04002713 RID: 10003
	private float lastRealTime;

	// Token: 0x04002714 RID: 10004
	private bool useRealTime;

	// Token: 0x020005C2 RID: 1474
	// (Invoke) Token: 0x06002288 RID: 8840
	private delegate float EasingFunction(float start, float end, float value);

	// Token: 0x020005C3 RID: 1475
	// (Invoke) Token: 0x0600228C RID: 8844
	private delegate void ApplyTween();

	// Token: 0x020005C4 RID: 1476
	public enum EaseType
	{
		// Token: 0x04002716 RID: 10006
		easeInQuad,
		// Token: 0x04002717 RID: 10007
		easeOutQuad,
		// Token: 0x04002718 RID: 10008
		easeInOutQuad,
		// Token: 0x04002719 RID: 10009
		easeInCubic,
		// Token: 0x0400271A RID: 10010
		easeOutCubic,
		// Token: 0x0400271B RID: 10011
		easeInOutCubic,
		// Token: 0x0400271C RID: 10012
		easeInQuart,
		// Token: 0x0400271D RID: 10013
		easeOutQuart,
		// Token: 0x0400271E RID: 10014
		easeInOutQuart,
		// Token: 0x0400271F RID: 10015
		easeInQuint,
		// Token: 0x04002720 RID: 10016
		easeOutQuint,
		// Token: 0x04002721 RID: 10017
		easeInOutQuint,
		// Token: 0x04002722 RID: 10018
		easeInSine,
		// Token: 0x04002723 RID: 10019
		easeOutSine,
		// Token: 0x04002724 RID: 10020
		easeInOutSine,
		// Token: 0x04002725 RID: 10021
		easeInExpo,
		// Token: 0x04002726 RID: 10022
		easeOutExpo,
		// Token: 0x04002727 RID: 10023
		easeInOutExpo,
		// Token: 0x04002728 RID: 10024
		easeInCirc,
		// Token: 0x04002729 RID: 10025
		easeOutCirc,
		// Token: 0x0400272A RID: 10026
		easeInOutCirc,
		// Token: 0x0400272B RID: 10027
		linear,
		// Token: 0x0400272C RID: 10028
		spring,
		// Token: 0x0400272D RID: 10029
		easeInBounce,
		// Token: 0x0400272E RID: 10030
		easeOutBounce,
		// Token: 0x0400272F RID: 10031
		easeInOutBounce,
		// Token: 0x04002730 RID: 10032
		easeInBack,
		// Token: 0x04002731 RID: 10033
		easeOutBack,
		// Token: 0x04002732 RID: 10034
		easeInOutBack,
		// Token: 0x04002733 RID: 10035
		easeInElastic,
		// Token: 0x04002734 RID: 10036
		easeOutElastic,
		// Token: 0x04002735 RID: 10037
		easeInOutElastic,
		// Token: 0x04002736 RID: 10038
		punch
	}

	// Token: 0x020005C5 RID: 1477
	public enum LoopType
	{
		// Token: 0x04002738 RID: 10040
		none,
		// Token: 0x04002739 RID: 10041
		loop,
		// Token: 0x0400273A RID: 10042
		pingPong
	}

	// Token: 0x020005C6 RID: 1478
	public enum NamedValueColor
	{
		// Token: 0x0400273C RID: 10044
		_Color,
		// Token: 0x0400273D RID: 10045
		_SpecColor,
		// Token: 0x0400273E RID: 10046
		_Emission,
		// Token: 0x0400273F RID: 10047
		_ReflectColor
	}

	// Token: 0x020005C7 RID: 1479
	public static class Defaults
	{
		// Token: 0x0600228F RID: 8847 RVA: 0x000B360C File Offset: 0x000B180C
		// Note: this type is marked as 'beforefieldinit'.
		static Defaults()
		{
			iTween.Defaults.time = 1f;
			iTween.Defaults.delay = 0f;
			iTween.Defaults.namedColorValue = iTween.NamedValueColor._Color;
			iTween.Defaults.loopType = iTween.LoopType.none;
			iTween.Defaults.easeType = iTween.EaseType.easeOutExpo;
			iTween.Defaults.lookSpeed = 3f;
			iTween.Defaults.isLocal = false;
			iTween.Defaults.space = Space.Self;
			iTween.Defaults.orientToPath = false;
			iTween.Defaults.color = Color.white;
			iTween.Defaults.updateTimePercentage = 0.05f;
			iTween.Defaults.updateTime = 1f * iTween.Defaults.updateTimePercentage;
			iTween.Defaults.cameraFadeDepth = 999999;
			iTween.Defaults.lookAhead = 0.05f;
			iTween.Defaults.useRealTime = false;
			iTween.Defaults.up = Vector3.up;
		}

		// Token: 0x04002740 RID: 10048
		public static float time;

		// Token: 0x04002741 RID: 10049
		public static float delay;

		// Token: 0x04002742 RID: 10050
		public static iTween.NamedValueColor namedColorValue;

		// Token: 0x04002743 RID: 10051
		public static iTween.LoopType loopType;

		// Token: 0x04002744 RID: 10052
		public static iTween.EaseType easeType;

		// Token: 0x04002745 RID: 10053
		public static float lookSpeed;

		// Token: 0x04002746 RID: 10054
		public static bool isLocal;

		// Token: 0x04002747 RID: 10055
		public static Space space;

		// Token: 0x04002748 RID: 10056
		public static bool orientToPath;

		// Token: 0x04002749 RID: 10057
		public static Color color;

		// Token: 0x0400274A RID: 10058
		public static float updateTimePercentage;

		// Token: 0x0400274B RID: 10059
		public static float updateTime;

		// Token: 0x0400274C RID: 10060
		public static int cameraFadeDepth;

		// Token: 0x0400274D RID: 10061
		public static float lookAhead;

		// Token: 0x0400274E RID: 10062
		public static bool useRealTime;

		// Token: 0x0400274F RID: 10063
		public static Vector3 up;
	}

	// Token: 0x020005C8 RID: 1480
	private class CRSpline
	{
		// Token: 0x06002290 RID: 8848 RVA: 0x000B36A4 File Offset: 0x000B18A4
		public CRSpline(params Vector3[] pts)
		{
			this.pts = new Vector3[pts.Length];
			Array.Copy(pts, this.pts, pts.Length);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000B36CC File Offset: 0x000B18CC
		public Vector3 Interp(float t)
		{
			int num = this.pts.Length - 3;
			int num2 = Mathf.Min(Mathf.FloorToInt(t * (float)num), num - 1);
			float num3 = t * (float)num - (float)num2;
			Vector3 a = this.pts[num2];
			Vector3 a2 = this.pts[num2 + 1];
			Vector3 vector = this.pts[num2 + 2];
			Vector3 b = this.pts[num2 + 3];
			return 0.5f * ((-a + 3f * a2 - 3f * vector + b) * (num3 * num3 * num3) + (2f * a - 5f * a2 + 4f * vector - b) * (num3 * num3) + (-a + vector) * num3 + 2f * a2);
		}

		// Token: 0x04002750 RID: 10064
		public Vector3[] pts;
	}
}
