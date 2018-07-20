using System;
using System.Collections.Generic;
using app_cell.Modelo;

using Xamarin.Forms;

namespace app_cell.Pagina
{
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            lsvFuncionarios.ItemsSource = Lista;
        }

        private void ActionFerias(object sender, EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario funcionario = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Funcionário: " + funcionario.Nome, "Férias marcadas para: " + funcionario.Nome + " - " + funcionario.Cargo, "OK");
        }
    }
}
