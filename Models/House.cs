using System.ComponentModel.DataAnnotations;

namespace gregslist_csharp.Models;

public class House
{
  public int Id { get; set; }

  [Range(1, 200000)]
  public int Sqft { get; set; }

  [Range(0, 30)]
  public int Bedrooms { get; set; }

  [Range(0, 25)]
  public double Bathrooms { get; set; }

  [MaxLength(500)]
  public string ImgUrl { get; set; }

  [MaxLength(1000)]
  public string Description { get; set; }

  [Range(0, 10000000)]
  public int Price { get; set; }

  public string CreatorId { get; set; }
  public Account Creator { get; set; }
}