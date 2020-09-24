using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteAllEventRecordsResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteAllEventRecordsResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
