Imports System.IO
Imports System.Drawing.Imaging

Public Class Form1
    Dim BM As Bitmap 'Creamos objeto BM de la clase bitmap para trabajar con imágenes definidas mediante datos de píxeles
    Dim DIBUJO As Graphics 'Creamos objeto DIBUJO de la clase Graphics para encapsular una superficie de dibujo
    Dim ext As String 'Variable donde almacenamos el tipo de extension (jpeg,png,etc...)
    Dim gr, gr2 As Graphics  'Creamos dos de la clase Graphics para encapsular una superficie de dibujo
    Dim fSize As Size  ' Varible donde almacenamos el tamaño de lo que queremos copiar

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TransparencyKey = lblContenedor.BackColor 'Hacemos que la etiqueta lblContenedor se haga transparente al cargar el formulario.
    End Sub

    Private Sub CapturarVentana_Click(sender As System.Object, e As System.EventArgs) Handles CapturarVentana.Click 'Capturamos la superficia encapsulado por la etiqueta lblContenedor.
        SaveFileDialog1.Filter = "Archivo JPEG (Joint Photographic Experts Group) (*.jpeg)|*.jpeg|Archivo PNG (Portable Network Graphics) (*.png)|*.png|Archivo GIF (Graphics Interchange Format) (*.gif)|(*.gif)|Archivo  BMP (Windows bitmap) (*.bmp)|*.bmp|Archivo TIFF (Tagged Image File Format) (*.tiff)|*.tiff| ICO file format (*.ico)|*.ico" 'Extensiones soportadas para guardar las capturas.
        SaveFileDialog1.DefaultExt = "*.jpeg" 'Extensión por defecto.
        SaveFileDialog1.Title = "Guardar captura como ..." 'Nombre por defecto de la captura.

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then 'Abrimos dialogo de guardado.
            BM = New Bitmap(lblContenedor.Width, lblContenedor.Height) 'Creamos el objeto BM con el mismo tamaño en alto y en ancho que lblContenedor
            DIBUJO = Graphics.FromImage(BM) 'Crea un nuevo objeto de la clase Graphics con lo que queremos dibujar
            DIBUJO.CopyFromScreen(Me.Location.X + lblContenedor.Location.X + 8, Me.Location.Y + lblContenedor.Location.Y + 30, 0, 0, lblContenedor.Size) 'Copiamos el contenido que se ve a traves de lblContenido
            DIBUJO.DrawImage(BM, 0, 0, BM.Width, BM.Height) 'Construimos la imagen
            ext = Path.GetExtension(SaveFileDialog1.FileName).ToLower 'Guardamos el nombre de la extensión
            Select Case ext 'En funcion del tipo de extension guardamos la captura en su formato correspondiente
                Case ".jpeg"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg)
                Case ".png"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Png)
                Case ".gif"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Gif)
                Case ".bmp"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Bmp)
                Case ".tiff"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Tiff)
                Case ".ico"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Icon)
            End Select
        End If

    End Sub

    Private Sub CapturarPantallaCompletaToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarPantallaCompleta.Click 'Capturamos pantalla completa.
        Me.Visible = False 'Ocultamos el formulario principla que evitar que salga en la captuta completa de pantalla.
        SaveFileDialog1.Filter = "Archivo JPEG (Joint Photographic Experts Group) (*.jpeg)|*.jpeg|Archivo PNG (Portable Network Graphics) (*.png)|*.png|Archivo GIF (Graphics Interchange Format) (*.gif)|(*.gif)|Archivo  BMP (Windows bitmap) (*.bmp)|*.bmp|Archivo TIFF (Tagged Image File Format) (*.tiff)|*.tiff| ICO file format (*.ico)|*.ico" 'Extensiones soportadas para guardar las capturas.
        SaveFileDialog1.DefaultExt = "*.jpeg" 'Extensión por defecto.
        SaveFileDialog1.Title = "Guardar captura como ..." 'Nombre por defecto de la captura.

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            gr = Me.CreateGraphics 'Crea el Graphics para el formulario.
            fSize = Screen.PrimaryScreen.Bounds.Size 'Establece el tamaño y la ubicación del formulario en píxeles
            BM = New Bitmap(fSize.Width, fSize.Height, gr) 'Creamos el bitmap con el área que vamos a capturar

            gr2 = Graphics.FromImage(BM)  ' 'Crea un nuevo objeto de la clase Graphics con lo que queremos dibujar

            gr2.CopyFromScreen(0, 0, 0, 0, fSize) ' Copiar todo el área de la pantalla

            lblContenedor.Image = BM   ' Asignamos la imagen al label
            ext = Path.GetExtension(SaveFileDialog1.FileName).ToLower 'obtenemos la extension del archivo
            Debug.Write("Extension" & ext & "nombre" & SaveFileDialog1.FileName) 'Guardamos el nombre de la extensión
            Select Case ext 'En funcion del tipo de extension guardamos la captura en su formato correspondiente
                Case ".jpeg"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg)
                Case ".png"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Png)
                Case ".gif"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Gif)
                Case ".bmp"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Bmp)
                Case ".tiff"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Tiff)
                Case ".ico"
                    BM.Save(SaveFileDialog1.FileName, ImageFormat.Icon)
            End Select
        End If
        End
    End Sub

    Private Sub Recorte_Click(sender As System.Object, e As System.EventArgs) Handles Recorte.Click
        Form2.Show() 'Mostramos formulario 2
        Me.Hide() 'Ocultamos formulario actual.
    End Sub
End Class
