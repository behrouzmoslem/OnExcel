namespace onExcel.DataAccess
{
    public interface IUnitOfWork
    {
        IPatientRepository PatientRepository { get; }
        void Commit();
    }
}