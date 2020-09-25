using System;

namespace ATS.Engine.Net.Requests
{
	public sealed class OpenAccountRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly decimal _price       = 0;




		public OpenAccountRequest( Guid customerId , decimal price )
		{
			_customerId  = InternalValidator.CheckUniqueId( customerId ) ;
			_price       = InternalValidator.CheckAmount   ( price      ) ;
		}
	



		public Guid Customer
		{
			get => _customerId;
		}

		public decimal Price
		{
			get => _price;
		}
	}
}
