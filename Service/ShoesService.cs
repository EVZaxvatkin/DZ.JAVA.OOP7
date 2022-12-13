namespace SeminarDZ7
{
    class ShoesService
    {
        private List<Shoes> shoess;

        public ShoesService(List<Shoes> shoess)
        {
            this.shoess=shoess;
        }

        public void service()
        {
            Console.Clear();
            foreach (Shoes shoes in shoess)
            {
                shoes.getAllMethods();
                Console.WriteLine();
            }
        }

    }

}