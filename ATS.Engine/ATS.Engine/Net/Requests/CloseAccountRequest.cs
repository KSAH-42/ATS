using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class CloseAccountRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;




		public CloseAccountRequest( Guid customerId , Guid accountId )
		{
			_customerId  = InternalValidator.CheckUniqueId( customerId ) ;
			_accountId   = InternalValidator.CheckUniqueId( accountId  ) ;
		}
	



		public Guid CustomerId
		{
			get => _customerId;
		}

		public Guid AccountId
		{
			get => _accountId;
		}
	}
}
