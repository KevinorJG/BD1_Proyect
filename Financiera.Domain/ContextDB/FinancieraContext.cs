using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Financiera.Domain.Entities;
using Financiera.Domain.Interfaces;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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
        public virtual DbSet<AccountDetail> AccountDetails { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardDetail> CardDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Hideline> Hidelines { get; set; }

        public Task<bool> DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCard(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetAccountByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAccounts()
        {
            throw new NotImplementedException();
        }

        public Card GetCardByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public DataTable GetCards()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(this.Database.GetConnectionString()))
                {

                    conn.Open();
                    using (var cmd = new SqlCommand(this.Database.GetConnectionString(), conn))
                    {
                        cmd.CommandText = "select * from CardsView";
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        cmd.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {

            }         
            return dt;
        }

        public Client GetClientByDni(string dni)
        {
            Client cl = null;
            try
            {
                using (var conn = new SqlConnection(this.Database.GetConnectionString()))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(this.Database.GetConnectionString(), conn))
                    {
                        cmd.CommandText = "sp_BuscarClient";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter()
                        {
                            ParameterName = "@Identification",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 20,
                            Value = dni
                        });
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cl = new Client()
                            {
                                IdClient = int.Parse(reader["ID"].ToString()),
                                Names = reader["Nombres"].ToString(),
                                LastNames = reader["Apellidos"].ToString(),
                                Nacionality = reader["Nacionalidad"].ToString(),
                                Identification = reader["Identificación"].ToString(),
                                BirthDate = DateTime.Parse(reader["Fecha_Nacimiento"].ToString()),
                                Phone = reader["Número_Telefonico"].ToString(),
                                Direction = reader["Domicilio"].ToString()
                            };
                        }
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 229)
                {

                }
            }


            return cl;
        }

        public DataTable GetClients()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(this.Database.GetConnectionString()))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(this.Database.GetConnectionString(), conn))
                    {
                        cmd.CommandText = "select * from ClientsView";
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public Task<int> InsertAccount(Account entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertCard(Card entity)
        {
            Task<int> result = null;
            try
            {
                var execute = Database.ExecuteSqlRawAsync("[dbo].[sp_InsertCard] @identi,@NameCard,@TyperCard,@TypeCoin,@OpenDate,@ExpireDate,@MaxAmountD,@MaxAmountC,@BaseAmountD,@BaseAmountC,@FechaPago ,@FechaCorte,@NCard", new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@identi",
                            SqlDbType =  System.Data.SqlDbType.NVarChar,
                            Size= 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.identi
                        },
                        new SqlParameter() {
                            ParameterName = "@NameCard",
                            SqlDbType =  System.Data.SqlDbType.NVarChar,
                            Size = 10,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.NameCard
                        },
                        new SqlParameter() {
                            ParameterName = "@TyperCard",
                            SqlDbType =  System.Data.SqlDbType.NVarChar,
                            Size = 15,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.TypeCard
                        },
                        new SqlParameter() {
                            ParameterName = "@TypeCoin",
                            SqlDbType =  System.Data.SqlDbType.NVarChar,
                            Size = 15,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.TypeCoin
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@OpenDate",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.OpenDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@ExpireDate",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.ExpiredDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@MaxAmountD",
                            SqlDbType =  System.Data.SqlDbType.Money,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.MaxAmountDolar
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@MaxAmountC",
                            SqlDbType =  System.Data.SqlDbType.Money,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.MaxAmountCordoba
                        },
                         new SqlParameter()
                        {
                            ParameterName = "@BaseAmountD",
                            SqlDbType =  System.Data.SqlDbType.Money,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.AmounBaseDolar
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@BaseAmountC",
                            SqlDbType =  System.Data.SqlDbType.Money,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.AmountBaseCordoba
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@FechaPago",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.FechaPago
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@FechaCorte",
                            SqlDbType =  System.Data.SqlDbType.Date,                          
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.FechaCorte
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@Ncard",
                            SqlDbType= System.Data.SqlDbType.NVarChar,
                            Size = 22,
                            Value = entity.NumerCard
                        }

                     });
                await execute;
                result = execute;
            }
            catch (Exception ex)
            {

            }
            return result.Result;
        }

        public async Task<int> InsertClient(Client entity)
        {
            Task<int> result = null;
            try
            {
                var execute = Database.ExecuteSqlRawAsync("[dbo].[sp_InsertClient] @names,@lastnames,@Direction,@phone,@Birth,@Nation,@dni", new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@names",
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
                            ParameterName = "@Direction",
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
                            ParameterName = "@Birth",
                            SqlDbType =  System.Data.SqlDbType.Date,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.BirthDate
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@Nation",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Nacionality
                        },
                        new SqlParameter()
                        {
                            ParameterName = "@dni",
                            SqlDbType =  System.Data.SqlDbType.VarChar,
                            Size = 20,
                            Direction = System.Data.ParameterDirection.Input,
                            Value = entity.Identification
                        }
                     });
                await execute;
                result = execute;
            }
            catch (Exception ex)
            {

            }
            return result.Result;
        }

        public Task<bool> UpdateAccount(Account entity, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCard(Card entity, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateClient(Client entity, int id)
        {
            Task<int> query = null;
            try
            {
                query = Database.ExecuteSqlRawAsync("[dbo].[sp_UpdateClient] @Id_Client,@Direction,@Phone,@Nationality,@Identification", new SqlParameter[]
                {
                    new SqlParameter()
                    {
                    ParameterName = "@Id_Client",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = id
                    },
                    new SqlParameter()
                    {
                    ParameterName = "@Direction",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50,
                    Value = entity.Direction

                    },
                    new SqlParameter()
                    {
                    ParameterName = "@Phone",
                    SqlDbType= System.Data.SqlDbType.NVarChar,
                    Size = 15,
                    Value = entity.Phone
                    },
                    new SqlParameter()
                    {
                    ParameterName = "@Nationality",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 00,
                    Value = entity.Nacionality

                    },
                    new SqlParameter()
                    {
                    ParameterName = "@Identification",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20,
                    Value = entity.Identification

                    }
                });
                await query;
            }
            catch (Exception ex)
            {

            }

            return query.IsCompleted;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount)
                    .HasName("PK__Accounts__0EB75CDB6C31A0B5");

                entity.Property(e => e.IdAccount).HasColumnName("Id_Account");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Description_");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.IdHideline).HasColumnName("id_Hideline");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Status_");

                entity.Property(e => e.TypeAccount)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Type_Account");

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Type_Coin");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdClient)
                    .HasConstraintName("FK__Accounts__id_Cli__5EBF139D");

                entity.HasOne(d => d.IdHidelineNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdHideline)
                    .HasConstraintName("FK__Accounts__id_Hid__5FB337D6");
            });

            modelBuilder.Entity<AccountDetail>(entity =>
            {
                entity.HasKey(e => e.IdAccountDetails)
                    .HasName("PK__AccountD__DF9627CD3D4B0327");

                entity.Property(e => e.IdAccountDetails).HasColumnName("Id_AccountDetails");

                entity.Property(e => e.Deposito).HasColumnType("money");

                entity.Property(e => e.IdAccount).HasColumnName("id_Account");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.Retiro).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.IdAccountNavigation)
                    .WithMany(p => p.AccountDetails)
                    .HasForeignKey(d => d.IdAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccountDe__id_Ac__60A75C0F");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.AccountDetails)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccountDe__id_Em__619B8048");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .HasName("PK__Cards__A7B8DC5692306856");

                entity.Property(e => e.IdCard).HasColumnName("Id_Card");

                entity.Property(e => e.NumerCard)
                    .IsRequired()                  
                    .HasColumnName("NumerCard");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.FechaCorte).HasColumnType("date");

                entity.Property(e => e.FechaPago).HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.MaxAmountCordoba).HasColumnType("money");

                entity.Property(e => e.AmountBaseCordoba).HasColumnType("money");

                entity.Property(e => e.MaxAmountDolar).HasColumnType("money");

                entity.Property(e => e.AmounBaseDolar).HasColumnType("money");

                entity.Property(e => e.NameCard)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.TypeCard)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cards__id_Client__5CD6CB2B");
            });

            modelBuilder.Entity<CardDetail>(entity =>
            {
                entity.HasKey(e => e.IdCardDetails)
                    .HasName("PK__CardDeta__8B8DDC0267169511");

                entity.Property(e => e.IdCardDetails).HasColumnName("Id_CardDetails");

                entity.Property(e => e.Deposito).HasColumnType("money");

                entity.Property(e => e.IdCard).HasColumnName("id_Card");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.Retiro).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.HasOne(d => d.IdCardNavigation)
                    .WithMany(p => p.CardDetails)
                    .HasForeignKey(d => d.IdCard)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardDetai__id_Ca__5DCAEF64");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CardDetails)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardDetai__id_Em__628FA481");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__Clients__668DFF3F1B66E1BA");

                entity.Property(e => e.IdClient).HasColumnName("Id_Client");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastNames)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nacionality)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__938D4B1019BE6262");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_Employee");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("DNI");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Roll)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Status_");

                entity.Property(e => e.Surnames)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Hideline>(entity =>
            {
                entity.HasKey(e => e.IdHideline)
                    .HasName("PK__Hideline__49C5CC97EE226FA4");

                entity.ToTable("Hideline");

                entity.Property(e => e.IdHideline).HasColumnName("Id_Hideline");

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Name_");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
