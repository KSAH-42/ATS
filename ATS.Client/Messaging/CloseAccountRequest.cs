using System;

namespace ATS.Client.Messaging
{
	public sealed class CloseAccountRequest : Request
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;




		public CloseAccountRequest( Guid customerId , Guid accountId )
		{
			ValidationHelper.CheckUniqueId( customerId , accountId );
			
			_customerId  = customerId;
			_accountId   = accountId;
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
