using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Tarefas.Web.Models;

public class TarefaViewModel
{
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Por favor informe o título")]
    [MinLength(5, ErrorMessage ="O título deve ter no mínimo 5 caracteres")]
    [DisplayName("Título")]    
    public string? Titulo { get; set; }        
    
    [Required(ErrorMessage ="Por favor informe a descrição")]
    [MinLength(12, ErrorMessage ="A dscrição deve ter no mínimo 12 caracteres")]
    [DisplayName("Descrição")]    
    public string? Descricao { get; set; }  

    [DisplayName("Concluída")]
    public bool Concluida { get; set; }
}