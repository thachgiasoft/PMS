﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThongTinChiTietGiangVienChoDuyetHoSoTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewThongTinChiTietGiangVienChoDuyetHoSo"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThongTinChiTietGiangVienChoDuyetHoSoTest
    {
    	// the ViewThongTinChiTietGiangVienChoDuyetHoSo instance used to test the repository.
		private ViewThongTinChiTietGiangVienChoDuyetHoSo mock;
		
		// the VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> instance used to test the repository.
		private VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThongTinChiTietGiangVienChoDuyetHoSo Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewThongTinChiTietGiangVienChoDuyetHoSo objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThongTinChiTietGiangVienChoDuyetHoSo objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThongTinChiTietGiangVienChoDuyetHoSoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThongTinChiTietGiangVienChoDuyetHoSo entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThongTinChiTietGiangVienChoDuyetHoSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongTinChiTietGiangVienChoDuyetHoSo)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThongTinChiTietGiangVienChoDuyetHoSo entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThongTinChiTietGiangVienChoDuyetHoSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongTinChiTietGiangVienChoDuyetHoSo)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThongTinChiTietGiangVienChoDuyetHoSo) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThongTinChiTietGiangVienChoDuyetHoSo collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThongTinChiTietGiangVienChoDuyetHoSoCollection.xml";
		
			VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> mockCollection = new VList<ViewThongTinChiTietGiangVienChoDuyetHoSo>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongTinChiTietGiangVienChoDuyetHoSo>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThongTinChiTietGiangVienChoDuyetHoSo collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThongTinChiTietGiangVienChoDuyetHoSoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongTinChiTietGiangVienChoDuyetHoSo>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> mockCollection = (VList<ViewThongTinChiTietGiangVienChoDuyetHoSo>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThongTinChiTietGiangVienChoDuyetHoSo> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThongTinChiTietGiangVienChoDuyetHoSo Entity with mock values.
		///</summary>
		static public ViewThongTinChiTietGiangVienChoDuyetHoSo CreateMockInstance()
		{		
			ViewThongTinChiTietGiangVienChoDuyetHoSo mock = new ViewThongTinChiTietGiangVienChoDuyetHoSo();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(24, false);;
			mock.TenDem = TestUtility.Instance.RandomString(24, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTenDem = TestUtility.Instance.RandomString(49, false);;
			mock.NgaySinh = TestUtility.Instance.RandomString(10, false);;
			mock.GioiTinh = TestUtility.Instance.RandomBoolean();
			mock.TenGioiTinh = TestUtility.Instance.RandomString(3, false);;
			mock.NoiSinh = TestUtility.Instance.RandomString(99, false);;
			mock.Cmnd = TestUtility.Instance.RandomString(9, false);;
			mock.NgayCap = TestUtility.Instance.RandomString(10, false);;
			mock.NoiCap = TestUtility.Instance.RandomString(99, false);;
			mock.DoanDang = TestUtility.Instance.RandomBoolean();
			mock.NgayVaoDoanDang = TestUtility.Instance.RandomString(10, false);;
			mock.NgayKyHopDong = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThucHopDong = TestUtility.Instance.RandomDateTime();
			mock.HinhAnh = new byte[] { TestUtility.Instance.RandomByte() };
			mock.DiaChi = TestUtility.Instance.RandomString(99, false);;
			mock.ThuongTru = TestUtility.Instance.RandomString(99, false);;
			mock.NoiLamViec = TestUtility.Instance.RandomString(49, false);;
			mock.Email = TestUtility.Instance.RandomString(24, false);;
			mock.DienThoai = TestUtility.Instance.RandomString(9, false);;
			mock.SoDiDong = TestUtility.Instance.RandomString(9, false);;
			mock.SoTaiKhoan = TestUtility.Instance.RandomString(24, false);;
			mock.TenNganHang = TestUtility.Instance.RandomString(49, false);;
			mock.MaSoThue = TestUtility.Instance.RandomString(9, false);;
			mock.ChiNhanh = TestUtility.Instance.RandomString(49, false);;
			mock.SoSoBaoHiem = TestUtility.Instance.RandomString(24, false);;
			mock.ThoiGianBatDau = TestUtility.Instance.RandomString(24, false);;
			mock.BacLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayHuongLuong = TestUtility.Instance.RandomString(9, false);;
			mock.NamLamViec = TestUtility.Instance.RandomString(10, false);;
			mock.ChuyenNganh = TestUtility.Instance.RandomString(499, false);;
			mock.MaHeSoThuLao = TestUtility.Instance.RandomString(9, false);;
			mock.MaDanToc = TestUtility.Instance.RandomString(9, false);;
			mock.TenDanToc = TestUtility.Instance.RandomString(49, false);;
			mock.MaTonGiao = TestUtility.Instance.RandomString(9, false);;
			mock.TenTonGiao = TestUtility.Instance.RandomString(49, false);;
			mock.MaDonVi = TestUtility.Instance.RandomString(9, false);;
			mock.TenDonVi = TestUtility.Instance.RandomString(126, false);;
			mock.MaHocHam = TestUtility.Instance.RandomString(9, false);;
			mock.TenHocHam = TestUtility.Instance.RandomString(99, false);;
			mock.MaHocVi = TestUtility.Instance.RandomString(9, false);;
			mock.TenHocVi = TestUtility.Instance.RandomString(99, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.TenLoaiGiangVien = TestUtility.Instance.RandomString(49, false);;
			mock.TenDangNhap = TestUtility.Instance.RandomString(6, false);;
			mock.TenMayTinh = TestUtility.Instance.RandomString(49, false);;
			mock.MatKhau = TestUtility.Instance.RandomString(24, false);;
			mock.MaTinhTrang = TestUtility.Instance.RandomString(9, false);;
			mock.TenTinhTrang = TestUtility.Instance.RandomString(99, false);;
			mock.DaDuyet = TestUtility.Instance.RandomBoolean();
		   return (ViewThongTinChiTietGiangVienChoDuyetHoSo)mock;
		}
		

		#endregion
    }
}
