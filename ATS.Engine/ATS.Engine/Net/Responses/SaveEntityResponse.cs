using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class SaveEntityResponse : BaseResponse
	{
		private readonly bool _succeed = false;


		public SaveEntityResponse( bool succeed )
		{
			_succeed = succeed;
		}



		public bool Succeed
		{
			get => _succeed;
		}
	}
}
