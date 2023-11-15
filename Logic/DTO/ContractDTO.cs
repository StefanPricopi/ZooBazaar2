using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class ContractDTO
    {
        public int ContractID { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ContractType { get; set; }
        public int RoleID { get; set; }

        public ContractDTO() { }
        public ContractDTO(ContractDTO contractDTO)
        {

        }
    }
}
