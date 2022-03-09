using System;
namespace Challenge_Automobile
{
    class Automobile
    {
        private string make, model, vin, color;
        private int year;
        private AutoType type;
        int currentYear = DateTime.Now.Year;
        public int getAutoAge(){
            int value = currentYear - this.year;
            return value;
        }
        public Automobile(string make, string model, int year, string vin, string color, AutoType type){
            this.make = make;
            this.model = model;
            this.vin = vin;
            this.color = color; 
            this.year = year;
            this.type = type;
        }
        public AutoType getType()
        {
            return this.type;
        }
        public string getMake(){
            return this.make;
        }
        public string getModel(){
            return this.model;
        }
        public string getVin(){
            return this.vin;
        }
        public int getYear(){
            return this.year;
        }
        
        public string getColor(){
            return this.color;
        }
        public void setColor(string newColor){
            this.color = newColor;
        }
    }
}