using System;

namespace Test01
{
    class Temperatur
    {
        // Variables
        public float celsius = 20.0f;

        // Constructor
        public Temperatur(float _celsius)
        {
            celsius = _celsius;
        }
        
        // Methode
        public void Result()
        {
            Console.WriteLine("Rechne jetzt...");
            Console.WriteLine("celsius: " + celsius);
            Console.WriteLine("kelvin: " + (celsius * 1.8 + 32));
            Console.WriteLine("fahrenheit: " + (celsius + 273.15));
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        
        // Klasse mit 20 Grad instanzieren?
        
        string input01;
        float defaultTemperature = 20.0f;
        


        Console.WriteLine("Jo Bruder! Soll deine Temperatur Klasse mit 20° instanziert werden?\nDann tippe: y und bestätige mit ENTER");
        input01 = Console.ReadLine();
        

       if (input01 == "y"){
            Console.WriteLine("Danke, Abfrage umsonst gecodet!");
        }
       else{
        
            Console.WriteLine("K, dann gib halt den Wert, den du unbedingt haben willst und ENTER");
            
            bool success = Single.TryParse( Console.ReadLine(), out Single result);

            while(success == false){
                Console.WriteLine("Ach Junge, gib Float\nBITTE");
                success = Single.TryParse( Console.ReadLine(), out result);
        }
        
        defaultTemperature = result;
        
    
       }
       
        Temperatur temp01 = new Temperatur(defaultTemperature);
        temp01.Result();


        Console.WriteLine("---------------");
        Console.WriteLine("Wennu jetzt erhöhen willst, tippe q\nverringern mit e \nexit für Beenden");
        Console.WriteLine("---------------");
        input01 = Console.ReadLine();
        
        
        float newTemp = defaultTemperature;

        while (input01 != "exit"){
            
            if (input01 == "q"){
                temp01.celsius = newTemp + 1.0f;
                newTemp = temp01.celsius;
                temp01.Result();
                input01 = Console.ReadLine();

            } else if (input01 == "e"){
                temp01.celsius = newTemp - 1.0f;
                newTemp = temp01.celsius;
                temp01.Result();
                input01 = Console.ReadLine();
            } else{
                Console.WriteLine("Junge, bissu besoffen? Tipp q oder e!");
                input01 = Console.ReadLine();
            }
            
        }
        
        
        
        // Wait before closing
        Console.ReadKey();
        }
        

    }
}