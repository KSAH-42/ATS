using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class SaveEventRecordRequest : BaseRequest
	{
		private readonly DOEventRecord _record = null;


		public SaveEventRecordRequest( DOEventRecord record )
		{
			_record = InternalValidator.Validate( record );
		}

		
	

		public DOEventRecord Record
		{
			get => _record;
		}


	}
}
