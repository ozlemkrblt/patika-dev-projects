class Program
{

    static void Main(string[] args)
    {
        //add to launch.json , "console"="integratedTerminal" 
        //useful in indexed contstants
        
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Thursday);
        Console.WriteLine((int)Days.Friday);

        int temperature = 30;

        if (temperature <= (int)Weather.Normal)
        {
            Console.WriteLine($"Temperature: {temperature}" + " Please wait for weather to get hotter");
        }else if (temperature>=(int)Weather.ExtremelyHot)
        {
            Console.WriteLine($"Temperature: {temperature}" + " Warning! It is to hot too go out!");
        }else if ((int)Weather.Normal<=temperature && temperature<=(int)Weather.Hot)
        {
            Console.WriteLine($"Temperature: {temperature}" + " Let's go out!");    
        }
    }
}

enum Days { Monday,Tuesday,Wednesday,Thursday,Friday=23,Saturday,Sunday }
enum Weather { Cold=5 , Normal = 23 , Hot= 32, ExtremelyHot=40}