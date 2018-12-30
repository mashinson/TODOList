using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TODOList.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            TodoList = new List<Todo>
            {
                new Todo(Guid.NewGuid(), "Make cake", false),
                new Todo(Guid.NewGuid(), "Buy milk", true),
                new Todo(Guid.NewGuid(), "dsfdfdfdffffffffffffffffffffffffffffffffffffffffffff", true),
                new Todo(Guid.NewGuid(), "zavsdvdfbgfvnb gftnbgtntyghjht j yuj yhuj uykj uikm uik uiczxcdcccccdcccccccccccccccccccccccccccccccccccccccccccccckuik", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true),
                new Todo(Guid.NewGuid(), "Make cookeis", true)
            };
        }
        public List<Todo> TodoList { get; set; }
        public Todo Task { get; set; }
    }
}