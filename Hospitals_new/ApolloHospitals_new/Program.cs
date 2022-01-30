using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApolloHospitals_new
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Apollo Hospitals

            class MedicalStaff
            {
            private string staffName;
            private string staffId;
            private string staffDepartment;
            private string staffDesignation;
            private uint salary;

            public void StaffRecruitment()
            {
                //todo
            }

            public void StaffEndOfService()
            {
                //todo
            }
              
            public void StaffContribution()
            {
                //todo
            }

            public void DisplayStaff()
            {
                //todo
            }

            public void StaffDocumnetation()
            {
                //todo
            }

            }

            class LaboratoryDepartment
            {
            private string bloodGroup;
            private string prescribedTest;
            private ushort testPrice;
            private string testResult;
            private ulong contactNumber;

            public void GenerateTestReport()
            {
                //todo
            }

            public void DisplayTestReport()
            {
                //todo
            }

            public void SyncTestReports()
            {
                //todo
            }

            public void DeleteTestReport()
            {
                //todo
            }

            public void LaboratoryTransactions()
            {
                //todo
            }

            }

            class Patients
            {
            private string name;
            private string patientID;
            private ulong patientContactNumber;
            private byte age;
            private string gender;

            public void AddPatient()
            {
                //todo
            }

            public void DeletePatient()
            {
                //todo
            }

            public void DisplayPatient()
            {
                //todo
            }

            public void UpdatePatientAccount()
            {
                //todo
            }

            public void PatientTransactions()
            {
                //todo
            }

            }
            
            class Administration
            {
                 private string hospitalName;
                 private ulong hospitalContactNumber;
                 private string address;
                 private string hospitalWebsite;
                 private string specialization;

                 public void MedicineStockMaintainence()
                 {
                    
                    //todo
                 }

                public void ManageAppointments()
                {
                //todo
                }

                public void AssistStaff()
                {
                //todo
                }
                
                public void AssistPatients()
                {
                    //todo
                }

                public void LegalFormalities()
                {

                //todo

                }


            
            }

            class PharmacyCompanies
            {

            private string companyName;
            private ulong companyContactNumber;
            private string companyWebsite;
            private string medicineOffered;
            private string companyRepresentative;

            public void AddCompany()
            {
                //todo
            }

            public void DeleteCompany()
            {
                //todo

            }

            public void DisplayCompany()
            {
                //todo
            }

            public void CompanyTransactions()
            {
                //todo
            }

            public void UpdateCompanyDetails()
            {
                //todo
            }

            }
        }
    }
}
