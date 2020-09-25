using System;

namespace ATS.Engine.Net
{
	public sealed class DOAdviser : DOUser
	{
		private readonly DOPersonalInfos _personalInfos = new DOPersonalInfos();

		private readonly DOContacts      _contacts      = new DOContacts();

		private readonly DOCredentials   _credentials   = new DOCredentials();

		private readonly DOUniqueIdList  _customers     = new DOUniqueIdList();




		public DOAdviser( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public override DOEntityType Type
		{
			get => DOEntityType.Adviser;
		}

		public override DOPersonalInfos Informations
		{
			get => _personalInfos;
		}

		public override DOContacts Contacts
		{
			get => _contacts;
		}

		public override DOCredentials Credentials
		{
			get => _credentials;
		}

		public DOUniqueIdList Customers
		{
			get => _customers;
		}

		public override bool IsDirty
		{
			get
			{
				return base.IsDirty 

					|| _personalInfos.IsDirty
					|| _contacts     .IsDirty
					|| _credentials  .IsDirty
					|| _customers    .IsDirty;
			}

			set
			{
				base.IsDirty            = value;

				_personalInfos .IsDirty = value;
				_contacts      .IsDirty = value;
				_credentials   .IsDirty = value;
				_customers     .IsDirty = value;
			}
		}

	}
}
