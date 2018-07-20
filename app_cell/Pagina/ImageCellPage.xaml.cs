using System;
using System.Collections.Generic;
using app_cell.Modelo;

using Xamarin.Forms;

namespace app_cell.Pagina
{
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "senador16.jpg", Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Foto = "senador558.jpg", Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "senador643.jpg", Nome = "Elaine", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "senador4558.jpg", Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "senador5236.jpg", Nome = "João", Cargo = "Vendedor" });

            lsvFuncionarios.ItemsSource = Lista;
        }
    }
}
