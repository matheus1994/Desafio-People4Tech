using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serviço
{
    public class TaskService: ITaskRepository
    {
        List<Task> tasks = new List<Task>;

        public void adicionar(Task task){
            this.tasks.add(task);
        }

        public void remover(int x){
            this.tasks.remove(x);
        }

        public void atualizar(Task task, int x){

            if(tasks[x] != null){
                tasks[x].id = task.id;
                tasks[x].title = task.title;
                tasks[x].description = task.description;
                tasks[x].DueDate = task.DueDate;
                tasks[x].Priority = task.Priority;
            }

        }

        public void listar(){
            foreach(Task task in tasks){
                Console.WriteLine(task.title);
            }
        }

    }
}