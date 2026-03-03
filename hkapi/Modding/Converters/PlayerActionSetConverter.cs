using System;
using InControl;
using Newtonsoft.Json;

namespace Modding.Converters
{
	/// <summary>
	/// JsonConverter to serialize and deserialize classes that derive from <c>PlayerActionSet</c>.<br />
	/// The target class needs to have a parameterless constructor
	/// that initializes the player actions that get read/written.<br />
	/// All of the added actions will get processed,
	/// so if there are unmappable actions, an <c>IMappablePlayerActions</c> interface should be added
	/// to filter the mappable keybinds.
	/// </summary>
	// Token: 0x02000DF3 RID: 3571
	public class PlayerActionSetConverter : JsonConverter
	{
		/// <inheritdoc />
		// Token: 0x060049B8 RID: 18872 RVA: 0x0018D277 File Offset: 0x0018B477
		public override bool CanConvert(Type objectType)
		{
			return objectType.IsSubclassOf(typeof(PlayerActionSet));
		}

		/// <inheritdoc />
		// Token: 0x060049B9 RID: 18873 RVA: 0x0018D28C File Offset: 0x0018B48C
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			PlayerActionSet playerActionSet = (PlayerActionSet)Activator.CreateInstance(objectType);
			IMappablePlayerActions mappablePlayerActions = playerActionSet as IMappablePlayerActions;
			Predicate<string> predicate;
			if (mappablePlayerActions == null)
			{
				predicate = ((string _) => true);
			}
			else
			{
				predicate = new Predicate<string>(mappablePlayerActions.IsMappable);
			}
			Predicate<string> predicate2 = predicate;
			reader.Read();
			while (reader.TokenType == JsonToken.PropertyName)
			{
				string text = (string)reader.Value;
				if (!predicate2(text))
				{
					reader.Read();
					reader.Read();
				}
				else
				{
					PlayerAction playerActionByName = playerActionSet.GetPlayerActionByName(text);
					reader.Read();
					if (playerActionByName != null)
					{
						string text2 = reader.Value as string;
						if (text2 != null)
						{
							if (text2 == default(InputHandler.KeyOrMouseBinding).ToString() || text2 == InputControlType.None.ToString())
							{
								playerActionByName.ClearBindings();
							}
							else
							{
								InputHandler.KeyOrMouseBinding? keyOrMouseBinding = KeybindUtil.ParseBinding(text2);
								if (keyOrMouseBinding != null)
								{
									InputHandler.KeyOrMouseBinding valueOrDefault = keyOrMouseBinding.GetValueOrDefault();
									playerActionByName.ClearBindings();
									playerActionByName.AddKeyOrMouseBinding(valueOrDefault);
								}
								else
								{
									InputControlType? inputControlType = KeybindUtil.ParseInputControlTypeBinding(text2);
									if (inputControlType != null)
									{
										InputControlType valueOrDefault2 = inputControlType.GetValueOrDefault();
										playerActionByName.ClearBindings();
										playerActionByName.AddInputControlType(valueOrDefault2);
									}
									else
									{
										Logger.APILogger.LogWarn("Invalid keybinding " + text2);
									}
								}
							}
						}
						else
						{
							Logger.APILogger.LogWarn(string.Format("Expected string for keybind, got `{0}", reader.Value));
						}
					}
					else
					{
						Logger.APILogger.LogWarn("Invalid keybind name " + text);
					}
					reader.Read();
				}
			}
			return playerActionSet;
		}

		/// <inheritdoc />
		// Token: 0x060049BA RID: 18874 RVA: 0x0018D43C File Offset: 0x0018B63C
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			PlayerActionSet playerActionSet = (PlayerActionSet)value;
			IMappablePlayerActions mappablePlayerActions = playerActionSet as IMappablePlayerActions;
			Predicate<string> predicate;
			if (mappablePlayerActions != null)
			{
				predicate = new Predicate<string>(mappablePlayerActions.IsMappable);
			}
			else
			{
				predicate = ((string _) => true);
			}
			writer.WriteStartObject();
			foreach (PlayerAction playerAction in playerActionSet.Actions)
			{
				if (predicate(playerAction.Name))
				{
					writer.WritePropertyName(playerAction.Name);
					InputHandler.KeyOrMouseBinding keyOrMouseBinding = playerAction.GetKeyOrMouseBinding();
					InputControlType controllerButtonBinding = playerAction.GetControllerButtonBinding();
					if (keyOrMouseBinding.Key != Key.None)
					{
						writer.WriteValue(keyOrMouseBinding.ToString());
					}
					else if (controllerButtonBinding != InputControlType.None)
					{
						writer.WriteValue(controllerButtonBinding.ToString());
					}
					else
					{
						writer.WriteValue("None");
					}
				}
			}
			writer.WriteEndObject();
		}
	}
}
