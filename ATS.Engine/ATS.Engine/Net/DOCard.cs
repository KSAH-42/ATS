using System;

namespace ATS.Engine.Net
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
			set => SetField( ref _number , value ?? string.Empty );
		}

		public string Password
		{
			get => GetField( ref _pincode );
			set => SetField( ref _pincode , value ?? string.Empty );
		}

		public bool IsEnabled
		{
			get => GetField( ref _isEnabled );
			set => SetField( ref _isEnabled , value );
		}

	}
}
