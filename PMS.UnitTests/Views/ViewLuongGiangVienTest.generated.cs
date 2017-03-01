﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewLuongGiangVienTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="ViewLuongGiangVien"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewLuongGiangVienTest
    {
    	// the ViewLuongGiangVien instance used to test the repository.
		private ViewLuongGiangVien mock;
		
		// the VList<ViewLuongGiangVien> instance used to test the repository.
		private VList<ViewLuongGiangVien> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewLuongGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {       	
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
		
		/// <summary>
		/// Selects a page of ViewLuongGiangVien objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewLuongGiangVienProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewLuongGiangVienProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewLuongGiangVien objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewLuongGiangVienProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewLuongGiangVienProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewLuongGiangVien entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewLuongGiangVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewLuongGiangVien)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewLuongGiangVien entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewLuongGiangVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewLuongGiangVien)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewLuongGiangVien) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewLuongGiangVien collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewLuongGiangVienCollection.xml";
		
			VList<ViewLuongGiangVien> mockCollection = new VList<ViewLuongGiangVien>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewLuongGiangVien>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewLuongGiangVien> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewLuongGiangVien collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewLuongGiangVienCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewLuongGiangVien>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewLuongGiangVien> mockCollection = (VList<ViewLuongGiangVien>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewLuongGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewLuongGiangVien Entity with mock values.
		///</summary>
		static public ViewLuongGiangVien CreateMockInstance()
		{		
			ViewLuongGiangVien mock = new ViewLuongGiangVien();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.SoTaiKhoan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(20, false);;
			mock.TenLop = TestUtility.Instance.RandomString(49, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(20, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.SoTien = TestUtility.Instance.RandomShort();
			mock.ThanhTien = TestUtility.Instance.RandomShort();
			mock.TongTien = TestUtility.Instance.RandomShort();
			mock.ThueTncn = TestUtility.Instance.RandomShort();
			mock.TienThucNhan = TestUtility.Instance.RandomShort();
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(20, false);;
			mock.MaHeDaoTao = TestUtility.Instance.RandomString(20, false);;
			mock.MaVaiTroGiangDay = TestUtility.Instance.RandomString(20, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(20, false);;
		   return (ViewLuongGiangVien)mock;
		}
		

		#endregion
    }
}
