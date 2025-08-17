using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ParentEntityUpdateDTO
    {
        public List<ChildEntityDTO> Children { get; set; }
    }

    public class ChildEntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
