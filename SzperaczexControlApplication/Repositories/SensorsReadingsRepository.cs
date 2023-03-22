using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzperaczexControlCore.Repositories;

namespace SzperaczexControlApplication.Repositories
{
	internal class SensorsReadingsRepository : ISensorsReadingsRepository
	{
		private IList<SensorsReadings> _sensorsReadings; //TODO: change to SqlDatabaseContext

		public void AddReadings(SensorsReadings sensorsReadings)
		{
			_sensorsReadings.Add(sensorsReadings);
		}

		public List<SensorsReadings> GetAnyReadings()
		{
			var firstSelectedValue = _sensorsReadings.First();
			return _sensorsReadings.Where(x => x.RideId == firstSelectedValue.RideId).ToList();
		}

		public List<SensorsReadings> GetReadings(Guid rideId)
		{
			return _sensorsReadings.Where(x => x.RideId == rideId).ToList();
		}

		public IEnumerable<Guid> GetRideIds()
		=> _sensorsReadings.Select(x => x.RideId);
	}
}
