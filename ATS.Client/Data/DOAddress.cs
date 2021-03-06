﻿using System;

namespace ATS.Client.Data
{
	public sealed class DOAddress : DORoot
	{
		private string    _street    = string.Empty;

		private string    _city      = string.Empty;

		private string    _zipCode   = string.Empty;

		private string    _country   = string.Empty;

		



		public string Street
		{
			get => GetField( ref _street );
			set => SetField( ref _street , DataFilter.ReplaceNull( value ) );
		}

		public string City
		{
			get => GetField( ref _city );
			set => SetField( ref _city , DataFilter.ReplaceNull( value ) );
		}

		public string ZipCode
		{
			get => GetField( ref _zipCode );
			set => SetField( ref _zipCode , DataFilter.ReplaceNull( value ) );
		}

		public string Country
		{
			get => GetField( ref _country );
			set => SetField( ref _country , DataFilter.ReplaceNull( value ) );
		}
							
	}
}
