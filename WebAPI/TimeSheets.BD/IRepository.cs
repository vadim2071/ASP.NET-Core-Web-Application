using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheets.Models;

namespace TimeSheets.BD
{
    internal interface IRepository
    {
        bool Delete (int id);
        bool Update(Person item);
        bool New(Person item);

    }
}
