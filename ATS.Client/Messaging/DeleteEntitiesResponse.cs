using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEntitiesResponse : Response
	{
		private readonly int _results = 0;


		public DeleteEntitiesResponse( bool succeed , int results )
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
