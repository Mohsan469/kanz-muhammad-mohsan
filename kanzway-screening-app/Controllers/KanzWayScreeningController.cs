using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace kanzway_screening_app.Controllers
{
    [ApiController]
    public class KanzWayScreeningController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/screening/{number}")]
        public List<string> GetStrings(UInt32 number)
        {
            if (number == 0)
            {
                return null;
            }
            var list = new List<string>();
            try
            {
                var numbers = Enumerable.Range(1, (int)number).ToList();
                foreach (var item in numbers)
                {
                    list.Add(item.ToString());

                    if (item % 3 == 0 && item % 5 == 0)
                    {
                        list.Add("KanzWay");
                    }
                    else if (item % 3 == 0)
                    {
                        list.Add("Kanz");
                    }
                    else if (item % 5 == 0)
                    {
                        list.Add("Way");
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                logger.log.Error("ERROR",ex);
            }
            return list;
        }
    }
}
