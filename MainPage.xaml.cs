using Microsoft.Maui.Controls;
using System;

namespace PontoProf
{
    
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LogarButton_Clicked(object sender, EventArgs e)
        {
            // Lógica para fazer login
            string drt = DrtEntry.Text;
            string senha = SenhaEntry.Text;

            // Exibir mensagem de sucesso ou erro
            if (drt == "usuario" && senha == "senha")
            {
                DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Erro", "DRT ou senha inválidos!", "OK");
            }
        }
    }
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SalvarButton_Clicked(object sender, EventArgs e)
        {
            // Lógica para salvar informações do professor
            string nome = NomeEntry.Text;
            TimeSpan horario = HorarioEntry.Time;
            string sala = SalaEntry.Text;

            // Exibir mensagem de sucesso
            DisplayAlert("Sucesso", "Professor cadastrado com sucesso!", "OK");
        }


    }
}

