using Microsoft.AspNetCore.Mvc;
using UmbracoHerosBlock.Core.Models;

namespace UmbracoHerosBlock.View_Components
{
    public class HeroBlockViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(HeroBlockViewModel hero)
        {
            return Task.FromResult<IViewComponentResult>(View(hero));
        }
    }
}