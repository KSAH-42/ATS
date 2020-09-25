using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DisableCardResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public DisableCardResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
