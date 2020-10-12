using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteTransactionsResponse : Response
	{
		private readonly int _results = 0;


		public DeleteTransactionsResponse( bool succeed , int results )
			: base ( succeed )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
