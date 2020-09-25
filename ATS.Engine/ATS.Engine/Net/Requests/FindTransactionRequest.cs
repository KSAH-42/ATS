using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindTransactionRequest : BaseRequest
	{
		private readonly Guid _transactionId = Guid.Empty;


		public FindTransactionRequest( Guid transactionId )
		{
			_transactionId = InternalValidator.Validate( transactionId );
		}

		
	

		public Guid TransactionId
		{
			get => _transactionId;
		}


	}
}
