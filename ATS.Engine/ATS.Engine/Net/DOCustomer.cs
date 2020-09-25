﻿using System;

namespace ATS.Engine.Net
{
	public sealed class DOCustomer : DOUser
	{
		private readonly DOUniqueIdList  _accounts      = new DOUniqueIdList();

		private readonly DOUniqueIdList  _cards         = new DOUniqueIdList();





		public DOCustomer( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public override DOEntityType Type
		{
			get => DOEntityType.Customer;
		}

		public DOUniqueIdList Accounts
		{
			get => _accounts;
		}

		public DOUniqueIdList Cards
		{
			get => _cards;
		}

		public override bool IsDirty
		{
			get
			{
				return base.IsDirty 

					|| _accounts     .IsDirty
					|| _cards        .IsDirty;
			}

			set
			{
				base.IsDirty            = value;

				_accounts      .IsDirty = value;
				_cards         .IsDirty = value;
			}
		}

	}
}
