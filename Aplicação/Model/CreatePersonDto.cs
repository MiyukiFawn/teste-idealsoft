using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação.Model;
public class CreatePersonDto {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }

    public CreatePersonDto(string name, string surname, string phone) {
        Name = name;
        Surname = surname;
        Phone = phone;
    }
}
