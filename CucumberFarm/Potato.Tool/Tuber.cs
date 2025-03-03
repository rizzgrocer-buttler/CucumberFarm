namespace Potato.Tool
{
    public class Tuber
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Tuber()
        {
            Name = string.Empty;
            Description = string.Empty;
        }
        public Tuber(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string What()
        {
            return "Potatoes";
        }
    }
}