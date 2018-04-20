using ArchivosPlanosWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace ArchivosPlanosWeb.Services
{
    public class Archivo1ARepository
    {
        private DbFirstSqlServer db = new DbFirstSqlServer();
        private MetodosGlbRepository MtGlb = new MetodosGlbRepository();

        string ConnectString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
        string Archivo_1;
        string Str_detalle;
        string Carpeta = @"C:\ARCHIVOSPLANOS2\";
        string StrIdentificador = "A";
        public string Message = string.Empty;

        /// <summary>
        /// ARCHIVO 1A
        /// </summary>
        /// <param name="Str_Turno_block"></param>
        /// <param name="FechaInicio"></param>
        /// <param name="IdPlazaCobro"></param>
        /// <param name="CabeceraTag"></param>
        /// <param name="Tramo"></param>
        /// <returns></returns>
        public string Generar_Bitacora_Operacion(string Str_Turno_block, DateTime FechaInicio, string IdPlazaCobro, string CabeceraTag, string Tramo)
        {
            string rpt = string.Empty;
            bool Validar = false;

            string StrQuerys = string.Empty;
            string Cabecera = string.Empty;
            string Numero_archivo = string.Empty;
            string Nombre_archivo = string.Empty;
            int Int_turno = 0;
            string H_inicio_turno = string.Empty;
            string H_fin_turno = string.Empty;
            string No_registros = string.Empty;
            string Str_detalle_tc = string.Empty;
            string Str_encargado = string.Empty;
            double Dbl_registros = 0;
            string StrEncargadoTurno = string.Empty;
            int Cont_cerrado_todo_turno = 0;
            string strSac;
            var NumPlaza = string.Empty;
            var NumCarril = string.Empty;
            var NumTramo = string.Empty;
            var Encargado = string.Empty;
            var EncargadoTurno = string.Empty;
            var Matricula = string.Empty;
            var EncargadoPlaza = string.Empty;
            DataSet dataSet = new DataSet();

            try
            {
                if (!Directory.Exists(Carpeta))
                {
                    Directory.CreateDirectory(Carpeta);
                }

                if (Str_Turno_block.Substring(0, 2) == "06")
                {
                    Int_turno = 5;
                    H_inicio_turno = FechaInicio.ToString("MM/dd/yyyy") + " 06:00:00";
                    H_fin_turno = FechaInicio.ToString("MM/dd/yyyy") + " 13:59:59";
                }
                else if (Str_Turno_block.Substring(0, 2) == "14")
                {
                    Int_turno = 6;
                    H_inicio_turno = FechaInicio.ToString("MM/dd/yyyy") + " 14:00:00";
                    H_fin_turno = FechaInicio.ToString("MM/dd/yyyy") + " 21:59:59";
                }
                else if (Str_Turno_block.Substring(0, 2) == "22")
                {
                    Int_turno = 4;
                    H_inicio_turno = FechaInicio.AddDays(-1).ToString("MM/dd/yyyy") + " 22:00:00";
                    H_fin_turno = FechaInicio.ToString("MM/dd/yyyy") + " 05:59:59";
                }

                if (IdPlazaCobro.Length == 3)
                {
                    if (IdPlazaCobro == "108")
                        Nombre_archivo = "0001";
                    else if (IdPlazaCobro == "109")
                        Nombre_archivo = "001B";
                    else if (IdPlazaCobro == "107")
                        Nombre_archivo = "0107";
                    else Nombre_archivo = "0" + IdPlazaCobro;
                }

                Nombre_archivo = Nombre_archivo + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "1" + StrIdentificador;

                StreamWriter Osw = new StreamWriter(Carpeta + Nombre_archivo);

                Archivo_1 = Nombre_archivo;
                // cabecera = "David Cabecera"
                // cabecera = "04"
                Cabecera = CabeceraTag;
                if (IdPlazaCobro.Length == 3)
                {
                    if (IdPlazaCobro == "108")
                        Cabecera = Cabecera + "0001";
                    else if (IdPlazaCobro == "109")
                        Cabecera = Cabecera + "001B";
                    else if (IdPlazaCobro == "107")
                        Cabecera = Cabecera + "0107";
                    else Cabecera = Cabecera + "0" + IdPlazaCobro;
                }

                Cabecera = Cabecera + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "1" + StrIdentificador + FechaInicio.ToString("dd/MM/yyyy") + Int_turno;

                // CABECERA INICIO REGISTROS
                DateTime _H_inicio_turno = DateTime.ParseExact(H_inicio_turno, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime _H_fin_turno = DateTime.ParseExact(H_fin_turno, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                StrQuerys = "SELECT	FIN_POSTE.Id_Gare, " +
                                            "TYPE_VOIE.libelle_court_voie_L2, " +
                                            "Voie, " +
                                            "'zzz', " +
                                            "TO_CHAR(Numero_Poste,'FM09'), " +
                                            "TO_CHAR(Date_Fin_Poste,'MM/DD/YY'), " +
                                            "TO_CHAR(Date_Fin_Poste,'HH24:MI'), " +
                                            "Matricule, " +
                                            "Sac, " +
                                            "FIN_POSTE.Id_Voie, " +
                                            "DATE_DEBUT_POSTE,Date_Fin_Poste, " +
                                            "TO_CHAR(Date_Debut_Poste,'YYYYMMDDHH24MISS'), " +
                                            "TO_CHAR(Date_Fin_Poste,'YYYYMMDDHH24MISS') " +
                                            ",TYPE_VOIE.libelle_court_voie " +
                                            ",FIN_POSTE_CPT22, " +
                                            "ROUND((DATE_FIN_POSTE - DATE_DEBUT_POSTE) * (60 * 24), 2) AS time_in_minutes " +
                                            "FROM 	TYPE_VOIE, " +
                                            "FIN_POSTE, " +
                                            "SITE_GARE " +
                                            "WHERE	FIN_POSTE.Id_Voie	=	TYPE_VOIE.Id_Voie " +
                                            "AND FIN_POSTE.id_reseau	= 	SITE_GARE.id_Reseau " +
                                            "AND	FIN_POSTE.id_Gare	=	SITE_GARE.id_Gare " +
                                            "AND	SITE_GARE.id_reseau		= 	'01' " +
                                            "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                                            "AND (Id_Mode_Voie IN (1,7,9)) " +
                                            "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                            "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                            "AND (FIN_POSTE.Id_Voie = '1' " +
                                            "OR FIN_POSTE.Id_Voie = '2' " +
                                            "OR FIN_POSTE.Id_Voie = '3' " +
                                            "OR FIN_POSTE.Id_Voie = '4' " +
                                            "OR FIN_POSTE.Id_Voie = 'X' " +
                                            ") " +
                                            "ORDER BY Id_Gare, " +
                                            "Id_Voie, " +
                                            "Voie, " +
                                            "Date_Debut_Poste," +
                                            "Date_Fin_Poste, " +
                                            "Numero_Poste, " +
                                            "Matricule " +
                                            ",Sac";

                if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE"))
                    Dbl_registros = MtGlb.Ds.Tables["FIN_POSTE"].Rows.Count;
                else
                    Dbl_registros = 0;

                if (IdPlazaCobro.Substring(1, 2) == "84")
                {
                    StrQuerys = "SELECT	FIN_POSTE.Id_Gare, " +
                                "TYPE_VOIE.libelle_court_voie_L2, " +
                                "Voie, " +
                                "'zzz', " +
                                "TO_CHAR(Numero_Poste,'FM09'), " +
                                "TO_CHAR(Date_Fin_Poste,'MM/DD/YY'), " +
                                "TO_CHAR(Date_Fin_Poste,'HH24:MI'), " +
                                "Matricule, " +
                                "Sac, " +
                                "FIN_POSTE.Id_Voie, " +
                                "DATE_DEBUT_POSTE,Date_Fin_Poste, " +
                                "TO_CHAR(Date_Debut_Poste,'YYYYMMDDHH24MISS'), " +
                                "TO_CHAR(Date_Fin_Poste,'YYYYMMDDHH24MISS') " +
                                ",TYPE_VOIE.libelle_court_voie " +
                                ",FIN_POSTE_CPT22, " +
                                "ROUND((DATE_FIN_POSTE - DATE_DEBUT_POSTE) * (60 * 24), 2) AS time_in_minutes " +
                                "FROM 	TYPE_VOIE, " +
                                "FIN_POSTE, " +
                                "SITE_GARE " +
                                "WHERE	FIN_POSTE.Id_Voie	=	TYPE_VOIE.Id_Voie " +
                                "AND FIN_POSTE.id_reseau	= 	SITE_GARE.id_Reseau " +
                                "AND	FIN_POSTE.id_Gare	=	SITE_GARE.id_Gare " +
                                "AND	SITE_GARE.id_reseau		= 	'01' " +
                                "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                                "AND (Id_Mode_Voie IN (1,7,9)) " +
                                "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                "AND (FIN_POSTE.Id_Voie = '1' " +
                                "OR FIN_POSTE.Id_Voie = '2' " +
                                "OR FIN_POSTE.Id_Voie = '3' " +
                                "OR FIN_POSTE.Id_Voie = '4' " +
                                "OR FIN_POSTE.Id_Voie = 'X' " +
                                ")  and SUBSTR(Voie,1,1) = 'A'  " +
                                "ORDER BY Id_Gare, " +
                                "Id_Voie, " +
                                "Voie, " +
                                "Date_Debut_Poste," +
                                "Date_Fin_Poste, " +
                                "Numero_Poste, " +
                                "Matricule " +
                                ",Sac";

                    if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE"))
                        Dbl_registros = Dbl_registros + MtGlb.Ds.Tables["FIN_POSTE"].Rows.Count;
                    else
                        Dbl_registros = Dbl_registros + 0;
                }
                else if (IdPlazaCobro.Substring(1, 2) == "02")
                {
                    //tramo corto
                    StrQuerys = "SELECT	FIN_POSTE.Id_Gare, " +
                                "TYPE_VOIE.libelle_court_voie_L2, " +
                                "Voie, " +
                                "'zzz', " +
                                "TO_CHAR(Numero_Poste,'FM09'), " +
                                "TO_CHAR(Date_Fin_Poste,'MM/DD/YY'), " +
                                "TO_CHAR(Date_Fin_Poste,'HH24:MI'), " +
                                "Matricule, " +
                                "Sac, " +
                                "FIN_POSTE.Id_Voie, " +
                                "DATE_DEBUT_POSTE,Date_Fin_Poste, " +
                                "TO_CHAR(Date_Debut_Poste,'YYYYMMDDHH24MISS'), " +
                                "TO_CHAR(Date_Fin_Poste,'YYYYMMDDHH24MISS') " +
                                ",TYPE_VOIE.libelle_court_voie " +
                                ",FIN_POSTE_CPT22, " +
                                "ROUND((DATE_FIN_POSTE - DATE_DEBUT_POSTE) * (60 * 24), 2) AS time_in_minutes " +
                                "FROM 	TYPE_VOIE, " +
                                "FIN_POSTE, " +
                                "SITE_GARE " +
                                "WHERE	FIN_POSTE.Id_Voie	=	TYPE_VOIE.Id_Voie " +
                                "AND FIN_POSTE.id_reseau	= 	SITE_GARE.id_Reseau " +
                                "AND	FIN_POSTE.id_Gare	=	SITE_GARE.id_Gare " +
                                "AND	SITE_GARE.id_reseau		= 	'01' " +
                                "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                                "AND (Id_Mode_Voie IN (1,7,9)) " +
                                "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                "AND (FIN_POSTE.Id_Voie = '1' " +
                                "OR FIN_POSTE.Id_Voie = '2' " +
                                "OR FIN_POSTE.Id_Voie = '3' " +
                                "OR FIN_POSTE.Id_Voie = '4' " +
                                "OR FIN_POSTE.Id_Voie = 'X' " +
                                ")  and (Voie = 'A01' OR Voie = 'B08')  " +
                                "ORDER BY Id_Gare, " +
                                "Id_Voie, " +
                                "Voie, " +
                                "Date_Debut_Poste," +
                                "Date_Fin_Poste, " +
                                "Numero_Poste, " +
                                "Matricule " +
                                ",Sac";

                    if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE"))
                        Dbl_registros = Dbl_registros + MtGlb.Ds.Tables["FIN_POSTE"].Rows.Count;
                    else
                        Dbl_registros = Dbl_registros + 0;
                }

                StrQuerys = "SELECT ID_NETWORK, ID_PLAZA,ID_LANE, LANE, BEGIN_DHM, END_DHM, BAG_NUMBER, REPORT_FLAG, GENERATION_DHM " +
                            "FROM CLOSED_LANE_REPORT, SITE_GARE " +
                            "where " +
                            "CLOSED_LANE_REPORT.ID_PLAZA	=	SITE_GARE.id_Gare " +
                            "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                            "AND ((BEGIN_DHM >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                            "AND (BEGIN_DHM <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                            "order by BEGIN_DHM";

                if (MtGlb.QueryDataSet(StrQuerys, "CLOSED_LANE_REPORT"))
                    Dbl_registros = Dbl_registros + MtGlb.Ds.Tables["CLOSED_LANE_REPORT"].Rows.Count;
                else
                    Dbl_registros = Dbl_registros + 0;

                // carriles siempre cerrados
                // cont_cerrado_todo_turno

                StrQuerys = "SELECT VOIE, NUM_SEQUENCE FROM SEQ_VOIE_TOD ";

                if (IdPlazaCobro == "106")
                {
                    StrQuerys = StrQuerys + "where VOIE <> 'B04' and VOIE <> 'A03' ";
                }

                if (MtGlb.QueryDataSet1(StrQuerys, "SEQ_VOIE_TOD"))
                {
                    for (int i = 0; i < MtGlb.Ds1.Tables["SEQ_VOIE_TOD"].Rows.Count - 1; i++)
                    {
                        MtGlb.oDataRow1 = MtGlb.Ds1.Tables["SEQ_VOIE_TOD"].Rows[i];
                        MtGlb.oDataRow1.AcceptChanges();
                        StrQuerys = "SELECT	* FROM 	FIN_POSTE " +
                                     "WHERE	 VOIE = '" + MtGlb.oDataRow1["VOIE"] + "' " +
                                     "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                     "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) ";

                        if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE") == false)
                        {
                            StrQuerys = "SELECT * " +
                                        "FROM CLOSED_LANE_REPORT, SITE_GARE " +
                                        "where " +
                                        "CLOSED_LANE_REPORT.ID_PLAZA	=	SITE_GARE.id_Gare " +
                                        "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                                        "AND	LANE		=	'" + MtGlb.oDataRow1["VOIE"] + "' " +
                                        "AND ((BEGIN_DHM >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                        "AND (BEGIN_DHM <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                        "order by BEGIN_DHM";

                            if (MtGlb.QueryDataSet(StrQuerys, "CLOSED_LANE_REPORT") == false)
                                Cont_cerrado_todo_turno = Cont_cerrado_todo_turno + 1;
                        }
                    }
                }

                Dbl_registros = Dbl_registros + Cont_cerrado_todo_turno;

                // fin carriles siempre cerrados

                if (Convert.ToString(Dbl_registros).Length == 1)
                    No_registros = "0000" + Dbl_registros;
                else if (Convert.ToString(Dbl_registros).Length == 2)
                    No_registros = "000" + Dbl_registros;
                else if (Convert.ToString(Dbl_registros).Length == 3)
                    No_registros = "00" + Dbl_registros;
                else if (Convert.ToString(Dbl_registros).Length == 4)
                    No_registros = "0" + Dbl_registros;
                else if (Convert.ToString(Dbl_registros).Length == 5)
                    No_registros = Dbl_registros.ToString();

                Cabecera = Cabecera + No_registros;

                Osw.WriteLine(Cabecera);
                // CABECERA FIN

                //INICIO DETALLE

                //CARRILES ABIERTOS 
                StrQuerys = "SELECT	FIN_POSTE.Id_Gare, " +
                            "TYPE_VOIE.libelle_court_voie_L2, " +
                            "Voie, " +
                            "'zzz', " +
                            "TO_CHAR(Numero_Poste,'FM09'), " +
                            "TO_CHAR(Date_Fin_Poste,'MM/DD/YY'), " +
                            "TO_CHAR(Date_Fin_Poste,'HH24:MI'), " +
                            "Matricule, " +
                            "Sac, " +
                            "FIN_POSTE.Id_Voie, " +
                            "DATE_DEBUT_POSTE,Date_Fin_Poste, " +
                            "TO_CHAR(Date_Debut_Poste,'YYYYMMDDHH24MISS'), " +
                            "TO_CHAR(Date_Fin_Poste,'YYYYMMDDHH24MISS') " +
                            ",TYPE_VOIE.libelle_court_voie " +
                            ",FIN_POSTE_CPT22, " +
                            "ROUND((DATE_FIN_POSTE - DATE_DEBUT_POSTE) * (60 * 24), 2) AS time_in_minutes " +
                            "FROM 	TYPE_VOIE, " +
                            "FIN_POSTE, " +
                            "SITE_GARE " +
                            "WHERE	FIN_POSTE.Id_Voie	=	TYPE_VOIE.Id_Voie " +
                            "AND FIN_POSTE.id_reseau	= 	SITE_GARE.id_Reseau " +
                            "AND	FIN_POSTE.id_Gare	=	SITE_GARE.id_Gare " +
                            "AND	SITE_GARE.id_reseau		= 	'01' " +
                            "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                            "AND (Id_Mode_Voie IN (1,7,9)) " +
                            "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                            "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                            "AND (FIN_POSTE.Id_Voie = '1' " +
                            "OR FIN_POSTE.Id_Voie = '2' " +
                            "OR FIN_POSTE.Id_Voie = '3' " +
                            "OR FIN_POSTE.Id_Voie = '4' " +
                            "OR FIN_POSTE.Id_Voie = 'X' " +
                            ") " +
                            "ORDER BY Id_Gare, " +
                            "Id_Voie, " +
                            "Voie, " +
                            "Date_Debut_Poste," +
                            "Date_Fin_Poste, " +
                            "Numero_Poste, " +
                            "Matricule " +
                            ",Sac";

                if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE"))
                {
                    for (int i = 0; i < MtGlb.Ds.Tables["FIN_POSTE"].Rows.Count; i++)
                    {
                        MtGlb.oDataRow = MtGlb.Ds.Tables["FIN_POSTE"].Rows[i];

                        Str_detalle = string.Empty;
                        Str_detalle_tc = string.Empty;

                        //Fecha base de operación 	Fecha 	dd/mm/aaaa
                        //str_detalle = Format(oDataRow("DATE_DEBUT_POSTE"), "dd/MM/yyyy") & ","
                        //Format(dt_Fecha_Inicio, "MM/dd/yyyy")
                        Str_detalle = FechaInicio.ToString("dd/MM/yyyy") + ",";
                        //Número de turno Entero  9   Valores posibles: Tabla 12 - Ejemplo del Catálogo de Turnos por Plaza de Cobro.
                        Str_detalle = Str_detalle + Int_turno + ",";
                        //Hora inicial de operación   Caracter hhmmss
                        Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["DATE_DEBUT_POSTE"]).ToString("HHmmss") + ",";
                        //Hora final de operación     Caracter hhmmss
                        Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["Date_Fin_Poste"]).ToString("HHmmss") + ",";

                        Str_detalle_tc = Str_detalle;

                        //BUSCAR EN LA BD SQLSERVER EL CARRIL
                        using (SqlConnection Connection = new SqlConnection(ConnectString))
                        {
                            Connection.Open();
                            string Query = @"SELECT t.idTramo, t.nomTramo, p.idPlaza, p.nomPlaza, c.idCarril, c.numCarril, c.numTramo " +
                                            "FROM TYPE_PLAZA p " +
                                            "INNER JOIN TYPE_TRAMO t ON t.idTramo = p.idTramo " +
                                            "INNER JOIN TYPE_CARRIL c ON c.idPlaza = p.idPlaza " +
                                            "WHERE p.idTramo = @tramo and p.idPlaza = @plaza and c.idCarril = @carril ";

                            using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                            {
                                Cmd.Parameters.Add(new SqlParameter("tramo", Tramo));
                                Cmd.Parameters.Add(new SqlParameter("plaza", IdPlazaCobro.Substring(1, 2)));
                                Cmd.Parameters.Add(new SqlParameter("carril", Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2)));
                                try
                                {
                                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                    sqlDataAdapter.Fill(dataSet, "CARRIL");
                                    if (dataSet.Tables["CARRIL"].Rows.Count != 0)
                                    {
                                        foreach (DataRow item in dataSet.Tables["CARRIL"].Rows)
                                        {
                                            NumCarril = item[5].ToString();
                                            NumTramo = item[6].ToString();
                                            NumPlaza = item[2].ToString();
                                        }
                                    }
                                    else
                                    {
                                        NumCarril = string.Empty;
                                        NumTramo = string.Empty;
                                        NumPlaza = string.Empty;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                finally
                                {
                                    dataSet.Clear();
                                    Cmd.Dispose();
                                    Connection.Close();
                                }
                            }
                        }

                        if (NumPlaza == "84")
                        {
                            Str_detalle = Str_detalle + NumTramo + ",";

                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "A")
                                Str_detalle_tc = Str_detalle_tc + "340" + ",";

                            Str_detalle = Str_detalle + NumCarril + ",";
                            Str_detalle_tc = Str_detalle_tc + NumCarril + ",";
                        }
                        else if (NumPlaza == "02")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "01")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";

                                Str_detalle_tc = Str_detalle_tc + "261" + ",";
                                Str_detalle_tc = Str_detalle_tc + "1803" + ",";
                            }
                            else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "08")
                            {
                                Str_detalle = Str_detalle + "249" + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";

                                Str_detalle_tc = Str_detalle_tc + NumTramo + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";
                            }
                        }
                        else if (NumPlaza == "06")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "A")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";

                                if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "02" || Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "04")
                                    Str_detalle = Str_detalle + NumCarril + ",";
                            }
                            else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "B")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";

                                if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "01" || Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "03")
                                    Str_detalle = Str_detalle + NumCarril + ",";
                            }
                        }
                        //CARRILES SIN CAMBIO DE TRAMO: 04 , 03 , 01 , 05, 08, 09 , 07 , 89
                        else if (NumPlaza != string.Empty)
                        {
                            Str_detalle = Str_detalle + NumTramo + ",";
                            Str_detalle = Str_detalle + NumCarril + ",";
                        }


                        //Cuerpo Caracter    X(1)    Valores posibles: Tabla 13 - Ejemplo del Catálogo de Carriles y Tramos por Plaza de Cobro.
                        Str_detalle = Str_detalle + Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) + ",";
                        Str_detalle_tc = Str_detalle_tc + Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) + ",";


                        //CHECAR ENCARGADO Y IDENT OPERACION
                        //Identificador de operación	Caracter 	X(2)	Valores posibles:  Tabla 17 - Códigos de Operación por Carril.
                        StrQuerys = "SELECT	LANE_ASSIGN.Id_plaza,LANE_ASSIGN.Id_lane,TO_CHAR(LANE_ASSIGN.MSG_DHM,'MM/DD/YY HH24:MI:SS'),LANE_ASSIGN.SHIFT_NUMBER,LANE_ASSIGN.OPERATION_ID, " +
                                    "LANE_ASSIGN.DELEGATION, TO_CHAR(LANE_ASSIGN.ASSIGN_DHM,'MM/DD/YY'),LTRIM(TO_CHAR(LANE_ASSIGN.JOB_NUMBER,'09')),	LANE_ASSIGN.STAFF_NUMBER,LANE_ASSIGN.IN_CHARGE_SHIFT_NUMBER " +
                                    "FROM 	LANE_ASSIGN, SITE_GARE " +
                                    "WHERE	LANE_ASSIGN.id_NETWORK = SITE_GARE.id_Reseau " +
                                    "AND LANE_ASSIGN.id_plaza = SITE_GARE.id_Gare " +
                                    "AND SITE_GARE.id_reseau = '01' " +
                                    "AND	SITE_GARE.id_Site ='" + IdPlazaCobro.Substring(1, 2) + "' " +
                                    "AND LANE_ASSIGN.Id_lane = '" + MtGlb.oDataRow["Voie"].ToString().Trim() + "' " +
                                    "AND ((MSG_DHM >= TO_DATE('" + Convert.ToDateTime(MtGlb.oDataRow["DATE_DEBUT_POSTE"]).ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) AND (MSG_DHM <= TO_DATE('" + Convert.ToDateTime(MtGlb.oDataRow["DATE_DEBUT_POSTE"]).ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                    "ORDER BY LANE_ASSIGN.Id_PLAZA, LANE_ASSIGN.Id_LANE, LANE_ASSIGN.MSG_DHM";

                        //SI NO ENCUENTRA NADA, SE ASIGNA PENDIENTE A ENCARGADO
                        if (MtGlb.QueryDataSet2(StrQuerys, "Asig_Carril"))
                        {
                            Str_detalle = Str_detalle + MtGlb.oDataRow2["OPERATION_ID"] + ",";
                            Str_detalle_tc = Str_detalle_tc + MtGlb.oDataRow2["OPERATION_ID"] + ",";

                            Str_encargado = MtGlb.oDataRow2["STAFF_NUMBER"].ToString();
                            StrEncargadoTurno = MtGlb.oDataRow2["IN_CHARGE_SHIFT_NUMBER"].ToString();

                            //VERIFICAR SI EL ENCARGADO Y EL ENCARGADO TURNO EXISTEN
                            using (SqlConnection Connection = new SqlConnection(ConnectString))
                            {
                                Connection.Open();
                                string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                {
                                    Cmd.Parameters.Add(new SqlParameter("numGea", Str_encargado));
                                    try
                                    {
                                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                        sqlDataAdapter.Fill(dataSet, "STR_ENCARGADO");
                                        if (dataSet.Tables["STR_ENCARGADO"].Rows.Count != 0)
                                        {
                                            foreach (DataRow item in dataSet.Tables["STR_ENCARGADO"].Rows)
                                            {
                                                Encargado = item[0].ToString();
                                            }
                                        }
                                        else
                                        {
                                            Encargado = string.Empty;
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    finally
                                    {
                                        dataSet.Clear();
                                        Cmd.Dispose();
                                        Connection.Close();
                                    }
                                }

                                //VERFICAR EL ENCARGADO DE TURNO
                                Connection.Open();
                                Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                {
                                    Cmd.Parameters.Add(new SqlParameter("numGea", StrEncargadoTurno));
                                    try
                                    {
                                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                        sqlDataAdapter.Fill(dataSet, "STRENCARGADO_TURNO");
                                        if (dataSet.Tables["STRENCARGADO_TURNO"].Rows.Count != 0)
                                        {
                                            foreach (DataRow item in dataSet.Tables["STRENCARGADO_TURNO"].Rows)
                                            {
                                                EncargadoTurno = item[0].ToString();
                                            }
                                        }
                                        else
                                        {
                                            EncargadoTurno = string.Empty;
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    finally
                                    {
                                        dataSet.Clear();
                                        Cmd.Dispose();
                                        Connection.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Str_detalle = Str_detalle + "Pendiente,";
                            Str_encargado = "Pendiente,";
                        }


                        //SI EL CAJERO NO SE ENCUENTRA CON EL QUERY DE ASING_CARRIL, HACER ESTO:
                        if (Encargado == string.Empty)
                        {
                            //QUERY PARA EXTRAER LA MATRICULA DEL CAJERO
                            using (SqlConnection Connection = new SqlConnection(ConnectString))
                            {
                                Connection.Open();
                                string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                {
                                    Cmd.Parameters.Add(new SqlParameter("numGea", MtGlb.oDataRow["Matricule"].ToString()));
                                    try
                                    {
                                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                        sqlDataAdapter.Fill(dataSet, "MATRICULE");
                                        if (dataSet.Tables["MATRICULE"].Rows.Count != 0)
                                        {
                                            foreach (DataRow item in dataSet.Tables["MATRICULE"].Rows)
                                            {
                                                Matricula = item[0].ToString();
                                            }
                                        }
                                        else
                                        {
                                            Matricula = string.Empty;
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    finally
                                    {
                                        dataSet.Clear();
                                        Cmd.Dispose();
                                        Connection.Close();
                                    }
                                }
                            }
                            //VERIFICAR QUE LA MATRICULA NO ESTE VACÍA 
                            if (Matricula != string.Empty)
                            {
                                Str_detalle = Str_detalle + Matricula + ",";
                                Str_detalle_tc = Str_detalle_tc + Matricula + ",";
                            }
                            else
                            {
                                Str_detalle = Str_detalle + ",";
                                Str_detalle_tc = Str_detalle_tc + ",";
                            }

                            //SI NO ENCONTRO UN ENCARGADO POR ENDE NO ENCONTRO UN ENCARGADO DE TURNO; AGREGAMOS UNA "," SOLAMENTE
                            if (Str_encargado == "Pendiente,")
                            {
                                Str_detalle = Str_detalle + ",";
                                Str_detalle_tc = Str_detalle_tc + ",";
                            }
                        }
                        else
                        {
                            Str_detalle = Str_detalle + Encargado + EncargadoTurno + ",";
                            Str_detalle_tc = Str_detalle_tc + Encargado + EncargadoPlaza + ",";
                        }

                        //AÑADIR EL ENCARGADO DE PLAZA Y LA BOLSA
                        using (SqlConnection Connection = new SqlConnection(ConnectString))
                        {
                            Connection.Open();
                            string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                            using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                            {
                                Cmd.Parameters.Add(new SqlParameter("numGea", "encargado_plaza"));
                                try
                                {
                                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                    sqlDataAdapter.Fill(dataSet, "ENCARGADO_PLAZA");
                                    if (dataSet.Tables["ENCARGADO_PLAZA"].Rows.Count != 0)
                                    {
                                        foreach (DataRow item in dataSet.Tables["ENCARGADO_PLAZA"].Rows)
                                        {
                                            EncargadoPlaza = item[0].ToString();
                                        }
                                    }
                                    else
                                    {
                                        EncargadoPlaza = string.Empty;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                finally
                                {
                                    dataSet.Clear();
                                    Cmd.Dispose();
                                    Connection.Close();
                                }
                            }
                        }

                        Str_detalle = Str_detalle + EncargadoPlaza + ",";
                        Str_detalle_tc = Str_detalle_tc + EncargadoPlaza + ",";

                        //No. de control de preliquidación  	Entero 	>>>9 
                        strSac = MtGlb.IIf(DBNull.Value.Equals((MtGlb.oDataRow["Sac"])), "", MtGlb.oDataRow["Sac"].ToString());
                        strSac = strSac.Replace("A", "");
                        strSac = strSac.Replace("B", "");
                        Str_detalle = Str_detalle + strSac + ",";
                        Str_detalle_tc = Str_detalle_tc + strSac + ",";
                        Str_detalle = Str_detalle.Replace("X", "N");

                        Osw.WriteLine(Str_detalle);

                        if (IdPlazaCobro.Substring(1, 2) == "84")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1).Trim() == "A")
                                Osw.WriteLine(Str_detalle_tc);
                        }
                        else if (IdPlazaCobro.Substring(1, 2) == "02")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Trim() == "A01" || Convert.ToString(MtGlb.oDataRow["Voie"]) == "B08")
                                Osw.WriteLine(Str_detalle_tc);
                        }
                    }
                }

                //INICIO CARRILES CERRADOS
                StrQuerys = "SELECT ID_NETWORK, ID_PLAZA,ID_LANE, LANE, BEGIN_DHM, END_DHM, BAG_NUMBER, REPORT_FLAG, GENERATION_DHM " +
                            "FROM CLOSED_LANE_REPORT, SITE_GARE " +
                            "where " +
                            "CLOSED_LANE_REPORT.ID_PLAZA	=	SITE_GARE.id_Gare " +
                            "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                            "AND ((BEGIN_DHM >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                            "AND (BEGIN_DHM <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                            "order by BEGIN_DHM";

                if (MtGlb.QueryDataSet(StrQuerys, "CLOSED_LANE_REPORT"))
                {
                    for (int i = 0; i < MtGlb.Ds.Tables["CLOSED_LANE_REPORT"].Rows.Count; i++)
                    {
                        MtGlb.oDataRow = MtGlb.Ds.Tables["CLOSED_LANE_REPORT"].Rows[i];

                        Str_detalle = "";

                        //Fecha base de operación 	Fecha 	dd/mm/aaaa
                        Str_detalle = FechaInicio.ToString("dd/MM/yyyy") + ",";
                        //Número de turno	Entero 	9	Valores posibles: Tabla 12 - Ejemplo del Catálogo de Turnos por Plaza de Cobro.
                        Str_detalle = Str_detalle + Int_turno + ",";
                        //Hora inicial de operación 	Caracter 	hhmmss 	
                        Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["BEGIN_DHM"]).ToString("HHmmss") + ",";
                        //Hora final de operación 	Caracter 	hhmmss 	

                        //h_fin_turno
                        if (Convert.ToDateTime(MtGlb.oDataRow["END_DHM"]) > _H_fin_turno)
                            Str_detalle = Str_detalle + Convert.ToDateTime(_H_fin_turno).ToString("HHmmss") + ",";
                        else
                            Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["END_DHM"]).ToString("HHmmss") + ",";

                        //BUSCAR EN LA BD SQLSERVER EL CARRIL
                        using (SqlConnection Connection = new SqlConnection(ConnectString))
                        {
                            Connection.Open();
                            string Query = @"SELECT t.idTramo, t.nomTramo, p.idPlaza, p.nomPlaza, c.idCarril, c.numCarril, c.numTramo " +
                                            "FROM TYPE_PLAZA p " +
                                            "INNER JOIN TYPE_TRAMO t ON t.idTramo = p.idTramo " +
                                            "INNER JOIN TYPE_CARRIL c ON c.idPlaza = p.idPlaza " +
                                            "WHERE p.idTramo = @tramo and p.idPlaza = @plaza and c.idCarril = @carril ";

                            using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                            {
                                Cmd.Parameters.Add(new SqlParameter("tramo", Tramo));
                                Cmd.Parameters.Add(new SqlParameter("plaza", IdPlazaCobro.Substring(1, 2)));
                                Cmd.Parameters.Add(new SqlParameter("carril", Convert.ToString(MtGlb.oDataRow["LANE"]).Substring(1, 2)));
                                try
                                {
                                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                    sqlDataAdapter.Fill(dataSet, "CARRIL");
                                    if (dataSet.Tables["CARRIL"].Rows.Count != 0)
                                    {
                                        foreach (DataRow item in dataSet.Tables["CARRIL"].Rows)
                                        {
                                            NumCarril = item[5].ToString();
                                            NumTramo = item[6].ToString();
                                            NumPlaza = item[2].ToString();
                                        }
                                    }
                                    else
                                    {
                                        NumCarril = string.Empty;
                                        NumTramo = string.Empty;
                                        NumPlaza = string.Empty;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                finally
                                {
                                    dataSet.Clear();
                                    Cmd.Dispose();
                                    Connection.Close();
                                }
                            }
                        }

                        if (NumPlaza == "02")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "01")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";

                                Str_detalle_tc = Str_detalle_tc + "261" + ",";
                                Str_detalle_tc = Str_detalle_tc + "1803" + ",";
                            }
                            else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "08")
                            {
                                Str_detalle = Str_detalle + "249" + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";

                                Str_detalle_tc = Str_detalle_tc + NumTramo + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";
                            }
                        }
                        else if (NumPlaza == "06")
                        {
                            if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "A")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";

                                if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "02" || Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "04")
                                    Str_detalle = Str_detalle + NumCarril + ",";
                            }
                            else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "B")
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";

                                if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "01" || Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(1, 2) == "03")
                                    Str_detalle = Str_detalle + NumCarril + ",";
                            }
                        }
                        //CARRILES SIN CAMBIO DE TRAMO: 84 , 04 , 07 , 03 , 01 , 08 , 05 , 06 , 09 , 89
                        else if (NumPlaza != string.Empty)
                        {
                            Str_detalle = Str_detalle + NumTramo + ",";
                            Str_detalle = Str_detalle + NumCarril + ",";
                        }

                        Str_detalle = Str_detalle + Convert.ToString(MtGlb.oDataRow["LANE"]).Substring(0, 1) + ",";
                        //Identificador de operación	Caracter 	X(2)	Valores posibles:  Tabla 17 - Códigos de Operación por Carril.
                        StrQuerys = "SELECT	LANE_ASSIGN.Id_plaza,LANE_ASSIGN.Id_lane,TO_CHAR(LANE_ASSIGN.MSG_DHM,'MM/DD/YY HH24:MI:SS'),LANE_ASSIGN.SHIFT_NUMBER,LANE_ASSIGN.OPERATION_ID, " +
                                    "LANE_ASSIGN.DELEGATION, TO_CHAR(LANE_ASSIGN.ASSIGN_DHM,'MM/DD/YY'),LTRIM(TO_CHAR(LANE_ASSIGN.JOB_NUMBER,'09')),	LANE_ASSIGN.STAFF_NUMBER,LANE_ASSIGN.IN_CHARGE_SHIFT_NUMBER " +
                                    "FROM 	LANE_ASSIGN, SITE_GARE " +
                                    "WHERE	LANE_ASSIGN.id_NETWORK = SITE_GARE.id_Reseau " +
                                    "AND LANE_ASSIGN.id_plaza = SITE_GARE.id_Gare " +
                                    "AND SITE_GARE.id_reseau = '01' " +
                                    "AND	SITE_GARE.id_Site = '" + IdPlazaCobro.Substring(1, 2) + "' " +
                                    "AND LANE_ASSIGN.Id_lane = '" + MtGlb.oDataRow["LANE"] + "' " +
                                    "AND ((MSG_DHM >= TO_DATE('" + Convert.ToDateTime(MtGlb.oDataRow["BEGIN_DHM"]).ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) AND (MSG_DHM <= TO_DATE('" + Convert.ToDateTime(MtGlb.oDataRow["BEGIN_DHM"]).ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                    "ORDER BY LANE_ASSIGN.Id_PLAZA, LANE_ASSIGN.Id_LANE, LANE_ASSIGN.MSG_DHM";

                        //SI NO ENCUENTRA NADA, SE ASIGNA PENDIENTE A ENCARGADO
                        if (MtGlb.QueryDataSet2(StrQuerys, "Asig_Carril"))
                        {
                            Str_detalle = Str_detalle + MtGlb.oDataRow2["OPERATION_ID"] + ",";

                            StrEncargadoTurno = MtGlb.oDataRow2["IN_CHARGE_SHIFT_NUMBER"].ToString();

                            //VERIFICAR SI EL ENCARGADO TURNO EXISTEN
                            using (SqlConnection Connection = new SqlConnection(ConnectString))
                            {
                                Connection.Open();
                                string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                {
                                    Cmd.Parameters.Add(new SqlParameter("numGea", StrEncargadoTurno));
                                    try
                                    {
                                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                        sqlDataAdapter.Fill(dataSet, "STRENCARGADO_TURNO");
                                        if (dataSet.Tables["STRENCARGADO_TURNO"].Rows.Count != 0)
                                        {
                                            foreach (DataRow item in dataSet.Tables["STRENCARGADO_TURNO"].Rows)
                                            {
                                                EncargadoTurno = item[0].ToString();
                                            }
                                        }
                                        else
                                        {
                                            EncargadoTurno = string.Empty;
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    finally
                                    {
                                        dataSet.Clear();
                                        Cmd.Dispose();
                                        Connection.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            Str_detalle = Str_detalle + "X" + MtGlb.oDataRow["LANE"].ToString().Substring(0, 1) + ",";
                            //str_encargado = "Pendiente,"
                        }

                        if (EncargadoTurno == string.Empty)
                        {
                            Str_detalle = Str_detalle + EncargadoTurno + ",";
                            //No. empleado encargado de turno 	Entero 	>>>>>9 	
                            Str_detalle = Str_detalle + EncargadoTurno + ",";
                        }

                        //No. empleado Admón. Gral. 	Entero 	>>>>>9 	
                        using (SqlConnection Connection = new SqlConnection(ConnectString))
                        {
                            Connection.Open();
                            string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                            using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                            {
                                Cmd.Parameters.Add(new SqlParameter("numGea", "encargado_plaza"));
                                try
                                {
                                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                    sqlDataAdapter.Fill(dataSet, "ENCARGADO_PLAZA");
                                    if (dataSet.Tables["ENCARGADO_PLAZA"].Rows.Count != 0)
                                    {
                                        foreach (DataRow item in dataSet.Tables["ENCARGADO_PLAZA"].Rows)
                                        {
                                            EncargadoPlaza = item[0].ToString();
                                        }
                                    }
                                    else
                                    {
                                        EncargadoPlaza = string.Empty;
                                    }
                                }
                                catch (Exception ex)
                                {

                                }
                                finally
                                {
                                    dataSet.Clear();
                                    Cmd.Dispose();
                                    Connection.Close();
                                }
                            }
                        }

                        Str_detalle = Str_detalle + EncargadoPlaza + ",";

                        //No. de control de preliquidación  	Entero 	>>>9 	
                        Str_detalle = Str_detalle + ",";

                        Osw.WriteLine(Str_detalle);
                    }
                }

                //CARRILES CERRADOS DOS
                StrQuerys = "SELECT VOIE, NUM_SEQUENCE FROM SEQ_VOIE_TOD ";

                if (IdPlazaCobro == "106")
                    StrQuerys = StrQuerys + "where VOIE <> 'B04' and VOIE <> 'A03' ";

                if (MtGlb.QueryDataSet1(StrQuerys, "SEQ_VOIE_TOD"))
                {
                    for (int i = 0; i < MtGlb.Ds1.Tables["SEQ_VOIE_TOD"].Rows.Count; i++)
                    {
                        MtGlb.oDataRow1 = MtGlb.Ds1.Tables["SEQ_VOIE_TOD"].Rows[i];

                        StrQuerys = "SELECT	* FROM 	FIN_POSTE " +
                                    "WHERE	VOIE = '" + MtGlb.oDataRow1["VOIE"] + "' " +
                                    "AND ((DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                    "AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) ";

                        if (MtGlb.QueryDataSet(StrQuerys, "FIN_POSTE") == false)
                        {
                            StrQuerys = "SELECT * " +
                                        "FROM CLOSED_LANE_REPORT, SITE_GARE " +
                                        "where " +
                                        "CLOSED_LANE_REPORT.ID_PLAZA	=	SITE_GARE.id_Gare " +
                                        "AND	SITE_GARE.id_Site		=	'" + IdPlazaCobro.Substring(1, 2) + "' " +
                                        "AND	LANE		=	'" + MtGlb.oDataRow1["VOIE"] + "' " +
                                        "AND ((BEGIN_DHM >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                        "AND (BEGIN_DHM <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS'))) " +
                                        "order by BEGIN_DHM";

                            if (MtGlb.QueryDataSet(StrQuerys, "CLOSED_LANE_REPORT") == false)
                            {
                                Str_detalle = "";
                                //Fecha base de operación 	Fecha 	dd/mm/aaaa
                                Str_detalle = FechaInicio.ToString("dd/MM/yyyy") + ",";
                                //Número de turno	Entero 	9	Valores posibles: Tabla 12 - Ejemplo del Catálogo de Turnos por Plaza de Cobro.
                                Str_detalle = Str_detalle + Int_turno + ",";
                                //Hora inicial de operación 	Caracter 	hhmmss 	
                                Str_detalle = Str_detalle + _H_inicio_turno.ToString("HHmmss") + ",";
                                //Hora final de operación 	Caracter 	hhmmss 	
                                Str_detalle = Str_detalle + _H_fin_turno.AddSeconds(1).ToString("HHmmss") + ",";
                                //                        ''Número de carril 	Entero 	>>9	Valores posibles: Tabla 13 - Ejemplo del Catálogo de Carriles y Tramos por Plaza de Cobro.

                                //BUSCAR EN LA BD SQLSERVER EL CARRIL
                                using (SqlConnection Connection = new SqlConnection(ConnectString))
                                {
                                    Connection.Open();
                                    string Query = @"SELECT t.idTramo, t.nomTramo, p.idPlaza, p.nomPlaza, c.idCarril, c.numCarril, c.numTramo " +
                                                    "FROM TYPE_PLAZA p " +
                                                    "INNER JOIN TYPE_TRAMO t ON t.idTramo = p.idTramo " +
                                                    "INNER JOIN TYPE_CARRIL c ON c.idPlaza = p.idPlaza " +
                                                    "WHERE p.idTramo = @tramo and p.idPlaza = @plaza and c.idCarril = @carril ";

                                    using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                    {
                                        Cmd.Parameters.Add(new SqlParameter("tramo", Tramo));
                                        Cmd.Parameters.Add(new SqlParameter("plaza", IdPlazaCobro.Substring(1, 2)));
                                        Cmd.Parameters.Add(new SqlParameter("carril", Convert.ToString(MtGlb.oDataRow1["VOIE"]).Substring(1, 2)));
                                        try
                                        {
                                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                            sqlDataAdapter.Fill(dataSet, "CARRIL");
                                            if (dataSet.Tables["CARRIL"].Rows.Count != 0)
                                            {
                                                foreach (DataRow item in dataSet.Tables["CARRIL"].Rows)
                                                {
                                                    NumCarril = item[5].ToString();
                                                    NumTramo = item[6].ToString();
                                                    NumPlaza = item[2].ToString();
                                                }
                                            }
                                            else
                                            {
                                                NumCarril = string.Empty;
                                                NumTramo = string.Empty;
                                                NumPlaza = string.Empty;
                                            }
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                        finally
                                        {
                                            dataSet.Clear();
                                            Cmd.Dispose();
                                            Connection.Close();
                                        }
                                    }
                                }

                                if (NumPlaza == "02")
                                {
                                    if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "01")
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";
                                        Str_detalle = Str_detalle + NumCarril + ",";

                                        Str_detalle_tc = Str_detalle_tc + "261" + ",";
                                        Str_detalle_tc = Str_detalle_tc + "1803" + ",";
                                    }
                                    else if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "08")
                                    {
                                        Str_detalle = Str_detalle + "249" + ",";
                                        Str_detalle = Str_detalle + NumCarril + ",";

                                        Str_detalle_tc = Str_detalle_tc + NumTramo + ",";
                                        Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                }
                                else if (NumPlaza == "06")
                                {
                                    if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(0, 1) == "A")
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                        if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "02" || Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "04")
                                            Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                    else if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(0, 1) == "B")
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                        if (Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "01" || Convert.ToString(MtGlb.oDataRow1["Voie"]).Substring(1, 2) == "03")
                                            Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                }
                                //CARRILES SIN CAMBIO DE TRAMO: 84 , 04 , 07 , 03 , 01 , 08 , 05 , 06 , 09 , 89
                                else if (NumPlaza != string.Empty)
                                {
                                    Str_detalle = Str_detalle + NumTramo + ",";
                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }

                                //Cuerpo 	Caracter 	X(1)	Valores posibles: Tabla 13 - Ejemplo del Catálogo de Carriles y Tramos por Plaza de Cobro.
                                Str_detalle = Str_detalle + MtGlb.oDataRow1["VOIE"].ToString().Substring(0, 1) + ",";

                                //Identificador de operación	Caracter 	X(2)	Valores posibles:  Tabla 17 - Códigos de Operación por Carril.
                                Str_detalle = Str_detalle + "X" + MtGlb.oDataRow1["VOIE"].ToString().Substring(0, 1) + ",";

                                if (StrEncargadoTurno.Trim() == "")
                                    StrEncargadoTurno = "encargado_plaza";

                                //VERIFICAR EL ENCARGADO EL TURNO; SI NO ESTA, SERÁ EL ENCARGADO DE PLAZA 
                                using (SqlConnection Connection = new SqlConnection(ConnectString))
                                {
                                    Connection.Open();
                                    string Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                    using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                    {
                                        Cmd.Parameters.Add(new SqlParameter("numGea", StrEncargadoTurno));
                                        try
                                        {
                                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                            sqlDataAdapter.Fill(dataSet, "STRENCARGADO_TURNO");
                                            if (dataSet.Tables["STRENCARGADO_TURNO"].Rows.Count != 0)
                                            {
                                                foreach (DataRow item in dataSet.Tables["STRENCARGADO_TURNO"].Rows)
                                                {
                                                    EncargadoTurno = item[0].ToString();
                                                }
                                            }
                                            else
                                            {
                                                EncargadoTurno = string.Empty;
                                            }
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                        finally
                                        {
                                            dataSet.Clear();
                                            Cmd.Dispose();
                                            Connection.Close();
                                        }
                                    }

                                    //BUSCAR EL ENCARGADO DE PLAZA
                                    Connection.Open();
                                    Query = @"SELECT numCapufe FROM TYPE_OPERADORES WHERE numGea = @numGea";

                                    using (SqlCommand Cmd = new SqlCommand(Query, Connection))
                                    {
                                        Cmd.Parameters.Add(new SqlParameter("numGea", "encargado_plaza"));
                                        try
                                        {
                                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Cmd);
                                            sqlDataAdapter.Fill(dataSet, "ENCARGADO_PLAZA");
                                            if (dataSet.Tables["ENCARGADO_PLAZA"].Rows.Count != 0)
                                            {
                                                foreach (DataRow item in dataSet.Tables["ENCARGADO_PLAZA"].Rows)
                                                {
                                                    EncargadoPlaza = item[0].ToString();
                                                }
                                            }
                                            else
                                            {
                                                EncargadoPlaza = string.Empty;
                                            }
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                        finally
                                        {
                                            dataSet.Clear();
                                            Cmd.Dispose();
                                            Connection.Close();
                                        }
                                    }
                                }


                                //No. empleado C-R 	Entero 	>>>>>9	
                                Str_detalle = Str_detalle + EncargadoTurno + ",";
                                //No. empleado encargado de turno 	Entero 	>>>>>9 	
                                Str_detalle = Str_detalle + EncargadoTurno + ",";
                                //No. empleado Admón. Gral. 	Entero 	>>>>>9 	
                                Str_detalle = Str_detalle + EncargadoPlaza + ",";
                                //No. de control de preliquidación  	Entero 	>>>9 	
                                Str_detalle = Str_detalle + ",";

                                Osw.WriteLine(Str_detalle);
                            }
                        }
                    }
                }
                /************************************************/

                Osw.Flush();
                Osw.Close();

                Validar = true;
                Message = "Todo bien";
            }
            catch (Exception ex)
            {
                Validar = false;
                Message = ex.Message + ex.StackTrace;
            }

            rpt = Validar ? "OK" : "STOP";

            return rpt;
        }
    }
}