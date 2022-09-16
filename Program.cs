using System;

namespace Property
{

    //le property sono una maniera più comoda
    //e veloce di gestire i metodi get e set
        public class Persona
        {
        //quando una variabile di istanza è privata, si chiama backing field
        //anzi
        //A private field that stores the data exposed by a public
        //property is called a backing store or backing field.
       
        private string name;

        //1 forma 
        //public string Name{ 
        //     public string getName() 
        //     {
        //     return name;
        //     }
        //     public void setName(string name)
        //     {
        //         this.name = name;
        //     }

        //}

        //2 forma condensata
        //public string Name 
        // {
        // get { return name; } 
        // set { name = value; }
        // }

        //3 forma: supercondensata
        //detta auto-implemented property
        //con valore di default
        public string Name { get; set; } = "Beppe";

    }

    public class Esegui
    {
        //metodo statico
        public static void Main(string[] args)
        {
           Persona p = new Persona();
           p.Name = "Mario";
           Persona k = new Persona();
           Persona j = new Persona(){Name="Aldo"};
           Console.WriteLine(p.Name);
           Console.WriteLine(k.Name);
           Console.WriteLine(j.Name);
        }
    }
}
