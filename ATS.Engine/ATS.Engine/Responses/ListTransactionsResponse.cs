using System;
using System.Collections.Generic;

namespace ATS.Client.Responses
{
	public sealed class ListTransactionsResponse : BaseResponse
	{
		private readonly IList<DOTransaction> _transactions = null;


		public ListTransactionsResponse( IList<DOTransaction> transactions )
		{
			_transactions = transactions ?? throw new ArgumentNullException( nameof( transactions ) );
		}



		public IList<DOTransaction> Transactions
		{
			get => _transactions;
		}
	}
}
