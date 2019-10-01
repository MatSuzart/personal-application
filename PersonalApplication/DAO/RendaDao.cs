using PersonalApplication.Models;
using System.Collections.Generic;
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

        public IList<Renda> Lista()
        {
            using (var contexto = new ModelContext())
            {
                return contexto.Rendas.ToList();
            }
        }

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


