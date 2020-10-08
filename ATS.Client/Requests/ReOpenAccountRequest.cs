﻿using System;

namespace ATS.Client.Requests
{
	public sealed class ReOpenAccountRequest : BaseRequest
	{
		private readonly Guid    _customerId  = Guid.Empty;

		private readonly Guid    _accountId   = Guid.Empty;




		public ReOpenAccountRequest( Guid customerId , Guid accountId )
		{
			InternalValidator.CheckUniqueId( customerId , accountId );

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