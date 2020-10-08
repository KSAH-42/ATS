using System;

namespace ATS.Client
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
			set => SetField( ref _street , ValueFilter.Filter( value ) );
		}

		public string City
		{
			get => GetField( ref _city );
			set => SetField( ref _city , ValueFilter.Filter( value ) );
		}

		public string ZipCode
		{
			get => GetField( ref _zipCode );
			set => SetField( ref _zipCode , ValueFilter.Filter( value ) );
		}

		public string Country
		{
			get => GetField( ref _country );
			set => SetField( ref _country , ValueFilter.Filter( value ) );
		}

		
	}
}
