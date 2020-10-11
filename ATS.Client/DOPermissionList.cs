using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Client
{
	public sealed class DOPermissionList : IEnumerable<DOPermission>
	{
		public const int                                  Maximum           = 100000;


		private readonly object                           _lock             = new object();

		private readonly IDictionary<Guid,DOPermission>   _collection       = new Dictionary<Guid,DOPermission>();

		private bool                                      _isDirty          = false;




		public DOPermissionList()
		{
		}


		public DOPermissionList( IEnumerable<DOPermission> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public DOPermission this[ int index ]
		{
			get => FindAt( index );
		}

		public DOPermission this[ Guid uniqueId ]
		{
			get => FindById( uniqueId );
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

		public ICollection<DOPermission> Values
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

		public IEnumerator<DOPermission> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public bool Any()
		{
			lock ( _lock )
			{
				return _collection.Count > 0;
			}
		}

		public bool Any( Func<DOPermission , bool> predicate )
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

		public bool Contains( DOPermission element )
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

		public bool Add( DOPermission element )
		{				
			if ( element == null )
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

				OnChange();

				return true;
			}
		}

		public int AddRange( IEnumerable<DOPermission> elements )
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

					if ( element == null )
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

				if ( results > 0 )
				{
					OnChange();
				}

				return results;
			}
		}

		public DOPermission FindById( Guid uniqueId )
		{
			lock ( _lock )
			{
				if ( _collection.TryGetValue( uniqueId , out DOPermission element ) )
				{
					return element;
				}

				return null;
			}
		}

		public DOPermission FindAt( int index )
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

		public IList<DOPermission> GetAll()
		{
			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null ).ToList();
			}
		}

		public IList<DOPermission> GetAll( Func<DOPermission , bool> predicate )
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
				if ( _collection.Remove( uniqueId ) )
				{
					OnChange();

					return true;
				}

				return false;
			}
		}

		public bool Remove( DOPermission element  )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( _collection.Remove( element.UniqueId ) )
				{
					OnChange();

					return true;
				}

				return false;
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
