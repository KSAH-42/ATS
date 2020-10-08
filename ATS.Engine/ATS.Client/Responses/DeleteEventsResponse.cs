using System;


namespace ATS.Client.Responses
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
