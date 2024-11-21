using System.Data;
using System.Data.SQLite;

namespace ManagerApplication
{
    public class DatabaseManager
    {
        private const string ConnectionString = "Data Source=Database/addressManager.db;Version=3;";

        // Method to get an open connection to the database
        public SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            // Enable foreign key constraints
            using (var command = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
            {
                command.ExecuteNonQuery();
            }

            return connection;
        }

        public DataTable GetAllOrganisations()
        {
            using (var connection = GetConnection())
            {
                string query = "SELECT * FROM Organisations";
                using (var command = new SQLiteCommand(query, connection))
                {
                    var dataTable = new DataTable();
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
            }
        }
        public void AddOrganisation(string name, string street, string zip, string city, string country)
        {
            using (var connection = GetConnection())
            {
                string query = "INSERT INTO Organisations (Name, Street, Zip, City, Country) VALUES (@Name, @Street, @Zip, @City, @Country)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Street", street);
                    command.Parameters.AddWithValue("@Zip", zip);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@Country", country);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrganisation(int id, string name, string street, string zip, string city, string country)
        {
            using (var connection = GetConnection())
            {
                string query = "UPDATE Organisations SET Name = @Name, Street = @Street, Zip = @Zip, City = @City, Country = @Country WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Street", street);
                    command.Parameters.AddWithValue("@Zip", zip);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@Country", country);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOrganisation(int id)
        {
            using (var connection = GetConnection())
            {
                string query = "DELETE FROM Organisations WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllStaff()
        {
            using (var connection = GetConnection())
            {
                string query = "SELECT * FROM Staff";
                using (var command = new SQLiteCommand(query, connection))
                {
                    var dataTable = new DataTable();
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    return dataTable;
                }
            }
        }

        public void AddStaff(string title, string firstName, string lastName, string phoneNumber, string email, int organisationId)
        {
            using (var connection = GetConnection())
            {
                string query = "INSERT INTO Staff (Title, FirstName, LastName, PhoneNumber, Email, OrganisationId) " +
                               "VALUES (@Title, @FirstName, @LastName, @PhoneNumber, @Email, @OrganisationId)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@OrganisationId", organisationId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStaff(int id, string title, string firstName, string lastName, string phoneNumber, string email, int organisationId)
        {
            using (var connection = GetConnection())
            {
                string query = "UPDATE Staff SET Title = @Title, FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, OrganisationId = @OrganisationId WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@OrganisationId", organisationId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStaff(int id)
        {
            using (var connection = GetConnection())
            {
                string query = "DELETE FROM Staff WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
