using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveEntityRequest : BaseRequest
	{
		private readonly DOEntity _entity = null;


		public SaveEntityRequest( DOEntity entity )
		{
			_entity = InternalValidator.CheckEntity( entity );
		}

		
	

		public DOEntity Entity
		{
			get => _entity;
		}


	}
}
