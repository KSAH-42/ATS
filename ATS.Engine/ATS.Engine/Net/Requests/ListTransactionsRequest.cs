using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class ListTransactionsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _transactions = null;


		public ListTransactionsRequest( IReadOnlyCollection<Guid> transactions )
		{
			InternalValidator.CheckCollection( transactions );

			_transactions = transactions;
		}

		
	

		public IReadOnlyCollection<Guid> Transactions
		{
			get => _transactions;
		}


	}
}
