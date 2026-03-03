using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace InControl
{
	// Token: 0x020006CB RID: 1739
	public abstract class PlayerActionSet
	{
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000E6A4E File Offset: 0x000E4C4E
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x000E6A56 File Offset: 0x000E4C56
		public InputDevice Device { get; set; }

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000E6A5F File Offset: 0x000E4C5F
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x000E6A67 File Offset: 0x000E4C67
		public List<InputDevice> IncludeDevices { get; private set; }

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000E6A70 File Offset: 0x000E4C70
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x000E6A78 File Offset: 0x000E4C78
		public List<InputDevice> ExcludeDevices { get; private set; }

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000E6A81 File Offset: 0x000E4C81
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x000E6A89 File Offset: 0x000E4C89
		public ReadOnlyCollection<PlayerAction> Actions { get; private set; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000E6A92 File Offset: 0x000E4C92
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x000E6A9A File Offset: 0x000E4C9A
		public ulong UpdateTick { get; protected set; }

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x0600297B RID: 10619 RVA: 0x000E6AA4 File Offset: 0x000E4CA4
		// (remove) Token: 0x0600297C RID: 10620 RVA: 0x000E6ADC File Offset: 0x000E4CDC
		public event Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000E6B11 File Offset: 0x000E4D11
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x000E6B19 File Offset: 0x000E4D19
		public bool Enabled { get; set; }

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000E6B22 File Offset: 0x000E4D22
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x000E6B2A File Offset: 0x000E4D2A
		public bool PreventInputWhileListeningForBinding { get; set; }

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x000E6B33 File Offset: 0x000E4D33
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x000E6B3B File Offset: 0x000E4D3B
		public object UserData { get; set; }

		// Token: 0x06002983 RID: 10627 RVA: 0x000E6B44 File Offset: 0x000E4D44
		protected PlayerActionSet()
		{
			this.actions = new List<PlayerAction>();
			this.oneAxisActions = new List<PlayerOneAxisAction>();
			this.twoAxisActions = new List<PlayerTwoAxisAction>();
			this.actionsByName = new Dictionary<string, PlayerAction>();
			this.listenOptions = new BindingListenOptions();
			base..ctor();
			this.Enabled = true;
			this.PreventInputWhileListeningForBinding = true;
			this.Device = null;
			this.IncludeDevices = new List<InputDevice>();
			this.ExcludeDevices = new List<InputDevice>();
			this.Actions = new ReadOnlyCollection<PlayerAction>(this.actions);
			InputManager.AttachPlayerActionSet(this);
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000E6BD0 File Offset: 0x000E4DD0
		public void Destroy()
		{
			this.OnLastInputTypeChanged = null;
			InputManager.DetachPlayerActionSet(this);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000E6BDF File Offset: 0x000E4DDF
		protected PlayerAction CreatePlayerAction(string name)
		{
			return new PlayerAction(name, this);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000E6BE8 File Offset: 0x000E4DE8
		internal void AddPlayerAction(PlayerAction action)
		{
			action.Device = this.FindActiveDevice();
			if (this.actionsByName.ContainsKey(action.Name))
			{
				throw new InControlException("Action '" + action.Name + "' already exists in this set.");
			}
			this.actions.Add(action);
			this.actionsByName.Add(action.Name, action);
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000E6C50 File Offset: 0x000E4E50
		protected PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			PlayerOneAxisAction playerOneAxisAction = new PlayerOneAxisAction(negativeAction, positiveAction);
			this.oneAxisActions.Add(playerOneAxisAction);
			return playerOneAxisAction;
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000E6C74 File Offset: 0x000E4E74
		protected PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			PlayerTwoAxisAction playerTwoAxisAction = new PlayerTwoAxisAction(negativeXAction, positiveXAction, negativeYAction, positiveYAction);
			this.twoAxisActions.Add(playerTwoAxisAction);
			return playerTwoAxisAction;
		}

		// Token: 0x170005CD RID: 1485
		public PlayerAction this[string actionName]
		{
			get
			{
				PlayerAction result;
				if (this.actionsByName.TryGetValue(actionName, out result))
				{
					return result;
				}
				throw new KeyNotFoundException("Action '" + actionName + "' does not exist in this action set.");
			}
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x000E6CD0 File Offset: 0x000E4ED0
		public PlayerAction GetPlayerActionByName(string actionName)
		{
			PlayerAction result;
			if (this.actionsByName.TryGetValue(actionName, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x000E6CF0 File Offset: 0x000E4EF0
		internal void Update(ulong updateTick, float deltaTime)
		{
			InputDevice device = this.Device ?? this.FindActiveDevice();
			BindingSourceType lastInputType = this.LastInputType;
			ulong lastInputTypeChangedTick = this.LastInputTypeChangedTick;
			InputDeviceClass lastDeviceClass = this.LastDeviceClass;
			InputDeviceStyle lastDeviceStyle = this.LastDeviceStyle;
			int count = this.actions.Count;
			for (int i = 0; i < count; i++)
			{
				PlayerAction playerAction = this.actions[i];
				playerAction.Update(updateTick, deltaTime, device);
				if (playerAction.UpdateTick > this.UpdateTick)
				{
					this.UpdateTick = playerAction.UpdateTick;
					this.activeDevice = playerAction.ActiveDevice;
				}
				if (playerAction.LastInputTypeChangedTick > lastInputTypeChangedTick)
				{
					lastInputType = playerAction.LastInputType;
					lastInputTypeChangedTick = playerAction.LastInputTypeChangedTick;
					lastDeviceClass = playerAction.LastDeviceClass;
					lastDeviceStyle = playerAction.LastDeviceStyle;
				}
			}
			int count2 = this.oneAxisActions.Count;
			for (int j = 0; j < count2; j++)
			{
				this.oneAxisActions[j].Update(updateTick, deltaTime);
			}
			int count3 = this.twoAxisActions.Count;
			for (int k = 0; k < count3; k++)
			{
				this.twoAxisActions[k].Update(updateTick, deltaTime);
			}
			if (lastInputTypeChangedTick > this.LastInputTypeChangedTick)
			{
				bool flag = lastInputType != this.LastInputType;
				this.LastInputType = lastInputType;
				this.LastInputTypeChangedTick = lastInputTypeChangedTick;
				this.LastDeviceClass = lastDeviceClass;
				this.LastDeviceStyle = lastDeviceStyle;
				if (this.OnLastInputTypeChanged != null && flag)
				{
					this.OnLastInputTypeChanged(lastInputType);
				}
			}
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x000E6E6C File Offset: 0x000E506C
		public void Reset()
		{
			int count = this.actions.Count;
			for (int i = 0; i < count; i++)
			{
				this.actions[i].ResetBindings();
			}
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x000E6EA4 File Offset: 0x000E50A4
		private InputDevice FindActiveDevice()
		{
			bool flag = this.IncludeDevices.Count > 0;
			bool flag2 = this.ExcludeDevices.Count > 0;
			if (flag || flag2)
			{
				InputDevice inputDevice = InputDevice.Null;
				int count = InputManager.Devices.Count;
				for (int i = 0; i < count; i++)
				{
					InputDevice inputDevice2 = InputManager.Devices[i];
					if (inputDevice2 != inputDevice && inputDevice2.LastInputAfter(inputDevice) && !inputDevice2.Passive && (!flag2 || !this.ExcludeDevices.Contains(inputDevice2)) && (!flag || this.IncludeDevices.Contains(inputDevice2)))
					{
						inputDevice = inputDevice2;
					}
				}
				return inputDevice;
			}
			return InputManager.ActiveDevice;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000E6F4C File Offset: 0x000E514C
		public void ClearInputState()
		{
			int count = this.actions.Count;
			for (int i = 0; i < count; i++)
			{
				this.actions[i].ClearInputState();
			}
			int count2 = this.oneAxisActions.Count;
			for (int j = 0; j < count2; j++)
			{
				this.oneAxisActions[j].ClearInputState();
			}
			int count3 = this.twoAxisActions.Count;
			for (int k = 0; k < count3; k++)
			{
				this.twoAxisActions[k].ClearInputState();
			}
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000E6FE0 File Offset: 0x000E51E0
		public bool HasBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return false;
			}
			int count = this.actions.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.actions[i].HasBinding(binding))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000E7028 File Offset: 0x000E5228
		public void RemoveBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return;
			}
			int count = this.actions.Count;
			for (int i = 0; i < count; i++)
			{
				this.actions[i].RemoveBinding(binding);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x000E7069 File Offset: 0x000E5269
		public bool IsListeningForBinding
		{
			get
			{
				return this.listenWithAction != null;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000E7074 File Offset: 0x000E5274
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x000E707C File Offset: 0x000E527C
		public BindingListenOptions ListenOptions
		{
			get
			{
				return this.listenOptions;
			}
			set
			{
				this.listenOptions = (value ?? new BindingListenOptions());
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000E708E File Offset: 0x000E528E
		public InputDevice ActiveDevice
		{
			get
			{
				return this.activeDevice ?? InputDevice.Null;
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000E70A0 File Offset: 0x000E52A0
		public byte[] SaveData()
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.UTF8))
				{
					binaryWriter.Write(66);
					binaryWriter.Write(73);
					binaryWriter.Write(78);
					binaryWriter.Write(68);
					binaryWriter.Write(2);
					int count = this.actions.Count;
					binaryWriter.Write(count);
					for (int i = 0; i < count; i++)
					{
						this.actions[i].Save(binaryWriter);
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000E7158 File Offset: 0x000E5358
		public void LoadData(byte[] data)
		{
			if (data == null)
			{
				return;
			}
			try
			{
				using (MemoryStream memoryStream = new MemoryStream(data))
				{
					using (BinaryReader binaryReader = new BinaryReader(memoryStream))
					{
						if (binaryReader.ReadUInt32() != 1145981250U)
						{
							throw new Exception("Unknown data format.");
						}
						ushort num = binaryReader.ReadUInt16();
						if (num < 1 || num > 2)
						{
							throw new Exception("Unknown data format version: " + num.ToString());
						}
						int num2 = binaryReader.ReadInt32();
						for (int i = 0; i < num2; i++)
						{
							PlayerAction playerAction;
							if (this.actionsByName.TryGetValue(binaryReader.ReadString(), out playerAction))
							{
								playerAction.Load(binaryReader, num);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Logger.LogError("Provided state could not be loaded:\n" + ex.Message);
				this.Reset();
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000E7250 File Offset: 0x000E5450
		public string Save()
		{
			return Convert.ToBase64String(this.SaveData());
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000E7260 File Offset: 0x000E5460
		public void Load(string data)
		{
			if (data == null)
			{
				return;
			}
			try
			{
				this.LoadData(Convert.FromBase64String(data));
			}
			catch (Exception ex)
			{
				Logger.LogError("Provided state could not be loaded:\n" + ex.Message);
				this.Reset();
			}
		}

		// Token: 0x04002F95 RID: 12181
		public BindingSourceType LastInputType;

		// Token: 0x04002F97 RID: 12183
		public ulong LastInputTypeChangedTick;

		// Token: 0x04002F98 RID: 12184
		public InputDeviceClass LastDeviceClass;

		// Token: 0x04002F99 RID: 12185
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x04002F9D RID: 12189
		private List<PlayerAction> actions;

		// Token: 0x04002F9E RID: 12190
		private List<PlayerOneAxisAction> oneAxisActions;

		// Token: 0x04002F9F RID: 12191
		private List<PlayerTwoAxisAction> twoAxisActions;

		// Token: 0x04002FA0 RID: 12192
		private Dictionary<string, PlayerAction> actionsByName;

		// Token: 0x04002FA1 RID: 12193
		private BindingListenOptions listenOptions;

		// Token: 0x04002FA2 RID: 12194
		internal PlayerAction listenWithAction;

		// Token: 0x04002FA3 RID: 12195
		private InputDevice activeDevice;

		// Token: 0x04002FA4 RID: 12196
		private const ushort currentDataFormatVersion = 2;
	}
}
