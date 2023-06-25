using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
public class Autor{
   
   [Key]
    public int Id {get; set;}
    [Required]
    [Display(Name = "Nombre de Autor")]
    [StringLength(100,MinimumLength =2)]
    public string? Nombre {get; set;}
    [Required]
    [Display(Name = "Nacionalidad del Autor")]
    [StringLength(100,MinimumLength =2)]
    public string? Nacionalidad {get ; set;}

   
}    
}