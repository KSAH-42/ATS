using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEntitiesRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _entities = null;


		public DeleteEntitiesRequest( IReadOnlyCollection<Guid> entities )
		{
			InternalValidator.CheckCollection<Guid>( entities );

			_entities = entities;
		}

		
	

		public IReadOnlyCollection<Guid> Entities
		{
			get => _entities;
		}

	}
}
