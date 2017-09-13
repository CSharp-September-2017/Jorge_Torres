namespace human{
public class humanatt{
    public string name;
    public int strength =3;
    public int intelligence =3;
    public int dexterity =3;
    public int health =100;
    
    public humanatt(string val){
       name = val;

    }
    public humanatt(string n, int strn, int intl, int dex, int hp){
        name = n;
        strength = strn;
        intelligence = intl;
        dexterity = dex;
        health = hp;
    }
    public void attack(object punch){
       humanatt enemy = punch  as humanatt;
       if(enemy != null){
           enemy.health -= 5 * strength;
       }
    }
}
}