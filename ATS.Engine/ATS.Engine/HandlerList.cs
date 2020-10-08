using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Client
{
	using ATS.Client.Handlers;

	public sealed class HandlerList : IEnumerable<IHandler>
	{
		public const int                              Maximum           = 100000;


		private readonly object                       _lock             = new object();

		private readonly IDictionary<string,IHandler> _collection       = new Dictionary<string,IHandler>();




		public HandlerList()
		{
		}


		public HandlerList( IEnumerable<IHandler> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public IHandler this[ int index ]
		{
			get => GetAt( index );
		}

		public IHandler this[ string typeId ]
		{
			get => GetByType( typeId );
		}








		public object SyncRoot
		{
			get => _lock;
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

		public ICollection<IHandler> Values
		{
			get
			{
				lock ( _lock )
				{
					return _collection.Values.ToList();
				}
			}
		}

		public ICollection<string> Keys
		{
			get
			{
				lock ( _lock )
				{
					return _collection.Keys.ToList();
				}
			}
		}








		IEnumerator IEnumerable.GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public IEnumerator<IHandler> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public void ForEach( Action<IHandler> action )
		{
			if ( action == null )
			{
				throw new ArgumentNullException( nameof( action ) );
			}

			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
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

		public bool Any( Func<IHandler , bool> predicate )
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				return _collection.Values.Any( predicate );
			}
		}

		public bool ContainsKey( string typeId )
		{
			lock ( _lock )
			{
				return _collection.ContainsKey( typeId ?? string.Empty );
			}
		}

		public bool Contains( IHandler handler )
		{
			if ( handler == null )
			{
				return false;
			}

			lock ( _lock )
			{
				return _collection.Values.Contains( handler );
			}
		}

		public bool Add( IHandler element )
		{
			if ( element == null || object.ReferenceEquals( element , Handler.Null ) )
			{
				return false;
			}

			if ( string.IsNullOrWhiteSpace( element.TypeId ) )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( _collection.ContainsKey( element.TypeId ) )
				{
					return false;
				}

				if ( _collection.Count >= Maximum )
				{
					return false;
				}

				_collection[ element.TypeId ] = element;

				return true;
			}
		}

		public int AddRange( IEnumerable<IHandler> elements )
		{
			if ( elements == null )
			{
				return 0;
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var element in elements )
				{
					if ( _collection.Count >= Maximum )
					{
						break;
					}

					if ( element == null || object.ReferenceEquals( element , Handler.Null ) )
					{
						continue;
					}

					if ( string.IsNullOrWhiteSpace( element.TypeId ) )
					{
						continue;
					}

					if ( _collection.ContainsKey( element.TypeId ) )
					{
						continue;
					}

					_collection[ element.TypeId] = element;

					++ results;
				}

				return results;
			}
		}

		public IHandler GetByType( string typeId )
		{
			return FindByType( typeId ) ?? Handler.Null;
		}

		public IHandler FindByType( string typeId )
		{
			lock ( _lock )
			{
				if ( _collection.TryGetValue( typeId ?? string.Empty , out IHandler element ) )
				{
					return element;
				}

				return null;
			}
		}

		public IHandler GetAt( int index )
		{
			return FindAt( index ) ?? Handler.Null;
		}

		public IHandler FindAt( int index )
		{
			lock ( _lock )
			{
				if ( index < 0 || index >= _collection.Count )
				{
					return null;
				}

				return _collection.ElementAt( index ).Value;
			}
		}

		public IList<IHandler> GetAll()
		{
			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null ).ToList();
			}
		}

		public IList<IHandler> GetAll( Func<IHandler , bool> predicate )
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null && predicate( element ) ).ToList();
			}
		}

		public bool Remove( string typeId )
		{
			lock ( _lock )
			{
				return _collection.Remove( typeId ?? string.Empty );
			}
		}

		public bool Remove( IHandler element  )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				return _collection.Remove( element.TypeId ?? string.Empty );
			}
		}

		public void Clear()
		{
			lock ( _lock )
			{
				_collection.Clear();
			}
		}
	}
}
