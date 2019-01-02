using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition2018E
{
    public class Collections
    {
        //Arrays
        // myInts indeholder heltal
        // Lav full properties til myInts
        private int[] myInts = new int [] {1, 34, 5, 6};

        public int[] MyInts
        {
            get { return myInts;  }
            set { myInts = value;  }
        }

        private List<int> myIntList = new List<int>(){12,34,5,67,7};

        public List<int> MyIntList
        {
            set { myIntList = value; }
            get { return myIntList; }
        }
        //myNames indeholder et number og et tilhørende navn
        // Lav full properties til myNames
        private Dictionary<int, string> myNames = new Dictionary<int, string>();

        public Dictionary<int, string> MyNames
        {
            get { return myNames; }
            set { myNames = value; }
        }
        // Lav dit eget eksempel, som definerer et array, en List og et Dictionary
        public void TestArray()
        {
            // Lav i metoden TestArray nogle sætninger:
            //  som indsætter et tal på pladsen til indeks 3
            //  som udskriver alle elementer i arrayet
            // som udskriver tallene i arrayet bagfra
            // Giv eksempler på foreach- , for- og while loops
            Console.WriteLine("Test Array");
            myInts[3] = 4;
            
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Udskriv bagfra for loop");
            for (int j = myInts.Length - 1; j >= 0; j--)
            {
                Console.Write($" {myInts[j]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Udskriv bagfra While loop");
            int k = myInts.Length - 1;
            while (k >= 0)
            {
                Console.Write($" {myInts[k]} ");
                k--;
            }
            Console.WriteLine();
        }


        //List

        public void TestList()
        {
            // Lav i metoden TestList sætninger, 
            //  som tilføjer et tal til listen bagerst
            //  som indsætter tallet 45 på indekspladsen 2 i listen
            //  som fjerner tallet som er placeret på plads 4
            // som erstatter det eksisterende tal på indeks 2 med tallet 22
            // som udskriver listen vha. foreach
            // som checker om der eksisterer tallet 2 i listen og hvis det gør så udskriv en sætning om, at det eksisterer
            // som sorterer listen

            // Lav sætninger som laver de samme operationer med din egen liste.

            Console.WriteLine("Test List");
            myIntList.Add(55);
            myIntList.Insert(2,45);
            myIntList.RemoveAt(4);
            myIntList[2] = 22;
            foreach (int i in myIntList )      {
                Console.Write($" {i} ");
            }
            //myIntList.Sort();
            bool exist =myIntList.Contains(2);
            if (exist)
                Console.WriteLine($"2 eksisterer i listen på position {myIntList.IndexOf(2)} ");
            else
            {
                Console.WriteLine("2 eksisterer ikke i  listen");
            }
        }

        // Lav en metode, SumList, som løber listen igennem og lægger alle tallene samme. 
        // hvis der forekommer et negativt tal, skal der kastes en exception, NegativeNumberException, som du selv skal definere


        public int SumList()
        {
            int sum = 0;
            foreach (int i in myIntList)
            {
                if (i < 0)
                    throw new NegativeNumberExcpetion("Negative number");
                sum = i + sum;
            }
            return sum;
        }

        //Dictionary

        public void TestDictionary()
        {
            // Lav læstninger, som tilføjer de studerendes navne til Dictionary'et myNames og som key angives et tal mellem 1 -10

            myNames.Add(1, "Sofus");
            myNames.Add(2, "Line");
            myNames.Add(3, "Christian");
            myNames.Add(4, "Anders");
            myNames.Add(5, "Nikolai");
            myNames[6] = "Thomas";

            

            // Lav sætninger der checker om der findes et navn inder key 4
            // Hivs der findes et navn under key 4 skal det fjernes
            if (myNames.ContainsKey(4))
            {
                Console.WriteLine(myNames[4]);
                myNames.Remove(4);
            }

            // Lav sætninger, som udskriver alle values i myNames
            foreach (string aName in myNames.Values)
            {
                Console.WriteLine(aName);
            }

            // Lav sætninger, som tilføjer manipulerer dit eget dictionary

        }



    }
}
