using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;



		public DeleteEntityRequest( Guid entityId )
		{
			_entityId = InternalValidator.Validate( entityId );
		}
	

		public Guid EntityId
		{
			get => _entityId;
		}

	}
}
