using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;

namespace ArchivosPlanosWeb.Services
{
    public class MetodosGlbRepository
    {

        string ConnectString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

        public DataSet Ds = new DataSet();
        public DataSet Ds1 = new DataSet();
        public DataSet Ds2 = new DataSet();
        public DataSet Ds3 = new DataSet();
        public DataSet Ds4 = new DataSet();
        public DataRow oDataRow;
        public DataRow oDataRow1;
        public DataRow oDataRow2;
        public DataRow oDataRow3;
        public DataRow oDataRow4;

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

        /// <summary>
        /// Lee archivo .ini
        /// </summary>
        /// <param name="Ruta"></param>
        /// <param name="Seccion"></param>
        /// <param name="Variable"></param>
        /// <returns></returns>
        public string LeeINI(string Ruta, string Seccion, string Variable)
        {
            string Res;
            try
            {

                StringBuilder Resultado;
                Resultado = new StringBuilder((char)0, 255);

                uint Caracteres;
                Caracteres = GetPrivateProfileString(Seccion, Variable, "", Resultado, 255, Ruta);

                Res = Left(Convert.ToString(Resultado), Convert.ToInt32(Caracteres));
            }
            catch (Exception ex)
            {
                Res = "";
            }
            return Res;
        }

        /// <summary>
        /// Devuelve una cadena que contiene un número especificado de caracteres a partir del lado izquierdo de una cadena.
        /// </summary>
        /// <param name="param"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }

        public string IIf(bool Expression, string TruePart, string FalsePart)
        {
            string ReturnValue = Expression == true ? TruePart : FalsePart;

            return ReturnValue;
        }

        public Boolean IsNumeric(string valor)
        {
            return int.TryParse(valor, out int result);
        }

        /// <summary>
        /// Convierte una cadena a un formato dd/MM/yyyy 
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public string Fecha(string fecha)
        {
            string _fecha = fecha.Substring(6, 2) + "/" + fecha.Substring(4, 2) + "/" + fecha.Substring(0, 4) + " " + fecha.Substring(8, 2) + ":" + fecha.Substring(10, 2) + ":" + fecha.Substring(12, 2);

            return _fecha;
        }

        /// <summary>
        /// MÉTODO 0 PARA EJECUTAR UN QUERY Y ADAPTARLO A UN DATASET ESPECIFICANDO LA COLUMNA
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public bool QueryDataSet(string Query, string Column)
        {
            reitentar:
            using (OracleConnection Connection = new OracleConnection(ConnectString))
            {
                if (Ds.Tables.Count != 0)
                    Ds.Clear();

                int iPosicionFilaActual = 0;
                bool _return = false;

                Connection.Open();
                OracleCommand Cmd = new OracleCommand(Query, Connection);
                Cmd.CommandType = System.Data.CommandType.Text;

                OracleDataAdapter Da = new OracleDataAdapter(Cmd);
                Da.Fill(Ds, Column);
                try
                {
                    if (Ds.Tables[Column].Rows.Count > 0)
                    {
                        oDataRow = Ds.Tables[Column].Rows[iPosicionFilaActual];
                        _return = true;
                    }
                    else
                        _return = false;
                }
                catch (Exception ex)
                {
                    _return = false;
                    goto reitentar;
                }

                finally
                {
                    Cmd.Dispose();
                    Connection.Close();
                }
                return _return;
            }
        }

        /// <summary>
        /// MÉTODO 1 PARA EJECUTAR UN QUERY Y ADAPTARLO A UN DATASET ESPECIFICANDO LA COLUMNA
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public bool QueryDataSet1(string Query, string Column)
        {
            reitentar:
            using (OracleConnection Connection = new OracleConnection(ConnectString))
            {
                if (Ds1.Tables.Count != 0)
                    Ds1.Clear();

                int iPosicionFilaActual = 0;
                bool _return = false;

                Connection.Open();
                OracleCommand Cmd = new OracleCommand(Query, Connection);
                Cmd.CommandType = System.Data.CommandType.Text;

                OracleDataAdapter Da = new OracleDataAdapter(Cmd);
                Da.Fill(Ds1, Column);
                try
                {
                    if (Ds1.Tables[Column].Rows.Count > 0)
                    {
                        oDataRow1 = Ds1.Tables[Column].Rows[iPosicionFilaActual];
                        _return = true;
                    }
                    else
                        _return = false;
                }
                catch (Exception ex)
                {
                    _return = false;
                    goto reitentar;
                }

                finally
                {
                    Cmd.Dispose();
                    Connection.Close();
                }
                return _return;
            }
        }

