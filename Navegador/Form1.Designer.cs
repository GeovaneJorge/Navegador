
namespace Navegador
{
	partial class Browser
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.tb_url = new System.Windows.Forms.TextBox();
			this.btn_ir = new System.Windows.Forms.Button();
			this.btn_home = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_proximo = new System.Windows.Forms.Button();
			this.btn_parar = new System.Windows.Forms.Button();
			this.btn_atualizar = new System.Windows.Forms.Button();
			this.btn_pesquisar = new System.Windows.Forms.Button();
			this.btn_definirhome = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(12, 102);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(723, 511);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// tb_url
			// 
			this.tb_url.Location = new System.Drawing.Point(12, 76);
			this.tb_url.Name = "tb_url";
			this.tb_url.Size = new System.Drawing.Size(719, 20);
			this.tb_url.TabIndex = 1;
			this.tb_url.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
			// 
			// btn_ir
			// 
			this.btn_ir.Image = ((System.Drawing.Image)(resources.GetObject("btn_ir.Image")));
			this.btn_ir.Location = new System.Drawing.Point(12, 37);
			this.btn_ir.Name = "btn_ir";
			this.btn_ir.Size = new System.Drawing.Size(84, 33);
			this.btn_ir.TabIndex = 2;
			this.btn_ir.UseVisualStyleBackColor = true;
			this.btn_ir.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_home
			// 
			this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
			this.btn_home.Location = new System.Drawing.Point(102, 38);
			this.btn_home.Name = "btn_home";
			this.btn_home.Size = new System.Drawing.Size(76, 32);
			this.btn_home.TabIndex = 3;
			this.btn_home.UseVisualStyleBackColor = true;
			this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
			// 
			// btn_voltar
			// 
			this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
			this.btn_voltar.Location = new System.Drawing.Point(193, 38);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(76, 32);
			this.btn_voltar.TabIndex = 4;
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
			// 
			// btn_proximo
			// 
			this.btn_proximo.Image = ((System.Drawing.Image)(resources.GetObject("btn_proximo.Image")));
			this.btn_proximo.Location = new System.Drawing.Point(285, 37);
			this.btn_proximo.Name = "btn_proximo";
			this.btn_proximo.Size = new System.Drawing.Size(75, 33);
			this.btn_proximo.TabIndex = 5;
			this.btn_proximo.UseVisualStyleBackColor = true;
			this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
			// 
			// btn_parar
			// 
			this.btn_parar.Image = ((System.Drawing.Image)(resources.GetObject("btn_parar.Image")));
			this.btn_parar.Location = new System.Drawing.Point(366, 38);
			this.btn_parar.Name = "btn_parar";
			this.btn_parar.Size = new System.Drawing.Size(74, 32);
			this.btn_parar.TabIndex = 6;
			this.btn_parar.UseVisualStyleBackColor = true;
			this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
			// 
			// btn_atualizar
			// 
			this.btn_atualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.Image")));
			this.btn_atualizar.Location = new System.Drawing.Point(464, 38);
			this.btn_atualizar.Name = "btn_atualizar";
			this.btn_atualizar.Size = new System.Drawing.Size(79, 32);
			this.btn_atualizar.TabIndex = 7;
			this.btn_atualizar.UseVisualStyleBackColor = true;
			this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
			// 
			// btn_pesquisar
			// 
			this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
			this.btn_pesquisar.Location = new System.Drawing.Point(562, 38);
			this.btn_pesquisar.Name = "btn_pesquisar";
			this.btn_pesquisar.Size = new System.Drawing.Size(78, 32);
			this.btn_pesquisar.TabIndex = 8;
			this.btn_pesquisar.UseVisualStyleBackColor = true;
			this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
			// 
			// btn_definirhome
			// 
			this.btn_definirhome.Image = ((System.Drawing.Image)(resources.GetObject("btn_definirhome.Image")));
			this.btn_definirhome.Location = new System.Drawing.Point(656, 38);
			this.btn_definirhome.Name = "btn_definirhome";
			this.btn_definirhome.Size = new System.Drawing.Size(75, 32);
			this.btn_definirhome.TabIndex = 9;
			this.btn_definirhome.UseVisualStyleBackColor = true;
			this.btn_definirhome.Click += new System.EventHandler(this.btn_definirhome_Click);
			// 
			// Browser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 615);
			this.Controls.Add(this.btn_definirhome);
			this.Controls.Add(this.btn_pesquisar);
			this.Controls.Add(this.btn_atualizar);
			this.Controls.Add(this.btn_parar);
			this.Controls.Add(this.btn_proximo);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_home);
			this.Controls.Add(this.btn_ir);
			this.Controls.Add(this.tb_url);
			this.Controls.Add(this.webBrowser1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Browser";
			this.Text = "Developer Geovane Versão 1.0.1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.TextBox tb_url;
		private System.Windows.Forms.Button btn_ir;
		private System.Windows.Forms.Button btn_home;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_proximo;
		private System.Windows.Forms.Button btn_parar;
		private System.Windows.Forms.Button btn_atualizar;
		private System.Windows.Forms.Button btn_pesquisar;
		private System.Windows.Forms.Button btn_definirhome;
	}
}

