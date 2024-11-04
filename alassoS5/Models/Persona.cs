using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxLengthAttribute = SQLite.MaxLengthAttribute;

namespace alassoS5.Models;

    [Table("Persona")]
public class Persona
{
    internal string Nombre;

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    [MaxLength(25), Unique]
    public string Name { get; set; }

}

