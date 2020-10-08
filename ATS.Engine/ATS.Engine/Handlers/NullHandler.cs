using System;

namespace ATS.Client.Handlers
{
	public sealed class NullHandler : Handler
	{
		internal NullHandler()
		{
		}


		public override string TypeId
		{
			get => string.Empty;
		}

		public override void BeginProcess( IRequest request ) {}

		public override void EndProcess( IRequest request , IResponse response ) {}
	}
}
