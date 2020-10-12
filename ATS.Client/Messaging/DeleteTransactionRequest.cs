using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteTransactionRequest : Request
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
