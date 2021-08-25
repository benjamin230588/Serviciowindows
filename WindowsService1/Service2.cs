using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WindowsService1.Modelo;

namespace WindowsService1
{
    partial class Service2 : ServiceBase
    {
        public Service2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            EventLog.WriteEntry("Inicio de Servicio", EventLogEntryType.Information);
            reloj.Start();
        }

        protected override void OnStop()
        {
           
            reloj.Stop();
            EventLog.WriteEntry("Detuvo el Servicio", EventLogEntryType.Information);
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
        }

        private void reloj_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                reloj.Enabled = false;
                EventLog.WriteEntry("Inicio el reloj", EventLogEntryType.Information);

                using (var db = new pruebaEntities())
                {
                    cliente model = new cliente();
                    //model.id = 1;
                    model.name = "Josue";
                    model.fecha = DateTime.Now;

                    db.cliente.Add(model);
                    db.SaveChanges();
                }
                EventLog.WriteEntry("Ejecutado con Exito", EventLogEntryType.Information);
                reloj.Enabled = true;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("error al ejecutar servicio", EventLogEntryType.Error);
            }
        }
    }
}
