using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class ListAllEventRecordsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _records = null;


		public ListAllEventRecordsRequest( IReadOnlyCollection<Guid> records )
		{
			_records = records ?? throw new ArgumentNullException( nameof( records ) );
		}

		
	

		public IReadOnlyCollection<Guid> Records
		{
			get => _records;
		}




		public override bool Validate()
		{
			return _records.Any();
		}
	}
}
