namespace SeminarDZ7
{
    class Menshoes: Shoes, IGreeting
    {
        public Menshoes()
        {
        }

        public override void getAllMethods()
        {
            greeting();
            productline();
        }

        public void greeting() => Console.WriteLine("Приветствуем Вас в магазине мужской обуви!!!");

        private void productline() => Console.WriteLine("У нас представлен самый широкий ассортимент как спортивной, так и классической обуви! Здесь вы можете подобрать обувь на любой сезон!");

    }

}