using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEntityRequest : Request
	{
		private readonly Guid _entityId = Guid.Empty;



		public DeleteEntityRequest( Guid entityId )
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
