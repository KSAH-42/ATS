using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;


		public FindEntityRequest( Guid entityId )
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
