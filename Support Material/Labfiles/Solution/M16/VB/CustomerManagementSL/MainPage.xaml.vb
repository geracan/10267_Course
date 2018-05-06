Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PlayButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        MainMediaElement.Play()
    End Sub
End Class