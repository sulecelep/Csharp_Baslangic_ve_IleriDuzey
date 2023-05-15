using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_129_OOP_Kapsulleme_VerileriKapsulleme3_AraOdev
{
	internal class Musteri
	{
		/*
		 * Ara Odev
		 * Musteri sınıfının içerisine _tckimliknumarasi adında bir
		 * private field tanımı yapalım ve aşağıdaki kurallara göre 
		 * kapsülleme işlemlerini gerçekleştirelim.
		 * 
		 * Set
		 * Girilen değer 11 haneli olmalı
		 * Girilen değer içerisindeki tüm değerler sayısal değer olmak
		 * zorundadır.
		 * 
		 * Get
		 * Öncelikle değer okunamaz şekilde ayarlansın.
		 * İlk 3  hanesini gösterelim.
		 * 
		 */
		
		private string _tckimliknumarasi;
		public string TCKimlikNumarasi
		{
			//private get {  return _tckimliknumarasi;} //değer okunamaz yapar
			get
			{
				return _tckimliknumarasi.Substring(0, 3);
			}

			set 
			{ 
				if(value.Length==11)
				{
					bool bayrak = false;
					for(int i=0; i<value.Length; i++)
					{
						bool karakterKontrol = char.IsNumber(value[i]);
						if(karakterKontrol)
						{
							//sayısal karakterdir
						}
						else
						{
							bayrak = true;
							break;
						}
					}
					if(bayrak)
					{
                        Console.WriteLine("TC KimlikNumarası içindeki değerler sayısal olmalıdır.");
                    }
				}
				else
				{
                    Console.WriteLine("TC Kimlik Numarası 11 haneli olmalıdır.");
                }

			}
		}
	}
}
