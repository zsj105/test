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

public partial class Admin_SearchCommodity : System.Web.UI.Page
{
    Alert alert = new Alert();
    SqlHelper data = new SqlHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = data.GetDataReader("select * from  Class  ");
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

            DropDownList1.Items.Add("所有分类");
            DropDownList1.Items[this.DropDownList1.Items.Count - 1].Value = " ";
            DropDownList1.SelectedIndex = this.DropDownList1.Items.Count - 1;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("InqueList.aspx?name=" + txtname.Text + "&Code=" + TextBox1.Text + "&PinPai=" + TextBox2.Text + "&XingHao=" + TextBox3.Text + "&Specification=" + txtSpecification.Text + "&TypeName=" + DropDownList1.SelectedItem.Text);

    }
   
}
