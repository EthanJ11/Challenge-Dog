using System;
namespace ChallengeDOG

{
    public enum Gender { Male,Female};
    class Dog
    {
        private string name;
        private string owner;
        private int age;
        private Gender gender;
        public Dog(string name,string owner,int age,Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public string GetTag()
        {
            string tag = "If lost, call "+owner+". ";
            if (gender == 0)
            {
                tag += "His name is " + name + " he is " + age.ToString();
            }
            else
            {
                tag += "Her name is " + name + " she is " + age.ToString();
            }
            if (age > 1)
            {
                tag += " years old.";
            }
            else
            {
                tag += " year old.";
            }
            return tag;
        }
        public void Bark(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine();
        }
    }
    class Running
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Sparky", "Ethan", 4, Gender.Male);
            myDog.Bark(3);
            Console.WriteLine(myDog.GetTag());

            Dog dadDog =new Dog("Abby", "David", 2, Gender.Female);
            dadDog.Bark(4);
            Console.WriteLine(dadDog.GetTag());
        }
    }
}