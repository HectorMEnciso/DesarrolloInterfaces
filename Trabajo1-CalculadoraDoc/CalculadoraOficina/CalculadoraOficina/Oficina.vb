Public Class Oficina
    Dim valor As Decimal 'Guardamos primer valor
    Dim temporal As Decimal
    Dim valor2 As Decimal 'Guardamos segundo valor
    Dim memoria As Decimal 'Guardamos valor en memoria
    Dim resultado As Decimal 'Guardamos resultado de las operaciones
    Dim operacion As String = "" 'Guardamos el signo del tipo de operacion
    Dim x As Integer 'Almacenamos longitud de los caracteres del text box
    Dim esPulsado As Boolean = False 'Varaible que permite desactivar/actividar boton coma
    Dim comaTeclado As Boolean = False 'Variable que permite saber si la coma ha sido pulsado desde el teclado
    Dim entradoOper As Boolean = False 'Si es falso hacemos que se quede con el valor actual del txtResultado y no entre al resto de operaciones
    Private Sub btnUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUno.Click
        If (TxtResultado.Text = "0") Then 'Si en la caja de texto ya hay un 0, lo eliminamos.
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "1" 'Añadimos 1 a la caja de texto tantas veces como pulsemos el botón 1
    End Sub

    Private Sub btnDos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDos.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "2"
    End Sub

    Private Sub btnTres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTres.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "3"
    End Sub

    Private Sub btnCuatro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuatro.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "4"
    End Sub

    Private Sub btnCinco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCinco.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "5"
    End Sub

    Private Sub btnSeis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeis.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "6"
    End Sub

    Private Sub btnSiete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiete.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "7"
    End Sub

    Private Sub btnOcho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcho.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "8"
    End Sub

    Private Sub btnNueve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueve.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "9"
    End Sub

    Private Sub btnCero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCero.Click
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        TxtResultado.Text = TxtResultado.Text & "0"
    End Sub
    Private Sub btnComa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComa.Click
         If TxtResultado.Text = "0" Then

            TxtResultado.Text = TxtResultado.Text & "."

        ElseIf TxtResultado.Text <> "0" Then
            TxtResultado.Text = TxtResultado.Text & "."


        ElseIf comaTeclado Then
            TxtResultado.Text = TxtResultado.Text & "."
            TxtResultado.Clear()
        End If
        esPulsado = True
        If esPulsado Or comaTeclado Then 'Si la coma se ha pulsado desde el teclado o con el ratón sobre el btnComa se deshabilita para evitar así que se introduzca mas de una.
            btnComa.Enabled = False
        End If
    End Sub
    Private Sub btnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDividir.Click
        txtOper.Text = txtOper.Text & TxtResultado.Text & " / "
        If operacion = "+" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor + valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "-" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor - valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "*" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor * valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "/" Then
            valor2 = Val(TxtResultado.Text)
            resultado = valor / valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        operacion = "/"
        If entradoOper = False Then
            valor = Val(TxtResultado.Text)
        End If
        TxtResultado.Clear()
        btnComa.Enabled = True
    End Sub

    Private Sub btnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiplicar.Click
        txtOper.Text = txtOper.Text & TxtResultado.Text & " * "
        If operacion = "+" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor + valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "-" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor - valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "*" Then
            valor2 = Val(TxtResultado.Text)
            resultado = valor * valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "/" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor / valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        operacion = "*"
        If entradoOper = False Then
            valor = Val(TxtResultado.Text)
        End If
        TxtResultado.Clear()
        btnComa.Enabled = True
    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumar.Click
        txtOper.Text = txtOper.Text & TxtResultado.Text & " + "
        If operacion = "+" Then
            valor2 = Val(TxtResultado.Text)
            resultado = valor + valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "-" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor - valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "*" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor * valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "/" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor / valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        operacion = "+"
        If entradoOper = False Then
            valor = Val(TxtResultado.Text)
        End If
        TxtResultado.Clear()
        btnComa.Enabled = True
    End Sub

    Private Sub btnRestar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestar.Click
        txtOper.Text = txtOper.Text & TxtResultado.Text & " - "
        If operacion = "+" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor + valor2
            TxtResultado.Text = resultado
            valor = resultado

        End If
        If operacion = "-" Then
            valor2 = Val(TxtResultado.Text)
            resultado = valor - valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        If operacion = "*" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor * valor2
            TxtResultado.Text = resultado
            valor = resultado

        End If
        If operacion = "/" Then
            entradoOper = True
            valor2 = Val(TxtResultado.Text)
            resultado = valor / valor2
            TxtResultado.Text = resultado
            valor = resultado
        End If
        operacion = "-"
        If (entradoOper = False) Then
            valor = Val(TxtResultado.Text)
        End If
        TxtResultado.Clear()
        btnComa.Enabled = True
    End Sub
    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click
        valor2 = Val(TxtResultado.Text)
        txtOper.Clear()
        If operacion = "+" Then
            resultado = valor + valor2
        ElseIf operacion = "-" Then
            resultado = valor - valor2
            Debug.Write("resultado resta: " & resultado)
        ElseIf operacion = "*" Then
            resultado = valor * valor2
        ElseIf operacion = "/" Then
            resultado = valor / valor2
        ElseIf operacion = "^" Then
            txtOper.Text = txtOper.Text & valor.ToString & "^" & valor2.ToString
            resultado = valor ^ valor2
        End If
        TxtResultado.Text = resultado
        If TxtResultado.Text.Contains(",") Then 'Cambiamos coma por punto para formatear el resultado.
            TxtResultado.Text = TxtResultado.Text.Replace(",", ".")
        End If
        btnComa.Enabled = True
        entradoOper = False
        operacion = " "
    End Sub
    Private Sub TxtResultado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtResultado.KeyDown
        If (TxtResultado.Text = "0") Then
            TxtResultado.Clear()
        End If
        If e.KeyCode = Keys.Divide Then 'Llamamos al boton dividir
            btnDividir_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Subtract Then
            btnRestar_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Add Then
            btnSumar_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Multiply Then
            btnMultiplicar_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Decimal Then
            comaTeclado = True
            btnComa_Click(Nothing, Nothing)
            TxtResultado.Focus()
            TxtResultado.SelectionStart = TxtResultado.Text.Length 'Forzamos posición del cursor para poder introducir la parte decimal
        ElseIf e.KeyCode = Keys.Enter Then
            btnIgual_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Back Then
            btnBorrarUno_Click(Nothing, Nothing)
        End If

    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close() 'Cerramos la aplicación
    End Sub

    Private Sub btnBorrarUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarUno.Click
        x = TxtResultado.Text.Length - 1 'Guardamos en x la longitud de lo que hay en TxtResultado
        If TxtResultado.Text.Length > 0 Then 'Si hay algo que borrar vamos borrando de uno en uno
            TxtResultado.Text = TxtResultado.Text.Substring(0, x)
        End If
        If TxtResultado.Text = "" Or TxtResultado.Text = "-" Then 'Si no hay nada que borrar o el resultado era negativo, escribimos un cero
            TxtResultado.Text = "0"
            txtOper.Clear()
        End If
        btnComa.Enabled = True 'Habilitamos la coma de nuevo
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        TxtResultado.Clear()
        valor = 0
        valor2 = 0
        resultado = 0
        txtOper.Clear()
        TxtResultado.Text = "0"
        btnComa.Enabled = True
    End Sub

    Private Sub btnRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRaiz.Click 'Calculamos la raiz cuadrada de un número
        valor = Val(TxtResultado.Text)
        txtOper.Text = "√" & TxtResultado.Text
        TxtResultado.Text = Math.Sqrt(valor)
    End Sub

    Private Sub btnNegativo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNegativo.Click 'Convertimos un número a negativo
        valor = Val(TxtResultado.Text)
        TxtResultado.Text = (-1) * valor
    End Sub

    Private Sub TxtResultado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtResultado.KeyPress  'Controlamos que no se pueda introducir nada que no sean números
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCuadrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuadrado.Click 'Calculamos el cuadrado de un número

        valor = Val(TxtResultado.Text)
        txtOper.Text = TxtResultado.Text & "^2"

        resultado = valor * valor

        TxtResultado.Text = resultado
    End Sub

    Private Sub btnCubo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCubo.Click 'Calculamos el cubo de un número
        valor = Val(TxtResultado.Text)
        txtOper.Text = TxtResultado.Text & "^3"

        resultado = valor * valor * valor

        TxtResultado.Text = resultado
    End Sub

    Private Sub btnPorcenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorcenta.Click 'Realizamos la operación %

        temporal = Val(TxtResultado.Text)
        txtOper.Text = txtOper.Text & TxtResultado.Text & "%"
        valor2 = (valor * temporal) / 100
        TxtResultado.Text = valor2

    End Sub

    Private Sub btnDiezX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiezX.Click  'Realizamos la operación 10 elevado a un número
        valor = Val(TxtResultado.Text)
        TxtResultado.Clear()
        txtOper.Text = txtOper.Text & TxtResultado.Text & "10^" & valor.ToString
        resultado = 10 ^ valor
        TxtResultado.Text = resultado
    End Sub

    Private Sub btnXY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXY.Click 'Realizamos la operación de un número elevado a otro
        operacion = "^"
        valor = Val(TxtResultado.Text)
        TxtResultado.Clear()
    End Sub

    Private Sub btnUnoEntreX_Click(sender As System.Object, e As System.EventArgs) Handles btnUnoEntreX.Click 'Realizamos la operación 1/x
        valor = Val(TxtResultado.Text)
        TxtResultado.Clear()
        txtOper.Text = txtOper.Text & TxtResultado.Text & "1/" & valor.ToString

        resultado = 1 / valor
        TxtResultado.Text = resultado
    End Sub

    Private Sub btnMmenos_Click(sender As System.Object, e As System.EventArgs) Handles btnMmenos.Click 'Restamos el valor del txtResultado a lo que tenemos en memoria 
        If Val(TxtResultado.Text) > 0 Then
            memoria = memoria - Val(TxtResultado.Text)
            txtMemoria.Text = "M: " & memoria

        End If
    End Sub

    Private Sub btnMC_Click(sender As System.Object, e As System.EventArgs) Handles btnMC.Click 'Vaciamos la memoria
        txtMemoria.Text = ""
        memoria = 0
    End Sub

    Private Sub btnMR_Click(sender As System.Object, e As System.EventArgs) Handles btnMR.Click 'Introducimos el valor que tenemos en memoria en TxtResultado
        TxtResultado.Text = memoria
    End Sub

    Private Sub btnMS_Click(sender As System.Object, e As System.EventArgs) Handles btnMS.Click 'Guardamos lo que tenemos en TxtResultado en la memoria
        If Val(TxtResultado.Text) > 0 Then
            memoria = Val(TxtResultado.Text)
            txtMemoria.Text = "M: " & memoria

        End If
    End Sub

    Private Sub btnMmas_Click(sender As System.Object, e As System.EventArgs) Handles btnMmas.Click 'Sumamos a lo que tenemos en memoria el valor de TxtResultado
        If Val(TxtResultado.Text) > 0 Then
            memoria = memoria + Val(TxtResultado.Text)
            txtMemoria.Text = "M: " & memoria
        End If
    End Sub

    Private Sub Oficina_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    End Sub
End Class
