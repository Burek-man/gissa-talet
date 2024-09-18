// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;


Random rng = new Random();

int rand = rng.Next(1,100);
int guess = 0;
int p_turns = 0;
bool Start = false;

Console.WriteLine("för att starta tryck !");
while (!Start) {
string startup = Console.ReadLine();
    if (startup == "!") {
        Start = true;
    }

}

while (Start){
    if (p_turns == 0)
    {
        Console.WriteLine("gissa på ett tal mellan 1 och 100");
    }

    p_turns++;
    Console.Write("gissa " + p_turns + ": ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess == rand){
        Console.WriteLine("rätt");
        Console.WriteLine("det tog " + p_turns + " för att få rätt ");
        Start = false;
    }

    else if (guess < rand) {
        Console.WriteLine("nummeret är för lågt");
        Console.WriteLine("testa igen");
    }


    else if (guess > rand) {
        Console.WriteLine("nummeret är för högt");
        Console.WriteLine("testa igen");
    }





}



























/*do
Random random = new Random();

{
    {
        {

            int returnvalue = random.Next(1, 101);

            Console.WriteLine(" gissa nummer mellan 1 till 100 ");
            Console.WriteLine("Facit: " + returnvalue);
            int response = Convert.ToInt32(Console.ReadLine());
    
            if (response > returnvalue)
            {
                Console.WriteLine($"talet är för högt {response} testa igen");
                response = Convert.ToInt32(Console.ReadLine());
            }

            else if (response < returnvalue)
            {
                Console.WriteLine($"talet är för lågt {response} testa igen ");
                response = Convert.ToInt32(Console.ReadLine());
            }
            else{
                Console.WriteLine($"snyggt ! det är  {returnvalue}");

                
            }
        }
    }
}


/*do









/*do

Console.WriteLine("gissa tal mellan 1 till 100");

Random randomerare = new Random();
int slump_tal = randomerare.Next(1,101);






    string strNr = Console.ReadLine();
    int nr= Convert.ToInt32(strNr); 
    int guess = 0;


{

slump_tal=randomerare.Next(1,101);
guess +=1;

if (nr> slump_tal);

}


{
Console.WriteLine("din gissning är fel");
Console.WriteLine("gissa lägre");

}

else if(nr<slump_tal)
{
    Console.WriteLine("din gissning är fel");
    Console.WriteLine("gissa högre");
}

{ while (nr! = slump_tal);
Console.WriteLine ("grattis gu gissade rätt" " + guess + "försök" );

} 
*/