using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Models
{
public class Prestamo{
   
   [Key]
    public int Id {get; set;}
    [Required]
    [Display(Name = "Fecha_Prestamo")]
    [DataType(DataType.Date)]
    public string? Fecha_Prestamo {get; set;}

    [Required]
    [Display(Name = "Descipcion de prestamo")]
    [StringLength(100,MinimumLength =2)]
    public string? Descripcion_Prestamo {get ; set;}

      [Required]
    [Display(Name = "Defina Estado")]
    [StringLength(50,MinimumLength =2)]
    public string? Estado {get ; set;}
       [Required]
    [Display(Name = "Nombre del Libro")]
    [StringLength(100,MinimumLength =2)]
   
    public int LibrosId {get; set;}
    public int DocentesId {get; set;}
    public Libros? Libros{get;set;}
    public Docentes? Docentes{get;set;}
}    
}