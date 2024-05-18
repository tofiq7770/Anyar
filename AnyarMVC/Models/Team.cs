using AnyarMVC.Models.Base;

namespace AnyarMVC.Models
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
