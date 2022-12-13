namespace SeminarDZ7
{
    class Childrenshoes: Shoes, IGreeting
    {
        public Childrenshoes()
        {
        }

        public override void getAllMethods()
        {
            greeting();
            productline();
        }

        public void greeting() => Console.WriteLine("Приветствуем Вас в магазине детской обуви!!!");

        private void productline() => Console.WriteLine("у нас представлен самый широкий ассортимент обуви, как для самых маленьких покупателей, так и для самых модных школьников! Здесь вы можете подобрать обувь на любой сезон!");

    }

}

