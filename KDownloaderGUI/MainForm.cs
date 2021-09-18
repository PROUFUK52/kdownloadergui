/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: Ufcuk
 * Tarih: 18.09.2021
 * Zaman: 22:29
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace KDownloaderGUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			using (var indirici = new WebClient())
			{			
				this.Text = "KDownloader GUI - İndirme İşlemi Sürüyor... | Coded by KaptanUfuk";
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
				indirici.DownloadFile(textBox1.Text.ToString(), "C:\\Users\\"+Environment.UserName+"\\Desktop\\"+textBox2.Text.ToString());
				this.Text = "KDownloader GUI - İndirme İşlemi Sonlandırıldı...";
			}
		}
	}
}
