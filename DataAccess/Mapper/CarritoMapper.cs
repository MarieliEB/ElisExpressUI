using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Dao;
using DataAccessLayer.Mapper;
using Entities;

namespace DataAccess.Mapper
{
    public class CarritoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_ID_PRODUCTO = "ID_PRODUCTO";
        private const string DB_COL_CANTIDAD = "CANTIDAD";


        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var carrito = new Carrito
            {
                Id = GetIntValue(row, DB_COL_ID),
                IdProducto = GetIntValue(row, DB_COL_ID_PRODUCTO),
                Cantidad = GetIntValue(row, DB_COL_CANTIDAD)
            };
            return carrito;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var carrito = BuildObject(row);
                lstResults.Add(carrito);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CARRITO_PR" };

            var c = (Carrito)entity;
            operation.AddIntParam(DB_COL_ID_PRODUCTO, c.IdProducto);
            operation.AddIntParam(DB_COL_CANTIDAD, c.Cantidad);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CARRITO_PR" };

            var c = (Carrito)entity;
            operation.AddIntParam(DB_COL_ID, c.Id);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CARRITO_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CARRITO_PR" };

            var c = (Carrito)entity;
            operation.AddIntParam(DB_COL_ID, c.Id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CARRITO_PR" };

            var c = (Carrito)entity;
            operation.AddIntParam(DB_COL_ID, c.Id);
            operation.AddIntParam(DB_COL_ID_PRODUCTO, c.IdProducto);
            operation.AddIntParam(DB_COL_CANTIDAD, c.Cantidad);

            return operation;
        }
    }
}
