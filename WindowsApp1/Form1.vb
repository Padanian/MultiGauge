Public Class Form1
    Dim m1 As New MultiGauge.MultiGauge
    Dim m2 As New NumericUpDown


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With m1
            .Location = New Point(50, 50)
            .Name = "m1"
            .minimum = -4
            .maximum = 3
        End With
        Me.Controls.Add(m1)



        With m2
            .Location = New Point(150, 50)
            .Name = "m2"
            .Maximum = 3
            .Minimum = -3
            .DecimalPlaces = 1
            .Increment = 0.1
        End With

        Me.Controls.Add(m2)
        AddHandler m2.ValueChanged, AddressOf nup

    End Sub

    Private Sub nup()
        m1.value = m2.value
    End Sub

End Class
