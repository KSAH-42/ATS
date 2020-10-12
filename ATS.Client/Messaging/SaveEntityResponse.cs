using System;

namespace ATS.Client.Messaging
{
	public sealed class SaveEntityResponse : Response
	{
		public SaveEntityResponse( bool succeed )
			: base ( succeed )
		{
		}
	}
}
