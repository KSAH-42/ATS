using System;

namespace ATS.Client.Messaging
{
	public interface IHandler
	{
		string TypeId
		{
			get;
		}

		void BeginHandle( Request request );

		void EndHandle( Request request , Response response );
	}
}
