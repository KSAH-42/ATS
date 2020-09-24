﻿using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteEntityResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public DeleteEntityResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
