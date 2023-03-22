using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzperaczexControlCore.Repositories
{
	public interface ISensorsReadingsRepository
	{
		void AddReadings(SensorsReadings sensorsReadings);
		List<SensorsReadings> GetReadings(Guid rideId);
		List<SensorsReadings> GetAnyReadings();
		IEnumerable<Guid> GetRideIds();
	}
}
