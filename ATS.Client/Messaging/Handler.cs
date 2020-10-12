using System;

namespace ATS.Client.Messaging
{
	public abstract class Handler : IHandler
	{
		public abstract string TypeId
		{
			get;
		}

		public abstract void BeginHandle( Request request );

		public abstract void EndHandle( Request request , Response response );
	}
}
