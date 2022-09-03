using System;

/*
 This class is an abstract. 
 it is a template to creating specific classes
 Every specific mob will have some characteristics and a weapon.
 Every specific mob can attack somebody and showing information about itself or its weapon
 */
abstract class Mob
{
    private float hp , mp;
    protected string TypeofMob;
    protected float stamina;
    protected Weapon weapon;
    public string name{ get; set; }
    public float mana
    { get { return mp; }
      set { if (value > 0) mp = value; }
    }
    
    public float health
    {
        get { return hp; }
        set { if (value <= 0) hp = 0; else hp = value; }
    }
    public  void ShowWeapon()
    {
        Console.WriteLine("Your weapon is " + weapon.Name +
                          "\n Durability: " + weapon.Durability + 
                          "\n Damage: " + weapon.Damage);
    }
    public bool IsAlive()
    {
        if (health <= 0)
            return false;
        return true;
    }
    public  void show()
    {
        if (health <= 0)
            Console.WriteLine(name + " died!");
        else
            Console.WriteLine(TypeofMob + " name: " + name + "\n Health: " + health + "\n Mana: " + mana +
                "\n Stamina " + stamina);
    }
    abstract public void attack(Mob mob);
}
//It is a Player, in other words , main character in game
// at default, player have a gun, but he also can carry  other kind of weapons.
class Player : Mob
{
     public bool isStamina()
    {
        if (stamina <= 0)
            return false;
        return true;
    }

    public Player()
    {
        TypeofMob = "Player ";
        weapon = new GunWeapon();
        health = 0;
        mana = 0;
        stamina = 0;
        name = "null";
    }
    public Player(float hp, float mp, float sm, string pers, Weapon weapon)
    {
        this.weapon = weapon;
        health = hp;
        mana = mp;
        stamina = sm;
        name = pers;
        TypeofMob = "Player ";
    }
    public override void attack( Mob mob)
    {
       
        if (stamina <= 0)
        {
            Console.WriteLine("Dont have stamina!");
            return;
        }
        if (weapon.isDurability()) { return; } 
       
        weapon.Dodamag(mob);
        stamina -= 10;
    }
    public void ReNAme(string newName) => name = newName;
}
//Enemy Mage
class Mage : Mob
{
    public Mage()
    {
        health = 0;
        mana = 0;
        name = "null";
        TypeofMob = "Mage: ";
    }
    public Mage(float hp, float mp, float stamina, string name, Weapon weapon)
    {
        this.weapon = weapon;
        this.name = name;
        health = hp;
        mana = mp;
        this.stamina = stamina;
        TypeofMob = "Mage: ";
    }
    public override void attack(Mob mob)
    {
        if (mana <= 0)
        {
            Console.WriteLine("Dont enough mana!");
            return;
        }
        if (weapon.isDurability()) { return; }
        mana -= 20;
        weapon.Dodamag(mob);
    }
    
   
}