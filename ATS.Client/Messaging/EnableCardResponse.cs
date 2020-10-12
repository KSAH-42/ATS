using System;

namespace ATS.Client.Messaging
{
	public sealed class EnableCardResponse : Response
	{
		public EnableCardResponse( bool succeed )
			: base ( succeed )
		{
		}
	}
}
