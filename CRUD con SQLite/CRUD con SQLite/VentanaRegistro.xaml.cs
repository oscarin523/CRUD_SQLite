using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CRUD_con_SQLite.Clases;
using SQLite;

namespace CRUD_con_SQLite
{
    /// <summary>
    /// Lógica de interacción para VentanaRegistro.xaml
    /// </summary>
    public partial class VentanaRegistro : Window
    {
        List<Registros> Registros;

        public VentanaRegistro()
        {
            InitializeComponent();
            Registros = new List<Registros>();
            LeerBaseDatos();
            
        }

        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Registros>();
                Registros = (conn.Table<Registros>().ToList()).OrderBy(c => c.Nombreguitarra).ToList();
            }
            if (Registros!=null)
            {
                lvRegistros.ItemsSource = Registros;
            }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            CRUD_con_SQLite.MainWindow form = new CRUD_con_SQLite.MainWindow();
            form.ShowDialog();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            CRUD_con_SQLite.EliminarRegistro form = new CRUD_con_SQLite.EliminarRegistro();
            form.ShowDialog();
        }

    }
}
