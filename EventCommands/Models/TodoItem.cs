using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCommands.Models
{
    public class TodoItem
    {
        #region Properties
        public string Description { get; set; }
        public string OwnerName { get; set; }
        public bool IsCompleted { get; set; }
        #endregion Properties
    }
}
