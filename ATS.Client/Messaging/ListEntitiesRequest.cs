using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	public sealed class ListEntitiesRequest : Request
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
