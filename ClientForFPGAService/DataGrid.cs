namespace ClientForFPGAService
{
    public class DataGrid
    {
        public DataGrid(string name, int intProperty, string stringProperty, bool boolProperty)
        {
            Name = name;
            IntProperty = intProperty;
            StringProperty = stringProperty;
            BoolProperty = boolProperty;
        }

        public string Name { get; set; }
        public int IntProperty { get; set; }
        public string StringProperty { get; set; }
        public bool BoolProperty { get; set; }
    }
}