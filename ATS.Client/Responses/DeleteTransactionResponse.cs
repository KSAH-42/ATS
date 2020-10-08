using System;

namespace ATS.Client.Responses
{
	public sealed class DeleteTransactionResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public DeleteTransactionResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
