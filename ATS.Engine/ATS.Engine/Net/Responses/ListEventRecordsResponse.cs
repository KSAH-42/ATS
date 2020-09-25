using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Responses
{
	public sealed class ListEventRecordsResponse : BaseResponse
	{
		private readonly IList<DOEventRecord> _records = null;


		public ListEventRecordsResponse( IList<DOEventRecord> records )
		{
			_records = records ?? throw new ArgumentNullException( nameof( records ) );
		}



		public IList<DOEventRecord> Records
		{
			get => _records;
		}
	}
}
