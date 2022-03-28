using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.dto
{
    class Vechicle
    {
        private int id;
        private string type;
        private string name;
        private string manufacturer;
        private string yearOfManufacture;
        private string engineNo;
        private string chassisNo;
        private string emissionNorm;
        

        public Vechicle()
        {

        }

        public Vechicle(string type, string name, string manufacturer, string yearOfManufacture, string engineNo, string chassisNo, string emissionNorm)
        {
            
            this.type = type;
            this.name = name;
            this.manufacturer = manufacturer;
            this.yearOfManufacture = yearOfManufacture;
            this.engineNo = engineNo;
            this.chassisNo = chassisNo;
            this.emissionNorm = emissionNorm;
        }

        public  string tostring()
        {
            return type + " " + name + " " + manufacturer + " " + yearOfManufacture + " " + chassisNo + " " + emissionNorm + " ";
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }

            set
            {
                manufacturer = value;
            }
        }

        public string YearOfManufacture
        {
            get
            {
                return yearOfManufacture;
            }

            set
            {
                yearOfManufacture = value;
            }
        }

        public string ChassisNo
        {
            get
            {
                return chassisNo;
            }

            set
            {
                chassisNo = value;
            }
        }

        public string EmissionNorm
        {
            get
            {
                return emissionNorm;
            }

            set
            {
                emissionNorm = value;
            }
        }

        public string EngineNo
        {
            get
            {
                return engineNo;
            }

            set
            {
                engineNo = value;
            }
        }
    }
    

   
}
