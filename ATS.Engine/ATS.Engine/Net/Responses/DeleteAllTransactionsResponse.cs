using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteAllTransactionsResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteAllTransactionsResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
