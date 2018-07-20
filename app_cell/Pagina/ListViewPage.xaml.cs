using System;
using System.Collections.Generic;
using app_cell.Modelo;
using app_cell.Detalhe;

using Xamarin.Forms;

namespace app_cell.Pagina
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
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

        private void ActionItemSelecionado(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario funcionario = (Funcionario)args.SelectedItem;

            Navigation.PushAsync(new DetailPage(funcionario));
        }

        private void ActionFerias (object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario funcionario = (Funcionario)botao.CommandParameter;

            DisplayAlert("Funcionário: " + funcionario.Nome, "Férias marcadas para: " + funcionario.Nome + " - " + funcionario.Cargo, "OK");
        }

        private void ActionAbono (object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario funcionario = (Funcionario)botao.CommandParameter;

            DisplayAlert("Funcionário: " + funcionario.Nome, "Abono concedido para: " + funcionario.Nome + " - " + funcionario.Cargo, "OK");
        }
    }
}
