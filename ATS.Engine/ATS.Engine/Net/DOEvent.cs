using System;

namespace ATS.Engine.Net
{
	public sealed class DOEvent : DORoot
	{
		private readonly Guid     _uniqueId         = Guid.Empty;

		private DateTime          _timestamp        = DateTime.MinValue;

		private EventType         _type             = EventType.None;

		private Guid              _applicationId    = Guid.Empty;

	    private Guid              _entityId         = Guid.Empty;

		private string            _data             = string.Empty;





		public DOEvent( Guid uniqueId )
		{
			_uniqueId = uniqueId;
		}






		public override Guid UniqueId
		{
			get => _uniqueId;
		}

		public DateTime TimeStamp
		{
			get => GetField( ref _timestamp );
			set => SetField( ref _timestamp , value );
		}

		public EventType Type
		{
			get => GetField( ref _type );
			set => SetField( ref _type , value );
		}

		public Guid ApplicationId
		{
			get => GetField( ref _applicationId );
			set => SetField( ref _applicationId , value );
		}

		public Guid EntityId
		{
			get => GetField( ref _entityId );
			set => SetField( ref _entityId , value );
		}

		public string Data
		{
			get => GetField( ref _data );
			set => SetField( ref _data , value ?? string.Empty );
		}

	}
}
