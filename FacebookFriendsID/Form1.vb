Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Facebook.Navigate("https://www.facebook.com")
    End Sub

    Private Sub timermore_Tick(sender As Object, e As EventArgs) Handles timermore.Tick
        Facebook.Document.Body.ScrollIntoView(False)
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        timermore.Enabled = True
        timermore.Interval = "1000"
        timermore.Start()
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        timermore.Enabled = False
        timermore.Stop()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtlink.TextChanged

    End Sub

    Private Sub BtnOpenLink_Click(sender As Object, e As EventArgs) Handles BtnOpenLink.Click
        Facebook.Navigate(txtlink.Text)
    End Sub

    Private Sub Facebook_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Facebook.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FBUIDS As String
        Dim Counter As Integer = 0

        Dim anchorCollection As HtmlElementCollection
        anchorCollection = Facebook.Document.GetElementsByTagName("a")
        For Each element As HtmlElement In anchorCollection

            If element.GetAttribute("data-hovercard").Contains("/ajax/hovercard/user.php?") Then

                'Getting ID URL and processing it.
                Dim GeEntireID As String = element.GetAttribute("data-hovercard")
                Dim pass1 As String = GeEntireID.Split("=")(1)
                Dim UserID As String = pass1.Split("&"c)(0)

                Dim friends As String = element.InnerText

                If friends <> "" Then
                    FBUIDS = FBUIDS + UserID & ","
                    richfbtags.Text = richfbtags.Text & "@[" & UserID & ":]" & vbNewLine
                    Counter = Counter + 1
                End If
            End If
        Next

        txtfbids.Text = FBUIDS

        MsgBox(Counter.ToString)

    End Sub
End Class
