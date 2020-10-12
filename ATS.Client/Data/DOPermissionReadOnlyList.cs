using System;
using System.Collections;
using System.Collections.Generic;

namespace ATS.Client.Data
{
	public sealed class DOPermissionReadOnlyList : IEnumerable<DOPermission>
	{
		private readonly DOPermissionList  _collection = null;




		public DOPermissionReadOnlyList( DOPermissionList collection )
		{
			_collection = collection ?? throw new ArgumentNullException( nameof( collection ) );
		}




		public DOPermission this[ int index ]
		{
			get => _collection[ index ];
		}

		public DOPermission this[ Guid uniqueId ]
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

		public ICollection<DOPermission> Values
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

		public IEnumerator<DOPermission> GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		public bool Any()
		{
			return _collection.Any();
		}

		public bool Any( Func<DOPermission , bool> predicate )
		{
			return _collection.Any( predicate );
		}

		public bool ContainsKey( Guid uniqueId )
		{
			return _collection.ContainsKey( uniqueId );
		}

		public bool Contains( DOPermission element )
		{
			return _collection.Contains( element );
		}

		public DOPermission FindById( Guid uniqueId )
		{
			return _collection.FindById( uniqueId );
		}

		public DOPermission FindAt( int index )
		{
			return _collection.FindAt( index );
		}

		public IList<DOPermission> GetAll()
		{
			return _collection.GetAll();
		}

		public IList<DOPermission> GetAll( Func<DOPermission , bool> predicate )
		{
			return _collection.GetAll( predicate );
		}

	}
}
