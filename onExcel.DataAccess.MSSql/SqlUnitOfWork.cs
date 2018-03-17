using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace onExcel.DataAccess.MSSql
{

    public class SqlUnitOfWork:IUnitOfWork
    {
         private OnExcelContext context;

        public SqlUnitOfWork( )
        {
            var temp = typeof(System.Data.Entity.SqlServer.SqlFunctions);
           context = new OnExcelContext();
        }

        private IPatientRepository patientRepository;
        public IPatientRepository PatientRepository
        {
            get { return patientRepository ?? (patientRepository = new PatientRepository(context)); }
        } 
        public void Commit()
        {
            context.SaveChanges();
        }
    }

     
}
