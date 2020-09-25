using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class SaveEventResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public SaveEventResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
