using System;

namespace ATS.Client.Responses
{
	public sealed class ReOpenAccountResponse : BaseResponse
	{
		private readonly Guid _accountId = Guid.Empty;

		
		public ReOpenAccountResponse( Guid accountId )
		{
			_accountId = accountId;
		}



		public Guid AccountId
		{
			get => _accountId;
		}

	}
}
