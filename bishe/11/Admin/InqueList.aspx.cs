using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Admin_InqueList : System.Web.UI.Page
{
    SqlHelper data = new SqlHelper();
    Alert alert = new Alert();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getinfo();
        }
    }
    protected void dlinfo_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {


         
    }
    private void getinfo()
    {
        try
        {
            dlinfo.DataSource = GetCodeBy(0);
            dlinfo.DataBind();
        }
        catch
        {
        }
    }
    protected void dlinfo_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dlinfo.PageIndex = e.NewPageIndex;
        getinfo();
    }
    protected void dlinfo_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //鼠标移动变色
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            //当鼠标放上去的时候 先保存当前行的背景计量单位 并给附一计量单位 
            e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#f6f6f6',this.style.fontWeight='';");
            //当鼠标离开的时候 将背景计量单位还原的以前的计量单位 
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
        }
        //单击行改变行背景计量单位 
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", "this.style.backgroundColor='#f6f6f6'; this.style.color='buttontext';this.style.cursor='default';");
        }

    }
    public DataSet GetCodeBy(int iCount)
    {
        string strTop = "";
        if (iCount > 1)
        {
            strTop = "top " + iCount.ToString();
        }
        string name = Request.QueryString["name"].ToString();
        string Code = Request.QueryString["Code"].ToString();
        string PinPai = Request.QueryString["PinPai"].ToString();
        string XingHao = Request.QueryString["XingHao"].ToString();
        string Specification = Request.QueryString["Specification"].ToString();
        string TypeName = Request.QueryString["TypeName"].ToString();

        
        string str = "";
        string sql = str;
        sql = "select  " + strTop + "  * from [CommodityInfo] where  1=1";



        if (name != "")
        {
            sql += " and   name   like   '%" + name + "%'   ";

        }
        if (Code != "")
        {
            sql += " and   Code   like   '%" + Code + "%'   ";
        }
        if (PinPai != "")
        {
            sql += " and   PinPai   like   '%" + PinPai + "%'   ";
        }
        if (XingHao != "")
        {
            sql += " and   XingHao   like   '%" + XingHao + "%'   ";
        }
        if (Specification != "")
        {
            sql += " and   Specification   like   '%" + Specification + "%'   ";
        }
        if (TypeName != "所有分类")
        {
            sql += " and   TypeName   like   '%" + TypeName + "%'   ";
        }
    
        SqlConnection con = new SqlConnection(SqlHelper.connstring);
        SqlCommand cmd = new SqlCommand(sql, con);

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = null;
        try
        {
            con.Open();
            ds = new DataSet();
            da.Fill(ds);

        }
        catch (SqlException ex)
        {
            throw ex;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
        return ds;
    }
  
}
