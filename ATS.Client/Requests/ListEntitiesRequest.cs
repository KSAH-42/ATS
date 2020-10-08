using System;
using System.Collections.Generic;

namespace ATS.Client.Requests
{
	public sealed class ListEntitiesRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _entities = null;


		public ListEntitiesRequest( IReadOnlyCollection<Guid> entities )
		{
			ValidationHelper.CheckCollection( entities );

			_entities = entities;
		}

		
	

		public IReadOnlyCollection<Guid> Entities
		{
			get => _entities;
		}

	}
}
