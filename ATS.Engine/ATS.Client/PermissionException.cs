using System;
using System.Runtime.Serialization;

namespace ATS.Client
{
	[System.Serializable]
	public class PermissionException : Exception
	{
		private readonly Guid _permissionId = Guid.Empty;




		public PermissionException( Guid permissionId ) 
			: this( permissionId , string.Empty ) 
		{
		}

		public PermissionException( Guid permissionId , string message )
			: base( $"Access refused {message}" )
		{
			_permissionId = permissionId;
		}

		protected PermissionException( SerializationInfo info , StreamingContext context ) 
			: base( info , context ) 
		{
		}




		public Guid PermissionId
		{
			get => _permissionId;
		}
	}
}
