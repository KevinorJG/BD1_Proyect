using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

#nullable disable

namespace Financiera.Domain.ContextDB
{
    public partial class FinancieraContext : DbContext, IFinancieraContext
    {
        public FinancieraContext()
        {
        }

        public FinancieraContext(DbContextOptions<FinancieraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        public async Task<bool> DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetClientByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertClient(Client entity)
        {
            SqlParameter[]? param = null;
            int result = 0;
            
                try
                {
                    param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@name",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size= 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Names
                        },
                        new SqlParameter() {
                            ParameterName = "@lastnames",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.LastNames
                        },
                        new SqlParameter() {
                            ParameterName = "@direction",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Direction
                        },
                        new SqlParameter() {
                            ParameterName = "@phone",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 15,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Phone
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@birthdate",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.BirthDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@nationality",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Nationality
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@dni",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Identification
                        }


                     };
                    var execute = Database.ExecuteSqlRawAsync("[dbo].[sp_InsertClient] @name,@lastnames,@direction,@phone,@birthdate,@nationality,@dni", param);
                    await execute;
                    result = execute.Result;
                   
                }
                catch (Exception ex)
                {
                   
                }
            


            return result;
        }


        public async Task<bool> UpdateClient(Client entity)
        {
            SqlParameter[]? param = null;
            bool result = false;

            try
            {
                param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@name",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size= 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Names
                        },
                        new SqlParameter() {
                            ParameterName = "@lastnames",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.LastNames
                        },
                        new SqlParameter() {
                            ParameterName = "@direction",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 50,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Direction
                        },
                        new SqlParameter() {
                            ParameterName = "@phone",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 15,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Phone
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@birthdate",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.BirthDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@nationality",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Nationality
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@dni",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Identification
                        }


                     };
                var execute = Database.ExecuteSqlRawAsync("[dbo].[sp_UpdateClient] @name,@lastnames,@direction,@phone,@birthdate,@nationality,@dni", param);
                await execute;
                result = execute.IsCompleted;

            }
            catch (Exception ex)
            {

            }
            return result;
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
