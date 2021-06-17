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

public partial class Admin_AddShengChan : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DropDownList3.DataSource = data.GetDataReader("select * from  Store  ");
            DropDownList3.DataTextField = "Name";
            DropDownList3.DataValueField = "id";
            DropDownList3.DataBind();
            Type();
            GetChanp();
            BinderOrder();
        }
    }
    /// <summary>
    /// 绑定类别
    /// </summary>
    private void Type()
    {
        DropDownList1.DataSource = data.GetDataReader("select * from  Class  ");
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "id";
        DropDownList1.DataBind();
        DropDownList1.Items.Add(new ListItem("选择商品类别", "0")); //动态添加新项
    }
    private void GetChanp()
    {
        DropDownList2.DataSource = data.GetDataReader("select * from  CommodityInfo where TypeName='" + DropDownList1.SelectedItem.Text + "'   ");
        DropDownList2.DataTextField = "Name";
        DropDownList2.DataValueField = "id";
        DropDownList2.DataBind();
        this.DropDownList2.Items.Insert(0, new ListItem("请选择销售商品", "0"));
    }
    private void BinderCommodityInfo()
    {

        SqlDataReader dr;
        dr = data.GetDataReader("select * from   V_KuCun where CommodityInfoId='" + DropDownList2.SelectedValue + "' and  StoreId='" + DropDownList3.SelectedValue + "'  ");
        if (dr.Read())
        {

            txtSpecification.Text = dr["Specification"].ToString();
            txtCode.Text = dr["Code"].ToString();
            txtSL.Text = dr["shuliang"].ToString();
            TextBox4.Text = dr["danjia"].ToString();
        }
        else
        {
            alert.Alertjs("没有商品信息！");
            return;
        }
    }
    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox3.Text = Convert.ToString(float.Parse(TextBox1.Text) * float.Parse(TextBox4.Text));
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        BinderCommodityInfo();



    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        BinderCommodityInfo();

    }
  
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (int.Parse(txtSL.Text) < int.Parse(TextBox1.Text))
        {
            Label3.Text = "数量不能大于库存数量";

            return;
        }
        else
        {
            SqlDataReader dr;
            dr = data.GetDataReader("select   *  from CommodityKucun where CommodityInfoId='" + DropDownList2.SelectedValue + "' and   StoreId='" + DropDownList3.SelectedValue + "'    ");
            if (dr.Read())
            {



                data.RunSql("insert into dbo.CommodityChuKu(shuliang,CManger,CommodityInfoId,SumMoeny,StoreID,ClassificationNumber,ShengYu)values(" + TextBox1.Text.Trim() + ",'" + Session["UserName"].ToString() + "','" + DropDownList2.SelectedValue + "','" + TextBox3.Text + "','" + DropDownList3.SelectedValue + "','" + DropDownList1.SelectedValue + "'," + TextBox1.Text.Trim() + ")");

                Label3.Text = "销售成功！";
            
            }
            else
            {
                Label3.Text = "当前仓库不存在商品！";

                return;

            }

        }
        BinderOrder();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetChanp();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        BinderCommodityInfo();
    }
    private void BinderOrder()
    {
        string sqlstr = "select * from  dbo.V_XS where  IsCheckout='否'    ";
        gvOrderInfo.DataKeyNames = new string[] { "id" };
        gvOrderInfo.DataSource = data.GetDataReader(sqlstr);
        gvOrderInfo.DataBind();

        SqlDataReader dr1;
        dr1 = data.GetDataReader("select id from CommodityChuKu where  IsCheckout='否'   ");
        if (dr1.Read())
        {

            string sqlstrtprice = "select sum(SumMoeny) as tprice from CommodityChuKu  where  IsCheckout='否'   ";

            SqlDataReader dr;
            dr = data.GetDataReader(sqlstrtprice);
            dr.Read();

            Label5.Text = Convert.ToString(dr["tprice"].ToString());
        }
        else
        {
             

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql1 = "insert into  Login(UserName,UserRoul,Logintime) values('" + Session["UserName"].ToString() + "','商品销售','" + DateTime.Now + "')";
        data.RunSql(sql1);
        if (TextBox3.Text == "0")
        {
            Alert.AlertAndRedirect("没有商品不能结账！", "AddXS.aspx");
        }
        else
        {
            data.RunSql("update CommodityChuKu  set IsCheckout='是',JieZhangFangShi='" + DropDownList4.SelectedValue + "'  where  IsCheckout='否'   ");
            BinderOrder();
            Alert.AlertAndRedirect("销售成功！", "AddXS.aspx");
        }


    }
}
