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
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;

namespace WindowsServiceTutorials
{
    public partial class Service1 : ServiceBase
    {
        Timer timer=new Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string message = "Service started ";
            EmailService.SendEmail(message);
        }

      
        protected override void OnStop()
        {
            string message = "Service stopped ";
            EmailService.SendEmail(message);
        }
        
    }
}
