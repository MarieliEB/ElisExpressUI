using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Dao;
using DataAccess.Mapper;
using DataAccessLayer.Crud;
using Entities;

namespace DataAccess.Crud
{
    public class ImagenPorProductoCrudFactory : CrudFactory
    {
        ImagenPorProductoMapper mapper;

        public ImagenPorProductoCrudFactory() : base()
        {
            mapper = new ImagenPorProductoMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var ipp = (ImagenPorProducto)entity;
            var sqlOperation = mapper.GetCreateStatement(ipp);
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
            var lstImagProd = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstImagProd.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstImagProd;
        }

        public override void Update(BaseEntity entity)
        {
            var ipp = (ImagenPorProducto)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(ipp));
        }

        public override void Delete(BaseEntity entity)
        {
            var ipp = (ImagenPorProducto)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(ipp));
        }
    }
}
