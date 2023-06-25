using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Biblioteca.Models
{
public class Genero{
    [Key]
    public int Id {get; set;}
    [Required]
    [Display(Name = "Genero Literario")]
    [StringLength(100,MinimumLength =2)]
    public String? Nombre {get; set;}
    [Required]
    [Display(Name = "Descipcion de Genero")]
    [StringLength(100,MinimumLength =2)]
    public String? Descripcion_Genero {get ; set;}
   
   
   
   
}    
}