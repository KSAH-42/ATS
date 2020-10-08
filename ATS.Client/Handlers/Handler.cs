using System;

namespace ATS.Client.Handlers
{
	public abstract class Handler : IHandler
	{
		public static readonly Handler Null = new NullHandler();


		public abstract string TypeId
		{
			get;
		}

		public abstract void BeginHandle( IRequest request );

		public abstract void EndHandle( IRequest request , IResponse response );
	}
}
