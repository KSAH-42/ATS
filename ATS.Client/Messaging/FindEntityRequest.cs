using System;

namespace ATS.Client.Messaging
{
	public sealed class FindEntityRequest : Request
	{
		private readonly Guid _entityId = Guid.Empty;


		public FindEntityRequest( Guid entityId )
		{
			ValidationHelper.CheckUniqueId( entityId );

			_entityId = entityId;
		}

		
	

		public Guid EntityId
		{
			get => _entityId;
		}

	}
}
