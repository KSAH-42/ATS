﻿using System;

namespace ATS.Client.Responses
{
	public sealed class DeleteEventResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public DeleteEventResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}