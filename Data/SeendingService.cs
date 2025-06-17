using System;
using System.Linq;
using SalesWebMvc.Model;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeendingService
    {
        private SalesWebMvcContext _context;
        public SeendingService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Sellers.Any() ||
                _context.SalesRecords.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(1, "Eletronics");
            Department d3 = new Department(1, "Fashion");
            Department d4 = new Department(1, "Books");

            


        }
    }
}   
    
