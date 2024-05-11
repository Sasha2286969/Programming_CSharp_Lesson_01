using System.Runtime.CompilerServices;

Console.WriteLine("Welcom to the calculator3000, please enter +, -, / or *.");
string abobus = Console.ReadLine();
if(abobus == "+")
{

}
else
{
    if(abobus == "-")
    {

    }
    else
    {
        if(abobus == "/")
        {
            Console.WriteLine("Enter argument 1");
            string argument_1_3 = Console.ReadLine();
            int argument_1_3_dig = int.Parse(argument_1_3);
            Console.WriteLine("Enter argument 2");
            string argument_1_4 = Console.ReadLine();
            int argument_1_4_dig = int.Parse(argument_1_4);
            int result_3 = argument_1_3_dig / argument_1_4_dig;
            string result_str228 = result_3 + " This is youre resut";
            Console.WriteLine(result_str228);
        }
        else
        {
            if(abobus == "*")
            {
                
            }
        }
    }
}