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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    class PrescriptionDataTier
    {
        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public void InsertPrescription(string patientID, int fillCount, string description, string pharmacistID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_prescription";
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.Parameters.Add("@PatientID", SqlDbType.VarChar, 8).Value = patientID;
                cmdString.Parameters.Add("@FillCount", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@Description", SqlDbType.VarChar, 100).Value = description;
                cmdString.Parameters.Add("@PharmacistID", SqlDbType.VarChar, 8).Value = pharmacistID;
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

        public DataSet SearchPrescriptions(/*string patientID, */string prescriptionID)
        {
            try
            {

                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_prescription";
                cmdString.CommandType = CommandType.StoredProcedure;
                /*
                if(string.IsNullOrEmpty(patientID))
                {
                    cmdString.Parameters.Add("@Patient_ID", SqlDbType.VarChar, 8).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@Patient_ID", SqlDbType.VarChar, 8).Value = patientID;
                }
                */
                if (string.IsNullOrEmpty(prescriptionID))
                {
                    cmdString.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = int.Parse(prescriptionID);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                DataSet dt = new DataSet();
                da.Fill(dt);

                return dt;
                
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

        public void UpdatePrescription(int prescriptionID, int fillCount, string description)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "modify_prescription";
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = prescriptionID;
                cmdString.Parameters.Add("@FillCount", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@prescriptionDesc", SqlDbType.VarChar, 100).Value = description;
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

        public void DeletePrescription(string prescriptionID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "delete_prescription";
                cmdString.CommandType = CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(prescriptionID))
                {
                    cmdString.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@Prescription_ID", SqlDbType.Int).Value = int.Parse(prescriptionID);
                }

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
                cmdString.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                DataSet ds = new DataSet();
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
                cmdString.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                DataSet ds = new DataSet();
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

        public DataSet GetAllPrescriptionIDs()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllPrescriptionIDs";
                cmdString.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmdString);
                DataSet ds = new DataSet();
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

        public DataSet GetAllPrescriptions()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllPrescriptions";

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
    }
}






        /*
        public DataSet GetPrescriptionByID(int prescriptionID)
        {
            myConn.Open();

            // Set up command to use stored procedure
            cmdString.Parameters.Clear();
            cmdString.Connection = myConn;
            cmdString.CommandType = CommandType.StoredProcedure;
            cmdString.CommandText = "select_prescription";
            cmdString.CommandTimeout = 1500;

            cmdString.Parameters.Add("@PRESCRIPTION_ID", SqlDbType.Int).Value = prescriptionID;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdString);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public DataSet GetAllPrescriptions()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand("GetAllPrescriptions", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsPrescriptions = new DataSet();
                adapter.Fill(dsPrescriptions);
                return dsPrescriptions;
            }
        }

        public bool AddOrUpdatePrescription(int prescriptionID, string patientID, string pharmacistID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand("AddOrUpdatePrescription", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@PharmacistID", pharmacistID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public void ModifyPrescription(string prescriptionID, int fillCount, string description, string patientID, string pharmacistID)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand("ModifyPrescription", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                command.Parameters.AddWithValue("@FillCount", fillCount);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@PatientID", patientID);
                command.Parameters.AddWithValue("@PharmacistID", pharmacistID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void NewPrescription(int fillCount, string desc)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_prescription";
                cmdString.Parameters.Add("@fillCount", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@prescriptionDesc", SqlDbType.VarChar, 100).Value = desc;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
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

        /*
        
        public DataSet GetPrescriptions(string prescription)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_prescription";
                cmdString.Parameters.Add("@prescription_id", SqlDbType.Int).Value = prescription;

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

        public DataSet GetAllPrescriptions()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_all_prescription";
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

        public void ModifyPrescription(string prescriptionId, int fillCount, string prescriptionDesc, string patientId, string pharmacistId)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandText = "modify_prescription";
                cmdString.Parameters.Add("@PRESCRIPTION_ID", SqlDbType.VarChar, 10).Value = prescriptionId;
                cmdString.Parameters.Add("@fillCount", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@prescriptionDesc", SqlDbType.VarChar, 100).Value = prescriptionDesc;
                cmdString.Parameters.Add("@PATIENT_ID", SqlDbType.VarChar, 8).Value = patientId;
                cmdString.Parameters.Add("@PHARMACIST_ID", SqlDbType.VarChar, 8).Value = pharmacistId;

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

        public void NewPrescription(int fillCount, string desc)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_prescription";
                cmdString.Parameters.Add("@fillCount", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@prescriptionDesc", SqlDbType.VarChar, 100).Value = desc;

                SqlDataAdapter aAdapter = new SqlDataAdapter();
                aAdapter.SelectCommand = cmdString;
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

        public bool AddOrUpdatePrescription(int prescriptionID, string patientID, string pharmacistID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandText = "AddPrescriptionForPatient";

                cmdString.Parameters.Add(new SqlParameter("@prescriptionID", SqlDbType.Int)).Value = prescriptionID;
                cmdString.Parameters.Add(new SqlParameter("@patientID", SqlDbType.VarChar, 8)).Value = patientID;
                cmdString.Parameters.Add(new SqlParameter("@pharmacistID", SqlDbType.VarChar, 8)).Value = pharmacistID;

                int rowsAffected = cmdString.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Database error: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        public bool AddNewPrescription(string prescriptionDesc, int fillCount, string patientID, string pharmacistID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "AddNewPrescription";
                cmdString.Parameters.Add("@prescription_desc", SqlDbType.VarChar, 100).Value = prescriptionDesc;
                cmdString.Parameters.Add("@fill_count", SqlDbType.Int).Value = fillCount;
                cmdString.Parameters.Add("@patient_id", SqlDbType.VarChar, 8).Value = patientID;
                cmdString.Parameters.Add("@pharmacist_id", SqlDbType.VarChar, 8).Value = pharmacistID;

                int rowsAffected = cmdString.ExecuteNonQuery();
                return rowsAffected > 0;
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

        public bool CanRefillPrescription(int prescriptionID, int fillCount)
        {
            return fillCount > 0;
        }

        public void UpdatePrescriptionFillCount(int prescriptionID, int newFillCount)
        {
            
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandText = "UpdatePrescriptionFillCount";
                cmdString.Parameters.AddWithValue("@PrescriptionID", prescriptionID);
                cmdString.Parameters.AddWithValue("@NewFillCount", newFillCount);
                cmdString.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating prescription fill count: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

    }
}
        */