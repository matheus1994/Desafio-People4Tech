using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo
{
    public class Task{

        public Task(string id, string title, string description, DateTime duodate, enum Priority) 
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.DueDate = duodate;
            this.Priority = Priority;
        }

    private string id{ get; }
    private string title{ get; }
    private string description{ get; }
    private DataTime DueDate{ get; }

    private enum Priority{ get; }
    
}

}