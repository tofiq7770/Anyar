using AnyarMVC.Models.Base;

namespace AnyarMVC.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public List<Team> Team { get; set; }
    }
}
