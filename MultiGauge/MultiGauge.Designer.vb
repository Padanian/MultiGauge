<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MultiGauge
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbLED = New System.Windows.Forms.PictureBox()
        CType(Me.pbLED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLED
        '
        Me.pbLED.Image = Global.MultiGauge.My.Resources.Resources._1024px_Location_dot_red_svg
        Me.pbLED.Location = New System.Drawing.Point(0, 54)
        Me.pbLED.Name = "pbLED"
        Me.pbLED.Size = New System.Drawing.Size(10, 10)
        Me.pbLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLED.TabIndex = 0
        Me.pbLED.TabStop = False
        Me.pbLED.Visible = False
        '
        'MultiGauge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbLED)
        Me.Name = "MultiGauge"
        Me.Size = New System.Drawing.Size(64, 64)
        CType(Me.pbLED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLED As PictureBox
End Class
