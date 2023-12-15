using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Infra.Data.Contexts
{
    /// <summary>
    /// classe para mapeamento da conexão do banco de dados
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// metódo para configurar o BD do projeto
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName:"BDTarefasApp" );
        }

        //DbSet -> fornece os métodos CRUD para cada entidade
        public DbSet<Tarefa>? Tarefa { get; set; }
    }
}
