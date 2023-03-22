using System;

namespace SzperaczexControlCore.Repositories
{
	public class SensorsReadingsService : ISensorsReadingsService
	{
		private ISensorsReadingsRepository _sensorsReadingsRepository;

		public SensorsReadingsService(ISensorsReadingsRepository sensorsReadingsRepository)
		{
			_sensorsReadingsRepository = sensorsReadingsRepository;
		}

		public void AddReadings(
							Guid rideId,
							int accelerometrX, 
							int accelerometrY,
							int accelerometrZ)
		{
			_sensorsReadingsRepository.AddReadings(new SensorsReadings(
																	rideId,
																	accelerometrX,
																	accelerometrY, 
																	accelerometrZ));
		}

		public List<SensorsReadings> GetAnyReadings()
		{
			return _sensorsReadingsRepository.GetAnyReadings();
		}

		public List<SensorsReadings> GetReadings(Guid rideId)
		{
			return _sensorsReadingsRepository.GetReadings(rideId);
		}

		public IEnumerable<Guid> GetRideIds()
		{
			return _sensorsReadingsRepository.GetRideIds();
		}
	}
}