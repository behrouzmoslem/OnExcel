using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onExcel.Common;

namespace onExcel.DataAccess.MSSql
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(OnExcelContext context ) : base(context)
        {
            
        }
        public Patient GetByNationalCode(string nationalCode)
        {
            return set.FirstOrDefault(a => a.NationalCode == nationalCode);
        }

        public Patient GetBySerialInsurance(string serialInsurance)
        {
            return set.FirstOrDefault(a => a.SerialInsurance == serialInsurance);
        } 
    }
}
