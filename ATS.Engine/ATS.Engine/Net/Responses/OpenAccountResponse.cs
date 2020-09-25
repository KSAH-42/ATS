using System;

namespace ATS.Engine.Net.Responses
{
	public sealed class OpenAccountResponse : BaseResponse
	{
		private readonly Guid _accountId = Guid.Empty;

		
		public OpenAccountResponse( Guid accountId )
		{
			_accountId = accountId;
		}



		public Guid AccountId
		{
			get => _accountId;
		}

	}
}
