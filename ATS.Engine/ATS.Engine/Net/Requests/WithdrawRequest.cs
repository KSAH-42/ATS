using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class WithdrawRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;

		private readonly decimal _amount      = 0;




		public WithdrawRequest( Guid customerId , Guid accountId , decimal amount )
		{
			_customerId  = InternalValidator.CheckUniqueId( customerId ) ;
			_accountId   = InternalValidator.CheckUniqueId( accountId  ) ;
			_amount      = InternalValidator.CheckAmount  ( amount     ) ;
		}
	



		public Guid Customer
		{
			get => _customerId;
		}

		public Guid AccountId
		{
			get => _customerId;
		}

		public decimal Price
		{
			get => _amount;
		}
	}
}
