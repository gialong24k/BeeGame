using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            GenBee genBee = new GenBee();
            int sl;
            do
            {
                Console.WriteLine("1. Bắn đàn ong");
                Console.WriteLine("2. Hiển thị trạng thái đàn ong");
                Console.WriteLine("3. Thoát");
                Console.Write("Nhập lựa chọn: ");
                sl = int.Parse(Console.ReadLine());
                switch (sl)
                {
                    case 1:
                        genBee.Shoot();
                        break;
                    case 2:
                        genBee.Output();
                        break;
                    case 3:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, xin hãy thử lại.");
                        break;
                }
            } while (sl != 3) ;
        }
    }
}
