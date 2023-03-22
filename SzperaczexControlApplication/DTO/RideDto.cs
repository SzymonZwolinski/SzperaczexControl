using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzperaczexControlApplication.DTO
{
	internal class RideDto
	{
		public Guid RideId => Guid.NewGuid();
		public IEnumerable<SensorsReadingsDto> SensorsReadings { get; set; }
	}
}
