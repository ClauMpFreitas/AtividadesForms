/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 20/03/2023
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AtividadesForms
{
	partial class FrmSeguros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtvalor = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbassistencia = new System.Windows.Forms.CheckBox();
			this.cbvidro = new System.Windows.Forms.CheckBox();
			this.cbreboque = new System.Windows.Forms.CheckBox();
			this.cmbpagamento = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btncalcular = new System.Windows.Forms.Button();
			this.txtseguro = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtservicos = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txttotalseg = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdesconto = new System.Windows.Forms.TextBox();
			this.btnlimpar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor de tabela do veículo";
			// 
			// txtvalor
			// 
			this.txtvalor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtvalor.Location = new System.Drawing.Point(13, 55);
			this.txtvalor.Name = "txtvalor";
			this.txtvalor.Size = new System.Drawing.Size(200, 26);
			this.txtvalor.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbassistencia);
			this.groupBox1.Controls.Add(this.cbvidro);
			this.groupBox1.Controls.Add(this.cbreboque);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(13, 102);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 100);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serviços adicionais";
			// 
			// cbassistencia
			// 
			this.cbassistencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbassistencia.Location = new System.Drawing.Point(6, 65);
			this.cbassistencia.Name = "cbassistencia";
			this.cbassistencia.Size = new System.Drawing.Size(234, 24);
			this.cbassistencia.TabIndex = 2;
			this.cbassistencia.Text = "Assistência 24H - R$ 95,00";
			this.cbassistencia.UseVisualStyleBackColor = true;
			// 
			// cbvidro
			// 
			this.cbvidro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbvidro.Location = new System.Drawing.Point(6, 45);
			this.cbvidro.Name = "cbvidro";
			this.cbvidro.Size = new System.Drawing.Size(244, 24);
			this.cbvidro.TabIndex = 1;
			this.cbvidro.Text = "Seguro para vidro - R$ 130,00";
			this.cbvidro.UseVisualStyleBackColor = true;
			// 
			// cbreboque
			// 
			this.cbreboque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbreboque.Location = new System.Drawing.Point(6, 25);
			this.cbreboque.Name = "cbreboque";
			this.cbreboque.Size = new System.Drawing.Size(244, 24);
			this.cbreboque.TabIndex = 0;
			this.cbreboque.Text = "Reboque especial - R$ 200,00";
			this.cbreboque.UseVisualStyleBackColor = true;
			// 
			// cmbpagamento
			// 
			this.cmbpagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbpagamento.FormattingEnabled = true;
			this.cmbpagamento.Items.AddRange(new object[] {
									"À vista",
									"Duas parcelas",
									"Três parcelas"});
			this.cmbpagamento.Location = new System.Drawing.Point(321, 25);
			this.cmbpagamento.Name = "cmbpagamento";
			this.cmbpagamento.Size = new System.Drawing.Size(187, 26);
			this.cmbpagamento.TabIndex = 3;
			this.cmbpagamento.Text = "Forma de pagamento";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(331, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Valor do seguro básico";
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btncalcular.Location = new System.Drawing.Point(39, 223);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(89, 29);
			this.btncalcular.TabIndex = 5;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// txtseguro
			// 
			this.txtseguro.Enabled = false;
			this.txtseguro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtseguro.Location = new System.Drawing.Point(524, 125);
			this.txtseguro.Name = "txtseguro";
			this.txtseguro.Size = new System.Drawing.Size(100, 26);
			this.txtseguro.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(331, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Valor dos serviços";
			// 
			// txtservicos
			// 
			this.txtservicos.Enabled = false;
			this.txtservicos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtservicos.Location = new System.Drawing.Point(524, 159);
			this.txtservicos.Name = "txtservicos";
			this.txtservicos.Size = new System.Drawing.Size(100, 26);
			this.txtservicos.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(331, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Valor total do seguro";
			// 
			// txttotalseg
			// 
			this.txttotalseg.Enabled = false;
			this.txttotalseg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txttotalseg.Location = new System.Drawing.Point(524, 237);
			this.txttotalseg.Name = "txttotalseg";
			this.txttotalseg.Size = new System.Drawing.Size(100, 26);
			this.txttotalseg.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(331, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(196, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Valor do desconto à vista";
			// 
			// txtdesconto
			// 
			this.txtdesconto.Enabled = false;
			this.txtdesconto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtdesconto.Location = new System.Drawing.Point(524, 198);
			this.txtdesconto.Name = "txtdesconto";
			this.txtdesconto.Size = new System.Drawing.Size(100, 26);
			this.txtdesconto.TabIndex = 12;
			// 
			// btnlimpar
			// 
			this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnlimpar.Location = new System.Drawing.Point(151, 223);
			this.btnlimpar.Name = "btnlimpar";
			this.btnlimpar.Size = new System.Drawing.Size(89, 29);
			this.btnlimpar.TabIndex = 13;
			this.btnlimpar.Text = "Limpar";
			this.btnlimpar.UseVisualStyleBackColor = true;
			this.btnlimpar.Click += new System.EventHandler(this.BtnlimparClick);
			// 
			// FrmSeguros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(699, 282);
			this.Controls.Add(this.btnlimpar);
			this.Controls.Add(this.txtdesconto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txttotalseg);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtservicos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtseguro);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbpagamento);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtvalor);
			this.Controls.Add(this.label1);
			this.Name = "FrmSeguros";
			this.Text = "Companhia de Seguros Carro Bom";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnlimpar;
		private System.Windows.Forms.TextBox txtdesconto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txttotalseg;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtservicos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtseguro;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbpagamento;
		private System.Windows.Forms.CheckBox cbreboque;
		private System.Windows.Forms.CheckBox cbvidro;
		private System.Windows.Forms.CheckBox cbassistencia;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtvalor;
		private System.Windows.Forms.Label label1;
	}
}
