using System;

namespace ATS.Client.Requests
{
	public sealed class FindTransactionRequest : BaseRequest
	{
		private readonly Guid _transactionId = Guid.Empty;


		public FindTransactionRequest( Guid transactionId )
		{
			InternalValidator.CheckUniqueId( transactionId );

			_transactionId = transactionId;
		}

		
	

		public Guid TransactionId
		{
			get => _transactionId;
		}


	}
}
