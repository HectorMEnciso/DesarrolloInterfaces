Public Class frmBusqueda
    Dim index As Integer = 0 'Guardamos posicion de ocurrencia de cadena
    Dim Pos, strSearchTerm, lastIndex, strLastSearch As Integer
    Dim PalabraClave As String 'Guardamos texto de la palabra a buscar
    Dim TipoBusqueda As Long
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click 'Busca ocurrencia de una palabra en el RichTextBox
        If Form1.txtContenido.Find(txtBuscar.Text) = -1 Then 'Si no se encuentra el texto a buscar salta un mensaje indicando al usuario que la palabra no ha sido encontrada.
            MsgBox("Texto no encontrado.", 48, "Atención")
        Else
            If txtBuscar.Text.Length > 0 Then 'Si se ha introducido texto en txtBuscar se busca y se superpone el Form1
                Form1.txtContenido.Find(txtBuscar.Text)
                Form1.Focus()
            Else
                MsgBox("No ha introducido texto para buscar.", 48, "Atención")
            End If
        End If
    End Sub
    Private Sub btnReemplazar_Click(sender As System.Object, e As System.EventArgs) Handles btnReemplazar.Click 'Reemplaza una a una las ocurrencias de una cadena en el RichTextBox
        If txtReemplazar.Text.Length > 0 Then 'Si se ha introducido texto en txtReemplazar
            PalabraClave = txtBuscar.Text
            If Len(PalabraClave) Then 'Si PalabraClave tiene longitud mayor que 0
                Pos = InStr(Pos + 1, Form1.txtContenido.Text, PalabraClave, TipoBusqueda) 'Guardamos en posición la posicion que ocupa PalabraClave en txtContenido
                If Pos > 0 Then
                    Form1.txtContenido.SelectionStart = Pos - 1
                    Form1.txtContenido.SelectionLength = Len(PalabraClave)
                    'Selecciona la longitud de la palabra a reemplazar
                    Form1.txtContenido.Focus() 'Superpone el Form1
                    Clipboard.Clear() 'Limpia el portapapeles
                    Clipboard.SetText(txtReemplazar.Text) 'Establece el texto que se encuentra en txtReemplazar
                    SendKeys.Send("^(V)") 'Envia simulando la pulsación CRTL+V (pegar el texto que se encuentra en el portapapeles)
                Else
                    MsgBox("Texto no encontrado.", 48, "Atención")
                End If
            End If
        Else
            MsgBox("No ha introducido texto para reemplazar.", 48, "Atención")
        End If
    End Sub

    Private Sub btnReemplazarTodo_Click(sender As System.Object, e As System.EventArgs) Handles btnReemplazarTodo.Click 'Reemplazamos todos las ocurrencias de una cadena en el RichTextBox
        If Form1.txtContenido.Text = Form1.txtContenido.Text.Replace(txtBuscar.Text, txtReemplazar.Text) = -1 Then
            MsgBox("Texto no encontrado.", 48, "Atención")
        Else
            If txtReemplazar.Text.Length > 0 Then
                Form1.txtContenido.Text = Form1.txtContenido.Text.Replace(txtBuscar.Text, txtReemplazar.Text) 'Reemplazamos la cadena vieja(txtBuscar.txt) por la cadena nueva(txtReemplazar.txt)
                Form1.Focus()
            Else
                MsgBox("No ha introducido texto para reemplazar.", 48, "Atención")
            End If
        End If
    End Sub

    Private Sub btnBuscarSiguente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarSiguente.Click 'Buscamos la primera ocurrencia de una cadena y las siguiente hasta alcanzar el fin del documento
        lastIndex = Form1.txtContenido.Text.LastIndexOf(txtBuscar.Text) 'Indica la posicion de la ultima ocurrencia de una cadena
        If lastIndex = 0 Then 'Si la ultima ocurrencia en 0 quiere decir que esta al comienzo del documento
            strSearchTerm = 0 'Establecemos a 0
        ElseIf lastIndex = -1 Then 'Si no existe la ultima ocurrencia

            If Form1.txtContenido.Text = "" Then 'Si el txtContenido está vacio
                MsgBox("No se encontró '" & txtBuscar.Text & "'.", 48, "Atención")
            Else
                If Form1.txtContenido.Find(txtBuscar.Text, 0, Form1.txtContenido.Text.Length, RichTextBoxFinds.None) = -1 Then 'Si no está vacio buscamos de nuevo
                    MsgBox("No se encontró '" & txtBuscar.Text & "'.", 48, "Atención")
                Else
                    strSearchTerm = Form1.txtContenido.Find(txtBuscar.Text, 0, Form1.txtContenido.Text.Length, RichTextBoxFinds.None) 'Si se encuentra establecemos strSearchTerm con el índice de inicio de la ocurrencia.
                End If
            End If
        Else
            strSearchTerm = Form1.txtContenido.Find(txtBuscar.Text, index, lastIndex, RichTextBoxFinds.None) 'Si nada de lo anterior de cumple establecemos strSearchTerm al índice de la ocurrencia
        End If

        If strSearchTerm = -1 Then
            strLastSearch = Form1.txtContenido.Text.LastIndexOf(txtBuscar.Text) 'Si se encuentra pero es la útlima, repetimos el bucle
            Form1.Focus()
            Form1.txtContenido.SelectionStart = strLastSearch
            Form1.txtContenido.SelectionLength = txtBuscar.Text.Length
            index = 0
        Else 'Si se encuentra y no es la última, establecer index a partir de la declaración Find para evitar la aparición anterior
            Form1.Focus()
            Form1.txtContenido.SelectionStart = strSearchTerm
            Form1.txtContenido.SelectionLength = txtBuscar.Text.Length
            index = strSearchTerm + 1
        End If
    End Sub
End Class