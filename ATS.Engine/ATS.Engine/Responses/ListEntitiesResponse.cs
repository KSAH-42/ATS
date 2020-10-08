using System;
using System.Collections.Generic;

namespace ATS.Client.Responses
{
	public sealed class ListEntitiesResponse : BaseResponse
	{
		private readonly IList<DOEntity> _entities = null;


		public ListEntitiesResponse( IList<DOEntity> entities )
		{
			_entities = entities ?? throw new ArgumentNullException( nameof( entities ) );
		}



		public IList<DOEntity> Entities
		{
			get => _entities;
		}
	}
}
