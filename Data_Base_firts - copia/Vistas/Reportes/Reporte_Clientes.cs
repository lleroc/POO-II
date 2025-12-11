using Data_Base_firts.Controladores;
using Microsoft.Reporting.WinForms;

namespace Data_Base_firts.Vistas.Reportes
{
    public partial class Reporte_Clientes : Form
    {
        private readonly ReportViewer _reportViewer;
        private readonly clientesControlles _clientesControlles = new clientesControlles();

        public Reporte_Clientes()

        {
            InitializeComponent();
            _reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };
            this.Controls.Add(_reportViewer);
            // Ruta del RDLC (ajusta el nombre si difiere)
            var rdlcPath = Path.Combine(AppContext.BaseDirectory, "Vistas/Reportes", "clientes.rdlc");
            _reportViewer.LocalReport.ReportPath = rdlcPath;

            // Obtén datos del controlador
            var clientes = _clientesControlles.GetAllClientes();

            // Limpia fuentes anteriores y agrega la nueva
            _reportViewer.LocalReport.DataSources.Clear();
            _reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DS_Clientes", clientes));

            // Refresca
            _reportViewer.RefreshReport();
        }

        private void Reporte_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
