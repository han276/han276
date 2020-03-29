Public Class Form1
    Private i As Integer
    Private j As Integer
    Private turn As Integer
    Dim blackpoint As New List(Of Integer)
    Dim whitepoint As New List(Of Integer)
    Dim blacksum As Integer
    Dim whitesum As Integer
    Private Function colorchange(ByVal j As Integer) As Integer

        If (Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And
                                                               Button1.BackColor = Color.White And Button4.BackColor = Color.White And i = 4) Then
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
            whitepoint.Add(2)
            blackpoint.Add(-2)
        End If

        ' If (Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And
        'Button1.BackColor = Color.White And Button3.BackColor = Color.White And i = 3) Then
        'Button2.BackColor = Color.White
        'End If

        If (Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And
                       Button2.BackColor = Color.White And Button4.BackColor = Color.White And i = 3) Then
            Button3.BackColor = Color.White
            whitepoint.Add(1)
            blackpoint.Add(-1)
        End If

        ' If (Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And
        'Button1.BackColor = Color.Black And Button4.BackColor = Color.Black) Then
        'Button2.BackColor = Color.Black
        'Button3.BackColor = Color.Black
        'End If

        If (Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And
                 Button1.BackColor = Color.Black And Button3.BackColor = Color.Black And i = 3) Then
            Button2.BackColor = Color.Black
            blackpoint.Add(1)
            whitepoint.Add(-1)
        End If

        If (Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And
                       Button2.BackColor = Color.Black And Button4.BackColor = Color.Black And i = 3) Then
            Button3.BackColor = Color.Black
            blackpoint.Add(1)
            whitepoint.Add(-1)
        End If

        Return j

    End Function

    Private Sub button_click(ByVal sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        i = i + 1
        turn = i Mod 2

        Label1.Text = Int(i)
        If turn = 1 And (DirectCast(sender, Button).Enabled) Then
            DirectCast(sender, Button).Enabled = False
            DirectCast(sender, Button).BackColor = Color.Black
            blackpoint.Add(1)
        End If

        If turn = 0 And (DirectCast(sender, Button).Enabled) Then
            DirectCast(sender, Button).Enabled = False
            DirectCast(sender, Button).BackColor = Color.White
            whitepoint.Add(1)
        End If



        colorchange(j)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green

        whitepoint.Clear()
        blackpoint.Clear()
        TextBox1.Text = ""

        i = 0
        Label1.Text = Int(i)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        whitesum = whitepoint.Sum
        blacksum = blackpoint.Sum

        If whitesum = blacksum Then
            TextBox1.Text = "引き分け"
        End If

        If whitesum > blacksum Then
            TextBox1.Text = "白の勝ち"
        End If

        If whitesum < blacksum Then
            TextBox1.Text = "黒の勝ち"
        End If
    End Sub
    
    ''' <summary>
    ''' fushiana 修正版
    ''' </summary>
    'Private i As Integer
    'Dim buttons As List(Of Button)

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    buttons = New List(Of Button) From {
    '        Button1,
    '        Button2,
    '        Button3,
    '        Button4
    '    }
    'End Sub

    'Private Sub button_click(ByVal sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
    '    DirectCast(sender, Button).Enabled = False

    '    i += 1
    '    Label1.Text = i.ToString()
    '    Dim clickedButton = DirectCast(sender, Button)

    '    If (i Mod 2) = 1 And clickedButton.Enabled Then
    '        clickedButton.BackColor = Color.Black
    '    Else
    '        clickedButton.BackColor = Color.White
    '    End If
    '    ButtonColorCcheck(clickedButton)
    'End Sub


    'Private Sub ButtonColorCcheck(clickedButton As Button)
    '    Dim clickedButtons = buttons.Where(Function(x) x.Enabled = False And x.BackColor = clickedButton.BackColor).ToList()

    '    Dim firstButton = buttons.FindIndex(Function(x) x.BackColor = clickedButton.BackColor)
    '    Dim latestButton = buttons.FindLastIndex(Function(x) x.BackColor = clickedButton.BackColor)

    '    ButtonColorChenge(firstButton, latestButton, clickedButton.BackColor)
    'End Sub


    'Private Sub ButtonColorChenge(fromPosition As Integer, toPosition As Integer, backColor As Color)
    '    Dim targetButtons = buttons.GetRange(fromPosition, toPosition - fromPosition)
    '    For Each item In targetButtons
    '        item.BackColor = backColor
    '    Next
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    For Each item In buttons
    '        item.Enabled = True
    '        item.BackColor = Color.Green
    '    Next

    '    i = 0

    '    TextBox1.Text = String.Empty
    '    Label1.Text = i.ToString()
    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    Dim whitesum = buttons.Where(Function(x) x.BackColor = Color.White).ToList.Count
    '    Dim blacksum = buttons.Where(Function(x) x.BackColor = Color.Black).ToList.Count

    '    If whitesum = blacksum Then
    '        TextBox1.Text = "引き分け"
    '        Return
    '    End If

    '    If whitesum > blacksum Then
    '        TextBox1.Text = "白の勝ち"
    '        Return
    '    End If

    '    If whitesum < blacksum Then
    '        TextBox1.Text = "黒の勝ち"
    '        Return
    '    End If
    'End Sub
End Class



