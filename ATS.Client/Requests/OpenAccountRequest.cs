using System;

namespace ATS.Client.Requests
{
	public sealed class OpenAccountRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly decimal _price       = 0;




		public OpenAccountRequest( Guid customerId , decimal price )
		{
			InternalValidator.CheckUniqueId( customerId );
			InternalValidator.CheckAmount( price );

			_customerId  = customerId ;
			_price       = price      ;
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
