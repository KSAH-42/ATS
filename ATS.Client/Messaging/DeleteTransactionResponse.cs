using System;

namespace ATS.Client.Messaging
{
	public sealed class DeleteTransactionResponse : Response
	{
		public DeleteTransactionResponse( bool succeed )
			: base( succeed )
		{
		}
	}
}
