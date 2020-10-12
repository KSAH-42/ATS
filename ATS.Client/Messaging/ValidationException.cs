using System;
using System.Runtime.Serialization;

namespace ATS.Client.Messaging
{
	[Serializable]
	public class ValidationException : Exception
	{
		public ValidationException()
			: this( "Validation failed" )
		{
		}

		public ValidationException( string message ) 
			: base( message ) 
		{
		}
		
		public ValidationException( string message , Exception inner ) 
			: base( message , inner ) 
		{
		}
		
		protected ValidationException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{ 
		}
	}
}
