using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class FindEventRecordResponse : BaseResponse
	{
		private readonly DOEventRecord _record = null;


		public FindEventRecordResponse( DOEventRecord record )
		{
			_record = record;
		}



		public DOEventRecord Record
		{
			get => _record;
		}
	}
}
