using System;
using System.Collections.Generic;
using app_cell.Modelo;

using Xamarin.Forms;

namespace app_cell.Detalhe
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Funcionario funcionario)
        {
            InitializeComponent();
            lblNome.Text = funcionario.Nome;
            lblCargo.Text = funcionario.Cargo;
        }
    }
}
