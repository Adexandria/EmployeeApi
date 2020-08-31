using AutoMapper;
using EmployeePayroll.Model;
using EmployeePayroll.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Controllers
{
    [ApiController]
    [Route("api/employee/{id}")]
    public class Address:ControllerBase
    {
        private readonly IAddress data;
        private readonly IData db;
        private readonly IMapper mapper;
        private readonly IPropertyMappingService propertyMapping;

        public Address(IAddress data, IMapper mapper, IPropertyMappingService propertyMapping,IData db)
        {
            this.data = data ?? throw new NullReferenceException(nameof(data));
            this.db = db ?? throw new NullReferenceException(nameof(db));
            this.mapper = mapper ?? throw new NullReferenceException(nameof(mapper));
            this.propertyMapping = propertyMapping ?? throw new NullReferenceException(nameof(propertyMapping));


        }
        [HttpPut(Name ="Address")]
        public async Task<ActionResult<Entities.Employee>> Post(Guid id,AddressCreation address)
        {
            var query = await db.GetEmployee(id);
            if( query == null)
            {
                return NotFound();
            }
            var newAddress = mapper.Map<Entities.Address>(address);
            query.HomeAddress = newAddress;
            data.Update(newAddress);
            db.Update(query);
            data.Save();
             await db.Save();
            return Ok(query);
        }
    }
}
