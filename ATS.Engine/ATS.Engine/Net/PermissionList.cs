using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Engine.Net
{
	public sealed class PermissionList : IEnumerable<Permission>
	{
		public const int                                Maximum           = 100000;


		private readonly object                         _lock             = new object();

		private readonly IDictionary<Guid,Permission>   _collection       = new Dictionary<Guid,Permission>();




		public PermissionList()
		{
		}


		public PermissionList( IEnumerable<Permission> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public Permission this[ int index ]
		{
			get => GetAt( index );
		}

		public Permission this[ Guid uniqueId ]
		{
			get => GetById( uniqueId );
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

		public ICollection<Permission> Values
		{
			get
			{
				lock ( _lock )
				{
					return _collection.Values.ToList();
				}
			}
		}

		public ICollection<Guid> Keys
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

		public IEnumerator<Permission> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public void ForEach( Action<Permission> action )
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

		public bool Any( Func<Permission , bool> predicate )
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

		public bool ContainsKey( Guid uniqueId )
		{
			lock ( _lock )
			{
				return _collection.ContainsKey( uniqueId );
			}
		}

		public bool Contains( Permission element )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				return _collection.Values.Contains( element );
			}
		}

		public bool Add( Permission element )
		{				
			if ( element == null || object.ReferenceEquals( element , Permission.Null ) )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( _collection.ContainsKey( element.UniqueId ) )
				{
					return false;
				}

				if ( _collection.Count >= Maximum )
				{
					return false;
				}

				_collection[ element.UniqueId ] = element;

				return true;
			}
		}

		public int AddRange( IEnumerable<Permission> elements )
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

					if ( element == null || object.ReferenceEquals( element , Permission.Null ) )
					{
						continue;
					}

					if ( _collection.ContainsKey( element.UniqueId ) )
					{
						continue;
					}

					_collection[ element.UniqueId] = element;

					++ results;
				}

				return results;
			}
		}

		public Permission GetById( Guid uniqueId )
		{
			return FindById( uniqueId ) ?? Permission.Null;
		}

		public Permission FindById( Guid uniqueId )
		{
			lock ( _lock )
			{
				if ( _collection.TryGetValue( uniqueId , out Permission element ) )
				{
					return element;
				}

				return null;
			}
		}

		public Permission GetAt( int index )
		{
			return FindAt( index ) ?? Permission.Null;
		}

		public Permission FindAt( int index )
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

		public IList<Permission> GetAll()
		{
			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null ).ToList();
			}
		}

		public IList<Permission> GetAll( Func<Permission , bool> predicate )
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

		public bool Remove( Guid uniqueId )
		{
			lock ( _lock )
			{
				return _collection.Remove( uniqueId );
			}
		}

		public bool Remove( Permission element  )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				return _collection.Remove( element.UniqueId );
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
