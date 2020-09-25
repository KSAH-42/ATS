using System;

namespace ATS.Engine.Net.Responses
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
