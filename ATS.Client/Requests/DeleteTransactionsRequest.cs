using System;
using System.Collections.Generic;

namespace ATS.Client.Requests
{
	public sealed class DeleteTransactionsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _transactions = null;




		public DeleteTransactionsRequest( IReadOnlyCollection<Guid> trannsactions )
		{
			ValidationHelper.CheckCollection( trannsactions );

			_transactions = trannsactions;
		}




		public IReadOnlyCollection<Guid> Transactions
		{
			get => _transactions;
		}

	}
}
