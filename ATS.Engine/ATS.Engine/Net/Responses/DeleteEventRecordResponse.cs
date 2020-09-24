using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class DeleteEventRecordResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public DeleteEventRecordResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
