using System;
using System.Data;
using com.dataLayer;
using System.Data.SqlClient;
using com.interfaces;


namespace com.dto
{
    class TwoWheeler :Vechicle,IVechicle
    {
       
        public event drive driveops;
   
        public TwoWheeler(string t, string name, string manufacturer, string yearOfManufacture, string engineNo,string chassisNo, string emissionNorm)
        : base(t, name, manufacturer, yearOfManufacture, engineNo,chassisNo, emissionNorm)
        {
            this.driveops += new drive(firstStep);
            this.driveops += new drive(secondStep);
            this.driveops += new drive(thirdStep);
            this.driveops += new drive(fouthStep);
            this.driveops += new drive(fifthStep);
        }

        public TwoWheeler()
        {
        }

        public void driveOps()
        {
            this.driveops();
        }
        public DataTable fetchFromDb(int id)
        {
            SqlConnection con = DatabaseConnection.getConnection();
            DataTable dt = null;
            //using (_dbConnection)
            {
                using (SqlCommand sqlComm = new SqlCommand("[dbo].[fetchFromDb]", con))
                {
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter(sqlComm))
                    {
                        dt = new DataTable();
                        sqlDA.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public  void saveToDb(Vechicle vechicle)
        {
            int noOfRowsAffected = -1;
            SqlConnection con = DatabaseConnection.getConnection();
            try
            {
                con.Open();
                SqlCommand sqlComm = new SqlCommand("[dbo].[saveToDb]", con);
                {
                    sqlComm.CommandType = CommandType.StoredProcedure;
                    sqlComm.Parameters.Add(new SqlParameter("@type", vechicle.Type));
                    sqlComm.Parameters.Add(new SqlParameter("@name", vechicle.Name));
                    sqlComm.Parameters.Add(new SqlParameter("@manufacturer", vechicle.Manufacturer));
                    sqlComm.Parameters.Add(new SqlParameter("@yearOfManufacture", vechicle.YearOfManufacture));
                    sqlComm.Parameters.Add(new SqlParameter("@engineNo", vechicle.EngineNo));
                    sqlComm.Parameters.Add(new SqlParameter("@chasisNo", vechicle.ChassisNo));
                    sqlComm.Parameters.Add(new SqlParameter("@emissionNorm", vechicle.EmissionNorm));
                                                         noOfRowsAffected = sqlComm.ExecuteNonQuery();
                }
                con.Close();
            }catch(Exception e)
            {
                Console.WriteLine("error -> " + e.Message);
            }
            Console.WriteLine(noOfRowsAffected);
        }
        public void firstStep()
        {
            Console.WriteLine(this);
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
