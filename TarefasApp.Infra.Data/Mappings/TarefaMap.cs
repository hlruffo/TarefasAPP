using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Infra.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");
            builder.HasKey(t => t.Id);
            builder.Property(t=> t.Id).HasColumnName("ID");
            builder.Property(t=> t.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
            builder.Property(t=> t.DataHora).HasColumnName("DATAHORA").IsRequired();
            builder.Property(t => t.Descricao).HasColumnName("DESCRICAO").HasMaxLength(250).IsRequired();
            builder.Property(t => t.Prioridade).HasColumnName("PRIORIDADE").IsRequired();
            builder.Property(t => t.CategoriaId).HasColumnName("CATEGORIAID").IsRequired();
            //mapeando o relacionamento
            builder.HasOne(t => t.Categoria) //tarefa tem 1 categoria
                .WithMany(c => c.Tarefas)//categoria tem muitas tarefas
                .HasForeignKey(t => t.CategoriaId);//chave estrangeira
        }
    }
}
