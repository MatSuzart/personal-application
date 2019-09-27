using PersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalApplication.DAO
{
    public class DespesaDao
    {

        public void Adiciona(Despesa despesa)
        {
            using (var context = new ModelContext())
            {
                context.Despesas.Add(despesa);
                context.SaveChanges();
            }
        }

        public IList<Despesa> Lista()
        {
            using (var contexto = new ModelContext())
            {
                return contexto.Despesas.ToList();
            }
        }


        public Despesa BuscaPorId(int id)
        {
            using (var contexto = new ModelContext())
            {
                return contexto.Despesas.Find(id);
            }
        }
        
        public void Atualiza(Despesa despesa)
        {
            using (var contexto = new ModelContext())
            {
                contexto.Entry(despesa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}
