using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class ListEventRecordsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _records = null;


		public ListEventRecordsRequest( IReadOnlyCollection<Guid> records )
		{
			_records = InternalValidator.CheckCollection( records );
		}

		
	

		public IReadOnlyCollection<Guid> Records
		{
			get => _records;
		}


	}
}
