using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private int Length { get; set; }
    private int Width { get; set; }
    private int Height { get; set; }
    private int Weight { get; set; }
    private int CostToShip { get; set; }

    private static List<Parcel> _packages = new List<Parcel> {};

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      CostToShip = 5;
    }

    public static int Volume()
    {

    }

    public static int CostToShip()
    {
      
    }
    public static List<Parcel> GetAll()
    {
      return _packages;
    }

    public static void ClearAll()
    {
      _packages.Clear();
    }
  }
}