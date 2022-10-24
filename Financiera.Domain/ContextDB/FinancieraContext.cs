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



        public async Task<int> InsertClient(Client entity)
        {
            SqlParameter[]? param = null;
            int result = 0;
            using (var transaction = Database.BeginTransaction())
            {
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
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }


            return result;
        }


        public Task<bool> UpdateClient(Client entity)
        {
            throw new NotImplementedException();
        }



        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=KEVINOR\\SQLEXPRESS;Database=Financiera;user=sa;password=12345678;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAccount)
                    .HasName("PK__Accounts__ADA95621BC3DBFF9");

                entity.Property(e => e.IdAccount).HasColumnName("id_Account");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Description_");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TypeAccount)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Type_Account");

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Type_Coin");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accounts__id_Cli__38996AB5");
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .HasName("PK__Cards__40F8F1F8F1AC626D");

                entity.Property(e => e.IdCard).HasColumnName("id_Card");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Description_");

                entity.Property(e => e.ExpireDate).HasColumnType("date");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.MinAmount).HasColumnType("money");

                entity.Property(e => e.NameCard)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.TypeCard)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TypeCoin)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Cards)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cards__id_Client__3B75D760");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__Clients__F08F1F7641080BA1");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Birth_date");

                entity.Property(e => e.Direction).HasMaxLength(50);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastNames)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Last_Names");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nationality)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Photo).HasColumnType("image");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__0A0622860B609263");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(20);

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
