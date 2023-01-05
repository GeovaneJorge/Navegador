using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
	public partial class Browser : Form
	{
		string home = null;
		public Browser()
		{
			InitializeComponent();
		}
		private void navegar()
		{
			if (tb_url.Text != "")
			{
				webBrowser1.Navigate(tb_url.Text);
			}
			else
			{
				MessageBox.Show("Digite uma url");
				tb_url.Focus();
			}
		}
		

		private void button1_Click(object sender, EventArgs e)
		{
			
				navegar();
			
			
		}

		private void btn_home_Click(object sender, EventArgs e)
		{
			if(home== null)
			{
				webBrowser1.GoHome();
			} 
			else
			{
				webBrowser1.Navigate(home);
			}

		}
			
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void tb_url_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				navegar();
			}
		}

		private void btn_parar_Click(object sender, EventArgs e)
		{
			webBrowser1.Stop();
		}

		private void btn_voltar_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		private void btn_proximo_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
		{
			btn_proximo.Enabled = webBrowser1.CanGoForward;
		}

		private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
		{
			btn_voltar.Enabled = webBrowser1.CanGoBack;
		}

		private void btn_atualizar_Click(object sender, EventArgs e)
		{
			webBrowser1.Refresh();
		}

		private void btn_pesquisar_Click(object sender, EventArgs e)
		{
			webBrowser1.GoSearch();
		}

		private void btn_definirhome_Click(object sender, EventArgs e)
		{
			home = tb_url.Text;
		}
	}
}
