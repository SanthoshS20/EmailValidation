using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string emailID;
        int i,flag=0;
        int emailNameCount = 0, atSymbolCount=0,nameCount=0;
        emailID = TextBox1.Text;
        int atFlag = 0, dotSymbol=0;
        for (i = 0; i < emailID.Length; i++)
        {
            if (emailID[i] == '@')
            {
                atFlag = 1;
                atSymbolCount += 1;
                if (atSymbolCount > 1)
                {
                    flag = 1;
                    break;
                }
                if (emailNameCount < 4)
                {
                    flag = 1;
                    break;
                }
            }
            else if(emailID[i]=='.')
            {
                dotSymbol = 1;
                if (nameCount < 2)
                {
                    flag = 1;
                    break;
                }
            }
            else
            {
                if(atFlag==0)
                    emailNameCount+=1;
                else
                    nameCount+=1;
            }
        }
        if(dotSymbol==0 || atSymbolCount==0)
            flag=1;

        if (flag == 1)
            Response.Write("<script>alert('Invalid Email ID')</script>");
        else
            Response.Write("<script>alert('Valid Email ID')</script>");
    }
}
