﻿using System;

namespace ATS.Client.Data
{
	public sealed class DOSetting : DOEntity
	{
		private Guid              _ownerId          = Guid.Empty;

		private string            _value            = string.Empty;







		public DOSetting( Guid uniqueId )
			: base( uniqueId )
		{
		}






		public override DOEntityType Type
		{
			get => DOEntityType.Setting;
		}

		public Guid OwnerId
		{
			get => GetField( ref _ownerId );
			set => SetField( ref _ownerId , value );
		}

		public string Value
		{
			get => GetField( ref _value );
			set => SetField( ref _value , DataFilter.ReplaceNull( value ) );
		}


	}
}
