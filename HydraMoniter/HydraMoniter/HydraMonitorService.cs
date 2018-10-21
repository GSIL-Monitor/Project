using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HydraMoniter
{
    public partial class HydraMonitorService : ServiceBase
    {
        public HydraMonitorService()
        {
            InitializeComponent();
        }
 
        string filePath = "";
 
        protected override void OnStart(string[] args)
        {
            try
            {
                Log.Write("Service Starts");
                long lInterval = 3000;
                string sInterval = ConfigurationManager.AppSettings["interval"].ToString();
                long lIntervalConfig = 0;
                if (long.TryParse(sInterval, out lIntervalConfig) && lIntervalConfig > 0)
                    lInterval = lIntervalConfig * 1000;
                Timer t = new Timer();
                t.Interval = lInterval;
                t.Elapsed += new System.Timers.ElapsedEventHandler(DoTask);

                t.AutoReset = true;
                t.Enabled = true;
            }
            catch (Exception e)
            {
                Log.Write(e.Message);
            }
        }

        protected override void OnStop()
        {
            Log.Write("Service Stops");
          
        }
 
        private void DoTask(object source, System.Timers.ElapsedEventArgs e)
        {
            Task.CopyFinishData();//将完工数据复制
        }

       
    }
}
