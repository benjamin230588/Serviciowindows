
namespace WindowsService1
{
    partial class Service2
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.reloj = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.reloj)).BeginInit();
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Interval = 10000D;
            this.reloj.Elapsed += new System.Timers.ElapsedEventHandler(this.reloj_Elapsed);
            // 
            // Service2
            // 
            this.ServiceName = "Service2";
            ((System.ComponentModel.ISupportInitialize)(this.reloj)).EndInit();

        }

        #endregion

        private System.Timers.Timer reloj;
    }
}
