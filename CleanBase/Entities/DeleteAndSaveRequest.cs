using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class DeleteAndSaveRequest<T>
    {
        public T EntityToDelete { get; set; }
        public T EntityToSave { get; set; }
    }

}
