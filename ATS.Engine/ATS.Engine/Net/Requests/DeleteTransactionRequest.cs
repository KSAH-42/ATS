using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteTransactionRequest : BaseRequest
	{
		private Guid _transactionId = Guid.Empty;



		public DeleteTransactionRequest( Guid transactionId )
		{
			_transactionId = transactionId;
		}
	



		public Guid TransactionId
		{
			get => _transactionId;
		}




		public override bool Validate()
		{
			return _transactionId != Guid.Empty;
		}
	}
}
