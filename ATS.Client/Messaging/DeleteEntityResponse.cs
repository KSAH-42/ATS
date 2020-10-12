using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteEntityResponse : Response
	{
		public DeleteEntityResponse( bool succeed )
			: base( succeed )
		{
		}
	}
}
