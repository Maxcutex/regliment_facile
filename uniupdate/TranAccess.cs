using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bola.MiscHelper;

namespace uniupdate
{
  public  class TranAccess
    {
        public TranAccess()
        {
        }
        public static DataTable PullPendingTran(int threadId)
        {

            var dt = new DataTable();
            var da = new SqlDataAdapter();
            var ds = new DataSet();

            //  bool OpnrtnStatus = false;

            using (SqlConnection connection = new SqlConnection(AppConfig.DailyTranConnection))
            {
                //(Real Live Query)
                string query = "MAC_sp_getPendingTransactions";

                try
                {
                    SqlCommandBuilder cb = default(SqlCommandBuilder);

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                         command.Parameters.Add("@threadId", SqlDbType.Int);
                          command.Parameters["@threadId"].Value = threadId;
                        da.SelectCommand = command;
                        cb = new SqlCommandBuilder(da);
                        da.Fill(ds);
                        //da.Fill(dt)
                        dt = ds.Tables[0];

                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    MyHelperClass.WriteLog(ex);
                }
            }
            return dt;
        }

        public static int UpdateStan(long refId,string stan,DateTime sysDate)
        {
            var ret = 0; 
            using (SqlConnection connection = new SqlConnection(AppConfig.DailyTranConnection))
            {
                //(Real Live Query)
                string query = "MAC_sp_updateStanTransactions";

                try
                {
                    SqlCommandBuilder cb = default(SqlCommandBuilder);

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@refId", SqlDbType.BigInt);
                        command.Parameters["@refId"].Value = refId;
                        command.Parameters.Add("@stan", SqlDbType.VarChar);
                        command.Parameters["@stan"].Value = stan;
                        command.Parameters.Add("@sysdate", SqlDbType.DateTime);
                        command.Parameters["@sysdate"].Value = sysDate;

                        var returnPar = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnPar.Direction = ParameterDirection.ReturnValue;
                        command.ExecuteNonQuery();
                        return Convert.ToInt16(returnPar.Value);
                    }
                }
                catch (Exception ex)
                {
                    MyHelperClass.WriteLog(ex);
                }
            }
            return ret;
        }

        public static int UpdateAfterPost(long refId,string postedFlag,string tranId,string respCode,string message)
        {
            var ret = 0; 
            using (SqlConnection connection = new SqlConnection(AppConfig.DailyTranConnection))
            {
                string query = "MAC_sp_updateFinalTransactions";
                try
                {
                    SqlCommandBuilder cb = default(SqlCommandBuilder);

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@refId", SqlDbType.BigInt);
                        command.Parameters["@refId"].Value = refId;
                        command.Parameters.Add("@postedFlag", SqlDbType.VarChar);
                        command.Parameters["@postedFlag"].Value = postedFlag;
                        command.Parameters.Add("@tranId", SqlDbType.VarChar);
                        command.Parameters["@tranId"].Value = tranId;

                       

                        command.Parameters.Add("@respCode", SqlDbType.VarChar);
                        command.Parameters["@respCode"].Value = respCode;
                        command.Parameters.Add("@message", SqlDbType.VarChar);
                        command.Parameters["@message"].Value = message;

                        var returnPar = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnPar.Direction = ParameterDirection.ReturnValue;
                        command.ExecuteNonQuery();
                        return Convert.ToInt16(returnPar.Value);
                    }
                }
                catch (Exception ex)
                {
                    MyHelperClass.WriteLog(ex);
                }
            }
            return ret;
        }

        public static int ArchiveTransaction(long refId)
        {
            var ret = 0;
            using (SqlConnection connection = new SqlConnection(AppConfig.DailyTranConnection))
            {
                string query = "MAC_sp_updateTransactionHistory";
                try
                {
                    SqlCommandBuilder cb = default(SqlCommandBuilder);

                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@refId", SqlDbType.BigInt);
                        command.Parameters["@refId"].Value = refId;
                        var returnPar = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnPar.Direction = ParameterDirection.ReturnValue;
                        command.ExecuteNonQuery();
                        return Convert.ToInt16(returnPar.Value);
                    }
                }
                catch (Exception ex)
                {
                    MyHelperClass.WriteLog(ex);
                }
            }
            return ret;
        }

    }
}
