using System;

namespace ATS.Engine.Net.Responses
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
