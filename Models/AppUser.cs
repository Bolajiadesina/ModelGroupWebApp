
using System.ComponentModel.DataAnnotations;

namespace ModelGroupWebApp.Models;



public class AppUser
{

    [Key]
    public string AppUserId { get; set; }
    public int? Pace { get; set; }
    public int? Mileage { get; set; }
    public Address? Address { get; set; }

    public ICollection<Club> Clubs { get; set; }
    public ICollection<Race> Races { get; set; }




}