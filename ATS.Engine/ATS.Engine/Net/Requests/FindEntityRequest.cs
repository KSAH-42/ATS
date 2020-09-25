using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;


		public FindEntityRequest( Guid entityId )
		{
			_entityId = InternalValidator.CheckUniqueId( entityId );
		}

		
	

		public Guid EntityId
		{
			get => _entityId;
		}

	}
}
