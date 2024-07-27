using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentação
{
    public class TaskApp: ITaskApp
    {

        private TaskServices tasks = new();

        public void create(Task task){
            this.tasks.adicionar(task);
        }

        public void read(){
            this.tasks.atualizar();
        }

        public void update(Task task, int x){
            this.tasks.atualizar(task, x);
        }

        public void delete(int x){
            this.tasks.remover(x);
        }


    }
}