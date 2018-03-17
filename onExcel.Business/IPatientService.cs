using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onExcel.Business
{
    public interface IPatientService
    {
        PatientDto GetByNationalCode (string nationalCode);
        PatientDto GetBySerialInsurance (string serialInsurance);
        PatientDto GetById (int id);
        void Edit(int id, PatientDto patientDto);
        void Add(PatientDto patientDto);
        void Remove(int id);
    }
}
