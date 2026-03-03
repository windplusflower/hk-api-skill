using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Modding.Utils
{
	/// <summary>
	/// Class containing extensions used by the Modding API for interacting with assemblies.
	/// </summary>
	// Token: 0x02000DA3 RID: 3491
	public static class AssemblyExtensions
	{
		/// <summary>
		/// Returns a collection containing the types in the provided assembly.
		/// If some types cannot be loaded (e.g. they derive from a type in an uninstalled mod),
		/// then only the successfully loaded types are returned.
		/// </summary>
		// Token: 0x0600487F RID: 18559 RVA: 0x0018904C File Offset: 0x0018724C
		public static IEnumerable<Type> GetTypesSafely(this Assembly asm)
		{
			IEnumerable<Type> result;
			try
			{
				result = asm.GetTypes();
			}
			catch (ReflectionTypeLoadException ex)
			{
				result = from x in ex.Types
				where x != null
				select x;
			}
			return result;
		}

		/// <summary>
		/// Load an image from the assembly's embedded resources, and return a Sprite.
		/// </summary>
		/// <param name="asm">The assembly to load from.</param>
		/// <param name="path">The path to the image.</param>
		/// <param name="pixelsPerUnit">The pixels per unit. Changing this value will scale the size of the sprite accordingly.</param>
		/// <returns>A Sprite object.</returns>
		// Token: 0x06004880 RID: 18560 RVA: 0x001890A0 File Offset: 0x001872A0
		public static Sprite LoadEmbeddedSprite(this Assembly asm, string path, float pixelsPerUnit = 64f)
		{
			Sprite result;
			using (Stream manifestResourceStream = asm.GetManifestResourceStream(path))
			{
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, array.Length);
				Texture2D texture2D = new Texture2D(2, 2);
				texture2D.LoadImage(array, true);
				result = Sprite.Create(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), Vector2.one * 0.5f, pixelsPerUnit);
			}
			return result;
		}
	}
}
