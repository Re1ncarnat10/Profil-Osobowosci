using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Profil_Osobowosci.Models;

public class PersonalityTestResult
{
    [Key]
    public int Id { get; set; }
    public string Comment { get; set; }
    public string Result { get; set; }
    [ForeignKey("User")]
    public string UserId { get; set; }
    public User User { get; set; }
}