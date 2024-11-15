using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Xml.Linq;
using System.IO;

namespace Programming
{
    class PatientDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public DataSet GetPatient(string patientId, string fname, string lname, string middleName, DateTime dateOfBirth, string sex, string currentDoctor, string insuranceCompanyOne, int policyNumberOne, string insuranceCompanyTwo, int policyNumberTwo, string insuranceCompanyThree, int policyNumberThree, string homePhone, string workPhone, string workEmail, string personalEmail, string street, string city, string addressState, string zip, decimal accountBalance)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_patient";
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 8).Value = patientId;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                cmdString.Parameters.Add("@middleName", SqlDbType.Char, 1).Value = middleName;
                cmdString.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateOfBirth;
                cmdString.Parameters.Add("@sex", SqlDbType.Char, 6).Value = sex;
                cmdString.Parameters.Add("@currentDoctor", SqlDbType.VarChar, 60).Value = currentDoctor;
                cmdString.Parameters.Add("@insuranceCompanyOne", SqlDbType.VarChar, 60).Value = insuranceCompanyOne;
                cmdString.Parameters.Add("@policyNumberOne", SqlDbType.Int).Value = policyNumberOne;
                cmdString.Parameters.Add("@insuranceCompanyTwo", SqlDbType.VarChar, 60).Value = insuranceCompanyTwo;
                cmdString.Parameters.Add("@policyNumberTwo", SqlDbType.Int).Value = policyNumberTwo;
                cmdString.Parameters.Add("@insuranceCompanyThree", SqlDbType.VarChar, 60).Value = insuranceCompanyThree;
                cmdString.Parameters.Add("@policyNumberThree", SqlDbType.Int).Value = policyNumberThree;
                cmdString.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.VarChar, 15).Value = workPhone;
                cmdString.Parameters.Add("@workEmail", SqlDbType.VarChar, 60).Value = workEmail;
                cmdString.Parameters.Add("@personalEmail", SqlDbType.VarChar, 60).Value = personalEmail;
                cmdString.Parameters.Add("@street", SqlDbType.VarChar, 60).Value = street;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 60).Value = city;
                cmdString.Parameters.Add("@address_state", SqlDbType.Char, 2).Value = addressState;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@account_balance", SqlDbType.Decimal).Value = accountBalance;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
        
        public DataSet GetPatientsByPatID(string patid)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_patient";
                cmdString.Parameters.Add("@patient_id", SqlDbType.VarChar, 8).Value = patid;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
                aAdapter.Fill(aDataSet);

                return aDataSet;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public DataSet GetAllPatientIDs()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllPatientIDs";

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
                DataSet aDataSet = new DataSet();
                aAdapter.Fill(aDataSet);

                return aDataSet;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public void DeletePatient(string patientID)
        {
            try
            {
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandText = "delete_patient"; 
                cmdString.Parameters.Clear();
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 8).Value = patientID;
                myConn.Open();
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DeletePatient: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public void ModifyPatient(string patientId, string fname, string lname, string middleName, DateTime dateOfBirth, string sex, string currentDoctor, string insuranceCompanyOne, int policyNumberOne, string insuranceCompanyTwo, int policyNumberTwo, string insuranceCompanyThree, int policyNumberThree, string homePhone, string workPhone, string workEmail, string personalEmail, string street, string city, string addressState, string zip, decimal accountBalance)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "modify_patient";
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 8).Value = patientId;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fname;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lname;
                cmdString.Parameters.Add("@middleName", SqlDbType.Char, 1).Value = middleName;
                cmdString.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateOfBirth;
                cmdString.Parameters.Add("@sex", SqlDbType.Char, 6).Value = sex;
                cmdString.Parameters.Add("@currentDoctor", SqlDbType.VarChar, 60).Value = currentDoctor;
                cmdString.Parameters.Add("@insuranceCompanyOne", SqlDbType.VarChar, 60).Value = insuranceCompanyOne;
                cmdString.Parameters.Add("@policyNumberOne", SqlDbType.Int).Value = policyNumberOne;
                cmdString.Parameters.Add("@insuranceCompanyTwo", SqlDbType.VarChar, 60).Value = insuranceCompanyTwo;
                cmdString.Parameters.Add("@policyNumberTwo", SqlDbType.Int).Value = policyNumberTwo;
                cmdString.Parameters.Add("@insuranceCompanyThree", SqlDbType.VarChar, 60).Value = insuranceCompanyThree;
                cmdString.Parameters.Add("@policyNumberThree", SqlDbType.Int).Value = policyNumberThree;
                cmdString.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.VarChar, 15).Value = workPhone;
                cmdString.Parameters.Add("@workEmail", SqlDbType.VarChar, 60).Value = workEmail;
                cmdString.Parameters.Add("@personalEmail", SqlDbType.VarChar, 60).Value = personalEmail;
                cmdString.Parameters.Add("@street", SqlDbType.VarChar, 60).Value = street;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 60).Value = city;
                cmdString.Parameters.Add("@address_state", SqlDbType.Char, 2).Value = addressState;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@account_balance", SqlDbType.Decimal).Value = accountBalance;
                cmdString.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public void NewPatient(string patientID, string fName, string lName, string middleName, DateTime dateOfBirth, string gender, string currentDoctor, string insuranceCompanyOne, int policyNumberOne, string insuranceCompanyTwo, int policyNumberTwo, string insuranceCompanyThree, int policyNumberThree, string homePhone, string workPhone, string workEmail, string personalEmail,
        string address, string city, string state, string zip, decimal accountBalance)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_patient";
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 8).Value = patientID;
                cmdString.Parameters.Add("@fname", SqlDbType.VarChar, 25).Value = fName;
                cmdString.Parameters.Add("@lname", SqlDbType.VarChar, 25).Value = lName;
                cmdString.Parameters.Add("@middleName", SqlDbType.Char, 1).Value = middleName;
                cmdString.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateOfBirth;
                cmdString.Parameters.Add("@sex", SqlDbType.Char, 6).Value = gender;
                cmdString.Parameters.Add("@currentDoctor", SqlDbType.VarChar, 60).Value = currentDoctor;
                cmdString.Parameters.Add("@insuranceCompanyOne", SqlDbType.VarChar, 60).Value = insuranceCompanyOne;
                cmdString.Parameters.Add("@policyNumberOne", SqlDbType.Int).Value = policyNumberOne;
                cmdString.Parameters.Add("@insuranceCompanyTwo", SqlDbType.VarChar, 60).Value = insuranceCompanyTwo;
                cmdString.Parameters.Add("@policyNumberTwo", SqlDbType.Int).Value = policyNumberTwo;
                cmdString.Parameters.Add("@insuranceCompanyThree", SqlDbType.VarChar, 60).Value = insuranceCompanyThree;
                cmdString.Parameters.Add("@policyNumberThree", SqlDbType.Int).Value = policyNumberThree;
                cmdString.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.VarChar, 15).Value = workPhone;
                cmdString.Parameters.Add("@workEmail", SqlDbType.VarChar, 60).Value = workEmail;
                cmdString.Parameters.Add("@personalEmail", SqlDbType.VarChar, 60).Value = personalEmail;
                cmdString.Parameters.Add("@street", SqlDbType.VarChar, 60).Value = address;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 60).Value = city;
                cmdString.Parameters.Add("@address_state", SqlDbType.Char, 2).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
                cmdString.Parameters.Add("@account_balance", SqlDbType.Decimal).Value = accountBalance;
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}
