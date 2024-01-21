using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;
public class User : Entity
{
    public User() { }
    public User(string name, string emailAddress, int profileId, int departmentId, IEnumerable<int> churchIds)
    {
        Name = name;
        EmailAddress = emailAddress;
        CreationDate = DateTime.Now;
        ProfileId = profileId;
        DepartmentId = departmentId;

        AddChurchs(churchIds.ToList());
    }

    public User(string name, string emailAddress, int profileId, int departmentId, IEnumerable<Church> churchs)
    {
        Name = name;
        EmailAddress = emailAddress;
        CreationDate = DateTime.Now;
        ProfileId = profileId;
        DepartmentId = departmentId;
        Churchs = churchs;
    }

    public User(int id, string name, string emailAddress, int profileId, int departmentId, IEnumerable<int> churchIds) : base(id)
    {
        Name = name;
        EmailAddress = emailAddress;
        UpdateDate = DateTime.Now;
        ProfileId = profileId;
        DepartmentId = departmentId;

        AddChurchs(churchIds.ToList());
    }

    public string Name { get; private set; }
    public string EmailAddress { get; private set; }
    public DateTime CreationDate { get; private set; }
    public DateTime UpdateDate { get; private set; }
    public Department Department { get; private set; }
    public int DepartmentId { get; private set; }
    public Profile Profile { get; private set; }
    public int ProfileId { get; private set; }
    public IEnumerable<Church> Churchs { get; private set; }
    private void AddChurchs(List<int> churchIds)
    {
        Churchs = churchIds.Select(churchId => new Church(churchId)).ToList();
    }
}