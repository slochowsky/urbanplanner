using System;

namespace Planner
{
    public class Building
    {
        private string designer { get; set; }
        private DateTime dateConstructed { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        private string Owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building (string address)
        {
            Address = address;
        }
        public void Construct ()
        {
            dateConstructed = DateTime.Now;
        }
        public void Purchase (string name)
        {
            Owner = name;
        }
        public override string ToString ()
        {
            return ($"Address: {Address}, constructed on {dateConstructed}, and owned by: {Owner}, with a size of {Volume} ");
        }
    }
}