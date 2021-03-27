using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Repository;
using Test.Models;
using AutoMapper;
using Test.DTOS;

namespace Test.Controlers
{
    [Route("Api/Record")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public RecordController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET Api/RecordController/
        [HttpGet]
        public ActionResult<IEnumerable<Record>> GetAllRecords()
        {
            var Records = _repository.GetAllRecords();
            if (Records != null)
            {
                return Ok(Records);
            }
            return NotFound();
        }

        //GET Api/RecordController/{id}
        [HttpGet("{id}")]
        public ActionResult<Record> GetRecordById(int id)
        {
            var RecordItem = _repository.GetIdRecord(id);
            if (RecordItem != null)
            {
                return Ok(RecordItem);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Record> CreateRecord(RecordCreateDTO record)
        {
            Record _record = new Record
            {
                Age = record.Age,
                House = record.House.ToString(),
                Id = record.Id,
                LastName = record.LastName,
                Name = record.Name
            };
            _repository.CreateRecord(_record);
            _repository.SaveChanges();
            return Ok("registro creado con exito");
        }

        //Put Api/Recod/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateRecord(int id, RecordUpdateDTO recordUpdate) 
        {
            var record = _repository.GetIdRecord(id);
            if (record == null) 
            {
                return NotFound();
            }
            record.Age = recordUpdate.Age;
            record.House = recordUpdate.House.ToString();
            record.Name = recordUpdate.Name;
            record.LastName = recordUpdate.LastName;
            _repository.SaveChanges();
            return NoContent();
        }
        //Delete Api/Record/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRecord(int id) 
        {
            var record = _repository.GetIdRecord(id);
            if (record == null)
            {
                return NotFound();
            }
            _repository.DeleteRecord(record);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}