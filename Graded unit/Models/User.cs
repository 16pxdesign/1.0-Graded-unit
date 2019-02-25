using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Graded_unit.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string username { get; set; }
        [DataType(DataType.Password), MaxLength(50)]
        private string _password;
        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    byte[] data = System.Text.Encoding.ASCII.GetBytes(value);
                    data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                    _password = System.Text.Encoding.ASCII.GetString(data);
                }
            }

        }

    }
}