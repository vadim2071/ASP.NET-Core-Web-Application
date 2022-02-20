using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheets.Models;

namespace TimeSheets.BD
{
    public interface IRepository<T> where T : class
    {
        bool Delete (int id);
        bool Update(T item);
        bool New(T item);
        bool GetAll();

    }
}
