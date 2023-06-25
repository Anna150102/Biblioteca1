using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
public class Libros{
    [Key]
    public int Id {get; set;}
   [Required]
    [Display(Name = "Nombre del Libro")]
    [StringLength(100,MinimumLength =2)]
    public String? Nombre {get; set;}
    [Required]
    [Display(Name = "Existencias")]
    [Range (0,100)]
    public int Existencias_Libro {get; set;}
     [Required]
    [Display(Name = "Precio de Libros")]
    [Range (0,5000)]
    public string Precio_Libro {get; set;}
     [Required]
    [Display(Name = "Descripcion de Libros")]
    [StringLength(100,MinimumLength =2)]
    public String? Descripcion_Libro {get; set;}
    [Required]
    [Display(Name = "Nombre de los Autores")]
    
   
   
    public int AutorId {get; set;}
    public int EditorialId {get; set;}
    public int GeneroId {get; set;}
   
   public Autor? Autor{get;set;}
   public Editorial? Editorial{get;set;}
   public Genero? Genero{get;set;}
    
   
}    
}