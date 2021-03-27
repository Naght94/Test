using System;
using System.Collections.Generic;
using System.Linq;
using Test.Data;
using Test.Models;

namespace Test.Repository
{
    public class RecordRepo : IRepository
    {
        private readonly DataContext _context;
        
        public RecordRepo(DataContext context)
        {
            _context = context;
        }

        public void CreateRecord(Record record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }
            _context.Record.Add(record);
        }

        public void DeleteRecord(Record record)
        {
            if (record == null)
            {
                throw new ArgumentNullException(nameof(record));
            }
            _context.Record.Remove(record);
            _context.SaveChanges();
        }

        public IEnumerable<Record> GetAllRecords()
        {
            return _context.Record.ToList();
        }

        public Record GetIdRecord(int id)
        {
            return _context.Record.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

      
    }
}