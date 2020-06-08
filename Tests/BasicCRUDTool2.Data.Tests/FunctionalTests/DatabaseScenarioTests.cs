using BasicCRUDTool2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.ComponentModel;

namespace BasicCRUDTool2.Data.Tests.FunctionalTests
{
    [TestClass]
    public class DatabaseScenarioTests
    {
        [TestMethod]
        public void CanConnectToDataBase()
        {
            using (var conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Testing"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    Assert.IsTrue(conn.State == ConnectionState.Open);
                }
                catch(NpgsqlException e)
                {
                    Console.WriteLine(e.ToString());
                    Assert.Fail("Connection to test server has failed");
                }
            }
        }

        [TestMethod]
        public void CanCreateDatabase()
        {

        }
    }
}
