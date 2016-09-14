using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Web;


namespace BitTask.Models
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Permission { get; set; }
        public List<Shift> Shifts { get; set; } = new List<Shift>();
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = CreatePasswordHash(value);
            }
        }

        private string CreatePasswordHash(string _password)
        {
            int saltSize = 16;
            int bytesRequired = 32;
            byte[] array = new byte[1 + saltSize + bytesRequired];
            // 1000, afaik, which is the min recommended for Rfc2898DeriveBytes
            int iterations = 1000;
            using (var pbkdf2 = new Rfc2898DeriveBytes(_password, saltSize, iterations))
            {
                byte[] salt = pbkdf2.Salt;
                Buffer.BlockCopy(salt, 0, array, 1, saltSize);
                byte[] bytes = pbkdf2.GetBytes(bytesRequired);
                Buffer.BlockCopy(bytes, 0, array, saltSize + 1, bytesRequired);
            }
            return Convert.ToBase64String(array);
        }
    }
}