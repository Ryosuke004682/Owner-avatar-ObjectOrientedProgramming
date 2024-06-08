using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    internal class Program_01 {
        static void Main(string[] args) {
            Person person = new Person();

            person.Name = "斎藤さん";
            person.Address = "東京都";

            Console.WriteLine($"Name : {person.Name}");
            Console.WriteLine($"Address : {person.Address}");

            while (true) ;
        }
    }

    //オブジェクト指向の基本概念。
    public class Person {
        private string name;//名前という属性
        private string address;//アドレスという属性


        /*PersonClassが持つ振る舞い*/
        //こいつらを呼び出すことで、Objectの属性の値を調べたり、変更したりできる。
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }
        /*-----------------------*/
    }
}
