using System;
using System.Collections.Generic;

namespace Tarefas.DTO
{

    public class TarefaDTO
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }        

        public string? Descricao { get; set; }  

        public bool Concluida { get; set; }
    }
}
