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

		public override void BeginHandle( IRequest request ) {}

		public override void EndHandle( IRequest request , IResponse response ) {}
	}
}
