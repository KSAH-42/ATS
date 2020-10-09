using System;

namespace ATS.Client
{
	public sealed class DOCard : DOEntity
	{
		private Guid     _customerId    = Guid.Empty;

		private string   _number        = string.Empty;

		private string   _pincode       = string.Empty;

		private bool     _isEnabled     = false;





		public DOCard( Guid uniqueId )
			: base ( uniqueId )
		{
		}




		public override DOEntityType Type
		{
			get => DOEntityType.Card;
		}

		public Guid CustomerId
		{
			get => GetField( ref _customerId );
			set => SetField( ref _customerId , value );
		}

		public string Number
		{
			get => GetField( ref _number );
			set => SetField( ref _number , ValueFilter.ReplaceNull( value ) );
		}

		public string Password
		{
			get => GetField( ref _pincode );
			set => SetField( ref _pincode , ValueFilter.ReplaceNull( value ) );
		}

		public bool IsEnabled
		{
			get => GetField( ref _isEnabled );
			set => SetField( ref _isEnabled , value );
		}

	}
}
