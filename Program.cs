namespace SeminarDZ7
{
    class Program
    {
        public static void Main(string[] args)
        {
            ShoesService shoesService = new ShoesService(
                new List<Shoes>(){
                    new Childrenshoes(),
                    new Menshoes(),
                    new Womenshoes()
                }
            );
            shoesService.service();
        }
    }

}