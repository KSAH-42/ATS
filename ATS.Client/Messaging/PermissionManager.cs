using System;


namespace ATS.Client.Messaging
{
	using ATS.Client.Data;

	public class PermissionManager
	{
		private readonly DOPermissionReadOnlyList _permissions = null;




		public PermissionManager( DOPermissionReadOnlyList permissions )
		{
			_permissions = permissions ?? throw new ArgumentNullException( nameof( permissions ) );
		}




		public void CheckPermission( Guid permissionId )
		{
			lock ( _permissions.SyncRoot )
			{
				if ( ! _permissions.ContainsKey( permissionId ) )
				{
					return;
				}
				
				if ( _permissions[ permissionId ].IsGranted )
				{
					return;
				}

				throw new PermissionException( permissionId );
			}
		}

		public bool TryCheckPermission( Guid permissionId )
		{
			lock ( _permissions.SyncRoot )
			{
				if ( _permissions.ContainsKey( permissionId ) )
				{
					return _permissions[ permissionId ].IsGranted;
				}
				
				return false;
			}
		}
		
	}
}
