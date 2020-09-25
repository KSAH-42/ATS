using System;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEventRecordsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _records = null;


		public DeleteEventRecordsRequest( IReadOnlyCollection<Guid> entities )
		{
			_records = InternalValidator.CheckCollection( entities );
		}




		public IReadOnlyCollection<Guid> Records
		{
			get => _records;
		}


	}
}
