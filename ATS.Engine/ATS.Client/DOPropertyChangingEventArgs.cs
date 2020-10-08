using System;

namespace ATS.Client
{
	public class DOPropertyChangingEventArgs : EventArgs
	{
		private readonly string _propertyName = string.Empty;

		private readonly object _oldValue     = null;

		private readonly object _newValue     = null;

		private bool            _isCanceled   = false;



		public DOPropertyChangingEventArgs( string propertyName , object oldValue , object newValue )
		{
			if ( string.IsNullOrWhiteSpace( propertyName ) )
			{
				throw new ArgumentNullException( nameof( propertyName ) );
			}

			_propertyName = propertyName;
			_oldValue     = oldValue;
			_newValue     = newValue;
		}

		


		public string PropertyName
		{
			get => _propertyName;
		}

		public object OldValue
		{
			get => _oldValue;
		}

		public object NewValue
		{
			get => _newValue;
		}

		public bool IsCancelled
		{
			get => _isCanceled;
			set => _isCanceled = value;
		}
	}
}
