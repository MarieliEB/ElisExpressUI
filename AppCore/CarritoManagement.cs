using DataAccess.Crud;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
    public class CarritoManagement
    {
        private CarritoCrudFactory crud;

        public CarritoManagement()
        {
            crud = new CarritoCrudFactory();
        }

        public void Create(Carrito obj)
        {
            crud.Create(obj);
        }

        public List<Carrito> RetriveAll()
        {
            return crud.RetrieveAll<Carrito>();
        }

        public Carrito RetriveById(Carrito obj)
        {
            return crud.Retrieve<Carrito>(obj);
        }

        public void Update(Carrito obj)
        {
            crud.Update(obj);
        }

        public void Delete(Carrito obj)
        {
            crud.Delete(obj);
        }
    }
}

