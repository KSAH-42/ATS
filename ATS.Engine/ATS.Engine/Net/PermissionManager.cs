using System;


namespace ATS.Engine.Net
{
	public class PermissionManager
	{
		private readonly PermissionReadOnlyList _permissions = null;




		public PermissionManager( PermissionReadOnlyList permissions )
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
