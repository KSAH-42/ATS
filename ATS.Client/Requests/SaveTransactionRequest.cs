using System;

namespace ATS.Client.Requests
{
	public sealed class SaveTransactionRequest : BaseRequest
	{
		private readonly DOTransaction _transaction = null;


		public SaveTransactionRequest( DOTransaction transaction )
		{
			ValidationHelper.CheckTransaction( transaction );

			_transaction = transaction;
		}

		
	

		public DOTransaction Transaction
		{
			get => _transaction;
		}


	}
}
