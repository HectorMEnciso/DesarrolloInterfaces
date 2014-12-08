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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PersonasDataSet = New Enciso_Agenda.PersonasDataSet()
        Me.NacimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NacimientosTableAdapter = New Enciso_Agenda.PersonasDataSetTableAdapters.NacimientosTableAdapter()
        Me.TableAdapterManager = New Enciso_Agenda.PersonasDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PersonasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NacimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonasDataSet
        '
        Me.PersonasDataSet.DataSetName = "PersonasDataSet"
        Me.PersonasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NacimientosBindingSource
        '
        Me.NacimientosBindingSource.DataMember = "Nacimientos"
        Me.NacimientosBindingSource.DataSource = Me.PersonasDataSet
        '
        'NacimientosTableAdapter
        '
        Me.NacimientosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NacimientosTableAdapter = Me.NacimientosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Enciso_Agenda.PersonasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(602, 331)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cumpleaños"
        CType(Me.PersonasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NacimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersonasDataSet As Enciso_Agenda.PersonasDataSet
    Friend WithEvents NacimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NacimientosTableAdapter As Enciso_Agenda.PersonasDataSetTableAdapters.NacimientosTableAdapter
    Friend WithEvents TableAdapterManager As Enciso_Agenda.PersonasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
