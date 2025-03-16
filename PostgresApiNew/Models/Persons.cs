using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresApiNew.Models;

public class Persons
{
    [Column("personid")]
    public int Id { get; set; }
    public string LastNnme { get; set; }
    public string Firstname { get; set; }
    public int Age { get; set; }
}