using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    class RefillDataTier
    {

        static String connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        static SqlConnection myConn = new SqlConnection(connString);
        static System.Data.SqlClient.SqlCommand cmdString = new System.Data.SqlClient.SqlCommand();

        public void AddRefill(int refillCount, int refillsRemaining, string prescriptionID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "add_refill";
                //cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 8).Value = refillID;
                cmdString.Parameters.Add("@refill_count", SqlDbType.Int).Value = refillCount;
                cmdString.Parameters.Add("@refills_remaining", SqlDbType.Int).Value = refillsRemaining;
                cmdString.Parameters.Add("@PRESCRIPTION_ID", SqlDbType.VarChar, 8).Value = prescriptionID;
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

        public DataSet SearchRefills(string prescriptionID, string refillID)
        {
            try
            {

                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "select_refill";
                cmdString.CommandType = CommandType.StoredProcedure;

                if(string.IsNullOrEmpty(prescriptionID))
                {
                    cmdString.Parameters.Add("@prescriptionID", SqlDbType.VarChar, 8).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@prescriptionID", SqlDbType.VarChar, 8).Value = prescriptionID;
                }

                if (string.IsNullOrEmpty(refillID))
                {
                    cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 6).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 6).Value = int.Parse(refillID);
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

        public void UpdatePrescription(string refillID, int refillsRemaining, string prescriptionID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "modify_refill";
                cmdString.Parameters.Add("@PRESCRIPTION_ID", SqlDbType.VarChar, 6).Value = prescriptionID;
                cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 8).Value = refillID;
                cmdString.Parameters.Add("@refills_remaining", SqlDbType.Int).Value = refillsRemaining;
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

        public void DeleteRefill(string refillID)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "delete_refill";
                cmdString.CommandType = CommandType.StoredProcedure;

                if (string.IsNullOrEmpty(refillID))
                {
                    cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 8).Value = DBNull.Value;
                }
                else
                {
                    cmdString.Parameters.Add("@refill_ID", SqlDbType.VarChar, 8).Value = refillID;
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

        public DataSet GetAllRefillIDs()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllRefillIDs";
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

        public DataSet GetAllRefills()
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "GetAllRefills";

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

        public void DecrementRefill(int prescriptionId)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "DecrementRefill";
                cmdString.Parameters.Add("@prescriptionID", SqlDbType.Int).Value = prescriptionId;
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

        public void IncrementRefill(int prescriptionId)
        {
            try
            {
                myConn.Open();
                cmdString.Parameters.Clear();
                cmdString.Connection = myConn;
                cmdString.CommandType = CommandType.StoredProcedure;
                cmdString.CommandTimeout = 1500;
                cmdString.CommandText = "IncrementRefill";
                cmdString.Parameters.Add("@PRESCRIPTION_ID", SqlDbType.Int).Value = prescriptionId;
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
