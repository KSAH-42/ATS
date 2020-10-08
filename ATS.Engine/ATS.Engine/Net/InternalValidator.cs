using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net
{
	internal static class InternalValidator
	{
		public static void CheckUniqueId( Guid uniqueId )
		{
			if ( uniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}
		}

		public static void CheckUniqueId( params Guid[] ids )
		{
			if ( null == ids || 0 >= ids.Length )
			{
				throw new ValidationException();
			}
			
			if ( ids.Any( element => element == Guid.Empty ) )
			{
				throw new ValidationException();
			}
		}

		public static void CheckAmount( decimal price )
		{
			if ( price <= 0 )
			{
				throw new ValidationException();
			}
		}

		public static void CheckLogin( string loginId )
		{
			if ( string.IsNullOrWhiteSpace( loginId ) )
			{
				throw new ValidationException();
			}
		}

		public static void CheckTime( DateTime time )
		{
			if ( time == DateTime.MinValue || time == DateTime.MaxValue )
			{
				throw new ValidationException();
			}
		}

		public static void CheckSearchParameters( DateTime startTime , DateTime endTime , int maxHits )
		{
			if ( startTime == DateTime.MinValue || startTime == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			if ( endTime == DateTime.MinValue || endTime == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			if ( startTime >= endTime )
			{
				throw new ValidationException();
			}

			if ( ! (( 0 < maxHits ) && ( maxHits <= 10000 )) )
			{
				throw new ValidationException();
			}
		}

		public static void CheckCollection<TElement>( IEnumerable<TElement> elements )
		{
			if ( elements == null || ! elements.Any() )
			{
				throw new ValidationException();
			}
		}

		public static void CheckCollection<TElement>( IReadOnlyCollection<TElement> elements )
		{
			if ( elements == null || elements.Count == 0 )
			{
				throw new ValidationException();
			}
		}




		//---------------------------------------------------------------------------------------------------------------------------------------------------



		public static void CheckEntity( DOEntity entity )
		{
			if ( null == entity )
			{
				throw new ValidationException();
			}

			if ( entity.UniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( entity.CreationTime == DateTime.MinValue || entity.CreationTime == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			if ( entity.ModificationTime == DateTime.MinValue || entity.ModificationTime == DateTime.MaxValue )
			{
				throw new ValidationException();
			}
		}
		
		public static void CheckTransaction( DOTransaction transaction )
		{
			if ( null == transaction )
			{
				throw new ValidationException();
			}

			if ( transaction.UniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( transaction.ApplicationId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( transaction.Type <= 0 )
			{
				throw new ValidationException();
			}

			if ( transaction.TimeStamp == DateTime.MinValue || transaction.TimeStamp == DateTime.MaxValue )
			{
				throw new ValidationException();
			}
		}

		public static void CheckEvent( DOEvent @event )
		{
			if ( null == @event )
			{
				throw new ValidationException();
			}

			if ( @event.UniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( @event.ApplicationId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( @event.Type <= 0 )
			{
				throw new ValidationException();
			}

			if ( @event.TimeStamp == DateTime.MinValue || @event.TimeStamp == DateTime.MaxValue )
			{
				throw new ValidationException();
			}
		}

	}
}
