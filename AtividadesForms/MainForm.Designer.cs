/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 20/03/2023
 * Time: 13:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AtividadesForms
{
	partial class FrmHotel
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
			this.txtcpf = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtdias = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbking = new System.Windows.Forms.RadioButton();
			this.rbsuperluxo = new System.Windows.Forms.RadioButton();
			this.rbluxo = new System.Windows.Forms.RadioButton();
			this.rbstandard = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cblavanderia = new System.Windows.Forms.CheckBox();
			this.cbestacionamento = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txthospedagem = new System.Windows.Forms.TextBox();
			this.txtopcionais = new System.Windows.Forms.TextBox();
			this.txtconta = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.btnlimpar = new System.Windows.Forms.Button();
			this.btnproximo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(29, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Qual o CPF do cliente?";
			// 
			// txtcpf
			// 
			this.txtcpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtcpf.Location = new System.Drawing.Point(29, 49);
			this.txtcpf.Name = "txtcpf";
			this.txtcpf.Size = new System.Drawing.Size(181, 26);
			this.txtcpf.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(29, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(263, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Quantos dias ele ficou hospedado?";
			// 
			// txtdias
			// 
			this.txtdias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtdias.Location = new System.Drawing.Point(110, 113);
			this.txtdias.Name = "txtdias";
			this.txtdias.Size = new System.Drawing.Size(100, 26);
			this.txtdias.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbking);
			this.groupBox1.Controls.Add(this.rbsuperluxo);
			this.groupBox1.Controls.Add(this.rbluxo);
			this.groupBox1.Controls.Add(this.rbstandard);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(29, 157);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 125);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de quarto";
			// 
			// rbking
			// 
			this.rbking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbking.Location = new System.Drawing.Point(6, 86);
			this.rbking.Name = "rbking";
			this.rbking.Size = new System.Drawing.Size(163, 24);
			this.rbking.TabIndex = 3;
			this.rbking.TabStop = true;
			this.rbking.Text = "King - R$ 350,00";
			this.rbking.UseVisualStyleBackColor = true;
			// 
			// rbsuperluxo
			// 
			this.rbsuperluxo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbsuperluxo.Location = new System.Drawing.Point(6, 65);
			this.rbsuperluxo.Name = "rbsuperluxo";
			this.rbsuperluxo.Size = new System.Drawing.Size(201, 24);
			this.rbsuperluxo.TabIndex = 2;
			this.rbsuperluxo.TabStop = true;
			this.rbsuperluxo.Text = "Superluxo - R$ 245,00";
			this.rbsuperluxo.UseVisualStyleBackColor = true;
			// 
			// rbluxo
			// 
			this.rbluxo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbluxo.Location = new System.Drawing.Point(6, 46);
			this.rbluxo.Name = "rbluxo";
			this.rbluxo.Size = new System.Drawing.Size(163, 24);
			this.rbluxo.TabIndex = 1;
			this.rbluxo.TabStop = true;
			this.rbluxo.Text = "Luxo - R$ 210,00";
			this.rbluxo.UseVisualStyleBackColor = true;
			// 
			// rbstandard
			// 
			this.rbstandard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbstandard.Location = new System.Drawing.Point(6, 25);
			this.rbstandard.Name = "rbstandard";
			this.rbstandard.Size = new System.Drawing.Size(186, 24);
			this.rbstandard.TabIndex = 0;
			this.rbstandard.TabStop = true;
			this.rbstandard.Text = "Standard - R$ 150,00";
			this.rbstandard.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cblavanderia);
			this.groupBox2.Controls.Add(this.cbestacionamento);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(320, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(292, 79);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opcionais";
			// 
			// cblavanderia
			// 
			this.cblavanderia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cblavanderia.Location = new System.Drawing.Point(6, 47);
			this.cblavanderia.Name = "cblavanderia";
			this.cblavanderia.Size = new System.Drawing.Size(191, 24);
			this.cblavanderia.TabIndex = 1;
			this.cblavanderia.Text = "Lavanderia - R$ 21,00";
			this.cblavanderia.UseVisualStyleBackColor = true;
			// 
			// cbestacionamento
			// 
			this.cbestacionamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbestacionamento.Location = new System.Drawing.Point(7, 26);
			this.cbestacionamento.Name = "cbestacionamento";
			this.cbestacionamento.Size = new System.Drawing.Size(222, 24);
			this.cbestacionamento.TabIndex = 0;
			this.cbestacionamento.Text = "Estacionamento - R$ 18,00";
			this.cbestacionamento.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(320, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor da hospedagem:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(320, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(167, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Valor dos opcionais:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(320, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Valor da conta:";
			// 
			// txthospedagem
			// 
			this.txthospedagem.Enabled = false;
			this.txthospedagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txthospedagem.Location = new System.Drawing.Point(497, 157);
			this.txthospedagem.Name = "txthospedagem";
			this.txthospedagem.Size = new System.Drawing.Size(125, 26);
			this.txthospedagem.TabIndex = 9;
			// 
			// txtopcionais
			// 
			this.txtopcionais.Enabled = false;
			this.txtopcionais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtopcionais.Location = new System.Drawing.Point(481, 189);
			this.txtopcionais.Name = "txtopcionais";
			this.txtopcionais.Size = new System.Drawing.Size(100, 26);
			this.txtopcionais.TabIndex = 10;
			// 
			// txtconta
			// 
			this.txtconta.Enabled = false;
			this.txtconta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtconta.Location = new System.Drawing.Point(449, 222);
			this.txtconta.Name = "txtconta";
			this.txtconta.Size = new System.Drawing.Size(100, 26);
			this.txtconta.TabIndex = 11;
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btncalcular.Location = new System.Drawing.Point(351, 98);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(107, 29);
			this.btncalcular.TabIndex = 12;
			this.btncalcular.Text = "Calcular";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// btnlimpar
			// 
			this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnlimpar.Location = new System.Drawing.Point(512, 98);
			this.btnlimpar.Name = "btnlimpar";
			this.btnlimpar.Size = new System.Drawing.Size(84, 29);
			this.btnlimpar.TabIndex = 13;
			this.btnlimpar.Text = "Limpar";
			this.btnlimpar.UseVisualStyleBackColor = true;
			this.btnlimpar.Click += new System.EventHandler(this.BtnlimparClick);
			// 
			// btnproximo
			// 
			this.btnproximo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnproximo.Location = new System.Drawing.Point(520, 261);
			this.btnproximo.Name = "btnproximo";
			this.btnproximo.Size = new System.Drawing.Size(115, 29);
			this.btnproximo.TabIndex = 14;
			this.btnproximo.Text = "Próximo";
			this.btnproximo.UseVisualStyleBackColor = true;
			this.btnproximo.Click += new System.EventHandler(this.Button1Click);
			// 
			// FrmHotel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(654, 302);
			this.Controls.Add(this.btnproximo);
			this.Controls.Add(this.btnlimpar);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtconta);
			this.Controls.Add(this.txtopcionais);
			this.Controls.Add(this.txthospedagem);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtdias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtcpf);
			this.Controls.Add(this.label1);
			this.Name = "FrmHotel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hotel Gran Verano";
			this.Shown += new System.EventHandler(this.FrmHotelShown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnproximo;
		private System.Windows.Forms.Button btnlimpar;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.TextBox txtconta;
		private System.Windows.Forms.TextBox txtopcionais;
		private System.Windows.Forms.TextBox txthospedagem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbestacionamento;
		private System.Windows.Forms.CheckBox cblavanderia;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbstandard;
		private System.Windows.Forms.RadioButton rbluxo;
		private System.Windows.Forms.RadioButton rbsuperluxo;
		private System.Windows.Forms.RadioButton rbking;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtdias;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtcpf;
		private System.Windows.Forms.Label label1;
	}
}
