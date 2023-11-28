using Aplicação.Model;
using Aplicação.Service;
using Aplicação.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Aplicação.ViewModel;

public partial class MainWindowVM : ObservableObject {
    private PersonService personService = PersonService.GetInstance();

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(CreatePersonCommand))]
    bool canCreate = false;

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(EditPersonCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeletePersonCommand))]
    Person? selectedPerson = null;

    [ObservableProperty]
    ObservableCollection<Person> peoples = new();

    public MainWindowVM() {
        _ = GetPeople();
    }

    private async Task GetPeople() {
        CanCreate = false;
        
        var list = await personService.GetPeople();
        Peoples = new ObservableCollection<Person>(list);
        
        CanCreate = true;
    }

    private bool CanCreatePerson() => CanCreate;
    [RelayCommand(CanExecute = nameof(CanCreatePerson))]
    private void CreatePerson() {
        var createPersonWindow = new CreatePersonWindow();
        createPersonWindow.ShowDialog();

        _ = GetPeople();
    }

    private bool CanEditPerson() => SelectedPerson != null;
    [RelayCommand(CanExecute = nameof(CanEditPerson))]
    private void EditPerson() {
        if (SelectedPerson == null)
            return;

        var updatePersonWindow = new UpdatePersonWindow();
        var vm = updatePersonWindow.DataContext as UpdatePersonVM;

        vm!.SelectedPerson = SelectedPerson;
        vm!.Name = SelectedPerson.Name;
        vm!.Surname = SelectedPerson.Surname;
        vm!.Phone = SelectedPerson.Phone;

        updatePersonWindow.ShowDialog();

        _ = GetPeople();
    }

    private bool CanDeletePerson() => SelectedPerson != null;
    [RelayCommand(CanExecute = nameof(CanDeletePerson))]
    private async Task DeletePerson() {
        if (SelectedPerson == null)
            return;
        MessageBoxResult result = MessageBox.Show("Tem certeza que deseja remover o usuário " + SelectedPerson.Name + " " + SelectedPerson.Surname + "?",
            "Aviso",
            MessageBoxButton.YesNo);

        if (result == MessageBoxResult.Yes) {
            await personService.DeletePerson(SelectedPerson.Id);
            _ = GetPeople();
        }
    }
}
