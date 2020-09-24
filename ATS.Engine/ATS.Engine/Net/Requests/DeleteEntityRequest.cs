using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;



		public DeleteEntityRequest( Guid entityId )
		{
			_entityId = entityId;
		}
	

		public Guid EntityId
		{
			get => _entityId;
		}




		public override bool Validate()
		{
			return _entityId != Guid.Empty;
		}
	}
}
