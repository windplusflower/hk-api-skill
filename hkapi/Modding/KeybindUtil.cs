using System;
using InControl;

namespace Modding
{
	/// <summary>
	/// Utils for interacting with InControl keybindings.
	/// </summary>
	// Token: 0x02000D68 RID: 3432
	public static class KeybindUtil
	{
		/// <summary>
		/// Gets a <c>KeyOrMouseBinding</c> from a player action.
		/// </summary>
		/// <param name="action">The player action</param>
		/// <returns></returns>
		// Token: 0x060046B5 RID: 18101 RVA: 0x00180848 File Offset: 0x0017EA48
		public static InputHandler.KeyOrMouseBinding GetKeyOrMouseBinding(this PlayerAction action)
		{
			foreach (BindingSource bindingSource in action.Bindings)
			{
				KeyBindingSource keyBindingSource = bindingSource as KeyBindingSource;
				InputHandler.KeyOrMouseBinding keyOrMouseBinding;
				if (keyBindingSource != null)
				{
					if (keyBindingSource.Control.IncludeCount != 1)
					{
						goto IL_6D;
					}
					keyOrMouseBinding = new InputHandler.KeyOrMouseBinding(keyBindingSource.Control.GetInclude(0));
				}
				else
				{
					MouseBindingSource mouseBindingSource = bindingSource as MouseBindingSource;
					if (mouseBindingSource == null)
					{
						goto IL_6D;
					}
					keyOrMouseBinding = new InputHandler.KeyOrMouseBinding(mouseBindingSource.Control);
				}
				IL_79:
				InputHandler.KeyOrMouseBinding keyOrMouseBinding2 = keyOrMouseBinding;
				if (!InputHandler.KeyOrMouseBinding.IsNone(keyOrMouseBinding2))
				{
					return keyOrMouseBinding2;
				}
				continue;
				IL_6D:
				keyOrMouseBinding = default(InputHandler.KeyOrMouseBinding);
				goto IL_79;
			}
			return default(InputHandler.KeyOrMouseBinding);
		}

		/// <summary>
		/// Adds a binding to the player action based on a <c>KeyOrMouseBinding</c>.
		/// </summary>
		/// <param name="action">The player action</param>
		/// <param name="binding">The binding</param>
		// Token: 0x060046B6 RID: 18102 RVA: 0x00180914 File Offset: 0x0017EB14
		public static void AddKeyOrMouseBinding(this PlayerAction action, InputHandler.KeyOrMouseBinding binding)
		{
			if (binding.Key != Key.None)
			{
				action.AddBinding(new KeyBindingSource(new KeyCombo(new Key[]
				{
					binding.Key
				})));
				return;
			}
			if (binding.Mouse != Mouse.None)
			{
				action.AddBinding(new MouseBindingSource(binding.Mouse));
			}
		}

		/// <summary>
		/// Parses a key or mouse binding from a string.
		/// </summary>
		/// <param name="src">The source string</param>
		/// <returns></returns>
		// Token: 0x060046B7 RID: 18103 RVA: 0x00180964 File Offset: 0x0017EB64
		public static InputHandler.KeyOrMouseBinding? ParseBinding(string src)
		{
			Key key;
			if (Enum.TryParse<Key>(src, out key))
			{
				return new InputHandler.KeyOrMouseBinding?(new InputHandler.KeyOrMouseBinding(key));
			}
			Mouse mouse;
			if (Enum.TryParse<Mouse>(src, out mouse))
			{
				return new InputHandler.KeyOrMouseBinding?(new InputHandler.KeyOrMouseBinding(mouse));
			}
			return null;
		}

		/// <summary>
		/// Gets a controller button binding for a player action.
		/// </summary>
		/// <param name="ac">The player action.</param>
		/// <returns></returns>
		// Token: 0x060046B8 RID: 18104 RVA: 0x001809A8 File Offset: 0x0017EBA8
		public static InputControlType GetControllerButtonBinding(this PlayerAction ac)
		{
			foreach (BindingSource bindingSource in ac.Bindings)
			{
				DeviceBindingSource deviceBindingSource = bindingSource as DeviceBindingSource;
				if (deviceBindingSource != null)
				{
					return deviceBindingSource.Control;
				}
			}
			return InputControlType.None;
		}

		/// <summary>
		/// Adds a controller button binding to the player action based on a <c>InputControlType</c>.
		/// </summary>
		/// <param name="action">The player action</param>
		/// <param name="binding">The binding</param>
		// Token: 0x060046B9 RID: 18105 RVA: 0x00180A04 File Offset: 0x0017EC04
		public static void AddInputControlType(this PlayerAction action, InputControlType binding)
		{
			if (binding != InputControlType.None)
			{
				action.AddBinding(new DeviceBindingSource(binding));
			}
		}

		/// <summary>
		/// Parses a InputControlType binding from a string.
		/// </summary>
		/// <param name="src">The source string</param>
		/// <returns></returns>
		// Token: 0x060046BA RID: 18106 RVA: 0x00180A18 File Offset: 0x0017EC18
		public static InputControlType? ParseInputControlTypeBinding(string src)
		{
			InputControlType value;
			if (Enum.TryParse<InputControlType>(src, out value))
			{
				return new InputControlType?(value);
			}
			return null;
		}
	}
}
