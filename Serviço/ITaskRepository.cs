using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviço
{
    public interface ITaskRepository
    {
        public void adicionar(Task task);
        public void remover(int x);
        public void atualizar(Task task, int x);
        public void listar();
    }
}