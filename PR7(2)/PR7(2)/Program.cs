using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR7_2_
{
    class place
    {
        protected string name;
        protected double square;
        protected double nPeople;
        protected double density;
        protected string fdate;

        virtual public void input()
        {
            Console.Write("Введите название места: ");
            name = Console.ReadLine();
            Console.Write("Введите население людей в этом месте: ");
            nPeople = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите площадь этого места(км^2): ");
            square = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите плотность населения(чел./км^2): ");
            density = Convert.ToDouble(Console.ReadLine());
            Console.Write("Дата основания: ");
            fdate = Console.ReadLine();
        }

        virtual public void output()
        {
            Console.WriteLine("Название: {0}\nНаселение: {1}\nПлощадь: {2}\nПлотность населения: {3}\nДата основания: {4}", 
                name, nPeople,square,density,fdate);
        }
    }

    class region : place
    {
        string center;
        string head_reg;
        int Ndistrict;

        public override void input()
        {
            base.input();
            Console.Write("Введите название административного центра области: ");
            center = Console.ReadLine();
            Console.Write("Введите имя главы областной государственной администрации: ");
            head_reg = Console.ReadLine();
            Console.Write("Введите количество районов области: ");
            Ndistrict = Convert.ToInt32(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Административный центр области: {0}\nИмя главы областной государственной администрации: {1}\nКоличество районов области: {2}", 
                center,head_reg,Ndistrict);
        }
    }

    class city : place
    {
        string postcode;
        string head_city;

        public override void input()
        {
            base.input();
            Console.Write("Введите имя городского главы: ");
            head_city = Console.ReadLine();
            Console.Write("Введите почтовый индекс города: ");
            postcode = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Городской глава: {0}\nПочтовый индекс города: {1}", head_city, postcode);
        }
    }

    class metropolis : place
    {
        int Ncity;

        public override void input()
        {
            base.input();
            Console.Write("Введите количество городов городской агломерации: ");
            Ncity = Convert.ToInt32(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Количество городов городской агломерации: {0}", Ncity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            region region = new region();
            Console.WriteLine("Введите все данные про область");
            region.input();
            Console.WriteLine("\n==============================================ОБЛАСТЬ============================================");
            region.output();

            Console.WriteLine();

            city city = new city();
            Console.WriteLine("Введите все данные про город");

            city.input();
            Console.WriteLine("\n==============================================ГОРОД============================================");
            city.output();

            Console.WriteLine();

            metropolis metropolis = new metropolis();
            Console.WriteLine("Введите все данные про мегаполис");
            metropolis.input();
            Console.WriteLine("\n==============================================МЕГАПОЛИС============================================");
            metropolis.output();
        }
    }
}
