namespace arvSak
{
    class Program
    {
        static void Main(string[] args)
        {
            Databas databas = new Databas();
            databas.Add("Violator", "Depeche Mode", DiskType.CD);
            databas.Add("Violator", "Some great reward", DiskType.CD);
            databas.Add("Peter Jackson", "Lord of the Rings: The Fellowship of the Ring", DiskType.DVD);
            databas.Add("Peter Jackson", "Lord of the Rings: The Two Towers", DiskType.DVD);
            databas.Add("Peter Jackson", "Lord of the Rings: The Return of the King", DiskType.DVD);

            databas.Print();
        }
    }
}
