using System;

namespace ATS.Client
{
	public abstract class DOEntity : DORoot
	{
		private readonly Guid     _uniqueId         = Guid.Empty;

		private DateTime          _creationTime     = DateTime.MinValue;

		private DateTime          _modificationTime = DateTime.MinValue;

		private string            _name             = string.Empty;

		private string            _description      = string.Empty;

		private string            _comments         = string.Empty;

		private int               _subType          = 0;





		protected DOEntity( Guid uniqueId )
		{
			_uniqueId = uniqueId;
		}




		public abstract DOEntityType Type
		{
			get;
		}

		public override Guid UniqueId
		{
			get => _uniqueId;
		}

		public DateTime CreationTime
		{
			get => GetField( ref _creationTime );
			set => SetField( ref _creationTime , value );
		}

		public DateTime ModificationTime
		{
			get => GetField( ref _modificationTime );
			set => SetField( ref _modificationTime , value );
		}

		public string Name
		{
			get => GetField( ref _name );
			set => SetField( ref _name , ValueFilter.Filter( value ) );
		}

		public string Description
		{
			get => GetField( ref _description );
			set => SetField( ref _description , ValueFilter.Filter( value ) );
		}

		public string Comments
		{
			get => GetField( ref _comments );
			set => SetField( ref _comments , ValueFilter.Filter( value ) );
		}

		public int SubType
		{
			get => GetField( ref _subType );
			set => SetField( ref _subType , value );
		}


	}
}
