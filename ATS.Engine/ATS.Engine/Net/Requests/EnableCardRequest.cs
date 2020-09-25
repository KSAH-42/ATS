using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class EnableCardRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _cardId      = Guid.Empty;



		public EnableCardRequest( Guid customerId , Guid cardId )
		{
			_customerId  = InternalValidator.CheckUniqueId( customerId );
			_cardId      = InternalValidator.CheckUniqueId( cardId     );
		}
	



		public Guid Customer
		{
			get => _customerId;
		}

		public Guid AccountId
		{
			get => _customerId;
		}

	}
}
