using System;
using System.Collections.Generic;
using System.Text;

namespace Vakuutusmaksut
{
    class Animal
    {
        public string species;
        public bool isDogOrCat;
        public bool neutered;
        public int price;

        public Animal()
        {

        }

        public Animal(string species, string isNeutered, int price)
        {
            SetSpecies(species);
            IsNeutered(isNeutered);
            SetPrice();
        }

        public void CheckInput(string value)
        {
            if(value.Length == 1)
            {
                this.species = value;
            }
            else
            {
                Console.WriteLine("Syötä vain yksi merkki!");
            }
        }

        public void CheckInput2(string value)
        {
            if(value.Contains("K") || value.Contains("k"))
            {
                this.neutered = true;
            }
            else if (value.Contains("E") || value.Contains("e"))
            {
                this.neutered = false;
            }
            else
            {
                Console.WriteLine("Syötä K tai E!");
            }
        }

        public void SetSpecies(string value)
        {
            if (value.Contains("A") || value.Contains("a"))
            {
                this.species = "Koira";
                this.isDogOrCat = true;
            }
            else if (value.Contains("B") || value.Contains("b"))
            {
                this.species = "Kissa";
                this.isDogOrCat = true;
            }
            else if (value.Contains("C") || value.Contains("c"))
            {
                this.species = "Lintu";
                this.isDogOrCat = false;
            }
            else
            {
                this.species = "Matelija";
                this.isDogOrCat = false;
            }
        }

        public void IsNeutered(string value)
        {
            if(value.Contains("K") || value.Contains("k"))
            {
                this.neutered = true;
            }
            else if (value.Contains("E") || value.Contains("e"))
            {
                this.neutered = false;
            }
            else
            {
                Console.WriteLine("Syötä K tai E!");
            }
        }

        public void SetPrice()
        {
            if (this.species == "Koira" && this.neutered == false)
            {
                this.price = 80;
            }
            else if (this.species == "Koira" && this.neutered == true)
            {
                this.price = 50;    
            }
            else if (this.species == "Kissa" && this.neutered == false)
            {
                this.price = 60;
            }
            else if (this.species == "Kissa" && this.neutered == true)
            {
                this.price = 40;
            }
            else
            {
                this.price = 0;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Eläimesi: {0}, vakuutus maksaa {1}.", this.species, this.price);
        }
    }
}
