using System;
using System.Linq;
using onExcel.Common;
using onExcel.DataAccess;

namespace onExcel.Business
{
    public class PatientService : IPatientService
    {
        private IUnitOfWork unitOfWork;
        private IPatientFactory patientFactory;

        public PatientService(IUnitOfWork unitOfWork, IPatientFactory patientFactory)
        {
            this.unitOfWork = unitOfWork;
            this.patientFactory = patientFactory;
        }

        public PatientDto GetByNationalCode(string nationalCode)
        {
            var patientEntity = unitOfWork.PatientRepository.GetByNationalCode(nationalCode);

            return patientFactory.CreateDto(patientEntity);
        }

        public PatientDto GetBySerialInsurance(string serialInsurance)
        {
            var patientEntity = unitOfWork.PatientRepository.GetBySerialInsurance(serialInsurance);

            return patientFactory.CreateDto(patientEntity);
        }

        public PatientDto GetById(int id)
        {
            var patientEntity = unitOfWork.PatientRepository.GetAll().FirstOrDefault(a => a.Id == id);

            return patientFactory.CreateDto(patientEntity);
        }

        public void Edit(int id, PatientDto patientDto)
        {
           var entityPatient = unitOfWork.PatientRepository.GetAll().FirstOrDefault(a => a.Id == id);
            if (entityPatient != null)
            {
                patientDto.Id = entityPatient.Id;
                ObjectCopy.Patch(entityPatient,patientDto);
                unitOfWork.PatientRepository.Update(entityPatient);
                unitOfWork.Commit();
            }


        }

        public void Add(PatientDto patientDto)
        {
            var patientEntity = unitOfWork.PatientRepository.GetByNationalCode(patientDto.NationalCode);
            if (patientEntity == null)
            {
                patientEntity = patientFactory.CreateEntity(patientDto);
            }
            else
            {
                patientDto.Id = patientEntity.Id;
                ObjectCopy.Patch(patientEntity, patientDto);
            }


            unitOfWork.PatientRepository.Add(patientEntity);
            unitOfWork.Commit();
        }

        public void Remove(int id)
        {
            var entityPatient = unitOfWork.PatientRepository.GetAll().FirstOrDefault(a => a.Id == id);
            if (entityPatient != null)
            {
                unitOfWork.PatientRepository.Remove(entityPatient);
                unitOfWork.Commit();

            }


        }
    }

}