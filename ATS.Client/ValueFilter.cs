using System;

namespace ATS.Client
{
	internal static class ValueFilter
	{
		public static string ReplaceNull( string value )
		{
			return value ?? string.Empty;
		}

	}
}
