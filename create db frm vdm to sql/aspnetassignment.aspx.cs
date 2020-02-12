using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void anu_Click(object sender, EventArgs e)
        {

            suriyaEntities6 suriya = new suriyaEntities6();
            web dad = new web();
            dad.FirstName = TextBox1.Text;
            dad.Age = int.Parse(TextBox2.Text);
            dad.LoginName = TextBox3.Text;
            dad.pwd = TextBox4.Text;
            dad.experience = int.Parse(TextBox6.Text);
            dad.sal = int.Parse(TextBox7.Text);
            suriya.webs.Add(dad);
            suriya.SaveChanges();

        }

       
    }
}