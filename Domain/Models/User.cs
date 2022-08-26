using Shared.Base;

namespace Domain.Models
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime Birth { get; set; }

        public decimal Salary { get; set; }
    }
}