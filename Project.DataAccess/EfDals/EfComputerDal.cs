using Proje.Entity.Entities;
using Project.DataAccess.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.EfDals
{
    //  CRUD operations
    public class EfComputerDal
    {
        // constructor to take connectionstring
        private string connectionString;
        public EfComputerDal()
        {
            this.connectionString = new Project.DataAccess.Connection.ProjectConStr().getConstr();
        }
         
         // This Function is Adding Computer To Database
        public void ComputerAdd(Computer comp)
        {
            
           
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                var queryString = "INSERT INTO Computers (Modal, Particular,Total) VALUES('" + comp.Model + "','" + comp.Particular + "','" + comp.Total + "'); ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
           
        }

        // This Function is Getting Computer List From Database
        public List<Computer> GetComp()
        {
            var comp=new List<Computer>();
            using (SqlConnection connection = new SqlConnection(
              connectionString))
            {
                var queryString = "SELECT * FROM Computers ";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader readData = command.ExecuteReader();
                if (readData.HasRows)
                {
                    while (readData.Read())
                    {
                        Computer computer = new Computer();
                        computer.Id = Convert.ToInt32(readData.GetValue(0));
                        computer.Model = readData.GetValue(1).ToString();
                        computer.Particular = readData.GetValue(2).ToString();
                        computer.Total= Convert.ToInt32(readData.GetValue(3));
                        comp.Add(computer);
                    }
                }
                else
                {
                    return comp;
                }
                readData.Close();
            }
            return comp;
        }
        // This Function is Getting one  Computer From DataBase with Id
        public Computer GetCompById(int id)
        {
            Computer comp = new Computer();
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                var queryString = "Select * From Computers WHERE Id=" + id + ";";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader readData = command.ExecuteReader();
                if (readData.HasRows)
                {
                    while (readData.Read())
                    {
                        comp.Id = Convert.ToInt32(readData.GetValue(0));
                        comp.Model = readData.GetValue(1).ToString();
                        comp.Particular = readData.GetValue(2).ToString();
                        comp.Total = Convert.ToInt32(readData.GetValue(3));
                    }
                    

                }
                else
                {
                    comp = null;
                }
            }
            return comp;
            
        }
        // This Function is Updating Computer in data base
        public void UpdateComp(Computer computer)
        {
            Computer comp = new Computer();

            
            using (SqlConnection connetion= new SqlConnection(connectionString))
            {
                var queryString = "UPDATE Computers Set Modal='" + computer.Model + "',Particular='" + computer.Particular + "',Total='" + computer.Total + "'  where Id=" + computer.Id + ";";
                SqlCommand command = new SqlCommand(queryString, connetion);
                command.Connection.Open();
                command.ExecuteReader();
            }

        }
        // This Function is Deleting Computer To Database with Id
        public void DeleteComp(int id)
        {
            using (SqlConnection connection=new SqlConnection(connectionString))
            {
                var queryString = "Delete from Computers Where Id= " + id +"";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteReader();

            }
        }
      
    }
}
