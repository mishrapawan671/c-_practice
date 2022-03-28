using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
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



    }

    interface IVechicle
    {
        void saveToDb(Vechicle vechicle);
        DataTable fetchFromDb(int id);


    }
    class TwoWheeler : IVechicle
    {
        public delegate void drive();
        public event drive driveops;
        public TwoWheeler()
        {

            this.driveops += new drive(firstStep);
            this.driveops += new drive(secondStep);
            this.driveops += new drive(thirdStep);
            this.driveops += new drive(fouthStep);
            this.driveops += new drive(fifthStep);


        }
        public void driveOps()
        {
            this.driveops();
        }
        public DataTable fetchFromDb(int id)
        {
            throw new NotImplementedException();
        }

        public void saveToDb(Vechicle vechicle)
        {
            throw new NotImplementedException();
        }
        public void firstStep()
        {
            Console.WriteLine("Start Engine");
        }
        public void secondStep()
        {
            Console.WriteLine("Drive");
        }
        public void thirdStep()
        {
            Console.WriteLine("follow traffic rules");
        }
        public void fouthStep()
        {
            Console.WriteLine("stop Engine");
        }
        public void fifthStep()
        {
            Console.WriteLine("stop Drive");
        }

    }

    class FourWheeler : IVechicle
    {
        private delegate void drive();
        private event drive driveops;
        public FourWheeler()
        {
            this.driveops += new drive(firstStep);
            this.driveops += new drive(secondStep);
            this.driveops += new drive(thirdStep);
            this.driveops += new drive(fouthStep);
            this.driveops += new drive(fifthStep);


        }
        public void driveOps()
        {
            this.driveops();
        }
        public DataTable fetchFromDb(int id)
        {
            throw new NotImplementedException();
        }

        public void saveToDb(Vechicle vechicle)
        {
            throw new NotImplementedException();
        }
        public void firstStep()
        {
            Console.WriteLine("Start Engine");
        }
        public void secondStep()
        {
            Console.WriteLine("Drive");
        }
        public void thirdStep()
        {
            Console.WriteLine("follow traffic rules");
        }
        public void fouthStep()
        {
            Console.WriteLine("stop Engine");
        }
        public void fifthStep()
        {
            Console.WriteLine("stop Drive");
        }

    }
}
