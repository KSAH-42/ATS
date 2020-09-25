using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteEventRecordsResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteEventRecordsResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
