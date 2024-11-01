using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace libraryMangementSystem
{
    internal class RegulerUser : user
    { 
        public void borrow(Book book , libraray li)
        {
            li.Borrow(book);
        }

    }
}
