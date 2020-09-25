using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveTransactionRequest : BaseRequest
	{
		private readonly DOTransaction _transaction = null;


		public SaveTransactionRequest( DOTransaction transaction )
		{
			_transaction = InternalValidator.CheckTransaction( transaction );
		}

		
	

		public DOTransaction Transaction
		{
			get => _transaction;
		}


	}
}
