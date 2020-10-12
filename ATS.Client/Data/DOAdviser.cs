using System;

namespace ATS.Client.Data
{
	public sealed class DOAdviser : DOUser
	{
		private readonly DOUniqueIdList  _customers = new DOUniqueIdList();




		public DOAdviser( Guid uniqueId )
			: base ( uniqueId )
		{
		}



		public DOUniqueIdList Customers
		{
			get => _customers;
		}

		public override bool IsDirty
		{
			get
			{
				return base.IsDirty || _customers.IsDirty;
			}

			set
			{
				base.IsDirty       = value;

				_customers.IsDirty = value;
			}
		}

	}
}
