using System;

namespace ATS.Client.Requests
{
	public sealed class DeleteTransactionRequest : BaseRequest
	{
		private Guid _transactionId = Guid.Empty;



		public DeleteTransactionRequest( Guid transactionId )
		{
			ValidationHelper.CheckUniqueId( transactionId );

			_transactionId = transactionId;
		}
	



		public Guid TransactionId
		{
			get => _transactionId;
		}

	}
}
