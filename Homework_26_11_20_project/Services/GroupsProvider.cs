using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Homework_26_11_20.Models;

namespace Homework_26_11_20.Services
{
    class GroupsProvider
    {
        public GroupsProvider(SqlConnection connection)
        {
            this.connection = connection;
        }

        private SqlConnection connection;
        public List<Group> GetAll()
        {
            var resultList = new List<Group>();
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText: @"
SELECT [Groups].[id], [Groups].[name], [course], [year], [specialty_id], [Specialties].[name], [Specialties].[code] 
FROM [Groups]
LEFT JOIN [Specialties] 
ON [Groups].[specialty_id] = [Specialties].[id];",
                    connection: connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new Group();
                        var specialty = new Specialty();
                        item.Id = reader.GetInt32(0);
                        item.Name = reader.GetString(1);
                        item.Course = reader.GetInt32(2);
                        item.Year = reader.GetInt32(3);
                        item.SpecialtyId = reader.GetInt32(4);
                        specialty.Id = reader.GetInt32(4);
                        specialty.Name = reader.GetString(5);
                        specialty.Code = reader.GetString(6);
                        item.Specialty = specialty;
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

        public bool Add(Group group) 
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText: 
                    @"
                            INSERT INTO [Groups]
                                ([name], [year], [course], [specialty_id])
                            VALUES
                                (@Name, @Year, @Course, @SpecialtyId)

                    ", connection);
                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@Course", group.Course);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally 
            {
                connection.Close();

            }

            return result;
        }
        public bool Update(Group group) 
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand
                    (@"
                        UPDATE [Groups]
                        SET
                            [year] = @Уear,
                            [name] = @Name,
                            [course] = @Course
                        WHERE
                            [id] = @Id

                    ", connection);
                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@Course", group.Course);
                command.Parameters.AddWithValue("@Id", group.Id);
                
                result = command.ExecuteNonQuery() > 0;
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
                        DELETE FROM [Groups]
                        WHERE [id] = @Id
                    ",
                    connection
                    );
                command.Parameters.AddWithValue("@Id", id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();

            }
            return result;
        }
    }
}
