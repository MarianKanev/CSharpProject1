using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAP.Middleware.Connector;

namespace ConsoleApplication_SAP_Connect
{
    class Program
    {
        static void Main(string[] args)
        {


            RfcConfigParameters config = new RfcConfigParameters();
            config.Add(RfcConfigParameters.Name, "C11");
            config.Add(RfcConfigParameters.AppServerHost, "Marko2003");
            config.Add(RfcConfigParameters.SystemNumber, "00");
            config.Add(RfcConfigParameters.User, "marian");
            config.Add(RfcConfigParameters.Password, "start1010");
            config.Add(RfcConfigParameters.Client, "800");
            config.Add(RfcConfigParameters.Language, "EN");

            RfcDestination destination = RfcDestinationManager.GetDestination(config);
            RfcRepository repository = destination.Repository;
            IRfcFunction function = repository.CreateFunction("ZJCO_GET_MARA_DETAILS");
            function.SetValue("P_MATNR", "200-250");

            function.Execute();

            //IRfcStructure structure = repository.GetTableMetadata("MARA");

            //string matnr = function.GetString("IT_MARA-MATNR");
            //Console.WriteLine(matnr);

            //string created_by = function.GetString("IT_MARA-CREATED_BY");
            //Console.WriteLine(created_by);




            iRFCFunction func = con.CreateFunction("BAPI_EMPLOYEE_GETLIST");
            func.Exports["SUR_NAME_SEARK"].ParamValue = "TH*";
            func.Execute();
            foreach (RFCStructure row in func.Tables["EMPLOYEE_LIST"].Rows)
                Console.WriteLine(row["ENAME"].ToString());
            con.Close();

            catch (RfcAbapException ex)
            {
                if (ex.Key == "CARR_NOT_FOUND")
                    Console.WriteLine("Airline company not found with given id.");
            }
            Console.ReadLine();




        }
    }
}
