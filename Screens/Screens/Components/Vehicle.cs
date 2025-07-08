using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Screens.Components.SuperInterfaces;

namespace Screens.Components
{
    abstract class Vehicle : DBInputOutput
    {
        /*fields */
        protected string numberPlate;
        protected string brand;
        protected string model;
        protected double price;


        /*Properties*/
        public string NumberPlate { get { return numberPlate; } set { numberPlate = value; } }

        public string Brand { get { return brand; } set { brand = value; } }

        public string Model { get { return model; } set { model = value; } }

        public double Price { get { return price; } set { price = value; } }

        /*coding inherited fuctions*/
        public abstract void Insert();

        public abstract void Update();

        public abstract DataTable Display();
    }
}