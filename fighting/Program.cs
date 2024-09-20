using System;

public class Player{
    public int hp;
    public int dmg;
    public Random random;
    
    public Player(int hp, int dmg) {
        this.hp = hp;
        this.dmg = dmg;
    }
// sigma
    public int Attack(Player opponent) {
        int dmgdone = random.Next(dmg -3, dmg +3);
        opponent.hp = hp - dmgdone;
        return dmgdone;

    }
}

class Program {
    public static void Main() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
    Player 下庞 = new Player(100,30);
    Player 新秀大师赛 = new Player(300,10);
    Random random = new Random();
    Console.WriteLine("输入你的名字");


    string name = Console.ReadLine();

    while (name.Length < 3)
{
    Console.WriteLine("输入你的名字 sa jag dummis");
    name = Console.ReadLine();

}


Console.WriteLine($"Hej {name}");


    int card = Random.Shared.Next(52);
    Console.WriteLine(card);
    Console.ReadLine();




Console.ReadLine();

    }
}


