using System;
using System.Collections;
using System.Collections.Generic;

namespace ATS.Engine.Net
{
	public sealed class DOReadOnlyCache<TDOElement> : IEnumerable<TDOElement>  where TDOElement : DORoot
	{
		private readonly DOCache<TDOElement> _cache = null;




		public DOReadOnlyCache()
		{
		}


		public DOReadOnlyCache( DOCache<TDOElement> cache )
		{
			_cache = cache ?? throw new ArgumentNullException( nameof( cache ) ); ;
		}




		public TDOElement this[ int index ]
		{
			get => _cache.FindAt( index );
		}

		public TDOElement this[ Guid id ]
		{
			get => _cache.FindById( id );
		}





		public object SyncRoot
		{
			get => _cache.SyncRoot;
		}

		public bool IsEmpty
		{
			get
			{
				return _cache.IsEmpty;
			}
		}

		public ICollection<TDOElement> Values
		{
			get
			{
				return _cache.Values;
			}
		}

		public ICollection<Guid> Keys
		{
			get
			{
				return _cache.Keys;
			}
		}




		IEnumerator IEnumerable.GetEnumerator()
		{
			return _cache.GetEnumerator();
		}

		public IEnumerator<TDOElement> GetEnumerator()
		{
			return _cache.GetEnumerator();
		}

		public void ForEach( Action<TDOElement> action )
		{
			_cache.ForEach( action );
		}

		public void ForEach<TItem>( Action<TItem> action ) 
			where TItem : TDOElement
		{
			_cache.ForEach<TItem>( action );
		}

		public bool Any()
		{
			return _cache.Any();
		}

		public bool Any( Func<TDOElement , bool> predicate )
		{
			return _cache.Any( predicate );
		}

		public bool Any<TItem>() where TItem : TDOElement
		{
			return _cache.Any<TItem>();
		}

		public bool Any<TItem>( Func<TItem , bool> predicate ) where TItem : TDOElement
		{
			return _cache.Any<TItem>( predicate );
		}

		public int Count()
		{
			return _cache.Count();
		}

		public int Count( Func<TDOElement,bool> predicate )
		{
			return _cache.Count( predicate );
		}

		public int Count<TItem>()
		{
			return _cache.Count<TItem>();
		}

		public int Count<TItem>( Func<TItem , bool> predicate ) where TItem : TDOElement
		{
			return _cache.Count<TItem>( predicate );
		}

		public bool ContainsKey( Guid id )
		{
			return _cache.ContainsKey( id );
		}

		public bool Contains( TDOElement element )
		{
			return _cache.Contains( element );
		}

		public TDOElement FindFirst()
		{
			return _cache.FindFirst();
		}

		public TItem FindFirst<TItem>() where TItem : TDOElement
		{
			return _cache.FindFirst<TItem>();
		}

		public TDOElement FindFirst( Func<TDOElement,bool> predicate )
		{
			return _cache.FindFirst( predicate );
		}

		public TItem FindFirst<TItem>( Func<TItem , bool> predicate ) where TItem : TDOElement
		{
			return _cache.FindFirst( predicate );
		}

		public TDOElement FindById( Guid id )
		{
			return _cache.FindById( id );
		}

		public TItem FindById<TItem>( Guid id ) where TItem : TDOElement 
		{
			return _cache.FindById<TItem>( id );
		}

		public TDOElement FindAt( int index )
		{
			return _cache.FindAt( index );
		}

		public TItem FindAt<TItem>( int index ) where TItem : TDOElement
		{
			return _cache.FindAt<TItem>( index );
		}

		public IList<TDOElement> ListAll()
		{
			return _cache.ListAll();
		}

		public IList<TDOElement> ListAll( Func<TDOElement , bool> predicate )
		{
			return _cache.ListAll( predicate );
		}

		public IList<TItem> ListAll<TItem>() where TItem : TDOElement
		{
			return _cache.ListAll<TItem>();
		}

		public IList<TItem> ListAll<TItem>( Func<TItem,bool> predicate ) where TItem : TDOElement
		{
			return _cache.ListAll<TItem>( predicate );
		}
	}
}
