using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace creaciondecarpeta
{
    partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            lapso.Start();
            // prueba real
            // otro cambio
        }

        protected override void OnStop()
        {
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
          
        }

        private void lapso_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            EventLog.WriteEntry("hola mundo", EventLogEntryType.Information);
            lapso.Stop();
        }
    }
}
