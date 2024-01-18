using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class Department : Entity
{
    public Department(int id):base(id) { }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Department(string name,string description)
    {
        Name = name;
        Description = description;
    }

    public Department(int id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }
}


