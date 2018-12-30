using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOList.Models
{
    public class Todo
    {
        public Todo()
        {
            ID = Guid.NewGuid();
            IsDone = false;
        }
        public Todo(Guid id, string des, bool done)
            {
                ID = id;
                Description = des;
                IsDone = done;
            }
            public Guid ID { get; set; }
            public string Description { get; set; }
            public bool IsDone { get; set; }
        }
    
}