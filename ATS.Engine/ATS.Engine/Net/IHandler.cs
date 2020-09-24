using System;

namespace ATS.Engine.Net
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
