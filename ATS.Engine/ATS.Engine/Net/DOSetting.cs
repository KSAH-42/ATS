using System;

namespace ATS.Engine.Net
{
	public sealed class DOSetting : DOEntity
	{
		private Guid              _ownerId          = Guid.Empty;

		private string            _value            = string.Empty;







		public DOSetting( Guid uniqueId )
			: base( uniqueId )
		{
		}






		public override DOEntityTypes EntityType
		{
			get => DOEntityTypes.Setting;
		}

		public Guid OwnerId
		{
			get => GetField( ref _ownerId );
			set => SetField( ref _ownerId , value );
		}

		public string Value
		{
			get => GetField( ref _value );
			set => SetField( ref _value , value ?? string.Empty );
		}


	}
}
