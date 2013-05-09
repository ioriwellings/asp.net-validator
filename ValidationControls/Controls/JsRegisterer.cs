using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;

namespace ValidationControls.Controls
{
    [ParseChildren(true)]
    [PersistChildren(true)]
    [ToolboxData(@"<{0}:JsRegisterer runat=""server""></{0}:JsRegisterer>")]
    public class JsRegisterer : WebControl, INamingContainer
    {
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [TemplateInstance(TemplateInstance.Single)]
        public ITemplate Content { get; set; }

        protected override void OnInit(EventArgs e)
        {
            if (Content != null)
            {
                Controls.Clear();
                Content.InstantiateIn(this);
            }

            if(Controls.OfType<ValidationBase>().Any())
            {
                var script = string.Empty;
                foreach (var control in Controls.OfType<ValidationBase>())
                {
                    script += control.JavascriptMehod + "\n";
                }

                Page.ClientScript.RegisterStartupScript(GetType(), "customValidation", script, true);
            }

            base.OnInit(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            RenderChildren(writer);
        }
    }
}