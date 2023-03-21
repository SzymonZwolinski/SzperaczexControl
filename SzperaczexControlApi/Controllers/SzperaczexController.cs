using Microsoft.AspNetCore.Mvc;
using SzperaczexControlApplication.DTO;
using SzperaczexControlCore.Repositories;

namespace SzperaczexControlApi.Controllers
{
	[Route("[controller]")]
	public class SzperaczexController 
	{
		private readonly ISensorsReadingsService _sensorsReadingsService;

		public SzperaczexController(ISensorsReadingsService sensorsReadingsService)
		{
			_sensorsReadingsService = sensorsReadingsService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAnySensorData()
		{
			var readings = _sensorsReadingsService.GetAnyReadings();

			return new JsonResult(readings);
		}

		[HttpGet("/{rideId}")]
		public async Task<IActionResult> GetSensorsReadings([FromRoute] Guid rideId)
		{
			var readings = _sensorsReadingsService.GetReadings(rideId);
			
			return new JsonResult(readings);
		}

		[HttpGet("/rides")]
		public async Task<IActionResult> GetRideIds()
		{
			var rideIds = _sensorsReadingsService.GetRideIds();

			return new JsonResult(rideIds);
		}

		[HttpPost]
		public async Task PostSensorsReadings([FromQuery] RideDto ride)
		{
			var rideId = Guid.NewGuid();
			ride.SensorsReadings.ToList()
				.ForEach(x => _sensorsReadingsService.AddReadings(
																rideId,
																x.AccelerometrX,
																x.AccelerometrY,
																x.AccelerometrZ));
		}
	}
}
