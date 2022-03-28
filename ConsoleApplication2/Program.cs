using System;
using System.Data;
using com.dto;
namespace com
{
    public delegate void drive();
    class Program
    {

        static int frontPage() 
        {
            int choice;
            Console.Clear();
            Console.WriteLine("OPtion Menu");
            Console.WriteLine("(1)  create and invoke twoWheeler DriveOps");
            Console.WriteLine("(2)  create and invoke FourWheeler DriveOps");
            Console.WriteLine("(3)  save twoWheeler info to DB");
            Console.WriteLine("(4)  save fourWheeler info to DB");
            Console.WriteLine("(5)  fetch from Db by Id");
            Console.WriteLine("(6)  fetch all");// it is not implemented
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            return choice;
        }



        static void Main(string[] args)
        {

            FourWheeler fw = new FourWheeler();
            TwoWheeler tw = new TwoWheeler();
            int choice=0;

            while (true)
            {
                
                try
                {
                    choice = frontPage();
                } catch(Exception e)
                {
                    Console.WriteLine("Wrong input");
                    Console.ReadLine();
                }
                switch (choice)
                {
                    case 1:
                        {
                            TwoWheeler t = new TwoWheeler("dymmy", "dymmy", "dymmy", "dymmy", "dymmy", "dymmy", "dymmy");
                            t.driveOps();
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        {
                            FourWheeler f = new FourWheeler("dymmy", "dymmy", "dymmy", "dymmy", "dymmy", "dymmy", "dymmy");
                            f.driveOps();
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        {

                            Console.Write("\nEnter Type  ");
                            tw.Type = Console.ReadLine();
                            Console.Write("\nEnter Name  ");
                            tw.Name = Console.ReadLine();
                            Console.Write("\nEnter manufacturer ");
                            tw.Manufacturer = Console.ReadLine();
                            Console.Write("\nEnter yearOfManufacture    ");
                            tw.YearOfManufacture = Console.ReadLine();
                            Console.Write("\nEnter ChassisNo    ");
                            tw.ChassisNo = Console.ReadLine();
                            Console.Write("\nEnter EngineNo     ");
                            tw.EngineNo = Console.ReadLine();
                            Console.Write("\nEnter emissionNorm     ");
                            tw.EmissionNorm = Console.ReadLine();
                            tw.saveToDb(tw);
                            Console.Write(tw.tostring());

                        }
                        break;
                    case 4:
                        {
                            Console.Write("\nEnter Type  ");
                            fw.Type = Console.ReadLine();
                            Console.Write("\nEnter Name  ");
                            fw.Name = Console.ReadLine();
                            Console.Write("\nEnter manufacturer ");
                            fw.Manufacturer = Console.ReadLine();
                            Console.Write("\nEnter yearOfManufacture    ");
                            fw.YearOfManufacture = Console.ReadLine();
                            Console.Write("\nEnter ChassisNo    ");
                            fw.ChassisNo = Console.ReadLine();
                            Console.Write("\nEnter EngineNo     ");
                            fw.EngineNo = Console.ReadLine();
                            Console.Write("\nEnter emissionNorm     ");
                            fw.EmissionNorm = Console.ReadLine();
                            fw.saveToDb(tw);
                            Console.Write(fw.tostring());
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Vechicle Id ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            DataTable dt = tw.fetchFromDb(id);
                            if (dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    foreach (DataColumn dc in dt.Columns)
                                    {
                                        Console.Write(String.Format("{0} : {1} \n", dc.ColumnName, dr[dc.ColumnName]));
                                    }
                                    Console.WriteLine();
                                }
                            }
                            Console.ReadLine();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
