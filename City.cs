using System.Collections.Generic;
  namespace Planner
  {
      public class City
      {
          public City (string name)
          {
              Name = name;
          }
          public string Name { get; set; }
          public string cityMayor { get; set; }
          public int cityYear { get; set; }
          public List<Building> Buildings = new List<Building> ();
          //methods
          public void addBuilding (Building name)
          {
              Buildings.Add (name);
          }
      }
  }