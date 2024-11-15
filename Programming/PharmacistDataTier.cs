using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using Programming;
using System.Data.SqlTypes;

namespace ProjectName
{
    class PharmacistDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public void AddPharmacist(string pharmacistID, string firstName, string lastName, string middleInitial,
            string gender, decimal yearlySalary, DateTime dob, DateTime hireDate, string homePhone, string homeEmail, string workPhone,
            string workEmail, string addressStreet, string zip, string city, string state)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_pharmacist";
                cmdString.Parameters.Add("@PHARMACIST_ID", SqlDbType.VarChar, 8).Value = pharmacistID;
                cmdString.Parameters.Add("@fName", SqlDbType.VarChar, 25).Value = firstName;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lastName;
                cmdString.Parameters.Add("@middleName", SqlDbType.Char, 1).Value = middleInitial;
                cmdString.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dob;
                cmdString.Parameters.Add("@sex", SqlDbType.Char, 6).Value = gender;
                cmdString.Parameters.Add("@yearlySalary", SqlDbType.Decimal, 8).Value = yearlySalary;
                cmdString.Parameters.Add("@hiredate", SqlDbType.Date).Value = hireDate;
                cmdString.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.VarChar, 15).Value = workPhone;
                cmdString.Parameters.Add("@workEmail", SqlDbType.VarChar, 60).Value = workEmail;
                cmdString.Parameters.Add("@personalEmail", SqlDbType.VarChar, 60).Value = homeEmail;
                cmdString.Parameters.Add("@street", SqlDbType.VarChar, 60).Value = addressStreet;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 60).Value = city;
                cmdString.Parameters.Add("@address_state", SqlDbType.VarChar, 20).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
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

        public DataSet GetPharmacistsByPharmacistID(string pharmacistID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetPharmacistsByPharmacistID";
                cmdString.Parameters.Add("@PharmacistID", SqlDbType.VarChar, 8).Value = pharmacistID;

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

        public DataSet GetAllPharmacistIDs()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllPharmacistIDs";

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                da.Fill(ds);
                return ds;
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

        public void UpdatePharmacist(string pharmacistID, string firstName, string lastName, string middleInitial,
            string gender, decimal yearlySalary, DateTime dob, DateTime hireDate, string homePhone, string homeEmail, string workPhone,
            string workEmail, string addressStreet, string city, string state, string zip)
        {
            try 
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "modify_pharmacist";
                cmdString.Parameters.Add("@PHARMACIST_ID", SqlDbType.VarChar, 8).Value = pharmacistID;
                cmdString.Parameters.Add("@fName", SqlDbType.VarChar, 25).Value = firstName;
                cmdString.Parameters.Add("@lName", SqlDbType.VarChar, 25).Value = lastName;
                cmdString.Parameters.Add("@middleName", SqlDbType.Char, 1).Value = middleInitial;
                cmdString.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dob;
                cmdString.Parameters.Add("@sex", SqlDbType.Char, 6).Value = gender;
                cmdString.Parameters.Add("@yearlySalary", SqlDbType.Decimal, 8).Value = yearlySalary;
                cmdString.Parameters.Add("@hiredate", SqlDbType.Date).Value = hireDate;
                cmdString.Parameters.Add("@homePhone", SqlDbType.VarChar, 15).Value = homePhone;
                cmdString.Parameters.Add("@workPhone", SqlDbType.VarChar, 15).Value = workPhone;
                cmdString.Parameters.Add("@workEmail", SqlDbType.VarChar, 60).Value = workEmail;
                cmdString.Parameters.Add("@personalEmail", SqlDbType.VarChar, 60).Value = homeEmail;
                cmdString.Parameters.Add("@street", SqlDbType.VarChar, 60).Value = addressStreet;
                cmdString.Parameters.Add("@city", SqlDbType.VarChar, 60).Value = city;
                cmdString.Parameters.Add("@address_state", SqlDbType.VarChar, 20).Value = state;
                cmdString.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = zip;
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

        public void DeletePharmacist(string pharmacistID)
        {
            try
            {              
                myConn.Open();
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandText = "delete_pharmacist";
                cmdString.Parameters.Clear();
                cmdString.Parameters.Add("@pharmacist_ID", SqlDbType.VarChar, 8).Value = pharmacistID;
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


    }
}