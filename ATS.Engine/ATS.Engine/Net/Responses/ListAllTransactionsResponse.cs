﻿using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Responses
{
	public sealed class ListAllTransactionsResponse : BaseResponse
	{
		private readonly IList<DOTransaction> _transactions = null;


		public ListAllTransactionsResponse( IList<DOTransaction> transactions )
		{
			_transactions = transactions ?? throw new ArgumentNullException( nameof( transactions ) );
		}



		public IList<DOTransaction> Transactions
		{
			get => _transactions;
		}
	}
}