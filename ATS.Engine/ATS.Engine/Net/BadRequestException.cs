using System;
using System.Runtime.Serialization;

namespace ATS.Engine.Net
{
	[System.Serializable]
	public class BadRequestException : Exception
	{
		public BadRequestException() 
			: this( string.Empty ) 
		{
		}

		public BadRequestException( string message )
			: base( $"Bad request {message}" )
		{
		}

		protected BadRequestException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{
		}
	}
}
