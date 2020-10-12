using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class SaveEntityRequest : Request
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
