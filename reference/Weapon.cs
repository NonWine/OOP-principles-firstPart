using System;


abstract class Weapon
{
    protected int dmg =0 , health =0;
    public string Name { get;protected set; }
    public int Durability
    {
        get { return health; }
        set {  health = value; }
    }
    public int Damage
    {
        get { return dmg; }
        set { if (value > 0) dmg = value; }
    }
    public bool isDurability()
    {
        if (Durability <= 0)
        {
            Console.WriteLine(Name + " has broken");
            return true;
        }
        return false;
    }
    abstract public void Dodamag(Mob person);
}
 class GunWeapon : Weapon
{
   
    public GunWeapon(string name,int damage,int durr)
    {
        Name = name;
        Damage = damage;
        health = durr;
    }
    public GunWeapon()
    {
        Name = "GunWeapon";
        Damage = 10;
        health = 100;
    }
    
   
    public override void Dodamag(Mob person)
    {  
            Console.WriteLine("gun gun\n" + person.name + " was attacked");
            person.health -= Damage;
            health -= 10;
    }
}
 class Bow : Weapon
{
    private void Shoot() { Console.WriteLine("bow bow"); }
    public override void Dodamag(Mob person) { Shoot(); }
}
 class MagicWeapon : Weapon
{
    public MagicWeapon()
    {
        Name = "Magic Weapon";
        Damage = 30;
       health = 200;
    }
    public MagicWeapon(string name,int damage,int durra)
    {
        Name = name;
        health = durra;
        Damage = damage;
    }
    public override void Dodamag(Mob person)
    {
        Console.WriteLine("MAgic attack\n" + person.name + " was attacked");
        person.health -= Damage;
        health -= 20;
    }
}