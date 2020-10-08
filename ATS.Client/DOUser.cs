using System;

namespace ATS.Client
{
	public abstract class DOUser : DOEntity
	{
		private readonly DOPersonalInfos _personalInfos = new DOPersonalInfos();

		private readonly DOAddress       _address       = new DOAddress();

		private readonly DOContacts      _contacts      = new DOContacts();

		private readonly DOCredentials   _credentials   = new DOCredentials();





		protected DOUser( Guid uniqueId )
			: base ( uniqueId )
		{
		}





		public sealed override DOEntityType Type
		{
			get => DOEntityType.User;
		}

		public DOPersonalInfos Informations
		{
			get => _personalInfos;
		}

		public DOContacts Contacts
		{
			get => _contacts;
		}

		public DOAddress Address
		{
			get => _address;
		}

		public DOCredentials Credentials
		{
			get => _credentials;
		}

		public override bool IsDirty
		{
			get
			{
				return base.IsDirty

					|| _personalInfos.IsDirty
					|| _address      .IsDirty
					|| _contacts     .IsDirty
					|| _credentials  .IsDirty;
			}

			set
			{
				base.IsDirty = value;

				_personalInfos.IsDirty = value;
				_address      .IsDirty = value;
				_contacts     .IsDirty = value;
				_credentials  .IsDirty = value;
			}
		}
	}
}
