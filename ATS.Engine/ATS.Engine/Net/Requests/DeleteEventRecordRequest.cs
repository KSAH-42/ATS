using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class DeleteEventRecordRequest : BaseRequest
	{
		private Guid _recordId = Guid.Empty;



		public DeleteEventRecordRequest( Guid recordId )
		{
			_recordId = InternalValidator.Validate( recordId );
		}
	



		public Guid RecordId
		{
			get => _recordId;
		}

	}
}
