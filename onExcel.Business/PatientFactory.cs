using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using onExcel.Common;

namespace onExcel.Business
{
    public class PatientFactory:IPatientFactory
    {
        public PatientDto CreateDto(Patient patientEntity)
        {
            return ObjectCopy.ShallowCopy<PatientDto, Patient>(patientEntity);
        }

        public IEnumerable<Patient> CreateEntity(IEnumerable<PatientDto> dtos)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<PatientDto> CreateDto(IEnumerable<Patient> entities)
        {
            throw new System.NotImplementedException();
        }

        public Patient CreateEntity(PatientDto patientDto)
        {
            return ObjectCopy.ShallowCopy<Patient, PatientDto>(patientDto);
        }
    }
}
