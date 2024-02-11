using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AtividadesForms
{
	public partial class FrmHotel : Form
	{
		public FrmHotel()
		{
			InitializeComponent();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			int qntdias;
			double valorhospedagem=0, valoropcionais=0, valortotal;
			
			qntdias=Convert.ToInt16(txtdias.Text);
			if (rbstandard.Checked==true)
				valorhospedagem=qntdias*150;
			if (rbluxo.Checked==true)
				valorhospedagem=qntdias*210;
			if (rbsuperluxo.Checked==true)
				valorhospedagem=qntdias*245;
			if (rbking.Checked==true)
				valorhospedagem=qntdias*350;
			txthospedagem.Text=Convert.ToString(valorhospedagem);
			
			if (cbestacionamento.Checked==true)
				valoropcionais+=18;
			if (cblavanderia.Checked==true)
				valoropcionais+=21;
			txtopcionais.Text=Convert.ToString(valoropcionais);
			
			valortotal=valorhospedagem+valoropcionais;
			txtconta.Text=Convert.ToString(valortotal);
		}
		
		void FrmHotelShown(object sender, EventArgs e)
		{
			rbstandard.Checked=false;
			rbluxo.Checked=false;
			rbsuperluxo.Checked=false;
			rbking.Checked=false;
		}
		
		void BtnlimparClick(object sender, EventArgs e)
		{
			txtcpf.Clear();
			txtdias.Clear();
			txthospedagem.Clear();
			txtopcionais.Clear();
			txtconta.Clear();
			txtcpf.Focus();
			rbstandard.Checked=false;
			rbluxo.Checked=false;
			rbsuperluxo.Checked=false;
			rbking.Checked=false;
			cbestacionamento.Checked=false;
			cblavanderia.Checked=false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			FrmSeguros f = new FrmSeguros();
			f.Show();
		}
	}
}
