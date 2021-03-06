﻿using System;

namespace ATS.Client.Messaging
{
	public sealed class OpenAccountRequest : Request
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly decimal _price       = 0;




		public OpenAccountRequest( Guid customerId , decimal price )
		{
			ValidationHelper.CheckUniqueId( customerId );
			ValidationHelper.CheckAmount( price );

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
