using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Exercise2_004_Nanda_yudha_pratama;

namespace ServerConfigRest_004_Nanda_yudha_pratama
{
    class Server
    {
        internal void OnServer()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                Console.WriteLine("Server is Ready!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        internal void OffServer()
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                Console.WriteLine("Server is Off!!!");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
