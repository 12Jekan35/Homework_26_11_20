using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Homework_26_11_20.Models;

namespace Homework_26_11_20.Services
{
    public class SpecialtiesProvider
    {
        public SpecialtiesProvider(SqlConnection connection)
        {
            this.connection = connection;
        }

        private SqlConnection connection;
        public List<Specialty> GetAll()
        {
            var resultList = new List<Specialty>();
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText: "SELECT [id], [name], [code] FROM [Specialties]",
                    connection: connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Specialty();
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Code = reader.GetString(2);
                        resultList.Add(item);
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return resultList;
        }

        public bool Add(Specialty item)
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText: @"INSERT INTO [Specialties] 
([code], [name])
VALUES
    (@Code, @Name);",
                    connection: connection

                );
                command.Parameters.AddWithValue("@Code", item.Code);
                command.Parameters.AddWithValue("@Name", item.Name);
                int affected = command.ExecuteNonQuery();
                result = affected > 0;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public bool Update(Specialty item)
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
UPDATE [Specialties] SET
[code] = @Code
[name] = @Name
WHERE [id] = @Id",
                    connection: connection
                );
                command.Parameters.AddWithValue("@Code", item.Code);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Id", item.Id);

                int affected = command.ExecuteNonQuery();
                result = affected > 0;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    @"
DELETE FROM [Specialties]
WHERE [id] = @Id
", connection);
                command.Parameters.AddWithValue("@Id", id);
                int affected = command.ExecuteNonQuery();
                result = affected > 0;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
