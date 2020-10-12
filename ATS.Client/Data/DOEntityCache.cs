using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ATS.Client.Data
{
	public sealed class DOEntityCache : IEnumerable<DOEntity>
	{
		public const int                                Maximum           = 100000;


		private readonly object                         _lock             = new object();

		private readonly IDictionary<Guid,DOEntity>    _collection       = new Dictionary<Guid,DOEntity>();




		public DOEntityCache()
		{
		}


		public DOEntityCache( IEnumerable<DOEntity> elements )
		{
			if ( elements == null )
			{
				throw new ArgumentNullException( nameof( elements ) );
			}

			AddRange( elements );
		}




		public DOEntity this[ int index ]
		{
			get => FindAt( index );
		}

		public DOEntity this[ Guid id ]
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

		public ICollection<DOEntity> Values
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

		public IEnumerator<DOEntity> GetEnumerator()
		{
			lock ( _lock )
			{
				return _collection.Values.ToList().GetEnumerator();
			}
		}

		public void ForEach( Action<DOEntity> action )
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

		public void ForEach<TEntity>( Action<TEntity> action ) where TEntity : DOEntity
		{
			if ( action == null )
			{
				throw new ArgumentNullException( nameof( action ) );
			}

			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TEntity;

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

		public bool Any( Func<DOEntity , bool> predicate )
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

		public bool Any<TEntity>() where TEntity : DOEntity
		{
			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					if ( element is TEntity )
					{
						return true;
					}
				}

				return false;
			}
		}

		public bool Any<TEntity>( Func<TEntity , bool> predicate ) where TEntity : DOEntity
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				foreach( var element in _collection.Values )
				{
					var desiredElement = element as TEntity;

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

		public int Count( Func<DOEntity,bool> predicate )
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

		public int Count<TEntity>()
		{
			lock ( _lock )
			{
				int results = 0;

				foreach ( var element in _collection.Values )
				{
					if ( element is TEntity )
					{
						++ results;
					}
				}

				return results;
			}
		}

		public int Count<TEntity>( Func<TEntity , bool> predicate ) where TEntity : DOEntity
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
					var desiredElement = element as TEntity;

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

		public bool Contains( DOEntity element )
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

		public bool Add( DOEntity element )
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

		public bool AddOrUpdate( DOEntity element )
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

		public int AddRange( IEnumerable<DOEntity> elements )
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

		public bool Update( DOEntity element )
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

		public int UpdateRange( IEnumerable<DOEntity> elements )
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

		public DOEntity FindFirst()
		{
			lock ( _lock )
			{
				return _collection.Values.FirstOrDefault();
			}
		}

		public TEntity FindFirst<TEntity>() where TEntity : DOEntity
		{
			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					if ( element is TEntity )
					{
						return element as TEntity;
					}
				}

				return null;
			}
		}

		public DOEntity FindFirst( Func<DOEntity,bool> predicate )
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				return _collection.Values.FirstOrDefault( predicate );
			}
		}

		public TEntity FindFirst<TEntity>( Func<TEntity , bool> predicate ) where TEntity : DOEntity
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TEntity;

					if ( null == desiredElement )
					{
						continue;
					}

					if ( predicate.Invoke( desiredElement ) )
					{
						return desiredElement;
					}
				}

				return null;
			}
		}

		public DOEntity FindById( Guid id )
		{
			lock ( _lock )
			{
				if ( _collection.TryGetValue( id , out DOEntity element ) )
				{
					return element;
				}

				return null;
			}
		}

		public TEntity FindById<TEntity>( Guid id ) where TEntity : DOEntity 
		{
			return FindById( id ) as TEntity;
		}

		public DOEntity FindAt( int index )
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

		public TEntity FindAt<TEntity>( int index ) where TEntity : DOEntity
		{
			return FindAt( index ) as TEntity;
		}

		public IList<DOEntity> ListAll()
		{
			lock ( _lock )
			{
				return _collection.Values.Where( ( element ) => element != null ).ToList();
			}
		}

		public IList<DOEntity> ListAll( Func<DOEntity , bool> predicate )
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

		public IList<TEntity> ListAll<TEntity>() where TEntity : DOEntity
		{
			lock ( _lock )
			{
				var results = new List<TEntity>();

				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TEntity;

					if ( null != desiredElement )
					{
						results.Add( desiredElement );
					}
				}

				return results;
			}
		}

		public IList<TEntity> ListAll<TEntity>( Func<TEntity,bool> predicate ) where TEntity : DOEntity
		{
			if ( predicate == null )
			{
				throw new ArgumentNullException( nameof( predicate ) );
			}

			lock ( _lock )
			{
				var results = new List<TEntity>();

				foreach ( var element in _collection.Values )
				{
					var desiredElement = element as TEntity;

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

		public bool Remove( DOEntity element  )
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

		public int RemoveRange( IEnumerable<DOEntity> elements )
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
