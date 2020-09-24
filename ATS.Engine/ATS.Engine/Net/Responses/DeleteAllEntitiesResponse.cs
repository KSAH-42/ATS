using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteAllEntitiesResponse : BaseResponse
	{
		private readonly int _results = 0;


		public DeleteAllEntitiesResponse( int results )
		{
			_results = results;
		}



		public int Results
		{
			get => _results;
		}
	}
}
