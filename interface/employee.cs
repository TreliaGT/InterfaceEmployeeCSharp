using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEmployee
{
  public  interface employeeid
    {
        string Name
        {
            get;
            set;
        }
        string Role
        {
            get;
            set;
        }

        int ID
        {
            get;
            set;
        }

    }

    class employee : employeeid
    {
        private string name;
        private string role;
        private int id;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Role"></param>
        /// <param name="ID"></param>
        public employee(string Name, string Role, int ID )
        {
            name = Name;
            role = Role;
            id = ID;
        }

        //Setter & getter
        public string Name  
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

    }
}
