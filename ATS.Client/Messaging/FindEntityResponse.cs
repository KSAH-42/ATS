using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class FindEntityResponse : Response
	{
		private readonly DOEntity _entity = null;


		public FindEntityResponse( bool succeed , DOEntity entity )
			: base ( succeed  )
		{
			_entity = entity;
		}



		public DOEntity Entity
		{
			get => _entity;
		}
	}
}
