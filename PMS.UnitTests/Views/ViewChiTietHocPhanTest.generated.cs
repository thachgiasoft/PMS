﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewChiTietHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewChiTietHocPhan"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewChiTietHocPhanTest
    {
    	// the ViewChiTietHocPhan instance used to test the repository.
		private ViewChiTietHocPhan mock;
		
		// the VList<ViewChiTietHocPhan> instance used to test the repository.
		private VList<ViewChiTietHocPhan> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewChiTietHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewChiTietHocPhan objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietHocPhanProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewChiTietHocPhanProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewChiTietHocPhan objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewChiTietHocPhanProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewChiTietHocPhanProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewChiTietHocPhan entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietHocPhan)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewChiTietHocPhan entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewChiTietHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewChiTietHocPhan)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewChiTietHocPhan) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewChiTietHocPhan collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietHocPhanCollection.xml";
		
			VList<ViewChiTietHocPhan> mockCollection = new VList<ViewChiTietHocPhan>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietHocPhan>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewChiTietHocPhan> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewChiTietHocPhan collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewChiTietHocPhanCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewChiTietHocPhan>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewChiTietHocPhan> mockCollection = (VList<ViewChiTietHocPhan>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewChiTietHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewChiTietHocPhan Entity with mock values.
		///</summary>
		static public ViewChiTietHocPhan CreateMockInstance()
		{		
			ViewChiTietHocPhan mock = new ViewChiTietHocPhan();
						
			mock.MaLichHoc = TestUtility.Instance.RandomNumber();
			mock.MaGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(249, false);;
			mock.SoTinChi = (decimal)TestUtility.Instance.RandomShort();
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.MaLoaiHocPhan = TestUtility.Instance.RandomByte();
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(10, false);;
			mock.Nam = TestUtility.Instance.RandomNumber();
			mock.Tuan = TestUtility.Instance.RandomNumber();
			mock.MaPhong = TestUtility.Instance.RandomString(9, false);;
			mock.MaToaNha = TestUtility.Instance.RandomString(9, false);;
			mock.DonViTinh = TestUtility.Instance.RandomString(10, false);;
			mock.MaCoSo = TestUtility.Instance.RandomString(9, false);;
			mock.MaBuoiHoc = TestUtility.Instance.RandomNumber();
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.TietBatDau = TestUtility.Instance.RandomNumber();
			mock.SoTiet = TestUtility.Instance.RandomNumber();
			mock.LoaiHocKy = TestUtility.Instance.RandomByte();
			mock.HeSoCoSo = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.TinhTrang = TestUtility.Instance.RandomNumber();
		   return (ViewChiTietHocPhan)mock;
		}
		

		#endregion
    }
}
