using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    string name = null;
    int speed;

    public void Setname(string name)
    {
        this.name = name;
    }
    public string Getname()
    {
        return this.name;
    }
    public int Setspeed(int speed) => this.speed = speed;
    public int Getspeed()
    {
        return this.speed;
    }
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }

}
class MainClass
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Setname("람보르기니");
        // myrobot.name = "쿠쿠"
        Console.WriteLine("차 이름 : " + myCar.Getname());
        myCar.Setspeed(19);
        Console.WriteLine("지금 속도 : " + myCar.Getspeed());
    }
}