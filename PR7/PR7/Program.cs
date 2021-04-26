using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7
{

    class ship
    {
        protected string name;
        protected string appointment;
        protected double cavity;
        protected double enginePower;
        protected string nameFuel;

        virtual public void input()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Назначение: ");
            appointment = Console.ReadLine();
            Console.Write("Водоизмещение(в тоннах): ");
            cavity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Мощность двигателя(кВт): ");
            enginePower = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вид горючего: ");
            nameFuel = Console.ReadLine();
        }

        virtual public void output()
        {
            Console.WriteLine("Имя: {0}\nНазначение: {1}\nВодоизмещение: {2}\nМощность двигателя: {3}\nВид горючего: {4}",
                name,appointment,cavity, enginePower,nameFuel);
        }
    }

    class carrier : ship
    {
        string typePlane;
        int numberPlanes;

        public override void input()
        {
            base.input();
            
            Console.Write("Тип самолетов, которые он везет: ");
            typePlane = Console.ReadLine();
            Console.Write("Их количество: ");
            numberPlanes = Convert.ToInt32(Console.ReadLine());
           
        }

        public override void output()
        {
            Console.WriteLine("\n======================АВИАНОСЕЦ======================");
            base.output();

            Console.WriteLine("Тип самолетов, которые он везет: {0}\nИх количество: {1}", typePlane, numberPlanes);
        }
    }

    class rocketCarrier : ship
    {
        string typeRockets;
        int numberRockets;

        public override void input()
        {
            base.input();

            Console.Write("Тип ракет: ");
            typeRockets = Console.ReadLine();
            Console.Write("Их количество: ");
            numberRockets = Convert.ToInt32(Console.ReadLine());
        }
        public override void output()
        {
            Console.WriteLine("\n======================РАКЕТОНОСЕЦ======================");
            base.output();

            Console.WriteLine("Тип ракет: {0}\nИх количество: {1}", typeRockets, numberRockets);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Заполните все данные про авианосец");
            carrier carrier = new carrier();
            carrier.input();
            carrier.output();
            Console.WriteLine();
            Console.WriteLine("Заполните все данные про ракетоносец");
            rocketCarrier rocketCarrier = new rocketCarrier();
            rocketCarrier.input();
            rocketCarrier.output();

        }
    }
}
