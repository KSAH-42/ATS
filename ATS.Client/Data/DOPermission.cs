using System;

namespace ATS.Client.Data
{
	public sealed class DOPermission : DORoot
	{
		private readonly Guid  _uniqueId  = Guid.Empty;

		private bool           _isGranted = false;






		public DOPermission( Guid uniqueId )
		{
			_uniqueId = uniqueId;
		}






		public Guid UniqueId
		{
			get => _uniqueId;
		}

		public bool IsGranted
		{
			get => GetField( ref _isGranted );
			set => SetField( ref _isGranted , value );
		}

	}
}
