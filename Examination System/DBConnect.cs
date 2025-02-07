using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using Examination_System;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

public static class DBConnect
{

    private static SqlConnection con;

    //Replace this ConnectionString with Yours 
    private static string connectionString = "Data Source=YAHYA\\SQLEXPRESS;Initial Catalog=Examination System;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    

    public static int ProcedureQ(string storedProcedureName, string[] paramNames, object[] paramValues, out string[] Array_OfStrings)
    {
        string Result = string.Empty;

        try
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(storedProcedureName, con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ensure parameter names and values match in length
                    if (paramNames != null && paramValues != null && paramNames.Length == paramValues.Length)
                    {
                        for (int i = 0; i < paramNames.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(paramNames[i]))
                            {
                                command.Parameters.AddWithValue(paramNames[i], paramValues[i] ?? DBNull.Value);
                            }
                        }
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Result += reader.IsDBNull(i) ? "NULL\n" : reader[i].ToString() + "\n";
                            }
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(Result))
            {
                Array_OfStrings = new string[] { "No Result" };
                return 0;
            }
        }
        catch (Exception error)
        {
            Debug.WriteLine(error);
            Array_OfStrings = new string[] { $"Error Message: {error.Message}" };
            return 0;
        }

        Array_OfStrings = Result.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        return 1;
    }

    // Used only For Select Query or Procedures that Returns Select Statement ,Name Must Contain "Select" Word
    // If Successful 
    // Returns 1
    // Returns Query Result as an String Array passed by referance
    // for example if query result is (ID Name Subject) function result will be 3 rows
    // else
    // Returns 0
    // and The Error Message will be in the passed by ref varable

    // You don't need to intialize the Array_ofStrings before Passing it
    public static int SelectQ(string Query, out string[] Array_OfStrings)
    {
        string Result = string.Empty;


        if (!Query.Contains("select") && !Query.Contains("SELECT") && !Query.Contains("Select"))
        {
            Array_OfStrings = new string[1];
            Array_OfStrings[0] = "Error : USE Only Select Statement";
            return 0;
        }
        try
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(Query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.IsDBNull(i))
                        Result += ("NULL\n");
                    else
                        Result += (Convert.ToString(reader[i]) + "\n");
                }
            }
            if (Result == string.Empty)
                { Array_OfStrings = new string[1]; Array_OfStrings[0]= "No Result"; return 0; }

            con.Close();
        }
        catch (Exception error)
        {

            Array_OfStrings = new string[1]; 
            Array_OfStrings[0] = $"Error Message : {error.Message}"; 
            return 0; 
        }

        Array_OfStrings = Result.Split("\n");

        if (Array_OfStrings[Array_OfStrings.Length - 1] == string.Empty)
            Array.Resize(ref Array_OfStrings, Array_OfStrings.Length - 1);

        return 1;
    }

    // used for insert , update , delete
    // if successful returns affected rows count as a string
    // else returns error message

    /*
      Usage Example

       1)Single Insert
         string query = "INSERT INTO Student (ID, Name, Age) VALUES (1, 'John Doe', 20);";

       2) Multi-Insert
         string query = @"
        INSERT INTO Student (ID, Name, Age) VALUES (1, 'John Doe', 20);
        INSERT INTO Student (ID, Name, Age) VALUES (2, 'Jane Doe', 22);
        INSERT INTO Student (ID, Name, Age) VALUES (3, 'Alice Smith', 21);";

        3) Update
            string query = "UPDATE Student SET Name = Ahmed WHERE ID = 8";

        4) Delete
            string query = "DELETE FROM Student WHERE ID = 10";
     */
    public static string ModifyQ(string Query)
    {
        
        try
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand(Query, con);
            int row = command.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                return Convert.ToString(row);
            else
                return "Modifing Error";
        }
        catch (Exception error) { return $"Error Message : {error.Message}"; }
    }
}

