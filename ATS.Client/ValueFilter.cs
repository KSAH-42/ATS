using System;

namespace ATS.Client
{
	internal static class ValueFilter
	{
		public static string ReplaceNull( string value )
		{
			return value ?? string.Empty;
		}

		public static string Truncate( string value , int maxCaracters )
		{
			if ( maxCaracters <= 0 )
			{
				throw new ArgumentException( value );
			}

			if ( string.IsNullOrEmpty( value ) )
			{
				return string.Empty;
			}

			return ( value.Length <= maxCaracters ) ? value : value.Substring( 0 , maxCaracters );
		}
	}
}
