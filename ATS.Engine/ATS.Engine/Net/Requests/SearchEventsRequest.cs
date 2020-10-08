﻿using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SearchEventsRequest : BaseRequest
	{
		private readonly DateTime _startTime          = DateTime.MinValue;

		private readonly DateTime _endTime            = DateTime.MinValue;

		private readonly int      _maximumOfResults   = 0;



		public SearchEventsRequest( DateTime startTime , DateTime endTime , int maximumOfResults )
		{
			InternalValidator.CheckSearchParameters( startTime , endTime , maximumOfResults );

			_startTime        = startTime;
			_endTime          = endTime;
			_maximumOfResults = maximumOfResults ;
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
