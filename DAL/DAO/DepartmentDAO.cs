﻿using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(DEPARTMENT department)
        {
            try
            {
                db.DEPARTMENTs.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<DEPARTMENT> GetDepartment()
        {
            return db.DEPARTMENTs.ToList();
        }

        public static void UpdateDepartment(DEPARTMENT department)
        {
            try
            {
                DEPARTMENT dpt = new DEPARTMENT();
                dpt.DepartmentName = department.DepartmentName;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
