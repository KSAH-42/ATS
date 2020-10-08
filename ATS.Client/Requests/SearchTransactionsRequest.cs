using System;

namespace ATS.Client.Requests
{
	public sealed class SearchTransactionsRequest : BaseRequest
	{
		private readonly DateTime _startTime          = DateTime.MinValue;

		private readonly DateTime _endTime            = DateTime.MinValue;

		private readonly int      _maximumOfResults   = 0;



		public SearchTransactionsRequest( DateTime startTime , DateTime endTime , int maximumOfResults )
		{
			ValidationHelper.CheckSearchParameters( startTime , endTime , maximumOfResults );

			_startTime        = startTime;
			_endTime          = endTime;
			_maximumOfResults = maximumOfResults;
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
