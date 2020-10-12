using System;

namespace ATS.Client.Messaging
{
	public sealed class SaveTransactionResponse : Response
	{
		public SaveTransactionResponse( bool succeed )
			: base ( succeed )
		{
		}
	}
}
