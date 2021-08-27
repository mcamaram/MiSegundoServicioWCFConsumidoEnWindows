using MiSegundoServicioWCFConsumidoEnWindows.ServiceMedicamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiSegundoServicioWCFConsumidoEnWindows
{
    public partial class frmPopupMedicamento : Form
    {
        public int iidmedicamento { get; set; }
        public frmPopupMedicamento()
        {
            InitializeComponent();
        }

        private void frmPopupMedicamento_Load(object sender, EventArgs e)
        {
            MedicamentosClient oMedicamentosClient = new MedicamentosClient();
            oMedicamentosClient.ClientCredentials.UserName.UserName = "lhurol";
            oMedicamentosClient.ClientCredentials.UserName.Password = "1234";
            List<FormaFarmaceuticaCLS> listaForma= oMedicamentosClient.listarFormaFarmaceutica();
            listaForma.Insert(0, new FormaFarmaceuticaCLS { iidformafarmaceutica = 0, nombreFormaFarmaceutica = "--Seleccione" });
            cboFormaFarmaceutica.DataSource = listaForma;
            cboFormaFarmaceutica.DisplayMember = "nombreFormaFarmaceutica";
            cboFormaFarmaceutica.ValueMember = "iidFormaFarmaceutica";

            //Todo bien
            if (iidmedicamento == 0)
            {
                this.Text = "Agregar Medicamento";
                //Pintamos la informacion
            }else
            {
                this.Text = "Editando Medicamento";
                MedicamentosClient oMedicamentosClientEditar = new MedicamentosClient();
                oMedicamentosClientEditar.ClientCredentials.UserName.UserName = "lhurol";
                oMedicamentosClientEditar.ClientCredentials.UserName.Password = "1234";
                 MedicamentoCLS oMedicamentoCLS= oMedicamentosClientEditar.recuperarMedicamento(iidmedicamento);
                txtIdMedicamento.Text = oMedicamentoCLS.iidmedicamento.ToString();
                txtNombre.Text = oMedicamentoCLS.nombre;
                txtprecio.Text = oMedicamentoCLS.precio.ToString();
                txtstock.Text = oMedicamentoCLS.stock.ToString();
                txtpresentacion.Text = oMedicamentoCLS.presentacion;
                txtConcentracion.Text = oMedicamentoCLS.concentracion;
                cboFormaFarmaceutica.SelectedValue = oMedicamentoCLS.iidformafarmaceutica;

            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            } else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }

        private void soloDecimales(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar=='.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var exito = true;

            if (txtNombre.Text == "")
            {
                errorDatos.SetError(txtNombre, "Ingrese nombre");
                exito = false;
            }else
            {
                errorDatos.SetError(txtNombre, "");

            }

            if (txtprecio.Text == "")
            {
                errorDatos.SetError(txtprecio, "Ingrese precio");
                exito = false;
            }
            else
            {
                errorDatos.SetError(txtprecio, "");

            }

            if (txtstock.Text == "")
            {
                errorDatos.SetError(txtstock, "Ingrese stock");
                exito = false;
            }
            else
            {
                errorDatos.SetError(txtstock, "");

            }

            if (txtpresentacion.Text == "")
            {
                errorDatos.SetError(txtpresentacion, "Ingrese presentacion");
                exito = false;
            }
            else
            {
                errorDatos.SetError(txtpresentacion, "");

            }

            if (txtConcentracion.Text == "")
            {
                errorDatos.SetError(txtConcentracion, "Ingrese concentracion");
                exito = false;
            }
            else
            {
                errorDatos.SetError(txtConcentracion, "");

            }

            if ((int)cboFormaFarmaceutica.SelectedValue == 0)
            {
                errorDatos.SetError(cboFormaFarmaceutica, "Ingrese forma farmaceutica");
                exito = false;
            }
            else
            {
                errorDatos.SetError(cboFormaFarmaceutica, "");

            }

            if (exito == false)
            {
                this.DialogResult = DialogResult.None;
                return;
            }else
            {
                MedicamentoCLS oMedicamentoCLS = new MedicamentoCLS();
                oMedicamentoCLS.iidmedicamento = int.Parse( txtIdMedicamento.Text);
                oMedicamentoCLS.nombre = txtNombre.Text;
                oMedicamentoCLS.precio = decimal.Parse(txtprecio.Text);
                oMedicamentoCLS.presentacion = txtpresentacion.Text;
                oMedicamentoCLS.iidformafarmaceutica = (int)cboFormaFarmaceutica.SelectedValue;
                oMedicamentoCLS.stock = int.Parse(txtstock.Text);
                oMedicamentoCLS.concentracion = txtConcentracion.Text;
                oMedicamentoCLS.bhabilitado = 1;
                MedicamentosClient oMedicamentosClient = new MedicamentosClient();
                oMedicamentosClient.ClientCredentials.UserName.UserName = "lhurol";
                oMedicamentosClient.ClientCredentials.UserName.Password = "1234";
                int rpta= oMedicamentosClient.registrarYActualizarMedicamentos(oMedicamentoCLS);
                if (rpta == 1)
                {
                    MessageBox.Show("Se ejecuto correctamente");
                    this.DialogResult = DialogResult.OK;
                }else
                {
                    MessageBox.Show("Ocurrio un error");
                    this.DialogResult = DialogResult.None;
                }
            }




        }
    }
}
