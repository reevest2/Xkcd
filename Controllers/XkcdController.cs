using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using xkcd.Models;
using xkcd.Client;



namespace xkcd.Controllers
{
    [Route("xkcd")]
    public class XkcdController : Controller
    {
        Xkcd _xkcd = new Xkcd();
        List<Xkcd> _xkcds = new List<Xkcd>();

        public async Task<IActionResult> IndexAsync()
        {
            var client = new XkcdClient();
            var xkcd = await client.GetComic();
            return View(xkcd);
        }
    }
}
