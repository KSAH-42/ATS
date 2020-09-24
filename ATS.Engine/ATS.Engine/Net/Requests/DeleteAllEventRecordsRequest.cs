using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteAllEventRecordsRequest : BaseRequest
	{
		private readonly IReadOnlyCollection<Guid> _records = null;


		public DeleteAllEventRecordsRequest( IReadOnlyCollection<Guid> entities )
		{
			_records = entities ?? throw new ArgumentNullException( nameof( entities ) );
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
