using System;

namespace ATS.Engine.Net
{
	public sealed class Permission
	{
		public static readonly Permission Null = new Permission();





		private readonly Guid   _uniqueId  = Guid.Empty;

		private readonly bool   _isGranted = false;






		private Permission()
		{
		}

		public Permission( Guid uniqueId , bool isGranted )
		{
			if ( uniqueId == Guid.Empty )
			{
				throw new ArgumentException( nameof( uniqueId ) );
			}

			_uniqueId = uniqueId;
			_isGranted= isGranted;
		}



		public Guid UniqueId
		{
			get
			{
				return _uniqueId;
			}
		}

		public bool IsGranted
		{
			get
			{
				return _isGranted;
			}
		}

	}
}
