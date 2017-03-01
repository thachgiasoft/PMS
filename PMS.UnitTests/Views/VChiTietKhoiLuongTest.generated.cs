﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file VChiTietKhoiLuongTest.cs instead.
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
    /// Provides tests for the and <see cref="VChiTietKhoiLuong"/> objects (entity, collection and repository).
    /// </summary>
    public partial class VChiTietKhoiLuongTest
    {
    	// the VChiTietKhoiLuong instance used to test the repository.
		private VChiTietKhoiLuong mock;
		
		// the VList<VChiTietKhoiLuong> instance used to test the repository.
		private VList<VChiTietKhoiLuong> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the VChiTietKhoiLuong Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of VChiTietKhoiLuong objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VChiTietKhoiLuongProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.VChiTietKhoiLuongProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some VChiTietKhoiLuong objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.VChiTietKhoiLuongProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.VChiTietKhoiLuongProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock VChiTietKhoiLuong entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_VChiTietKhoiLuong.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VChiTietKhoiLuong)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock VChiTietKhoiLuong entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_VChiTietKhoiLuong.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VChiTietKhoiLuong)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (VChiTietKhoiLuong) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a VChiTietKhoiLuong collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_VChiTietKhoiLuongCollection.xml";
		
			VList<VChiTietKhoiLuong> mockCollection = new VList<VChiTietKhoiLuong>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VChiTietKhoiLuong>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<VChiTietKhoiLuong> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a VChiTietKhoiLuong collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_VChiTietKhoiLuongCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<VChiTietKhoiLuong>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<VChiTietKhoiLuong> mockCollection = (VList<VChiTietKhoiLuong>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<VChiTietKhoiLuong> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed VChiTietKhoiLuong Entity with mock values.
		///</summary>
		static public VChiTietKhoiLuong CreateMockInstance()
		{		
			VChiTietKhoiLuong mock = new VChiTietKhoiLuong();
						
			mock.MaKetQua = TestUtility.Instance.RandomNumber();
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.HoTen = TestUtility.Instance.RandomString(75, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.TrongGio = (decimal)TestUtility.Instance.RandomShort();
			mock.NgoaiGio = (decimal)TestUtility.Instance.RandomShort();
			mock.TietDoAn = (decimal)TestUtility.Instance.RandomShort();
			mock.ChatLuongCao = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.PhanLoai = TestUtility.Instance.RandomString(24, false);;
			mock.LoaiHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TietNghiaVu = TestUtility.Instance.RandomNumber();
			mock.TietGioiHan = TestUtility.Instance.RandomNumber();
		   return (VChiTietKhoiLuong)mock;
		}
		

		#endregion
    }
}