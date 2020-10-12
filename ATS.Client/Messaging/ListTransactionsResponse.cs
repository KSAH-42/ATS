using System;
using System.Collections.Generic;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class ListTransactionsResponse : Response
	{
		private readonly IList<DOTransaction> _transactions = null;


		public ListTransactionsResponse( bool succeed , IList<DOTransaction> transactions )
			: base( succeed )
		{
			_transactions = transactions ?? throw new ArgumentNullException( nameof( transactions ) );
		}



		public IList<DOTransaction> Transactions
		{
			get => _transactions;
		}
	}
}
