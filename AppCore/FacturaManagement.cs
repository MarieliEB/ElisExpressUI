using DataAccess.Crud;
using Entities;
using System;
using System.Collections.Generic;

namespace AppCore
{
    public class FacturaManagement
    {
        private FacturaCrudFactory crud;

        public FacturaManagement()
        {
            crud = new FacturaCrudFactory();
        }

        public void Create(Factura factura)
        {
            crud.Create(factura);
        }

        public List<Factura> RetrieveAll()
        {
            return crud.RetrieveAll<Factura>();
        }

        public Factura RetrieveById(Factura ent)
        {
            return crud.Retrieve<Factura>(ent);
        }

        public void Update(Factura ent)
        {
            crud.Update(ent);

        }

        public void Delete(Factura ent)
        {
            crud.Delete(ent);
        }
    }
}
