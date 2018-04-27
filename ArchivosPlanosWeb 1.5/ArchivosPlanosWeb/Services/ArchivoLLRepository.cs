using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ArchivosPlanosWeb.Services
{
    public class ArchivoLLRepository
    {

        private MetodosGlbRepository MtGlb = new MetodosGlbRepository();

        string ConnectString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
        string Archivo_5;
        string Carpeta = @"C:\ARCHIVOSPLANOS2\";
        public string Message = string.Empty;

        /// <summary>
        /// ARCHIVO LL
        /// </summary>
        /// <param name="Str_Turno_block"></param>
        /// <param name="FechaInicio"></param>
        /// <param name="IdPlazaCobro"></param>
        /// <param name="CabeceraTag"></param>
        /// <param name="Tramo"></param>
        /// <returns></returns>
        public void Registro_usuarios_telepeaje(string Str_Turno_block, DateTime FechaInicio, string IdPlazaCobro, string CabeceraTag, string Tramo)
        {
            string StrQuerys;
            string Cabecera;
            string Nombre_archivo = string.Empty;
            int Int_turno = 0;
            string H_inicio_turno = string.Empty;
            string H_fin_turno = string.Empty;
            string No_registros = string.Empty;
            string Str_detalle;
            double Dbl_registros;
            string StrClaseExcedente;
            string Tag_iag;

            string LenText;
            int KeyAscii;
            bool Validar = false;
            var Val = new ArrayList();

            var dataSet = new DataSet();
            var IdCarril = string.Empty;
            var NumCarril = string.Empty;
            var NumPlaza = string.Empty;
            var NumTramo = string.Empty;

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

                Nombre_archivo = Nombre_archivo + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "II";

                System.IO.StreamWriter Osw = new System.IO.StreamWriter(Carpeta + Nombre_archivo);

                Archivo_5 = Nombre_archivo;


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

                Cabecera = Cabecera + FechaInicio.ToString("MM") + FechaInicio.ToString("dd") + "." + Int_turno + "II" + FechaInicio.ToString("dd/MM/yyyy") + Int_turno;

                //CABECERA INICIO REGISTROS

                //CABECERA FIN
                //inicio detalle

                DateTime _H_inicio_turno = DateTime.ParseExact(H_inicio_turno, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime _H_fin_turno = DateTime.ParseExact(H_fin_turno, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                StrQuerys = "SELECT DATE_TRANSACTION, VOIE,  EVENT_NUMBER, FOLIO_ECT, Version_Tarif, ID_PAIEMENT, " +
                            "TAB_ID_CLASSE, TYPE_CLASSE.LIBELLE_COURT1 AS CLASE_MARCADA,  NVL(TRANSACTION.Prix_Total,0) as MONTO_MARCADO, " +
                            "ACD_CLASS, TYPE_CLASSE_ETC.LIBELLE_COURT1 AS CLASE_DETECTADA, NVL(TRANSACTION.transaction_CPT1 / 100, 0) as MONTO_DETECTADO, CONTENU_ISO, CODE_GRILLE_TARIF, ID_OBS_MP, ID_OBS_TT, ISSUER_ID " +
                            "FROM TRANSACTION " +
                            "JOIN TYPE_CLASSE ON TAB_ID_CLASSE = TYPE_CLASSE.ID_CLASSE  " +
                            "LEFT JOIN TYPE_CLASSE   TYPE_CLASSE_ETC  ON ACD_CLASS = TYPE_CLASSE_ETC.ID_CLASSE " +
                            "WHERE " +
                            "(DATE_DEBUT_POSTE >= TO_DATE('" + _H_inicio_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) AND (DATE_DEBUT_POSTE <= TO_DATE('" + _H_fin_turno.ToString("yyyyMMddHHmmss") + "','YYYYMMDDHH24MISS')) " +
                            " AND  (ID_PAIEMENT  = 15 or ID_OBS_MP = 30) " +
                            "AND (TRANSACTION.Id_Voie = '1' " +
                            "OR TRANSACTION.Id_Voie = '2' " +
                            "OR TRANSACTION.Id_Voie = '3' " +
                            "OR TRANSACTION.Id_Voie = '4' " +
                            "OR TRANSACTION.Id_Voie = 'X')  AND (MODE_REGLEMENT = 'IAV ')  " +
                            "ORDER BY DATE_TRANSACTION";

                if (MtGlb.QueryDataSet(StrQuerys, "TRANSACTION"))
                {
                    Dbl_registros = 0;

                    for (int i = 0; i < MtGlb.Ds.Tables["TRANSACTION"].Rows.Count; i++)
                    {
                        MtGlb.oDataRow = MtGlb.Ds.Tables["TRANSACTION"].Rows[i];

                        Str_detalle = string.Empty;

                        //while (!DBNull.Value.Equals(MtGlb.oDataRow["CLASE_DETECTADA"]))
                        //{
                        Str_detalle = Convert.ToDateTime(MtGlb.oDataRow["DATE_TRANSACTION"]).ToString("dd/MM/yyyy") + ",";

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
                                Cmd.Parameters.Add(new SqlParameter("carril", MtGlb.oDataRow["Voie"].ToString().Substring(1, 2)));
                                try
                                {
                                    SqlDataAdapter Da = new SqlDataAdapter(Cmd);
                                    Da.Fill(dataSet, "CARRILES");

                                    if (dataSet.Tables["CARRILES"].Rows.Count > 0)
                                    {
                                        foreach (DataRow item in dataSet.Tables["CARRILES"].Rows)
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


                        //Hora de evento 	Caracter 	hhmmss 
                        Str_detalle = Str_detalle + Convert.ToDateTime(MtGlb.oDataRow["DATE_TRANSACTION"]).ToString("HHmmss") + ",";



                        //numero tarjeta iave
                        Validar = true;
                        Tag_iag = MtGlb.IIf(MtGlb.oDataRow["CONTENU_ISO"].ToString().Trim() == "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", "", MtGlb.oDataRow["CONTENU_ISO"].ToString().TrimStart());

                        Tag_iag = Tag_iag.Substring(0, 14).Trim();

                        if (Tag_iag.Length == 13 && Tag_iag.Substring(0, 3) == "009")
                            Tag_iag = Tag_iag.Substring(0, 3) + Tag_iag.Substring(5, 8);

                        LenText = Tag_iag.Length.ToString();

                        for (int c = 0; c < Convert.ToInt32(LenText); c++)
                        {
                            KeyAscii = (int)Convert.ToChar(Tag_iag.Substring(c, 1));
                            if ((KeyAscii >= 33) && (KeyAscii <= 47) || (KeyAscii >= 58) && (KeyAscii <= 64) || (KeyAscii >= 91) && (KeyAscii <= 96) || (KeyAscii >= 123) && (KeyAscii <= 126))
                            {
                                Validar = false;
                                KeyAscii = 8;
                            }
                        }

                        Str_detalle = Str_detalle + Tag_iag.Trim() + ",";

                        //situacion tarjeta iave
                        if (Convert.ToInt32(MtGlb.oDataRow["ID_PAIEMENT"]) == 15)
                            Str_detalle = Str_detalle + "V" + ",";
                        else
                            Str_detalle = Str_detalle + "I" + ",";

                        //clave transportsta iave
                        Str_detalle = Str_detalle + ",";

                        //clase vehiculo iave
                        Str_detalle = Str_detalle + ",";

                        //importe usuario iave
                        Str_detalle = Str_detalle + MtGlb.oDataRow["MONTO_DETECTADO"] + ",";

                        //numero de evento ect
                        Str_detalle = Str_detalle + MtGlb.oDataRow["EVENT_NUMBER"] + ",";

                        //Número de turno	Entero 	9
                        Str_detalle = Str_detalle + Int_turno + ",";

                        //numero de ejes segun ect
                        if (!DBNull.Value.Equals(MtGlb.oDataRow["CLASE_DETECTADA"]))
                        {
                            StrClaseExcedente = string.Empty;

                            if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01A")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01M")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01T")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T02B")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T03B")
                            {
                                Str_detalle = Str_detalle + "3" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T04B")
                            {
                                Str_detalle = Str_detalle + "4" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T02C")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T03C")
                            {
                                Str_detalle = Str_detalle + "3" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T04C")
                            {
                                Str_detalle = Str_detalle + "4" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T05C")
                            {
                                Str_detalle = Str_detalle + "5" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T06C")
                            {
                                Str_detalle = Str_detalle + "6" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T07C")
                            {
                                Str_detalle = Str_detalle + "7" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T08C")
                            {
                                Str_detalle = Str_detalle + "8" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T09C")
                            {
                                Str_detalle = Str_detalle + "9" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TL01A")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TL02A")
                            {
                                Str_detalle = Str_detalle + "2" + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TLnnA")
                            {
                                Str_detalle = Str_detalle + MtGlb.oDataRow["ID_OBS_TT"] + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "T01P")
                            {
                                Str_detalle = Str_detalle + "1" + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TP01C")
                            {
                                Str_detalle = Str_detalle + "9" + ",";
                                Str_detalle = Str_detalle + "L";
                            }
                            else if (MtGlb.oDataRow["CLASE_DETECTADA"].ToString() == "TPnnC")
                            {
                                Str_detalle = Str_detalle + MtGlb.oDataRow["ID_OBS_TT"] + ",";
                                Str_detalle = Str_detalle + "P";
                            }
                            else
                                Str_detalle = Str_detalle + "No detectada" + ",0,";
                        }
                        else
                        {
                            Str_detalle = Str_detalle + "0,";
                        }
                        //II Fin

                        //fin clase detectada
                        if (Validar)
                        {
                            Dbl_registros = Dbl_registros + 1;
                            Val.Add(Str_detalle);

                            //oSW.WriteLine(str_detalle)
                            //----------------------
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
                }
                //fin detalle

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