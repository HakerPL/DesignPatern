using System;

namespace DesignPaterns._SOLID.Liskov_Substitution
{
    /*
     * Liskov Substitution
     * You should be albe to substitute a base type for a subtype
     */


    class Liskov
    {
        public static int Area(RectangleWrong r) => r.Width * r.Height;
        public static int Area(RectangleGood r) => r.Width * r.Height;

        public void Run()
        {
            RectangleWrong rc = new RectangleWrong(2,3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            SquareWrong sq = new SquareWrong();
            sq.Width = 4;

            Console.WriteLine($"{sq} has area {Area(sq)}");

            //here we have error (we not use SquareWrong setter but use RectangleWrong variable)
            RectangleWrong rsqW = new SquareWrong();
            rsqW.Width = 4;

            Console.WriteLine($"{rsqW} has area {Area(rsqW)}");


            // here we use virtual variable and compilator go to and use SquareGood setter (use virtual table)
            RectangleGood rsqG = new SquareGood();
            rsqG.Width = 4;

            Console.WriteLine($"{rsqG} has area {Area(rsqG)}");
        }
    }
}
