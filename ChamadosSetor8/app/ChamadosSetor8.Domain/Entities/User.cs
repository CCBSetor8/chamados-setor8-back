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

        AddProfile(profileId);
        AddDepartment(departmentId);
        AddChurchs(churchIds.ToList());
    }

    public User(int id, string name, string emailAddress, int profileId, int departmentId, IEnumerable<int> churchIds) : base(id)
    {
        Name = name;
        EmailAddress = emailAddress;
        UpdateDate = DateTime.Now;

        AddProfile(profileId);
        AddDepartment(departmentId);
        AddChurchs(churchIds.ToList());
    }

    public string Name { get; private set; }
    public string EmailAddress { get; private set; }
    public DateTime CreationDate { get; private set; }
    public DateTime UpdateDate { get; private set; }
    public Department Department { get; private set; }
    public Profile Profile { get; private set; }
    public IEnumerable<Church> Churchs { get; private set; }

    private void AddProfile(int profileId) => Profile = new Profile(profileId);
    private void AddDepartment(int departmentId) => Department = new Department(departmentId);
    private void AddChurchs(List<int> churchIds)
    {
        var churchs = new List<Church>();

        for (int i = 0; i < churchIds.Count; i++)
        {
            churchs.Add(new Church(churchIds[i]));
        }

        Churchs = churchs;
    }
}