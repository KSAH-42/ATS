using System;

namespace ATS.Client.Messaging
{
	public abstract class Response
	{
		private readonly bool _succeed = false;




		protected Response( bool succeed )
		{
			_succeed = succeed;
		}




		public bool Succeed
		{
			get => _succeed;
		}
	}
}
