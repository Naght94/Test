using System.Collections.Generic;
using Test.Models;

namespace Test.Repository 
{
    public interface IRepository
    {
        IEnumerable<Record> GetAllRecords();
        Record GetIdRecord(int id);
        void CreateRecord(Record record);
        bool SaveChanges();
        void DeleteRecord(Record record);
    }
}
