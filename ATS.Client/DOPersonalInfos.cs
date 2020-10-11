﻿using System;

namespace ATS.Client
{
	public sealed class DOPersonalInfos : DORoot
	{
		private string    _firstName     = string.Empty;

		private string    _lastName      = string.Empty;

		private string    _nationality   = string.Empty;

		private DateTime  _birthDay      = DateTime.MinValue;


		
		
		public string FirstName
		{
			get => GetField( ref _firstName );
			set => SetField( ref _firstName , ValueFilter.ReplaceNull( value ) );
		}

		public string LastName
		{
			get => GetField( ref _lastName );
			set => SetField( ref _lastName , ValueFilter.ReplaceNull( value ) );
		}

		public string Nationality
		{
			get => GetField( ref _nationality );
			set => SetField( ref _nationality , ValueFilter.ReplaceNull( value ) );
		}

		public DateTime BirthDay
		{
			get => GetField( ref _birthDay );
			set => SetField( ref _birthDay , value );
		}

	}
}
