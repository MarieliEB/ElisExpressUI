using DataAccess.Crud;
using Entities;
using System;
using System.Collections.Generic;

namespace AppCore
{
    public class ImagenPorProductoManagement
    {
        private ImagenPorProductoCrudFactory crud;

        public ImagenPorProductoManagement()
        {
            crud = new ImagenPorProductoCrudFactory();
        }

        public void Create(ImagenPorProducto ent)
        {
            crud.Create(ent);
        }

        public List<ImagenPorProducto> RetrieveAll()
        {
            return crud.RetrieveAll<ImagenPorProducto>();
        }

        public ImagenPorProducto RetrieveById(ImagenPorProducto ent)
        {
            return crud.Retrieve<ImagenPorProducto>(ent);
        }

        public void Update(ImagenPorProducto ent)
        {
            crud.Update(ent);

        }

        public void Delete(ImagenPorProducto ent)
        {
            crud.Delete(ent);
        }
    }
}
