
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text = "PreInit event<br />"
        Else
            PostBackEventLabel.Text = "PreInit event<br />"
        End If
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "Init event<br />"
        Else
            PostBackEventLabel.Text &= "Init event<br />"
        End If
    End Sub

    Protected Sub Page_InitComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.InitComplete
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "InitComplete event<br />"
        Else
            PostBackEventLabel.Text &= "InitComplete event<br />"
        End If
    End Sub

    Protected Sub Page_PreLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreLoad
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "PreLoad event<br />"
        Else
            PostBackEventLabel.Text &= "PreLoad event<br />"
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "Load event<br />"
        Else
            PostBackEventLabel.Text &= "Load event<br />"
        End If
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "LoadComplete event<br />"
        Else
            PostBackEventLabel.Text &= "LoadComplete event<br />"
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "PreRender event<br />"
        Else
            PostBackEventLabel.Text &= "PreRender event<br />"
        End If
    End Sub

    Protected Sub Page_PreRenderComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRenderComplete
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "PreRenderComplete event<br />"
        Else
            PostBackEventLabel.Text &= "PreRenderComplete event<br />"
        End If
    End Sub

    Protected Sub Page_SaveStateComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SaveStateComplete
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "SaveStateComplete event<br />"
        Else
            PostBackEventLabel.Text &= "SaveStateComplete event<br />"
        End If
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        If Not Me.IsPostBack Then
            NonPostBackEventLabel.Text &= "Unload event<br />"
        Else
            PostBackEventLabel.Text &= "Unload event<br />"
        End If
    End Sub
End Class