﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace ArchivosPlanosWeb.Services
{
    public class Archivo9ARepository
    {
        string Archivo_3;
        string Carpeta = @"C:\ARCHIVOSPLANOS2\";
        string StrIdentificador = "A";
        string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
        public string Message = string.Empty;


        /// <summary>
        /// ARCHIVO 9A
        /// </summary>
        /// <param name="Str_Turno_block"></param>
        /// <param name="FechaInicio"></param>
        /// <param name="IdPlazaCobro"></param>
        /// <param name="CabeceraTag"></param>
        /// <param name="Tramo"></param>
        /// <returns></returns>
        public void eventos_detectados_y_marcados_en_el_ECT(string Str_Turno_block, DateTime FechaInicio, string IdPlazaCobro, string CabeceraTag, string Tramo)
        {
            string StrQuerys;
            string Linea = string.Empty;
            string Cabecera;
            string Numero_archivo = string.Empty;
            string Nombre_archivo = string.Empty;
            int Int_turno = 0;

            string H_inicio_turno = string.Empty;
            string H_fin_turno = string.Empty;

            string No_registros = string.Empty;

            string Str_detalle = string.Empty;

            double Dbl_registros;

            string StrClaseExcedente;
            string StrCodigoVhMarcado = string.Empty;
            string strCodigoVhPagoMarcado;

            string Tag_iag;
            string Tarjeta;

            var Val = new ArrayList();
            var NumCarril = string.Empty;
            var NumTramo = string.Empty;
            var NumPlaza = string.Empty;
            var IdCarril = string.Empty;

            MetodosGlbRepository MtGlb = new MetodosGlbRepository();

            try
            {
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

                Nombre_archivo = Nombre_archivo + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "9" + StrIdentificador;

                StreamWriter Osw = new StreamWriter(Carpeta + Nombre_archivo);

                Archivo_3 = Nombre_archivo;

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

                Cabecera = Cabecera + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "9" + StrIdentificador + FechaInicio.ToString("dd/MM/yyyy") + Int_turno;


                DateTime _H_inicio_turno = DateTime.ParseExact(H_inicio_turno, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime _H_fin_turno = DateTime.ParseExact(H_fin_turno, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                //DATE_DEBUT_POSTE
                StrQuerys = "SELECT DATE_TRANSACTION, VOIE,  EVENT_NUMBER, FOLIO_ECT, Version_Tarif, ID_PAIEMENT, " +
                            "TAB_ID_CLASSE, TYPE_CLASSE.LIBELLE_COURT1 AS CLASE_MARCADA,  NVL(TRANSACTION.Prix_Total,0) as MONTO_MARCADO, " +
                            "ACD_CLASS, TYPE_CLASSE_ETC.LIBELLE_COURT1 AS CLASE_DETECTADA, NVL(TRANSACTION.transaction_CPT1 / 100, 0) as MONTO_DETECTADO, CONTENU_ISO, CODE_GRILLE_TARIF, ID_OBS_MP, ID_OBS_TT, ISSUER_ID " +
                            "FROM TRANSACTION " +
                            "JOIN TYPE_CLASSE ON TAB_ID_CLASSE = TYPE_CLASSE.ID_CLASSE  " +
                            "LEFT JOIN TYPE_CLASSE   TYPE_CLASSE_ETC  ON ACD_CLASS = TYPE_CLASSE_ETC.ID_CLASSE " +
                            "WHERE " +
                            "(DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                            " AND  ID_PAIEMENT  <> 0 " +
                            "AND (TRANSACTION.Id_Voie = '1' " +
                            "OR TRANSACTION.Id_Voie = '2' " +
                            "OR TRANSACTION.Id_Voie = '3' " +
                            "OR TRANSACTION.Id_Voie = '4' " +
                            "OR TRANSACTION.Id_Voie = 'X') " +
                            "ORDER BY DATE_TRANSACTION";

                if (MtGlb.QueryDataSet(StrQuerys, "TRANSACTION"))
                {
                    Dbl_registros = 0;

                    for (int i = 0; i < MtGlb.Ds.Tables["TRANSACTION"].Rows.Count; i++)
                    {
                        MtGlb.oDataRow = MtGlb.Ds.Tables["TRANSACTION"].Rows[i];

                        Str_detalle = string.Empty;

                        if (!DBNull.Value.Equals(MtGlb.oDataRow["CLASE_DETECTADA"]))
                        {
                            //Fecha del evento 	Fecha 	dd/mm/aaaa 
                            Str_detalle = Convert.ToDateTime(MtGlb.oDataRow["DATE_TRANSACTION"]).ToString("dd/MM/yyyy") + ",";
                            //Número de turno	Entero 	9
                            Str_detalle = Str_detalle + Int_turno + ",";
                            //Hora de evento 	Caracter 	hhmmss 
                            Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["DATE_TRANSACTION"]).ToString("HHmmss") + ",";

                            using (SqlConnection Connection = new SqlConnection(ConnectionString))
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
                                    Cmd.Parameters.Add(new SqlParameter("carril", MtGlb.oDataRow["Voie"].ToString().Substring(1, 2)));
                                    try
                                    {
                                        SqlDataAdapter da = new SqlDataAdapter(Cmd);
                                        DataSet Ds = new DataSet();
                                        da.Fill(Ds, "CARRILES");

                                        if (Ds.Tables["CARRILES"].Rows.Count > 0)
                                        {
                                            foreach (DataRow item in Ds.Tables["CARRILES"].Rows)
                                            {
                                                NumCarril = item[5].ToString();
                                                NumPlaza = item[2].ToString();
                                                NumTramo = item[6].ToString();
                                                IdCarril = item[4].ToString();
                                            }
                                        }
                                        else
                                        {
                                            NumCarril = string.Empty;
                                            NumPlaza = string.Empty;
                                            NumTramo = string.Empty;
                                            IdCarril = string.Empty;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Message = ex.Message + " " + ex.StackTrace;
                                    }
                                    finally
                                    {
                                        Cmd.Dispose();
                                        Connection.Close();
                                    }
                                }
                            }

                            if (NumPlaza == "84")
                            {

                                if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                    Str_detalle = Str_detalle + "340" + ",";
                                else
                                    Str_detalle = Str_detalle + NumTramo + ",";

                                Str_detalle = Str_detalle + NumCarril + ",";
                            }
                            else if (NumPlaza == "02")
                            {
                                if (IdCarril == "01")
                                {
                                    if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                        Str_detalle = Str_detalle + "261" + ",";
                                    else
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }
                                else if (IdCarril == "08")
                                {
                                    if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                        Str_detalle = Str_detalle + NumTramo + ",";
                                    else
                                        Str_detalle = Str_detalle + "249" + ",";

                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + NumTramo + ",";
                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }
                            }
                            else if (NumPlaza == "06")
                            {
                                if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "A")
                                {
                                    Str_detalle = Str_detalle + NumTramo + ",";

                                    if (IdCarril == "02" || IdCarril == "04")
                                        Str_detalle = Str_detalle + NumCarril + ",";
                                }
                                else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "B")
                                {
                                    Str_detalle = Str_detalle + NumTramo + ",";

                                    if (IdCarril == "01" || IdCarril == "03")
                                        Str_detalle = Str_detalle + NumCarril + ",";
                                }
                            }
                            else if (NumPlaza != string.Empty)
                            {
                                Str_detalle = Str_detalle + NumTramo + ",";
                                Str_detalle = Str_detalle + NumCarril + ",";
                            }
                            else
                            {
                                Str_detalle = Str_detalle + ",";
                                Str_detalle = Str_detalle + ",";
                            }

                            //Cuerpo Caracter    X(1)
                            Str_detalle = Str_detalle + MtGlb.oDataRow["Voie"].ToString().Substring(0, 1) + ",";
                            //Número de evento 	Entero 	>>>>>>9
                            Str_detalle = Str_detalle + MtGlb.oDataRow["EVENT_NUMBER"] + ",";
                            //Número de folio 	Entero 	>>>>>>9 
                            Str_detalle = Str_detalle + MtGlb.oDataRow["FOLIO_ECT"] + ",";
                            //Código de vehículo detectado ECT 	Caracter 	X(6)

                            if (!DBNull.Value.Equals(MtGlb.oDataRow["CLASE_DETECTADA"]))
                            {
                                StrClaseExcedente = string.Empty;

                                if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01A")
                                    Str_detalle = Str_detalle + "T01" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01M")
                                    Str_detalle = Str_detalle + "T01" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01T")
                                    Str_detalle = Str_detalle + "T09P01" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T02B")
                                    Str_detalle = Str_detalle + "T02" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T03B")
                                    Str_detalle = Str_detalle + "T03" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T04B")
                                    Str_detalle = Str_detalle + "T04" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T02C")
                                    Str_detalle = Str_detalle + "T02" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T03C")
                                    Str_detalle = Str_detalle + "T03" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T04C")
                                    Str_detalle = Str_detalle + "T04" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T05C")
                                    Str_detalle = Str_detalle + "T05" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T06C")
                                    Str_detalle = Str_detalle + "T06" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T07C")
                                    Str_detalle = Str_detalle + "T07" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T08C")
                                    Str_detalle = Str_detalle + "T08" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T09C")
                                    Str_detalle = Str_detalle + "T09" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TL01A")
                                    Str_detalle = Str_detalle + "T01L01" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TL02A")
                                    Str_detalle = Str_detalle + "T01L02" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TLnnA")
                                    Str_detalle = Str_detalle + "T01L" + MtGlb.IIf(MtGlb.oDataRow["ID_OBS_TT"].ToString().Length == 1, "0" + MtGlb.oDataRow["ID_OBS_TT"], MtGlb.oDataRow["ID_OBS_TT"].ToString()) + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01P")
                                    Str_detalle = Str_detalle + "T01P" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TP01C")
                                    Str_detalle = Str_detalle + "T09P01" + ",";
                                else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TPnnC")
                                    Str_detalle = Str_detalle + "T09P" + MtGlb.IIf(MtGlb.oDataRow["ID_OBS_TT"].ToString().Length == 1, "0" + MtGlb.oDataRow["ID_OBS_TT"], MtGlb.oDataRow["ID_OBS_TT"].ToString()) + ",";
                                else
                                    Str_detalle = Str_detalle + "No detectada" + ",0,";
                            }
                            else
                            {
                                Str_detalle = Str_detalle + "0,";
                            }

                            //Importe vehículo detectado ECT 	Decimal 	>>9.99 
                            StrQuerys = "SELECT " +
                                        "TYPE_PAIEMENT.libelle_paiement_L2 " +
                                        ",Prix_Cl01 ,Prix_Cl02 ,Prix_Cl03 ,Prix_Cl04 ,Prix_Cl05 ,Prix_Cl06 ,Prix_Cl07 ,Prix_Cl08 ,Prix_Cl09 " +
                                        ",Prix_Cl10 ,Prix_Cl11 ,Prix_Cl12 ,Prix_Cl13 ,Prix_Cl14 ,Prix_Cl15 ,Prix_Cl16 ,Prix_Cl17 ,Prix_Cl18 " +
                                        ",Prix_Cl19, Prix_Cl20 " +
                                        ",TYPE_PAIEMENT.libelle_paiement " +
                                        ",TABLE_TARIF.CODE " +
                                        "FROM TABLE_TARIF, " +
                                        "TYPE_PAIEMENT " +
                                        "WHERE   TABLE_TARIF.CODE =	TYPE_PAIEMENT.Id_Paiement(+) ";

                            //borrar
                            StrQuerys = StrQuerys + "AND TABLE_TARIF.Version_Tarif = " + MtGlb.oDataRow["Version_Tarif"] + " " +
                                                    "AND CODE = " + MtGlb.oDataRow["ID_PAIEMENT"] + " " +
                                                    "ORDER BY TABLE_TARIF.CODE ";

                            if (MtGlb.QueryDataSet4(StrQuerys, "TABLE_TARIF"))
                            {
                                if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) > 0 && Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) <= 9)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow["MONTO_DETECTADO"] + ",,";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) >= 12 && Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) <= 15)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow["MONTO_DETECTADO"] + ",,";
                                //EXCEDENTES
                                else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) >= 10 && Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) <= 11)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) == 16)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) == 17)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) == 18)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                else
                                    Str_detalle = Str_detalle + ",,";
                            }
                            else
                                Str_detalle = Str_detalle + ",,";

                            //Importe eje excedente detectado ECT Decimal     > 9.99
                            //Código de vehículo marcado C-R	Caracter 	X(6)

                            if (!DBNull.Value.Equals(MtGlb.oDataRow["CLASE_MARCADA"]))
                            {
                                StrClaseExcedente = string.Empty;
                                StrCodigoVhMarcado = string.Empty;

                                if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T01A")
                                    Str_detalle = Str_detalle + "T01" + ",A,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T01M")
                                    Str_detalle = Str_detalle + "T01" + ",M,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T01T")
                                    Str_detalle = Str_detalle + "T09P01" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T02B")
                                    Str_detalle = Str_detalle + "T02" + ",B,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T03B")
                                    Str_detalle = Str_detalle + "T03" + ",B,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T04B")
                                    Str_detalle = Str_detalle + "T04" + ",B,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T02C")
                                    Str_detalle = Str_detalle + "T02" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T03C")
                                    Str_detalle = Str_detalle + "T03" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T04C")
                                    Str_detalle = Str_detalle + "T04" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T05C")
                                    Str_detalle = Str_detalle + "T05" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T06C")
                                    Str_detalle = Str_detalle + "T06" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T07C")
                                    Str_detalle = Str_detalle + "T07" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T08C")
                                    Str_detalle = Str_detalle + "T08" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T09C")
                                    Str_detalle = Str_detalle + "T09" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "TL01A")
                                    Str_detalle = Str_detalle + "T01L01" + ",A,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "TL02A")
                                    Str_detalle = Str_detalle + "T01L02" + ",A,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "TLnnA")
                                    Str_detalle = Str_detalle + "T01L" + MtGlb.IIf(MtGlb.oDataRow["CODE_GRILLE_TARIF"].ToString().Length == 1, "0" + MtGlb.oDataRow["CODE_GRILLE_TARIF"], MtGlb.oDataRow["CODE_GRILLE_TARIF"].ToString()) + ",A,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "T01P")
                                    Str_detalle = Str_detalle + "T01P" + ",A,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "TP01C")
                                    Str_detalle = Str_detalle + "T09P01" + ",C,";
                                else if (MtGlb.oDataRow["CLASE_MARCADA"].ToString() == "TPnnC")
                                    Str_detalle = Str_detalle + "T09P" + MtGlb.IIf(MtGlb.oDataRow["CODE_GRILLE_TARIF"].ToString().Length == 1, "0" + MtGlb.oDataRow["CODE_GRILLE_TARIF"], MtGlb.oDataRow["CODE_GRILLE_TARIF"].ToString()) + ",C,";
                                else
                                    Str_detalle = Str_detalle + "No detectada" + ",0,";
                            }
                            else
                                Str_detalle = Str_detalle + ",0,";

                            //Tipo de vehículo marcado C - R    Caracter X(1)
                            //Código de usuario pago marcado C-R	Caracter 	X(3)
                            if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 1)
                                strCodigoVhPagoMarcado = "NOR" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 2)
                                strCodigoVhPagoMarcado = "NOR" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 27)
                                strCodigoVhPagoMarcado = "VSC" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 9)
                                strCodigoVhPagoMarcado = "FCUR" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 10)
                                strCodigoVhPagoMarcado = "RPI" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 12)
                                strCodigoVhPagoMarcado = "TDC" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 14)
                                strCodigoVhPagoMarcado = "TDD" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 15)
                                strCodigoVhPagoMarcado = "IAV" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 13)
                                strCodigoVhPagoMarcado = "ELU" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 71)
                                strCodigoVhPagoMarcado = "RPI" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 72)
                                strCodigoVhPagoMarcado = "RPI" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 73)
                                strCodigoVhPagoMarcado = "RPI" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 74)
                                strCodigoVhPagoMarcado = "RPI" + ",";
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 75)
                                strCodigoVhPagoMarcado = "RSP" + ",";
                            else
                                strCodigoVhPagoMarcado = ",";

                            //Importe vehículo marcado C-R[1] Decimal >> 9.99
                            StrQuerys = "SELECT " +
                                        "TYPE_PAIEMENT.libelle_paiement_L2 " +
                                        ",Prix_Cl01 ,Prix_Cl02 ,Prix_Cl03 ,Prix_Cl04 ,Prix_Cl05 ,Prix_Cl06 ,Prix_Cl07 ,Prix_Cl08 ,Prix_Cl09 " +
                                        ",Prix_Cl10 ,Prix_Cl11 ,Prix_Cl12 ,Prix_Cl13 ,Prix_Cl14 ,Prix_Cl15 ,Prix_Cl16 ,Prix_Cl17 ,Prix_Cl18 " +
                                        ",Prix_Cl19, Prix_Cl20 " +
                                        ",TYPE_PAIEMENT.libelle_paiement " +
                                        ",TABLE_TARIF.CODE " +
                                        "FROM TABLE_TARIF, " +
                                        "TYPE_PAIEMENT " +
                                        "WHERE   TABLE_TARIF.CODE =	TYPE_PAIEMENT.Id_Paiement(+) ";

                            StrQuerys = StrQuerys + "AND TABLE_TARIF.Version_Tarif = " + MtGlb.oDataRow["Version_Tarif"] + " " +
                                                    "AND CODE = " + MtGlb.oDataRow["ID_PAIEMENT"] + " " +
                                                    "ORDER BY TABLE_TARIF.CODE ";

                            if (MtGlb.QueryDataSet4(StrQuerys, "TABLE_TARIF"))
                            {
                                if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) > 0 && Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) <= 9)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow["MONTO_MARCADO"] + ",,";
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) >= 12 && Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) <= 15)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow["MONTO_MARCADO"] + ",,";
                                    //EXCEDENTES
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) >= 10 && Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) <= 11)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) == 16)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) == 17)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["TAB_ID_CLASSE"]) == 18)
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + ",,";
                                }
                            }
                            else
                            {
                                Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                Str_detalle = Str_detalle + ",,";
                            }

                            //Importe eje excedente marcado C - R   Decimal > 9.99
                            //Número de tarjeta Pagos Electrónicos[2]	Caracter 	X(20)

                            Tag_iag = string.Empty;
                            Tarjeta = string.Empty;

                            if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 15)
                            {
                                Tag_iag = MtGlb.IIf(MtGlb.oDataRow["CONTENU_ISO"].ToString() == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "", MtGlb.oDataRow["CONTENU_ISO"].ToString().Trim());

                                Tag_iag = Tag_iag.Substring(0, 16).Trim();

                                if (Tag_iag.Length == 13 && Tag_iag.Substring(0, 3) == "009")
                                    Tag_iag = Tag_iag.Substring(0, 3) + Tag_iag.Substring(5, 8);

                                Str_detalle = Str_detalle + Tag_iag + ",";

                                Str_detalle = Str_detalle + "V" + ",";
                                Str_detalle = Str_detalle + ",";
                                Str_detalle = Str_detalle + ",";
                            }
                            else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 12 || Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 14)
                            {
                                Str_detalle = Str_detalle + MtGlb.oDataRow["ISSUER_ID"] + ",";
                                Str_detalle = Str_detalle + "V" + ",";

                                if (MtGlb.IsNumeric(MtGlb.oDataRow["CONTENU_ISO"].ToString().Substring(0, 6)))
                                {
                                    if (MtGlb.oDataRow["CONTENU_ISO"].ToString().Substring(0, 6).IndexOf("E") != 0)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow["CONTENU_ISO"].ToString().Substring(0, 6) + ",";

                                    else
                                        Str_detalle = Str_detalle + "0,";
                                }
                                else
                                    Str_detalle = Str_detalle + "0,";

                                Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["DATE_TRANSACTION"]).ToString("dd/MM/yyyy") + ",";
                            }
                            else
                            {
                                Str_detalle = Str_detalle + MtGlb.IIf(MtGlb.oDataRow["CONTENU_ISO"].ToString() == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "", "") + ",";
                                Str_detalle = Str_detalle + ",";

                                Str_detalle = Str_detalle + ",";
                                Str_detalle = Str_detalle + ",";
                            }
                        }
                        else
                        {
                            //inicio clase detectada

                            //StrQuerys = "SELECT DATE_TRANSACTION, VOIE,  EVENT_NUMBER, FOLIO_ECT, Version_Tarif, ID_PAIEMENT, " +
                            //            "TAB_ID_CLASSE, TYPE_CLASSE.LIBELLE_COURT1 AS CLASE_MARCADA,  NVL(TRANSACTION.Prix_Total,0) as MONTO_MARCADO, " +
                            //            "ACD_CLASS, TYPE_CLASSE_ETC.LIBELLE_COURT1 AS CLASE_DETECTADA, NVL(TRANSACTION.transaction_CPT1 / 100, 0) as MONTO_DETECTADO, CONTENU_ISO, CODE_GRILLE_TARIF, ID_OBS_MP, ID_OBS_TT, ISSUER_ID " +
                            //            "FROM TRANSACTION " +
                            //            "JOIN TYPE_CLASSE ON TAB_ID_CLASSE = TYPE_CLASSE.ID_CLASSE  " +
                            //            "LEFT JOIN TYPE_CLASSE   TYPE_CLASSE_ETC  ON ACD_CLASS = TYPE_CLASSE_ETC.ID_CLASSE " +
                            //            "WHERE " +
                            //            "(DATE_DEBUT_POSTE >= TO_DATE('" & Format(h_inicio_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS')) AND (DATE_DEBUT_POSTE <= TO_DATE('" & Format(h_fin_turno, "yyyyMMddHHmmss") & "','YYYYMMDDHH24MISS')) " +
                            //            "AND VOIE = '" & oDataRow("VOIE") & "' " +
                            //            "AND  ID_OBS_SEQUENCE = '7' " +
                            //            "AND EVENT_NUMBER = " & oDataRow("EVENT_NUMBER") & " " +
                            //            "AND (TRANSACTION.Id_Voie = '1' " +
                            //            "OR TRANSACTION.Id_Voie = '2' " +
                            //            "OR TRANSACTION.Id_Voie = '3' " +
                            //            "OR TRANSACTION.Id_Voie = '4' " +
                            //            "OR TRANSACTION.Id_Voie = 'X') " +
                            //            "ORDER BY DATE_TRANSACTION";


                            StrQuerys = "SELECT DATE_TRANSACTION, VOIE,  EVENT_NUMBER, FOLIO_ECT, Version_Tarif, ID_PAIEMENT, " +
                                        "TAB_ID_CLASSE, TYPE_CLASSE.LIBELLE_COURT1 AS CLASE_MARCADA,  NVL(TRANSACTION.Prix_Total,0) as MONTO_MARCADO, " +
                                        "ACD_CLASS, TYPE_CLASSE_ETC.LIBELLE_COURT1 AS CLASE_DETECTADA, NVL(TRANSACTION.transaction_CPT1 / 100, 0) as MONTO_DETECTADO, CONTENU_ISO, CODE_GRILLE_TARIF, ID_OBS_MP, ID_OBS_TT, ISSUER_ID " +
                                        "FROM TRANSACTION " +
                                        "JOIN TYPE_CLASSE ON TAB_ID_CLASSE = TYPE_CLASSE.ID_CLASSE  " +
                                        "LEFT JOIN TYPE_CLASSE   TYPE_CLASSE_ETC  ON ACD_CLASS = TYPE_CLASSE_ETC.ID_CLASSE " +
                                        "WHERE " +
                                        "(DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                                        "AND VOIE = '" + MtGlb.oDataRow["VOIE"] + "' " +
                                        "AND  ID_OBS_SEQUENCE <> '7777' " +
                                        "AND EVENT_NUMBER = " + MtGlb.oDataRow["EVENT_NUMBER"] + " " +
                                        "AND (TRANSACTION.Id_Voie = '1' " +
                                        "OR TRANSACTION.Id_Voie = '2' " +
                                        "OR TRANSACTION.Id_Voie = '3' " +
                                        "OR TRANSACTION.Id_Voie = '4' " +
                                        "OR TRANSACTION.Id_Voie = 'X') " +
                                        "ORDER BY DATE_TRANSACTION desc";

                            if (MtGlb.QueryDataSet3(StrQuerys, "TRANSACTION"))
                            {
                                Str_detalle = Convert.ToDateTime(MtGlb.oDataRow3["DATE_TRANSACTION"]).ToString("dd/MM/yyyy") + ",";
                                //Número de turno	Entero 	9
                                Str_detalle = Str_detalle + Int_turno + ",";
                                //Hora de evento 	Caracter 	hhmmss 
                                Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow3["DATE_TRANSACTION"]).ToString("HHmmss") + ",";
                                //Clave de tramo	Entero 	>9
                                //Verificar 
                                //str_detalle = str_detalle & "247" & ","
                                //Número de carril	Entero 	>>9

                                using (SqlConnection Connection = new SqlConnection(ConnectionString))
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
                                        Cmd.Parameters.Add(new SqlParameter("carril", MtGlb.oDataRow["Voie"].ToString().Substring(1, 2)));
                                        try
                                        {
                                            SqlDataAdapter da = new SqlDataAdapter(Cmd);
                                            DataSet Ds = new DataSet();
                                            da.Fill(Ds, "CARRILES");

                                            if (Ds.Tables["CARRILES"].Rows.Count > 0)
                                            {
                                                foreach (DataRow item in Ds.Tables["CARRILES"].Rows)
                                                {
                                                    NumCarril = item[5].ToString();
                                                    NumPlaza = item[2].ToString();
                                                    NumTramo = item[6].ToString();
                                                    IdCarril = item[4].ToString();
                                                }
                                            }
                                            else
                                            {
                                                NumCarril = string.Empty;
                                                NumPlaza = string.Empty;
                                                NumTramo = string.Empty;
                                                IdCarril = string.Empty;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Message = ex.Message + " " + ex.StackTrace;
                                        }
                                        finally
                                        {
                                            Cmd.Dispose();
                                            Connection.Close();
                                        }
                                    }
                                }

                                if (NumPlaza == "84")
                                {

                                    if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                        Str_detalle = Str_detalle + "340" + ",";
                                    else
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }
                                else if (NumPlaza == "02")
                                {
                                    if (IdCarril == "01")
                                    {
                                        if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                            Str_detalle = Str_detalle + "261" + ",";
                                        else
                                            Str_detalle = Str_detalle + NumTramo + ",";

                                        Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                    else if (IdCarril == "08")
                                    {
                                        if (MtGlb.oDataRow["ID_PAIEMENT"].ToString().Trim() == "2")
                                            Str_detalle = Str_detalle + NumTramo + ",";
                                        else
                                            Str_detalle = Str_detalle + "249" + ",";

                                        Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                    else
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";
                                        Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                }
                                else if (NumPlaza == "06")
                                {
                                    if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "A")
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                        if (IdCarril == "02" || IdCarril == "04")
                                            Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                    else if (Convert.ToString(MtGlb.oDataRow["Voie"]).Substring(0, 1) == "B")
                                    {
                                        Str_detalle = Str_detalle + NumTramo + ",";

                                        if (IdCarril == "01" || IdCarril == "03")
                                            Str_detalle = Str_detalle + NumCarril + ",";
                                    }
                                }
                                else if (NumPlaza != string.Empty)
                                {
                                    Str_detalle = Str_detalle + NumTramo + ",";
                                    Str_detalle = Str_detalle + NumCarril + ",";
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + ",";
                                    Str_detalle = Str_detalle + ",";
                                }

                                //Cuerpo	Caracter 	X(1)
                                Str_detalle = Str_detalle + MtGlb.oDataRow3["Voie"].ToString().Substring(0, 1) + ",";
                                //Número de evento 	Entero 	>>>>>>9


                                Str_detalle = Str_detalle + MtGlb.oDataRow3["EVENT_NUMBER"] + ",";
                                //Número de folio 	Entero 	>>>>>>9 

                                if (Convert.ToInt32(MtGlb.oDataRow3["FOLIO_ECT"]) == 0)
                                    Str_detalle = Str_detalle + MtGlb.oDataRow["FOLIO_ECT"] + ",";
                                else
                                    Str_detalle = Str_detalle + MtGlb.oDataRow3["FOLIO_ECT"] + ",";

                                //Código de vehículo detectado ECT Caracter    X(6)
                                if (!DBNull.Value.Equals(MtGlb.oDataRow3["CLASE_DETECTADA"]))
                                {
                                    StrClaseExcedente = string.Empty;

                                    if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T01A")
                                        Str_detalle = Str_detalle + "T01" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T01M")
                                        Str_detalle = Str_detalle + "T01" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T01T")
                                        Str_detalle = Str_detalle + "T09P01" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T02B")
                                        Str_detalle = Str_detalle + "T02" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T03B")
                                        Str_detalle = Str_detalle + "T03" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T04B")
                                        Str_detalle = Str_detalle + "T04" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T02C")
                                        Str_detalle = Str_detalle + "T02" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T03C")
                                        Str_detalle = Str_detalle + "T03" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T04C")
                                        Str_detalle = Str_detalle + "T04" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T05C")
                                        Str_detalle = Str_detalle + "T05" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T06C")
                                        Str_detalle = Str_detalle + "T06" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T07C")
                                        Str_detalle = Str_detalle + "T07" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T08C")
                                        Str_detalle = Str_detalle + "T08" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T09C")
                                        Str_detalle = Str_detalle + "T09" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "TL01A")
                                        Str_detalle = Str_detalle + "T01L01" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "TL02A")
                                        Str_detalle = Str_detalle + "T01L02" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "TLnnA")
                                        Str_detalle = Str_detalle + "T01L" + MtGlb.IIf(MtGlb.oDataRow3["ID_OBS_TT"].ToString().Length == 1, "0" + MtGlb.oDataRow3["ID_OBS_TT"], MtGlb.oDataRow["ID_OBS_TT"].ToString()) + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "T01P")
                                        Str_detalle = Str_detalle + "T01P" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "TP01C")
                                        Str_detalle = Str_detalle + "T09P01" + ",";
                                    else if (MtGlb.oDataRow3["CLASE_DETECTADA"].ToString() == "TPnnC")
                                        Str_detalle = Str_detalle + "T09P" + MtGlb.IIf(MtGlb.oDataRow3["ID_OBS_TT"].ToString().Length == 1, "0" + MtGlb.oDataRow3["ID_OBS_TT"], MtGlb.oDataRow["ID_OBS_TT"].ToString()) + ",";
                                    else
                                        Str_detalle = Str_detalle + "No detectada" + ",0,";
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + "0,";
                                }

                                //Importe vehículo detectado ECT  Decimal >> 9.99


                                StrQuerys = "SELECT " +
                                            "TYPE_PAIEMENT.libelle_paiement_L2 " +
                                            ",Prix_Cl01 ,Prix_Cl02 ,Prix_Cl03 ,Prix_Cl04 ,Prix_Cl05 ,Prix_Cl06 ,Prix_Cl07 ,Prix_Cl08 ,Prix_Cl09 " +
                                            ",Prix_Cl10 ,Prix_Cl11 ,Prix_Cl12 ,Prix_Cl13 ,Prix_Cl14 ,Prix_Cl15 ,Prix_Cl16 ,Prix_Cl17 ,Prix_Cl18 " +
                                            ",Prix_Cl19, Prix_Cl20 " +
                                            ",TYPE_PAIEMENT.libelle_paiement " +
                                             ",TABLE_TARIF.CODE " +
                                            "FROM TABLE_TARIF, " +
                                            "TYPE_PAIEMENT " +
                                            "WHERE   TABLE_TARIF.CODE =	TYPE_PAIEMENT.Id_Paiement(+) ";

                                //borrar
                                StrQuerys = StrQuerys + "AND TABLE_TARIF.Version_Tarif = " + MtGlb.oDataRow3["Version_Tarif"] + " " +
                                                        "AND CODE = " + MtGlb.oDataRow["ID_PAIEMENT"] + " " +
                                                        "ORDER BY TABLE_TARIF.CODE ";

                                if (MtGlb.QueryDataSet4(StrQuerys, "TABLE_TARIF"))
                                {
                                    if (Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) > 0 && Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) <= 9)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow3["MONTO_DETECTADO"] + ",,";
                                    else if (Convert.ToInt32(MtGlb.oDataRow["ACD_CLASS"]) >= 12 && Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) <= 15)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow3["MONTO_DETECTADO"] + ",,";
                                    //EXCEDENTES
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) >= 10 && Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) <= 11)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) == 16)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) == 17)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["ACD_CLASS"]) == 18)
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_DETECTADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                    else
                                        Str_detalle = Str_detalle + ",,";
                                }
                                else
                                    Str_detalle = Str_detalle + ",,";

                                //Importe eje excedente detectado ECT 	Decimal 	>9.99 
                                //Código de vehículo marcado C-R	Caracter 	X(6)

                                if (!DBNull.Value.Equals(MtGlb.oDataRow3["CLASE_MARCADA"]))
                                {
                                    StrClaseExcedente = string.Empty;
                                    StrCodigoVhMarcado = string.Empty;

                                    if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T01A")
                                        Str_detalle = Str_detalle + "T01" + ",A,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T01M")
                                        Str_detalle = Str_detalle + "T01" + ",M,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T01T")
                                        Str_detalle = Str_detalle + "T09P01" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T02B")
                                        Str_detalle = Str_detalle + "T02" + ",B,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T03B")
                                        Str_detalle = Str_detalle + "T03" + ",B,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T04B")
                                        Str_detalle = Str_detalle + "T04" + ",B,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T02C")
                                        Str_detalle = Str_detalle + "T02" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T03C")
                                        Str_detalle = Str_detalle + "T03" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T04C")
                                        Str_detalle = Str_detalle + "T04" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T05C")
                                        Str_detalle = Str_detalle + "T05" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T06C")
                                        Str_detalle = Str_detalle + "T06" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T07C")
                                        Str_detalle = Str_detalle + "T07" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T08C")
                                        Str_detalle = Str_detalle + "T08" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T09C")
                                        Str_detalle = Str_detalle + "T09" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "TL01A")
                                        Str_detalle = Str_detalle + "T01L01" + ",A,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "TL02A")
                                        Str_detalle = Str_detalle + "T01L02" + ",A,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "TLnnA")
                                        Str_detalle = Str_detalle + "T01L" + MtGlb.IIf(MtGlb.oDataRow3["CODE_GRILLE_TARIF"].ToString().Length == 1, "0" + MtGlb.oDataRow3["CODE_GRILLE_TARIF"], MtGlb.oDataRow3["CODE_GRILLE_TARIF"].ToString()) + ",A,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "T01P")
                                        Str_detalle = Str_detalle + "T01P" + ",A,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "TP01C")
                                        Str_detalle = Str_detalle + "T09P01" + ",C,";
                                    else if (MtGlb.oDataRow3["CLASE_MARCADA"].ToString() == "TPnnC")
                                        Str_detalle = Str_detalle + "T09P" + MtGlb.IIf(MtGlb.oDataRow3["CODE_GRILLE_TARIF"].ToString().Length == 1, "0" + MtGlb.oDataRow3["CODE_GRILLE_TARIF"], MtGlb.oDataRow3["CODE_GRILLE_TARIF"].ToString()) + ",C,";
                                    else
                                        Str_detalle = Str_detalle + "No detectada" + ",0,";
                                }
                                else
                                    Str_detalle = Str_detalle + ",0,";

                                //Tipo de vehículo marcado C - R    Caracter X(1)
                                //Código de usuario pago marcado C-R	Caracter 	X(3)
                                if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 1)
                                    strCodigoVhPagoMarcado = "NOR" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 2)
                                    strCodigoVhPagoMarcado = "NOR" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 27)
                                    strCodigoVhPagoMarcado = "VSC" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 9)
                                    strCodigoVhPagoMarcado = "FCUR" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 10)
                                    strCodigoVhPagoMarcado = "RPI" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 12)
                                    strCodigoVhPagoMarcado = "TDC" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 14)
                                    strCodigoVhPagoMarcado = "TDD" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 15)
                                    strCodigoVhPagoMarcado = "IAV" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 13)
                                    strCodigoVhPagoMarcado = "ELU" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 71)
                                    strCodigoVhPagoMarcado = "RPI" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 72)
                                    strCodigoVhPagoMarcado = "RPI" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 73)
                                    strCodigoVhPagoMarcado = "RPI" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 74)
                                    strCodigoVhPagoMarcado = "RPI" + ",";
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 75)
                                    strCodigoVhPagoMarcado = "RSP" + ",";
                                else
                                    strCodigoVhPagoMarcado = ",";

                                //Importe vehículo marcado C-R[1] Decimal >> 9.99
                                StrQuerys = "SELECT " +
                                            "TYPE_PAIEMENT.libelle_paiement_L2 " +
                                            ",Prix_Cl01 ,Prix_Cl02 ,Prix_Cl03 ,Prix_Cl04 ,Prix_Cl05 ,Prix_Cl06 ,Prix_Cl07 ,Prix_Cl08 ,Prix_Cl09 " +
                                            ",Prix_Cl10 ,Prix_Cl11 ,Prix_Cl12 ,Prix_Cl13 ,Prix_Cl14 ,Prix_Cl15 ,Prix_Cl16 ,Prix_Cl17 ,Prix_Cl18 " +
                                            ",Prix_Cl19, Prix_Cl20 " +
                                            ",TYPE_PAIEMENT.libelle_paiement " +
                                            ",TABLE_TARIF.CODE " +
                                            "FROM TABLE_TARIF, " +
                                            "TYPE_PAIEMENT " +
                                            "WHERE   TABLE_TARIF.CODE =	TYPE_PAIEMENT.Id_Paiement(+) ";

                                //borrar
                                StrQuerys = StrQuerys + "AND TABLE_TARIF.Version_Tarif = " + MtGlb.oDataRow3["Version_Tarif"] + " " +
                                                        "AND CODE = " + MtGlb.oDataRow["ID_PAIEMENT"] + " " +
                                                        "ORDER BY TABLE_TARIF.CODE ";


                                if (MtGlb.QueryDataSet4(StrQuerys, "TABLE_TARIF"))
                                {
                                    if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) > 0 && Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) <= 9)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow3["MONTO_MARCADO"] + ",,";
                                    }
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) >= 12 && Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) <= 15)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow3["MONTO_MARCADO"] + ",,";
                                        //EXCEDENTES
                                    }
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) >= 10 && Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) <= 11)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                    }
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) == 16)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                    }
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) == 17)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl01"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl01"])) + ",";
                                    }
                                    else if (Convert.ToInt32(MtGlb.oDataRow3["TAB_ID_CLASSE"]) == 18)
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + MtGlb.oDataRow4["Prix_Cl09"] + "," + (Convert.ToInt32(MtGlb.oDataRow3["MONTO_MARCADO"]) - Convert.ToInt32(MtGlb.oDataRow4["Prix_Cl09"])) + ",";
                                    }
                                    else
                                    {
                                        Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                        Str_detalle = Str_detalle + ",,";
                                    }
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + StrCodigoVhMarcado + strCodigoVhPagoMarcado;
                                    Str_detalle = Str_detalle + ",,";
                                }

                                //Situación de la tarjeta Pagos Electrónicos	Caracter 	X(1)
                                if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 15)
                                {
                                    Tag_iag = MtGlb.IIf(MtGlb.oDataRow3["CONTENU_ISO"].ToString() == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "", MtGlb.oDataRow3["CONTENU_ISO"].ToString().Trim());

                                    Tag_iag = Tag_iag.Substring(0, 16).Trim();

                                    if (Tag_iag.Length == 13 && Tag_iag.Substring(0, 3) == "009")
                                        Tag_iag = Tag_iag.Substring(0, 3) + Tag_iag.Substring(5, 8);

                                    Str_detalle = Str_detalle + Tag_iag + ",";

                                    Str_detalle = Str_detalle + "V" + ",";
                                    Str_detalle = Str_detalle + ",";
                                    Str_detalle = Str_detalle + ",";
                                }
                                else if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 12 || Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 14)
                                {
                                    Str_detalle = Str_detalle + MtGlb.oDataRow3["ISSUER_ID"] + ",";
                                    Str_detalle = Str_detalle + "V" + ",";

                                    if (MtGlb.IsNumeric(MtGlb.oDataRow3["CONTENU_ISO"].ToString().Substring(0, 6)))
                                    {
                                        if (MtGlb.oDataRow3["CONTENU_ISO"].ToString().Substring(0, 6).IndexOf("E") != 0)
                                            Str_detalle = Str_detalle + MtGlb.oDataRow3["CONTENU_ISO"].ToString().Substring(0, 6) + ",";

                                        else
                                            Str_detalle = Str_detalle + "0,";
                                    }
                                    else
                                        Str_detalle = Str_detalle + "0,";

                                    Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow3["DATE_TRANSACTION"]).ToString("dd/MM/yyyy") + ",";
                                }
                                else
                                {
                                    Str_detalle = Str_detalle + MtGlb.IIf(MtGlb.oDataRow3["CONTENU_ISO"].ToString() == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "", "") + ",";
                                    Str_detalle = Str_detalle + ",";

                                    Str_detalle = Str_detalle + ",";
                                    Str_detalle = Str_detalle + ",";
                                }
                            }
                        }
                        if (Str_detalle.IndexOf("-") <= 1)
                        {
                            Dbl_registros = Dbl_registros + 1;
                            Val.Add(Str_detalle);
                            //oSW.WriteLine(str_detalle)
                        }
                    }

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
                }
                else
                {
                    Cabecera = Cabecera + "00000";
                    Osw.WriteLine(Cabecera);
                    //fin detalle
                }

                foreach (var item in Val)
                {
                    Osw.WriteLine(item);
                }

                Osw.Flush();
                Osw.Close();

                Message = "Todo bien";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }
    }
}