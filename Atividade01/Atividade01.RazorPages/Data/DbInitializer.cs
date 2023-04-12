using Atividade01.RazorPages.Models;

namespace Atividade01.RazorPages.Data {

    public class DbInitializer
    {
        public static void Initialize(AppDbContext context) {
            if (!context.Atendimentos!.Any())
            {
                var atendimentos = new AtendimentoModel[] {
                    new AtendimentoModel {
                       MesaAtendida = new MesaModel {
                        Ocupada = false,
                        HoraAbertura = null,
                        NumeroMesa = 8,
                       }
                    },

                    new AtendimentoModel {
                        GarconResponsavel = new GarcomModel {
                            Nome = "José",
                            Sobrenome = "Silva",
                            NumeroIdentificacao = 1,
                            NumeroTelefone = "3848-2453",
                        }
                    } 
                };
                context.AddRange(atendimentos);
            };
        
            if (!context.Categorias!.Any())
            {
                var categorias = new CategoriaModel[] {
                    new CategoriaModel {
                        Nome = "Entrada",
                        Descricao = "Refeicao leve",
                    }
                };
                context.AddRange(categorias);
            };

            if (!context.GarcomModel!.Any())
            {
                var atendimentos = new GarcomModel[] {
                    new GarcomModel {
                        Nome = "José",
                        Sobrenome = "Silva",
                        NumeroIdentificacao = 1,
                        NumeroTelefone = "3848-2453",
                    }
                };
                context.AddRange(garcons);
            };

            if (!context.MesaModel!.Any())
            {
                var atendimentos = new MesaModel[] {
                        new MesaModel {
                            NumeroMesa = 3,
                            Ocupada = true,

                         }
                 };
                context.AddRange(mesas);
            }

            if (!context.Produtos!.Any())
            {
                var atendimentos = new ProdutoModel[] {
                    new ProdutoModel {
                         Nome ="",
                         Descricao ="",
                         Preco =,

                    }
                 };
                context.AddRange(produtos);
            }
        }

        context.SaveChanges()
    }
}

