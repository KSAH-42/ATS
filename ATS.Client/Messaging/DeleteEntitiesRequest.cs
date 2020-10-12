using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEntitiesRequest : Request
	{
		private readonly IReadOnlyCollection<Guid> _entities = null;


		public DeleteEntitiesRequest( IReadOnlyCollection<Guid> entities )
		{
			ValidationHelper.CheckCollection<Guid>( entities );

			_entities = entities;
		}

		
	

		public IReadOnlyCollection<Guid> Entities
		{
			get => _entities;
		}

	}
}
