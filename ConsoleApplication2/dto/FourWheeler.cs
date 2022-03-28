
using System;
using System.Data;
using System.Data.SqlClient;
using com.dataLayer;
using com.dto;
using com.interfaces;

namespace com.dto
{
    class FourWheeler : Vechicle, IVechicle
    {

        public event drive driveops;


        public FourWheeler(string type, string name, string manufacturer, string yearOfManufacture, string engineNo, string chassisNo, string emissionNorm)
        : base(type, name, manufacturer, yearOfManufacture, engineNo, chassisNo, emissionNorm)
        {

            this.driveops += new drive(firstStep);
            this.driveops += new drive(secondStep);
            this.driveops += new drive(thirdStep);
            this.driveops += new drive(fouthStep);
            this.driveops += new drive(fifthStep);

        }

        public FourWheeler()
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
                using (SqlCommand sqlComm = new SqlCommand("[dbo].[getById]", con))
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

        public void saveToDb(Vechicle vechicle)
        {

            int noOfRowsAffected = -1;
            SqlConnection con = DatabaseConnection.getConnection();

            con.Open();
            SqlCommand sqlComm = new SqlCommand("[dbo].[SaveINtoDb]", con);
            {
                sqlComm.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@id", 2);
                sqlComm.Parameters.Add(param1);
                SqlParameter param2 = new SqlParameter("@name", "Pawan Kumar");
                sqlComm.Parameters.Add(param2);
                noOfRowsAffected = sqlComm.ExecuteNonQuery();
            }
            con.Close();
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

