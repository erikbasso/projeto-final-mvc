using System;
using System.ComponentModel.DataAnnotations;

namespace miniblog.Models
{
  public class Post
  {
    public int Id {get; set;}
    public string Titulo {get; set;}
    public string Conteudo {get; set;}

    [Display(Name="Data da publicação")]
    [DataType(DataType.Date)]
    public DateTime data {get; set;}

    public string autor {get; set;}
  }
}