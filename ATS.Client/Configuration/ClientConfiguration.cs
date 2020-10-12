using System;
using System.Runtime.CompilerServices;

namespace ATS.Client.Configuration
{
	public abstract class ClientConfiguration : IClientConfiguration
	{
		public event EventHandler<ConfigurationPropertyChangedEventArgs>  Changed = delegate{ };




		private readonly object _lock = new object();





		public object SyncRoot
		{
			get => _lock;
		}

		public abstract string Server
		{
			get;
			set;
		}

		public abstract TimeSpan Timeout
		{
			get;
			set;
		}






		public abstract void Validate();







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

			lock ( _lock )
			{
				memberValue = value;
			}

			OnChanged( new ConfigurationPropertyChangedEventArgs( propertyName , value ) );
		}









		protected virtual void OnChanged( ConfigurationPropertyChangedEventArgs e )
		{
			if ( e == null )
			{
				throw new ArgumentNullException( nameof( e ) );
			}

			try
			{
				var handler = Changed;

				handler?.Invoke( this , e );
			}
			catch ( Exception ex )
			{
				System.Diagnostics.Debug.WriteLine( ex );
			}
		}
	}
}
