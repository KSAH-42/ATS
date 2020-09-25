using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net.Requests
{
	public sealed class FindEventRecordRequest : BaseRequest
	{
		private readonly Guid _recordId = Guid.Empty;


		public FindEventRecordRequest( Guid recordId )
		{
			_recordId = InternalValidator.CheckUniqueId( recordId );
		}

		
	

		public Guid RecordId
		{
			get => _recordId;
		}


	}
}
