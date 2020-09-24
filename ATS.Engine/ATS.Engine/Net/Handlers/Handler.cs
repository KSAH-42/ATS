using System;

namespace ATS.Engine.Net.Handlers
{
	public abstract class Handler : IHandler
	{
		public static readonly Handler Null = new NullHandler();


		public abstract string TypeId
		{
			get;
		}

		public abstract void BeginProcess( IRequest request );

		public abstract void EndProcess( IRequest request , IResponse response );
	}
}
