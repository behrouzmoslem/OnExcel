using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using onExcel.Common;

namespace onExcel.DataAccess.MSSql
{
    public class OnExcelContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
    }
}
