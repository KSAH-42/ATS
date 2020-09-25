using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SearchTransactionsRequest : BaseRequest
	{
		private readonly DateTime _startTime          = DateTime.MinValue;

		private readonly DateTime _endTime            = DateTime.MinValue;

		private readonly int      _maximumOfResults   = 0;



		public SearchTransactionsRequest( DateTime startTime , DateTime endTime , int maximumOfResults )
		{
			_startTime        = InternalValidator.CheckStartTime( startTime , endTime );
			_endTime          = InternalValidator.CheckEndTime  ( startTime , endTime );
			_maximumOfResults = InternalValidator.CheckMaximumOfResults( maximumOfResults );
		}
	



		public DateTime StartTime
		{
			get => _startTime;
		}

		public DateTime EndTime
		{
			get => _endTime;
		}

		public int MaximumOfResults
		{
			get => _maximumOfResults;
		}

	}
}
