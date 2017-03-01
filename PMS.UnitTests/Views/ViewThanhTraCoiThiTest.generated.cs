﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThanhTraCoiThiTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewThanhTraCoiThi"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThanhTraCoiThiTest
    {
    	// the ViewThanhTraCoiThi instance used to test the repository.
		private ViewThanhTraCoiThi mock;
		
		// the VList<ViewThanhTraCoiThi> instance used to test the repository.
		private VList<ViewThanhTraCoiThi> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThanhTraCoiThi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewThanhTraCoiThi objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThanhTraCoiThiProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThanhTraCoiThiProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThanhTraCoiThi objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThanhTraCoiThiProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThanhTraCoiThiProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThanhTraCoiThi entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThanhTraCoiThi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThanhTraCoiThi)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThanhTraCoiThi entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThanhTraCoiThi.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThanhTraCoiThi)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThanhTraCoiThi) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThanhTraCoiThi collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThanhTraCoiThiCollection.xml";
		
			VList<ViewThanhTraCoiThi> mockCollection = new VList<ViewThanhTraCoiThi>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThanhTraCoiThi>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThanhTraCoiThi> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThanhTraCoiThi collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThanhTraCoiThiCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThanhTraCoiThi>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThanhTraCoiThi> mockCollection = (VList<ViewThanhTraCoiThi>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThanhTraCoiThi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThanhTraCoiThi Entity with mock values.
		///</summary>
		static public ViewThanhTraCoiThi CreateMockInstance()
		{		
			ViewThanhTraCoiThi mock = new ViewThanhTraCoiThi();
						
			mock.Examination = TestUtility.Instance.RandomNumber();
			mock.MaCanBoCoiThi = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.NgayThi = TestUtility.Instance.RandomString(10, false);;
			mock.ThoiGianBatDau = TestUtility.Instance.RandomString(10, false);;
			mock.MaPhong = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.ThoiGianLamBai = TestUtility.Instance.RandomString(24, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.MaLopSinhVien = TestUtility.Instance.RandomString(499, false);;
			mock.SoLuongSinhVien = TestUtility.Instance.RandomNumber();
			mock.TenKhoaChuQuan = TestUtility.Instance.RandomString(126, false);;
			mock.MaViPham = TestUtility.Instance.RandomString(9, false);;
			mock.MaHinhThucViPhamHrm = Guid.NewGuid();
			mock.SiSoThanhTra = TestUtility.Instance.RandomNumber();
			mock.ThoiDiemGhiNhan = TestUtility.Instance.RandomString(249, false);;
			mock.LyDo = TestUtility.Instance.RandomString(499, false);;
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			mock.NgayCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomNumber();
			mock.TuTietDenTiet = TestUtility.Instance.RandomString(7, false);;
			mock.TrangThai = TestUtility.Instance.RandomBoolean();
			mock.XacNhan = TestUtility.Instance.RandomBoolean();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.Lt = TestUtility.Instance.RandomNumber();
			mock.Th = TestUtility.Instance.RandomNumber();
		   return (ViewThanhTraCoiThi)mock;
		}
		

		#endregion
    }
}