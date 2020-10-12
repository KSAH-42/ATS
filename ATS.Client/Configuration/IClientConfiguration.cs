using System;

namespace ATS.Client.Configuration
{
	public interface IClientConfiguration
	{
		event EventHandler<ConfigurationPropertyChangedEventArgs> Changed;




		object SyncRoot
		{
			get;
		}

		string Server
		{
			get;
			set;
		}

		TimeSpan Timeout
		{
			get;
			set;
		}



		void Validate();
	}
}
