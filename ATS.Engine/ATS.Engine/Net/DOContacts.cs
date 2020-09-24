using System;

namespace ATS.Engine.Net
{
	public sealed class DOContacts : DOValue
	{
		private string                  _phone         = string.Empty;

		private string                  _mobile        = string.Empty;

		private string                  _fax           = string.Empty;

		private string                  _email         = string.Empty;





		public string Phone
		{
			get => GetField( ref _phone );
			set => SetField( ref _phone , value ?? string.Empty );
		}

		public string Mobile
		{
			get => GetField( ref _mobile );
			set => SetField( ref _mobile , value ?? string.Empty );
		}

		public string Fax
		{
			get => GetField( ref _fax );
			set => SetField( ref _fax , value ?? string.Empty );
		}

		public string Email
		{
			get => GetField( ref _email );
			set => SetField( ref _email , value ?? string.Empty );
		}

	}
}
