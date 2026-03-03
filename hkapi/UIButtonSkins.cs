using System;
using System.Collections;
using System.Collections.Generic;
using GlobalEnums;
using InControl;
using Modding;
using UnityEngine;

// Token: 0x020004C3 RID: 1219
public class UIButtonSkins : MonoBehaviour
{
	// Token: 0x17000340 RID: 832
	// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00080DD8 File Offset: 0x0007EFD8
	// (set) Token: 0x06001B06 RID: 6918 RVA: 0x00080DE0 File Offset: 0x0007EFE0
	public MappableKey listeningKey { get; private set; }

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00080DE9 File Offset: 0x0007EFE9
	// (set) Token: 0x06001B08 RID: 6920 RVA: 0x00080DF1 File Offset: 0x0007EFF1
	public MappableControllerButton listeningButton { get; private set; }

	// Token: 0x06001B09 RID: 6921 RVA: 0x00080DFA File Offset: 0x0007EFFA
	private void Start()
	{
		this.SetupRefs();
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x00080E02 File Offset: 0x0007F002
	private void OnEnable()
	{
		if (!this.active)
		{
			this.SetupRefs();
		}
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x00080E14 File Offset: 0x0007F014
	public ButtonSkin GetButtonSkinFor(PlayerAction action)
	{
		ButtonSkin result;
		switch (this.ih.lastActiveController)
		{
		case BindingSourceType.None:
		case BindingSourceType.KeyBindingSource:
		case BindingSourceType.MouseBindingSource:
			result = this.GetKeyboardSkinFor(action);
			break;
		case BindingSourceType.DeviceBindingSource:
			result = this.GetControllerButtonSkinFor(action);
			break;
		default:
			result = null;
			break;
		}
		return result;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x00080E5C File Offset: 0x0007F05C
	public ButtonSkin GetKeyboardSkinFor(PlayerAction action)
	{
		return this.GetButtonSkinFor(action.GetKeyOrMouseBinding().ToString());
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x00080E83 File Offset: 0x0007F083
	public ButtonSkin GetControllerButtonSkinFor(PlayerAction action)
	{
		return this.GetButtonSkinFor(action.GetControllerButtonBinding());
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x00080E94 File Offset: 0x0007F094
	public ButtonSkin GetButtonSkinFor(HeroActionButton actionButton)
	{
		if (this.ih == null)
		{
			Debug.LogWarning("Attempting to get button skins before the Input Handler is ready.", this);
			return this.GetButtonSkinFor(Key.None.ToString());
		}
		return this.GetButtonSkinFor(this.ih.ActionButtonToPlayerAction(actionButton));
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x00080EE2 File Offset: 0x0007F0E2
	public IEnumerator ShowCurrentKeyboardMappings()
	{
		UIButtonSkins.<ShowCurrentKeyboardMappings>d__18 <ShowCurrentKeyboardMappings>d__ = new UIButtonSkins.<ShowCurrentKeyboardMappings>d__18(0);
		<ShowCurrentKeyboardMappings>d__.<>4__this = this;
		return <ShowCurrentKeyboardMappings>d__;
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x00080EF1 File Offset: 0x0007F0F1
	public IEnumerator ShowCurrentButtonMappings()
	{
		UIButtonSkins.<ShowCurrentButtonMappings>d__20 <ShowCurrentButtonMappings>d__ = new UIButtonSkins.<ShowCurrentButtonMappings>d__20(0);
		<ShowCurrentButtonMappings>d__.<>4__this = this;
		return <ShowCurrentButtonMappings>d__;
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x00080F00 File Offset: 0x0007F100
	public void RefreshKeyMappings()
	{
		if (this.customKeys != null)
		{
			foreach (MappableKey mappableKey in this.customKeys)
			{
				if (!(mappableKey == null))
				{
					mappableKey.GetBinding();
					mappableKey.ShowCurrentBinding();
				}
			}
		}
		this.orig_RefreshKeyMappings();
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x00080F70 File Offset: 0x0007F170
	public void RefreshButtonMappings()
	{
		if (this.customButtons != null)
		{
			foreach (MappableControllerButton mappableControllerButton in this.customButtons)
			{
				if (!(mappableControllerButton == null))
				{
					mappableControllerButton.ShowCurrentBinding();
				}
			}
		}
		this.orig_RefreshButtonMappings();
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x00080FDC File Offset: 0x0007F1DC
	public void ListeningForKeyRebind(MappableKey mappableKey)
	{
		if (this.listeningKey == null)
		{
			this.listeningKey = mappableKey;
			return;
		}
		this.listeningKey.AbortRebind();
		this.listeningKey = mappableKey;
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x00081006 File Offset: 0x0007F206
	public void ListeningForButtonRebind(MappableControllerButton mappableButton)
	{
		if (this.listeningButton != null)
		{
			this.listeningButton.AbortRebind();
		}
		this.listeningButton = mappableButton;
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x00081028 File Offset: 0x0007F228
	public void FinishedListeningForKey()
	{
		this.listeningKey = null;
		this.RefreshKeyMappings();
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x00081037 File Offset: 0x0007F237
	public void FinishedListeningForButton()
	{
		this.listeningButton = null;
		base.StartCoroutine(this.ShowCurrentButtonMappings());
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x0008104D File Offset: 0x0007F24D
	private ButtonSkin GetButtonSkinFor(InputControlType inputControlType)
	{
		if (this.ih == null)
		{
			this.ih = (InputHandler)InputHandler.Instance;
		}
		return this.orig_GetButtonSkinFor(inputControlType);
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x00081074 File Offset: 0x0007F274
	private ButtonSkin GetButtonSkinFor(string buttonName)
	{
		ButtonSkin buttonSkin = new ButtonSkin(this.blankKey, buttonName, ButtonSkinType.BLANK);
		if (buttonName.Length == 1)
		{
			if (char.IsLetter(buttonName[0]))
			{
				buttonSkin.sprite = this.squareKey;
				buttonSkin.symbol = buttonName;
				buttonSkin.skinType = ButtonSkinType.SQUARE;
			}
		}
		else
		{
			if (buttonName != null)
			{
				uint num = <PrivateImplementationDetails>.ComputeStringHash(buttonName);
				if (num <= 850645478U)
				{
					if (num <= 439010491U)
					{
						if (num <= 355122396U)
						{
							if (num <= 215134355U)
							{
								if (num <= 75071339U)
								{
									if (num != 55056364U)
									{
										if (num == 75071339U)
										{
											if (buttonName == "LeftAlt")
											{
												buttonSkin.sprite = this.rectangleKey;
												buttonSkin.symbol = "L Alt";
												buttonSkin.skinType = ButtonSkinType.WIDE;
												return buttonSkin;
											}
										}
									}
									else if (buttonName == "MiddleButton")
									{
										buttonSkin.sprite = this.middleMouseButton;
										buttonSkin.symbol = "";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
								else if (num != 198356736U)
								{
									if (num == 215134355U)
									{
										if (buttonName == "F8")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "F9")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (num <= 257323198U)
							{
								if (num != 254900552U)
								{
									if (num == 257323198U)
									{
										if (buttonName == "Semicolon")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.symbol = ";";
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "Insert")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.symbol = "Ins";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (num != 311208791U)
							{
								if (num != 332577688U)
								{
									if (num == 355122396U)
									{
										if (buttonName == "Key8")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.symbol = "8";
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "F1")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (buttonName == "PadDivide")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "/";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num <= 399688164U)
						{
							if (num <= 371900015U)
							{
								if (num != 366132926U)
								{
									if (num == 371900015U)
									{
										if (buttonName == "Key9")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.symbol = "9";
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "F3")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (num != 382910545U)
							{
								if (num == 399688164U)
								{
									if (buttonName == "F5")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "F2")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num <= 416465783U)
						{
							if (num != 400677660U)
							{
								if (num == 416465783U)
								{
									if (buttonName == "F4")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "PadEnter")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "Ent";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 422232872U)
						{
							if (num != 433243402U)
							{
								if (num == 439010491U)
								{
									if (buttonName == "Key5")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "5";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "F7")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (buttonName == "Key4")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "4";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num <= 539676205U)
					{
						if (num <= 472565729U)
						{
							if (num <= 455788110U)
							{
								if (num != 450021021U)
								{
									if (num == 455788110U)
									{
										if (buttonName == "Key6")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.symbol = "6";
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "F6")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (num != 457187446U)
							{
								if (num == 472565729U)
								{
									if (buttonName == "Key7")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "7";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Pad8")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "8";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num <= 489343348U)
						{
							if (num != 473965065U)
							{
								if (num == 489343348U)
								{
									if (buttonName == "Key0")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "0";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Pad9")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "9";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 506120967U)
						{
							if (num != 522898586U)
							{
								if (num == 539676205U)
								{
									if (buttonName == "Key3")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "3";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Key2")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "2";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (buttonName == "Key1")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "1";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num <= 624963636U)
					{
						if (num <= 574630779U)
						{
							if (num != 557853160U)
							{
								if (num == 574630779U)
								{
									if (buttonName == "Pad3")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "3";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Pad2")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "2";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 591408398U)
						{
							if (num != 608186017U)
							{
								if (num == 624963636U)
								{
									if (buttonName == "Pad6")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "6";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Pad1")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "1";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (buttonName == "Pad0")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "0";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num <= 651038163U)
					{
						if (num != 641741255U)
						{
							if (num == 651038163U)
							{
								if (buttonName == "RightBracket")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.symbol = "]";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "Pad7")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "7";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num != 658518874U)
					{
						if (num != 675296493U)
						{
							if (num == 850645478U)
							{
								if (buttonName == "RightArrow")
								{
									buttonSkin.sprite = this.rightArrowKey;
									buttonSkin.symbol = "";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "Pad5")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "5";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (buttonName == "Pad4")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.symbol = "4";
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (num <= 2044664427U)
				{
					if (num <= 1466336430U)
					{
						if (num <= 1258159639U)
						{
							if (num <= 1050238388U)
							{
								if (num != 1044186795U)
								{
									if (num == 1050238388U)
									{
										if (buttonName == "Equals")
										{
											buttonSkin.sprite = this.squareKey;
											buttonSkin.symbol = "=";
											buttonSkin.skinType = ButtonSkinType.SQUARE;
											return buttonSkin;
										}
									}
								}
								else if (buttonName == "PageUp")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.symbol = "PgUp";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
							else if (num != 1231278590U)
							{
								if (num == 1258159639U)
								{
									if (buttonName == "Backslash")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "\\";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "RightControl")
							{
								buttonSkin.sprite = this.rectangleKey;
								buttonSkin.symbol = "R Ctrl";
								buttonSkin.skinType = ButtonSkinType.WIDE;
								return buttonSkin;
							}
						}
						else if (num <= 1406581478U)
						{
							if (num != 1391791790U)
							{
								if (num == 1406581478U)
								{
									if (buttonName == "PadMinus")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "-";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Home")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "Home";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 1428210068U)
						{
							if (num != 1462265726U)
							{
								if (num == 1466336430U)
								{
									if (buttonName == "PadPlus")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "+";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Backquote")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "~";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (buttonName == "LeftShift")
						{
							buttonSkin.sprite = this.rectangleKey;
							buttonSkin.symbol = "L Shift";
							buttonSkin.skinType = ButtonSkinType.WIDE;
							return buttonSkin;
						}
					}
					else if (num <= 1682706001U)
					{
						if (num <= 1522423415U)
						{
							if (num != 1469573738U)
							{
								if (num == 1522423415U)
								{
									if (buttonName == "Quote")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = "'";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Delete")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.symbol = "Del";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 1565561622U)
						{
							if (num != 1629542348U)
							{
								if (num == 1682706001U)
								{
									if (buttonName == "RightButton")
									{
										buttonSkin.sprite = this.rightMouseButton;
										buttonSkin.symbol = "";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "Backspace")
							{
								buttonSkin.sprite = this.rectangleKey;
								buttonSkin.skinType = ButtonSkinType.WIDE;
								return buttonSkin;
							}
						}
						else if (buttonName == "DownArrow")
						{
							buttonSkin.sprite = this.downArrowKey;
							buttonSkin.symbol = "";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num <= 1732852044U)
					{
						if (num != 1706424088U)
						{
							if (num == 1732852044U)
							{
								if (buttonName == "LeftBracket")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.symbol = "[";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "Comma")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = ",";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num != 1898928778U)
					{
						if (num != 1985520332U)
						{
							if (num == 2044664427U)
							{
								if (buttonName == "PadPeriod")
								{
									buttonSkin.sprite = this.squareKey;
									buttonSkin.symbol = ".";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "Left Bracket")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "[";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (buttonName == "Slash")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.symbol = "/";
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (num <= 3250860581U)
				{
					if (num <= 2848837449U)
					{
						if (num <= 2267317284U)
						{
							if (num != 2118290244U)
							{
								if (num == 2267317284U)
								{
									if (buttonName == "Period")
									{
										buttonSkin.sprite = this.squareKey;
										buttonSkin.symbol = ".";
										buttonSkin.skinType = ButtonSkinType.SQUARE;
										return buttonSkin;
									}
								}
							}
							else if (buttonName == "LeftButton")
							{
								buttonSkin.sprite = this.leftMouseButton;
								buttonSkin.symbol = "";
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
						else if (num != 2434225852U)
						{
							if (num == 2848837449U)
							{
								if (buttonName == "LeftArrow")
								{
									buttonSkin.sprite = this.leftArrowKey;
									buttonSkin.symbol = "";
									buttonSkin.skinType = ButtonSkinType.SQUARE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "RightAlt")
						{
							buttonSkin.sprite = this.rectangleKey;
							buttonSkin.symbol = "R Alt";
							buttonSkin.skinType = ButtonSkinType.WIDE;
							return buttonSkin;
						}
					}
					else if (num <= 3036628469U)
					{
						if (num != 2988002186U)
						{
							if (num == 3036628469U)
							{
								if (buttonName == "LeftControl")
								{
									buttonSkin.sprite = this.rectangleKey;
									buttonSkin.symbol = "L Ctrl";
									buttonSkin.skinType = ButtonSkinType.WIDE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "PadMultiply")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "*";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num != 3082514982U)
					{
						if (num != 3241480638U)
						{
							if (num == 3250860581U)
							{
								if (buttonName == "Space")
								{
									buttonSkin.sprite = this.rectangleKey;
									buttonSkin.skinType = ButtonSkinType.WIDE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "PageDown")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "PgDn";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (buttonName == "Escape")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.symbol = "Esc";
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (num <= 3592460967U)
				{
					if (num <= 3422663135U)
					{
						if (num != 3388260431U)
						{
							if (num == 3422663135U)
							{
								if (buttonName == "Return")
								{
									buttonSkin.sprite = this.rectangleKey;
									buttonSkin.symbol = "Enter";
									buttonSkin.skinType = ButtonSkinType.WIDE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "Minus")
						{
							buttonSkin.sprite = this.squareKey;
							buttonSkin.symbol = "-";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (num != 3482547786U)
					{
						if (num != 3583141561U)
						{
							if (num == 3592460967U)
							{
								if (buttonName == "RightShift")
								{
									buttonSkin.sprite = this.rectangleKey;
									buttonSkin.symbol = "R Shift";
									buttonSkin.skinType = ButtonSkinType.WIDE;
									return buttonSkin;
								}
							}
						}
						else if (buttonName == "UpArrow")
						{
							buttonSkin.sprite = this.upArrowKey;
							buttonSkin.symbol = "";
							buttonSkin.skinType = ButtonSkinType.SQUARE;
							return buttonSkin;
						}
					}
					else if (buttonName == "End")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.symbol = "End";
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (num <= 3720178443U)
				{
					if (num != 3703400824U)
					{
						if (num == 3720178443U)
						{
							if (buttonName == "F11")
							{
								buttonSkin.sprite = this.squareKey;
								buttonSkin.skinType = ButtonSkinType.SQUARE;
								return buttonSkin;
							}
						}
					}
					else if (buttonName == "F10")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (num != 3736956062U)
				{
					if (num != 3762169905U)
					{
						if (num == 4219689196U)
						{
							if (buttonName == "Tab")
							{
								buttonSkin.sprite = this.rectangleKey;
								buttonSkin.skinType = ButtonSkinType.WIDE;
								return buttonSkin;
							}
						}
					}
					else if (buttonName == "Right Bracket")
					{
						buttonSkin.sprite = this.squareKey;
						buttonSkin.symbol = "]";
						buttonSkin.skinType = ButtonSkinType.SQUARE;
						return buttonSkin;
					}
				}
				else if (buttonName == "F12")
				{
					buttonSkin.sprite = this.squareKey;
					buttonSkin.skinType = ButtonSkinType.SQUARE;
					return buttonSkin;
				}
			}
			buttonSkin.skinType = ButtonSkinType.BLANK;
			buttonSkin.symbol = buttonName;
		}
		return buttonSkin;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x0008257E File Offset: 0x0008077E
	private void SetupRefs()
	{
		this.customKeys = new HashSet<MappableKey>();
		this.customButtons = new HashSet<MappableControllerButton>();
		this.orig_SetupRefs();
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x0008259C File Offset: 0x0008079C
	public void AddMappableKey(MappableKey b)
	{
		this.customKeys.Add(b);
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x000825AB File Offset: 0x000807AB
	public void RemoveMappableKey(MappableKey b)
	{
		this.customKeys.Remove(b);
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000825BA File Offset: 0x000807BA
	public void AddMappableControllerButton(MappableControllerButton b)
	{
		this.customButtons.Add(b);
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x000825C9 File Offset: 0x000807C9
	public void RemoveMappableControllerButton(MappableControllerButton b)
	{
		this.customButtons.Remove(b);
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000825D8 File Offset: 0x000807D8
	public void orig_RefreshKeyMappings()
	{
		foreach (MappableKey mappableKey in this.mappableKeyboardButtons.GetComponentsInChildren<MappableKey>())
		{
			mappableKey.GetBinding();
			mappableKey.ShowCurrentBinding();
		}
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x0008260D File Offset: 0x0008080D
	public IEnumerator orig_ShowCurrentKeyboardMappings()
	{
		MappableKey[] componentsInChildren = this.mappableKeyboardButtons.GetComponentsInChildren<MappableKey>();
		foreach (MappableKey mappableKey in componentsInChildren)
		{
			mappableKey.GetBinding();
			mappableKey.ShowCurrentBinding();
			yield return null;
		}
		MappableKey[] array = null;
		yield return null;
		yield break;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x0008261C File Offset: 0x0008081C
	public void orig_RefreshButtonMappings()
	{
		MappableControllerButton[] componentsInChildren = this.mappableControllerButtons.GetComponentsInChildren<MappableControllerButton>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].ShowCurrentBinding();
		}
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x0008264B File Offset: 0x0008084B
	public IEnumerator orig_ShowCurrentButtonMappings()
	{
		MappableControllerButton[] actionButtons = this.mappableControllerButtons.GetComponentsInChildren<MappableControllerButton>();
		int num;
		for (int i = 0; i < actionButtons.Length; i = num + 1)
		{
			actionButtons[i].ShowCurrentBinding();
			yield return null;
			num = i;
		}
		yield return null;
		yield break;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x0008265C File Offset: 0x0008085C
	private ButtonSkin orig_GetButtonSkinFor(InputControlType inputControlType)
	{
		ButtonSkin buttonSkin = new ButtonSkin(this.blankKey, "", ButtonSkinType.CONTROLLER);
		if (this.ih.activeGamepadType == GamepadType.PS4)
		{
			switch (inputControlType)
			{
			case InputControlType.DPadUp:
				buttonSkin.sprite = this.dpadUp;
				break;
			case InputControlType.DPadDown:
				buttonSkin.sprite = this.dpadDown;
				break;
			case InputControlType.DPadLeft:
				buttonSkin.sprite = this.dpadLeft;
				break;
			case InputControlType.DPadRight:
				buttonSkin.sprite = this.dpadRight;
				break;
			case InputControlType.LeftTrigger:
				buttonSkin.sprite = this.ps4lt;
				break;
			case InputControlType.RightTrigger:
				buttonSkin.sprite = this.ps4rt;
				break;
			case InputControlType.LeftBumper:
				buttonSkin.sprite = this.ps4lb;
				break;
			case InputControlType.RightBumper:
				buttonSkin.sprite = this.ps4rb;
				break;
			case InputControlType.Action1:
				buttonSkin.sprite = this.ps4x;
				break;
			case InputControlType.Action2:
				buttonSkin.sprite = this.ps4circle;
				break;
			case InputControlType.Action3:
				buttonSkin.sprite = this.ps4square;
				break;
			case InputControlType.Action4:
				buttonSkin.sprite = this.ps4triangle;
				break;
			default:
				switch (inputControlType)
				{
				case InputControlType.Start:
					buttonSkin.sprite = this.start;
					break;
				case InputControlType.Select:
					buttonSkin.sprite = this.select;
					break;
				case InputControlType.System:
				case InputControlType.Pause:
				case InputControlType.Menu:
					break;
				case InputControlType.Options:
					buttonSkin.sprite = this.options;
					break;
				case InputControlType.Share:
					buttonSkin.sprite = this.share;
					break;
				default:
					if (inputControlType == InputControlType.TouchPadButton)
					{
						buttonSkin.sprite = this.touchpadButton;
					}
					break;
				}
				break;
			}
		}
		else if (this.ih.activeGamepadType == GamepadType.SWITCH_JOYCON_DUAL || this.ih.activeGamepadType == GamepadType.SWITCH_PRO_CONTROLLER)
		{
			switch (inputControlType)
			{
			case InputControlType.DPadUp:
				buttonSkin.sprite = this.switchHidDPadUp;
				break;
			case InputControlType.DPadDown:
				buttonSkin.sprite = this.switchHidDPadDown;
				break;
			case InputControlType.DPadLeft:
				buttonSkin.sprite = this.switchHidDPadLeft;
				break;
			case InputControlType.DPadRight:
				buttonSkin.sprite = this.switchHidDPadRight;
				break;
			case InputControlType.LeftTrigger:
				buttonSkin.sprite = this.switchHidLeftTrigger;
				break;
			case InputControlType.RightTrigger:
				buttonSkin.sprite = this.switchHidRightTrigger;
				break;
			case InputControlType.LeftBumper:
				buttonSkin.sprite = this.switchHidLeftBumper;
				break;
			case InputControlType.RightBumper:
				buttonSkin.sprite = this.switchHidRightBumper;
				break;
			case InputControlType.Action1:
				buttonSkin.sprite = this.switchHidB;
				break;
			case InputControlType.Action2:
				buttonSkin.sprite = this.switchHidA;
				break;
			case InputControlType.Action3:
				buttonSkin.sprite = this.switchHidY;
				break;
			case InputControlType.Action4:
				buttonSkin.sprite = this.switchHidX;
				break;
			default:
				if (inputControlType != InputControlType.Start)
				{
					if (inputControlType == InputControlType.Select)
					{
						buttonSkin.sprite = this.switchHidMinus;
					}
				}
				else
				{
					buttonSkin.sprite = this.switchHidPlus;
				}
				break;
			}
		}
		else
		{
			switch (inputControlType)
			{
			case InputControlType.DPadUp:
				buttonSkin.sprite = this.dpadUp;
				break;
			case InputControlType.DPadDown:
				buttonSkin.sprite = this.dpadDown;
				break;
			case InputControlType.DPadLeft:
				buttonSkin.sprite = this.dpadLeft;
				break;
			case InputControlType.DPadRight:
				buttonSkin.sprite = this.dpadRight;
				break;
			case InputControlType.LeftTrigger:
				buttonSkin.sprite = this.lt;
				break;
			case InputControlType.RightTrigger:
				buttonSkin.sprite = this.rt;
				break;
			case InputControlType.LeftBumper:
				buttonSkin.sprite = this.lb;
				break;
			case InputControlType.RightBumper:
				buttonSkin.sprite = this.rb;
				break;
			case InputControlType.Action1:
				buttonSkin.sprite = this.a;
				break;
			case InputControlType.Action2:
				buttonSkin.sprite = this.b;
				break;
			case InputControlType.Action3:
				buttonSkin.sprite = this.x;
				break;
			case InputControlType.Action4:
				buttonSkin.sprite = this.y;
				break;
			default:
				switch (inputControlType)
				{
				case InputControlType.Back:
					buttonSkin.sprite = this.select;
					break;
				case InputControlType.Start:
					buttonSkin.sprite = this.start;
					break;
				case InputControlType.Select:
					buttonSkin.sprite = this.select;
					break;
				case InputControlType.System:
				case InputControlType.Options:
				case InputControlType.Pause:
					break;
				case InputControlType.Menu:
					buttonSkin.sprite = this.menu;
					break;
				default:
					if (inputControlType == InputControlType.View)
					{
						buttonSkin.sprite = this.view;
					}
					break;
				}
				break;
			}
		}
		return buttonSkin;
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x00082AEB File Offset: 0x00080CEB
	private void orig_SetupRefs()
	{
		this.ih = GameManager.instance.inputHandler;
		this.active = true;
	}

	// Token: 0x0400205E RID: 8286
	[Header("Empty Button")]
	public Sprite blankKey;

	// Token: 0x0400205F RID: 8287
	[Header("Keyboard Button Skins")]
	public Sprite squareKey;

	// Token: 0x04002060 RID: 8288
	public Sprite rectangleKey;

	// Token: 0x04002061 RID: 8289
	public Sprite upArrowKey;

	// Token: 0x04002062 RID: 8290
	public Sprite downArrowKey;

	// Token: 0x04002063 RID: 8291
	public Sprite leftArrowKey;

	// Token: 0x04002064 RID: 8292
	public Sprite rightArrowKey;

	// Token: 0x04002065 RID: 8293
	[Space]
	public Sprite leftMouseButton;

	// Token: 0x04002066 RID: 8294
	public Sprite rightMouseButton;

	// Token: 0x04002067 RID: 8295
	public Sprite middleMouseButton;

	// Token: 0x04002068 RID: 8296
	[Header("Default Font Settings")]
	public int labelFontSize;

	// Token: 0x04002069 RID: 8297
	public TextAnchor labelAlignment;

	// Token: 0x0400206A RID: 8298
	[Space(10f)]
	public int buttonFontSize;

	// Token: 0x0400206B RID: 8299
	public TextAnchor buttonAlignment;

	// Token: 0x0400206C RID: 8300
	[Space(10f)]
	public int wideButtonFontSize;

	// Token: 0x0400206D RID: 8301
	public TextAnchor wideButtonAlignment;

	// Token: 0x0400206E RID: 8302
	[Header("Universal Controller Buttons")]
	public Sprite a;

	// Token: 0x0400206F RID: 8303
	public Sprite b;

	// Token: 0x04002070 RID: 8304
	public Sprite x;

	// Token: 0x04002071 RID: 8305
	public Sprite y;

	// Token: 0x04002072 RID: 8306
	public Sprite lb;

	// Token: 0x04002073 RID: 8307
	public Sprite lt;

	// Token: 0x04002074 RID: 8308
	public Sprite rb;

	// Token: 0x04002075 RID: 8309
	public Sprite rt;

	// Token: 0x04002076 RID: 8310
	public Sprite start;

	// Token: 0x04002077 RID: 8311
	public Sprite select;

	// Token: 0x04002078 RID: 8312
	public Sprite dpadLeft;

	// Token: 0x04002079 RID: 8313
	public Sprite dpadRight;

	// Token: 0x0400207A RID: 8314
	public Sprite dpadUp;

	// Token: 0x0400207B RID: 8315
	public Sprite dpadDown;

	// Token: 0x0400207C RID: 8316
	[Header("XBone Controller Buttons")]
	public Sprite view;

	// Token: 0x0400207D RID: 8317
	public Sprite menu;

	// Token: 0x0400207E RID: 8318
	[Header("PS4 Controller Buttons")]
	public Sprite options;

	// Token: 0x0400207F RID: 8319
	public Sprite share;

	// Token: 0x04002080 RID: 8320
	public Sprite touchpadButton;

	// Token: 0x04002081 RID: 8321
	public Sprite ps4x;

	// Token: 0x04002082 RID: 8322
	public Sprite ps4square;

	// Token: 0x04002083 RID: 8323
	public Sprite ps4triangle;

	// Token: 0x04002084 RID: 8324
	public Sprite ps4circle;

	// Token: 0x04002085 RID: 8325
	public Sprite ps4lb;

	// Token: 0x04002086 RID: 8326
	public Sprite ps4lt;

	// Token: 0x04002087 RID: 8327
	public Sprite ps4rb;

	// Token: 0x04002088 RID: 8328
	public Sprite ps4rt;

	// Token: 0x04002089 RID: 8329
	[Header("Switch HID Buttons")]
	[SerializeField]
	private Sprite switchHidB;

	// Token: 0x0400208A RID: 8330
	[SerializeField]
	private Sprite switchHidA;

	// Token: 0x0400208B RID: 8331
	[SerializeField]
	private Sprite switchHidY;

	// Token: 0x0400208C RID: 8332
	[SerializeField]
	private Sprite switchHidX;

	// Token: 0x0400208D RID: 8333
	[SerializeField]
	private Sprite switchHidLeftBumper;

	// Token: 0x0400208E RID: 8334
	[SerializeField]
	private Sprite switchHidLeftTrigger;

	// Token: 0x0400208F RID: 8335
	[SerializeField]
	private Sprite switchHidRightBumper;

	// Token: 0x04002090 RID: 8336
	[SerializeField]
	private Sprite switchHidRightTrigger;

	// Token: 0x04002091 RID: 8337
	[SerializeField]
	private Sprite switchHidMinus;

	// Token: 0x04002092 RID: 8338
	[SerializeField]
	private Sprite switchHidPlus;

	// Token: 0x04002093 RID: 8339
	[SerializeField]
	private Sprite switchHidDPadUp;

	// Token: 0x04002094 RID: 8340
	[SerializeField]
	private Sprite switchHidDPadDown;

	// Token: 0x04002095 RID: 8341
	[SerializeField]
	private Sprite switchHidDPadLeft;

	// Token: 0x04002096 RID: 8342
	[SerializeField]
	private Sprite switchHidDPadRight;

	// Token: 0x04002097 RID: 8343
	private bool active;

	// Token: 0x04002098 RID: 8344
	private GameManager gm;

	// Token: 0x04002099 RID: 8345
	private InputHandler ih;

	// Token: 0x0400209A RID: 8346
	[Header("Keyboard Menu")]
	public RectTransform mappableKeyboardButtons;

	// Token: 0x0400209B RID: 8347
	[Header("Controller Menu")]
	public RectTransform mappableControllerButtons;

	// Token: 0x0400209E RID: 8350
	private HashSet<MappableKey> customKeys;

	// Token: 0x0400209F RID: 8351
	private HashSet<MappableControllerButton> customButtons;
}
