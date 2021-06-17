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
using System.Drawing;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

public partial class Manager_CheckImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckImage(GetCode(4));      
    }
    //返回验证码的位数
    protected string GetCode(int i) {

        Random ran = new Random();
        string strCode = string.Empty;
        string[] str ={ "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        for (int j = 0; j < i; j++) {

            strCode += str[ran.Next(str.Length)];
        
        }
        Session["CheckCode"] = strCode;
        return strCode;
        
    }
    protected void CheckImage(string nCode) {

        Random ran=new Random();
        Bitmap img = new Bitmap(120, 24);
        Graphics g = Graphics.FromImage(img);
        g.Clear(System.Drawing.Color.White);
        for (int i = 0; i < 30; i++) {

            g.DrawLine(Pens.Gainsboro, new Point(ran.Next(img.Width), ran.Next(img.Height)), new Point(ran.Next(img.Height),ran.Next(img.Width)));
        
        }
        //验证码图片边框字体等
        g.DrawRectangle(Pens.White, new Rectangle(0, 0, 69, 23));
        Font font = new Font("Arail", 12, FontStyle.Bold);
        g.DrawString(nCode, font, Brushes.Black, new Point(5, 4));
        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        Response.ClearContent();
        Response.ContentType = "Image/Gif";
        Response.BinaryWrite(ms.ToArray());
    
    }
}
