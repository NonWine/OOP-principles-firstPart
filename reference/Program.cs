using System;
namespace reference
{
    class Program
    {
        static void Main(string[] args)
        {
            //BATTLE ARENA simulation
            // creating NPC
            Weapon gun = new GunWeapon("GuNNER", 90,30);
            Weapon sciptr = new MagicWeapon("Staff", 50, 200);
            Player Non = new Player(100, 60, 100, "NonWine",gun), player = new Player(100, 60, 100, "Player", gun);
            Mage ArcMage = new Mage(200, 60, 100, "ArcMage", sciptr), mage2 =  new Mage(200, 60, 100, "mage2", sciptr);
            
            int i = 0;
            //Now  main character is attacking arcmage
            Console.WriteLine("Main character and ArcMage charactiristics before battle");
            Non.show();
            Non.ShowWeapon();
            ArcMage.show();
           
            while ( i  < 5)
            {
                Non.attack(ArcMage);
                i++;
            }
            i = 0;
            Console.WriteLine("Main character and ArcMage charactiristics after battle");
            Non.show();
            Non.ShowWeapon();
            ArcMage.show();
            Console.WriteLine("============================");
            //Now  arcmage  is attacking main character
            Console.WriteLine("Main character and ArcMage charactiristics before battle");
            player.show();
            mage2.show();
            mage2.ShowWeapon();
            while (i < 5)
            {
                mage2.attack(player);
                i++;
            }
            Console.WriteLine("Main character and ArcMage charactiristics after battle");
            player.show();
            mage2.show();
            mage2.ShowWeapon();
        }
    }
}
