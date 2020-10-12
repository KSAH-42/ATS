using System;
using System.Threading;

namespace ATS.Client.Threading
{
	public sealed class Worker
	{
		private readonly Action _routine         = null;

		private Thread          _thread          = null;

		private EventWaitHandle _stopEventHandle = null;

		private Exception       _exception       = null;






		public Worker( Action routine )
		{
			_routine = routine ?? throw new ArgumentNullException( nameof( routine ) );
		}






		public Exception Exception
		{
			get => _exception;
		}

		public bool IsStarted
		{
			get => _thread != null;
		}







		public void Start()
		{
			if ( this._thread != null || this._stopEventHandle != null )
			{
				throw new InvalidOperationException( "the thread is already started" );
			}

			_exception = null;
			
			var handle = new EventWaitHandle( false , EventResetMode.ManualReset );

			var thread = new Thread( new ThreadStart( this.Execute ) )
			{
				Name         = "Client worker",
				IsBackground = true
			};

			this._thread         = thread;
			this._stopEventHandle = handle;

			thread.Start();
		}

		public void Stop()
		{
			if ( this._stopEventHandle != null )
			{
				this._stopEventHandle.Set();
			}

			if ( this._thread != null )
			{
				this._thread.Join();
				this._thread = null;
			}

			if ( this._stopEventHandle != null )
			{
				this._stopEventHandle.Close();
				this._stopEventHandle = null;
			}
		}

		public bool CanContinue( int timeout )
		{
			var handle = this._stopEventHandle;

			return handle != null ? ! handle.WaitOne( timeout ) : false;
		}








		private void Execute()
		{
			try
			{
				_routine.Invoke();
			}
			catch ( Exception ex )
			{
				_exception = ex;
			}
		}
	}
}
