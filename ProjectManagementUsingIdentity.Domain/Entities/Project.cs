using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementUsingIdentity.Domain.Entities
{
    //public class Project
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public DateTime CreatedDate { get; set; }
    //    public string? Description { get; set; }
    //    public string Status { get; set; } = "Not Started";

    //    public int CustomerId { get; set; }
    //    public Customer Customer { get; set; }

    //}
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; } = "Started";

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
