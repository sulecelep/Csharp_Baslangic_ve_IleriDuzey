using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_189_GenericClass_Kullanimi
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*
			 * Database | Uygulama 
			 * MSSQL       C#
			 * 
			 * tblMusteri
			 * id int
			 * musteriNumara uniqueidentify (Guid)
			 * isim nvarchar string
			 * soyisim nvarchar string
			 * dogumTarih datetime datetime
			 * 
			 * UnitOfWork => Generic Class | Generic Interface
			 * 
			 */
			GenericRepository<Musteri> repositoryMusteri = new GenericRepository<Musteri>();
			List<Musteri> musterilerim = repositoryMusteri.Getir();

			GenericRepository<Urun> reporsitoryUrun = new GenericRepository<Urun>();
			reporsitoryUrun.Getir();

			repositoryMusteri.yeniKayitEkle(null);
			reporsitoryUrun.yeniKayitEkle(null);
		}
	}
}
