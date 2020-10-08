using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class ListEntitiesRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _entities = null;


		public ListEntitiesRequest( IReadOnlyCollection<Guid> entities )
		{
			InternalValidator.CheckCollection( entities );

			_entities = entities;
		}

		
	

		public IReadOnlyCollection<Guid> Entities
		{
			get => _entities;
		}

	}
}
