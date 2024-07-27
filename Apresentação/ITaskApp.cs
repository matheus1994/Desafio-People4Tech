using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentação
{
    public interface ITaskApp
    {
        public void create(Task task);
        public void read(Task task);
        public void update(Task task, int x);
        public void delete(int x);
    }
}