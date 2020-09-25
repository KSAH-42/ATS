using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteEventsResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteEventsResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
