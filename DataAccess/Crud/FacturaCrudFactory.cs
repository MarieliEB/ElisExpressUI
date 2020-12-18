using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Dao;
using DataAccess.Mapper;
using DataAccessLayer.Crud;
using Entities;

namespace DataAccess.Crud
{
    public class FacturaCrudFactory : CrudFactory
    {
        FacturaMapper mapper;

        public FacturaCrudFactory() : base()
        {
            mapper = new FacturaMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var f = (Factura)entity;
            var sqlOperation = mapper.GetCreateStatement(f);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstFactura = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstFactura.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstFactura;
        }

        public override void Update(BaseEntity entity)
        {
            var f = (Factura)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(f));
        }

        public override void Delete(BaseEntity entity)
        {
            var f = (Factura)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(f));
        }
    }
}
