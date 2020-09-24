using System;

namespace ATS.Engine.Net
{
	public sealed class DOPersonalInfos : DOValue
	{
		private string    _firstName     = string.Empty;

		private string    _lastName      = string.Empty;

		private string    _nationality   = string.Empty;

		private DateTime  _birthDay      = DateTime.MinValue;


		
		
		public string FirstName
		{
			get => GetField( ref _firstName );
			set => SetField( ref _firstName , value ?? string.Empty );
		}

		public string LastName
		{
			get => GetField( ref _lastName );
			set => SetField( ref _lastName , value ?? string.Empty );
		}

		public string Nationality
		{
			get => GetField( ref _nationality );
			set => SetField( ref _nationality , value ?? string.Empty );
		}

		public DateTime BirthDay
		{
			get => GetField( ref _birthDay );
			set => SetField( ref _birthDay , value );
		}

	}
}
