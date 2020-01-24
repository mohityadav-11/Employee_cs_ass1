using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private int id;
        private string name;
        private string deptName;

        string _fire;

        public delegate void Fired(String msg);
        public event Fired OnFired;

        public Employee(int id , string name , string deptName)
        {
            this.id = id;
            this.name = name;
            this.deptName = deptName;

            this._fire = "Empty";
        }


        public int getID() {
            OnFired("GetID() Method is called");
            return this.id;
        }

        public string getName()
        {
            OnFired("GetName() Method is called");
            return this.name;
        }
        
        public string getDepartmentName()
        {
            OnFired("GetDepartmentName() Method is called");
            return this.deptName;
        }

        public void update(int id)
        {
            OnFired("update() Method is called");
            this.id = id;
        }

        public void update(String name)
        {
            OnFired("update() Method is called");
            this.name = name;
        }

        public void  updateDepName(String dept)
        {
            OnFired("updateDepName() Method is called");
            this.deptName = dept;
        }
    }
}
