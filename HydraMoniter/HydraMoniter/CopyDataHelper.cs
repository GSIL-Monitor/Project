using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace HydraMoniter
{
    public class Task
    {

        public static void CopyFinishData()
        {
            string FromConnectionString = ConfigurationManager.AppSettings["fromdatabase"];
            string ToConnectionString = ConfigurationManager.AppSettings["todatabase"];
            DbUtility Fromdb = new DbUtility(FromConnectionString, DbProviderType.SqlServer);
            DbUtility Todb = new DbUtility(ToConnectionString, DbProviderType.SqlServer);

            int ToRowCount = 0;
            int FromRowCount = 0;
            try
            {
                string str = "";
                str = " select ab_aunr.aunr, ";
                str += " ab_aunr.soll_menge_pri,";
                str += "       ab_aunr.artikel,";
                str += "       ab_aunr.user_f_23,";
                str += "       ab_aunr.user_f_24,";
                str += "       ab_aunr.user_f_25,";
                str += "       ab_anr.auftrag_nr, ";
                str += "       ab_anr.ag_bez,";
                str += "       as_anr.gut_pri,";
                str += "       as_anr.aus_pri, ";
                str += "       as_anr.a_status ";
                str += "  from auftrag_status as_anr";
                str += " inner join auftrags_bestand ab_anr";
                str += "    on ab_anr.a_typ = 'AG'";
                str += "    and ab_anr.auftrag_nr = as_anr.auftrag_nr";
                str += "    inner join auftrags_bestand ab_aunr";
                str += "    on ab_aunr.a_typ = 'AU'";
                str += "    and ab_aunr.auftrag_nr = ab_anr.aunr";
                str += " where as_anr.a_typ = 'AG'and a_status='E'";
                str += " and Convert(nvarchar(10),ab_aunr.frueh_anf_dat,120)='" + DateTime.Now.ToShortDateString() + "'";
                DataTable FromDataTable = Fromdb.ExecuteDataTable(str);
                FromRowCount = FromDataTable.Rows.Count;   
                Log.Write(string.Format("{0} Row(s) Results", FromRowCount));
                foreach (DataRow gDr in FromDataTable.Rows)
                {
                    //将数据复制到新表内
                    str = " INSERT INTO AIP_Record";
                    str += " (MOCODE, IQTY, CPRODUCT, PLY, WIDTH, LENTH, CWORKSTEP, IQCQTY, IUNQCQTY, STATUS)";
                    str += " VALUES   (";
                    str += "'" + gDr["aunr"] + "',";
                    str += "'" + gDr["soll_menge_pri"] + "',";
                    str += "'" + gDr["artikel"] + "',";
                    str += "'" + gDr["user_f_23"] + "',";
                    str += "'" + gDr["user_f_24"] + "',";
                    str += "'" + gDr["user_f_25"] + "',";
                    str += "'" + gDr["ag_bez"] + "',";
                    str += "'" + gDr["gut_pri"] + "',";
                    str += "'" + gDr["aus_pri"] + "',";
                    str += "'" + gDr["a_status"] + "')";
                    ToRowCount += Todb.ExecuteNonQuery(str, null);
                    Log.Write(string.Format("Execute SQL : {0}", str));
                    Log.Write(string.Format("{0} Row(s) Inserted", ToRowCount));
                }
            }
            catch (Exception ex)
            {
                Log.Write("ERROR : " + ex.Message);
            }
            finally
            {
                Log.Write("Finished");
            }
        }



    }
}
