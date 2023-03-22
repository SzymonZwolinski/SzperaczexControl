using System;
namespace SzperaczexControlCore.Repositories
{
	public class SensorsReadings
	{
		public Guid Id { get; set; }
		public Guid RideId { get; set; }
		public int AccelerometrX { get; set; }
		public int AccelerometrY { get; set; }
		public int AccelerometrZ { get; set; }
		//TODO: AddHere models from LiDAR

		public SensorsReadings(
			Guid rideId,
			int accelerometrX,
			int accelerometrY,
			int accelerometrZ)
		{
			Id = Guid.NewGuid();
			RideId = rideId;
			AccelerometrX = accelerometrX;
			AccelerometrY = accelerometrY;
			AccelerometrZ = accelerometrZ;
		}
	}
}