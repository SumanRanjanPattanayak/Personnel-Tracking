using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;

namespace BLL
{
    public class PositionBLL
    {
        public static void AddPosition(POSITION position)
        {
            PositionDAO.AddPosition(position);
        }

        public static List<PositionDTO> GetPosition()
        {
            return PositionDAO.GetPosition();
        }

        public static void UpdatePosition(POSITION position, bool control)
        {
            PositionDAO.UpdatePosition(position);
            if (control)
            {
                EmployeeDAO.UpdateEmployee(position);
            }
        }
    }
}
