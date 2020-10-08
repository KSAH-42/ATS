using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;



		public DeleteEntityRequest( Guid entityId )
		{
			InternalValidator.CheckUniqueId( entityId );

			_entityId = entityId;
		}
	

		public Guid EntityId
		{
			get => _entityId;
		}

	}
}
