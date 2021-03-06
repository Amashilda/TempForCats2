﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace TempForCats2.Models
{
    public class Dao
    {
        public LoginModel getCredentials()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["mssql"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(String.Format("SELECT * FROM Logins")))
                {
                    command.Connection = connection;
                    using (var reader = command.ExecuteReader())
                    {
                        LoginModel model = new LoginModel();

                        if (reader.Read())
                        {
                            model.Login = reader["Login"].ToString();
                            model.Password = reader["Password"].ToString();
                        }

                        return model;
                    }
                }
            }
        }


    }
}