using System;
using System.Runtime.Serialization;

namespace ATS.Engine.Net
{
	[System.Serializable]
	public class InvalidRequestException : Exception
	{
		public InvalidRequestException() 
			: this( string.Empty ) 
		{
		}

		public InvalidRequestException( string message )
			: base( $"Bad request {message}" )
		{
		}

		protected InvalidRequestException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{
		}
	}
}
