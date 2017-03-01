﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewChiTietGiangVienTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewChiTietGiangVien"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewChiTietGiangVienTest
    {
    	// the ViewChiTietGiangVien instance used to test the repository.
		private ViewChiTietGiangVien mock;
		
		// the VList<ViewChiTietGiangVien> instance used to test the repository.
		private VList<ViewChiTietGiangVien> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewChiTietGiangVien Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewChiTietGiangVien objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietGiangVienProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewChiTietGiangVienProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewChiTietGiangVien objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietGiangVienProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewChiTietGiangVienProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewChiTietGiangVien entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietGiangVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietGiangVien)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewChiTietGiangVien entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietGiangVien.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietGiangVien)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewChiTietGiangVien) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewChiTietGiangVien collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietGiangVienCollection.xml";
		
			VList<ViewChiTietGiangVien> mockCollection = new VList<ViewChiTietGiangVien>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietGiangVien>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewChiTietGiangVien> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewChiTietGiangVien collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietGiangVienCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietGiangVien>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewChiTietGiangVien> mockCollection = (VList<ViewChiTietGiangVien>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewChiTietGiangVien> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewChiTietGiangVien Entity with mock values.
		///</summary>
		static public ViewChiTietGiangVien CreateMockInstance()
		{		
			ViewChiTietGiangVien mock = new ViewChiTietGiangVien();
						
			mock.MaGiangVien = TestUtility.Instance.RandomString(20, false);;
			mock.MatKhau = TestUtility.Instance.RandomString(24, false);;
			mock.TenTinhTrang = TestUtility.Instance.RandomString(99, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.GioiTinh = TestUtility.Instance.RandomString(3, false);;
			mock.NgaySinh = TestUtility.Instance.RandomString(10, false);;
			mock.NoiSinh = TestUtility.Instance.RandomString(99, false);;
			mock.Cmnd = TestUtility.Instance.RandomString(20, false);;
			mock.NgayCap = TestUtility.Instance.RandomString(10, false);;
			mock.NoiCap = TestUtility.Instance.RandomString(99, false);;
			mock.TenDanToc = TestUtility.Instance.RandomString(49, false);;
			mock.TenTonGiao = TestUtility.Instance.RandomString(49, false);;
			mock.DoanDang = TestUtility.Instance.RandomString(5, false);;
			mock.NgayVaoDoanDang = TestUtility.Instance.RandomString(10, false);;
			mock.ThuongTru = TestUtility.Instance.RandomString(99, false);;
			mock.DiaChi = TestUtility.Instance.RandomString(99, false);;
			mock.SoDiDong = TestUtility.Instance.RandomString(20, false);;
			mock.DienThoai = TestUtility.Instance.RandomString(20, false);;
			mock.SoSoBaoHiem = TestUtility.Instance.RandomString(24, false);;
			mock.Email = TestUtility.Instance.RandomString(24, false);;
			mock.SoTaiKhoan = TestUtility.Instance.RandomString(24, false);;
			mock.MaSoThue = TestUtility.Instance.RandomString(20, false);;
			mock.TenNganHang = TestUtility.Instance.RandomString(49, false);;
			mock.TenHocHam = TestUtility.Instance.RandomString(99, false);;
			mock.TenHocVi = TestUtility.Instance.RandomString(99, false);;
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.NgayKyHopDong = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThucHopDong = TestUtility.Instance.RandomDateTime();
			mock.TenKhoa = TestUtility.Instance.RandomString(126, false);;
			mock.ChuyenNganh = TestUtility.Instance.RandomString(499, false);;
			mock.MaHeSoThuLao = TestUtility.Instance.RandomString(20, false);;
			mock.NoiLamViec = TestUtility.Instance.RandomString(49, false);;
			mock.NamLamViec = TestUtility.Instance.RandomString(10, false);;
			mock.BacLuong = (decimal)TestUtility.Instance.RandomShort();
		   return (ViewChiTietGiangVien)mock;
		}
		

		#endregion
    }
}
