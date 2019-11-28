Public Class DataAccess
    Shared cnnStr As String = My.Settings.cnnStr.ToString()
    Shared ctx As DataContext = New DataContext()

    Public Shared Function login(ByVal user As String, ByVal pass As String) As String
        Dim datos = (From c In ctx.Usuarios Where c.user = user AndAlso c.password = pass Select c).SingleOrDefault()

        If datos IsNot Nothing Then
            GeneralClass.IdUsuario = datos.idUsuario
            'Data.GeneralClass.IdUsuario = datos.idUsuario

            If datos.estado = True Then
                Return "OK"
            Else
                Return "Disabled"
            End If
        Else
            Return "NULL"
        End If
    End Function

    Public Shared Function nombre(ByVal id As Integer) As String
        Dim datos = (From c In ctx.Usuarios Where c.idUsuario = id Select c).SingleOrDefault()
        Return String.Concat(datos.Empeado.nombre.ToString(), " ", datos.Empeado.apellidos.ToString())
    End Function

    'Public Shared Sub cargarMesas(ByVal dgv As DataGridView)
    '    Dim datos = (From c In ctx.Mesas Order By c.estadoMesa Select New With {Key
    '        .N_de_Mesa = c.idMesa, Key
    '        .Capacidad = c.capacidad, Key
    '        .Disponible = c.estadoMesa
    '    }).ToList()
    '    dgv.DataSource = datos
    'End Sub

    'Public Shared Sub cargarSucursal(ByVal cbo As ComboBox)
    '    cbo.DataSource = ctx.Sucursals.ToList()
    '    cbo.DisplayMember = "establecimiento" & ""
    '    cbo.ValueMember = "idSucursal"
    'End Sub

    'Public Shared Sub añadirMesa(ByVal mesa As Mesa)
    '    ctx.Mesas.Add(mesa)
    '    ctx.SaveChanges()
    'End Sub

    'Public Shared Function devM(ByVal id As Integer) As Mesa
    '    Dim datos = (From c In ctx.Mesas Where c.idMesa = id Select c).SingleOrDefault()
    '    Return datos
    'End Function

    'Public Shared Sub deleteM(ByVal mesa As Mesa)
    '    ctx.Mesas.Remove(mesa)
    '    ctx.SaveChanges()
    'End Sub

    'Public Shared Sub updateM(ByVal id As Integer, ByVal capacidad As String)
    '    Dim datos = (From c In ctx.Mesas Where c.idMesa = id Select c).SingleOrDefault()
    '    datos.capacidad = capacidad
    '    ctx.SaveChanges()
    'End Sub

    'Public Shared Sub cargarClientes(ByVal dgv As DataGridView)
    '    Dim datos = (From c In ctx.Clientes Order By c.nombre Select New With {Key
    '        .N_Identidad = c.numIdentidad, Key
    '        .Nombre_Completo = String.Concat(c.nombre.ToString(), " ", c.apellidos.ToString()), Key
    '        .Email = c.correoElectronico, Key
    '        .Celular = c.celular.ToString(), Key
    '        .Direccion = c.direccion, Key
    '        .Edad = DateTime.Today.Year - c.fechaNacimiento.Year, Key
    '        .Genero = c.Genero.genero
    '    }).ToList()
    '    dgv.DataSource = datos
    'End Sub

    'Public Shared Sub cargarPedidos(ByVal dgv As DataGridView)
    '    Dim datos = (From c In ctx.DetallePedidos Order By c.Ordenes.fecha Select New With {Key
    '        .N_de_Pedido = c.idPedido, Key
    '        .Fecha = c.Ordenes.fecha.ToString(), Key
    '        .Estado = c.Ordenes.estadoPedido, Key
    '        .N_de_identidad = c.Ordenes.numIdentidad, Key
    '        .N_Mesa = c.Ordenes.idMesa, Key
    '        .Detalle = String.Concat(c.cantidad.ToString(), " ", c.Menu.nombre.ToString())
    '    }).ToList()
    '    dgv.DataSource = datos
    'End Sub

    'Public Shared Sub cargarMenuP(ByVal flp As FlowLayoutPanel)
    '    Dim datos = (From c In ctx.Precios Select New With {Key
    '        .id = c.Menu.idMenu, Key
    '        .name = c.Menu.nombre.ToString(), Key
    '        .precio = c.precio.ToString()
    '    }).ToList()

    '    For i As Integer = 0 To datos.Count - 1
    '        Dim datoS = (From c In ctx.Precios Where c.idPrecio = (i + 1) Select New With {Key
    '            .id = c.Menu.idMenu, Key
    '            .name = c.Menu.nombre.ToString(), Key
    '            .precio = c.precio.ToString()
    '        }).FirstOrDefault()
    '        Dim btn As Button = New Button() With {
    '            .BackColor = System.Drawing.Color.Transparent,
    '            .FlatStyle = System.Windows.Forms.FlatStyle.Flat,
    '            .Font = New System.Drawing.Font("Lucida Console", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0),
    '            .ForeColor = System.Drawing.Color.Black,
    '            .Size = New System.Drawing.Size(166, 54),
    '            .UseVisualStyleBackColor = False,
    '            .Text = $"{datoS.name}\nL.{datoS.precio}"
    '        }
    '        flp.Controls.Add(btn)
    '    Next
    'End Sub

    'Public Shared Function devD(ByVal i As Integer) As String
    '    Dim datoS = (From c In ctx.Precios Where c.idPrecio = (i + 1) Select New With {Key
    '        .id = c.Menu.idMenu, Key
    '        .name = c.Menu.nombre.ToString(), Key
    '        .precio = c.precio.ToString()
    '    }).FirstOrDefault()
    '    Return datoS.name.ToString()
    'End Function

    'Public Shared Function devPre(ByVal i As Integer) As String
    '    Dim datoS = (From c In ctx.Precios Where c.idPrecio = (i + 1) Select New With {Key
    '        .id = c.Menu.idMenu, Key
    '        .name = c.Menu.nombre.ToString(), Key
    '        .precio = c.precio.ToString()
    '    }).FirstOrDefault()
    '    Return datoS.precio.ToString()
    'End Function

    'Public Shared Sub cargarMenu(ByVal dgv As DataGridView)
    '    Dim datos = (From c In ctx.DetalleMenus Order By c.Menu.fechaCreacion Select New With {Key
    '        .Nombre = c.Menu.nombre, Key
    '        .Fecha = c.Menu.fechaCreacion, c.cantidad, Key
    '        .Detalle = c.Productos.descripcion
    '    }).ToList()
    '    dgv.DataSource = datos
    'End Sub

    'Public Shared Sub cargarProductos(ByVal dgv As DataGridView)
    '    Dim datos = (From c In ctx.Productos Order By c.idProducto Select New With {Key
    '        .ID = c.idProducto, Key
    '        .Descripcion = c.descripcion, Key
    '        .Tipo = c.TipoProducto.tipoProducto
    '    }).ToList()
    '    dgv.DataSource = datos
    'End Sub
End Class
