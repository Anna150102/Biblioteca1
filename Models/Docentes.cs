using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Docentes{
    [Key]
    public int Id {get; set;}
    [Required]
    [Display(Name = "Nombre de Docente")]
    [StringLength(100,MinimumLength =2)]
    public String? Nombre {get; set;}
    [Required]
    [Display(Name = "Facultad de Docente")]
    [StringLength(100,MinimumLength =2)]
    public String? Facultad{get ; set;}
}    
}