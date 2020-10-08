using System;

namespace ATS.Client.Requests
{
	public sealed class SaveEntityRequest : BaseRequest
	{
		private readonly DOEntity _entity = null;


		public SaveEntityRequest( DOEntity entity )
		{
			ValidationHelper.CheckEntity( entity );

			_entity = entity;
		}

		
	

		public DOEntity Entity
		{
			get => _entity;
		}


	}
}
