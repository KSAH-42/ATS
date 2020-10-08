using System;

namespace ATS.Client
{
	public interface IHandler
	{
		string TypeId
		{
			get;
		}

		void BeginHandle( IRequest request );

		void EndHandle( IRequest request , IResponse response );
	}
}
