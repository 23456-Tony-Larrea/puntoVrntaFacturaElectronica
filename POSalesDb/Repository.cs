using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace POSalesDb
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

        //public async Task UpdateAsync(T t)
        //{
        //    var updateQuery = GenerateUpdateQuery();

        //    using (var connection = dbconnection)
        //    {
        //        await connection.ExecuteAsync(updateQuery, t);
        //    }
        //}
        //private string GenerateUpdateQuery()
        //{
        //    var updateQuery = new StringBuilder($"UPDATE Items SET ");
        //    var properties = GenerateListOfProperties(GetProperties);

        //    properties.ForEach(property =>
        //    {
        //        if (!property.Equals("Id"))
        //        {
        //            updateQuery.Append($"{property}=@{property},");
        //        }
        //    });

        //    updateQuery.Remove(updateQuery.Length - 1, 1); //remove last comma
        //    updateQuery.Append(" WHERE Id=@Id");

        //    return updateQuery.ToString();
        //}


    }
}
