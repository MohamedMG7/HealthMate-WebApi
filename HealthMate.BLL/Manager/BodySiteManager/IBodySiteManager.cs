using HealthMate.DAL.DTO.BodySiteDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMate.BLL.Manager.BodySiteManager
{
	public interface IBodySiteManager
	{
		Task<List<BodySiteNameAndId>> getBodySiteNameAndId();
	}
}
