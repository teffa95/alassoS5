using alassoS5.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alassoS5.Utils;

public class PersonRepository
{
    string dbPath;
    private SQLiteConnection conn;

    public string StatusMessage { get; set; }
    private void Init()
    {
        if (conn == null)
            return;
        conn = new(dbPath);
        conn.CreateTable<Persona>();
    }

    public PersonRepository(string Path)
    {
        dbPath = Path;
    }
    public void AddNewPerson(string name)
    {
        int result = 0;
        try
        {
            Init();
            if (string.IsNullOrEmpty(name))
                throw new Exception("Nombre es un campo requerido");
            Persona person = new() { Name = name };
            result = conn.Insert(person);
            StatusMessage = string.Format("Dato insertado");
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Error" + ex.Message);
        }

    }

public List<Persona> GetAllPeople()
    {
        try
        {
            Init();
            return conn.Table<Persona>().ToList();
        }
        catch (Exception ex)
        {
            StatusMessage = string.Format("Error" + ex.Message);
        }

        return new List<Persona>();

    }

    internal void DeletePerson(Persona persona)
    {
        throw new NotImplementedException();
    }

    internal void UpdatePerson(Persona persona)
    {
        throw new NotImplementedException();
    }

    internal void AddPerson(Persona persona)
    {
        throw new NotImplementedException();
    }
}

