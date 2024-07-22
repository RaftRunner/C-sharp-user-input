class Program{
    static void Main(string[] args){

    //Username example for strings
    Console.WriteLine("Enter username: ");
    string userName = Console.ReadLine();
    Console.WriteLine("Username is: " + userName);

    //Age example for ints
    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Your age is: " + age);

    Console.WriteLine("So you're " + userName + " and you're " + age);
    }
}
