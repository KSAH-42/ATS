using System;

namespace ATS.Client.Configuration
{
	public sealed class ConfigurationPropertyChangedEventArgs : EventArgs
	{
		private readonly string _propertyName = string.Empty;

		private readonly object _value = null;



		public ConfigurationPropertyChangedEventArgs( string propertyName , object value )
		{
			_propertyName = propertyName ?? throw new ArgumentNullException( nameof( propertyName ) );
			_value        = value;
		}




		public string PropertyName
		{
			get => _propertyName;
		}

		public object Value
		{
			get => _value;
		}

	}
}
