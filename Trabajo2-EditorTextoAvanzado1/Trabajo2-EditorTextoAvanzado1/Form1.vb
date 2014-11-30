Imports System.IO
Imports System.Drawing.Printing
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Form1
    Dim cadena As String 'variable que guarda la ruta de acceso el nombre de archivo y la extensión
    Dim ruta As String 'Almacenamos ruta documento.
    Dim esGuardado As Boolean = False 'Variable que nos permite saber si un documento ha sido guardado o no.
    Dim fecha, dia As String 'Guardamos la fecha y hora actual del sistemas
    Dim posicion, linea, col As Integer 'Guardamos posicion,  número de línea y columna.
    Private Sub abrirSubMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abrirSubMenu.Click, AbrirToolStripButton.Click
        OpenFileDialog1.Filter = "Text (*.txt)|*.txt||*.rtf|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|Rich Text Files|*.rtf|All files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.FileName = OpenFileDialog1.FileName 'Abrimos dialogo de apertura de ficheros
            cadena = OpenFileDialog1.FileName 'Guardamos el nombre del archivo en la variable cadena
            txtContenido.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText) 'Cargamos el arvhivo
        End If
        ruta = Path.GetFullPath(OpenFileDialog1.FileName) + "  -Editor Texto Avanzado" 'Guardamos en ruta la ruta completa junto con el nombre y la extensión del fichero
        Me.Text = ruta 'Mostramos como título del formulario la ruta del fichero
    End Sub

    Private Sub NuevoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click, NuevoToolStripButton.Click
        txtContenido.Clear() 'Limpia el contenido del RichTextBox
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click, GuardarToolStripButton.Click
        SaveFileDialog1.Filter = "Text (*.txt)|*.txt|Rich Text Files|*.rtf|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*" 'Diferentes formatos con los que podemos guardar el documento
        SaveFileDialog1.DefaultExt = "Rich Text Files|*.rtf"
        If cadena = "" Then 'Si el documento no existía lo guardamos como (ruta,nombre y extensión)
            GuardarcomoToolStripMenuItem_Click(Nothing, Nothing)
        Else
            txtContenido.SaveFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText) 'Guardamos el contenido del RichTextBox con formato
        End If
        esGuardado = True 'Ponemos la variable a true ya que hemos guardado el documento
    End Sub

    Private Sub GuardarcomoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarcomoToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text (*.txt)|*.txt|Rich Text Files|*.rtf|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*" 'Diferentes formatos con los que podemos guardar el documento
        SaveFileDialog1.DefaultExt = "Rich Text Files|*.rtf" 'Formato de guardado por defecto
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveFileDialog1.FileName = SaveFileDialog1.FileName 'Mostramos diálogo de guardado
            txtContenido.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText) 'Guardamos el contenido del RichTextBox con formato
        End If
        esGuardado = True 'Ponemos la variable a true ya que hemos guardado el documento
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        txtContenido.Undo() 'Deshace las acciones
    End Sub

    Private Sub RehacerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click
        txtContenido.Redo() 'Rehace las acciones
    End Sub

    Private Sub CortarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click, CortarToolStripButton.Click
        txtContenido.Cut() 'Opción de cortar texto seleccionado.
    End Sub

    Private Sub CopiarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click, CopiarToolStripButton.Click
        txtContenido.Copy() 'Opción de copiado texto seleccionado
    End Sub

    Private Sub PegarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click, PegarToolStripButton.Click
        txtContenido.Paste() 'Opción de pegado texto seleccionado
    End Sub

    Private Sub SeleccionartodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtContenido.SelectAll() 'Seleccionamos todo el contenido del RichTextBox
    End Sub

    Private Sub BuscarYReemplazarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarYReemplazarToolStripMenuItem.Click, btnBuscar.Click
        frmBusqueda.Show() 'Muestra el formulario de búsqueda/reemplado de palabras.
    End Sub

    Private Sub ColorFuenteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorFuenteToolStripMenuItem.Click 'Cambiamos el color texto.
        If txtContenido.Text = String.Empty Then
            MsgBox("No hay texto para cambiar el color.Introduza texto y después proceda a cambiar su color.", 48, "Atención")
        Else
            If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtContenido.SelectionColor = ColorDialog1.Color
            End If
        End If
    End Sub

    Private Sub FuenteToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click 'Cambiamos la fuente del texto.
        If txtContenido.Text = String.Empty Then
            MsgBox("No hay texto para cambiar la fuente.Introduza texto y después proceda a cambiar su fuente.", 48, "Atención")
        Else
            If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtContenido.SelectionFont = FontDialog1.Font
            End If

        End If
    End Sub

    Private Sub ColorFondoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorFondoToolStripMenuItem.Click 'Cambiamos el color de fondo.
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtContenido.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub AcercadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercadeToolStripMenuItem.Click, AyudaToolStripButton.Click
        MsgBox("Editor de texto avanzado desarrollado para DE", 64, "Acerca de este editor...")
    End Sub
    Private Sub ReemplazarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmBusqueda.Show() 'Muestra el formulario de búsqueda/reemplado de palabras.
    End Sub

    Private Sub SelecionarTodoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelecionarTodoToolStripMenuItem.Click
        txtContenido.SelectAll() 'Selecciona todo el contenido del RichTextBox
    End Sub

    Private Sub MayúsculasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MayúsculasToolStripMenuItem.Click
        txtContenido.SelectedText = txtContenido.SelectedText.ToUpper 'Convertimos el texto seleccionado a mayúsculas
    End Sub

    Private Sub MinúsculasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MinúsculasToolStripMenuItem.Click
        txtContenido.SelectedText = txtContenido.SelectedText.ToLower 'Convertimos el texto seleccionado a minúsculas
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click 'Controlamos la salida de la aplicación teniendo en cuenta si el documento ha sido guardado o no.
        If esGuardado Then 'Si el documento ha sido guardado, salimos de la aplicación
            End
        Else
            Dim result As Integer = MsgBox("¿Quieres guardar el documento?", MsgBoxStyle.YesNo, Title:="Guardar documento")
            If result = MsgBoxResult.Yes Then
                If cadena = "" Then 'Si no existe el  documento lo guardamos especificando ruta , nombre y extensión
                    GuardarcomoToolStripMenuItem_Click(Nothing, Nothing)
                Else
                    GuardarToolStripMenuItem_Click(Nothing, Nothing) 'Si ya existía el documento guardamos los cambios y salimos de la aplicación
                End If
                End
            ElseIf result = MsgBoxResult.No Then
                End
            End If
            End
        End If
        esGuardado = True
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click, ImprimirToolStripButton.Click 'Imprime el documento actual.
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage 'Imprime el documento actual.
        e.Graphics.DrawString(txtContenido.Text, Font, Brushes.Black, 10, 10)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click 'Elimina texto
        txtContenido.SelectedText = "" 'Elimina el texto que esta seleccionado solamente.
    End Sub

    Private Sub HoraFechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HoraFechaToolStripMenuItem.Click 'Muestra la hora y fecha actual del sistema.
        fecha = Date.Now.ToString("T")
        dia = Date.Today.ToString("D")
        txtContenido.Text = dia + " " + fecha
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If esGuardado Then 'Si el documento ha sido guardado, salimos de la aplicación
            End
        Else
            Dim result As Integer = MsgBox("¿Quieres guardar el documento?", MsgBoxStyle.YesNo, Title:="Guardar documento")
            If result = MsgBoxResult.Yes Then
                If cadena = "" Then 'Si no existe el  documento lo guardamos especificando ruta , nombre y extensión
                    GuardarcomoToolStripMenuItem_Click(Nothing, Nothing)
                Else
                    GuardarToolStripMenuItem_Click(Nothing, Nothing) 'Si ya existía el documento guardamos los cambios y salimos de la aplicación
                End If
                End
            ElseIf result = MsgBoxResult.No Then
                End
            End If
            End
        End If
        esGuardado = True
    End Sub

    Private Sub IzquierdaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IzquierdaToolStripMenuItem.Click, ToolStripJustificarIzquierda.Click 'Justificamos texto a la isquierda
        txtContenido.SelectionAlignment = HorizontalAlignment.Left
        IzquierdaToolStripMenuItem.Checked = True
        CentradoToolStripMenuItem.Checked = False
        DerechaToolStripMenuItem.Checked = False
    End Sub

    Private Sub CentradoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CentradoToolStripMenuItem.Click, ToolStripButtonJustificarCentro.Click 'Justificamos texto al centro
        txtContenido.SelectionAlignment = HorizontalAlignment.Center
        IzquierdaToolStripMenuItem.Checked = False
        CentradoToolStripMenuItem.Checked = True
        DerechaToolStripMenuItem.Checked = False
    End Sub

    Private Sub DerechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DerechaToolStripMenuItem.Click, ToolStripButtonJustificarDerecha.Click 'Justificamos texto a la derecha
        txtContenido.SelectionAlignment = HorizontalAlignment.Right
        IzquierdaToolStripMenuItem.Checked = False
        CentradoToolStripMenuItem.Checked = False
        DerechaToolStripMenuItem.Checked = True
    End Sub

    Private Sub GuardarComoPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarComoPDFToolStripMenuItem.Click, btnGenerarPDF.Click 'Generamos un fichero PDF
        SaveFilePDF.Filter = "Fichero PDF|*.pdf"

        If txtContenido.Text = "" Then
            MsgBox("Debe introducir el texto a convertir a PDF.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            txtContenido.Focus()
        Else
            If txtContenido.Text = "" Then
                MsgBox("Debe indicar el fichero PDF destino de la conversión del texto.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                txtContenido.Focus()
            Else
                Try
                    If SaveFilePDF.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        SaveFilePDF.FileName = SaveFilePDF.FileName 'Mostramos diálogo de guardado

                        'Creamos el objeto documento PDF
                        Dim documentoPDF As New Document
                        PdfWriter.GetInstance(documentoPDF, New FileStream(SaveFilePDF.FileName, FileMode.CreateNew))
                        documentoPDF.Open()
                        'Escribimos el texto en el objeto documento PDF
                        documentoPDF.Add(New Paragraph(txtContenido.Text, FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL)))
                        'Añadimos los metadatos para el fichero PDF
                        documentoPDF.AddCreator("Héctor Máximo Enciso Lezcano.")

                        'Cerramos el objeto documento, guardamos y creamos el PDF
                        documentoPDF.Close()
                        'Comprobamos si se ha creado el fichero PDF
                        If System.IO.File.Exists(SaveFilePDF.FileName) Then
                            If MsgBox("Texto convertido a fichero PDF correctamente " + "¿desea abrir el fichero PDF resultante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                'Abrimos el fichero PDF con la aplicación asociada
                                System.Diagnostics.Process.Start(SaveFilePDF.FileName)
                            End If
                        Else
                            MsgBox("El fichero PDF no se ha generado, " + "compruebe que tiene permisos en la carpeta de destino.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Se ha producido un error al intentar convertir el texto a PDF: " + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
            End If
        End If
        'esGuardado = True
    End Sub

    Private Sub txtContenido_SelectionChanged(sender As Object, e As System.EventArgs) Handles txtContenido.SelectionChanged 'Controlamos numero de linea y columnas en funcion de la posicion del cursor
        posicion = txtContenido.SelectionStart 'Guardamos en posición el inicio del texto que tenemos seleccionado
        linea = txtContenido.GetLineFromCharIndex(posicion) 'Guardamos en linea el numero de linea a partir de posicion
        col = posicion - txtContenido.GetFirstCharIndexOfCurrentLine 'Guardamos en col la resta entre la posicion y el indice del primer caracter de la linea actual
        lblLineasTotales.Text = "Líneas totales: " & txtContenido.Lines.Length 'Guardamos el número de lineas totales
        lblColumna.Text = "Columna: " & (col + 1) 'Mostramos la columna en la que nos encontramos
        lblLinea.Text = "Linea: " & (linea + 1) 'Mostramos la linea en la que nos encontramos
    End Sub

    Private Sub IrAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAToolStripMenuItem.Click 'Posicionamos el cursor en una linea concreta
        Dim linea As Integer
        linea = InputBox("Introduzca número de linea al que quiere ir: ") 'Guardamos numero linea introducido a buscar
        Dim c As Long
        For c = 0 To Len(txtContenido.Text) - 1 'Recorremos todo el RichTextBox
            If txtContenido.GetLineFromCharIndex(c) >= (linea - 1) Then 'Restamos una a la linea introducida pues empieza en cero
                txtContenido.SelectionStart = c 'Posicionamos el cursor en la posicion igual a la linea introducida
                Exit For
            End If
        Next c
    End Sub

    Private Sub VistapreviadeimpresiónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VistapreviadeimpresiónToolStripMenuItem.Click 'Muestra dialogo de vista previa de impresión
        PrintPreviewDialog1.Document = PrintDocument1 'PrintPreviewDialog asociado con PrintDocument.
        PrintPreviewDialog1.ShowDialog() 'Abre vista previa de impresión
    End Sub

    Private Sub BorrarTodoToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles BorrarTodoToolStripMenuItem.Click 'Borra contenido del RichTextBox
        txtContenido.Clear()
    End Sub
End Class
