<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqueda
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
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnBuscarSiguente = New System.Windows.Forms.Button()
        Me.lblReemplazar = New System.Windows.Forms.Label()
        Me.txtReemplazar = New System.Windows.Forms.TextBox()
        Me.btnReemplazar = New System.Windows.Forms.Button()
        Me.btnReemplazarTodo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(40, 40)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(73, 24)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(155, 41)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(200, 23)
        Me.txtBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(375, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(190, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnBuscarSiguente
        '
        Me.btnBuscarSiguente.Location = New System.Drawing.Point(375, 51)
        Me.btnBuscarSiguente.Name = "btnBuscarSiguente"
        Me.btnBuscarSiguente.Size = New System.Drawing.Size(190, 23)
        Me.btnBuscarSiguente.TabIndex = 3
        Me.btnBuscarSiguente.Text = "Buscar Siguiente"
        Me.btnBuscarSiguente.UseVisualStyleBackColor = True
        '
        'lblReemplazar
        '
        Me.lblReemplazar.AutoSize = True
        Me.lblReemplazar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReemplazar.Location = New System.Drawing.Point(0, 86)
        Me.lblReemplazar.Name = "lblReemplazar"
        Me.lblReemplazar.Size = New System.Drawing.Size(149, 24)
        Me.lblReemplazar.TabIndex = 5
        Me.lblReemplazar.Text = "Reemplazar por:"
        '
        'txtReemplazar
        '
        Me.txtReemplazar.Location = New System.Drawing.Point(155, 87)
        Me.txtReemplazar.Multiline = True
        Me.txtReemplazar.Name = "txtReemplazar"
        Me.txtReemplazar.Size = New System.Drawing.Size(200, 23)
        Me.txtReemplazar.TabIndex = 6
        '
        'btnReemplazar
        '
        Me.btnReemplazar.Location = New System.Drawing.Point(375, 80)
        Me.btnReemplazar.Name = "btnReemplazar"
        Me.btnReemplazar.Size = New System.Drawing.Size(190, 23)
        Me.btnReemplazar.TabIndex = 7
        Me.btnReemplazar.Text = "Reemplazar/Reemplazar Siguiente"
        Me.btnReemplazar.UseVisualStyleBackColor = True
        '
        'btnReemplazarTodo
        '
        Me.btnReemplazarTodo.Location = New System.Drawing.Point(375, 109)
        Me.btnReemplazarTodo.Name = "btnReemplazarTodo"
        Me.btnReemplazarTodo.Size = New System.Drawing.Size(190, 23)
        Me.btnReemplazarTodo.TabIndex = 8
        Me.btnReemplazarTodo.Text = "ReemplazarTodo"
        Me.btnReemplazarTodo.UseVisualStyleBackColor = True
        '
        'frmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(577, 153)
        Me.Controls.Add(Me.btnReemplazarTodo)
        Me.Controls.Add(Me.btnReemplazar)
        Me.Controls.Add(Me.txtReemplazar)
        Me.Controls.Add(Me.lblReemplazar)
        Me.Controls.Add(Me.btnBuscarSiguente)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.MaximizeBox = False
        Me.Name = "frmBusqueda"
        Me.Text = "Buscar/Reemplazar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarSiguente As System.Windows.Forms.Button
    Friend WithEvents lblReemplazar As System.Windows.Forms.Label
    Friend WithEvents txtReemplazar As System.Windows.Forms.TextBox
    Friend WithEvents btnReemplazar As System.Windows.Forms.Button
    Friend WithEvents btnReemplazarTodo As System.Windows.Forms.Button
End Class
