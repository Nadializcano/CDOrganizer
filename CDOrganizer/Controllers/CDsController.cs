using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
  public class CDsController : Controller
  {

    [HttpGet("/artists/{artistId}/cds/new")]
    public ActionResult New(int artistId)
    {
       Artist artist = Artist.Find(artistId);
       return View(artist);
    }

    [HttpGet("/artists/{artistId}/cds/{cdId}")]
    public ActionResult Show(int artistId, int cdId)
    {
      CD cd = CD.Find(cdId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist artist = Artist.Find(artistId);
      model.Add("cd", cd);
      model.Add("artist", artist);
      return View(model);
    }

    [HttpPost("/cds/delete")]
    public ActionResult DeleteAll()
    {
      CD.ClearAll();
      return View();
    }

  }
}
