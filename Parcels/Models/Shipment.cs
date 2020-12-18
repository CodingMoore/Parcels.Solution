using System.Collections.Generic;

namespace Parcels.Models
{
public class Shipment
{
  private static List<Shipment> _instances = new List<Shipment> {};
  public string Name { get; set;}
  public int Id { get;}
  public List<Parcel> Parcels { get; set;}

  public Shipment(string shipmentName)
  {
    Name = shipmentName;
    _instances.Add(this);
    Id = _instances.Count;
    Parcels = new List<Parcel> {};
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }

  public static List<Shipment> GetAll()
  {
    return _instances;
  }

  public static Shipment Find(int searchId)
  {
    return _instances[searchId -1];
  }

}

}