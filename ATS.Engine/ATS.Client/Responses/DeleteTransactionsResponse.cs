using System;

namespace ATS.Client.Responses
{
	public sealed class DeleteTransactionsResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteTransactionsResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
