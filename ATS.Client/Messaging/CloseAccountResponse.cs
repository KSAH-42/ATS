using System;

namespace ATS.Client.Messaging
{
	public sealed class CloseAccountResponse : Response
	{
		private readonly Guid _accountId = Guid.Empty;

		
		public CloseAccountResponse( bool succeed , Guid accountId )
			: base( succeed )
		{
			_accountId = accountId;
		}



		public Guid AccountId
		{
			get => _accountId;
		}

	}
}
