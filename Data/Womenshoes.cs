namespace SeminarDZ7
{
    class Womenshoes: Shoes, IGreeting
    {
        public Womenshoes()
        {
        }

        public override void getAllMethods()
        {
            greeting();
            productline();
        }

        public void greeting() => Console.WriteLine("Приветствуем Вас в магазине обуви для наших милых дам!!!");

        private void productline() => Console.WriteLine("У нас представлен самый широкий ассортимент обуви на любой, даже самый изысканный вкус!");

    }

}