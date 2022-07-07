using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace digiseiWindowsService
{
    public partial class Service1 : ServiceBase
    {
        private int eventId = 1;
        private System.Diagnostics.EventLog eventLog1;

        public Service1()
        {
            InitializeComponent();
            InitializeEventLog();
        }

        private void InitializeEventLog()
        {
            eventLog1 = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "Z project", "Register made by Carlo");
            }
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        public void OnDebug()
        {
            OnStart(null);
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {

            //here stamp a information basing on http to bluemilk
            // TODO: Insert monitoring activities here.
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }

        private void StartATimer()
        {
            // Set up a timer that triggers every minute.
            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }
        protected override void OnStart(string[] args)
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt");
            StartATimer();
            eventLog1.WriteEntry("In OnStart.");
        }

        protected override void OnStop()
        {
            System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt");
            eventLog1.WriteEntry("In OnStop.");
        }
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In OnContinue.");
        }
    }
}
