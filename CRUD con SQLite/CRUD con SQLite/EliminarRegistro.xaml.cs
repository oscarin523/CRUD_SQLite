﻿using System;
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
    /// Lógica de interacción para EliminarRegistro.xaml
    /// </summary>
    public partial class EliminarRegistro : Window
    {
        public EliminarRegistro()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection (App.databasePath))
            {
                string sentenciaSQL = "delete from Registros where Nombreguitarra='" + txtEliminar.Text + "'";
                conexion.Execute(sentenciaSQL);
            }
            Close();
        }

        private void txtEliminar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
