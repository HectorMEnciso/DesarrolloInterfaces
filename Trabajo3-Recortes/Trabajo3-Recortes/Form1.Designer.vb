<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CapturarVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturarPantallaCompleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recorte = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblContenedor = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturarVentana, Me.CapturarPantallaCompleta, Me.Recorte})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CapturarVentana
        '
        Me.CapturarVentana.BackColor = System.Drawing.Color.DarkGray
        Me.CapturarVentana.Name = "CapturarVentana"
        Me.CapturarVentana.Size = New System.Drawing.Size(61, 20)
        Me.CapturarVentana.Text = "Captura"
        '
        'CapturarPantallaCompleta
        '
        Me.CapturarPantallaCompleta.Name = "CapturarPantallaCompleta"
        Me.CapturarPantallaCompleta.Size = New System.Drawing.Size(165, 20)
        Me.CapturarPantallaCompleta.Text = "Capturar Pantalla Completa"
        '
        'Recorte
        '
        Me.Recorte.Name = "Recorte"
        Me.Recorte.Size = New System.Drawing.Size(59, 20)
        Me.Recorte.Text = "Recorte"
        '
        'lblContenedor
        '
        Me.lblContenedor.BackColor = System.Drawing.Color.White
        Me.lblContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblContenedor.Location = New System.Drawing.Point(0, 24)
        Me.lblContenedor.Name = "lblContenedor"
        Me.lblContenedor.Size = New System.Drawing.Size(497, 238)
        Me.lblContenedor.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 262)
        Me.Controls.Add(Me.lblContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recortes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CapturarVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturarPantallaCompleta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Recorte As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblContenedor As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
