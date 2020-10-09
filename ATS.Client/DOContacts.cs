using System;

namespace ATS.Client
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
			set => SetField( ref _phone , ValueFilter.ReplaceNull( value ) );
		}

		public string Mobile
		{
			get => GetField( ref _mobile );
			set => SetField( ref _mobile , ValueFilter.ReplaceNull( value ) );
		}

		public string Fax
		{
			get => GetField( ref _fax );
			set => SetField( ref _fax , ValueFilter.ReplaceNull( value ) );
		}

		public string Email
		{
			get => GetField( ref _email );
			set => SetField( ref _email , ValueFilter.ReplaceNull( value ) );
		}

	}
}
