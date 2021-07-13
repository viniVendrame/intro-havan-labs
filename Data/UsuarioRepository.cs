using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepository
    {
        // CREATE

        public void Create(Usuario model)
        {
            using (var context = new HavanLabsContext())
            {
                context.Usuarios.Add(model);
                context.SaveChanges();
            }
        }

        // READALL

        public List<Usuario> ReadAll()
        {
            using (var context = new HavanLabsContext())
            {
               return context.Usuarios.ToList();
            }
        }

        // READBYID

        public Usuario ReadById(int id)
        {
            using (var context = new HavanLabsContext())
            {
               return context.Usuarios.Find(id);
            }
        }

        // UPDATE

        public void Update(Usuario model)
        {
            using (var context = new HavanLabsContext())
            {
                context.Entry(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        // DELETE

        public void Delete(int id)
        {
            using (var context = new HavanLabsContext())
            {
                Usuario model = context.Usuarios.Find(id);
                context.Usuarios.Remove(model);
                context.SaveChanges();
            }
        }
    }
}
