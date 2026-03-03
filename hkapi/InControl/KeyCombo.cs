using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InControl
{
	// Token: 0x020006C6 RID: 1734
	public struct KeyCombo
	{
		// Token: 0x06002909 RID: 10505 RVA: 0x000E5408 File Offset: 0x000E3608
		public KeyCombo(params Key[] keys)
		{
			this.includeData = 0UL;
			this.includeSize = 0;
			this.excludeData = 0UL;
			this.excludeSize = 0;
			for (int i = 0; i < keys.Length; i++)
			{
				this.AddInclude(keys[i]);
			}
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000E544A File Offset: 0x000E364A
		private void AddIncludeInt(int key)
		{
			if (this.includeSize == 8)
			{
				return;
			}
			this.includeData |= (ulong)((ulong)((long)key & 255L) << this.includeSize * 8);
			this.includeSize++;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x000E5486 File Offset: 0x000E3686
		private int GetIncludeInt(int index)
		{
			return (int)(this.includeData >> index * 8 & 255UL);
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x000E549D File Offset: 0x000E369D
		[Obsolete("Use KeyCombo.AddInclude instead.")]
		public void Add(Key key)
		{
			this.AddInclude(key);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x000E54A6 File Offset: 0x000E36A6
		[Obsolete("Use KeyCombo.GetInclude instead.")]
		public Key Get(int index)
		{
			return this.GetInclude(index);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000E54AF File Offset: 0x000E36AF
		public void AddInclude(Key key)
		{
			this.AddIncludeInt((int)key);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000E54B8 File Offset: 0x000E36B8
		public Key GetInclude(int index)
		{
			if (index < 0 || index >= this.includeSize)
			{
				throw new IndexOutOfRangeException("Index " + index.ToString() + " is out of the range 0.." + this.includeSize.ToString());
			}
			return (Key)this.GetIncludeInt(index);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000E54F5 File Offset: 0x000E36F5
		private void AddExcludeInt(int key)
		{
			if (this.excludeSize == 8)
			{
				return;
			}
			this.excludeData |= (ulong)((ulong)((long)key & 255L) << this.excludeSize * 8);
			this.excludeSize++;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000E5531 File Offset: 0x000E3731
		private int GetExcludeInt(int index)
		{
			return (int)(this.excludeData >> index * 8 & 255UL);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000E5548 File Offset: 0x000E3748
		public void AddExclude(Key key)
		{
			this.AddExcludeInt((int)key);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000E5551 File Offset: 0x000E3751
		public Key GetExclude(int index)
		{
			if (index < 0 || index >= this.excludeSize)
			{
				throw new IndexOutOfRangeException("Index " + index.ToString() + " is out of the range 0.." + this.excludeSize.ToString());
			}
			return (Key)this.GetExcludeInt(index);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000E558E File Offset: 0x000E378E
		public static KeyCombo With(params Key[] keys)
		{
			return new KeyCombo(keys);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000E5598 File Offset: 0x000E3798
		public KeyCombo AndNot(params Key[] keys)
		{
			for (int i = 0; i < keys.Length; i++)
			{
				this.AddExclude(keys[i]);
			}
			return this;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000E55C2 File Offset: 0x000E37C2
		public void Clear()
		{
			this.includeData = 0UL;
			this.includeSize = 0;
			this.excludeData = 0UL;
			this.excludeSize = 0;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x000E55E2 File Offset: 0x000E37E2
		[Obsolete("Use KeyCombo.IncludeCount instead.")]
		public int Count
		{
			get
			{
				return this.includeSize;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000E55E2 File Offset: 0x000E37E2
		public int IncludeCount
		{
			get
			{
				return this.includeSize;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x000E55EA File Offset: 0x000E37EA
		public int ExcludeCount
		{
			get
			{
				return this.excludeSize;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000E55F4 File Offset: 0x000E37F4
		public bool IsPressed
		{
			get
			{
				if (this.includeSize == 0)
				{
					return false;
				}
				IKeyboardProvider keyboardProvider = InputManager.KeyboardProvider;
				bool flag = true;
				for (int i = 0; i < this.includeSize; i++)
				{
					Key include = this.GetInclude(i);
					flag = (flag && keyboardProvider.GetKeyIsPressed(include));
				}
				for (int j = 0; j < this.excludeSize; j++)
				{
					Key exclude = this.GetExclude(j);
					if (keyboardProvider.GetKeyIsPressed(exclude))
					{
						return false;
					}
				}
				return flag;
			}
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000E5668 File Offset: 0x000E3868
		public static KeyCombo Detect(bool modifiersAsKeys)
		{
			KeyCombo result = default(KeyCombo);
			IKeyboardProvider keyboardProvider = InputManager.KeyboardProvider;
			if (modifiersAsKeys)
			{
				for (Key key = Key.LeftShift; key <= Key.RightControl; key++)
				{
					if (keyboardProvider.GetKeyIsPressed(key))
					{
						result.AddInclude(key);
						if (key == Key.LeftControl && keyboardProvider.GetKeyIsPressed(Key.RightAlt))
						{
							result.AddInclude(Key.RightAlt);
						}
						return result;
					}
				}
			}
			else
			{
				for (Key key2 = Key.Shift; key2 <= Key.Control; key2++)
				{
					if (keyboardProvider.GetKeyIsPressed(key2))
					{
						result.AddInclude(key2);
					}
				}
			}
			for (Key key3 = Key.Escape; key3 <= Key.QuestionMark; key3++)
			{
				if (keyboardProvider.GetKeyIsPressed(key3))
				{
					result.AddInclude(key3);
					return result;
				}
			}
			result.Clear();
			return result;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000E5710 File Offset: 0x000E3910
		public override string ToString()
		{
			string text;
			if (!KeyCombo.cachedStrings.TryGetValue(this.includeData, out text))
			{
				KeyCombo.cachedStringBuilder.Clear();
				for (int i = 0; i < this.includeSize; i++)
				{
					if (i != 0)
					{
						KeyCombo.cachedStringBuilder.Append(" ");
					}
					Key include = this.GetInclude(i);
					KeyCombo.cachedStringBuilder.Append(InputManager.KeyboardProvider.GetNameForKey(include));
				}
				text = KeyCombo.cachedStringBuilder.ToString();
				KeyCombo.cachedStrings[this.includeData] = text;
			}
			return text;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000E579B File Offset: 0x000E399B
		public static bool operator ==(KeyCombo a, KeyCombo b)
		{
			return a.includeData == b.includeData && a.excludeData == b.excludeData;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000E57BB File Offset: 0x000E39BB
		public static bool operator !=(KeyCombo a, KeyCombo b)
		{
			return a.includeData != b.includeData || a.excludeData != b.excludeData;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000E57E0 File Offset: 0x000E39E0
		public override bool Equals(object other)
		{
			if (other is KeyCombo)
			{
				KeyCombo keyCombo = (KeyCombo)other;
				return this.includeData == keyCombo.includeData && this.excludeData == keyCombo.excludeData;
			}
			return false;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000E581C File Offset: 0x000E3A1C
		public override int GetHashCode()
		{
			return (17 * 31 + this.includeData.GetHashCode()) * 31 + this.excludeData.GetHashCode();
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000E5840 File Offset: 0x000E3A40
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			if (dataFormatVersion == 1)
			{
				this.includeSize = reader.ReadInt32();
				this.includeData = reader.ReadUInt64();
				return;
			}
			if (dataFormatVersion != 2)
			{
				throw new InControlException("Unknown data format version: " + dataFormatVersion.ToString());
			}
			this.includeSize = reader.ReadInt32();
			this.includeData = reader.ReadUInt64();
			this.excludeSize = reader.ReadInt32();
			this.excludeData = reader.ReadUInt64();
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000E58B7 File Offset: 0x000E3AB7
		internal void Save(BinaryWriter writer)
		{
			writer.Write(this.includeSize);
			writer.Write(this.includeData);
			writer.Write(this.excludeSize);
			writer.Write(this.excludeData);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000E58E9 File Offset: 0x000E3AE9
		// Note: this type is marked as 'beforefieldinit'.
		static KeyCombo()
		{
			KeyCombo.cachedStrings = new Dictionary<ulong, string>();
			KeyCombo.cachedStringBuilder = new StringBuilder(256);
		}

		// Token: 0x04002F5D RID: 12125
		private int includeSize;

		// Token: 0x04002F5E RID: 12126
		private ulong includeData;

		// Token: 0x04002F5F RID: 12127
		private int excludeSize;

		// Token: 0x04002F60 RID: 12128
		private ulong excludeData;

		// Token: 0x04002F61 RID: 12129
		private static readonly Dictionary<ulong, string> cachedStrings;

		// Token: 0x04002F62 RID: 12130
		private static readonly StringBuilder cachedStringBuilder;
	}
}
