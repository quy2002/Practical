using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.ss4
{
    public delegate void ShowString(string s);// khai bao 1 delegate dai dien cho cac ham return void vaf tham so: string
    public class Program
    {
        public static ShowString ss = new ShowString(DemoDelegate.ShowMsg);
        public static void Main(string[] args)
        {
            // DemoDelegate.ShowMsg("xin chao cac ban");
            // DemoDelegate dd = new DemoDelegate();
            // dd.ShowInfo("xin chao cac ban");
            // ShowString ss = new ShowString(DemoDelegate.ShowMsg);// truyen vao ten cua ham
            DemoDelegate dd = new DemoDelegate(); // nap them vao vao danh sach thuc hien
            ss += DemoDelegate.ShowMsg;
            ss += DemoDelegate.ShowMsg;
            ss("xin chao cac ban");// chay delegate
            Calculate c = new Calculate(Calcutation.Add);
            c += Calcutation.Sub;
            c += Calcutation.Multi;
            c += Calcutation.Div;
            int rs = c(5, 3);
            Console.WriteLine("rs: " + rs);
            dd.Running();
        }
    }
}
