using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveEntityRequest : BaseRequest
	{
		private readonly DOEntity _entity = null;


		public SaveEntityRequest( DOEntity entity )
		{
			_entity = entity ?? throw new ArgumentNullException( nameof( entity ) );
		}

		
	

		public DOEntity Entity
		{
			get => _entity;
		}




		public override bool Validate()
		{
			return _entity.UniqueId != Guid.Empty;
		}
	}
}
