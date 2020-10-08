using System;

namespace ATS.Client.Requests
{
	public sealed class DepositRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;

		private readonly decimal _amount      = 0;




		public DepositRequest( Guid customerId , Guid accountId , decimal amount )
		{
			InternalValidator.CheckUniqueId( customerId , accountId );
			InternalValidator.CheckAmount( amount );

			_customerId  = customerId ;
			_accountId   = accountId  ;
			_amount      = amount     ;
		}
	



		public Guid Customer
		{
			get => _customerId;
		}

		public Guid AccountId
		{
			get => _accountId;
		}

		public decimal Price
		{
			get => _amount;
		}
	}
}
