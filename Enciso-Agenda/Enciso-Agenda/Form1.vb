Public Class Form1
    Dim fechaActual As New DateTimePicker 'Variable DateTimePicker para saber fecha actual
    Dim newLbl As Label 'Variable para generar nuevos labels
    Dim fechaActual1, SieteDiasMenos, QuinceDiasMas, fechaPrueba, fechaPrueba2, fechaPrueba3 As Date 'Variables donde almacenamos la fecha actual, las fechas de hace 7 dias y las proximas 15
    Private Sub NacimientosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.NacimientosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PersonasDataSet)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PersonasDataSet.Nacimientos' Puede moverla o quitarla según sea necesario.
        Me.NacimientosTableAdapter.Fill(Me.PersonasDataSet.Nacimientos)

        Label1.Text = "Hoy es " & fechaActual.Value.ToString("dddd") & ", " & fechaActual.Value.ToString("dd") & " de " & fechaActual.Value.ToString("MMMM") & " de " & fechaActual.Value.ToString("yyyy") 'Mostramos la fecha actual
        fechaActual1 = Now.ToString("d")
        Dim posicionx As Integer = 90 'Posicion x
        Dim posiciony As Integer = 90 'Posicion y
        For i = 0 To PersonasDataSet.Nacimientos.Count - 1 'Recorremos toda la tabla Nacimientos
            fechaPrueba = PersonasDataSet.Nacimientos(i).Fecha_Nacimiento 'Almacenamos en fechaPrueba las fechas de la base de datos
            If (fechaActual1.Day & "/" & fechaActual1.Month) = (fechaPrueba.Day & "/" & fechaPrueba.Month) Then 'Si alguna fecha coindide con el día y fecha de hoy
                newLbl = New Label 'Generamos un nuevo label
                newLbl.BorderStyle = BorderStyle.Fixed3D 'Elegimos un estilo de borde
                newLbl.Location = New Point(posicionx, posiciony) 'Establecemos posicion
                newLbl.Font = New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold) 'Establecemos un estilo
                newLbl.BackColor = Color.LightGreen 'Establecemos color de fondo
                newLbl.TextAlign = ContentAlignment.MiddleCenter 'Establecemos alineación
                newLbl.Size = New Size(420, 70) 'Definimos el tamaño
                Me.Controls.Add(newLbl) 'Añadimos el label al formulario
                newLbl.Text = PersonasDataSet.Nacimientos(i).Nombre & " cumple hoy " & DateDiff("yyyy", PersonasDataSet.Nacimientos(i).Fecha_Nacimiento, fechaActual1) & " años " & vbCrLf & _
                    "Su cumpleaños es el " & fechaActual1.ToString("D") & vbCrLf & _
                    "Nació el " & fechaPrueba.ToString("D") 'Mostramos mensaje en el label
                posiciony = posiciony + 100 'Aumentamos posicion en 100 pixeles
            End If
            For x As Integer = 1 To 7
                SieteDiasMenos = DateAdd("y", -x, fechaActual1) 'Restamos de uno en uno siete dias a la fecha actual para comprobar si hay algún cumpleaños.
                fechaPrueba2 = PersonasDataSet.Nacimientos(i).Fecha_Nacimiento 'Almacenamos en fechaPrueba2 las fechas de la base de datos
                If x = 1 Then 'Comprobamos si el cumpleaños fue justo ayer.
                    If (SieteDiasMenos.Day & "/" & SieteDiasMenos.Month) = (fechaPrueba2.Day & "/" & fechaPrueba2.Month) Then
                        newLbl = New Label 'Generamos un nuevo label
                        newLbl.BorderStyle = BorderStyle.Fixed3D 'Elegimos un estilo de borde
                        newLbl.Location = New Point(posicionx, posiciony) 'Establecemos posicion
                        newLbl.Font = New Font(FontFamily.GenericSansSerif, 9.0F, FontStyle.Bold) 'Establecemos un estilo
                        newLbl.BackColor = Color.Teal 'Establecemos color de fondo
                        newLbl.TextAlign = ContentAlignment.MiddleCenter 'Establecemos alineación
                        newLbl.Size = New Size(420, 70)  'Definimos el tamaño
                        Me.Controls.Add(newLbl) 'Añadimos el label al formulario
                        newLbl.Text = PersonasDataSet.Nacimientos(i).Nombre & " cumplió ayer " & DateDiff("yyyy", PersonasDataSet.Nacimientos(i).Fecha_Nacimiento, fechaActual1) & " años" & vbCrLf & _
                            "Su cumpleaños fue el " & SieteDiasMenos.ToString("D") & vbCrLf & _
                            "Nació el " & fechaPrueba2.ToString("D") 'Mostramos mensaje en el label
                        posiciony = posiciony + 100 'Aumentamos posicion en 100 pixeles
                    End If
                End If
                If x >= 2 Then ' Si el dia es antes de ayer o anterior
                    If (SieteDiasMenos.Day & "/" & SieteDiasMenos.Month) = (fechaPrueba2.Day & "/" & fechaPrueba2.Month) Then
                        newLbl = New Label 'Generamos un nuevo label
                        newLbl.BorderStyle = BorderStyle.Fixed3D 'Elegimos un estilo de borde
                        newLbl.Location = New Point(posicionx, posiciony) 'Establecemos posicion
                        newLbl.BackColor = Color.Teal 'Establecemos color de fondo
                        newLbl.TextAlign = ContentAlignment.MiddleCenter 'Establecemos alineación
                        newLbl.Size = New Size(420, 70) 'Definimos el tamaño
                        Me.Controls.Add(newLbl) 'Añadimos el label al formulario
                        newLbl.Text = PersonasDataSet.Nacimientos(i).Nombre & " cumplió " & DateDiff("yyyy", PersonasDataSet.Nacimientos(i).Fecha_Nacimiento, fechaActual1) & " años hace " & DateDiff("d", (fechaPrueba2.Day & "/" & fechaPrueba2.Month), (fechaActual1.Day & "/" & fechaActual1.Month)) & " dias" & vbCrLf & _
                            "Su cumpleaños fue el " & SieteDiasMenos.ToString("D") & vbCrLf & _
                            "Nació el " & fechaPrueba2.ToString("D") 'Mostramos mensaje en el label
                        posiciony = posiciony + 100 'Aumentamos posicion en 100 pixeles
                    End If
                End If
            Next
            For x As Integer = 0 To 15
                QuinceDiasMas = DateAdd("y", x, fechaActual1) 'Sumamos de uno en uno quince dias a la fecha actual para comprobar si hay algún cumpleaños.
                fechaPrueba3 = PersonasDataSet.Nacimientos(i).Fecha_Nacimiento
                If x = 1 Then 'Si el cumpleaños es mañana
                    If (QuinceDiasMas.Day & "/" & QuinceDiasMas.Month) = (fechaPrueba3.Day & "/" & fechaPrueba3.Month) Then
                        newLbl = New Label 'Generamos un nuevo label
                        newLbl.BorderStyle = BorderStyle.Fixed3D 'Elegimos un estilo de borde
                        newLbl.Location = New Point(posicionx, posiciony) 'Establecemos posicion
                        newLbl.Font = New Font(FontFamily.GenericSansSerif, 11.0F, FontStyle.Bold) 'Establecemos un estilo
                        newLbl.BackColor = Color.GreenYellow 'Establecemos color de fondo
                        newLbl.TextAlign = ContentAlignment.MiddleCenter 'Establecemos alineación
                        newLbl.Size = New Size(420, 70) 'Definimos el tamaño
                        Me.Controls.Add(newLbl) 'Añadimos el label al formulario
                        newLbl.Text = PersonasDataSet.Nacimientos(i).Nombre & " cumple mañana " & DateDiff("yyyy", PersonasDataSet.Nacimientos(i).Fecha_Nacimiento, fechaActual1) & " años" & vbCrLf & _
                            "Su cumpleaños es el " & QuinceDiasMas.ToString("D") & vbCrLf & _
                            "Nació el " & fechaPrueba3.ToString("D")
                        posiciony = posiciony + 100 'Aumentamos posicion en 100 pixeles
                    End If
                End If
                If x >= 2 Then 'Si es pasado mañana o posteriores
                    If (QuinceDiasMas.Day & "/" & QuinceDiasMas.Month) = (fechaPrueba3.Day & "/" & fechaPrueba3.Month) Then
                        newLbl = New Label 'Generamos un nuevo label
                        newLbl.BorderStyle = BorderStyle.Fixed3D 'Elegimos un estilo de borde
                        newLbl.Location = New Point(posicionx, posiciony) 'Establecemos posicion
                        newLbl.Font = New Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold) 'Establecemos un estilo
                        newLbl.BackColor = Color.Magenta 'Establecemos color de fondo
                        newLbl.TextAlign = ContentAlignment.MiddleCenter 'Establecemos alineación
                        newLbl.Size = New Size(420, 70) 'Definimos el tamaño
                        Me.Controls.Add(newLbl) 'Añadimos el label al formulario
                        newLbl.Text = PersonasDataSet.Nacimientos(i).Nombre & " cumple " & DateDiff("yyyy", PersonasDataSet.Nacimientos(i).Fecha_Nacimiento, fechaActual1) & " años dentro de " & DateDiff("d", (fechaActual1.Day & "/" & fechaActual1.Month), (fechaPrueba3.Day & "/" & fechaPrueba3.Month)) & " dias" & vbCrLf & _
                            "Su cumpleaños es el " & QuinceDiasMas.ToString("D") & vbCrLf & _
                            "Nació el " & fechaPrueba3.ToString("D") 'Mostramos mensaje en el label
                        posiciony = posiciony + 100 'Aumentamos posicion en 100 pixeles
                    End If
                End If
            Next
        Next
    End Sub
End Class
