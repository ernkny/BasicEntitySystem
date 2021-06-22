using Proje.Entity.Entities;
using Project.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComputerManager computerManager = new ComputerManager();
                var result = computerManager.GetCompControlManager(Convert.ToInt32(TextBox1.Text)); ;

                if (result != null)
                {
                    
                    Label2.Text = result.Model;
                    Label3.Text = result.Particular;
                    Label4.Text = result.Total.ToString();
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Ürün Bulumadı";
                }
            }
            catch (Exception)
            {
                Label1.Visible = true;
                Label1.Text = "Lütfen Ürün Numarasını giriniz";
            }
          



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Computer comp = new Computer();
                comp.Id = Convert.ToInt32(TextBox2.Text);
                comp.Model = TextBox3.Text;
                comp.Particular = TextBox4.Text;
                try { comp.Total = Convert.ToInt32(TextBox5.Text); } catch { comp.Total=Convert.ToInt32(null); } // Gözden Geçir.
               
                ComputerManager computerManager = new ComputerManager();
                Label6.Text = computerManager.UpdateControlManager(comp);

            }
            catch (Exception)
            {

                Label6.Text = "Lütfen Ürün Numarasını giriniz";
            }
          
        

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                ComputerManager computerManager = new ComputerManager();
                Label7.Text = computerManager.DeleteControlManager(Convert.ToInt32(TextBox6.Text));
            }
            catch (Exception)
            {

                Label7.Text = "Lütfen Ürün Numarasını giriniz";
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Computer comp = new Computer();
                comp.Model = TextBox7.Text;
                comp.Particular = TextBox8.Text;
                comp.Total = Convert.ToInt32(TextBox9.Text);
                ComputerManager compManager = new ComputerManager();
                Label5.Text = compManager.AddControlManager(comp);
            }
            catch (Exception)
            {

                Label5.Text = "Lütfen Bilgileri Düzgün Giriniz.";
            }
          

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            ComputerManager computerManager = new ComputerManager();
            var result=computerManager.GetAll();
            if (result!=null )
            {
                GridView1.DataSource = result;
                GridView1.DataBind();

            }
            else
            {
                Label8.Visible = true;
                Label8.Text = "İstenilen Ürünler Bulunamadı.";
            }




        }
    }
}