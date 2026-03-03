using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using MonoMod.Utils;

namespace Modding
{
	/// <summary>
	///     A class to aid in reflection while caching it.
	/// </summary>
	// Token: 0x02000D9A RID: 3482
	public static class ReflectionHelper
	{
		/// <summary>
		///     Caches all fields on a type to frontload cost of reflection
		/// </summary>
		/// <typeparam name="T">The type to cache</typeparam>
		// Token: 0x06004850 RID: 18512 RVA: 0x00187EDC File Offset: 0x001860DC
		private static void CacheFields<T>()
		{
			Type t = typeof(T);
			ConcurrentDictionary<string, FieldInfo> tFields;
			if (!ReflectionHelper.Fields.TryGetValue(t, out tFields))
			{
				tFields = new ConcurrentDictionary<string, FieldInfo>();
			}
			MethodInfo getInstanceFieldGetter = typeof(ReflectionHelper).GetMethod("GetInstanceFieldGetter", BindingFlags.Static | BindingFlags.NonPublic);
			MethodInfo getStaticFieldGetter = typeof(ReflectionHelper).GetMethod("GetStaticFieldGetter", BindingFlags.Static | BindingFlags.NonPublic);
			MethodInfo getInstanceFieldSetter = typeof(ReflectionHelper).GetMethod("GetInstanceFieldSetter", BindingFlags.Static | BindingFlags.NonPublic);
			MethodInfo getStaticFieldSetter = typeof(ReflectionHelper).GetMethod("GetStaticFieldSetter", BindingFlags.Static | BindingFlags.NonPublic);
			Parallel.ForEach<FieldInfo>(t.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), delegate(FieldInfo field)
			{
				tFields[field.Name] = field;
				if (field.IsLiteral)
				{
					return;
				}
				object[] parameters = new object[]
				{
					field
				};
				if (field.IsStatic)
				{
					MethodInfo getStaticFieldGetter = getStaticFieldGetter;
					if (getStaticFieldGetter != null)
					{
						getStaticFieldGetter.MakeGenericMethod(new Type[]
						{
							field.FieldType
						}).Invoke(null, parameters);
					}
				}
				else
				{
					MethodInfo getInstanceFieldGetter = getInstanceFieldGetter;
					if (getInstanceFieldGetter != null)
					{
						getInstanceFieldGetter.MakeGenericMethod(new Type[]
						{
							t,
							field.FieldType
						}).Invoke(null, parameters);
					}
				}
				if (field.IsInitOnly)
				{
					return;
				}
				if (field.IsStatic)
				{
					MethodInfo getStaticFieldSetter = getStaticFieldSetter;
					if (getStaticFieldSetter == null)
					{
						return;
					}
					getStaticFieldSetter.MakeGenericMethod(new Type[]
					{
						field.FieldType
					}).Invoke(null, parameters);
					return;
				}
				else
				{
					MethodInfo getInstanceFieldSetter = getInstanceFieldSetter;
					if (getInstanceFieldSetter == null)
					{
						return;
					}
					getInstanceFieldSetter.MakeGenericMethod(new Type[]
					{
						t,
						field.FieldType
					}).Invoke(null, parameters);
					return;
				}
			});
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x00187FB4 File Offset: 0x001861B4
		internal static void PreloadCommonTypes()
		{
			if (ReflectionHelper._preloaded)
			{
				return;
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Action[] array = new Action[5];
			int num = 0;
			Action action;
			if ((action = ReflectionHelper.<>O.<0>__CacheFields) == null)
			{
				action = (ReflectionHelper.<>O.<0>__CacheFields = new Action(ReflectionHelper.CacheFields<PlayerData>));
			}
			array[num] = action;
			int num2 = 1;
			Action action2;
			if ((action2 = ReflectionHelper.<>O.<1>__CacheFields) == null)
			{
				action2 = (ReflectionHelper.<>O.<1>__CacheFields = new Action(ReflectionHelper.CacheFields<HeroController>));
			}
			array[num2] = action2;
			int num3 = 2;
			Action action3;
			if ((action3 = ReflectionHelper.<>O.<2>__CacheFields) == null)
			{
				action3 = (ReflectionHelper.<>O.<2>__CacheFields = new Action(ReflectionHelper.CacheFields<HeroControllerStates>));
			}
			array[num3] = action3;
			int num4 = 3;
			Action action4;
			if ((action4 = ReflectionHelper.<>O.<3>__CacheFields) == null)
			{
				action4 = (ReflectionHelper.<>O.<3>__CacheFields = new Action(ReflectionHelper.CacheFields<GameManager>));
			}
			array[num4] = action4;
			int num5 = 4;
			Action action5;
			if ((action5 = ReflectionHelper.<>O.<4>__CacheFields) == null)
			{
				action5 = (ReflectionHelper.<>O.<4>__CacheFields = new Action(ReflectionHelper.CacheFields<UIManager>));
			}
			array[num5] = action5;
			Parallel.Invoke(array);
			stopwatch.Stop();
			Logger.APILogger.Log(string.Format("Preloaded reflection in {0}ms", stopwatch.ElapsedMilliseconds));
			ReflectionHelper._preloaded = true;
		}

		/// <summary>
		///     Gets a field on a type
		/// </summary>
		/// <param name="t">Type</param>
		/// <param name="field">Field name</param>
		/// <param name="instance"></param>
		/// <returns>FieldInfo for field or null if field does not exist.</returns>
		// Token: 0x06004852 RID: 18514 RVA: 0x001880A4 File Offset: 0x001862A4
		[PublicAPI]
		public static FieldInfo GetFieldInfo(Type t, string field, bool instance = true)
		{
			ConcurrentDictionary<string, FieldInfo> concurrentDictionary;
			if (!ReflectionHelper.Fields.TryGetValue(t, out concurrentDictionary))
			{
				concurrentDictionary = (ReflectionHelper.Fields[t] = new ConcurrentDictionary<string, FieldInfo>());
			}
			FieldInfo field2;
			if (concurrentDictionary.TryGetValue(field, out field2))
			{
				return field2;
			}
			field2 = t.GetField(field, BindingFlags.Public | BindingFlags.NonPublic | (instance ? BindingFlags.Instance : BindingFlags.Static));
			if (field2 != null)
			{
				concurrentDictionary.TryAdd(field, field2);
			}
			return field2;
		}

		/// <summary>
		///     Gets delegate getting field on type
		/// </summary>
		/// <param name="fi">FieldInfo for field.</param>
		/// <returns>Function which gets value of field</returns>
		// Token: 0x06004853 RID: 18515 RVA: 0x00188104 File Offset: 0x00186304
		private static Delegate GetInstanceFieldGetter<TType, TField>(FieldInfo fi)
		{
			Delegate @delegate;
			if (ReflectionHelper.FieldGetters.TryGetValue(fi, out @delegate))
			{
				return @delegate;
			}
			if (fi.IsLiteral)
			{
				throw new ArgumentException("Field cannot be const", "fi");
			}
			string str = "FieldAccess";
			Type declaringType = fi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + fi.Name, typeof(TField), new Type[]
			{
				typeof(TType)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldfld, fi);
			if (fi.FieldType.IsValueType && typeof(TField) == typeof(object))
			{
				ilgenerator.Emit(OpCodes.Box, fi.FieldType);
			}
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Func<TType, TField>));
			ReflectionHelper.FieldGetters[fi] = @delegate;
			return @delegate;
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x00188204 File Offset: 0x00186404
		private static Delegate GetStaticFieldGetter<TField>(FieldInfo fi)
		{
			Delegate @delegate;
			if (ReflectionHelper.FieldGetters.TryGetValue(fi, out @delegate))
			{
				return @delegate;
			}
			if (fi.IsLiteral)
			{
				throw new ArgumentException("Field cannot be const", "fi");
			}
			string str = "FieldAccess";
			Type declaringType = fi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + fi.Name, typeof(TField), Type.EmptyTypes);
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldsfld, fi);
			if (fi.FieldType.IsValueType && typeof(TField) == typeof(object))
			{
				ilgenerator.Emit(OpCodes.Box, fi.FieldType);
			}
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Func<TField>));
			ReflectionHelper.FieldGetters[fi] = @delegate;
			return @delegate;
		}

		/// <summary>
		///     Gets delegate setting field on type
		/// </summary>
		/// <param name="fi">FieldInfo for field.</param>
		/// <returns>Function which sets field passed as FieldInfo</returns>
		// Token: 0x06004855 RID: 18517 RVA: 0x001882EC File Offset: 0x001864EC
		private static Delegate GetInstanceFieldSetter<TType, TField>(FieldInfo fi)
		{
			Delegate @delegate;
			if (ReflectionHelper.FieldSetters.TryGetValue(fi, out @delegate))
			{
				return @delegate;
			}
			if (fi.IsLiteral || fi.IsInitOnly)
			{
				throw new ArgumentException("Field cannot be readonly or const", "fi");
			}
			string str = "FieldSet";
			Type declaringType = fi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + fi.Name, typeof(void), new Type[]
			{
				typeof(TType),
				typeof(TField)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			if (fi.FieldType.IsValueType && typeof(TField) == typeof(object))
			{
				ilgenerator.Emit(OpCodes.Unbox_Any, fi.FieldType);
			}
			ilgenerator.Emit(OpCodes.Stfld, fi);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Action<TType, TField>));
			ReflectionHelper.FieldSetters[fi] = @delegate;
			return @delegate;
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x0018840C File Offset: 0x0018660C
		private static Delegate GetStaticFieldSetter<TField>(FieldInfo fi)
		{
			Delegate @delegate;
			if (ReflectionHelper.FieldSetters.TryGetValue(fi, out @delegate))
			{
				return @delegate;
			}
			if (fi.IsLiteral || fi.IsInitOnly)
			{
				throw new ArgumentException("Field cannot be readonly or const", "fi");
			}
			string str = "FieldSet";
			Type declaringType = fi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + fi.Name, typeof(void), new Type[]
			{
				typeof(TField)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			if (fi.FieldType.IsValueType && typeof(TField) == typeof(object))
			{
				ilgenerator.Emit(OpCodes.Unbox_Any, fi.FieldType);
			}
			ilgenerator.Emit(OpCodes.Stsfld, fi);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Action<TField>));
			ReflectionHelper.FieldSetters[fi] = @delegate;
			return @delegate;
		}

		/// <summary>
		///     Get a field on an object using a string. Cast to TCast before returning and if field doesn't exist return default.
		/// </summary>
		/// <param name="obj">Object/Object of type which the field is on</param>
		/// <param name="name">Name of the field</param>
		/// <param name="default">Default return</param>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		/// <typeparam name="TCast">Type of return.</typeparam>
		/// <returns>The value of a field on an object/type</returns>
		// Token: 0x06004857 RID: 18519 RVA: 0x00188514 File Offset: 0x00186714
		[PublicAPI]
		public static TCast GetField<TObject, TField, TCast>(TObject obj, string name, TCast @default = default(TCast))
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TObject), name, true);
			if (!(fieldInfo == null))
			{
				return (TCast)((object)((Func<TObject, TField>)ReflectionHelper.GetInstanceFieldGetter<TObject, TField>(fieldInfo))(obj));
			}
			return @default;
		}

		/// <summary>
		///     Get a field on an object using a string.
		/// </summary>
		/// <param name="obj">Object/Object of type which the field is on</param>
		/// <param name="name">Name of the field</param>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		/// <returns>The value of a field on an object/type</returns>
		// Token: 0x06004858 RID: 18520 RVA: 0x00188559 File Offset: 0x00186759
		[PublicAPI]
		public static TField GetField<TObject, TField>(TObject obj, string name)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TObject), name, true);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			return ((Func<TObject, TField>)ReflectionHelper.GetInstanceFieldGetter<TObject, TField>(fieldInfo))(obj);
		}

		/// <summary>
		///     Get a static field on an type using a string.
		/// </summary>
		/// <param name="name">Name of the field</param>
		/// <typeparam name="TType">Type which static field resides upon</typeparam>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <returns>The value of a field on an object/type</returns>
		// Token: 0x06004859 RID: 18521 RVA: 0x00188596 File Offset: 0x00186796
		[PublicAPI]
		public static TField GetField<TType, TField>(string name)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TType), name, false);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			return ((Func<TField>)ReflectionHelper.GetStaticFieldGetter<TField>(fieldInfo))();
		}

		/// <summary>
		///     Get a static field on an type using a string. (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static field resides upon</param>
		/// <param name="name">Name of the field</param>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <returns>The value of a field on an object/type</returns>
		// Token: 0x0600485A RID: 18522 RVA: 0x001885D2 File Offset: 0x001867D2
		[PublicAPI]
		public static TField GetField<TField>(Type type, string name)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(type, name, false);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			return ((Func<TField>)ReflectionHelper.GetStaticFieldGetter<TField>(fieldInfo))();
		}

		/// <summary>
		///     Set a field on an object using a string.
		/// </summary>
		/// <param name="obj">Object/Object of type which the field is on</param>
		/// <param name="name">Name of the field</param>
		/// <param name="value">Value to set the field to</param>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		// Token: 0x0600485B RID: 18523 RVA: 0x00188608 File Offset: 0x00186808
		[PublicAPI]
		public static void SetFieldSafe<TObject, TField>(TObject obj, string name, TField value)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TObject), name, true);
			if (fieldInfo == null)
			{
				return;
			}
			((Action<TObject, TField>)ReflectionHelper.GetInstanceFieldSetter<TObject, TField>(fieldInfo))(obj, value);
		}

		/// <summary>
		///     Set a field on an object using a string.
		/// </summary>
		/// <param name="obj">Object/Object of type which the field is on</param>
		/// <param name="name">Name of the field</param>
		/// <param name="value">Value to set the field to</param>
		/// <typeparam name="TField">Type of field</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		// Token: 0x0600485C RID: 18524 RVA: 0x00188643 File Offset: 0x00186843
		[PublicAPI]
		public static void SetField<TObject, TField>(TObject obj, string name, TField value)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TObject), name, true);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			((Action<TObject, TField>)ReflectionHelper.GetInstanceFieldSetter<TObject, TField>(fieldInfo))(obj, value);
		}

		/// <summary>
		///     Set a static field on an type using a string.
		/// </summary>
		/// <param name="name">Name of the field</param>
		/// <param name="value">Value to set the field to</param>
		/// <typeparam name="TType">Type which static field resides upon</typeparam>
		/// <typeparam name="TField">Type of field</typeparam>
		// Token: 0x0600485D RID: 18525 RVA: 0x00188681 File Offset: 0x00186881
		[PublicAPI]
		public static void SetField<TType, TField>(string name, TField value)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(typeof(TType), name, false);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			((Action<TField>)ReflectionHelper.GetInstanceFieldSetter<TType, TField>(fieldInfo))(value);
		}

		/// <summary>
		///     Set a static field on an type using a string. (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static field resides upon</param>
		/// <param name="name">Name of the field</param>
		/// <param name="value">Value to set the field to</param>
		/// <typeparam name="TField">Type of field</typeparam>
		// Token: 0x0600485E RID: 18526 RVA: 0x001886BE File Offset: 0x001868BE
		[PublicAPI]
		public static void SetField<TField>(Type type, string name, TField value)
		{
			FieldInfo fieldInfo = ReflectionHelper.GetFieldInfo(type, name, false);
			if (fieldInfo == null)
			{
				throw new MissingFieldException("Field " + name + " does not exist!");
			}
			((Action<TField>)ReflectionHelper.GetStaticFieldSetter<TField>(fieldInfo))(value);
		}

		/// <summary>
		///     Gets a property on a type
		/// </summary>
		/// <param name="t">Type</param>
		/// <param name="property">Property name</param>
		/// <param name="instance"></param>
		/// <returns>PropertyInfo for property or null if property does not exist.</returns>
		// Token: 0x0600485F RID: 18527 RVA: 0x001886F4 File Offset: 0x001868F4
		[PublicAPI]
		public static PropertyInfo GetPropertyInfo(Type t, string property, bool instance = true)
		{
			ConcurrentDictionary<string, PropertyInfo> concurrentDictionary;
			if (!ReflectionHelper.Properties.TryGetValue(t, out concurrentDictionary))
			{
				concurrentDictionary = (ReflectionHelper.Properties[t] = new ConcurrentDictionary<string, PropertyInfo>());
			}
			PropertyInfo property2;
			if (concurrentDictionary.TryGetValue(property, out property2))
			{
				return property2;
			}
			property2 = t.GetProperty(property, BindingFlags.Public | BindingFlags.NonPublic | (instance ? BindingFlags.Instance : BindingFlags.Static));
			if (property2 != null)
			{
				concurrentDictionary.TryAdd(property, property2);
			}
			return property2;
		}

		/// <summary>
		///     Get a property on an object using a string.
		/// </summary>
		/// <param name="obj">Object/Object of type which the property is on</param>
		/// <param name="name">Name of the property</param>
		/// <typeparam name="TProperty">Type of property</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		/// <returns>The value of a property on an object/type</returns>
		// Token: 0x06004860 RID: 18528 RVA: 0x00188754 File Offset: 0x00186954
		[PublicAPI]
		public static TProperty GetProperty<TObject, TProperty>(TObject obj, string name)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TObject), name, true);
			if (propertyInfo == null)
			{
				throw new MissingFieldException("Property " + name + " does not exist!");
			}
			return ((Func<TObject, TProperty>)ReflectionHelper.GetInstancePropertyGetter<TObject, TProperty>(propertyInfo))(obj);
		}

		/// <summary>
		///     Get a static property on an type using a string.
		/// </summary>
		/// <param name="name">Name of the property</param>
		/// <typeparam name="TType">Type which static property resides upon</typeparam>
		/// <typeparam name="TProperty">Type of property</typeparam>
		/// <returns>The value of a property on an object/type</returns>
		// Token: 0x06004861 RID: 18529 RVA: 0x00188794 File Offset: 0x00186994
		[PublicAPI]
		public static TProperty GetProperty<TType, TProperty>(string name)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TType), name, false);
			if (!(propertyInfo == null))
			{
				return ((Func<TProperty>)ReflectionHelper.GetStaticPropertyGetter<TProperty>(propertyInfo))();
			}
			return default(TProperty);
		}

		/// <summary>
		///     Get a static property on an type using a string. (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static property resides upon</param>
		/// <param name="name">Name of the property</param>
		/// <typeparam name="TProperty">Type of property</typeparam>
		/// <returns>The value of a property on an object/type</returns>
		// Token: 0x06004862 RID: 18530 RVA: 0x001887D8 File Offset: 0x001869D8
		[PublicAPI]
		public static TProperty GetProperty<TProperty>(Type type, string name)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(type, name, false);
			if (!(propertyInfo == null))
			{
				return ((Func<TProperty>)ReflectionHelper.GetStaticPropertyGetter<TProperty>(propertyInfo))();
			}
			return default(TProperty);
		}

		/// <summary>
		///     Set a property on an object using a string.
		/// </summary>
		/// <param name="obj">Object/Object of type which the property is on</param>
		/// <param name="name">Name of the property</param>
		/// <param name="value">Value to set the property to</param>
		/// <typeparam name="TProperty">Type of property</typeparam>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		// Token: 0x06004863 RID: 18531 RVA: 0x00188811 File Offset: 0x00186A11
		[PublicAPI]
		public static void SetProperty<TObject, TProperty>(TObject obj, string name, TProperty value)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TObject), name, true);
			if (propertyInfo == null)
			{
				throw new MissingFieldException("Property " + name + " does not exist!");
			}
			((Action<TObject, TProperty>)ReflectionHelper.GetInstancePropertySetter<TObject, TProperty>(propertyInfo))(obj, value);
		}

		/// <summary>
		///     Set a static property on an type using a string.
		/// </summary>
		/// <param name="name">Name of the property</param>
		/// <param name="value">Value to set the property to</param>
		/// <typeparam name="TType">Type which static property resides upon</typeparam>
		/// <typeparam name="TProperty">Type of property</typeparam>
		// Token: 0x06004864 RID: 18532 RVA: 0x0018884F File Offset: 0x00186A4F
		[PublicAPI]
		public static void SetProperty<TType, TProperty>(string name, TProperty value)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(typeof(TType), name, false);
			if (propertyInfo == null)
			{
				throw new MissingFieldException("Property " + name + " does not exist!");
			}
			((Action<TProperty>)ReflectionHelper.GetStaticPropertySetter<TProperty>(propertyInfo))(value);
		}

		/// <summary>
		///     Set a static property on an type using a string. (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static property resides upon</param>
		/// <param name="name">Name of the property</param>
		/// <param name="value">Value to set the property to</param>
		/// <typeparam name="TProperty">Type of property</typeparam>
		// Token: 0x06004865 RID: 18533 RVA: 0x0018888C File Offset: 0x00186A8C
		[PublicAPI]
		public static void SetProperty<TProperty>(Type type, string name, TProperty value)
		{
			PropertyInfo propertyInfo = ReflectionHelper.GetPropertyInfo(type, name, false);
			if (propertyInfo == null)
			{
				throw new MissingFieldException("Property " + name + " does not exist!");
			}
			((Action<TProperty>)ReflectionHelper.GetStaticPropertySetter<TProperty>(propertyInfo))(value);
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x001888C0 File Offset: 0x00186AC0
		private static Delegate GetInstancePropertyGetter<TType, TProperty>(PropertyInfo pi)
		{
			Delegate @delegate;
			if (ReflectionHelper.PropertyGetters.TryGetValue(pi, out @delegate))
			{
				return @delegate;
			}
			if (!pi.CanRead)
			{
				throw new ArgumentException("Property doesn't have Get method", "pi");
			}
			string str = "PropertyAccess";
			Type declaringType = pi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + pi.Name, typeof(TProperty), new Type[]
			{
				typeof(TType)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, pi.GetMethod);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Func<TType, TProperty>));
			ReflectionHelper.PropertyGetters[pi] = @delegate;
			return @delegate;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00188988 File Offset: 0x00186B88
		private static Delegate GetStaticPropertyGetter<TProperty>(PropertyInfo pi)
		{
			Delegate @delegate;
			if (ReflectionHelper.PropertyGetters.TryGetValue(pi, out @delegate))
			{
				return @delegate;
			}
			if (!pi.CanRead)
			{
				throw new ArgumentException("Property doesn't have Get method", "pi");
			}
			string str = "PropertyAccess";
			Type declaringType = pi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + pi.Name, typeof(TProperty), Type.EmptyTypes);
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Call, pi.GetMethod);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Func<TProperty>));
			ReflectionHelper.PropertyGetters[pi] = @delegate;
			return @delegate;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00188A38 File Offset: 0x00186C38
		private static Delegate GetInstancePropertySetter<TType, TProperty>(PropertyInfo pi)
		{
			Delegate @delegate;
			if (ReflectionHelper.PropertySetters.TryGetValue(pi, out @delegate))
			{
				return @delegate;
			}
			if (!pi.CanWrite)
			{
				throw new ArgumentException("Property doesn't have a Set method", "pi");
			}
			string str = "PropertySet";
			Type declaringType = pi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + pi.Name, typeof(void), new Type[]
			{
				typeof(TType),
				typeof(TProperty)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			ilgenerator.Emit(OpCodes.Call, pi.SetMethod);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Action<TType, TProperty>));
			ReflectionHelper.PropertySetters[pi] = @delegate;
			return @delegate;
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00188B18 File Offset: 0x00186D18
		private static Delegate GetStaticPropertySetter<TProperty>(PropertyInfo pi)
		{
			Delegate @delegate;
			if (ReflectionHelper.PropertySetters.TryGetValue(pi, out @delegate))
			{
				return @delegate;
			}
			if (!pi.CanWrite)
			{
				throw new ArgumentException("Property doesn't have a Set method", "pi");
			}
			string str = "PropertySet";
			Type declaringType = pi.DeclaringType;
			DynamicMethodDefinition dynamicMethodDefinition = new DynamicMethodDefinition(str + ((declaringType != null) ? declaringType.Name : null) + pi.Name, typeof(void), new Type[]
			{
				typeof(TProperty)
			});
			ILGenerator ilgenerator = dynamicMethodDefinition.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, pi.SetMethod);
			ilgenerator.Emit(OpCodes.Ret);
			@delegate = dynamicMethodDefinition.Generate().CreateDelegate(typeof(Action<TProperty>));
			ReflectionHelper.PropertySetters[pi] = @delegate;
			return @delegate;
		}

		/// <summary>
		///     Gets a method on a type 
		/// </summary>
		/// <param name="t">Type</param>
		/// <param name="method">Method name</param>
		/// <param name="instance"></param>
		/// <returns>MethodInfo for method or null if method does not exist.</returns>
		// Token: 0x0600486A RID: 18538 RVA: 0x00188BE0 File Offset: 0x00186DE0
		[PublicAPI]
		public static MethodInfo GetMethodInfo(Type t, string method, bool instance = true)
		{
			ConcurrentDictionary<string, MethodInfo> concurrentDictionary;
			if (!ReflectionHelper.Methods.TryGetValue(t, out concurrentDictionary))
			{
				concurrentDictionary = (ReflectionHelper.Methods[t] = new ConcurrentDictionary<string, MethodInfo>());
			}
			MethodInfo method2;
			if (concurrentDictionary.TryGetValue(method, out method2))
			{
				return method2;
			}
			method2 = t.GetMethod(method, BindingFlags.Public | BindingFlags.NonPublic | (instance ? BindingFlags.Instance : BindingFlags.Static));
			if (method2 != null)
			{
				concurrentDictionary.TryAdd(method, method2);
			}
			return method2;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00188C40 File Offset: 0x00186E40
		private static FastReflectionDelegate GetFastReflectionDelegate(MethodInfo mi)
		{
			FastReflectionDelegate fastDelegate;
			if (ReflectionHelper.MethodsDelegates.TryGetValue(mi, out fastDelegate))
			{
				return fastDelegate;
			}
			fastDelegate = mi.GetFastDelegate(true);
			ReflectionHelper.MethodsDelegates[mi] = fastDelegate;
			return fastDelegate;
		}

		/// <summary>
		///     Call an instance method with a return type
		/// </summary>
		/// <param name="obj">Object of type which the method is on</param>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		/// <typeparam name="TReturn">The return type of the method</typeparam>
		/// <returns>The specified return type</returns>
		// Token: 0x0600486C RID: 18540 RVA: 0x00188C74 File Offset: 0x00186E74
		[PublicAPI]
		public static TReturn CallMethod<TObject, TReturn>(TObject obj, string name, params object[] param)
		{
			MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TObject), name, true);
			if (methodInfo == null)
			{
				throw new MissingFieldException("Method " + name + " does not exist!");
			}
			return (TReturn)((object)ReflectionHelper.GetFastReflectionDelegate(methodInfo)(obj, (param.Length == 0) ? null : param));
		}

		/// <summary>
		///     Call an instance method without a return type
		/// </summary>
		/// <param name="obj">Object of type which the method is on</param>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <typeparam name="TObject">Type of object being passed in</typeparam>
		/// <returns>None</returns>
		// Token: 0x0600486D RID: 18541 RVA: 0x00188CCC File Offset: 0x00186ECC
		[PublicAPI]
		public static void CallMethod<TObject>(TObject obj, string name, params object[] param)
		{
			MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(typeof(TObject), name, true);
			if (methodInfo == null)
			{
				throw new MissingFieldException("Method " + name + " does not exist!");
			}
			ReflectionHelper.GetFastReflectionDelegate(methodInfo)(obj, (param.Length == 0) ? null : param);
		}

		/// <summary>
		///     Call a static method with a return type
		/// </summary>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <typeparam name="TType">The Type which static method resides upon</typeparam>
		/// <typeparam name="TReturn">The return type of the method</typeparam>
		/// <returns>The specified return type</returns>
		// Token: 0x0600486E RID: 18542 RVA: 0x00188D1D File Offset: 0x00186F1D
		[PublicAPI]
		public static TReturn CallMethod<TType, TReturn>(string name, params object[] param)
		{
			return ReflectionHelper.CallMethod<TReturn>(typeof(TType), name, param);
		}

		/// <summary>
		///     Call a static method without a return type
		/// </summary>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <typeparam name="TType">The Type which static method resides upon</typeparam>
		/// <returns>None</returns>
		// Token: 0x0600486F RID: 18543 RVA: 0x00188D30 File Offset: 0x00186F30
		[PublicAPI]
		public static void CallMethod<TType>(string name, params object[] param)
		{
			ReflectionHelper.CallMethod(typeof(TType), name, param);
		}

		/// <summary>
		///     Call a static method with a return type (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static method resides upon</param>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <typeparam name="TReturn">The return type of the method</typeparam>
		/// <returns>The specified return type</returns>
		// Token: 0x06004870 RID: 18544 RVA: 0x00188D43 File Offset: 0x00186F43
		[PublicAPI]
		public static TReturn CallMethod<TReturn>(Type type, string name, params object[] param)
		{
			MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(type, name, false);
			if (methodInfo == null)
			{
				throw new MissingFieldException("Method " + name + " does not exist!");
			}
			return (TReturn)((object)ReflectionHelper.GetFastReflectionDelegate(methodInfo)(null, (param.Length == 0) ? null : param));
		}

		/// <summary>
		///     Call a static method without a return type (for static classes)
		/// </summary>
		/// <param name="type">Static Type which static method resides upon</param>
		/// <param name="name">Name of the method</param>
		/// <param name="param">The paramters that need to be passed into the method.</param>
		/// <returns>None</returns>
		// Token: 0x06004871 RID: 18545 RVA: 0x00188D7F File Offset: 0x00186F7F
		[PublicAPI]
		public static void CallMethod(Type type, string name, params object[] param)
		{
			MethodInfo methodInfo = ReflectionHelper.GetMethodInfo(type, name, false);
			if (methodInfo == null)
			{
				throw new MissingFieldException("Method " + name + " does not exist!");
			}
			ReflectionHelper.GetFastReflectionDelegate(methodInfo)(null, (param.Length == 0) ? null : param);
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x00188DB8 File Offset: 0x00186FB8
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionHelper()
		{
			ReflectionHelper.Fields = new ConcurrentDictionary<Type, ConcurrentDictionary<string, FieldInfo>>();
			ReflectionHelper.FieldGetters = new ConcurrentDictionary<FieldInfo, Delegate>();
			ReflectionHelper.FieldSetters = new ConcurrentDictionary<FieldInfo, Delegate>();
			ReflectionHelper.Properties = new ConcurrentDictionary<Type, ConcurrentDictionary<string, PropertyInfo>>();
			ReflectionHelper.PropertyGetters = new ConcurrentDictionary<PropertyInfo, Delegate>();
			ReflectionHelper.PropertySetters = new ConcurrentDictionary<PropertyInfo, Delegate>();
			ReflectionHelper.Methods = new ConcurrentDictionary<Type, ConcurrentDictionary<string, MethodInfo>>();
			ReflectionHelper.MethodsDelegates = new ConcurrentDictionary<MethodInfo, FastReflectionDelegate>();
		}

		// Token: 0x04004C7C RID: 19580
		private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, FieldInfo>> Fields;

		// Token: 0x04004C7D RID: 19581
		private static readonly ConcurrentDictionary<FieldInfo, Delegate> FieldGetters;

		// Token: 0x04004C7E RID: 19582
		private static readonly ConcurrentDictionary<FieldInfo, Delegate> FieldSetters;

		// Token: 0x04004C7F RID: 19583
		private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, PropertyInfo>> Properties;

		// Token: 0x04004C80 RID: 19584
		private static readonly ConcurrentDictionary<PropertyInfo, Delegate> PropertyGetters;

		// Token: 0x04004C81 RID: 19585
		private static readonly ConcurrentDictionary<PropertyInfo, Delegate> PropertySetters;

		// Token: 0x04004C82 RID: 19586
		private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<string, MethodInfo>> Methods;

		// Token: 0x04004C83 RID: 19587
		private static readonly ConcurrentDictionary<MethodInfo, FastReflectionDelegate> MethodsDelegates;

		// Token: 0x04004C84 RID: 19588
		private static bool _preloaded;

		// Token: 0x02000D9B RID: 3483
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04004C85 RID: 19589
			public static Action <0>__CacheFields;

			// Token: 0x04004C86 RID: 19590
			public static Action <1>__CacheFields;

			// Token: 0x04004C87 RID: 19591
			public static Action <2>__CacheFields;

			// Token: 0x04004C88 RID: 19592
			public static Action <3>__CacheFields;

			// Token: 0x04004C89 RID: 19593
			public static Action <4>__CacheFields;
		}
	}
}
