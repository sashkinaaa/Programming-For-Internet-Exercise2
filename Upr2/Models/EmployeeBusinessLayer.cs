﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Upr2.DataAccessLayer;

namespace Upr2.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

    }
}