using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class GetEntityRequest : BaseRequest
	{
		private readonly Guid _entityId = Guid.Empty;


		public GetEntityRequest( Guid entityId )
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
