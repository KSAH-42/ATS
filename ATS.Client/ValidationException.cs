using System;
using System.Runtime.Serialization;

namespace ATS.Client
{
	[System.Serializable]
	public class ValidationException : Exception
	{
		public ValidationException() 
			: this( string.Empty ) 
		{
		}

		public ValidationException( string message )
			: base( $"Bad request {message}" )
		{
		}

		protected ValidationException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{
		}
	}
}
