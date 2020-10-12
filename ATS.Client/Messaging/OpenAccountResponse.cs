using System;

namespace ATS.Client.Messaging
{
	public sealed class OpenAccountResponse : Response
	{
		private readonly Guid _accountId = Guid.Empty;

		
		public OpenAccountResponse( bool succeed , Guid accountId )
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
