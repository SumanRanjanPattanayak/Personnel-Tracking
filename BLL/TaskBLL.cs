﻿using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaskBLL
    {
        public static void AddTask(TASK task)
        {
            TaskDAO.AddTask(task);
        }

        public static TaskDTO GetAll()
        {
            TaskDTO taskdto = new TaskDTO();
            taskdto.Employees = EmployeeDAO.GetEmployee();
            taskdto.Departments = DepartmentDAO.GetDepartment();
            taskdto.Positions = PositionDAO.GetPosition();
            taskdto.TaskStates = TaskDAO.GetTaskStates();
            taskdto.Tasks = TaskDAO.GetTasks();
            return taskdto;
        }

        public static void UpdateTask(TASK task)
        {
            TaskDAO.UpdateTask(task);
        }
    }
}
