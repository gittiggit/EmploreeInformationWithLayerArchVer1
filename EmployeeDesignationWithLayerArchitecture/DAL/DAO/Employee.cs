﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignationWithLayerArchitecture.DAL.DAO
{
   public class Employee
    {
       public int Id { set; get;}
       public string Name { set; get; }
       public string Email { set; get; }
       public string Address { set; get; }
       public Designation DesignationId { set; get; }

    }
}
