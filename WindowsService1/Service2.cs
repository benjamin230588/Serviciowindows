using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsService1.Modelo;
using WindowsService1.reporte;

namespace WindowsService1
{
    partial class Service2 : ServiceBase
    {
        Boolean bandera = false;
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
            //if (bandera) return;
            try
            {
                reloj.Enabled = false;
                //bandera = true;
                EventLog.WriteEntry("Inicio el reloj hoy ", EventLogEntryType.Information);
                Thread.Sleep(15000);
                //using (var db = new pruebaEntities())
                //{
                //    cliente model = new cliente();
                //    //model.id = 1;
                //    model.name = "servicio";
                //    model.fecha = DateTime.Now;

                //    db.cliente.Add(model);
                //    db.SaveChanges();
                //}
                CrystalReport1 reporte = new CrystalReport1();
                ////reporte.SetParameterValue(0, filtro);
                //reporte.SetDatabaseLogon("sa", "1234", "LAPTOP-ICLC5GJE\\SQLEXPRESS", "Inventario");
                //string ruta = "D:\\BOSAP\\benjamin.pdf";

                ////reporte.DataSourceConnections(0).SetConnection(server, basedatos1, user, password)
                //reporte.SetDatabaseLogon("sa", "1234", "LAPTOP-ICLC5GJE\\SQLEXPRESS", "imagenes");
               

                //var doctoPrint = new System.Drawing.Printing.PrintDocument();
                //doctoPrint.PrinterSettings.PrinterName = "EPSON L3150 Series"; //printer es el nombre de la impresora por donde imprimirá
                ////reporte.PrintOptions.PaperSize

                //for (var j = 0; j < doctoPrint.PrinterSettings.PaperSizes.Count; j++) { 
                //    if (doctoPrint.PrinterSettings.PaperSizes[j].PaperName == "benja34555") //tamañoPapel es el nombre del tamaño parametrizado
                //    {
                //        reporte.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)doctoPrint.PrinterSettings.PaperSizes[j].RawKind;
                //        break;
                //    }
                //}
                //reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
                //reporte.PrintOptions.PrinterName = "EPSON L3150 Series";
                //reporte.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
                //reporte.PrintToPrinter(1, false, 0, 0);
                EventLog.WriteEntry("Ejecutado con Exito", EventLogEntryType.Information);
                //reporte.Clone();
                //reporte.Dispose();
                //bandera = false;
                reloj.Enabled = true;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("error al ejecutar servicio", EventLogEntryType.Error);
            }
        }
    }
}
