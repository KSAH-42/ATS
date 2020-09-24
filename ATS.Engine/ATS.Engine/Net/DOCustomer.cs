using System;

namespace ATS.Engine.Net
{
	public sealed class DOCustomer : DOEntity
	{
		private readonly DOPersonalInfos _personalInfos = new DOPersonalInfos();

		private readonly DOAddress       _address       = new DOAddress();

		private readonly DOContacts      _contacts      = new DOContacts();

		private readonly DOCredentials   _credentials   = new DOCredentials();

		private readonly DOUniqueIdList  _accounts      = new DOUniqueIdList();

		private readonly DOUniqueIdList  _cards         = new DOUniqueIdList();





		public DOCustomer( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public override DOEntityTypes EntityType
		{
			get => DOEntityTypes.Customer;
		}

		public DOPersonalInfos Informations
		{
			get => _personalInfos;
		}

		public DOAddress Address
		{
			get => _address;
		}

		public DOContacts Contacts
		{
			get => _contacts;
		}

		public DOCredentials Credentials
		{
			get => _credentials;
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

					|| _personalInfos.IsDirty 
					|| _address      .IsDirty 
					|| _contacts     .IsDirty 
					|| _credentials  .IsDirty
					|| _accounts     .IsDirty
					|| _cards        .IsDirty;
			}

			set
			{
				base.IsDirty            = value;

				_personalInfos .IsDirty = value;
				_address       .IsDirty = value;
				_contacts      .IsDirty = value;
				_credentials   .IsDirty = value;
				_accounts      .IsDirty = value;
				_cards         .IsDirty = value;
			}
		}

	}
}
