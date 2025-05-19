using LearningAPI1.Data;
using LearningAPI1.Models;
using LearningAPI1.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultantsController : ControllerBase
    {
        private readonly AppDBContext dBContext;

        public ConsultantsController(AppDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult getAllConsultants()
        {
            return Ok(dBContext.Consultants.ToList());
        }

        [HttpPost]
        public IActionResult addConsultant(ConsultantDto consultantDto)
        {
            var consultantEntity =  new Consultant() 
            { 
                Address = consultantDto.Address,
                Cpf = consultantDto.Cpf,
                Email = consultantDto.Email,
                Name = consultantDto.Name,
                PhoneNumber = consultantDto.PhoneNumber
            };

            dBContext.Consultants.Add(consultantEntity);
            dBContext.SaveChanges();
            return Ok(consultantEntity);

        }

        [HttpPut]
        public IActionResult updateConsultant(Guid id, ConsultantDto consultantDto)
        {
            var consultant = dBContext.Consultants.Find(id);
            if (consultant == null)
            {
                return NotFound();
            }

            consultant.PhoneNumber = consultantDto.PhoneNumber;
            consultant.Cpf = consultantDto.Cpf;
            consultant.Address = consultantDto.Address;
            consultant.Email = consultantDto.Email;
            consultant.Name = consultantDto.Name;
            consultant.UpdatedAt = DateTime.Now.ToString();

            dBContext.SaveChanges();

            return Ok(consultant);
        }
    }
}
