using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Atividade01.RazorPages.Data;
using Atividade01.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade01.RazorPages.Pages.Categorias
{
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        private readonly ILogger<Index> _logger;

        public List<CategoriaModel> Categorias { get; set; } = new();
        public List<ProdutoModel> Produtos { get; set; } = new();

        public Index(ILogger<Index> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> OnGetCategoriasAsync() 
        {
            var produto = new ProdutoModel {
                Nome = "Macarrão",
                Categoria = null,
                Descricao = "Descricao",
            };
            Produtos.Add(produto);
            var categoria = new CategoriaModel {
                CategoriaID = 1,
                Descricao = "Categoria de teste",
                Nome = "Categoria com nome teste",
                Produtos = Produtos

            };
            Categorias.Add(categoria);
            // Categorias = await _context.Categorias!.ToListAsync();

            Console.WriteLine(Categorias);

            return Page();
        }
    }
}