using System;

namespace ATS.Client
{
	public interface IHandler
	{
		string TypeId
		{
			get;
		}

		void BeginProcess( IRequest request );

		void EndProcess( IRequest request , IResponse response );
	}
}
