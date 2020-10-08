using System;

namespace ATS.Client.Responses
{
	public sealed class FindTransactionResponse : BaseResponse
	{
		private readonly DOTransaction _transaction = null;


		public FindTransactionResponse( DOTransaction transaction )
		{
			_transaction = transaction;
		}



		public DOTransaction Transaction
		{
			get => _transaction;
		}
	}
}
