using System;

namespace ATS.Client.Messaging
{
	public sealed class FindTransactionRequest : Request
	{
		private readonly Guid _transactionId = Guid.Empty;


		public FindTransactionRequest( Guid transactionId )
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
