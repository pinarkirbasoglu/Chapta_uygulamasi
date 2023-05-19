using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chapta
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //resimler sayfa yüklenir yüklenmez gelmeli yani güvenlik kodu sayfa yüklenir yüklenmez oluşturulup labela aılmalı.
            if(Page.IsPostBack ==false)//bir nesene bir olay yapıp servera gittiğinde nesnenin olayı gerçekleşmeden önce
             //sayfa  page_load(tekrar yüklenme) olur biz güvenlik kodunu sayfa ilk açıldığında bir kez oluşturup textbox da
             //girilen kod ile karşılaştırcaz doğruluğunu eğer her postbackte yeni kod oluşursa hiç bir zaman doğru olmaz
            {
                Random rstgele =new Random();
                List<int> rakamlar = new List<int>();
                string[] harfler = { "a", "b", "d", "e", "v" };
                List<string> harflerimiz = new List<string>();
                for(int i = 1; i <= 4; i++)
                {
                    rakamlar.Add(rstgele.Next(0, 9));
                }
                for(int j =1; j<=2; j++)
                {
                    harflerimiz.Add(harfler[rstgele.Next(0,4)]);
                }
                res1.ImageUrl = "img/" + rakamlar[0] + ".gif";
                res2.ImageUrl = "img/" + harflerimiz[0] + ".gif";
                res3.ImageUrl = "img/" + rakamlar[1] + ".gif";
                res4.ImageUrl = "img/" + rakamlar[2] + ".gif";
                res5.ImageUrl = "img/" + harflerimiz[1] + ".gif";
                res6.ImageUrl = "img/" + rakamlar[3] + ".gif";
                Label2.Text = rakamlar[0].ToString() + harflerimiz[0] + rakamlar[1].ToString() + rakamlar[2].ToString() + harflerimiz[1] + rakamlar[3].ToString();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == Label2.Text) Response.Redirect("Anasayfa.aspx");
            else Response.Write("güvenlik kodu doğru değil");
        }
    }
}