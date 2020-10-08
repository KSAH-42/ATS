using System;

namespace ATS.Client.Responses
{
	public sealed class DepositResponse : BaseResponse
	{
		private readonly Guid    _customerId = Guid.Empty;

		private readonly Guid    _accountId  = Guid.Empty;

		private readonly decimal _balance    = 0;


		public DepositResponse( Guid customerId , Guid accountId , decimal balance )
		{
			_customerId= customerId;
			_accountId = accountId;
			_balance   = balance;
		}



		public Guid CustomerId
		{
			get => _customerId;
		}

		public Guid AccountId
		{
			get => _accountId;
		}

		public decimal Balance
		{
			get => _balance;
		}

	}
}
