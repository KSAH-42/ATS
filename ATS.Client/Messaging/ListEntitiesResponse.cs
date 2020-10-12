using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class ListEntitiesResponse : Response
	{
		private readonly IList<DOEntity> _entities = null;


		public ListEntitiesResponse( bool succeed , IList<DOEntity> entities )
			: base ( succeed )
		{
			_entities = entities ?? throw new ArgumentNullException( nameof( entities ) );
		}



		public IList<DOEntity> Entities
		{
			get => _entities;
		}
	}
}
