using UnityEngine;

namespace UnityEngineEx
{
	public static class ColorEx
	{
		/// <summary>
		/// Returns new Color with the Alpha value set.
		/// </summary>
		/// <param name="color"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static Color Alpha(this Color color, float a)
		{
			return new Color(color.r, color.g, color.b, a);
		}
	}
}

