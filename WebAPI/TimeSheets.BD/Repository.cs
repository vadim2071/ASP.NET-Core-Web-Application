using System;
using System.Collections.Generic;
using TimeSheets.Models;

namespace TimeSheets.BD
{
    public class Repository : IRepository
    {
        // get all> get??
        bool IRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepository.Update(Person item)
        {
            throw new NotImplementedException();
        }

        public bool New(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
