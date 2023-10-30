using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using System.IO;


namespace IcoFarma
{
    public partial class frmDetalleVentas : Form
    {
        
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            txtbusqueda.Select();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtbusqueda.Text);

            if (oVenta.IdVenta != 0)
            {

                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtfecha.Text = oVenta.FechaRegistro;
                txttipodocumento.Text = oVenta.TipoDocumento;
                txtusuario.Text = oVenta.oUsuario.NombreCompleto;


                txtdoccliente.Text = oVenta.DocumentoCliente;
                txtnombrecliente.Text = oVenta.NombreCliente;

                dgvdata.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvdata.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtmontototal.Text = oVenta.MontoTotal.ToString("0.00");
                txtmontopago.Text = oVenta.MontoPago.ToString("0.00");
                txtmontocambio.Text = oVenta.MontoCambio.ToString("0.00");


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtfecha.Text = "";
            txttipodocumento.Text = "";
            txtusuario.Text = "";
            txtdoccliente.Text = "";
            txtnombrecliente.Text = "";

            dgvdata.Rows.Clear();
            txtmontototal.Text = "0.00";
            txtmontopago.Text = "0.00";
            txtmontocambio.Text = "0.00";
        }

        DateTime dateTime = DateTime.Now;

        private void btnboleta_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://facturacion.apisperu.com/api/v1/invoice/pdf");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJpYXQiOjE2OTgxNjcxNTYsImV4cCI6NDg1MTc2NzE1NiwidXNlcm5hbWUiOiJMdWNhc3QiLCJjb21wYW55IjoiMTA3MTEyMTk0MDAifQ.BPcRETd0uWxIQbCY5xjl_MlOIJD73ClHKRqyyb-v6SqgpqNecLAPAKO9dyelD0mM431oNYkBrRFtIvdi6NXU9I_11M-YMruixJTtx5W7h63YcxEATEZ3ZTWmBwc5nd0J_S8nwJ-nUB4dCkf9I32G1t0cysBxlGGbLroSNBq4E1ZkjPBKaWyU5l4SvVTsODoijZjAyPUOaz43UFV-BRwyiLKFOhir8J-seX_zB7ThsM6nbc-edc5Ds6rqBBtu-ITENFTwbEeSjJgJIU8-egnSFPi7YaCKE4ynMg_MH4uGlYKyhuWrRjurxbQUTo50oa0A6dqA6EmlYWOK-oqgTl7dc64Vy0qaRht8hi-ERuC9y54fhNgCR-Djf8Co48eYtihUp1Ad4VIz-_NXM3zd34RMgEfG-z6RvP1PEkTczmodJ9Nd7eESY-sUr8u8_RhkUJAtVtxKgZeligPb4-3Bw1kdnGBmmFnn-BZqWQy_G6B5UGPFYWsJwfIGMlVFPsbrLxfUMVWCOCvvZtAhzvhNAWroEkze9JfPMGuCCrf7yp4r5S_mi4VzWXF1NMz2n9Sj26_TOgbk0FuBPW1frP37jVmybSMZNAfTS50uJvzkuZJrqTt6Z9PXT01bpFrhNigvGvhwgdFN4obYe4VuPZIrnJmWIyjjn6kGASwS-nQactDutLM");

            var mtoOperGravadas = Convert.ToDecimal(txt_precioxu.Text) * Convert.ToDecimal(txt_cantidad.Text);
            var mtoIGV = mtoOperGravadas * Convert.ToDecimal(0.18);

            var jsonData = new {
                ublVersion = "2.1",
                fecVencimiento = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                tipoOperacion = "0101",
                tipoDoc = "01",
                serie = "F002",
                correlativo = txtbusqueda.Text, 
                fechaEmision = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz"),
                
                formaPago = new
                {
                    moneda = "PEN",
                    tipo = "Contado"
                },
                tipoMoneda = "PEN",

                client = new
                {
                    tipoDoc = "6",
                    numDoc = Convert.ToUInt64(txtdoccliente.Text),
                    rznSocial = txtnombrecliente.Text,
                    address = new
                    {
                        direccion = "",
                        provincia = "",
                        departamento = "",
                        distrito = "",
                        ubigueo = ""
                    }
                },
                
                company = new
                {
                    ruc = 10711219400,
                    razonSocial = "Botica ICOFARMA",
                    nombreComercial = "ICOFARMA",
                    address = new
                    {
                        direccion = "704 Av. Bolivia Víctor Larco Herrera",
                        provincia = "Trujillo",
                        departamento = "La Libertad",
                        distrito = "Victor Larco Herrera",
                        ubigueo = "130201"
                    }
                },
                mtoOperGravadas = mtoOperGravadas,
                mtoOperExoneradas = 0,
                
                mtoIGV = mtoIGV,
                totalImpuestos = 0,
                valorVenta = 0,
                subTotal = 0,
                mtoImpVenta = mtoIGV + mtoOperGravadas,
                details = new[]
                {
                    new
                    {
                        codProducto = txtbusqueda.Text,
                        unidad = "NIU",
                        descripcion = txt_producto.Text,
                        cantidad = Convert.ToUInt64(txt_cantidad.Text),//cantidad
                        mtoValorUnitario = 0,
                        mtoValorVenta = mtoOperGravadas, //valortotal
                        mtoBaseIgv = mtoOperGravadas, //valortotal
                        porcentajeIgv = 18,
                        igv = 0, //sacarigv
                        tipAfeIgv = 0,
                        totalImpuestos = mtoIGV, //sacarigv
                        mtoPrecioUnitario = Convert.ToDecimal(txt_precioxu.Text) //precio
                    },
                },
                            legends = new[]
                {
                    new
                    {
                        code = "1000",
                       value = "SON "+mtoIGV.ToString() + mtoOperGravadas.ToString()+"/100 SOLES"
                    }
                }
            };
            string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData);
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            RestResponse response = (RestResponse)client.Execute(request);

            string rutaDescarga = @"D:\Descargas";
            string nombreArchivo = txtbusqueda.Text + ".pdf";
            string pdfFileName = Path.Combine(rutaDescarga, nombreArchivo);

            System.IO.File.WriteAllBytes(pdfFileName, response.RawBytes);

            label11.Text = "Archivo PDF descargado con éxito como: " + pdfFileName;


        }

       

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow fila = dgvdata.Rows[indice];
                txt_precioxu.Text = fila.Cells["Precio"].Value.ToString();
                txt_cantidad.Text = fila.Cells["Cantidad"].Value.ToString();
                txt_producto.Text = fila.Cells["Producto"].Value.ToString();
                txt_subtotal.Text = fila.Cells["SubTotal"].Value.ToString();
            }
        }
    }
}

