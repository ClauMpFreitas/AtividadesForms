using System;
using System.Drawing;
using System.Windows.Forms;

namespace AtividadesForms
{
	public partial class FrmSeguros : Form
	{
		public FrmSeguros()
		{
			InitializeComponent();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double valortab, valorseg, valortotal, valordesc=0, valorservad=0;
			
			valortab=Convert.ToDouble(txtvalor.Text);
			if (cbreboque.Checked==true)
				valorservad+=200;
			if (cbvidro.Checked==true)
				valorservad+=130;
			if (cbassistencia.Checked==true)
				valorservad+=95;
			txtservicos.Text=Convert.ToString(valorservad);
			
			if (cmbpagamento.SelectedIndex==0)
				valordesc=valortab*0.95;
			if (cmbpagamento.SelectedIndex==1)
				valordesc=0;
			if (cmbpagamento.SelectedIndex==2)
				valordesc=0;
			txtdesconto.Text=Convert.ToString(valordesc);
			
			valorseg=(valortab*3)/100;
			txtseguro.Text=Convert.ToString(valorseg);
			
			valortotal=valorseg+valorservad;
			txttotalseg.Text=Convert.ToString(valortotal);
		}
		
		void BtnlimparClick(object sender, EventArgs e)
		{
			txtdesconto.Clear();
			txtseguro.Clear();
			txtservicos.Clear();
			txttotalseg.Clear();
			txtvalor.Clear();
			txtvalor.Focus();
			cbassistencia.Checked=false;
			cbreboque.Checked=false;
			cbvidro.Checked=false;
			cmbpagamento.SelectedIndex = -1;
			cmbpagamento.Text="Forma de pagamento";
		}
	}
}
