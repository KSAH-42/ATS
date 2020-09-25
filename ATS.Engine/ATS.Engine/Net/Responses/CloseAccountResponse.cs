using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class CloseAccountResponse : BaseResponse
	{
		private readonly Guid _accountId = Guid.Empty;

		
		public CloseAccountResponse( Guid accountId )
		{
			_accountId = accountId;
		}



		public Guid AccountId
		{
			get => _accountId;
		}

	}
}
