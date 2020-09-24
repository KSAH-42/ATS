using System;

namespace ATS.Engine.Net
{
	public sealed class DOSetting : DORoot
	{
		private readonly Guid     _uniqueId         = Guid.Empty;

		private Guid              _ownerId          = Guid.Empty;

		private string            _value            = string.Empty;







		public DOSetting( Guid uniqueId )
		{
			_uniqueId = uniqueId;
		}






		public override Guid UniqueId
		{
			get => _uniqueId;
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
