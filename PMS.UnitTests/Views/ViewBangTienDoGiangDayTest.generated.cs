﻿
/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file ViewBangTienDoGiangDayTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewBangTienDoGiangDay"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewBangTienDoGiangDayTest
    {
    	// the ViewBangTienDoGiangDay instance used to test the repository.
		private ViewBangTienDoGiangDay mock;
		
		// the VList<ViewBangTienDoGiangDay> instance used to test the repository.
		private VList<ViewBangTienDoGiangDay> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewBangTienDoGiangDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewBangTienDoGiangDay objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewBangTienDoGiangDayProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewBangTienDoGiangDayProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewBangTienDoGiangDay objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewBangTienDoGiangDayProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewBangTienDoGiangDayProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewBangTienDoGiangDay entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewBangTienDoGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewBangTienDoGiangDay)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewBangTienDoGiangDay entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewBangTienDoGiangDay.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewBangTienDoGiangDay)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewBangTienDoGiangDay) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewBangTienDoGiangDay collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewBangTienDoGiangDayCollection.xml";
		
			VList<ViewBangTienDoGiangDay> mockCollection = new VList<ViewBangTienDoGiangDay>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewBangTienDoGiangDay>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewBangTienDoGiangDay> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewBangTienDoGiangDay collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewBangTienDoGiangDayCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewBangTienDoGiangDay>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewBangTienDoGiangDay> mockCollection = (VList<ViewBangTienDoGiangDay>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewBangTienDoGiangDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewBangTienDoGiangDay Entity with mock values.
		///</summary>
		static public ViewBangTienDoGiangDay CreateMockInstance()
		{		
			ViewBangTienDoGiangDay mock = new ViewBangTienDoGiangDay();
						
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(20, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(20, false);;
			mock.MaLop = TestUtility.Instance.RandomString(20, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(20, false);;
			mock.HocKy = TestUtility.Instance.RandomString(20, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(20, false);;
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(10, false);;
			mock.PhanLoai = TestUtility.Instance.RandomString(24, false);;
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.Nhom = TestUtility.Instance.RandomString(20, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.LyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucHanh = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTap = (decimal)TestUtility.Instance.RandomShort();
			mock.BaiTapLon = (decimal)TestUtility.Instance.RandomShort();
			mock.DoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.LuanAn = (decimal)TestUtility.Instance.RandomShort();
			mock.TieuLuan = (decimal)TestUtility.Instance.RandomShort();
			mock.ThucTap = (decimal)TestUtility.Instance.RandomShort();
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.NgayBatDau = TestUtility.Instance.RandomDateTime();
			mock.NgayKetThuc = TestUtility.Instance.RandomDateTime();
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.TenBuoiHoc = TestUtility.Instance.RandomString(24, false);;
			mock.ThoiGianHoc = TestUtility.Instance.RandomString(19, false);;
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			mock.RowIndex = TestUtility.Instance.RandomNumber();
		   return (ViewBangTienDoGiangDay)mock;
		}
		

		#endregion
    }
}
