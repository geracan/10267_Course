using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text = "PreInit event<br />";
        else
            PostBackEventLabel.Text = "PreInit event<br />";
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "Init event<br />";
        else
            PostBackEventLabel.Text += "Init event<br />";
    }

    protected void Page_InitComplete(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "InitComplete event<br />";
        else
            PostBackEventLabel.Text += "InitComplete event<br />";
    }

    protected void Page_PreLoad(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "PreLoad event<br />";
        else
            PostBackEventLabel.Text += "PreLoad event<br />";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "Load event<br />";
        else
            PostBackEventLabel.Text += "Load event<br />";
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "LoadComplete event<br />";
        else
            PostBackEventLabel.Text += "LoadComplete event<br />";
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "PreRender event<br />";
        else
            PostBackEventLabel.Text += "PreRender event<br />";
    }

    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "PreRenderComplete event<br />";
        else
            PostBackEventLabel.Text += "PreRenderComplete event<br />";
    }

    protected void Page_SaveStateComplete(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "SaveStateComplete event<br />";
        else
            PostBackEventLabel.Text += "SaveStateComplete event<br />";
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            NonPostBackEventLabel.Text += "Unload event";
        else
            PostBackEventLabel.Text += "Unload event";
    }
}