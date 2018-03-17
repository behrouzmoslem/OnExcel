using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using onExcel.Business;

namespace onExcel.HttEndpoint.Controllers
{
    [RoutePrefix("api/patient")]
    public class PatientController : ApiController
    {

        private IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [Route("NationalCode={nationalCode}")]
        public IHttpActionResult GetByNationalCode(string nationalCode)
        {
            var result = patientService.GetByNationalCode(nationalCode);
            return Ok(result);
        }
        [Route("SerialInsurance={serialInsurance}")]
        public IHttpActionResult GetBySerialInsurance(string serialInsurance)
        {
            var result = patientService.GetBySerialInsurance(serialInsurance);
            return Ok(result);
        }
        [Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            var result = patientService.GetById(id);
            return Ok(result);
        }
        [Route("")]
        public IHttpActionResult Put(int id,PatientDto patientDto)
        {
              patientService.Edit(id, patientDto);
            return Created("", patientDto);
        }
        [Route("")]
        public IHttpActionResult Post(PatientDto patientDto)
        {
            patientService.Add(patientDto);
            return Created("", patientDto);
        }
        [Route("")]
        public IHttpActionResult Delete(int id)
        {
          patientService.Remove(id);
            return Ok(id);

        }
    }

    

   
}
