using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindTransactionRequest : BaseRequest
	{
		private readonly Guid _transactionId = Guid.Empty;


		public FindTransactionRequest( Guid transactionId )
		{
			_transactionId = InternalValidator.CheckUniqueId( transactionId );
		}

		
	

		public Guid TransactionId
		{
			get => _transactionId;
		}


	}
}
