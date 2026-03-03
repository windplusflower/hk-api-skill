using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006CA RID: 1738
	public class PlayerAction : OneAxisInputControl
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x000E5C96 File Offset: 0x000E3E96
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x000E5C9E File Offset: 0x000E3E9E
		public string Name { get; private set; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000E5CA7 File Offset: 0x000E3EA7
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x000E5CAF File Offset: 0x000E3EAF
		public PlayerActionSet Owner { get; private set; }

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06002943 RID: 10563 RVA: 0x000E5CB8 File Offset: 0x000E3EB8
		// (remove) Token: 0x06002944 RID: 10564 RVA: 0x000E5CF0 File Offset: 0x000E3EF0
		public event Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06002945 RID: 10565 RVA: 0x000E5D28 File Offset: 0x000E3F28
		// (remove) Token: 0x06002946 RID: 10566 RVA: 0x000E5D60 File Offset: 0x000E3F60
		public event Action OnBindingsChanged;

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000E5D95 File Offset: 0x000E3F95
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x000E5D9D File Offset: 0x000E3F9D
		public object UserData { get; set; }

		// Token: 0x06002949 RID: 10569 RVA: 0x000E5DA8 File Offset: 0x000E3FA8
		public PlayerAction(string name, PlayerActionSet owner)
		{
			this.defaultBindings = new List<BindingSource>();
			this.regularBindings = new List<BindingSource>();
			this.visibleBindings = new List<BindingSource>();
			this.bindingSourceListeners = new BindingSourceListener[]
			{
				new DeviceBindingSourceListener(),
				new UnknownDeviceBindingSourceListener(),
				new KeyBindingSourceListener(),
				new MouseBindingSourceListener()
			};
			base..ctor();
			this.Raw = true;
			this.Name = name;
			this.Owner = owner;
			this.bindings = new ReadOnlyCollection<BindingSource>(this.visibleBindings);
			this.unfilteredBindings = new ReadOnlyCollection<BindingSource>(this.regularBindings);
			owner.AddPlayerAction(this);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x000E5E48 File Offset: 0x000E4048
		public void AddDefaultBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return;
			}
			if (binding.BoundTo != null)
			{
				throw new InControlException("Binding source is already bound to action " + binding.BoundTo.Name);
			}
			if (!this.defaultBindings.Contains(binding))
			{
				this.defaultBindings.Add(binding);
				binding.BoundTo = this;
			}
			if (!this.regularBindings.Contains(binding))
			{
				this.regularBindings.Add(binding);
				binding.BoundTo = this;
				if (binding.IsValid)
				{
					this.visibleBindings.Add(binding);
				}
			}
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x000E5ED8 File Offset: 0x000E40D8
		public void AddDefaultBinding(params Key[] keys)
		{
			this.AddDefaultBinding(new KeyBindingSource(keys));
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000E5EE6 File Offset: 0x000E40E6
		public void AddDefaultBinding(KeyCombo keyCombo)
		{
			this.AddDefaultBinding(new KeyBindingSource(keyCombo));
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x000E5EF4 File Offset: 0x000E40F4
		public void AddDefaultBinding(Mouse control)
		{
			this.AddDefaultBinding(new MouseBindingSource(control));
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000E5F02 File Offset: 0x000E4102
		public void AddDefaultBinding(InputControlType control)
		{
			this.AddDefaultBinding(new DeviceBindingSource(control));
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x000E5F10 File Offset: 0x000E4110
		public bool AddBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return false;
			}
			if (binding.BoundTo != null)
			{
				Logger.LogWarning("Binding source is already bound to action " + binding.BoundTo.Name);
				return false;
			}
			if (this.regularBindings.Contains(binding))
			{
				return false;
			}
			this.regularBindings.Add(binding);
			binding.BoundTo = this;
			if (binding.IsValid)
			{
				this.visibleBindings.Add(binding);
			}
			this.triggerBindingChanged = true;
			return true;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x000E5F8C File Offset: 0x000E418C
		public bool InsertBindingAt(int index, BindingSource binding)
		{
			if (index < 0 || index > this.visibleBindings.Count)
			{
				throw new InControlException("Index is out of range for bindings on this action.");
			}
			if (index == this.visibleBindings.Count)
			{
				return this.AddBinding(binding);
			}
			if (binding == null)
			{
				return false;
			}
			if (binding.BoundTo != null)
			{
				Logger.LogWarning("Binding source is already bound to action " + binding.BoundTo.Name);
				return false;
			}
			if (this.regularBindings.Contains(binding))
			{
				return false;
			}
			int index2 = (index == 0) ? 0 : this.regularBindings.IndexOf(this.visibleBindings[index]);
			this.regularBindings.Insert(index2, binding);
			binding.BoundTo = this;
			if (binding.IsValid)
			{
				this.visibleBindings.Insert(index, binding);
			}
			this.triggerBindingChanged = true;
			return true;
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000E605C File Offset: 0x000E425C
		public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
		{
			if (findBinding == null || withBinding == null)
			{
				return false;
			}
			if (withBinding.BoundTo != null)
			{
				Logger.LogWarning("Binding source is already bound to action " + withBinding.BoundTo.Name);
				return false;
			}
			int num = this.regularBindings.IndexOf(findBinding);
			if (num < 0)
			{
				Logger.LogWarning("Binding source to replace is not present in this action.");
				return false;
			}
			findBinding.BoundTo = null;
			this.regularBindings[num] = withBinding;
			withBinding.BoundTo = this;
			num = this.visibleBindings.IndexOf(findBinding);
			if (num >= 0)
			{
				this.visibleBindings[num] = withBinding;
			}
			this.triggerBindingChanged = true;
			return true;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x000E6100 File Offset: 0x000E4300
		public bool HasBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return false;
			}
			BindingSource bindingSource = this.FindBinding(binding);
			return !(bindingSource == null) && bindingSource.BoundTo == this;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x000E6134 File Offset: 0x000E4334
		public BindingSource FindBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return null;
			}
			int num = this.regularBindings.IndexOf(binding);
			if (num >= 0)
			{
				return this.regularBindings[num];
			}
			return null;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x000E616C File Offset: 0x000E436C
		private void HardRemoveBinding(BindingSource binding)
		{
			if (binding == null)
			{
				return;
			}
			int num = this.regularBindings.IndexOf(binding);
			if (num >= 0)
			{
				BindingSource bindingSource = this.regularBindings[num];
				if (bindingSource.BoundTo == this)
				{
					bindingSource.BoundTo = null;
					this.regularBindings.RemoveAt(num);
					this.UpdateVisibleBindings();
					this.triggerBindingChanged = true;
				}
			}
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000E61CC File Offset: 0x000E43CC
		public void RemoveBinding(BindingSource binding)
		{
			BindingSource bindingSource = this.FindBinding(binding);
			if (bindingSource != null && bindingSource.BoundTo == this)
			{
				bindingSource.BoundTo = null;
				this.triggerBindingChanged = true;
			}
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x000E6201 File Offset: 0x000E4401
		public void RemoveBindingAt(int index)
		{
			if (index < 0 || index >= this.regularBindings.Count)
			{
				throw new InControlException("Index is out of range for bindings on this action.");
			}
			this.regularBindings[index].BoundTo = null;
			this.triggerBindingChanged = true;
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x000E623C File Offset: 0x000E443C
		private int CountBindingsOfType(BindingSourceType bindingSourceType)
		{
			int num = 0;
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				BindingSource bindingSource = this.regularBindings[i];
				if (bindingSource.BoundTo == this && bindingSource.BindingSourceType == bindingSourceType)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000E6288 File Offset: 0x000E4488
		private void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
		{
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				BindingSource bindingSource = this.regularBindings[i];
				if (bindingSource.BoundTo == this && bindingSource.BindingSourceType == bindingSourceType)
				{
					bindingSource.BoundTo = null;
					this.regularBindings.RemoveAt(i);
					this.triggerBindingChanged = true;
					return;
				}
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000E62E8 File Offset: 0x000E44E8
		private int IndexOfFirstInvalidBinding()
		{
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				if (!this.regularBindings[i].IsValid)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000E6324 File Offset: 0x000E4524
		public void ClearBindings()
		{
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				this.regularBindings[i].BoundTo = null;
			}
			this.regularBindings.Clear();
			this.visibleBindings.Clear();
			this.triggerBindingChanged = true;
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000E6378 File Offset: 0x000E4578
		public void ResetBindings()
		{
			this.ClearBindings();
			this.regularBindings.AddRange(this.defaultBindings);
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				BindingSource bindingSource = this.regularBindings[i];
				bindingSource.BoundTo = this;
				if (bindingSource.IsValid)
				{
					this.visibleBindings.Add(bindingSource);
				}
			}
			this.triggerBindingChanged = true;
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000E63E3 File Offset: 0x000E45E3
		public void ListenForBinding()
		{
			this.ListenForBindingReplacing(null);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000E63EC File Offset: 0x000E45EC
		public void ListenForBindingReplacing(BindingSource binding)
		{
			(this.ListenOptions ?? this.Owner.ListenOptions).ReplaceBinding = binding;
			this.Owner.listenWithAction = this;
			int num = this.bindingSourceListeners.Length;
			for (int i = 0; i < num; i++)
			{
				this.bindingSourceListeners[i].Reset();
			}
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000E6442 File Offset: 0x000E4642
		public void StopListeningForBinding()
		{
			if (this.IsListeningForBinding)
			{
				this.Owner.listenWithAction = null;
				this.triggerBindingEnded = true;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x000E645F File Offset: 0x000E465F
		public bool IsListeningForBinding
		{
			get
			{
				return this.Owner.listenWithAction == this;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000E646F File Offset: 0x000E466F
		public ReadOnlyCollection<BindingSource> Bindings
		{
			get
			{
				return this.bindings;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002961 RID: 10593 RVA: 0x000E6477 File Offset: 0x000E4677
		public ReadOnlyCollection<BindingSource> UnfilteredBindings
		{
			get
			{
				return this.unfilteredBindings;
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000E6480 File Offset: 0x000E4680
		private void RemoveOrphanedBindings()
		{
			for (int i = this.regularBindings.Count - 1; i >= 0; i--)
			{
				if (this.regularBindings[i].BoundTo != this)
				{
					this.regularBindings.RemoveAt(i);
				}
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000E64C8 File Offset: 0x000E46C8
		internal void Update(ulong updateTick, float deltaTime, InputDevice device)
		{
			this.Device = device;
			this.UpdateBindings(updateTick, deltaTime);
			if (this.triggerBindingChanged)
			{
				if (this.OnBindingsChanged != null)
				{
					this.OnBindingsChanged();
				}
				this.triggerBindingChanged = false;
			}
			if (this.triggerBindingEnded)
			{
				(this.ListenOptions ?? this.Owner.ListenOptions).CallOnBindingEnded(this);
				this.triggerBindingEnded = false;
			}
			this.DetectBindings();
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000E6538 File Offset: 0x000E4738
		private void UpdateBindings(ulong updateTick, float deltaTime)
		{
			bool flag = this.IsListeningForBinding || (this.Owner.IsListeningForBinding && this.Owner.PreventInputWhileListeningForBinding);
			BindingSourceType bindingSourceType = this.LastInputType;
			ulong num = this.LastInputTypeChangedTick;
			ulong updateTick2 = base.UpdateTick;
			InputDeviceClass lastDeviceClass = this.LastDeviceClass;
			InputDeviceStyle lastDeviceStyle = this.LastDeviceStyle;
			int count = this.regularBindings.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				BindingSource bindingSource = this.regularBindings[i];
				if (bindingSource.BoundTo != this)
				{
					this.regularBindings.RemoveAt(i);
					this.visibleBindings.Remove(bindingSource);
					this.triggerBindingChanged = true;
				}
				else if (!flag)
				{
					float value = bindingSource.GetValue(this.Device);
					if (base.UpdateWithValue(value, updateTick, deltaTime))
					{
						bindingSourceType = bindingSource.BindingSourceType;
						num = updateTick;
						lastDeviceClass = bindingSource.DeviceClass;
						lastDeviceStyle = bindingSource.DeviceStyle;
					}
				}
			}
			if (flag || count == 0)
			{
				base.UpdateWithValue(0f, updateTick, deltaTime);
			}
			base.Commit();
			this.ownerEnabled = this.Owner.Enabled;
			if (num > this.LastInputTypeChangedTick && (bindingSourceType != BindingSourceType.MouseBindingSource || Utility.Abs(base.LastValue - base.Value) >= MouseBindingSource.JitterThreshold))
			{
				bool flag2 = bindingSourceType != this.LastInputType;
				this.LastInputType = bindingSourceType;
				this.LastInputTypeChangedTick = num;
				this.LastDeviceClass = lastDeviceClass;
				this.LastDeviceStyle = lastDeviceStyle;
				if (this.OnLastInputTypeChanged != null && flag2)
				{
					this.OnLastInputTypeChanged(bindingSourceType);
				}
			}
			if (base.UpdateTick > updateTick2)
			{
				this.activeDevice = (this.LastInputTypeIsDevice ? this.Device : null);
			}
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000E66E8 File Offset: 0x000E48E8
		private void DetectBindings()
		{
			if (this.IsListeningForBinding)
			{
				BindingSource bindingSource = null;
				BindingListenOptions bindingListenOptions = this.ListenOptions ?? this.Owner.ListenOptions;
				int num = this.bindingSourceListeners.Length;
				for (int i = 0; i < num; i++)
				{
					bindingSource = this.bindingSourceListeners[i].Listen(bindingListenOptions, this.device);
					if (bindingSource != null)
					{
						break;
					}
				}
				if (bindingSource == null)
				{
					return;
				}
				if (!bindingListenOptions.CallOnBindingFound(this, bindingSource))
				{
					return;
				}
				if (this.HasBinding(bindingSource))
				{
					if (bindingListenOptions.RejectRedundantBindings)
					{
						bindingListenOptions.CallOnBindingRejected(this, bindingSource, BindingSourceRejectionType.DuplicateBindingOnActionSet);
						return;
					}
					this.StopListeningForBinding();
					bindingListenOptions.CallOnBindingAdded(this, bindingSource);
					return;
				}
				else
				{
					if (bindingListenOptions.UnsetDuplicateBindingsOnSet)
					{
						int count = this.Owner.Actions.Count;
						for (int j = 0; j < count; j++)
						{
							this.Owner.Actions[j].HardRemoveBinding(bindingSource);
						}
					}
					if (!bindingListenOptions.AllowDuplicateBindingsPerSet && this.Owner.HasBinding(bindingSource))
					{
						bindingListenOptions.CallOnBindingRejected(this, bindingSource, BindingSourceRejectionType.DuplicateBindingOnActionSet);
						return;
					}
					this.StopListeningForBinding();
					if (bindingListenOptions.ReplaceBinding == null)
					{
						if (bindingListenOptions.MaxAllowedBindingsPerType > 0U)
						{
							while ((long)this.CountBindingsOfType(bindingSource.BindingSourceType) >= (long)((ulong)bindingListenOptions.MaxAllowedBindingsPerType))
							{
								this.RemoveFirstBindingOfType(bindingSource.BindingSourceType);
							}
						}
						else if (bindingListenOptions.MaxAllowedBindings > 0U)
						{
							while ((long)this.regularBindings.Count >= (long)((ulong)bindingListenOptions.MaxAllowedBindings))
							{
								int index = Mathf.Max(0, this.IndexOfFirstInvalidBinding());
								this.regularBindings.RemoveAt(index);
								this.triggerBindingChanged = true;
							}
						}
						this.AddBinding(bindingSource);
					}
					else
					{
						this.ReplaceBinding(bindingListenOptions.ReplaceBinding, bindingSource);
					}
					this.UpdateVisibleBindings();
					bindingListenOptions.CallOnBindingAdded(this, bindingSource);
				}
			}
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000E689C File Offset: 0x000E4A9C
		private void UpdateVisibleBindings()
		{
			this.visibleBindings.Clear();
			int count = this.regularBindings.Count;
			for (int i = 0; i < count; i++)
			{
				BindingSource bindingSource = this.regularBindings[i];
				if (bindingSource.IsValid)
				{
					this.visibleBindings.Add(bindingSource);
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x000E68ED File Offset: 0x000E4AED
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x000E6914 File Offset: 0x000E4B14
		internal InputDevice Device
		{
			get
			{
				if (this.device == null)
				{
					this.device = this.Owner.Device;
					this.UpdateVisibleBindings();
				}
				return this.device;
			}
			set
			{
				if (this.device != value)
				{
					this.device = value;
					this.UpdateVisibleBindings();
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x000E692C File Offset: 0x000E4B2C
		public InputDevice ActiveDevice
		{
			get
			{
				return this.activeDevice ?? InputDevice.Null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000E693D File Offset: 0x000E4B3D
		private bool LastInputTypeIsDevice
		{
			get
			{
				return this.LastInputType == BindingSourceType.DeviceBindingSource || this.LastInputType == BindingSourceType.UnknownDeviceBindingSource;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x00003603 File Offset: 0x00001803
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float LowerDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0000D576 File Offset: 0x0000B776
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x00003603 File Offset: 0x00001803
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		public new float UpperDeadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000E6954 File Offset: 0x000E4B54
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			this.ClearBindings();
			int num = reader.ReadInt32();
			int i = 0;
			while (i < num)
			{
				BindingSourceType bindingSourceType = (BindingSourceType)reader.ReadInt32();
				BindingSource bindingSource;
				switch (bindingSourceType)
				{
				case BindingSourceType.None:
					IL_84:
					i++;
					continue;
				case BindingSourceType.DeviceBindingSource:
					bindingSource = new DeviceBindingSource();
					break;
				case BindingSourceType.KeyBindingSource:
					bindingSource = new KeyBindingSource();
					break;
				case BindingSourceType.MouseBindingSource:
					bindingSource = new MouseBindingSource();
					break;
				case BindingSourceType.UnknownDeviceBindingSource:
					bindingSource = new UnknownDeviceBindingSource();
					break;
				default:
					throw new InControlException("Don't know how to load BindingSourceType: " + bindingSourceType.ToString());
				}
				bindingSource.Load(reader, dataFormatVersion);
				this.AddBinding(bindingSource);
				goto IL_84;
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000E69F0 File Offset: 0x000E4BF0
		internal void Save(BinaryWriter writer)
		{
			this.RemoveOrphanedBindings();
			writer.Write(this.Name);
			int count = this.regularBindings.Count;
			writer.Write(count);
			for (int i = 0; i < count; i++)
			{
				BindingSource bindingSource = this.regularBindings[i];
				writer.Write((int)bindingSource.BindingSourceType);
				bindingSource.Save(writer);
			}
		}

		// Token: 0x04002F7E RID: 12158
		public BindingListenOptions ListenOptions;

		// Token: 0x04002F7F RID: 12159
		public BindingSourceType LastInputType;

		// Token: 0x04002F81 RID: 12161
		public ulong LastInputTypeChangedTick;

		// Token: 0x04002F82 RID: 12162
		public InputDeviceClass LastDeviceClass;

		// Token: 0x04002F83 RID: 12163
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x04002F86 RID: 12166
		private readonly List<BindingSource> defaultBindings;

		// Token: 0x04002F87 RID: 12167
		private readonly List<BindingSource> regularBindings;

		// Token: 0x04002F88 RID: 12168
		private readonly List<BindingSource> visibleBindings;

		// Token: 0x04002F89 RID: 12169
		private readonly ReadOnlyCollection<BindingSource> bindings;

		// Token: 0x04002F8A RID: 12170
		private readonly ReadOnlyCollection<BindingSource> unfilteredBindings;

		// Token: 0x04002F8B RID: 12171
		private readonly BindingSourceListener[] bindingSourceListeners;

		// Token: 0x04002F8C RID: 12172
		private bool triggerBindingEnded;

		// Token: 0x04002F8D RID: 12173
		private bool triggerBindingChanged;

		// Token: 0x04002F8E RID: 12174
		private InputDevice device;

		// Token: 0x04002F8F RID: 12175
		private InputDevice activeDevice;
	}
}
