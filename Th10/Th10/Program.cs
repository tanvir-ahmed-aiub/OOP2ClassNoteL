using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Th10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> st = new MyStack<int>();
            st.Push(10);
            st.Push(12);
            st.PrintStack();
            st.Pop();
            st.PrintStack();

            MyStack<string> st2 = new MyStack<string>();
            st2.Push("Tanvir");
            st2.Push("Ahmed");
            st2.Push("Sabbir");
            st2.PrintStack();

            MyStack<Student> st3 = new MyStack<Student>();

            Student s1 = new Student("Tanvir Ahmed","23354");
            st3.Push(s1);
            st3.Push(new Student("Sabbir Ahmed", "233534"));

            ArrayList list = new ArrayList();

            list.Add(s1);
            list.Add(10);
            list.Add("This is simple string");
            list.RemoveAt(0);

            var temp = list.IndexOf(s1);
            Console.WriteLine(temp);

            Hashtable name_id = new Hashtable();
            name_id["2568"] = "Rahim";
            name_id["1425"] = "Tanvir Ahmed";
            name_id["1426"] = "Karim Ahmed";

            Console.WriteLine(name_id["1426"]);

            foreach (DictionaryEntry entry in name_id) {
                Console.WriteLine(" Key: {0} ==> value: {1}", entry.Key, entry.Value);
            }

            SortedList language = new SortedList();
            language["en-us"] = "English : United Sates";
            language["en-uk"] = "English : United Kingdom";
            language["bn"] = "Bangla ";
            language["in"] = "India ";

            foreach (DictionaryEntry entry in language)
            {
                Console.WriteLine(" Key: {0} ==> value: {1}", entry.Key, entry.Value);
            }


        }
    }
}
