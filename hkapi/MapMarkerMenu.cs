using System;
using System.Collections.Generic;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x02000479 RID: 1145
public class MapMarkerMenu : MonoBehaviour
{
	// Token: 0x060019AA RID: 6570 RVA: 0x0007A43C File Offset: 0x0007863C
	private void Update()
	{
		if (this.state == 2)
		{
			this.PanMap();
			HeroActions inputActions = InputHandler.Instance.inputActions;
			if (Platform.Current.GetMenuAction(inputActions.menuSubmit.WasPressed, inputActions.menuCancel.WasPressed, inputActions.jump.WasPressed, inputActions.attack.WasPressed, inputActions.cast.WasPressed) == Platform.MenuActions.Submit && this.confirmTimer <= 0f)
			{
				if (this.collidingWithMarker)
				{
					this.RemoveMarker();
				}
				else
				{
					this.PlaceMarker();
				}
			}
			if (this.inputHandler.inputActions.dreamNail.WasPressed && this.confirmTimer <= 0f)
			{
				this.MarkerSelectRight();
			}
			if (this.inputHandler.inputActions.paneRight.WasPressed && this.confirmTimer <= 0f)
			{
				this.MarkerSelectRight();
			}
			if (this.inputHandler.inputActions.paneLeft.WasPressed && this.confirmTimer <= 0f)
			{
				this.MarkerSelectLeft();
			}
		}
		if (this.timer > 0f)
		{
			this.timer -= Time.deltaTime;
		}
		if (this.confirmTimer > 0f)
		{
			this.confirmTimer -= Time.deltaTime;
		}
		if (this.placementTimer > 0f)
		{
			this.placementTimer -= Time.deltaTime;
		}
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x0007A5A8 File Offset: 0x000787A8
	public void Open()
	{
		if (this.gm == null)
		{
			this.gm = GameManager.instance;
		}
		if (this.pd == null)
		{
			this.pd = PlayerData.instance;
		}
		if (this.inputHandler == null)
		{
			this.inputHandler = this.gm.GetComponent<InputHandler>();
		}
		if (this.gameMapObject == null)
		{
			this.gameMapObject = this.gm.gameMap;
			this.gameMap = this.gameMapObject.GetComponent<GameMap>();
		}
		this.placementCursor.SetActive(false);
		this.hasMarker_r = this.pd.GetBool("hasMarker_r");
		this.hasMarker_b = this.pd.GetBool("hasMarker_b");
		this.hasMarker_y = this.pd.GetBool("hasMarker_y");
		this.hasMarker_w = this.pd.GetBool("hasMarker_w");
		this.spareMarkers_r = this.pd.GetInt("spareMarkers_r");
		this.spareMarkers_b = this.pd.GetInt("spareMarkers_b");
		this.spareMarkers_y = this.pd.GetInt("spareMarkers_y");
		this.spareMarkers_w = this.pd.GetInt("spareMarkers_w");
		this.markerSelected = 0;
		float num = this.xPos_start;
		if (this.hasMarker_b)
		{
			this.marker_b.SetActive(true);
			this.marker_b.transform.localPosition = new Vector3(num, this.markerY, this.markerZ);
			num += this.xPos_interval;
			if (this.pd.GetInt("spareMarkers_b") > 0)
			{
				this.markerSelected = 1;
			}
		}
		if (this.hasMarker_r)
		{
			this.marker_r.SetActive(true);
			this.marker_r.transform.localPosition = new Vector3(num, this.markerY, this.markerZ);
			num += this.xPos_interval;
			if (this.markerSelected == 0 && this.pd.GetInt("spareMarkers_r") > 0)
			{
				this.markerSelected = 2;
			}
		}
		if (this.hasMarker_y)
		{
			this.marker_y.SetActive(true);
			this.marker_y.transform.localPosition = new Vector3(num, this.markerY, this.markerZ);
			num += this.xPos_interval;
			if (this.markerSelected == 0 && this.pd.GetInt("spareMarkers_y") > 0)
			{
				this.markerSelected = 3;
			}
		}
		if (this.hasMarker_w)
		{
			this.marker_w.SetActive(true);
			this.marker_w.transform.localPosition = new Vector3(num, this.markerY, this.markerZ);
			num += this.xPos_interval;
			if (this.markerSelected == 0 && this.pd.GetInt("spareMarkers_w") > 0)
			{
				this.markerSelected = 4;
			}
		}
		if (this.markerSelected == 0)
		{
			if (this.hasMarker_b)
			{
				this.markerSelected = 1;
			}
			else if (this.hasMarker_r)
			{
				this.markerSelected = 2;
			}
			else if (this.hasMarker_y)
			{
				this.markerSelected = 3;
			}
			else if (this.hasMarker_w)
			{
				this.markerSelected = 4;
			}
		}
		this.UpdateAmounts();
		this.cursor.SetActive(true);
		this.cursor.transform.localPosition = new Vector3(this.xPos_start, this.markerY, -3f);
		this.fadeGroup.FadeUp();
		this.changeButton.SetActive(true);
		this.cancelButton.SetActive(true);
		this.collidingMarkers.Clear();
		this.timer = 0f;
		this.confirmTimer = this.uiPause;
		this.state = 2;
		this.StartMarkerPlacement();
		this.MarkerSelect(this.markerSelected);
		this.placeString = Language.Get("CTRL_MARKER_PLACE", "UI");
		this.removeString = Language.Get("CTRL_MARKER_REMOVE", "UI");
		this.IsNotColliding();
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x0007A986 File Offset: 0x00078B86
	public void Close()
	{
		this.fadeGroup.FadeDown();
		this.changeButton.SetActive(false);
		this.cancelButton.SetActive(false);
		this.state = 0;
		this.placementCursor.SetActive(false);
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x0007A9C0 File Offset: 0x00078BC0
	private void StartMarkerPlacement()
	{
		this.placementCursor.SetActive(true);
		this.placementCursor.transform.localPosition = this.placementCursorOrigin;
		this.placementBox.transform.parent = this.placementCursor.transform;
		this.placementBox.transform.localPosition = new Vector3(0f, 0f, 0f);
		this.confirmTimer = this.uiPause;
		this.state = 2;
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x0007AA44 File Offset: 0x00078C44
	private void PanMap()
	{
		if (this.inputHandler.inputActions.rs_down.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursor.transform.localPosition.y - this.panSpeed * 2f * Time.deltaTime, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.down.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursor.transform.localPosition.y - this.panSpeed * Time.deltaTime, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.rs_up.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursor.transform.localPosition.y + this.panSpeed * 2f * Time.deltaTime, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.up.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursor.transform.localPosition.y + this.panSpeed * Time.deltaTime, this.placementCursor.transform.localPosition.z);
		}
		if (this.inputHandler.inputActions.rs_left.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x - this.panSpeed * 2f * Time.deltaTime, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.left.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x - this.panSpeed * Time.deltaTime, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.rs_right.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x + this.panSpeed * 2f * Time.deltaTime, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
		}
		else if (this.inputHandler.inputActions.right.IsPressed)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x + this.panSpeed * Time.deltaTime, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
		}
		if (this.placementCursor.transform.localPosition.x < this.placementCursorMinX)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursorMinX, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
			if (this.placementTimer <= 0f)
			{
				this.gameMapObject.transform.position = new Vector3(this.gameMapObject.transform.position.x + this.panSpeed * 2f * Time.deltaTime, this.gameMapObject.transform.position.y, this.gameMapObject.transform.position.z);
				this.gameMap.KeepWithinBounds();
			}
		}
		if (this.placementCursor.transform.localPosition.x > this.placementCursorMaxX)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursorMaxX, this.placementCursor.transform.localPosition.y, this.placementCursor.transform.localPosition.z);
			if (this.placementTimer <= 0f)
			{
				this.gameMapObject.transform.position = new Vector3(this.gameMapObject.transform.position.x - this.panSpeed * 2f * Time.deltaTime, this.gameMapObject.transform.position.y, this.gameMapObject.transform.position.z);
				this.gameMap.KeepWithinBounds();
			}
		}
		if (this.placementCursor.transform.localPosition.y < this.placementCursorMinY)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursorMinY, this.placementCursor.transform.localPosition.z);
			if (this.placementTimer <= 0f)
			{
				this.gameMapObject.transform.position = new Vector3(this.gameMapObject.transform.position.x, this.gameMapObject.transform.position.y + this.panSpeed * 2f * Time.deltaTime, this.gameMapObject.transform.position.z);
				this.gameMap.KeepWithinBounds();
			}
		}
		if (this.placementCursor.transform.localPosition.y > this.placementCursorMaxY)
		{
			this.placementCursor.transform.localPosition = new Vector3(this.placementCursor.transform.localPosition.x, this.placementCursorMaxY, this.placementCursor.transform.localPosition.z);
			if (this.placementTimer <= 0f)
			{
				this.gameMapObject.transform.position = new Vector3(this.gameMapObject.transform.position.x, this.gameMapObject.transform.position.y - this.panSpeed * 2f * Time.deltaTime, this.gameMapObject.transform.position.z);
				this.gameMap.KeepWithinBounds();
			}
		}
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x0007B1D4 File Offset: 0x000793D4
	private void MarkerSelect(int selection)
	{
		this.marker_b.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
		this.marker_r.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
		this.marker_y.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
		this.marker_w.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
		Vector3 value = new Vector3(0f, 0f, 0f);
		switch (selection)
		{
		case 1:
			this.marker_b.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			value = new Vector3(this.marker_b.transform.localPosition.x, this.markerY, -3f);
			break;
		case 2:
			this.marker_r.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			value = new Vector3(this.marker_r.transform.localPosition.x, this.markerY, -3f);
			break;
		case 3:
			this.marker_y.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			value = new Vector3(this.marker_y.transform.localPosition.x, this.markerY, -3f);
			break;
		case 4:
			this.marker_w.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
			value = new Vector3(this.marker_w.transform.localPosition.x, this.markerY, -3f);
			break;
		}
		this.cursorTweenFSM.FsmVariables.GetFsmVector3("Tween Pos").Value = value;
		this.cursorTweenFSM.SendEvent("TWEEN");
		this.audioSource.PlayOneShot(this.cursorClip);
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x0007B418 File Offset: 0x00079618
	private void PlaceMarker()
	{
		bool flag = false;
		if (this.markerSelected == 1 && this.pd.GetInt("spareMarkers_b") > 0)
		{
			flag = true;
		}
		if (this.markerSelected == 2 && this.pd.GetInt("spareMarkers_r") > 0)
		{
			flag = true;
		}
		if (this.markerSelected == 3 && this.pd.GetInt("spareMarkers_y") > 0)
		{
			flag = true;
		}
		if (this.markerSelected == 4 && this.pd.GetInt("spareMarkers_w") > 0)
		{
			flag = true;
		}
		if (flag)
		{
			this.placementBox.transform.parent = this.gameMapObject.transform;
			Vector3 item = new Vector3(this.placementBox.transform.localPosition.x, this.placementBox.transform.localPosition.y, -0.1f);
			this.placementBox.transform.parent = this.placementCursor.transform;
			GameObject gameObject = this.placeEffectPrefab.Spawn(this.placementCursor.transform.position, Quaternion.Euler(0f, 0f, 0f));
			gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -30f);
			if (this.markerSelected == 1)
			{
				this.pd.GetVariable<List<Vector3>>("placedMarkers_b").Add(item);
				PlayerData playerData = this.pd;
				playerData.SetIntSwappedArgs(playerData.GetInt("spareMarkers_b") - 1, "spareMarkers_b");
				gameObject.GetComponent<SpriteRenderer>().sprite = this.spriteBlue;
			}
			else if (this.markerSelected == 2)
			{
				this.pd.GetVariable<List<Vector3>>("placedMarkers_r").Add(item);
				PlayerData playerData2 = this.pd;
				playerData2.SetIntSwappedArgs(playerData2.GetInt("spareMarkers_r") - 1, "spareMarkers_r");
				gameObject.GetComponent<SpriteRenderer>().sprite = this.spriteRed;
			}
			else if (this.markerSelected == 3)
			{
				this.pd.GetVariable<List<Vector3>>("placedMarkers_y").Add(item);
				PlayerData playerData3 = this.pd;
				playerData3.SetIntSwappedArgs(playerData3.GetInt("spareMarkers_y") - 1, "spareMarkers_y");
				gameObject.GetComponent<SpriteRenderer>().sprite = this.spriteYellow;
			}
			else if (this.markerSelected == 4)
			{
				this.pd.GetVariable<List<Vector3>>("placedMarkers_w").Add(item);
				PlayerData playerData4 = this.pd;
				playerData4.SetIntSwappedArgs(playerData4.GetInt("spareMarkers_w") - 1, "spareMarkers_w");
				gameObject.GetComponent<SpriteRenderer>().sprite = this.spriteWhite;
			}
			this.UpdateAmounts();
			this.gameMap.SetupMapMarkers();
			this.audioSource.PlayOneShot(this.placeClip);
			VibrationManager.PlayVibrationClipOneShot(this.placementVibration, null, false, "");
			this.placementTimer = 0.3f;
			return;
		}
		this.audioSource.PlayOneShot(this.failureClip);
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x0007B710 File Offset: 0x00079910
	private void RemoveMarker()
	{
		GameObject gameObject = this.collidingMarkers[this.collidingMarkers.Count - 1];
		int colour = gameObject.GetComponent<InvMarker>().colour;
		int id = gameObject.GetComponent<InvMarker>().id;
		GameObject gameObject2 = this.removeEffectPrefab.Spawn(this.placementCursor.transform.position, Quaternion.Euler(0f, 0f, 0f));
		gameObject2.transform.position = new Vector3(gameObject2.transform.position.x, gameObject2.transform.position.y, -30f);
		switch (colour)
		{
		case 0:
		{
			this.pd.GetVariable<List<Vector3>>("placedMarkers_b").RemoveAt(id);
			PlayerData playerData = this.pd;
			playerData.SetIntSwappedArgs(playerData.GetInt("spareMarkers_b") + 1, "spareMarkers_b");
			gameObject2.GetComponent<SpriteRenderer>().sprite = this.spriteBlue;
			break;
		}
		case 1:
		{
			this.pd.GetVariable<List<Vector3>>("placedMarkers_r").RemoveAt(id);
			PlayerData playerData2 = this.pd;
			playerData2.SetIntSwappedArgs(playerData2.GetInt("spareMarkers_r") + 1, "spareMarkers_r");
			gameObject2.GetComponent<SpriteRenderer>().sprite = this.spriteRed;
			break;
		}
		case 2:
		{
			this.pd.GetVariable<List<Vector3>>("placedMarkers_y").RemoveAt(id);
			PlayerData playerData3 = this.pd;
			playerData3.SetIntSwappedArgs(playerData3.GetInt("spareMarkers_y") + 1, "spareMarkers_y");
			gameObject2.GetComponent<SpriteRenderer>().sprite = this.spriteYellow;
			break;
		}
		case 3:
		{
			this.pd.GetVariable<List<Vector3>>("placedMarkers_w").RemoveAt(id);
			PlayerData playerData4 = this.pd;
			playerData4.SetIntSwappedArgs(playerData4.GetInt("spareMarkers_w") + 1, "spareMarkers_w");
			gameObject2.GetComponent<SpriteRenderer>().sprite = this.spriteWhite;
			break;
		}
		}
		this.collidingMarkers.Remove(gameObject);
		if (this.collidingMarkers.Count <= 0)
		{
			this.IsNotColliding();
		}
		this.audioSource.PlayOneShot(this.removeClip);
		VibrationManager.PlayVibrationClipOneShot(this.placementVibration, null, false, "");
		this.UpdateAmounts();
		this.gameMap.SetupMapMarkers();
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x0007B94C File Offset: 0x00079B4C
	private void MarkerSelectLeft()
	{
		bool flag = false;
		if (this.markerSelected == 1)
		{
			if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
			else if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
			else if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
		}
		else if (this.markerSelected == 2)
		{
			if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
			else if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
			else if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
		}
		else if (this.markerSelected == 3)
		{
			if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
			else if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
			else if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
		}
		else if (this.markerSelected == 4)
		{
			if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
			else if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
			else if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
		}
		if (flag)
		{
			this.timer = this.uiPause;
			this.MarkerSelect(this.markerSelected);
		}
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x0007BA98 File Offset: 0x00079C98
	private void MarkerSelectRight()
	{
		bool flag = false;
		if (this.markerSelected == 1)
		{
			if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
			else if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
			else if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
		}
		else if (this.markerSelected == 2)
		{
			if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
			else if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
			else if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
		}
		else if (this.markerSelected == 3)
		{
			if (this.hasMarker_w)
			{
				this.markerSelected = 4;
				flag = true;
			}
			else if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
			else if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
		}
		else if (this.markerSelected == 4)
		{
			if (this.hasMarker_b)
			{
				this.markerSelected = 1;
				flag = true;
			}
			else if (this.hasMarker_r)
			{
				this.markerSelected = 2;
				flag = true;
			}
			else if (this.hasMarker_y)
			{
				this.markerSelected = 3;
				flag = true;
			}
		}
		if (flag)
		{
			this.timer = this.uiPause;
			this.MarkerSelect(this.markerSelected);
		}
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x0007BBE4 File Offset: 0x00079DE4
	private void UpdateAmounts()
	{
		this.amount_b.text = this.pd.spareMarkers_b.ToString();
		this.amount_r.text = this.pd.spareMarkers_r.ToString();
		this.amount_y.text = this.pd.spareMarkers_y.ToString();
		this.amount_w.text = this.pd.spareMarkers_w.ToString();
		if (this.pd.GetInt("spareMarkers_b") > 0)
		{
			this.marker_b.GetComponent<SpriteRenderer>().color = this.enabledColour;
			this.amount_b.GetComponent<TextMeshPro>().color = this.enabledColour;
		}
		else
		{
			this.marker_b.GetComponent<SpriteRenderer>().color = this.disabledColour;
			this.amount_b.GetComponent<TextMeshPro>().color = this.disabledColour;
		}
		if (this.pd.GetInt("spareMarkers_r") > 0)
		{
			this.marker_r.GetComponent<SpriteRenderer>().color = this.enabledColour;
			this.amount_r.GetComponent<TextMeshPro>().color = this.enabledColour;
		}
		else
		{
			this.marker_r.GetComponent<SpriteRenderer>().color = this.disabledColour;
			this.amount_r.GetComponent<TextMeshPro>().color = this.disabledColour;
		}
		if (this.pd.GetInt("spareMarkers_y") > 0)
		{
			this.marker_y.GetComponent<SpriteRenderer>().color = this.enabledColour;
			this.amount_y.GetComponent<TextMeshPro>().color = this.enabledColour;
		}
		else
		{
			this.marker_y.GetComponent<SpriteRenderer>().color = this.disabledColour;
			this.amount_y.GetComponent<TextMeshPro>().color = this.disabledColour;
		}
		if (this.pd.GetInt("spareMarkers_w") > 0)
		{
			this.marker_w.GetComponent<SpriteRenderer>().color = this.enabledColour;
			this.amount_w.GetComponent<TextMeshPro>().color = this.enabledColour;
			return;
		}
		this.marker_w.GetComponent<SpriteRenderer>().color = this.disabledColour;
		this.amount_w.GetComponent<TextMeshPro>().color = this.disabledColour;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0007BE10 File Offset: 0x0007A010
	public void AddToCollidingList(GameObject go)
	{
		this.collidingMarkers.Add(go);
		this.IsColliding();
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x0007BE24 File Offset: 0x0007A024
	public void RemoveFromCollidingList(GameObject go)
	{
		this.collidingMarkers.Remove(go);
		if (this.collidingMarkers.Count <= 0)
		{
			this.IsNotColliding();
		}
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0007BE47 File Offset: 0x0007A047
	private void IsColliding()
	{
		this.collidingWithMarker = true;
		this.actionText.text = this.removeString;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x0007BE61 File Offset: 0x0007A061
	private void IsNotColliding()
	{
		this.collidingWithMarker = false;
		this.actionText.text = this.placeString;
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x0007BE7C File Offset: 0x0007A07C
	public MapMarkerMenu()
	{
		this.xPos_start = 1.9f;
		this.xPos_interval = 1.4333f;
		this.markerY = -12.82f;
		this.markerZ = -1f;
		this.uiPause = 0.2f;
		this.enabledColour = new Color(1f, 1f, 1f, 1f);
		this.disabledColour = new Color(0.5f, 0.5f, 0.5f, 1f);
		base..ctor();
	}

	// Token: 0x04001EDD RID: 7901
	public float xPos_start;

	// Token: 0x04001EDE RID: 7902
	public float xPos_interval;

	// Token: 0x04001EDF RID: 7903
	public float markerY;

	// Token: 0x04001EE0 RID: 7904
	public float markerZ;

	// Token: 0x04001EE1 RID: 7905
	public float uiPause;

	// Token: 0x04001EE2 RID: 7906
	[Space]
	public FadeGroup fadeGroup;

	// Token: 0x04001EE3 RID: 7907
	[Space]
	public AudioSource audioSource;

	// Token: 0x04001EE4 RID: 7908
	public AudioClip placeClip;

	// Token: 0x04001EE5 RID: 7909
	public AudioClip removeClip;

	// Token: 0x04001EE6 RID: 7910
	public AudioClip cursorClip;

	// Token: 0x04001EE7 RID: 7911
	public AudioClip failureClip;

	// Token: 0x04001EE8 RID: 7912
	public VibrationData placementVibration;

	// Token: 0x04001EE9 RID: 7913
	[Space]
	public GameObject cursor;

	// Token: 0x04001EEA RID: 7914
	public PlayMakerFSM cursorTweenFSM;

	// Token: 0x04001EEB RID: 7915
	public GameObject placementCursor;

	// Token: 0x04001EEC RID: 7916
	public GameObject placementBox;

	// Token: 0x04001EED RID: 7917
	public GameObject changeButton;

	// Token: 0x04001EEE RID: 7918
	public GameObject cancelButton;

	// Token: 0x04001EEF RID: 7919
	public TextMeshPro actionText;

	// Token: 0x04001EF0 RID: 7920
	[Space]
	public GameObject marker_b;

	// Token: 0x04001EF1 RID: 7921
	public GameObject marker_r;

	// Token: 0x04001EF2 RID: 7922
	public GameObject marker_w;

	// Token: 0x04001EF3 RID: 7923
	public GameObject marker_y;

	// Token: 0x04001EF4 RID: 7924
	public TextMeshPro amount_b;

	// Token: 0x04001EF5 RID: 7925
	public TextMeshPro amount_r;

	// Token: 0x04001EF6 RID: 7926
	public TextMeshPro amount_w;

	// Token: 0x04001EF7 RID: 7927
	public TextMeshPro amount_y;

	// Token: 0x04001EF8 RID: 7928
	[Space]
	public Vector3 placementCursorOrigin;

	// Token: 0x04001EF9 RID: 7929
	public float panSpeed;

	// Token: 0x04001EFA RID: 7930
	public float placementCursorMinX;

	// Token: 0x04001EFB RID: 7931
	public float placementCursorMaxX;

	// Token: 0x04001EFC RID: 7932
	public float placementCursorMinY;

	// Token: 0x04001EFD RID: 7933
	public float placementCursorMaxY;

	// Token: 0x04001EFE RID: 7934
	[Space]
	public List<GameObject> collidingMarkers;

	// Token: 0x04001EFF RID: 7935
	[Space]
	public GameObject placeEffectPrefab;

	// Token: 0x04001F00 RID: 7936
	public GameObject removeEffectPrefab;

	// Token: 0x04001F01 RID: 7937
	public Sprite spriteBlue;

	// Token: 0x04001F02 RID: 7938
	public Sprite spriteRed;

	// Token: 0x04001F03 RID: 7939
	public Sprite spriteYellow;

	// Token: 0x04001F04 RID: 7940
	public Sprite spriteWhite;

	// Token: 0x04001F05 RID: 7941
	private GameManager gm;

	// Token: 0x04001F06 RID: 7942
	private PlayerData pd;

	// Token: 0x04001F07 RID: 7943
	private InputHandler inputHandler;

	// Token: 0x04001F08 RID: 7944
	private GameObject gameMapObject;

	// Token: 0x04001F09 RID: 7945
	private GameMap gameMap;

	// Token: 0x04001F0A RID: 7946
	private bool hasMarker_r;

	// Token: 0x04001F0B RID: 7947
	private bool hasMarker_b;

	// Token: 0x04001F0C RID: 7948
	private bool hasMarker_y;

	// Token: 0x04001F0D RID: 7949
	private bool hasMarker_w;

	// Token: 0x04001F0E RID: 7950
	private int spareMarkers_r;

	// Token: 0x04001F0F RID: 7951
	private int spareMarkers_b;

	// Token: 0x04001F10 RID: 7952
	private int spareMarkers_y;

	// Token: 0x04001F11 RID: 7953
	private int spareMarkers_w;

	// Token: 0x04001F12 RID: 7954
	private int state;

	// Token: 0x04001F13 RID: 7955
	private int markerSelected;

	// Token: 0x04001F14 RID: 7956
	private float timer;

	// Token: 0x04001F15 RID: 7957
	private float confirmTimer;

	// Token: 0x04001F16 RID: 7958
	private float placementTimer;

	// Token: 0x04001F17 RID: 7959
	private Color enabledColour;

	// Token: 0x04001F18 RID: 7960
	private Color disabledColour;

	// Token: 0x04001F19 RID: 7961
	private bool collidingWithMarker;

	// Token: 0x04001F1A RID: 7962
	private string placeString;

	// Token: 0x04001F1B RID: 7963
	private string removeString;
}
