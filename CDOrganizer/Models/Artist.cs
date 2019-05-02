using System.Collections.Generic;

namespace CDOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<CD> _cds;

    public Artist(string artistName)
    {
      _name = artistName;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<CD>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Artist> GetAll()
    {
      return _instances;
    }

    public static Artist Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public List<CD> GetCDs()
     {
       return _cds;
     }

     public void AddCD(CD cd)
    {
      _cds.Add(cd);
    }

  }
}
