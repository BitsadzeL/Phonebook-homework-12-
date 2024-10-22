using System.Net.Http.Headers;

namespace Phonebook__homework_12_
{

    //დაწერეთ PhoneBook ის აპლიკაცია სადაც შესაძლებელი იქნება ახალი კონტაქტის დამატება, წაშლა, ძებნა
    //გამოიყენეთ Dictionary ახალი კონტაქტები ჩაემატოს.txt გაფართოების ფაილში
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> contacts = new Dictionary<string, string>();
            contacts.Add("Luka Bitsadze", "568320770");
            contacts.Add("Nikoloz Bitsadze", "574011723");
            contacts.Add("Leo Messi", "1010101");
            contacts.Add("Luka Modric", "1010101");
            initializeFile(contacts);

            delete(contacts, "Nikoloz Bitsadze");
            seeData(contacts);

            Console.WriteLine();
            createContact(contacts, "Guram Kashia", "444444444");
            createContact(contacts, "Giorgi Chakvetadze", "10");
            seeData(contacts);


        }

        //25


        public static void initializeFile(Dictionary<string, string> contacts)
        {
            File.WriteAllText(@"../../../contacts.txt", string.Empty);

            foreach (var item in contacts)
            {

                File.AppendAllText(@"../../../contacts.txt", $"{item.Key} {item.Value}{Environment.NewLine}");
            }

        }
        public static void updateFile(Dictionary<string, string> contacts)
        {
            File.WriteAllText(@"../../../contacts.txt", string.Empty);
            foreach (var item in contacts)
            {

                File.AppendAllText(@"../../../contacts.txt", $"{item.Key} {item.Value}{Environment.NewLine}");
            }

        }

        public static void seeData(Dictionary<string, string> contacts) 
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item);

            }

        }



        public static Dictionary<string,string> delete(Dictionary<string, string> contacts, string name)
        {
            contacts.Remove(name);
            updateFile(contacts);
            return contacts;
        }
        public static string findPhoneNumber(Dictionary<string, string> contacts, string name)
        {

            foreach (var item in contacts)
            {
                if(item.Key== name)
                {
                    return item.Value;
                }
                
            }

            return default;
        }

        public static void createContact(Dictionary<string, string> contacts,string name, string number)
        {
            contacts.Add(name, number);
            updateFile(contacts);
        }







    }
}
