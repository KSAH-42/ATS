using System;
using System.Linq;
using System.Collections.Generic;

namespace ATS.Engine.Net
{
	internal static class InternalValidator
	{
		public static Guid Validate( Guid uniqueId )
		{
			if ( uniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			return uniqueId;
		}

		public static string Validate( string text )
		{
			if ( string.IsNullOrWhiteSpace( text ) )
			{
				throw new ValidationException();
			}

			return text;
		}

		public static DateTime Validate( DateTime time )
		{
			if ( time == DateTime.MinValue || time == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			return time;
		}

		public static IEnumerable<TElement> Validate<TElement>( IEnumerable<TElement> elements )
		{
			if ( elements == null || ! elements.Any() )
			{
				throw new ValidationException();
			}

			return elements;
		}

		public static IReadOnlyCollection<TElement> Validate<TElement>( IReadOnlyCollection<TElement> elements )
		{
			if ( elements == null || elements.Count == 0 )
			{
				throw new ValidationException();
			}

			return elements;
		}




		//---------------------------------------------------------------------------------------------------------------------------------------------------



		public static DOEntity Validate( DOEntity entity )
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
		
		public static DOTransaction Validate( DOTransaction transaction )
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

		public static DOEventRecord Validate( DOEventRecord record )
		{
			if ( null == record )
			{
				throw new ValidationException();
			}

			if ( record.UniqueId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( record.ApplicationId == Guid.Empty )
			{
				throw new ValidationException();
			}

			if ( record.Type <= 0 )
			{
				throw new ValidationException();
			}

			if ( record.TimeStamp == DateTime.MinValue || record.TimeStamp == DateTime.MaxValue )
			{
				throw new ValidationException();
			}

			return record;
		}


	}
}
