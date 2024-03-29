﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Models
{
  public static class Repository
  {
    private static List<Employee> allEmpoyees = new List<Employee>();

    public static IEnumerable<Employee> AllEmpoyees
    {
      get { return allEmpoyees; }
    }
    public static void Create(Employee employee)
    {
      allEmpoyees.Add(employee);
    }

    public static void Delete(Employee employee)
    {
      allEmpoyees.Remove(employee);
    } 

  }
}