        /// <summary>
        /// MÉTODO 2 PARA EJECUTAR UN QUERY Y ADAPTARLO A UN DATASET ESPECIFICANDO LA COLUMNA
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public bool QueryDataSet2(string Query, string Column)
        {
            reitentar:
            using (OracleConnection Connection = new OracleConnection(ConnectString))
            {
                if (Ds2.Tables.Count != 0)
                    Ds2.Clear();

                int iPosicionFilaActual = 0;
                bool _return = false;

                Connection.Open();
                OracleCommand Cmd = new OracleCommand(Query, Connection);
                Cmd.CommandType = System.Data.CommandType.Text;

                OracleDataAdapter Da = new OracleDataAdapter(Cmd);
                Da.Fill(Ds2, Column);
                try
                {
                    if (Ds2.Tables[Column].Rows.Count > 0)
                    {
                        oDataRow2 = Ds2.Tables[Column].Rows[iPosicionFilaActual];
                        _return = true;
                    }
                    else
                        _return = false;
                }
                catch (Exception ex)
                {
                    _return = false;
                    goto reitentar;
                }
                finally
                {
                    Cmd.Dispose();
                    Connection.Close();
                }
                return _return;
            }
        }

        /// <summary>
        /// MÉTODO 3 PARA EJECUTAR UN QUERY Y ADAPTARLO A UN DATASET ESPECIFICANDO LA COLUMNA
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Column"></param>
        /// <returns></returns>
        public bool QueryDataSet3(string Query, string Column)
        {
            reitentar:
            using (OracleConnection Connection = new OracleConnection(ConnectString))
            {
                if (Ds3.Tables.Count != 0)
                    Ds3.Clear();

                bool _return = false;

                int iPosicionFilaActual = 0;

                Connection.Open();
                OracleCommand Cmd = new OracleCommand(Query, Connection);
                Cmd.CommandType = System.Data.CommandType.Text;

                OracleDataAdapter Da = new OracleDataAdapter(Cmd);
                Da.Fill(Ds3, Column);
                try
                {
                    if (Ds3.Tables[Column].Rows.Count > 0)
                    {
                        oDataRow3 = Ds3.Tables[Column].Rows[iPosicionFilaActual];
                        _return = true;
                    }
                    else
                        _return = false;
                }
                catch (Exception ex)
                {
                    _return = false;
                    goto reitentar;
                }
                finally
                {
                    Cmd.Dispose();
                    Connection.Close();
                }
                return _return;
            }
        }

        /// <summary>
        /// Método 4 para ejecutar un query y adaptarlo a un dataset especificando la columna
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="Column"></param>
        /// <returns></returns>

        public bool QueryDataSet4(string Query, string Column)
        {
            reitentar:
            using (OracleConnection Connection = new OracleConnection(ConnectString))
            {
                if (Ds4.Tables.Count != 0)
                    Ds4.Clear();

                bool _return = false;

                int iPosicionFilaActual = 0;

                Connection.Open();
                OracleCommand Cmd = new OracleCommand(Query, Connection);
                Cmd.CommandType = System.Data.CommandType.Text;

                OracleDataAdapter Da = new OracleDataAdapter(Cmd);
                Da.Fill(Ds4, Column);
                try
                {
                    if (Ds4.Tables[Column].Rows.Count > 0)
                    {
                        oDataRow4 = Ds4.Tables[Column].Rows[iPosicionFilaActual];
                        _return = true;
                    }
                    else
                        _return = false;
                }
                catch (Exception ex)
                {
                    _return = false;
                    goto reitentar;
                }
                finally
                {
                    Cmd.Dispose();
                    Connection.Close();
                }
                return _return;
            }
        }
    }
}