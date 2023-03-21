using System;
namespace SzperaczexControlCore.Repositories
{
	public interface ISensorsReadingsService
	{
		void AddReadings(
					Guid rideId,
					int AccelerometrX,
					int AccelerometrY,
					int AccelerometrZ);

		List<SensorsReadings> GetReadings(Guid rideId);
	}
}