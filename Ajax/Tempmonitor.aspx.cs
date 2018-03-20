using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DTSclient; 
//using Common.PCL.Utility;


public partial class Tempmonitor : System.Web.UI.Page
{
    DBHelper db = new DBHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        string type = Request["type"];
          switch (type)
           {
            case "getData":
                GetAjaxData();
                break;
           }
    }
         private void GetAjaxData()
         {
             List<Series> seriesList0 = new List<Series>();
             List<Series> seriesList1= new List<Series>();
             List<Series> seriesList2 = new List<Series>();
             List<Series> seriesList3 = new List<Series>();
             List<Series> seriesList4 = new List<Series>();
             List<Series> seriesList5 = new List<Series>();
             List<Series> seriesList6 = new List<Series>();
             List<Series> seriesList7 = new List<Series>();
             List<Series> seriesList21 = new List<Series>();
             List<Series> seriesList22 = new List<Series>();
             List<Series> seriesList41 = new List<Series>();
             List<Series> seriesList42 = new List<Series>();
             List<Series> seriesList43 = new List<Series>();
             List<Series> seriesList01 = new List<Series>();
             List<Series> seriesList11 = new List<Series>();
             List<Series> seriesList31 = new List<Series>();
             List<Series> seriesList51 = new List<Series>();
             List<Series> seriesList61 = new List<Series>();
             List<Series> seriesList71 = new List<Series>();
             List<Series> seriesList02 = new List<Series>();
             Series[] series0bj = new Series[30];
             Series[] series1bj = new Series[30];
             Series[] series2bj = new Series[30];
             Series[] series3bj = new Series[30];
             Series[] series4bj = new Series[30];
             Series[] series5bj = new Series[30];
             Series[] series6bj = new Series[30];
             Series[] series7bj = new Series[30];
             Series[] series21bj = new Series[30];
             Series[] series22bj = new Series[30];
             Series[] series41bj = new Series[30];
             Series[] series42bj = new Series[30];
             Series[] series43bj = new Series[30];
             Series[] series01bj = new Series[30];
             Series[] series11bj = new Series[30];
             Series[] series31bj = new Series[30];
             Series[] series51bj = new Series[30];
             Series[] series61bj = new Series[30];
             Series[] series71bj = new Series[30];
             Series[] series02bj = new Series[30];
             for (int j = 0; j < 5; j++)
             {
                 series0bj[j] = new Series();
                 series1bj[j] = new Series();
                 series2bj[j] = new Series();
                 series21bj[j] = new Series();
                 series22bj[j] = new Series();
                 series3bj[j] = new Series();
                 series4bj[j] = new Series();
                 series41bj[j] = new Series();
                 series42bj[j] = new Series();
                 series43bj[j] = new Series();
                 series5bj[j] = new Series();
                 series6bj[j] = new Series();
                 series7bj[j] = new Series();
                 series01bj[j] = new Series();
                 series11bj[j] = new Series();
                 series31bj[j] = new Series();
                 series51bj[j] = new Series();
                 series61bj[j] = new Series();
                 series71bj[j] = new Series();
                 series02bj[j] = new Series();


             }
           
             //连接数据库
             string database = "JFPTC";//连接的数据库名称
             string sql= "select top 1 * from "+database;
             db.OpenConnection();
             string sql1 = sql+".dbo.StData order by ID DESC ";
             SqlDataAdapter da1 = new SqlDataAdapter(sql1, db.Connection);
             DataSet ds1 = new DataSet();
             da1.Fill(ds1);
             DataTable dt1 = ds1.Tables[0];
                 series0bj[0].value = Convert.ToDouble(dt1.Rows[0][5]);//当前值
                 series01bj[0].sm = Convert.ToString(dt1.Rows[0][3]);//获取时间
                 series02bj[0].sm = Convert.ToString(dt1.Rows[0][1]);//站点号
                 seriesList0.Add(series0bj[0]);
                 seriesList01.Add(series01bj[0]);
                 seriesList02.Add(series02bj[0]);
                 //孔隙水压力

                 string sql2 = sql + ".dbo.EpData order by ID DESC ";
             SqlDataAdapter da2 = new SqlDataAdapter(sql2, db.Connection);
             DataSet ds2 = new DataSet();
             da2.Fill(ds2);
             DataTable dt2 = ds2.Tables[0];
                 series1bj[0].value = Convert.ToDouble(dt2.Rows[0][4]);
                 series11bj[0].sm = Convert.ToString(dt2.Rows[0][3]);
                 seriesList1.Add(series1bj[0]);
                 seriesList11.Add(series11bj[0]); //土压力

                 string sql3 = sql + ".dbo.DmData order by ID DESC ";
             SqlDataAdapter da3 = new SqlDataAdapter(sql3, db.Connection);
             DataSet ds3 = new DataSet();
             da3.Fill(ds3);
             DataTable dt3 = ds3.Tables[0];
                 series2bj[0].value = Convert.ToDouble(dt3.Rows[0][4]);
                 series21bj[0].value = Convert.ToDouble(dt3.Rows[0][5]);
                 series22bj[0].sm = Convert.ToString (dt3.Rows[0][3]);
                 seriesList2.Add(series2bj[0]);
                 seriesList21.Add(series21bj[0]);
                 seriesList22.Add(series22bj[0]);//内部位移

                 string sql4 = sql + ".dbo.SmcData order by ID DESC ";
             SqlDataAdapter da4 = new SqlDataAdapter(sql4, db.Connection);
             DataSet ds4 = new DataSet();
             da4.Fill(ds4);
             DataTable dt4 = ds4.Tables[0];
                 series3bj[0].value = Convert.ToDouble(dt4.Rows[0][4]);
                 series31bj[0].sm = Convert.ToString(dt4.Rows[0][3]);
                 seriesList3.Add(series3bj[0]);
                 seriesList31.Add(series31bj[0]);//土壤含水率

                 string sql5 = sql + ".dbo.MpData order by ID DESC ";
             SqlDataAdapter da5 = new SqlDataAdapter(sql5, db.Connection);
             DataSet ds5 = new DataSet();
             da5.Fill(ds5);
             DataTable dt5 = ds5.Tables[0];
                 series4bj[0].value = Convert.ToDouble(dt5.Rows[0][4]);
                 series41bj[0].value = Convert.ToDouble(dt5.Rows[0][5]);
                 series42bj[0].value = Convert.ToDouble(dt5.Rows[0][6]);
                 series43bj[0].sm = Convert.ToString(dt5.Rows[0][3]);
                 seriesList4.Add(series4bj[0]);
                 seriesList41.Add(series41bj[0]);
                 seriesList42.Add(series42bj[0]);
                 seriesList43.Add(series43bj[0]);
                //表面位移

                 string sql6 = sql + ".dbo.HumData order by ID DESC ";
             SqlDataAdapter da6 = new SqlDataAdapter(sql6, db.Connection);
             DataSet ds6 = new DataSet();
             da6.Fill(ds6);
             DataTable dt6 = ds6.Tables[0];            
                 series5bj[0].value = Convert.ToDouble(dt6.Rows[0][4]);
                 series51bj[0].sm = Convert.ToString(dt6.Rows[0][3]);
                 seriesList5.Add(series5bj[0]);
                 seriesList51.Add(series51bj[0]);//湿度

                 string sql7 = sql + ".dbo.RainfallData order by ID DESC ";
             SqlDataAdapter da7 = new SqlDataAdapter(sql7, db.Connection);
             DataSet ds7 = new DataSet();
             da7.Fill(ds7);
             DataTable dt7 = ds7.Tables[0];
                 series6bj[0].value = Convert.ToDouble(dt7.Rows[0][4]);
                 series61bj[0].sm = Convert.ToString(dt7.Rows[0][3]);
                 seriesList6.Add(series6bj[0]);
                 seriesList61.Add(series61bj[0]);//降雨量

                 string sql8 = sql + ".dbo.TmpData order by ID DESC ";
             SqlDataAdapter da8 = new SqlDataAdapter(sql8, db.Connection);
             DataSet ds8 = new DataSet();
             da8.Fill(ds8);
             DataTable dt8 = ds8.Tables[0];
                 series7bj[0].value = Convert.ToDouble(dt8.Rows[0][4]);
                 series71bj[0].sm = Convert.ToString(dt8.Rows[0][3]);
                 seriesList7.Add(series7bj[0]);
                 seriesList71.Add(series71bj[0]);//温度
             

             var newObj = new
             {
                 series0 = seriesList0,
                 series1 = seriesList1,
                 series2=seriesList2,
                 series21 = seriesList21,
                 series22 = seriesList22,
                 series3 = seriesList3,
                 series4 = seriesList4,
                 series41 = seriesList41,
                 series42 = seriesList42,
                 series43 = seriesList43,
                 series5 = seriesList5,
                 series6 = seriesList6,
                 series7 = seriesList7,
                 series01 = seriesList01,
                 series11 = seriesList11,
                 series31 = seriesList31,
                 series51 = seriesList51,
                 series61 = seriesList61,
                 series71 = seriesList71,
                 series02 = seriesList02,

             };
             //Response返回新对象的json数据
             Response.Write(newObj.ToJson());
             Response.End();
         }
         class Series
         {

             public double value
             {
                 get;
                 set;
             }
             public String sm { get; set; }
         }
}
