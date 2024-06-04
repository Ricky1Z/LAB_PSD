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
    public partial class ManageSupplement : System.Web.UI.Page
    {
        public List<MsSupplement> Supplements = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            SupplementRepository supplementRepository = new SupplementRepository();
            if(IsPostBack == false)
            {
                Supplements = supplementRepository.GetSupplements();
                SupplementGV.DataSource = Supplements;
                SupplementGV.DataBind();
            }
        }

        protected void SupplementGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void SupplementGV_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void InsertSupplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertSupplement.aspx");
        }
    }
}