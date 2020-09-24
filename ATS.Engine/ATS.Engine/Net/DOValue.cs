using System;
using System.Runtime.CompilerServices;

namespace ATS.Engine.Net
{
	/// <summary>
	/// It's just represent the base class for a value object
	/// </summary>
	public class DOValue
	{
		public event EventHandler<DOPropertyChangedEventArgs>   Changed   = delegate {};

		public event EventHandler<DOPropertyChangingEventArgs>  Changing  = delegate {};



		private readonly object        _lock         = new object();

		private bool                   _isDirty      = false;



		protected DOValue()
		{
		}



		public object SyncRoot
		{
			get => _lock;
		}

		public virtual bool IsDirty
		{
			get
			{
				lock ( _lock )
				{
					return _isDirty;
				}
			}

			set
			{
				lock ( _lock )
				{
					_isDirty = value;
				}
			}
		}






		protected TValue GetField<TValue>( ref TValue memberValue , [CallerMemberName] string propertyName = null )
		{
			if ( string.IsNullOrWhiteSpace( propertyName ) )
			{
				throw new ArgumentNullException( nameof( propertyName ) );
			}

			lock ( _lock )
			{
				return memberValue;
			}
		}

		protected void SetField<TValue>( ref TValue memberValue , TValue value , [CallerMemberName] string propertyName = null )
		{
			if ( string.IsNullOrWhiteSpace( propertyName ) )
			{
				throw new ArgumentNullException( nameof( propertyName ) );
			}

			if ( ! OnPropertyChanging( new DOPropertyChangingEventArgs( propertyName , memberValue , value ) ) )
			{
				return;
			}

			lock ( _lock )
			{
				if ( value is ValueType )
				{
					if ( memberValue.Equals( value ) )
					{
						return;
					}
				}
				else
				{
					if ( object.ReferenceEquals( memberValue , value ) )
					{
						return;
					}

					if ( memberValue != null && memberValue.Equals( value ) )
					{
						return;
					}
				}

				memberValue = value;
				_isDirty    = true;
			}

			OnPropertyChanged( new DOPropertyChangedEventArgs( propertyName , memberValue , value ) );
		}







		protected virtual bool OnPropertyChanging( DOPropertyChangingEventArgs e )
		{
			if ( e == null )
			{
				return false;
			}

			try
			{
				var handler = Changing;

				if ( handler != null )
				{
					handler.Invoke( this , e );
				}

				return ! e.IsCancelled;
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}

			return false;
		}

		protected virtual void OnPropertyChanged( DOPropertyChangedEventArgs e )
		{
			if ( e == null )
			{
				return;
			}

			try
			{
				var handler = Changed;

				if ( handler != null )
				{
					handler.Invoke( this , e );
				}
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}
	}
}
