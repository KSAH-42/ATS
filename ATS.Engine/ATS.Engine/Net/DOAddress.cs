using System;

namespace ATS.Engine.Net
{
	public sealed class DOAddress : DOValue
	{
		private string                  _street        = string.Empty;

		private string                  _city          = string.Empty;

		private string                  _zipCode       = string.Empty;

		private string                  _country       = string.Empty;



		
		public string Street
		{
			get => GetField( ref _street );
			set => SetField( ref _street , value ?? string.Empty );
		}

		public string City
		{
			get => GetField( ref _city );
			set => SetField( ref _city , value ?? string.Empty );
		}

		public string ZipCode
		{
			get => GetField( ref _zipCode );
			set => SetField( ref _zipCode , value ?? string.Empty );
		}

		public string Country
		{
			get => GetField( ref _country );
			set => SetField( ref _country , value ?? string.Empty );
		}

		
	}
}
