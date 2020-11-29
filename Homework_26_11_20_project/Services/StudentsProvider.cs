using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Homework_26_11_20.Models;


namespace Homework_26_11_20.Services
{
    public class StudentsProvider
    {
        private SqlConnection connection { get; set; }
        public StudentsProvider(SqlConnection _connection)
        {
            connection = _connection;
        }

        public List<Students> GetAllWith()
        {
            var resultList = new List<Students>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    @"
                    SELECT  [Specialties].[id], 
                            [Specialties].[name], 
                            [Specialties].[code], 
                            [Groups].[id], 
                            [Groups].[name], 
                            [Groups].[year], 
                            [Students].[id], 
                            [Students].[name], 
                            [Students].[surname]
                    FROM [Students]
                    LEFT JOIN [Groups]
                    ON [Students].[group_id] = [Groups].[id]
                    LEFT JOIN [Specialties]
                    ON [Groups].[specialty_id] = [Specialties].[id];
                    ", connection);
                using (var reader = command.ExecuteReader())
                {
                    var specialty = new Specialty
                    {
                        Id: reader.GetInt32(0);
                        Code: reader.GetString(1);
                        Name: reader.GetString(2)
                    }
                    var group = new Group
                    {
                        Id: reader.GetInt32(3),
                        Name: reader.GetString(4),
                        Year: reader.GetInt32(5),
                        SpecialtyId: specialty.Id,
                        Specialty: specialty
                    };
                    var student = new Student
                    {
                        Id: reader.GetInt32(6),
                        Name: reader.GetString(7),
                        Surname: reader.GetString(8),
                        Group: group,
                        GroupId: group.Id
                    };
                    resultList.Add(student);
                }
            }
            finally
            {
                connection.Close();
            }
            return resultList;
        }

        public bool Update(Student item)
        {
            bool result = false;
            try
            {
                connection.Open();
            var command = new SqlCommand(
                @"
                UPDATE [Students]
                SET
                    [name] = @Name,
                    [surname] = @Surname,
                    [group_id] = @GroupId
                WHERE
                    [id] = @Id", 
                connection
                );
            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@Surname", item.Surname);
            command.Parameters.AddWithValue("@GroupId", item.Group.Id);
            command.Parameters.AddWithValue("@Id", item.Id);

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
                                DELETE FROM [Students]
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
        public bool Add(Student item)
        {
            bool result = false;
            try
            {
                connection.Open();
                var command = new SqlCommand(
                    cmdText:
                    @"
                                    INSERT INTO [Groups]
                                        ([name], [surname], [group_id])
                                    VALUES
                                        (@Name, @Surname, @GroupId)

                            ", connection);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Surname", item.Surname);
                command.Parameters.AddWithValue("@GroupId", item.GroupId);

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
