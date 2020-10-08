using System;
using System.Runtime.Serialization;

namespace ATS.Engine.Net
{
	[System.Serializable]
	public class PingException : Exception
	{
		public PingException() 
			: this( string.Empty ) 
		{
		}

		public PingException( string message )
			: base( $"Ping failure {message}" )
		{
		}

		protected PingException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{
		}
	}
}
