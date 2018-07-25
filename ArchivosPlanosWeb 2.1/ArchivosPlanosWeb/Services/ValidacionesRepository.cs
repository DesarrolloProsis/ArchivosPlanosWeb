using ArchivosPlanosWeb.Models;
//using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace ArchivosPlanosWeb.Services
{
    public class ValidacionesRepository
    { 
        private DbFirstTlalpanLab db = new DbFirstTlalpanLab();
        bool BanValidaciones = true;
        public  List<filas> listass = new List<filas>();
        public string Message = string.Empty;
        bool Null = false;

        /// <summary>
        /// Validar carriles cerrados
        /// </summary>
        /// <param name="FechaInicioD"></param>
        /// <param name="FechaSelect"></param>
        /// <param name="TempTurno"></param>
        /// <returns></returns>
        public string ValidarCarrilesCerrados(DateTime FechaInicioD, DateTime FechaSelect, string TempTurno)
        {
            Carril Carril = new Carril();
            OracleCommand Cmd = new OracleCommand();
            OracleConnection Connection = new OracleConnection();
            List<Carril> Carriles = new List<Carril>();
            List<Carril> CarrilesCerrados = new List<Carril>();
            Connection.ConnectionString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

            string rpt = string.Empty;
            string TurnoP = string.Empty;
            string FechaInicio = string.Empty;
            string FechaFinal = string.Empty;

            switch (TempTurno)
            {
                case "22:00 - 06:00":
                    TurnoP = "1";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 22:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "06:00 - 14:00":
                    TurnoP = "2";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 06:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "14:00 - 22:00":
                    TurnoP = "3";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 14:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
            }

            var Query = db.Database.SqlQuery<LANE_ASSIGN>(@"SELECT	LANE_ASSIGN.Id_plaza,
 		                    LANE_ASSIGN.Id_lane,
		                    TO_CHAR(LANE_ASSIGN.MSG_DHM,'MM/DD/YY HH24:MI:SS') AS FECHA_INICIO,
 		                    LANE_ASSIGN.SHIFT_NUMBER,
 		                    LANE_ASSIGN.OPERATION_ID,
		                    TO_CHAR(LANE_ASSIGN.ASSIGN_DHM,'MM/DD/YY') AS FECHA,
		                    LTRIM(TO_CHAR(LANE_ASSIGN.JOB_NUMBER,'09')) AS EMPLEADO,
		                    LANE_ASSIGN.STAFF_NUMBER,
		                    LANE_ASSIGN.IN_CHARGE_SHIFT_NUMBER
                            FROM 	LANE_ASSIGN
                            WHERE	 SHIFT_NUMBER = " + TurnoP + "" +
                            "AND LANE_ASSIGN.OPERATION_ID = 'NA'" +
                            "AND((MSG_DHM >= TO_DATE('" + FechaInicio + "', 'MM-DD-YYYY HH24:MI:SS')) AND(MSG_DHM <= TO_DATE('" + FechaFinal + "', 'MM-DD-YYYY HH24:MI:SS')))" +
                            "ORDER BY LANE_ASSIGN.Id_PLAZA," +
                            "LANE_ASSIGN.Id_LANE," +
                            "LANE_ASSIGN.MSG_DHM ");

            // Se llaman a todos los carriles con NA
            Connection.Open();
            Cmd.CommandText = Query.ToString();
            Cmd.Connection = Connection;
            OracleDataReader DataReader = Cmd.ExecuteReader();
            while (DataReader.Read())
            {
                Carril = new Carril();
                Carril.LANE = DataReader["ID_LANE"].ToString();
                Carril.FECHA = DataReader["FECHA_INICIO"].ToString();
                Carril.MATRICULE = DataReader["STAFF_NUMBER"].ToString();
                Carriles.Add(Carril);
            }
            Connection.Close();

            // Se verifican que los carriles se encuentren cerrados en la tabla FIN_POSTE
            foreach (Carril item in Carriles)
            {
                var QueryFin_Poste = db.Database.SqlQuery<FIN_POSTE>(@"SELECT COUNT(*) FROM FIN_POSTE WHERE DATE_DEBUT_POSTE = TO_DATE('" + item.FECHA + "', 'MM/DD/YY HH24:MI:SS') AND VOIE = '" + item.LANE + "' AND MATRICULE = '" + item.MATRICULE + "'");
                Connection.Open();
                Cmd.CommandText = Query.ToString();
                Cmd.Connection = Connection;
                if (Convert.ToInt32(Cmd.ExecuteScalar()) < 1)
                {
                    Carril = new Carril();
                    Carril.LANE = item.LANE;
                    Carril.FECHA = item.FECHA;
                    Carril.MATRICULE = item.MATRICULE;
                    CarrilesCerrados.Add(Carril);
                    BanValidaciones = false;
                }
                Connection.Close();

                foreach (Carril value in CarrilesCerrados)
                {
                    Message += Message + value.LANE + ", ";
                }
            }

            rpt = BanValidaciones == true ? "OK" : "STOP";

            return rpt;
        }

        /// <summary>
        /// Validar bolsas
        /// </summary>
        /// <param name="FechaInicioD"></param>
        /// <param name="FechaSelect"></param>
        /// <param name="TempTurno"></param>
        /// <returns></returns>
        public string ValidarBolsas(DateTime FechaInicioD, DateTime FechaSelect, string TempTurno)
        {
            OracleCommand Cmd = new OracleCommand();
            OracleConnection Connection = new OracleConnection();
            Connection.ConnectionString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

            string rpt = string.Empty;
            string FechaInicio = string.Empty;
            string FechaFinal = string.Empty;
            string TurnoP = string.Empty;

            switch (TempTurno)
            {
                case "22:00 - 06:00":
                    TurnoP = "1";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 22:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "06:00 - 14:00":
                    TurnoP = "2";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 06:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "14:00 - 22:00":
                    TurnoP = "3";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 14:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
            }

            // Verifica que todos los carriles cerrados tengan bolsa
            string Query = @"SELECT TO_CHAR(C.DATE_FIN_POSTE,'yyyy-mm-dd') AS FECHA, " +
                            "C.MATRICULE AS cajero, " +
                            "C.VOIE AS Carril, " +
                            "C.NUMERO_POSTE AS Corte, " +
                            "TO_CHAR(C.DATE_DEBUT_POSTE,'HH24:mi:SS') AS Inicio_Turno, " +
                            "TO_CHAR(C.DATE_FIN_POSTE,'HH24:mi:SS') AS Fin_Turno, " +
                            "'Entrega no realizada de bolsa '||C.VOIE||' Inicio '||TO_CHAR(C.DATE_DEBUT_POSTE,'HH24:mi:SS')||',Fin '||TO_CHAR(C.DATE_FIN_POSTE,'HH24:mi:SS')||' '||A.MATRICULE||'/'|| A.NOM AS Aviso " +
                            "FROM FIN_POSTE C " +
                            "LEFT JOIN TABLE_PERSONNEL  A ON C.Matricule = A.Matricule " +
                            "WHERE C.DATE_DEBUT_POSTE " +
                            "BETWEEN to_date('" + FechaInicio + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            "AND to_date('" + FechaFinal + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            "AND SAC IS NULL AND FIN_POSTE_CPT22 = " + TurnoP + "AND C.ID_MODE_VOIE in (1,7)";
            Connection.Open();
            Cmd.CommandText = Query;
            Cmd.Connection = Connection;
            OracleDataReader DataReader = Cmd.ExecuteReader();
            while (DataReader.Read())
            {
                BanValidaciones = false;
                Message += DataReader["Aviso"].ToString();
            }
            Connection.Close();

            rpt = BanValidaciones == true ? "OK" : "STOP";

            return rpt;
        }

        /// <summary>
        /// Validar Comentarios
        /// </summary>
        /// <param name="FechaInicioD"></param>
        /// <param name="FechaSelect"></param>
        /// <param name="TempTurno"></param>
        /// <returns></returns>
        public List<filas> ValidarComentarios(DateTime FechaInicioD, DateTime FechaSelect, string TempTurno)
        {
            OracleCommand Cmd = new OracleCommand();
            OracleConnection Connection = new OracleConnection();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            Connection.ConnectionString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

            string rpt = string.Empty;
            string FechaInicio = string.Empty;
            string FechaFinal = string.Empty;
            string TurnoP = string.Empty;
            

            switch (TempTurno)
            {
                case "22:00 - 06:00":
                    TurnoP = "1";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 22:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "06:00 - 14:00":
                    TurnoP = "2";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 06:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
                case "14:00 - 22:00":
                    TurnoP = "3";
                    FechaInicio = FechaInicioD.ToString("MM/dd/yyyy") + " 14:00:00";
                    FechaFinal = FechaSelect.ToString("MM/dd/yyyy") + " 23:59:59";
                    break;
            }

            // Valida que se hayan capturado los  comentarios en la entrega de Bolsa
            // SE MODIFICIO DATE_FIN_POSTE POR C.DATE_DEBUT_POSTE [RODRIGO]



            string Query = @"SELECT " +
                            "C.COMMENTAIRE AS COMENTARIOS, " +
                            "C.SAC AS BOLSA, " +
                            "C.OPERATING_SHIFT AS TURNO, " +
                            "C.DATE_REDDITION AS FECHA, " +
                            "C.RED_TXT1, " +
                            "'Declaracion sin comentarios  carril '||C.RED_TXT1||' bolsa '||TO_CHAR(C.SAC)||' '||A.MATRICULE||'/'|| A.NOM AS Aviso " +
                            "FROM REDDITION  C " +
                            "LEFT JOIN TABLE_PERSONNEL  A ON C.Matricule = A.Matricule " +
                            "WHERE DATE_REDDITION " +
                            "BETWEEN to_date('" + FechaInicio + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            "AND to_date('" + FechaFinal + "' ,'mm-dd-yyyy HH24:mi:SS') " +
                            " AND COMMENTAIRE IS NULL AND C.OPERATING_SHIFT  = " + TurnoP;



            Connection.Open();
            Cmd.CommandText = Query;
            Cmd.Connection = Connection;
            OracleDataAdapter myAdapter = new OracleDataAdapter(Cmd);
            OracleDataReader DataReader = Cmd.ExecuteReader();
         
            while (DataReader.Read())
            {
                BanValidaciones = false;
                myAdapter.Fill(dt);
                Message += DataReader["Aviso"].ToString();
                break;


            }


            //List<filas> filass = new List<filas>();
            foreach (DataRow indi in dt.Rows)
            {
                filas datos = new filas();
                datos.bolsa = indi["BOLSA"].ToString();
                datos.red = indi["RED_TXT1"].ToString();
                datos.turno = indi["TURNO"].ToString();
                listass.Add(datos);
                break;
            }


            ControlesExportar model = new ControlesExportar();
            model.Listacomentarios = listass;
            Connection.Close();

            //rpt = BanValidaciones == true ? "OK" : "STOP";

            return listass;
        }


        //public string Insertar_Comentarios(DateTime FechaInicioD, DateTime FechaSelect, string TempTurno, string Comentario)
        public string Isertar_Comentarios(List<filas> listass, List<string> comentario)
         {
    
            string rpt = string.Empty;
         
            for (int i = 0; i < comentario.Count; i++)
            {
              


                string Query = "UPDATE REDDITION SET COMMENTAIRE = '" + comentario[i] +
                                "' WHERE SAC = '" + listass[i].bolsa +
                                "' AND OPERATING_SHIFT = '" + listass[i].turno + 
                                "' ";



                string ConnectionString = ConfigurationManager.ConnectionStrings["OracleDbContext"].ConnectionString;

                try
                {
                    using (OracleConnection Connection = new OracleConnection(ConnectionString))

                    {
                        OracleCommand command = new OracleCommand(Query, Connection);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
            }
                catch (Exception ex)
            {

            }

        }

            BanValidaciones = true;
            Message = "MENSAJE INSERTADO";
            rpt = BanValidaciones == true ? "OK" : "STOP";
            
            return rpt;
        }

    }
}