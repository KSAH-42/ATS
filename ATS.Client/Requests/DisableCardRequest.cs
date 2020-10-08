using System;

namespace ATS.Client.Requests
{
	public sealed class DisableCardRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _cardId      = Guid.Empty;



		public DisableCardRequest( Guid customerId , Guid cardId )
		{
			ValidationHelper.CheckUniqueId( customerId , cardId );

			_customerId  = customerId ;
			_cardId      = cardId     ;
		}
	



		public Guid Customer
		{
			get => _customerId;
		}

		public Guid CardId
		{
			get => _cardId;
		}

	}
}
