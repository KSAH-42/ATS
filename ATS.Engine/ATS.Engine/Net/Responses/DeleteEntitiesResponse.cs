using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteEntitiesResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteEntitiesResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
