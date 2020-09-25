using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net
{
	internal static class InternalValidator
	{
		public static Guid CheckUniqueId( Guid uniqueId )
		{
			if ( uniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			return uniqueId;
		}

		public static decimal CheckAmount( decimal price )
		{
			if ( price >= 0 )
			{
				throw new ValidationException();
			}

			return price;
		}

		public static string CheckLogin( string loginId )
		{
			if ( string.IsNullOrWhiteSpace( loginId ) )
			{
				throw new ValidationException();
			}

			return loginId;
		}

		public static DateTime CheckTime( DateTime time )
		{
			if ( time == DateTime.MinValue || time == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			return time;
		}

		public static DateTime CheckStartTime( DateTime startTime , DateTime endTime )
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

			return startTime;
		}

		public static int CheckMaximumOfResults( int value )
		{
			if ( 1 <= value && value <= 10000 )
			{
				return value;
			}

			throw new ValidationException();
		}

		public static DateTime CheckEndTime( DateTime startTime , DateTime endTime )
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

			return endTime;
		}

		public static IEnumerable<TElement> CheckCollection<TElement>( IEnumerable<TElement> elements )
		{
			if ( elements == null || ! elements.Any() )
			{
				throw new ValidationException();
			}

			return elements;
		}

		public static IReadOnlyCollection<TElement> CheckCollection<TElement>( IReadOnlyCollection<TElement> elements )
		{
			if ( elements == null || elements.Count == 0 )
			{
				throw new ValidationException();
			}

			return elements;
		}




		//---------------------------------------------------------------------------------------------------------------------------------------------------



		public static DOEntity CheckEntity( DOEntity entity )
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

			return entity;
		}
		
		public static DOTransaction CheckTransaction( DOTransaction transaction )
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

			return transaction;
		}

		public static DOEvent CheckEvent( DOEvent @event )
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

			return @event;
		}


	}
}
