using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Repository;

namespace Tugas_LAB_PSD.View
{
    public partial class InsertSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupplementTypeRepository STRepo = new SupplementTypeRepository();
            if (IsPostBack == false)
            {
                List<String> supplementTypeName = STRepo.GetSupplementTypeName(); 
                SupplementTypeDropDown.DataSource = supplementTypeName;
                SupplementTypeDropDown.DataBind();
            }
        }


        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            SupplementRepository supplementRepository = new SupplementRepository();
            SupplementTypeRepository STRepo = new SupplementTypeRepository();
            String supplementName = SuplementNameTxt.Text;
            DateTime supplementExDate = DateTime.Parse(SupplementExDateTxt.Text);
            int supplementPrice = Convert.ToInt32(SupplementPriceTxt.Text);
            String supplementDropDown = SupplementTypeDropDown.Text;
            int supplementTypeID = STRepo.GetSupplementTypeIDByName(supplementDropDown);
            supplementRepository.InsertSupplement(supplementName, supplementExDate, supplementPrice, supplementTypeID);

            Response.Redirect("~/View/ManageSupplement.aspx");
        }
    }
}