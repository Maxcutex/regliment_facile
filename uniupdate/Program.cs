using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bola.MiscHelper;
using ISO8583Connect;

namespace uniupdate
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskCount = Convert.ToInt16(ConfigurationManager.AppSettings["taskCount"]);
            var tasks = new Task[taskCount]; for (var i = 0; i < taskCount; i++) { tasks[i] = Task.Factory.StartNew(() => PullTransactions(i)); }
            Task.WaitAll(tasks);

            //Task task1 = Task.Factory.StartNew(() => PullTransactions(1));
            //Task task2 = Task.Factory.StartNew(() => PullTransactions(2));
            //Task task3 = Task.Factory.StartNew(() => PullTransactions(3));
            //Task task4 = Task.Factory.StartNew(() => PullTransactions(4));
            //Task task5 = Task.Factory.StartNew(() => PullTransactions(5));
            //Task task6 = Task.Factory.StartNew(() => PullTransactions(6));
            //Task task7 = Task.Factory.StartNew(() => PullTransactions(7));
            //Task task8 = Task.Factory.StartNew(() => PullTransactions(8));
            //Task task9 = Task.Factory.StartNew(() => PullTransactions(9));
            //Task task10 = Task.Factory.StartNew(() => PullTransactions(10));
            //Task task11 = Task.Factory.StartNew(() => PullTransactions(11));
            //Task task12 = Task.Factory.StartNew(() => PullTransactions(12));
            //Task task13 = Task.Factory.StartNew(() => PullTransactions(13));
            //Task task14 = Task.Factory.StartNew(() => PullTransactions(14));
            //Task task15 = Task.Factory.StartNew(() => PullTransactions(15));
            //Task task16 = Task.Factory.StartNew(() => PullTransactions(16));
            //Task task17 = Task.Factory.StartNew(() => PullTransactions(17));
            //Task task18 = Task.Factory.StartNew(() => PullTransactions(18));
            //Task task19 = Task.Factory.StartNew(() => PullTransactions(19));
            //Task task20 = Task.Factory.StartNew(() => PullTransactions(20));
            //Task task21 = Task.Factory.StartNew(() => PullTransactions(21));
            //Task task22 = Task.Factory.StartNew(() => PullTransactions(22));
            //Task task23 = Task.Factory.StartNew(() => PullTransactions(23));
            //Task task24 = Task.Factory.StartNew(() => PullTransactions(24));
            //Task task25 = Task.Factory.StartNew(() => PullTransactions(25));
            //Task task26 = Task.Factory.StartNew(() => PullTransactions(26));
            //Task task27 = Task.Factory.StartNew(() => PullTransactions(27));
            //Task task28 = Task.Factory.StartNew(() => PullTransactions(28));
            //Task task29 = Task.Factory.StartNew(() => PullTransactions(29));
            //Task task30 = Task.Factory.StartNew(() => PullTransactions(30));
            //Task task31 = Task.Factory.StartNew(() => PullTransactions(31));
            //Task task32 = Task.Factory.StartNew(() => PullTransactions(32));
            //Task task33 = Task.Factory.StartNew(() => PullTransactions(33));
            //Task task34 = Task.Factory.StartNew(() => PullTransactions(34));
            //Task task35 = Task.Factory.StartNew(() => PullTransactions(35));
            //Task task36 = Task.Factory.StartNew(() => PullTransactions(36));
            //Task task37 = Task.Factory.StartNew(() => PullTransactions(37));
            //Task task38 = Task.Factory.StartNew(() => PullTransactions(38));
            //Task task39 = Task.Factory.StartNew(() => PullTransactions(39));
            //Task task40 = Task.Factory.StartNew(() => PullTransactions(40));
            //Task task41 = Task.Factory.StartNew(() => PullTransactions(41));
            //Task task42 = Task.Factory.StartNew(() => PullTransactions(42));
            //Task task43 = Task.Factory.StartNew(() => PullTransactions(43));
            //Task task44 = Task.Factory.StartNew(() => PullTransactions(44));
            //Task task45 = Task.Factory.StartNew(() => PullTransactions(45));
            //Task task46 = Task.Factory.StartNew(() => PullTransactions(46));
            //Task task47 = Task.Factory.StartNew(() => PullTransactions(47));
            //Task task48 = Task.Factory.StartNew(() => PullTransactions(48));
            //Task task49 = Task.Factory.StartNew(() => PullTransactions(49));
            //Task task50 = Task.Factory.StartNew(() => PullTransactions(50));
            //Task task51 = Task.Factory.StartNew(() => PullTransactions(51));
            //Task task52 = Task.Factory.StartNew(() => PullTransactions(52));
            //Task task53 = Task.Factory.StartNew(() => PullTransactions(53));
            //Task task54 = Task.Factory.StartNew(() => PullTransactions(54));
            //Task task55 = Task.Factory.StartNew(() => PullTransactions(55));
            //Task task56 = Task.Factory.StartNew(() => PullTransactions(56));
            //Task task57 = Task.Factory.StartNew(() => PullTransactions(57));
            //Task task58 = Task.Factory.StartNew(() => PullTransactions(58));
            //Task task59 = Task.Factory.StartNew(() => PullTransactions(59));
            //Task task60 = Task.Factory.StartNew(() => PullTransactions(60));
            //Task task61 = Task.Factory.StartNew(() => PullTransactions(61));
            //Task task62 = Task.Factory.StartNew(() => PullTransactions(62));
            //Task task63 = Task.Factory.StartNew(() => PullTransactions(63));
            //Task task64 = Task.Factory.StartNew(() => PullTransactions(64));
            //Task task65 = Task.Factory.StartNew(() => PullTransactions(65));
            //Task task66 = Task.Factory.StartNew(() => PullTransactions(66));
            //Task task67 = Task.Factory.StartNew(() => PullTransactions(67));
            //Task task68 = Task.Factory.StartNew(() => PullTransactions(68));
            //Task task69 = Task.Factory.StartNew(() => PullTransactions(69));
            //Task task70 = Task.Factory.StartNew(() => PullTransactions(70));
            //Task task71 = Task.Factory.StartNew(() => PullTransactions(71));
            //Task task72 = Task.Factory.StartNew(() => PullTransactions(72));
            //Task task73 = Task.Factory.StartNew(() => PullTransactions(73));
            //Task task74 = Task.Factory.StartNew(() => PullTransactions(74));
            //Task task75 = Task.Factory.StartNew(() => PullTransactions(75));
            //Task task76 = Task.Factory.StartNew(() => PullTransactions(76));
            //Task task77 = Task.Factory.StartNew(() => PullTransactions(77));
            //Task task78 = Task.Factory.StartNew(() => PullTransactions(78));
            //Task task79 = Task.Factory.StartNew(() => PullTransactions(79));
            //Task task80 = Task.Factory.StartNew(() => PullTransactions(80));
            //Task task81 = Task.Factory.StartNew(() => PullTransactions(81));
            //Task task82 = Task.Factory.StartNew(() => PullTransactions(82));
            //Task task83 = Task.Factory.StartNew(() => PullTransactions(83));
            //Task task84 = Task.Factory.StartNew(() => PullTransactions(84));
            //Task task85 = Task.Factory.StartNew(() => PullTransactions(85));
            //Task task86 = Task.Factory.StartNew(() => PullTransactions(86));
            //Task task87 = Task.Factory.StartNew(() => PullTransactions(87));
            //Task task88 = Task.Factory.StartNew(() => PullTransactions(88));
            //Task task89 = Task.Factory.StartNew(() => PullTransactions(89));
            //Task task90 = Task.Factory.StartNew(() => PullTransactions(90));
            //Task task91 = Task.Factory.StartNew(() => PullTransactions(91));
            //Task task92 = Task.Factory.StartNew(() => PullTransactions(92));
            //Task task93 = Task.Factory.StartNew(() => PullTransactions(93));
            //Task task94 = Task.Factory.StartNew(() => PullTransactions(94));
            //Task task95 = Task.Factory.StartNew(() => PullTransactions(95));
            //Task task96 = Task.Factory.StartNew(() => PullTransactions(96));
            //Task task97 = Task.Factory.StartNew(() => PullTransactions(97));
            //Task task98 = Task.Factory.StartNew(() => PullTransactions(98));
            //Task task99 = Task.Factory.StartNew(() => PullTransactions(99));
            //Task task100 = Task.Factory.StartNew(() => PullTransactions(100));


            ////Task.WaitAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10);

            //Task.WaitAll(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
            //    task11, task12, task13, task14, task15, task16, task17, task18, task19, task20,
            //    task21, task22, task23, task24, task25, task26, task27, task28, task29, task30,
            //    task31, task32, task33, task34, task35, task36, task37, task38, task39, task40,
            //    task41, task42, task43, task44, task45, task46, task47, task48, task49, task50,
            //    task51, task52, task53, task54, task55, task56, task57, task58, task59, task60,
            //    task61, task62, task63, task64, task65, task66, task67, task68, task69, task70,
            //    task71, task72, task73, task74, task75, task76, task77, task78, task79, task80,
            //    task81, task82, task83, task84, task85, task86, task87, task88, task89, task90,
            //    task91, task92, task93, task94, task95, task96, task97, task98, task99, task100);
        }
        public static void LogFileWrite(string message,int threadId)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null; var folderName = ConfigurationManager.AppSettings["ErrorPath"];
            try
            {
                string logFilePath = "";

                logFilePath = logFilePath + folderName + "ErrorLog_Thread" + threadId + "-" + DateTime.Today.ToString("yyyyMMdd") + "." + "txt";

                if (logFilePath.Equals("")) return;
                #region Create the Log file directory if it does not exists 
                DirectoryInfo logDirInfo = null;
                FileInfo logFileInfo = new FileInfo(logFilePath);
                logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists) logDirInfo.Create();
                #endregion Create the Log file directory if it does not exists

                if (!logFileInfo.Exists)
                {
                    fileStream = logFileInfo.Create();
                }
                else
                {
                    fileStream = new FileStream(logFilePath, FileMode.Append);
                }
                streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(message);
            }
            finally
            {
                if (streamWriter != null) streamWriter.Close();
                if (fileStream != null) fileStream.Close();
            }

        }
        static void PullTransactions(int threadId)
        {
            try
            {
                var dt = TranAccess.PullPendingTran(threadId);
                foreach (DataRow dr in dt.Rows)
                {
                    var stanVal = "";
                    var stanDate = new DateTime();
                     
                        //stanVal = DateTime.Now.ToString("yyMMddHH") + DateTime.Now.ToString("mmss");
                    stanVal = MyHelperClass.GenerateRandomString(4) + DateTime.Now.ToString("ddHHmmss");


                    if (String.IsNullOrEmpty(dr["value_date"].ToString()))
                        {
                            stanDate = DateTime.Now;
                        }
                        else
                        {
                            stanDate = Convert.ToDateTime(dr["value_date"].ToString());
                        }
                   // MyHelperClass.WriteLog(stanVal + " for " + dr["refId"].ToString() + "== ");
                    LogFileWrite(stanVal + " for " + dr["refId"].ToString() + "== ", threadId);
                    var up = TranAccess.UpdateStan(Convert.ToInt64(dr["refId"].ToString()), stanVal, stanDate);
                    // post to service
                    var identifier = dr["transaction_type"].ToString();
                    if (identifier == null || identifier == "")
                    {
                       identifier =  identifier.Substring(0, 3);
                    }
                    var debitAccount = dr["debit_account_number"].ToString();
                    var creditAccount = dr["credit_account_number"].ToString();
                    var currency = dr["currency"].ToString();
                    var transactionAmount = Convert.ToDouble(dr["transaction_amount"].ToString());
                    var tranParticular2 = dr["transaction_particular2"].ToString();
                    var transactionRefernce = dr["transaction_reference"].ToString();
                    var transactionParticular = dr["transaction_particular1"].ToString();
                    var originalRefNum = dr["original_ref_num"].ToString();

                    var res = PostTransaction(debitAccount, creditAccount, currency,transactionAmount, stanDate, stanVal, tranParticular2, transactionRefernce, transactionParticular, identifier,threadId, originalRefNum);
                    var result = res.Split('|');                     
                    var fi = TranAccess.UpdateAfterPost(Convert.ToInt64(dr["refId"].ToString()), "Y",result[1].Replace("::", "").TrimStart('7'),  result[0],result[1]);
                    LogFileWrite(result[0] + "==" + result[1] + "==" + result[2] + "==", threadId);
                    
                }
            }
            catch (Exception e)
            {
                 MyHelperClass.WriteLog(e);
                LogFileWrite(e.Message, threadId);
            }
           
        }

        public static string PostTransaction(string debitAccount, string creditAccount, string currency, double amount, DateTime transValueDate, string stan,string sessionId,string tranRemarks, string appDesc, string identifier,int threadId, string tranRef)
        {
            var bankId = ConfigurationManager.AppSettings["bankId"];
            var controllerId = ConfigurationManager.AppSettings["controllerId"];
            var ipAddress = ConfigurationManager.AppSettings["finacleIp"];
            // live "10.0.0.133"; // test "10.0.33.13"; 
            var ntranDate = transValueDate;
           // var te = amount.ToString();
            //amount = amount * 100;
            if (ConfigurationManager.AppSettings["Environment"] == "Test")
            {
                ntranDate = Convert.ToDateTime(ConfigurationManager.AppSettings["TestDate"]);
            }
            
            // transValueDate; //Convert.ToDateTime("2015-07-27 00:00:00");
            var port = Convert.ToInt32(ConfigurationManager.AppSettings["finaclePort"]);
            // live 47002; // test 48027; //
            Response resCharge;
            var uniqueId = stan; //MyHelperClass.GenerateRandomString(8) + DateTime.Now.Date.Second + rnd.Next();
            var xFTran = new FundTransfer(controllerId, ipAddress, port);
           
            try
            {
                //xFTran.ValueDate = transValueDate;
                xFTran.ValueDate = ntranDate;
                xFTran.Field41CardAcceptorTerminalId = "000000003REC9991";
                
                xFTran.Field2PAN = "9890190000000000000";
                switch (currency)
                {
                    case "NGN":
                        xFTran.Currency = new Currency(Currency.CURRENCY_REF.NGN);
                        break;
                    case "USD":
                        xFTran.Currency = new Currency(Currency.CURRENCY_REF.USD);
                        break;
                    case "GBP":
                        xFTran.Currency = new Currency(Currency.CURRENCY_REF.GBP);
                        break;
                    case "EUR":
                        xFTran.Currency = new Currency(Currency.CURRENCY_REF.EUR);
                        break;
                }
                
                xFTran.OptionalFieldData = "70NGND000000000000000000000001D0000000000000000NGN"; //Field46
                
                xFTran.Field37RetrievalReferenceNumber = stan;
                xFTran.Field42CardAcceptorTerminalCode = "RECONCILIATION1";
                xFTran.Field124InfoText = identifier;
               
                xFTran.Field125OptionalField1 = sessionId; 
                xFTran.Field126OptionalField2 = tranRemarks;
                xFTran.Field127OptionalField3 = tranRef;
                resCharge = xFTran.Commit(amount, debitAccount, creditAccount,  appDesc , uniqueId);
                MyHelperClass.WriteLog(xFTran.Diagnosis.ToString());
            }
            catch (Exception ex)
            {
               // MyHelperClass.WriteLog(ex);
                LogFileWrite(ex.Message, threadId);
                return "-99|Error: " + ex.Message + "|" + uniqueId;
            }
            if (resCharge != Response.TransactionApproved)
            {
                return "-1|" + resCharge + "|" + uniqueId;
            }
            return "0|" + Right(xFTran.Diagnosis.Trim(), 9) + "|" + uniqueId;
        }
        public static string Right(string value, int length)
        {
            return value.Substring(value.Length - length);
        }
    }
}
