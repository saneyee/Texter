using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Texter.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public virtual Message Message { get; set; }


        public Contact(string name, string phone, int id = 0)
        {
            Name = name;
            Phone = phone;
            ContactId = id;
        }

        public Contact() {}
    }





}




