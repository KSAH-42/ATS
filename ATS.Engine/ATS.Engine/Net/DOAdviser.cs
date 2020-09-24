using System;

namespace ATS.Engine.Net
{
	public sealed class DOAdviser : DOEntity
	{
		private readonly DOPersonalInfos _personalInfos = new DOPersonalInfos();

		private readonly DOCredentials   _credentials   = new DOCredentials();

		private readonly DOUniqueIdList  _customers     = new DOUniqueIdList();




		public DOAdviser( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public override DOEntityTypes EntityType
		{
			get => DOEntityTypes.Adviser;
		}

		public DOPersonalInfos Informations
		{
			get => _personalInfos;
		}

		public DOCredentials Credentials
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
					|| _customers    .IsDirty;
			}

			set
			{
				base.IsDirty            = value;

				_personalInfos .IsDirty = value;
				_customers     .IsDirty = value;
			}
		}

	}
}
