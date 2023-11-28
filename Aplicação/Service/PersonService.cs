using Aplicação.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Aplicação.Service;
public sealed class PersonService {
    private static PersonService _instance = new();
    private static string _apiUrl = "https://idealsoft-api.azurewebsites.net/api";
    private static HttpClient _client = new();

    public static PersonService GetInstance() => _instance;

    public async Task<List<Person>> GetPeople() {
        List<Person> people;
        try {
            people = await _client.GetFromJsonAsync<List<Person>>(_apiUrl + "/person") ?? new();
        }
        catch (Exception) {
            throw;
        }
        return people;
    }

    public async Task CreatePerson(string name, string surname, string phone) {
        try {
            await _client.PostAsJsonAsync(_apiUrl + "/person", new CreatePersonDto(name, surname, phone));
        }
        catch (Exception) {
            throw;
        }
    }

    public async Task UpdatePerson(Guid id, string name, string surname, string phone) {
        try {
            await _client.PutAsJsonAsync(_apiUrl + "/person/" + id, new CreatePersonDto(name, surname, phone));
        }
        catch (Exception) {
            throw;
        }
    }

    public async Task DeletePerson(Guid id) {
        try {
            await _client.DeleteAsync(_apiUrl + "/person/" + id);
        }
        catch (Exception) {

            throw;
        }
    }
}
