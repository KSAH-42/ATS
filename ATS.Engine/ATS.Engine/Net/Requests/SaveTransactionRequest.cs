using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveTransactionRequest : BaseRequest
	{
		private readonly DOTransaction _transaction = null;


		public SaveTransactionRequest( DOTransaction transaction )
		{
			_transaction = transaction;
		}

		
	

		public DOTransaction Transaction
		{
			get => _transaction;
		}




		public override bool Validate()
		{
			return _transaction.UniqueId != Guid.Empty;
		}
	}
}
