using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class EnableCardResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public EnableCardResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
