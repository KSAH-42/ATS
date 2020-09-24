using System;

namespace ATS.Engine.Net.Requests
{
	public abstract class BaseRequest : IRequest
	{
		public abstract bool Validate();
	}
}
