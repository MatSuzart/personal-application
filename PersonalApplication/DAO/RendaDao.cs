using PersonalApplication.Models;
using System.Linq;

namespace PersonalApplication.DAO
{
    public class RendaDao
    {
        private ModelContext context;

        public RendaDao()
        {
            this.context = new ModelContext();
        }
        public void Adiciona(Renda renda)
        {
            context.Rendas.Add(renda);
            context.SaveChanges();
        }

        /*public IList<Renda> BuscaPorNomeValorFixoValorVariavelValorOutros(string nome,double valorFixo,double valorVariavel,double valorOutros)
        {
            var busca = from v in contexto.Renda
                        select v;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(v => v.Nome == nome);
            }

            if (ValorFixo != 0.0)
            {
                busca = busca.Where(v => v.ValorFixo == valorFixo);
            }

            if (ValorVariavel != 0.0)
            {
                busca = busca.Where(v => v.ValorVariavel == valorVariavel);
            }

            if (ValorOutros != 0.0)
            {
                busca = busca.Where(v => v.ValorOutros == valorOutros);
            }

            return busca.ToList();
        }*/
        public Renda BuscaPorId(int id)
        {
            return context.Rendas.FirstOrDefault(r => r.ID == id);
        }

        public void Remove(Renda renda)
        {
            context.Rendas.Remove(renda);
            context.SaveChanges();
        }
        public void Atualiza(Renda renda)
        {
            context.SaveChanges();
        }
    }
}


