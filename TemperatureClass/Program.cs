using System;

namespace TemperatureClass
{

    /// ===== Temperature class =====
    public class Temperature
    {
        /// ===== Variables =====
        public float Celsius { 
            get { return _celsius; } 
            private set { _celsius = value; } 
        }
        public float Kelvin {
             get { return _kelvin; } 
             private set { _kelvin = value; }
        }
        public float Fahrenheit { 
            get { return _fahrenheit; }
            private set { _fahrenheit = value; }
            }
        public float AddTemp {
             get { return _addTemp; }
             private set { _addTemp = value; }
            }

        float _celsius;
        float _kelvin;
        float _fahrenheit;
        int _tempType;
        float _addTemp = 1f;
    

        /// ===== Constructor =====

        // Default: 
        // tempType = 0 (Celsius); tempValue = 20f
        public Temperature(){
            _tempType = 0;
            _celsius = 20f;
            calcTemp(0f);
        }
        // Variable: Change the initial temperatur type and value 
        // tempType = 0 -> Celsius; = 1 -> Kelvin; = 2 -> Fahrenheit
        // tempValue -> Initial Temperature
        public Temperature(int tempType, float tempValue){
            _tempType = tempType;
            switch(_tempType){
                case 0:
                _celsius = tempValue;
                break;
                case 1:
                _kelvin = tempValue;
                break;
                case 2:
                _fahrenheit = tempValue;
                break;
            }
            calcTemp(0f);
        }


        /// ===== Methodes ======

        // Change the value to increase/decrease the temperature with
        public void changeAddTemp(float changeAddTemp){
            _addTemp = changeAddTemp;
        }

        // Increase or decrease the temperature with current "addTemp" value
        public void changeTemp(bool decrease){
            _addTemp = System.Math.Abs(_addTemp);
            if (decrease){
                _addTemp = _addTemp * -1;
            }
            calcTemp(_addTemp);
        }

        // Print the current temperature values to console
        public void printResult(){
            Console.WriteLine ( "===========\nCalculated Temerature:\n===========" );
            Console.WriteLine ( "Celsius: " + _celsius );
            Console.WriteLine ( "Kelvin: " + _kelvin );
            Console.WriteLine ( "Fahrenheit: " + _fahrenheit );
        }

        // Calsulate all temperature values
        void calcTemp(float addToTemp){
                    
            switch(_tempType){
                case 0:
                _celsius = ( _celsius + addToTemp );
                _kelvin = ( _celsius + 273.15f );
                _fahrenheit = ( _celsius * 1.8f + 32f );
                break;
                case 1:
                _kelvin = ( _kelvin + addToTemp );
                _celsius = ( _kelvin - 273.15f );
                _fahrenheit = ( _celsius * 1.8f + 32f );
                break;
                case 2:
                _fahrenheit = ( _fahrenheit + addToTemp );
                _celsius = ( _fahrenheit / 1.8f - 32f);
                _kelvin = ( _celsius + 273.15f );
                break;
            }

        }



    }


 
    class Program
    {
        /// ===== Main methode =====
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Temperature temp01 = new Temperature( 2, 12f);
            temp01.printResult();
            

            temp01.changeAddTemp(29f);
            
            
            string input01;
            Console.WriteLine( temp01.Fahrenheit );
            Console.WriteLine( "y für decrease, sonst increase");
            input01 = Console.ReadLine();   
            if ( input01 == "y" ){
                temp01.changeTemp( true );
            }
            else{
                temp01.changeTemp( false );
            }

            
            temp01.printResult();





            // Wait before closing
            Console.ReadKey();


        }

    }
    









}









