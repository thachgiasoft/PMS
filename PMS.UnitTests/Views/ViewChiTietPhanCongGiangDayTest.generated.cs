﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewChiTietPhanCongGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewChiTietPhanCongGiangDay"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewChiTietPhanCongGiangDayTest
    {
    	// the ViewChiTietPhanCongGiangDay instance used to test the repository.
		private ViewChiTietPhanCongGiangDay mock;
		
		// the VList<ViewChiTietPhanCongGiangDay> instance used to test the repository.
		private VList<ViewChiTietPhanCongGiangDay> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewChiTietPhanCongGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewChiTietPhanCongGiangDay objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietPhanCongGiangDayProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewChiTietPhanCongGiangDayProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewChiTietPhanCongGiangDay objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietPhanCongGiangDayProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewChiTietPhanCongGiangDayProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewChiTietPhanCongGiangDay entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietPhanCongGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietPhanCongGiangDay)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewChiTietPhanCongGiangDay entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietPhanCongGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietPhanCongGiangDay)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewChiTietPhanCongGiangDay) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewChiTietPhanCongGiangDay collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietPhanCongGiangDayCollection.xml";
		
			VList<ViewChiTietPhanCongGiangDay> mockCollection = new VList<ViewChiTietPhanCongGiangDay>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietPhanCongGiangDay>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewChiTietPhanCongGiangDay> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewChiTietPhanCongGiangDay collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietPhanCongGiangDayCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietPhanCongGiangDay>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewChiTietPhanCongGiangDay> mockCollection = (VList<ViewChiTietPhanCongGiangDay>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewChiTietPhanCongGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewChiTietPhanCongGiangDay Entity with mock values.
		///</summary>
		static public ViewChiTietPhanCongGiangDay CreateMockInstance()
		{		
			ViewChiTietPhanCongGiangDay mock = new ViewChiTietPhanCongGiangDay();
						
			mock.MaLhpGoc = TestUtility.Instance.RandomString(14, false);;
			mock.MaLhp = TestUtility.Instance.RandomString(14, false);;
			mock.MaHp = TestUtility.Instance.RandomString(9, false);;
			mock.TenLhp = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaNhom = TestUtility.Instance.RandomString(9, false);;
			mock.TenNhom = TestUtility.Instance.RandomString(126, false);;
			mock.TenLoaiHp = TestUtility.Instance.RandomString(49, false);;
			mock.MaLich = TestUtility.Instance.RandomNumber();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.TuanHienThi = TestUtility.Instance.RandomNumber();
			mock.MaNgayTrongTuan = TestUtility.Instance.RandomNumber();
			mock.NgayTrongTuan = TestUtility.Instance.RandomString(49, false);;
			mock.MaTiet = TestUtility.Instance.RandomNumber();
			mock.KhoanTiet = TestUtility.Instance.RandomString(9, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.MaPhong = TestUtility.Instance.RandomString(9, false);;
			mock.TenPhong = TestUtility.Instance.RandomString(24, false);;
			mock.NgayDay = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(300, false);;
			mock.DanhSachLop = TestUtility.Instance.RandomString(126, false);;
		   return (ViewChiTietPhanCongGiangDay)mock;
		}
		

		#endregion
    }
}
