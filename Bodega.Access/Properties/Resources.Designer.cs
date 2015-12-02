﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18063
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bodega.Access.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bodega.Access.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Clientes 
        ///SET 
        ///Nombres = @Nombres, 
        ///Apellidos = @Apellidos, 
        ///Correo = @Correo, 
        ///Edad = @Edad 
        ///WHERE 
        ///(IdCliente = @IdCliente).
        /// </summary>
        internal static string usp_ActualizarClientes {
            get {
                return ResourceManager.GetString("usp_ActualizarClientes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a UPDATE Producto
        ///SET
        ///Codigo = @Codigo,
        ///Descripcion = @Descripcion,
        ///PrecioUnitario = @PrecioUnitario
        ///WHERE
        ///IdProducto = @IdProducto.
        /// </summary>
        internal static string usp_ActualizarProductos {
            get {
                return ResourceManager.GetString("usp_ActualizarProductos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a DELETE FROM PRODUCTO
        ///WHERE IdProducto = @IdProducto.
        /// </summary>
        internal static string usp_EliminarProductos {
            get {
                return ResourceManager.GetString("usp_EliminarProductos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO CLIENTES(IdCliente, Nombres, Apellidos, Correo, Edad) VALUES (@IdCliente, @Nombres, @Apellidos, @Correo, @Edad).
        /// </summary>
        internal static string usp_InsertarClientes {
            get {
                return ResourceManager.GetString("usp_InsertarClientes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO FacturaDetalle (IdFacturaDetalle, IdFacturaCabecera, IdProducto, Cantidad, PrecioUnitario, Total) 
        ///VALUES (@IdFacturaDetalle, @IdFacturaCabecera, @IdProducto, @Cantidad,@PrecioUnitario, @Total).
        /// </summary>
        internal static string usp_InsertarDetalleFactura {
            get {
                return ResourceManager.GetString("usp_InsertarDetalleFactura", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO FacturaCabecera (IdFacturaCabecera, IdCliente, Numero, Serie, Fecha, SubTotal, Impuestos, Total)
        /// VALUES (@IdFacturaCabecera,@IdCliente,@Numero,@Serie, @Fecha, @SubTotal,@Impuestos, @Total).
        /// </summary>
        internal static string usp_InsertarFactura {
            get {
                return ResourceManager.GetString("usp_InsertarFactura", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO PRODUCTO 
        ///(IdProducto, 
        ///Codigo, 
        ///Descripcion, 
        ///PrecioUnitario) 
        ///VALUES 
        ///(@IdProducto, 
        ///@Codigo, 
        ///@Descripcion, 
        ///@PrecioUnitario).
        /// </summary>
        internal static string usp_InsertarProductos {
            get {
                return ResourceManager.GetString("usp_InsertarProductos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a SELECT IDFACTURACABECERA
        ///		,CLIENTES.NOMBRES + &apos; &apos; + CLIENTES.APELLIDOS AS CLIENTE
        ///		,NUMERO
        ///		,SERIE
        ///		,FECHA
        ///		,SUBTOTAL
        ///		,IMPUESTOS
        ///		,TOTAL
        ///	FROM FACTURACABECERA
        ///	INNER JOIN CLIENTES ON FACTURACABECERA.IDCLIENTE = CLIENTES.IDCLIENTE
        ///	ORDER BY NUMERO.
        /// </summary>
        internal static string usp_ListarFacturas {
            get {
                return ResourceManager.GetString("usp_ListarFacturas", resourceCulture);
            }
        }
    }
}
