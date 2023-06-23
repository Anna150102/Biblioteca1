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
    [NotMapped]
    public string[]? Images {get; set;}
    public String? Nombre_Libro {get; set;}
    public int Existencias_Libro {get; set;}
    public float Precio_Libro {get; set;}
    public String? Descripcion_Libro {get; set;}
   public int Autor_Id{get;set;}
   public int Editorial_Id{get;set;}
   public int Genero_Id{get;set;}
   public Autor? Autor{get;set;}
   public Editorial? Editorial{get;set;}
   public Genero? Genero{get;set;}
    
   
}    
}