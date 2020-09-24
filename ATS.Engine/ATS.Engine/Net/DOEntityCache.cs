using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Engine.Net
{
	public sealed class DOCache<TDOElement> : IEnumerable<TDOElement> where TDOElement : DORoot
	{
		public const int                                Maximum           = 100000;


		private readonly object                         _lock             = new object();

		private readonly IDictionary<Guid,TDOElement>   _collection       = new Dictionary<Guid,TDOElement>();




		public DOCache()
		{
		}


		public DOCache( IEnumerable<TDOElement> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public TDOElement this[ int index ]
		{
			get => FindAt( index );
		}

		public TDOElement this[ Guid id ]
		{
			get => FindById( id );
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

		public ICollection<TDOElement> Values
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

		public IEnumerator<TDOElement> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public void ForEach( Action<TDOElement> action )
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

		public void ForEach<TItem>( Action<TItem> action ) where TItem : TDOElement
		{
			if ( action == null )
			{
				throw new ArgumentNullException( nameof( action ) );
			}

			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TItem;

					if ( desiredElement != null )
					{
						action( desiredElement );
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

		public bool Any( Func<TDOElement , bool> predicate )
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

		public bool Any<TItem>() where TItem : TDOElement
		{
			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					if ( element is TItem )
					{
						return true;
					}
				}

				return false;
			}
		}

		public bool Any<TItem>( Func<TItem , bool> predicate ) where TItem : TDOElement
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				foreach( var element in _collection.Values )
				{
					var desiredElement = element as TItem;

					if ( null == desiredElement )
					{
						continue;
					}

					if ( predicate( desiredElement ) )
					{
						return true;
					}
				}

				return true;
			}
		}

		public int Count()
		{
			lock ( _lock )
			{
				return _collection.Count;
			}
		}

		public int Count( Func<TDOElement,bool> predicate )
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var element in _collection.Values )
				{
					if ( element == null )
					{
						continue;
					}

					if ( ! predicate( element ) )
					{
						continue;
					}

					++ results;
				}

				return results;
			}
		}

		public int Count<TItem>()
		{
			lock ( _lock )
			{
				int results = 0;

				foreach ( var element in _collection.Values )
				{
					if ( element is TItem )
					{
						++ results;
					}
				}

				return results;
			}
		}

		public int Count<TItem>( Func<TItem , bool> predicate ) where TItem : TDOElement
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TItem;

					if ( desiredElement == null )
					{
						continue;
					}

					if ( ! predicate( desiredElement ) )
					{
						continue;
					}

					++ results;
				}

				return results;
			}
		}

		public bool ContainsKey( Guid id )
		{
			lock ( _lock )
			{
				return _collection.ContainsKey( id );
			}
		}

		public bool Contains( TDOElement element )
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

		public bool Add( TDOElement element )
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

				return true;
			}
		}

		public bool AddOrUpdate( TDOElement element )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( _collection.Count >= Maximum )
				{
					if ( ! _collection.ContainsKey( element.UniqueId ) )
					{
						return false;
					}
				}

				_collection[ element.UniqueId ] = element;

				return true;
			}
		}

		public int AddRange( IEnumerable<TDOElement> elements )
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

					_collection[ element.UniqueId ] = element;

					++ results;
				}

				return results;
			}
		}

		public bool Update( TDOElement element )
		{
			if ( element == null )
			{
				return false;
			}

			lock ( _lock )
			{
				if ( ! _collection.ContainsKey( element.UniqueId ) )
				{
					return false;
				}

				_collection[ element.UniqueId] = element;

				return true;
			}
		}

		public int UpdateRange( IEnumerable<TDOElement> elements )
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
					if ( element == null )
					{
						continue;
					}

					if ( ! _collection.ContainsKey( element.UniqueId ) )
					{
						continue;
					}

					_collection[ element.UniqueId ] = element;

					++ results;
				}

				return results;
			}
		}

		public TDOElement FindById( Guid id )
		{
			lock ( _lock )
			{
				if ( _collection.TryGetValue( id , out TDOElement element ) )
				{
					return element;
				}

				return null;
			}
		}

		public TItem FindById<TItem>( Guid id ) where TItem : TDOElement 
		{
			return FindById( id ) as TItem;
		}

		public TDOElement FindAt( int index )
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

		public TItem FindAt<TItem>( int index ) where TItem : TDOElement
		{
			return FindAt( index ) as TItem;
		}

		public IList<TDOElement> ListAll()
		{
			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null ).ToList();
			}
		}

		public IList<TDOElement> ListAll( Func<TDOElement , bool> predicate )
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

		public IList<TItem> ListAll<TItem>() where TItem : TDOElement
		{
			lock ( _lock )
			{
				var results = new List<TItem>();

				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TItem;

					if ( null != desiredElement )
					{
						results.Add( desiredElement );
					}
				}

				return results;
			}
		}

		public IList<TItem> ListAll<TItem>( Func<TItem,bool> predicate ) where TItem : TDOElement
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				var results = new List<TItem>();

				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TItem;

					if ( null == desiredElement )
					{
						continue;
					}

					if ( ! predicate( desiredElement ) )
					{
						continue;
					}

					results.Add( desiredElement );
				}

				return results;
			}
		}

		public bool Remove( Guid id )
		{
			lock ( _lock )
			{
				return _collection.Remove( id );
			}
		}

		public bool Remove( TDOElement element  )
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

		public int RemoveRange( IEnumerable<Guid> ids )
		{
			if ( ids == null )
			{
				return 0;
			}

			lock ( _lock )
			{
				int results = 0;

				foreach ( var id in ids )
				{
					if ( _collection.Remove( id ) )
					{
						++ results;
					}
				}

				return results;
			}
		}

		public int RemoveRange( IEnumerable<TDOElement> elements )
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
					if ( element == null )
					{
						continue;
					}

					if ( _collection.Remove( element.UniqueId ) )
					{
						++ results;
					}
				}

				return results;
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
