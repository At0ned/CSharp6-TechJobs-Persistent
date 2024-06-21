
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels;

public class AddEmployerViewModel
{
    [Required(ErrorMessage ="You need to set a name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "You need to set a location")]
    public string? Location { get; set; }

}