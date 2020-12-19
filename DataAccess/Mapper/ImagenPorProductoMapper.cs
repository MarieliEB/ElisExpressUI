using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Dao;
using DataAccessLayer.Mapper;
using Entities;

namespace DataAccess.Mapper
{
    public class ImagenPorProductoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_VALOR = "VALOR";
        private const string DB_COL_ID_PRODUCTO = "ID_PRODUCTO";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var ipp = new ImagenPorProducto
            {
                Id = GetIntValue(row, DB_COL_ID),
                Valor = GetStringValue(row,DB_COL_VALOR),
                IdProducto = GetIntValue(row, DB_COL_ID_PRODUCTO)
            };
            return ipp;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var ipp = BuildObject(row);
                lstResults.Add(ipp);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_IMAGENES_POR_PRODUCTO_PR" };

            var ipp = (ImagenPorProducto)entity;
            operation.AddVarcharParam(DB_COL_VALOR, ipp.Valor);
            operation.AddIntParam(DB_COL_ID_PRODUCTO, ipp.IdProducto);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_IMAGENES_POR_PRODUCTO_PR" };

            var ipp = (ImagenPorProducto)entity;
            operation.AddIntParam(DB_COL_ID, ipp.Id);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_IMAGENES_POR_PRODUCTO_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_IMAGENES_POR_PRODUCTO_PR" };

            var ipp = (ImagenPorProducto)entity;
            operation.AddIntParam(DB_COL_ID, ipp.Id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_IMAGENES_POR_PRODUCTO_PR" };

            var ipp = (ImagenPorProducto)entity;
            operation.AddIntParam(DB_COL_ID, ipp.Id);
            operation.AddVarcharParam(DB_COL_VALOR, ipp.Valor);
            operation.AddIntParam(DB_COL_ID_PRODUCTO, ipp.IdProducto);

            return operation;
        }

    }
}
