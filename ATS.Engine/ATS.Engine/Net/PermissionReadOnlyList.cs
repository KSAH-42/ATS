using System;
using System.Collections;
using System.Collections.Generic;

namespace ATS.Engine.Net
{
	public sealed class PermissionReadOnlyList : IEnumerable<Permission>
	{
		private readonly PermissionList  _collection = null;




		public PermissionReadOnlyList( PermissionList collection )
		{
			_collection = collection ?? throw new ArgumentNullException( nameof( collection ) );
		}




		public Permission this[ int index ]
		{
			get => _collection[ index ];
		}

		public Permission this[ Guid uniqueId ]
		{
			get => _collection[ uniqueId ];
		}








		public object SyncRoot
		{
			get => _collection.SyncRoot;
		}

		public bool IsEmpty
		{
			get => _collection.IsEmpty;
		}

		public int Count
		{
			get => _collection.Count;
		}

		public ICollection<Permission> Values
		{
			get => _collection.Values;
		}

		public ICollection<Guid> Keys
		{
			get => _collection.Keys;
		}








		IEnumerator IEnumerable.GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		public IEnumerator<Permission> GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		public void ForEach( Action<Permission> action )
		{
			_collection.ForEach( action );
		}

		public bool Any()
		{
			return _collection.Any();
		}

		public bool Any( Func<Permission , bool> predicate )
		{
			return _collection.Any( predicate );
		}

		public bool ContainsKey( Guid uniqueId )
		{
			return _collection.ContainsKey( uniqueId );
		}

		public bool Contains( Permission element )
		{
			return _collection.Contains( element );
		}

		public Permission GetById( Guid uniqueId )
		{
			return _collection.GetById( uniqueId );
		}

		public Permission FindById( Guid uniqueId )
		{
			return _collection.FindById( uniqueId );
		}

		public Permission GetAt( int index )
		{
			return _collection.GetAt( index );
		}

		public Permission FindAt( int index )
		{
			return _collection.FindAt( index );
		}

		public IList<Permission> GetAll()
		{
			return _collection.GetAll();
		}

		public IList<Permission> GetAll( Func<Permission , bool> predicate )
		{
			return _collection.GetAll( predicate );
		}

	}
}
