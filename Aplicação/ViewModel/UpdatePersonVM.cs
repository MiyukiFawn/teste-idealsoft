using Aplicação.Model;
using Aplicação.Service;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicação.ViewModel;
public partial class UpdatePersonVM : ObservableObject {
    private PersonService personService = PersonService.GetInstance();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(UpdatePersonCommand))]
    bool canSave = true;

    [ObservableProperty]
    Person? selectedPerson = null;

    [ObservableProperty]
    string? name;

    [ObservableProperty]
    string? surname;

    [ObservableProperty]
    string? phone;

    private bool CanUpdate() => CanSave;
    [RelayCommand(CanExecute = nameof(CanUpdate))]
    async Task UpdatePerson(Window window) {
        if (Name == null) {
            MessageBox.Show("Por favor insira um nome válido");
            return;
        }
        if (Name.Length < 3) {
            MessageBox.Show("O nome precisa ter ao menos 3 caracteres");
            return;
        }

        if (Surname == null) {
            MessageBox.Show("Por favor insira um sobrenome válido");
            return;
        }
        if (Surname.Length < 3) {
            MessageBox.Show("O sobrenome precisa ter ao menos 3 caracteres");
            return;
        }

        if (Phone == null) {
            MessageBox.Show("Por favor insira um telefone válido");
            return;
        }
        if (Phone.Length < 9) {
            MessageBox.Show("O telefone precisa ter ao menos 9 caracteres");
            return;
        }
        if (!Regex.IsMatch(Phone, @"^[0-9]*$")) {
            MessageBox.Show("Por favor insira somente números no campo de telefone");
            return;
        }

        CanSave = false;
        await personService.UpdatePerson(SelectedPerson!.Id, Name, Surname, Phone);

        window?.Close();
    }
}
