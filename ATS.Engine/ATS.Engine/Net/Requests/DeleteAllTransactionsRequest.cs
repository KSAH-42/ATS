﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteAllTransactionsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _transactions = null;




		public DeleteAllTransactionsRequest( IReadOnlyCollection<Guid> entities )
		{
			_transactions = entities ?? throw new ArgumentNullException( nameof( entities ) );
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
