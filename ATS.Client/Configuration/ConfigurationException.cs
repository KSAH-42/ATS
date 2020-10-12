using System;
using System.Runtime.Serialization;

namespace ATS.Client.Configuration
{
	[Serializable]
	public class ConfigurationException : Exception
	{
		public ConfigurationException()
			: this( "Configuration exception" )
		{
		}

		public ConfigurationException( string message ) 
			: base( message ) 
		{
		}
		
		public ConfigurationException( string message , Exception inner ) 
			: base( message , inner ) 
		{
		}
		
		protected ConfigurationException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{ 
		}
	}
}
