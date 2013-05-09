using System;
using System.Linq;
using System.Web.UI;
using ValidationControls.Controls;

namespace ValidationControls.FormTest
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void submit_Click(object sender, EventArgs e)
        {
            Literal1.Text = string.Empty;
            foreach (Control control in JsRegisterer1.Controls.OfType<ValidationBase>())
            {
                if (control != null)
                {
                    var field = control as ValidationBase;
                    if (!field.ValidateField())
                    {
                        Literal1.Text += string.Format("{0}: {1}" + "<br>", field.Key, field.Error);
                        break;
                    }

                    Literal1.Text += string.Format("{0}: succeed" + "<br>", field.Key);
                }
            }
        }
    }
}