using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class SaveTransactionResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public SaveTransactionResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
