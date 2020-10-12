using System;

namespace ATS.Client.Configuration
{
	public sealed class WebClientConfiguration : ClientConfiguration
	{
		private string _server = string.Empty;

		private TimeSpan _timeout = TimeSpan.Zero;




		public override string Server
		{
			get => GetField( ref _server );
			set => SetField( ref _server , value ?? string.Empty );
		}

		public override TimeSpan Timeout
		{
			get => GetField( ref _timeout );
			set => SetField( ref _timeout , value );
		}




		public override void Validate()
		{
			lock ( SyncRoot )
			{
				if ( string.IsNullOrWhiteSpace( _server ) )
				{
					throw new ConfigurationException( "Bad server value" );
				}

				if ( _timeout <= TimeSpan.Zero )
				{
					throw new ConfigurationException( "Bad timeout value" );
				}
			}
		}
	}
}
