using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Client
{
	public sealed class DOUniqueIdList : IEnumerable<Guid>
	{
		public const int              Maximum           = 100000;


		private readonly object       _lock             = new object();

		private readonly ISet<Guid>   _collection       = new HashSet<Guid>();

		private bool                  _isDirty          = false;



		public DOUniqueIdList()
		{
		}


		public DOUniqueIdList( IEnumerable<Guid> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public Guid this[ int index ]
		{
			get => GetAt( index );
		}









		public object SyncRoot
		{
			get => _lock;
		}

		public bool IsDirty
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

		public bool IsEmpty
		{
			get
			{
				lock ( _lock )
				{
					return _collection.Count <= 0;
				}
			}
		}

		public int Count
		{
			get
			{
				lock ( _lock )
				{
					return _collection.Count;
				}
			}
		}







		IEnumerator IEnumerable.GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.ToList().GetEnumerator();
			}
		}

		public IEnumerator<Guid> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.ToList().GetEnumerator();
			}
		}

		public void ForEach( Action<Guid> action )
		{
			if ( action == null )
			{
				throw new ArgumentNullException( nameof( action ) );
			}

			lock ( _lock )
			{
				foreach ( var element in _collection )
				{
					if ( element != null )
					{
						action( element );
					}
				}
			}
		}

		public bool Any()
		{
			lock ( _lock )
			{
				return _collection.Count > 0;
			}
		}

		public bool Any( Func<Guid, bool> predicate )
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				return _collection.Any( predicate );
			}
		}

		public bool Contains( Guid value )
		{
			lock ( _lock )
			{
				return _collection.Contains( value );
			}
		}

		public bool Add( Guid value )
		{
			if ( value == Guid.Empty )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( ! _collection.Add( value ) )
				{
					return false;
				}

				OnChange();

				return true;
			}
		}

		public int AddRange( IEnumerable<Guid> values )
		{
			if ( values == null )
			{
				return 0;
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var value in values )
				{
					if ( _collection.Count >= Maximum )
					{
						break;
					}

					if ( value == Guid.Empty )
					{
						continue;
					}

					if ( _collection.Add( value ) )
					{
						++ results;
					}
				}

				if ( 0 < results )
				{
					OnChange();
				}

				return results;
			}
		}

		public Guid GetAt( int index )
		{
			lock ( _lock )
			{
				if ( index < 0 || index >= _collection.Count )
				{
					return Guid.Empty;
				}

				return _collection.ElementAt( index );
			}
		}

		public IList<Guid> GetAll()
		{
			lock ( _lock )
			{
				return _collection.ToList();
			}
		}

		public bool Remove( Guid value )
		{
			lock ( _lock )
			{
				if ( ! _collection.Remove( value ) )
				{
					return false;
				}

				OnChange();

				return true;
			}
		}

		public bool RemoveAt( int index )
		{
			lock ( _lock )
			{
				if ( index < 0 || index >= _collection.Count )
				{
					return false;
				}

				if ( ! _collection.Remove( _collection.ElementAt( index ) ) )
				{
					return false;
				}

				OnChange();

				return true;
			}
		}

		public int RemoveRange( IEnumerable<Guid> values )
		{
			if ( values == null )
			{
				return 0;
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var value in values )
				{
					if ( _collection.Remove( value ) )
					{
						++ results;
					}
				}

				if ( 0 < results )
				{
					OnChange();
				}

				return results;
			}
		}

		public void Clear()
		{
			lock ( _lock )
			{
				if ( _collection.Count > 0 )
				{
					_collection.Clear();

					OnChange();
				}
			}
		}








		private void OnChange()
		{
			lock ( _lock )
			{
				_isDirty = true;
			}
		}
	}
}
