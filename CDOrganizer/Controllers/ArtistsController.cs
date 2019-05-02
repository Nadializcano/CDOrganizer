using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;

namespace CDOrganizer.Controllers
{
  public class ArtistsController : Controller
  {

    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/artists")]
    public ActionResult Creat(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      List<Artist> allArtists = Artist.GetAll();
      return View("Index", allArtists);
    }
    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<CD>artistCDs = selectedArtist.GetCDs();
      model.Add("artist", selectedArtist);
      model.Add("cds", artistCDs);
      return View(model);
    }

    [HttpPost("/artists/{artistId}/cds")]
    public ActionResult Create(int artistId, string CDDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      CD newCD = new CD(CDDescription);
      foundArtist.AddCD(newCD);
      List<CD> artistCDs = foundArtist.GetCDs();
      model.Add("cds", artistCDs);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }

  }
}
