using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEntitiesRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _entities = null;


		public DeleteEntitiesRequest( IReadOnlyCollection<Guid> entities )
		{
			_entities = entities ?? throw new ArgumentNullException( nameof( entities ) );
		}

		
	

		public IReadOnlyCollection<Guid> Entities
		{
			get => _entities;
		}




		public override bool Validate()
		{
			return _entities.Any();
		}
	}
}
