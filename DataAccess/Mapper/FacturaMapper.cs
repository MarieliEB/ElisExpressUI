using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Dao;
using DataAccessLayer.Mapper;
using Entities;

namespace DataAccess.Mapper
{
    public class FacturaMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_ID_CARRITO = "ID_CARRITO";
        private const string DB_COL_NOMBRE_USUARIO = "NOMBRE_USUARIO";
        private const string DB_COL_CORREO_USUARIO = "CORREO_USUARIO";
        private const string DB_COL_TELEFONO_USUARIO = "TELEFONO_USUARIO";
        private const string DB_COL_METODO_PAGO = "METODO_PAGO";
        private const string DB_COL_TOTAL_PAGO = "TOTAL_PAGO";

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var factura = new Factura
            {
                Id = GetIntValue(row, DB_COL_ID),
                IdCarrito = GetIntValue(row, DB_COL_ID_CARRITO),
                NombreUsuario = GetStringValue(row, DB_COL_NOMBRE_USUARIO),
                CorreoUsuario = GetStringValue(row, DB_COL_CORREO_USUARIO),
                TelefonoUsuario = GetIntValue(row, DB_COL_TELEFONO_USUARIO),
                MetodoPago = GetStringValue(row, DB_COL_METODO_PAGO),
                TotalPago = GetDoubleValue(row, DB_COL_TOTAL_PAGO)
            };
            return factura;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var factura = BuildObject(row);
                lstResults.Add(factura);
            }

            return lstResults;
        }

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_FACTURA_PR" };

            var f = (Factura)entity;
            operation.AddIntParam(DB_COL_ID_CARRITO, f.IdCarrito);
            operation.AddVarcharParam(DB_COL_NOMBRE_USUARIO, f.NombreUsuario);
            operation.AddVarcharParam(DB_COL_CORREO_USUARIO, f.CorreoUsuario);
            operation.AddIntParam(DB_COL_TELEFONO_USUARIO, f.TelefonoUsuario);
            operation.AddVarcharParam(DB_COL_METODO_PAGO, f.MetodoPago);
            operation.AddDoubleParam(DB_COL_TOTAL_PAGO, f.TotalPago);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_FACTURA_PR" };

            var f = (Factura)entity;
            operation.AddIntParam(DB_COL_ID, f.Id);
            return operation;
        }
        
        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_FACTURA_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_FACTURA_PR" };

            var f = (Factura)entity;
            operation.AddIntParam(DB_COL_ID, f.Id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_FACTURA_PR" };

            var f = (Factura)entity;
            operation.AddIntParam(DB_COL_ID, f.Id);
            operation.AddIntParam(DB_COL_ID_CARRITO, f.IdCarrito);
            operation.AddVarcharParam(DB_COL_NOMBRE_USUARIO, f.NombreUsuario);
            operation.AddVarcharParam(DB_COL_CORREO_USUARIO, f.CorreoUsuario);
            operation.AddIntParam(DB_COL_TELEFONO_USUARIO, f.TelefonoUsuario);
            operation.AddVarcharParam(DB_COL_METODO_PAGO, f.MetodoPago);
            operation.AddDoubleParam(DB_COL_TOTAL_PAGO, f.TotalPago);

            return operation;
        }
    }
}
