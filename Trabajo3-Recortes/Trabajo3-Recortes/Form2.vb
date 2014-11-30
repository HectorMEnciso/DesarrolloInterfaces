Imports System.IO
Imports System.Drawing.Imaging

Public Class Form2
    Dim ext As String 'Varible donde almacenamos el tipo de extension (jpeg,png,etc...)
    Dim graph As Graphics  'Creamos objeto graph de la clase Graphics para encapsular una superficie de dibujo
    Dim screenshot As System.Drawing.Bitmap 'Creamos objeto screenshot de la clase bitmap para trabajar con imágenes definidas mediante datos de píxeles
    Dim SaveFileDialog1 As New SaveFileDialog 'Definimos SaveFileDialog1 como objeto de SaveFileDialog
    Dim bmp As Bitmap
    Private Sub Form2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then 'Al presionar la tecla ESC, oculta el proceso de recorte de la pantalla y muestra formulario principal
            Me.Hide()
            Form1.Show()
        End If
    End Sub
    Private Sub Form2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Form3.Show() 'Mostramos formulario 3
        Form3.Location = Cursor.Position 'Establecemos  la esquina superior izquierda del form3 en la misma posicion que el cursor
        Form3.Location = Form3.Location
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Form3.Size = Cursor.Position - Form3.Location 'Establecemos el tamaño del formulario en funcion del movimiento del ratón.
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp 'evento que registra cuando se deja de presionar el boton izquierdo/derecho del raton
        Me.Hide() 'Ocultamos este formulario
        screenshot = New System.Drawing.Bitmap(Form3.Width, Form3.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot) 'Crea un nuevo objeto de la clase Graphics con lo que queremos dibujar
        graph.CopyFromScreen(Form3.Bounds.X, Form3.Bounds.Y, 0, 0, Bounds.Size, CopyPixelOperation.SourceCopy) 'Copiamos el contenido
        Form3.BackgroundImage = screenshot
        SaveFileDialog1.Filter = "Archivo JPEG (Joint Photographic Experts Group) (*.jpeg)|*.jpeg|Archivo PNG (Portable Network Graphics) (*.png)|*.png|Archivo GIF (Graphics Interchange Format) (*.gif)|(*.gif)|Archivo  BMP (Windows bitmap) (*.bmp)|*.bmp|Archivo TIFF (Tagged Image File Format) (*.tiff)|*.tiff| ICO file format (*.ico)|*.ico" 'Extensiones soportadas para guardar las capturas.
        SaveFileDialog1.DefaultExt = "*.jpeg" 'Extensión por defecto.
        SaveFileDialog1.Title = "Guardar captura como ..." 'Nombre por defecto de la captura.
        ' SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ext = Path.GetExtension(SaveFileDialog1.FileName).ToLower 'obtenemos la extension del archivo
            bmp = Form3.BackgroundImage
            Select Case ext 'En funcion del tipo de extension guardamos la captura
                Case ".jpeg"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg)
                Case ".png"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Png)
                Case ".gif"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Gif)
                Case ".bmp"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Bmp)
                Case ".tiff"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Tiff)
                Case ".ico"
                    bmp.Save(SaveFileDialog1.FileName, ImageFormat.Icon)
            End Select
        End If
        End
    End Sub
End Class