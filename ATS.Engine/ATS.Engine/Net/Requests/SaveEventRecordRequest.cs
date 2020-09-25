using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveEventRecordRequest : BaseRequest
	{
		private readonly DOEventRecord _record = null;


		public SaveEventRecordRequest( DOEventRecord record )
		{
			_record = record;
		}

		
	

		public DOEventRecord Record
		{
			get => _record;
		}




		public override bool Validate()
		{
			return _record.UniqueId != Guid.Empty;
		}
	}
}
