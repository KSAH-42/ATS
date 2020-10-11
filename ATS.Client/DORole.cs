using System;

namespace ATS.Client
{
	public sealed class DORole : DOEntity
	{
		private readonly DOPermissionList  _permissions = new DOPermissionList();



		public DORole( Guid uniqueId )
			: base ( uniqueId )
		{
		}




		public override DOEntityType Type
		{
			get => DOEntityType.Role;
		}

		public DOPermissionList Permissions
		{
			get => _permissions;
		}


		public override bool IsDirty 
		{ 
			get => base.IsDirty || _permissions.IsDirty;

			set => base.IsDirty = _permissions.IsDirty = value; 
		}
	}
}
