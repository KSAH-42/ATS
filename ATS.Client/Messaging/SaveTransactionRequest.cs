using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class SaveTransactionRequest : Request
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
