using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Dapper;

namespace POSalesData
{
    public class Repository : IDisposable
    {
            private readonly IDbConnection dbconnection;

            public Repository(IDbConnection dbconnection)
            {
                this.dbconnection = dbconnection;
            }

            public void Dispose()
            {
                dbconnection.Dispose();
                GC.SuppressFinalize(this);
            }
            public void InsertItem<T>(T items, string[] ignorar)
            {


                //REFFLECTION
                var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CanRead && p.CanWrite && !ignorar.Any(y => y.Equals(p.Name))

               ).Select(x => x.Name).ToList();

                var insertStatement = $"Insert Into Items ({string.Join(",", props)}) Values ({string.Join(",", props.Select(x => string.Format("@{0}", x)))})";


                int rowsAffected = dbconnection.Execute(insertStatement, items);


            }

            public List<T> GetAll<T>(string tablename)
            {
                try
                {
                    var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CanRead && p.CanWrite
                     ).Select(x => x.Name).ToList();
                    var selectStatement = $"Select {string.Join(",", props)} From {tablename}";
                    return dbconnection.Query<T>(selectStatement).ToList();
                }
                catch
                {
                    throw;
                }


            }
            public void UpdateItems<T>(T items)
            {
                var props = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(p => p.CanRead && p.CanWrite
                         ).Select(x => x.Name).ToList();
                var updateStatement = $"Update Items({string.Join(",", props)})Set ({string.Join(",", props.Select(x => string.Format("WHERE @Id={id}", x)))}) ";
                int rowsAffected = dbconnection.Execute(updateStatement, items);
            }


        }
    }
