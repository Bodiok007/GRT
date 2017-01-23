using GRT.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ConsoleAppEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Assembly.GetEntryAssembly().CodeBase);
            String s = Directory.GetCurrentDirectory();
            Console.WriteLine();
            /*var ctx = new GrtContext();
            ctx.Menus.Add(new GRT.DAL.Models.Menus.MenuDal());
            ctx.SaveChanges();
            Console.WriteLine(ctx.Database); */

            Console.Read();
        }
    }
}
