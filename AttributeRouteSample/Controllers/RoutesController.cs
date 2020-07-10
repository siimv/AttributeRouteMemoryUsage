using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace AttributeRouteSample.Controllers
{
    [AllowAnonymous]
    [Route("")]
    public class RoutesController : ControllerBase
    {
        private readonly IActionDescriptorCollectionProvider _provider;

        public RoutesController(IActionDescriptorCollectionProvider provider)
        {
            _provider = provider;
        }

        [Route(""), HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [Route("debug-routes"), HttpGet]
        public IActionResult GetAllRoutes()
        {
            var routes = _provider.ActionDescriptors.Items.Where(
                    ad => ad.AttributeRouteInfo != null)
                .Select(ad => new
                {
                    Name = ad.AttributeRouteInfo.Name,
                    Template = ad.AttributeRouteInfo.Template
                }).ToList();

            return Ok(new
            {
                Routes = routes,
                Count = routes.Count
            });
        }

    }
}