using System;

namespace smashbros
{
    class Fighter
    {
        public string Name;
        public int PlayerNum;
        private int percentage;
        public int Percentage
        {
            get{return percentage;}
        }
        public Fighter(string name, int playerNum)
        {
            Name = name;
            PlayerNum = playerNum;
            percentage = 0;

        }
        public void TakeDamage(int amount)
        {
            if(amount > 0)
            {
                percentage += amount;
            }
        }

        public void Attack(Fighter opponent)
        {
            int damage = 5;
            opponent.TakeDamage(damage);

            Console.WriteLine($"{Name} attacked {opponent.Name} for {damage}%!!");
        }
        // public void Special(Fighter opponent)
        // {
        //     int damage = 25;
        //     opponent.TakeDamage(damage);

        //     Console.WriteLine($"{Name} attacked {opponent.Name} for {damage}%!!");
        // }
    }

    class Samus : Fighter
    {
        private bool isCharged;

        public Samus(int playerNum) : base("Samus", playerNum)
        {
            isCharged = false;
        }

        public void Special(Fighter opponent)
        {
            if(isCharged)
            {
                int damage = 30;
                opponent.TakeDamage(damage);


                Console.WriteLine($"{Name} attacked {opponent.Name} for {damage}%!!");
            }
            else
            {
                isCharged = true;
                Console.WriteLine($"{Name} charged up laser arm thingy!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Samus samus = new Samus(1);
            // Fighter samus = new Fighter("Samus", 1);
            Fighter dk = new Fighter("Donkey Kong", 2);

            // Console.WriteLine(samus.Name);
            //samus.Percentage = 25;
            // Console.WriteLine(samus.Percentage);

            samus.Special(dk);
            samus.Special(dk);
            Console.WriteLine(dk.Percentage);
            dk.Attack(samus);
            Console.WriteLine(samus.Percentage);

    }
}
}