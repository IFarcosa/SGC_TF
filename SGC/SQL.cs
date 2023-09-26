using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace SGC
{

    class SQL
    {

      //  public SqlConnection CONEXION = new SqlConnection("Data Source=172.16.42.37;Initial Catalog=SOFTLAND;User=sa;Password=Farcosa1.");
        public SqlConnection CONEXION = new SqlConnection("Data Source=172.16.42.37;Initial Catalog=PRUEBA;User=sa;Password=Farcosa1.");

        public DataTable DATAADAPTER(String QUERY)
        {

            SqlDataAdapter ADAPTER = new SqlDataAdapter(QUERY, CONEXION);
            DataTable DTABLE1 = new DataTable();
            ADAPTER.Fill(DTABLE1);

            return DTABLE1;

        }

        public String SCALAR(String QUERY)
        {

            CONEXION.Open();
            SqlCommand COMMAND = new SqlCommand(QUERY, CONEXION);
            String RESULTADO   = COMMAND.ExecuteScalar().ToString();
            CONEXION.Close();

            return RESULTADO;
            
        }

        public int NONQUERY(String QUERY)
        {

            CONEXION.Open();
            SqlCommand COMMAND = new SqlCommand(QUERY, CONEXION);
            int RESULTADO = COMMAND.ExecuteNonQuery();
            CONEXION.Close();

            return RESULTADO;

        }

        public DataTable GPRINCIPAL ()
        {
            // ALMACEN
            try
            {               
                String QUERY01 = String.Format(" SELECT	PED.PEDIDO, FECHA_BOD,  CONVERT(time, FECHA_BOD) AS HORA_BOD, " +
                                                      " CONVERT(date, PED.FECHA_PEDIDO) AS FECHA_PEDIDO, " +
                                                      " CASE WHEN PED.ESTADO = 'A' THEN 'Aprobado'  ELSE CASE WHEN PED.ESTADO = 'B' THEN 'Backorder' ELSE " +
                                                      " CASE WHEN PED.ESTADO = 'C' THEN 'Cancelado' ELSE CASE WHEN PED.ESTADO = 'F' THEN 'Facturado' ELSE " +
                                                      " CASE WHEN PED.ESTADO = 'N' THEN 'Normal' ELSE 'No definido' END END END END END AS ESTADO, " +
                                                      " PED.CONFIRMADO, " +
                                                      " PED.CLIENTE, " +
                                                      " PED.NOMBRE_CLIENTE, " +
                                                      " EPD.NOMBRE_PILA AS USUARIO_BOD," +
                                                      " ZA.NOMBRE AS ZONA " +                                                 
                                                " FROM  FARCOSA.PEDIDO AS PED " +
                                                      " LEFT JOIN FARCOSA.ZONA AS ZA ON PED.ZONA = ZA.ZONA " +
                                                      " LEFT JOIN FARCOSA.EMPLEADO AS EPD ON PED.USUARIO_BOD = EPD.EMPLEADO" +
                                                " WHERE PED.ESTADO = 'N' AND PED.CONFIRMADO IS NOT NULL " +
                                                " ORDER BY PED.PEDIDO, PED.FECHA_PEDIDO ASC " );

                return DATAADAPTER(QUERY01);
            }

            catch (Exception)
            {
                throw;
            }

        }

        public DataTable GPRINCIPAL2()
        {
            // CUENTAS POR COBRAR
            try
            {
                String QUERY01 = String.Format(" SELECT	PED.PEDIDO, FECHA_BOD,  CONVERT(time, FECHA_BOD) AS HORA_BOD, " +
                                                      " CONVERT(date, PED.FECHA_PEDIDO) AS FECHA_PEDIDO, " +
                                                      " CASE WHEN PED.ESTADO = 'A' THEN 'Aprobado'  ELSE CASE WHEN PED.ESTADO = 'B' THEN 'Backorder' ELSE " +
                                                      " CASE WHEN PED.ESTADO = 'C' THEN 'Cancelado' ELSE CASE WHEN PED.ESTADO = 'F' THEN 'Facturado' ELSE " +
                                                      " CASE WHEN PED.ESTADO = 'N' THEN 'Normal' ELSE 'No definido' END END END END END AS ESTADO, " +
                                                      " PED.CONFIRMADO, " +
                                                      " PED.CLIENTE, " +
                                                      " PED.NOMBRE_CLIENTE, " +
                                                      " PED.USUARIO_BOD," +
                                                      " CASE WHEN PED.MONEDA_PEDIDO = 'L' THEN 'Córdoba' ELSE CASE WHEN PED.MONEDA_PEDIDO = 'D' THEN 'Dólar' ELSE 'No definido' END END AS MONEDA," +
                                                      " CONVERT(DECIMAL(28,2), PED.TOTAL_A_FACTURAR) AS TOTAL, " +
                                                      " V.NOMBRE AS VENDEDOR" +
                                                " FROM  FARCOSA.PEDIDO AS PED " +
                                                " INNER JOIN FARCOSA.VENDEDOR V ON PED.VENDEDOR=V.VENDEDOR"+
                                                " WHERE PED.ESTADO = 'N' AND PED.CONFIRMADO = 'N' " +
                                                " ORDER BY PED.PEDIDO, PED.FECHA_PEDIDO ASC ");

                return DATAADAPTER(QUERY01);
            }

            catch (Exception)
            {
                throw;
            }

        }

    }

}

