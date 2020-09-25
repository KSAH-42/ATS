using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class ListTransactionsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _transactions = null;


		public ListTransactionsRequest( IReadOnlyCollection<Guid> transactions )
		{
			_transactions = transactions ?? throw new ArgumentNullException( nameof( transactions ) );
		}

		
	

		public IReadOnlyCollection<Guid> Transactions
		{
			get => _transactions;
		}




		public override bool Validate()
		{
			return _transactions.Any();
		}
	}
}
