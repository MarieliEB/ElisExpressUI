using DataAccess.Crud;
using Entities;
using System;
using System.Collections.Generic;

namespace AppCore
{
    public class ProductoManagement
    {
        private ProductoCrudFactory crud;

        public ProductoManagement()
        {
            crud = new ProductoCrudFactory();
        }

        public void Create(Producto prod)
        {
            crud.Create(prod);
        }

        public List<Producto> RetrieveAll()
        {
            return crud.RetrieveAll<Producto>();
        }

        public Producto RetrieveById(Producto ent)
        {
            return crud.Retrieve<Producto>(ent);
        }

        public void Update(Producto ent)
        {
            crud.Update(ent);

        }

        public void Delete(Producto ent)
        {
            crud.Delete(ent);
        }
    }
}
