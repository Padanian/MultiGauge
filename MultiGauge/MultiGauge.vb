Public Class MultiGauge
    Private Sub GaugePaint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim centreX As Double = 32
        Dim centreY As Double = 32
        Dim apen As New Pen(Color.LightGray, 1)
        Dim radius As Double = 30
        Const Pi As Double = Math.PI
        Dim x1, y1, x2, y2 As Integer
        For num As Double = -5 / 4 * Pi To 1 / 4 * Pi Step 0.02
            x1 = Convert.ToInt32(radius * Math.Cos(num) + centreX)
            y1 = Convert.ToInt32(radius * Math.Sin(num) + centreY)
            e.Graphics.DrawLine(apen, x1, y1, x1 + 1, y1)
        Next
        Dim i As Integer = 1
        For num As Double = -5 / 4 * Pi To 1 / 4 * Pi Step 1 / 8 * Pi
            x1 = Convert.ToInt32(radius * Math.Cos(num) + centreX)
            y1 = Convert.ToInt32(radius * Math.Sin(num) + centreY)
            x2 = Convert.ToInt32(3 / 4 * radius * Math.Cos(num) + centreX)
            y2 = Convert.ToInt32(3 / 4 * radius * Math.Sin(num) + centreY)

            e.Graphics.DrawLine(apen, x1, y1, x2, y2)
            Dim lblScale As New Label
            With lblScale
                .Location = New Point(x2 - 3, y2 - 3)
                .Size = New Size(10, 10)
                .Text = i.ToString.PadLeft(2, "0")
                .Font = New Font("Segoe UI", 4, FontStyle.Regular)
                .ForeColor = Color.Black
                .BackColor = Color.Transparent
                .TextAlign = ContentAlignment.TopLeft
            End With
            Me.Controls.Add(lblScale)
            i += 1
        Next
    End Sub
End Class
