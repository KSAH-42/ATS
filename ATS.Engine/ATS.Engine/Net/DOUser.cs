using System;

namespace ATS.Engine.Net
{
	public abstract class DOUser : DOEntity
	{
		protected DOUser( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public abstract DOPersonalInfos Informations
		{
			get;
		}

		public abstract DOContacts Contacts
		{
			get;
		}

		public abstract DOCredentials Credentials
		{
			get;
		}

	}
}
