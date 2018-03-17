using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onExcel.Common;

namespace onExcel.DataAccess
{
    public interface IPatientRepository :IRepository<Patient>
    {
        Patient GetByNationalCode(string nationalCode);
        Patient GetBySerialInsurance(string serialInsurance);
    }
}
