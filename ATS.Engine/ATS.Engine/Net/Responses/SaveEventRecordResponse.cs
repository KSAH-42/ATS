using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class SaveEventRecordResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public SaveEventRecordResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
