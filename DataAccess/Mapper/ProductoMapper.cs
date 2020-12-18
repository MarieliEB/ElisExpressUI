using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Dao;
using DataAccessLayer.Mapper;
using Entities;

namespace DataAccess.Mapper
{
    public class ProductoMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_DESCRIPCION = "DESCRIPCION";
        private const string DB_COL_CANTIDAD = "CANTIDAD";
        private const string DB_COL_PRECIO = "PRECIO";
        private const string DB_COL_CATEGORIA = "CATEGORIA";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var producto = new Producto
            {
                Id = GetIntValue(row, DB_COL_ID),
                Nombre = GetStringValue(row, DB_COL_NOMBRE),
                Descripcion = GetStringValue(row, DB_COL_DESCRIPCION),
                Cantidad = GetIntValue(row, DB_COL_CANTIDAD),
                Precio =GetDoubleValue(row, DB_COL_PRECIO),
                Categoria = GetIntValue(row, DB_COL_CATEGORIA)
            };
            return producto;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var producto = BuildObject(row);
                lstResults.Add(producto);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_PRODUCTO_PR" };

            var p = (Producto)entity;
            operation.AddVarcharParam(DB_COL_NOMBRE, p.Nombre);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, p.Descripcion);
            operation.AddIntParam(DB_COL_CANTIDAD, p.Cantidad);
            operation.AddDoubleParam(DB_COL_PRECIO, p.Precio);
            operation.AddIntParam(DB_COL_CATEGORIA, p.Categoria);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_PRODUCTO_PR" };

            var p = (Producto)entity;
            operation.AddIntParam(DB_COL_ID, p.Id);
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_PRODUCTO_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_PRODUCTO_PR" };

            var p = (Producto)entity;
            operation.AddIntParam(DB_COL_ID, p.Id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_PRODUCTO_PR" };

            var p = (Producto)entity;
            operation.AddIntParam(DB_COL_ID, p.Id);
            operation.AddVarcharParam(DB_COL_NOMBRE, p.Nombre);
            operation.AddVarcharParam(DB_COL_DESCRIPCION, p.Descripcion);
            operation.AddIntParam(DB_COL_CANTIDAD, p.Cantidad);
            operation.AddDoubleParam(DB_COL_PRECIO, p.Precio);
            operation.AddIntParam(DB_COL_CATEGORIA, p.Categoria);

            return operation;
        }
    }
}
