using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Model
{
    internal sealed class ImmuTeacher
    {
        /// <summary>
        /// POCO
        /// </summary>
        public int Id { get; }
        public string? Firstname { get; }
        public string? Lastname { get; }

        public ImmuTeacher()
        {
        }

        public ImmuTeacher(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
