using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class GetEntityResponse : BaseResponse
	{
		private readonly DOEntity _entity = null;


		public GetEntityResponse( DOEntity entity )
		{
			_entity = entity;
		}



		public DOEntity Entity
		{
			get => _entity;
		}
	}
}
