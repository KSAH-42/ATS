using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	public sealed class ListTransactionsRequest : Request
	{
		private readonly IReadOnlyCollection<Guid> _transactions = null;


		public ListTransactionsRequest( IReadOnlyCollection<Guid> transactions )
		{
			ValidationHelper.CheckCollection( transactions );

			_transactions = transactions;
		}

		
	

		public IReadOnlyCollection<Guid> Transactions
		{
			get => _transactions;
		}


	}
}
