using System;

namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public sealed class FindTransactionResponse : Response
	{
		private readonly DOTransaction _transaction = null;


		public FindTransactionResponse( bool succeed , DOTransaction transaction )
			: base ( succeed )
		{
			_transaction = transaction;
		}



		public DOTransaction Transaction
		{
			get => _transaction;
		}
	}
}
