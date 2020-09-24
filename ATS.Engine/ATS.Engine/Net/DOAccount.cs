using System;

namespace ATS.Engine.Net
{
	public sealed class DOAccount : DOEntity
	{
		private Guid     _customerId    = Guid.Empty;

		private decimal  _balance       = 0;

		private bool     _isOpened      = false;





		public DOAccount( Guid uniqueId )
			: base ( uniqueId )
		{
		}




		public override DOEntityTypes EntityType
		{
			get => DOEntityTypes.Account;
		}

		public Guid CustomerId
		{
			get => GetField( ref _customerId );
			set => SetField( ref _customerId , value );
		}

		public decimal Balance
		{
			get => GetField( ref _balance );
			set => SetField( ref _balance , value );
		}

		public bool IsOpened
		{
			get => GetField( ref _isOpened );
			set => SetField( ref _isOpened , value );
		}


	}
}
