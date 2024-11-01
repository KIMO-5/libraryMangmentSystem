using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMangementSystem
{
    internal class librarian : user
    {
        public void Add(Book book ,libraray li)
        {
            li.Add(book);
        }
        public void Remove(Book book , libraray li)
        {
            li.Remove(book);
        }

    }
}
