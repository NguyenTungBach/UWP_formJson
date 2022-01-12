using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formJson.Entity
{
    class Register
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Introduction { get; set; }

        //public Register()
        //{
        //    CreateAt = DateTime.Now;
        //    UpdateAt = DateTime.Now;
        //    DeleteAt = DateTime.Now;
        //}
    }
}
