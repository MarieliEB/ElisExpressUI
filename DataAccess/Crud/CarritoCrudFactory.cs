using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Dao;
using DataAccess.Mapper;
using DataAccessLayer.Crud;
using Entities;

namespace DataAccess.Crud
{
    public class CarritoCrudFactory : CrudFactory
    {
        CarritoMapper mapper;

        public CarritoCrudFactory() : base()
        {
            mapper = new CarritoMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var c = (Carrito)entity;
            var sqlOperation = mapper.GetCreateStatement(c);
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
            var lstCarrito = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCarrito.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCarrito;
        }

        public override void Update(BaseEntity entity)
        {
            var c = (Carrito)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(c));
        }

        public override void Delete(BaseEntity entity)
        {
            var c = (Carrito)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(c));
        }
    }
}
