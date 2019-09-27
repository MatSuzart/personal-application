using PersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalApplication.DAO
{
    public class UsuarioDao
    {
        private ModelContext context;

        public UsuarioDao()
        {
           this.context = new ModelContext();
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return context.Usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Remove(Usuario usuario)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
        public void Atualiza(Usuario usuario)
        {
            context.SaveChanges();
        }
        public Usuario Busca(string login, string senha)
        {
            using (var context = new ModelContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
    }
}