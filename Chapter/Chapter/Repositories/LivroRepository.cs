using Chapter.Contexts;
using Chapter.Interfaces;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ChapterContext _chapterContext;
        public LivroRepository(ChapterContext context) {
            _chapterContext = context;
        }

        public List<Livro> Ler()
        {
            return _chapterContext.Livros.ToList();
        }

     }
}
