using System;

namespace ATS.Client
{
	public sealed class DOTransaction : DORoot
	{
		private readonly Guid     _uniqueId         = Guid.Empty;

		private DateTime          _timestamp        = DateTime.MinValue;

		private Guid              _applicationId    = Guid.Empty;

		private Guid              _customerId       = Guid.Empty;

		private int               _type             = 0;

		private decimal           _amount           = 0;

		private decimal           _balance          = 0;







		public DOTransaction( Guid uniqueId )
		{
			_uniqueId = uniqueId;
		}






		public override Guid UniqueId
		{
			get => _uniqueId;
		}

		public DateTime TimeStamp
		{
			get => GetField( ref _timestamp );
			set => SetField( ref _timestamp , value );
		}

		public Guid ApplicationId
		{
			get => GetField( ref _applicationId );
			set => SetField( ref _applicationId , value );
		}

		public Guid CustomerId
		{
			get => GetField( ref _customerId );
			set => SetField( ref _customerId , value );
		}

		public int Type
		{
			get => GetField( ref _type );
			set => SetField( ref _type , value );
		}

		public decimal Amount
		{
			get => GetField( ref _amount );
			set => SetField( ref _amount , value );
		}

		public decimal Balance
		{
			get => GetField( ref _balance );
			set => SetField( ref _balance , value );
		}

	}
}
