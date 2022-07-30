using System;

namespace Test01
{
    class Temperatur
    {
        // ----- Variables -----
        
        public float Celsius {get; private set; } = 20f;
        public float Kelvin {get; private set; } = 68f;
        public float Fahrenheit {get; private set; } = 293.15f;
        
        ///
        /// Change default temperature type
        /// int = 0 Celsius (default); int = 1 Kelvin; int = 2 Fahrenheit
        ///
        int _temperaturType = 0;
        ///
        /// Increase or decrease temperature value
        ///
        float changeTemp = 1f;

        // ----- Constructor -----
        public Temperatur()
        {
           
        }
        
        // ----- Methodes -----
        
        ///
        /// Change the initial temperature type
        /// Int 0 = Celsius; Int 1 = Kelvin; Int 2 = Fahrenheit
        ///
        public void changeInitValues(int tempType, float newTemp){
            

            _temperaturType = tempType;
            switch (tempType){
                case 0:
                    Celsius = newTemp;
                    break;
                case 1:
                    Kelvin  = newTemp;
                    break;
                case 2:
                    Fahrenheit = newTemp;
                    break;
            }
            changeTemp = 0f;
            calcTemp();
            changeTemp = 1f;

        }
        
        ///
        /// Change the Temperature depend on initial values
        ///
        public void changeTemperature(bool _decrease)
        {
            changeTemp = System.Math.Abs(changeTemp);
            if (_decrease){
                changeTemp = changeTemp * -1;
            }
            calcTemp();
        }
        
        ///
        /// Print result to console
        ///
        public void Result()
        {

            Console.WriteLine("Rechne jetzt...");
            Console.WriteLine("Celsuis: " + Celsius);
            Console.WriteLine("kelvin: " + Kelvin);
            Console.WriteLine("fahrenheit: " + Fahrenheit);
        }
        // ----- Private Methodes -----

        ///
        /// Calculate new Temperature depend on "changeTemp"
        private void calcTemp(){
            switch(_temperaturType){
                case 0:
                Celsius = (Celsius + changeTemp);
                Fahrenheit = (Celsius * 1.8f + 32f);
                Kelvin = (Celsius + 273.15f);
                break;

                case 1:
                Kelvin = (Kelvin + changeTemp);
                Celsius = (Kelvin - 273.15f);
                Fahrenheit = (Celsius * 1.8f + 273.15f);
                break;

                case 2:
                Fahrenheit = (Fahrenheit + changeTemp);
                Celsius = (Fahrenheit / 1.8f - 32f);
                Kelvin = (Celsius + 273.15f);
                break;

        
            }
        }



    }
    class Program
    {
        
        static void Main(string[] args)
        {
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        
        // Klasse mit 20 Grad instanzieren?
        
        string input01;
        Temperatur temp01 = new Temperatur();   

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
                if (success == true){
                    temp01.changeInitValues(2, result);
                    Console.WriteLine("doppelhäää)");
                }

        }
        
    
       }
       
        temp01.Result();
        Console.WriteLine("---------------");
        Console.WriteLine("Wennu jetzt erhöhen willst, tippe q\nverringern mit e \nexit für Beenden");
        Console.WriteLine("---------------");
        input01 = Console.ReadLine();
        

        while (input01 != "exit"){
            
            if (input01 == "q"){
                
                temp01.changeTemperature(false);
                temp01.Result();
                input01 = Console.ReadLine();

            } else if (input01 == "e"){
                temp01.changeTemperature(true);
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