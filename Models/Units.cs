

using static testrobo.Models.Directions;

namespace testrobo.Models
{
    public class Units
    {
        public int xUnit { get; set; } = 5;
        public int yUnit { get; set; } = 5;
        public string directions { get; set; } = "North";

        public int setSelectedRow { get; set; } = 0;
        public int setSelectedColumn { get; set; } = 0;
    }
}

