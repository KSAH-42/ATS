using System;

namespace ATS.Client.Messaging
{
	public sealed class WithdrawRequest : Request
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;

		private readonly decimal _amount      = 0;




		public WithdrawRequest( Guid customerId , Guid accountId , decimal amount )
		{
			ValidationHelper.CheckUniqueId( customerId , accountId );
			ValidationHelper.CheckAmount( amount );

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
