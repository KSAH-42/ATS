﻿using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class FindEntityResponse : BaseResponse
	{
		private readonly DOEntity _entity = null;


		public FindEntityResponse( DOEntity entity )
		{
			_entity = entity;
		}



		public DOEntity Entity
		{
			get => _entity;
		}
	}
}