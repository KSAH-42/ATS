using System;

namespace ATS.Client.Data
{
	public sealed class DOContacts : DORoot
	{
		private string   _phone    = string.Empty;

		private string   _mobile   = string.Empty;

		private string   _fax      = string.Empty;

		private string   _email    = string.Empty;




		public string Phone
		{
			get => GetField( ref _phone );
			set => SetField( ref _phone , DataFilter.ReplaceNull( value ) );
		}

		public string Mobile
		{
			get => GetField( ref _mobile );
			set => SetField( ref _mobile , DataFilter.ReplaceNull( value ) );
		}

		public string Fax
		{
			get => GetField( ref _fax );
			set => SetField( ref _fax , DataFilter.ReplaceNull( value ) );
		}

		public string Email
		{
			get => GetField( ref _email );
			set => SetField( ref _email , DataFilter.ReplaceNull( value ) );
		}

	}
}
